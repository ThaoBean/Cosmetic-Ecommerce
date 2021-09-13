using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp.Areas.Admin.DAL;
using WebApp.Areas.Admin.Models;

namespace WebApp.Areas.Admin.Controllers
{
    public class OrderDetailsController : Controller
    {
        IOrderDetailsDAL repoOD = new OrderDetailsDAL();
        public ActionResult DetailsOrderByIdOrder(long idOrder)
        {
            IEnumerable<OrderDetailsBLL> lst = repoOD.GetOrderDetailsByIdOrder(idOrder);
            return View(lst);
        }
    }
}