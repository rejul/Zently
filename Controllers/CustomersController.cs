using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Zently.Models;

namespace Zently.Controllers
{
    public class CustomersController : Controller
    {
        public ViewResult Index()
        {
            var customer = GetCustomers();
            return View(customer);

        }

         // GET: Customers
        public ActionResult Details(int? id)
        {
            var customer = GetCustomers().SingleOrDefault(c => c.Id == id);
            if (customer == null)
                return HttpNotFound();
            return View(customer);
        }


        private IEnumerable<Customer> GetCustomers()
        {
            return new List<Customer>
            {
                new Customer {Id = 1, Name = "Rejul"},
                new Customer {Id = 2, Name = "Akash"}

            };
        }

    }
}