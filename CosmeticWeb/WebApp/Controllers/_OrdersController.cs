using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp.DAL;
using WebApp.Helper;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class _OrdersController : _BaseController
    {
        _IOrdersDAL repoOrders = new _OrdersDAL();
        _ICartsDAL repoCart = new _CartsDAL();
        // GET: _Orders
        public ActionResult CheckOut()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CheckOut(MixCartOrder cartOrder)
        {
            var sessionCus = (CustomerLogin)Session[Constants.CUSTOMER_SESSION];
            IEnumerable<_CartsBLL> lst = repoCart.GetAllItemsByIdCus(sessionCus.CustomerID);
            long total = 0;
            foreach(_CartsBLL item in lst)
            {
                total += (long)item.UnitsTotal;
            }
            
            if (repoOrders.CreateOrder(sessionCus.CustomerID, (decimal)total, cartOrder.MOrder)){
                if(repoCart.OrderDetail(sessionCus.CustomerID, repoOrders.getIdOrder()) && repoCart.EmptyCart(sessionCus.CustomerID))
                    return RedirectToAction("SucceededOrder", "_Orders");
            }
            return View();
        }

        public ActionResult SucceededOrder()
        {
            return View();
        }
    }
}