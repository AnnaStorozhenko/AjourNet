using AjourNet.Domain.Entities;
using AjourNet.Domain.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AjourNet.Domain.ViewModels
{
    public class UserProfileModel
    {
        public int UserProfileID;
        
        [Required]
        [Display(Name = "User name")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "First Name is required")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is required")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        public  AjourNetUser AjourNetUser { get; set; }
        public Feed Feed { get; set; }
        
        public UserProfileModel()
        {
            FirstName = FirstName;
            LastName = LastName;
            AjourNetUser = new AjourNetUser();
            UserName = AjourNetUser.UserName;
        }
       
        public UserProfileModel(UserProfile user)
        {
            UserProfileID = user.UserProfileID; 
            FirstName = user.FirstName;
            LastName = user.LastName;
            AjourNetUser = user.AjourNetUser;
            UserName = user.UserName;
        }
    }
}
