using AjourNet.Domain.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AjourNet.Domain.Entities
{
    public class UserProfile
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }

        public virtual AjourNetUser AjourNetUser { get; set; }
       
        [Required]
        public string UserName
        {
            get { return AjourNetUser.UserName; }
        }


    }
}
