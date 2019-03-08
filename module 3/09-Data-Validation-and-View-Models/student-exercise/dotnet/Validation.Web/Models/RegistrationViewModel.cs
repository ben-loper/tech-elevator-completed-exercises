using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Validation.Web.Models
{
    public class RegistrationViewModel
    {
        [Display(Name = "First Name", Prompt = "  enter first name")]
        [MaxLength(20, ErrorMessage = "First Name cannot be more than 20 characters")]
        [Required(ErrorMessage = "*")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name", Prompt = "  enter last name")]
        [Required(ErrorMessage = "*")]
        [MaxLength(20, ErrorMessage = "Last Name cannot be more than 20 characters")]
        public string LastName { get; set; }

        [Display(Name = "Email", Prompt = "  enter email")]
        [Required(ErrorMessage = "*")]
        [RegularExpression("^[_A-Za-z'`+-.]+([_A-Za-z0-9'+-.]+)*@([A-Za-z0-9-])+(\\.[A-Za-z0-9]+)*(\\.([A-Za-z]*){3,})$", ErrorMessage = "Invalid email")]
        public string Email { get; set; }

        [Display(Name = "Confirmation Email", Prompt = "  confirm email address")]
        [Required]
        [NotMapped]
        [Compare("Email", ErrorMessage = "Emails do not match")]
        [EmailAddress]        
        public string ConfEmail { get; set; }

        [Display(Name = "Password", Prompt = "  enter password")]
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Confirm", Prompt = "  confirm password")]
        [Required(ErrorMessage = "Passwords do not match")]
        [NotMapped]
        [Compare("Password", ErrorMessage = "Passwords do not match")]
        [DataType(DataType.Password)]
        public string ConfPassword { get; set; }

        [Display(Name = "Birthday", Prompt = "  enter birth date (01/03/1993")]
        [Required]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }

        [Display(Name = "# of Tickets", Prompt = "  enter number of tickets")]
        [NumberOfTickets]
        [Required]        
        public int NumOfTickets { get; set; }
    }
}