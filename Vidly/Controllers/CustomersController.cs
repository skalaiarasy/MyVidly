using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        private MyDbContext _context;

        public CustomersController()
        {
            _context = new MyDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        //GET: Customers
        public ActionResult Customers()
        {

            //List<Customer> customers = new List<Customer>
            //{
            //    new Customer { Id = 1,Name = "Tharunika"},
            //    new Customer { Id =2, Name = "Madhunika"}

            //};


            //RandomCustomerViewModel randomCustomerViewModel = new RandomCustomerViewModel()
            //{

            //    Customers = customers
            //};
            var customers = _context.Customers.ToList();
            //return View(randomCustomerViewModel);
            return View(customers);

        }
        //[Route("Customers/CustomerDetails/{id}")]
        public ActionResult CustomerDetails(int? id)
        {
            //List<Customer> customers = new List<Customer>
            //{
            //    new Customer { Id = 1,Name = "Tharunika"},
            //    new Customer { Id = 2, Name = "Madhunika"}

            //};
            var customers = _context.Customers.SingleOrDefault(c => c.Id == id);
            //var temp = customers.Find(customer => customer.Id == id);
            if (customers == null)
            {
                
                return HttpNotFound();
                
            }
            else
            {
                //ViewBag.Name = temp.Name;
                return View(customers);
            }

            
        }
        
    }

}




