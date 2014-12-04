using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AjourNet.Controllers
{
    public class UserProfileController : Controller
    {
        // GET: UserProfile
        public ActionResult GetUserProfile()
        {
            return View();
        }
    }
}