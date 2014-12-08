using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 


namespace AjourNet.Domain.Entities
{
    public class Comment
    {
        [Key]
        public int Id { get; set; } 
        public string Text { get; set; }

        [ForeignKey("Post")]
        public int PostID { get; set; }
        public virtual Post Post { get; set; }  
    }
}
