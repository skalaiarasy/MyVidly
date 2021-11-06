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

            var customers = _context.Customers.ToList();            
            return View(customers);

        }
        
        public ActionResult CustomerDetails(int? id)
        {
            
            var customers = _context.Customers.SingleOrDefault(c => c.Id == id);            
            if (customers == null)
            {
                
                return HttpNotFound();
                
            }
            else
            {
                
                return View(customers);
            }

            
        }
        
    }

}




