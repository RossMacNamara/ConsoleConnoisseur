using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleConnoisseur.Models
{
    public class Comment
    {
        [BindNever]
        public int CommentId { get; set; }
        [Required]
        [EmailAddress]
        public string UserEmail { get; set; }
        [Required]
        [MinLength(2)]
        public string CommentDeltails { get; set; }
        [Required]
        public int ConsoleId { get; set; }
    }
}
