using FormSubmitApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace FormSubmitApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Register()
        {
            ViewBag.EmploymentStatusOptions = new List<SelectListItem>
            {
                new SelectListItem { Text = "Employed", Value = "Employed" },
                new SelectListItem { Text = "Self-Employed", Value = "Self-Employed" },
                new SelectListItem { Text = "Unemployed", Value = "Unemployed" },
                new SelectListItem { Text = "Student", Value = "Student" }
            };

            ViewBag.CurrencyOptions = new List<SelectListItem>
            {
                new SelectListItem { Text = "USD", Value = "USD" },
                new SelectListItem { Text = "EUR", Value = "EUR" },
                new SelectListItem { Text = "GBP", Value = "GBP" },
                new SelectListItem { Text = "INR", Value = "INR" }
            };

            return View();
        }

        [HttpPost]
        public IActionResult Register(FinanceRegistration registration)
        {
            if (ModelState.IsValid)
            {
                return View("RegistrationResult", registration);
            }
            return View();
        }
    }
}
