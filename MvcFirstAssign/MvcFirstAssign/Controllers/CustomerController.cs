using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcFirstAssign.Models;

namespace MvcFirstAssign.Controllers
{
    public class CustomerController : Controller
    {
        NorthwindEntities db=new NorthwindEntities();   
        // GET: Customer
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetCustomerByCountry()
        {
            List<string> custname = (from cust in db.Customers where cust.Country == "Germany"
                                     select cust.ContactName).ToList();
            return View(custname);
        }
        public ActionResult GetCustomerDetailsById()
        {
            List<Customer> customer = (from cust in db.Customers join o in db.Orders
                                       on cust.CustomerID equals o.CustomerID
                                       where o.OrderID == 10248
                                       select cust).ToList();
            return View(customer);
        }
    }
}