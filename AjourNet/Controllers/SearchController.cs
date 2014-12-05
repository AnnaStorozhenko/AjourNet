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

        public ActionResult SearchUser(string searchString="")
        {
            UserSearchViewModel firstUser = new UserSearchViewModel
            {
                UserProfileID = 111,
                FirstName = "Bohdan",
                LastName = "Tereta",
                Occupation = "Developer",
                Location = "Lviv"
            };

            UserSearchViewModel secondUser = new UserSearchViewModel
            {
                UserProfileID = 111,
                FirstName = "Anna",
                LastName = "Storozhenko",
                Occupation = "Developer",
                Location = "Lviv"
            };

            IEnumerable<UserSearchViewModel> users = new List<UserSearchViewModel> { firstUser, secondUser };
            List<UserSearchViewModel> usersFound = new List<UserSearchViewModel>();
            foreach (UserSearchViewModel user in users)
            {
                if (user.FirstName.Contains(searchString))
                {
                    usersFound.Add(user);
                }
            }
            return PartialView(usersFound);
        }

    }
}