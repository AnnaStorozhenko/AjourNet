using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AjourNet.Domain.Entities
{
    public class Feed
    {
        [Key]
        public int FeedID { get; set; }
        public virtual UserProfile FeedOf { get; set; }
        public virtual List<Post> Posts { get; set; }
    }
}
