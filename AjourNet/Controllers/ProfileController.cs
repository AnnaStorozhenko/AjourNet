using AjourNet.Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AjourNet.Controllers
{
    public class ProfileController : Controller
    {

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
                return RedirectToAction("GetProfile");
            }
            else
            {
                ModelState.AddModelError("BootstrapAlertSummary", "Please, enter your credentials"); 
                return View("CreateUserProfile", model);
            }

        }

        // GET: Profile
        public ActionResult GetProfile(/*user id or etc.*/)
        {
            return PartialView();
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