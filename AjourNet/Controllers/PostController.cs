using AjourNet.Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AjourNet.Domain.Infrastructure;

namespace AjourNet.Controllers
{
    public class PostController : Controller
    {
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreatePost(UserPostModel model)
        {
            ModelState.Clear();
            ViewBag.PostModel = model;
            return PartialView("~/Views/Feed/ViewMyFeed.cshtml");
        }

        public ActionResult ViewMyPost(UserPostModel postModel)
        { 
            UserPostModel post1 = new UserPostModel { PostID = 10, Time = DateTime.Now.ToLocalTimeAzure().Date.AddDays(-1), Text = "Hi All, my name is Nick" };
            UserPostModel post2 = new UserPostModel { PostID = 11, Time = DateTime.Now.ToLocalTimeAzure().AddHours(-4), Text = "Hi All,I am Nick" };
            List<UserPostModel> posts = new List<UserPostModel> { post1, post2 };
            if (postModel != null && postModel.Text != String.Empty && postModel.Text != null)
            {
                posts.Add(postModel);
            }
            return PartialView(posts);
        }
        

    }
}