using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Validation.Web.Models;


namespace Validation.Web.Controllers
{

    public class UsersController : Controller
    {
        // GET: User/Register
        // Return the empty registration view
        [HttpGet]
        public IActionResult Register()
        {
            RegistrationViewModel model = new RegistrationViewModel();

            return View(model);
        }

        // POST: User/Register
        // Validate the model and redirect to confirmation (if successful) or return the 
        // registration view (if validation fails)        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Register(RegistrationViewModel model)
        {
            IActionResult result = null;

            if (!ModelState.IsValid)
            {
                result = View("Register");
            }
            else
            {


                result = RedirectToAction("RegistrationConfirmation");
            }

            return result;
        }


        // GET: User/Login
        // Return the empty login view
        [HttpGet]
        public IActionResult Login()
        {
            LoginViewModel model = new LoginViewModel();

            return View(model);
        }
        // POST: User/Login  
        // Validate the model and redirect to login (if successful) or return the 
        // login view (if validation fails)
        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            IActionResult result = null;

            if (!ModelState.IsValid)
            {
                result = View("Login");
            }
            else
            {

                result = RedirectToAction("LogInConfirmation");
            }

            return result;
        }

        // GET: User/Confirmation
        // Return the confirmation view

        public IActionResult RegistrationConfirmation()
        {
            return View();
        }

        public IActionResult LogInConfirmation()
        {
            return View();
        }
    }
}