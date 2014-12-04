using AjourNet.Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AjourNet.Controllers
{
    public class FeedController : Controller
    {
        // GET: Feed
        public ActionResult GetUserFeed(UserProfileModel model)
        {
            return View();
        }
    }
}