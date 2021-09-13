using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp.Areas.Admin.DAL;
using WebApp.Areas.Admin.Models;

namespace WebApp.Areas.Admin.Controllers
{
    public class OrdersController : Controller
    {
        // GET: Admin/Orders
        IOrdersDAL repoOrders = new OrdersDAL();
        public ActionResult GetAllOrders()
        {
            IEnumerable<OrdersBLL> lstOrder = repoOrders.GetAllOrders_();
            return View(lstOrder);
        }
    }
}