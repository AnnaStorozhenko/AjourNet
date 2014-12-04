using AjourNet.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AjourNet.Domain.ViewModels
{
    public class UserFeedModel
    {
        public int FeedID { get; set; }
        [Required]
        public  UserProfile FeedOf { get; set; }
        public  List<Post> Posts { get; set; }

    }
}
