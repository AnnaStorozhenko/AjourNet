using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AjourNet.Domain.Entities
{
    public class Post
    {
        [Key]
        public int PostID { get; set; }
        [Required]
        public string Text { get; set; }
        [Required]
        public DateTime Time { get; set; }
        public virtual Feed PostOf { get; set; }
        public virtual UserProfile PostOfUser { get; set; }

    }
}
