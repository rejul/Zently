﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Zently.Models;

namespace Zently.Controllers
{
    public class CustomersController : Controller
    {

        private ApplicationDbContext _context;

        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }


        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        //GET: Customers/
        public ViewResult Index()
        {


            var customer = _context.Customers.ToList();
            return View(customer);

        }

         // GET: Customers/Details/{id}
        public ActionResult Details(int? id)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.Id == id);
            if (customer == null)
                return HttpNotFound();
            return View(customer);
        }


       

    }
}