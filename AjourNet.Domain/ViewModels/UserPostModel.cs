using AjourNet.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AjourNet.Domain.Infrastructure;

namespace AjourNet.Domain.ViewModels
{
    public class UserPostModel
    {
        public int PostID { get; set; }
        //[Required(ErrorMessage = "Type the post")]
        public string Text { get; set; }
        [Required]
        public DateTime Time { get; set; }
        [Required]
        public  Feed PostOf { get; set; }
        [Required]
        public  UserProfile PostOfUser { get; set; }

        public UserPostModel()
        {
            Time = DateTime.Now.ToLocalTimeAzure();
        }
    }
}
