using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Validation.Web.Models
{
    public class LoginViewModel
    {
        [Display(Name = "Email", Prompt = "  enter email")]
        [Required(ErrorMessage = "*")]
        [DataType(DataType.EmailAddress)]
        [RegularExpression("^[_A-Za-z'`+-.]+([_A-Za-z0-9'+-.]+)*@([A-Za-z0-9-])+(\\.[A-Za-z0-9]+)*(\\.([A-Za-z]*){3,})$", ErrorMessage = "Invalid email")]
        public string Email { get; set; }

        [Display(Name = "Password", Prompt = "  enter password")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "*")]
        public string Password { get; set; }
    }
}