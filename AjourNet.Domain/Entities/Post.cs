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
        public virtual Feed PostOf { get; set; }
    }
}
