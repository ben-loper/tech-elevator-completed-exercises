using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GETForms.Web.Models
{
    public class CustomerSearchViewModel
    {
        public string NameSearch { get; set; }
        public string SortBy { get; set; }

        public static List<SelectListItem> SortByOptions = new List<SelectListItem>()
        {
            new SelectListItem() { Text = "Last Name", Value = "last_name" },
            new SelectListItem() { Text = "Email", Value = "email" },
            new SelectListItem() { Text = "Active", Value = "active" }
        };

        public List<Customer> MatchingCustomers = new List<Customer>();
    }
}
