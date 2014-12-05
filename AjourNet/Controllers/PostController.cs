using AjourNet.Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AjourNet.Controllers
{
    public class PostController : Controller
    {
        // GET: Post
        //public ActionResult CreatePost()
        //{
        //    return View();
        //}

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreatePost(UserPostModel model)
        {
            //if (ModelState.IsValid)
            //{
                return RedirectToAction("GetUserFeed", "Feed");
            //}
            //else
            //{
            //    ModelState.AddModelError("BootstrapAlertSummary", "Please, enter your credentials");
            //    return View("CreateUserProfile", model);
            //}

        }
    }
}