using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BankSite.Models;
using BankSite.DAL;

namespace BankSite.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            BankDbContext context = new BankDbContext();

            var customer = (from c in context.Customers
                           where c.CustomerName.Equals("Parag Upadhyay")
                           select c.CustomerName).FirstOrDefault();

            ViewBag.CustomerName = customer;
            return View();
        }
    }
}