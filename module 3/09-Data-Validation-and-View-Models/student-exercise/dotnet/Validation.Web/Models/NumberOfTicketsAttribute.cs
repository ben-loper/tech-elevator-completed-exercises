using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Validation.Web.Models
{
    public class NumberOfTicketsAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            // We can only use this attribute on Movies so cast to a Movie first.
            RegistrationViewModel model = (RegistrationViewModel)validationContext.ObjectInstance;

            // Once casted, the object can now be checked for the rules.
            if (model.NumOfTickets <= 0 || model.NumOfTickets >= 11)
            {
                return new ValidationResult($"# of Tickets must be between 1 and 10");
            }

            return ValidationResult.Success;
        }
    }
}
