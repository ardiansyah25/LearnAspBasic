using LearnAspBasic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LearnAspBasic.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Index()
        {
            var customers = GetCustomers();
            return View(customers);
        }

        public ActionResult Details(int id)
        {
            var customer = GetCustomers().SingleOrDefault(c => c.Id == id);
            if (customer == null)
            {
                return HttpNotFound();
            }
            else
            {
                return View(customer);
            }
           
        }

        private List<Customer> GetCustomers()
        {
            return new List<Customer>
            {
                new Customer
                {
                    Id = 1,
                    Name = "Ardiansyah",
                },
                new Customer
                {
                    Id = 2,
                    Name = "Khalifi",
                }
            };
        }
    }
}