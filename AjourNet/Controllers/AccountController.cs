using AjourNet.Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace AjourNet.Controllers
{
    public class AccountController : Controller
    {
        [AllowAnonymous]
        public ActionResult Login(string returnUrl)
        {
            ViewBag.ReturnUrl = returnUrl;
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Login(LoginViewModel model, string returnUrl)
        {
            //TODO: Implement real authentication (part of task #10)
            if (!ModelState.IsValid )
            {
                return View(model);
            }     
                bool signInResult = await PasswordSignInAsync(model.Email, model.Password); 
            if(signInResult)
            {
                return RedirectToAction("CreateUserProfile", "UserProfile");
            }
            else
            {
                ModelState.AddModelError("Can't Login!", "Wrong Login or password!");
                return View(); 
            }
        } 

                private async Task<bool> PasswordSignInAsync(string eMail, string password)
        {
            return await Task.Run(() => {return eMail =="abc@gmail.com" && password == "123456"; });
        }

    }
}