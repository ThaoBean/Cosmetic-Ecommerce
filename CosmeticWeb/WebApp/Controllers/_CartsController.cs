using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp.DAL;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class _CartsController : _BaseController
    {
        // GET: _Carrts
        _ICartsDAL repoCart = new _CartsDAL();
        //Them san pham vao gio hang
        public ActionResult AddToCart(long idCus, string Img, string NamePro, long IdPro, long UnitPrice)
        {
            if(repoCart.AddToCart(idCus, Img, NamePro, IdPro, UnitPrice))
            {
                return RedirectToAction("DisplayCart", "_Carts", new { idCus = idCus });
            }
            return RedirectToAction("Mess", "_Home");
        }
        //Display san pham
        public ActionResult DisplayCart(long idCus)
        {
            IEnumerable<_CartsBLL> lst = repoCart.GetAllItemsByIdCus(idCus);
            return View(lst);
        }
        //Xoa san pham khoi gio hang
        public ActionResult DeleteItem(long idCart, long idCus)
        {
            if (repoCart.DeleteItem(idCart))
            {
                return RedirectToAction("DisplayCart", "_Carts", new { idCus = idCus });
            }
            return RedirectToAction("Mess", "_Home");
        }
    }
}