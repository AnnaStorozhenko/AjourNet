using AjourNet.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AjourNet.Domain.ViewModels
{
    public class UserSearchViewModel
    { 
        public int UserProfileID;
        [Required]
        [Display(Name = "User ID")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "First Name is required")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is required")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Status")]
        public string Occupation { get; set; }

        [Display(Name = "Location")]
        public string Location { get; set; }

        private Status status;
        public Status Status
        {
            get { return status; }
            set { status = value; }
        }

        public UserSearchViewModel()
        {
        }
        public UserSearchViewModel(UserProfile user)
        {
            UserProfileID = user.UserProfileID; 
            FirstName = user.FirstName;
            LastName = user.LastName;
            UserName = user.UserName;            
            Status = Status.Online;
            Location = String.Empty;
        }
    }
}
