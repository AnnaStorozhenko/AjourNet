using AjourNet.Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AjourNet.Controllers
{
    public class UserProfileController : Controller
    {
        // GET: CreateUserProfile
        public ActionResult CreateUserProfile()
        {
            return View();
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateUserProfile(UserProfileModel model)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("GetUserFeed");
            }
            else
            {
              //  ModelState.AddModelError("","Please, enter your credentials"); 
                
                return View(model);
            }
          
        }

        
        public ActionResult GetUserFeed(UserProfileModel model)
        {
            return View("~\\Views\\Shared\\_Layout.cshtml");
        }
    }
}