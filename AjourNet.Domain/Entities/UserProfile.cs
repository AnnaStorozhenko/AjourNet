﻿using AjourNet.Domain.Identity;
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
        [Key]
        public int UserProfileID { get; set; }
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

        public virtual Feed Feed{ get; set;}
        public virtual List<Post> Posts { get; set; }

    }
}
