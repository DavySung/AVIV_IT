using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AVI_IT.Models
{
    public class Quotation
    {
        [Display(Name ="First Name")]
        [Required(ErrorMessage ="First Name is required")]
        public string firstName { get; set; }
        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Last Name is required")]
        public string lastName { get; set; }
        [Display(Name = "Email")]
        [Required(ErrorMessage = "The email address is required")]
        [EmailAddress(ErrorMessage = "The email address is not valid")]
        public string email { get; set; }
        [Display(Name = "Phone Number")]
        [Required(ErrorMessage = "Phone Number is required")]
        public string phone { get; set; }
        [Display(Name = "Description")]
        [MinLength(20, ErrorMessage = "Description is too short")]
        public string description { get; set; }
    }
}
