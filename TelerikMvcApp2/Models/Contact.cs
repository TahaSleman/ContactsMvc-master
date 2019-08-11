using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TelerikMvcApp2.Models
{
    public class Contact
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "First Name Is Required")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name Is Required")]
        public string LastName { get; set; }

        [Display(Name = "Email address")]
        [Required(ErrorMessage = "Email Address Is Required")]
        [EmailAddress(ErrorMessage = "Email Is Not Valid")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Phone Name Is Required")]
        [Phone(ErrorMessage = "This is Not Phone Number")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Address Name Is Required")]
        public string Address { get; set; }

    }
}