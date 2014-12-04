using AjourNet.Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AjourNet.Controllers
{
    public class SearchController : Controller
    {

        public ActionResult SearchUser(string searchString)
        {
            if(searchString=="tebo")
            {
                UserSearchViewModel userFound =  new UserSearchViewModel
                {
                    UserProfileID = 111,
                    FirstName = "Bohdan",
                    LastName = "Tereta", 
                    Occupation = "Developer", 
                    Location = "Lviv"
                };
                IEnumerable<UserSearchViewModel> usersFound = new List<UserSearchViewModel> { userFound }; 
            }
            return PartialView();
        } 

    }
}