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
        [Required]
        [Display(Name = "User name")]
        public string UserName { get; set; }
      
        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        
        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        
        public  AjourNetUser AjourNetUser { get; set; }

        public UserProfileModel(UserProfile user)
        {
            FirstName = user.FirstName;
            LastName = user.LastName;
            AjourNetUser = user.AjourNetUser;
            UserName = user.UserName;

        }

    }
}
