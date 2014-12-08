using AjourNet.Domain.Entities;
using AjourNet.Domain.Identity;
using AjourNet.Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AjourNet.Controllers
{
    //[Authorize]
    public class ProfileController : Controller
    {
        static byte[] convertToByte()
        {
            Image img = Image.FromFile(@"D:\xnta.jpg");
            byte[] arr;

            using (MemoryStream stream = new MemoryStream())
            {
                img.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                arr = stream.ToArray();
            }

            return arr;
        }

        List<UserProfileModel> users = new List<UserProfileModel>
            {
                new UserProfileModel{Feed = null, FirstName = "Nazarii", LastName = "Tashak", Location = "LV/G", Motto = "ABC",
                                     Status = Status.Online, Occupation = "Test", UserName = "xnta", AjourNetUser = new AjourNetUser{UserName = "xnta"}, PhoneNumber = "123-456-789", Picture = convertToByte()},
                new UserProfileModel{Feed = null, FirstName = "Adam", LastName = "Adamovich", Location = "LA/W", Motto = "Good day",
                                     Status = Status.BusinessTrip, Occupation = "None", PhoneNumber = "555-12-456", UserName = "adch", AjourNetUser = new AjourNetUser{UserName = "adch"}},
                new UserProfileModel{Feed = null, FirstName = "Alice", LastName = "Jefferson", Location = "WA/A", Motto = "Hello",
                                     Status = Status.Vacation, Occupation = "Guru", PhoneNumber = "435-77-109", UserName = "alje", AjourNetUser = new AjourNetUser{UserName = "alje"}}
            };


        public ProfileController() { }

        // GET: CreateUserProfile
        public ActionResult CreateUserProfile()
        {
            return View("CreateUserProfile");
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateUserProfile(UserProfileModel model)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("GetUserFeed","Feed");
            }
            else
            {
                ModelState.AddModelError("BootstrapAlertSummary", "Please, enter your credentials"); 
                return View("CreateUserProfile", model);
            }

        }

        // GET: Profile
        public ActionResult GetProfile(string id)
        {
            //get info from database

            UserProfileModel user = users.Where(u => u.UserName == id).FirstOrDefault();
            
            return PartialView(user);
        }

        public ActionResult EditProfile(string id)
        {
            //check if user exist
            UserProfileModel user = users.Where(u => u.UserName == id).FirstOrDefault();
            return PartialView(user);
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        [ActionName("EditProfile")]
        public ActionResult EditProfileConfirmed(UserProfileModel user, HttpPostedFileBase file)
        {
            //if(ModelState.IsValid)
            //{ 
            //save info
            UserProfileModel userToEdit = users.Where(u => u.UserName == user.UserName).FirstOrDefault();
            if (userToEdit != null)
            {
                userToEdit.Location = user.Location;
                userToEdit.PhoneNumber = user.PhoneNumber;
                userToEdit.Motto = user.Motto;
            }
            //return GetProfile(id)
            return PartialView("GetProfile",userToEdit);
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public void FileUpload(HttpPostedFileBase file, string id)
        {
            byte[] imageData;

            if (file != null)
            {
                using (Stream inputStream = file.InputStream)
                {
                    MemoryStream ms = inputStream as MemoryStream;
                    if (ms == null)
                    {
                        ms = new MemoryStream();
                        inputStream.CopyTo(ms);
                    }
                    imageData = ms.ToArray();

                    UserProfileModel user = users.Where(u => u.UserName == id).FirstOrDefault();
                    if (user != null)
                    {
                        user.Picture = imageData;
                    }
                }
            }

            //return RedirectToAction("GetUserFeed", "Feed");
        }
    }
}