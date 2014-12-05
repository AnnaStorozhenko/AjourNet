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
            
            return PartialView(model);
        }

        public ActionResult ViewMyPost()
        {
            UserPostModel post1 = new UserPostModel { PostID = 10, Text = "Hi All, my name is Nick" };
            UserPostModel post2 = new UserPostModel { PostID = 11, Text = "Hi All,I am Nick" };
            List<UserPostModel> users = new List<UserPostModel> { post1, post2 };

            return PartialView("", users);
        }

    }
}