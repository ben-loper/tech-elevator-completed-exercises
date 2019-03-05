using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GETForms.Web.DAL;
using GETForms.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace GETForms.Web.Controllers
{
    public class CustomersController : Controller
    {
        private ICustomerDAL _customerDAL;

        public CustomersController(ICustomerDAL customerDal)
        {
            _customerDAL = customerDal;
        }

        /// <summary>
        /// The request to display an empty search page.
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SearchResult(string searchTerm, string sortBy)
        {
            IList<Customer> customers = _customerDAL.SearchForCustomers(searchTerm, sortBy);

            CustomerSearchViewModel model = new CustomerSearchViewModel();

            model.MatchingCustomers.AddRange(customers);

            return View(model);
        }
    }
}