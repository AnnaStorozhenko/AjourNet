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


            return PartialView(profile);
        }

        public ActionResult EditProfile(/*user id or etc.*/)
        {
            return PartialView();
        }

        [HttpPost]
        [ActionName("EditProfile")]
        public ActionResult EditProfileConfirmed(/*ViewModel, Model or Entity*/)
        {
            return PartialView();
        }
    }
}