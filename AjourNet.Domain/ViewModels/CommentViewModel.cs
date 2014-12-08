using AjourNet.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AjourNet.Domain.ViewModels
{
    public class CommentViewModel
    {
        public int Id { get; set; } 
        [Required]
        public string Text { get; set; }
        public int PostID; 
        public virtual Post Post { get; set; }  
    }
}
