using AjourNet.Domain.Entities;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AjourNet.Domain.Identity
{
    public class AjourNetUser : IdentityUser
    {
        public UserProfile UserProfile;
    
        public AjourNetUser()
        {
            UserName = "user";
        }
        
    }
}
