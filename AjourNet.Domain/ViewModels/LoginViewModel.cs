using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AjourNet.Domain.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage="That's not the right login")]
        [Display(Name = "Login")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "That's not the right password")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Display(Name = "Keep me signed in")]
        public bool RememberMe { get; set; }
    }
}
