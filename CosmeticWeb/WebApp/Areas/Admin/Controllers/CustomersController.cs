using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp.Areas.Admin.DAL;
using WebApp.Areas.Admin.Models;

namespace WebApp.Areas.Admin.Controllers
{
    public class CustomersController : Controller
    {
        ICustomersDAL repoCus = new CustomersDAL();
        // GET: Admin/Customers
        public ActionResult GetAllCustomers()
        {
            IEnumerable<CustomersBLL> lstCu = repoCus.GetAllCustomers_();
            return View(lstCu);
        }
    }
}