using AjourNet.Domain.Entities;
using AjourNet.Domain.Identity;
using AjourNet.Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AjourNet.Controllers
{
    //[Authorize]
    public class ProfileController : Controller
    {
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
                return RedirectToAction("GetUserFeed","Feed" );
            }
            else
            {
                ModelState.AddModelError("BootstrapAlertSummary", "Please, enter your credentials"); 
                return View("CreateUserProfile", model);
            }

        }

        // GET: Profile
        public ActionResult GetProfile(/*string id*/)
        {
            //get info from database
            AjourNetUser ajourUser = new AjourNetUser
            {
                UserName = "xnta"
            };

            UserProfile user = new UserProfile
            {
                FirstName = "Nazarii",
                LastName = "Tashak",
                AjourNetUser = ajourUser,
                UserProfileID = 1
            };

            UserProfileModel profile = new UserProfileModel(user);

            profile.Occupation = "Junior Software Developer";
            profile.Location = "LV/G";
            profile.Status = Status.Online;
            profile.PhoneNumber = "3346";
            profile.Motto = "To be or not to be";


            return PartialView(profile);
        }

        public ActionResult EditProfile(UserProfileModel user)
        {
            //check if user exist
            return PartialView(user);
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        [ActionName("EditProfile")]
        public ActionResult EditProfileConfirmed(/*ViewModel, Model or Entity*/)
        {
            return PartialView();
        }
    }
}