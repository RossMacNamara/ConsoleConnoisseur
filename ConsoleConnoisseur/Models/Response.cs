using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleConnoisseur.Models
{
    public class Response
    {
        [BindNever]
        public int ResponseId { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "Name Required")]
        public string Name { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "Email Required")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress(ErrorMessage ="Invalid Email")]
        public string Email { get; set; }
        [Required]
        [StringLength(5000, ErrorMessage = "Message Required")]
        public string Message { get; set; }

        public bool ContactMe { get; set; }
    }
}
