using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AjourNet.Controllers
{
    public class ProfileController : Controller
    {
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