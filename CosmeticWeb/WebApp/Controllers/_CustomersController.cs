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
    public class _CustomersController : Controller
    {
        _ICustomersDAL repoCus = new _CustomersDAL();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult LoginRegister(MixLoginRegis lr)
        {
            return View(new MixLoginRegis { MLogin = new _LoginBLL(), MRegister = new _CustomersBLL() });

        }
        [HttpPost]
        public ActionResult Login(MixLoginRegis l)
        {
            if (ModelState.IsValid)
            {
                if(repoCus.Login(l.MLogin.Name_Customer, l.MLogin.Password_Customer))
                {
                    var customer = repoCus.GetUserByUserName(l.MLogin.Name_Customer);
                    var customerSession = new CustomerLogin();
                    customerSession.CustomerID = customer.Id_Customer;
                    customerSession.CustomerName = customer.Name_Customer;
                    Session.Add(Constants.CUSTOMER_SESSION, customerSession);
                    return RedirectToAction("Index", "_Home");
                }
                else
                {
                    ModelState.AddModelError("", "Login Failded");
                    return View("LoginRegister", l);
                }
            }
            return View("LoginRegister", l);
        }

        [HttpPost]
        public ActionResult Register(MixLoginRegis r)
        {
            if (ModelState.IsValid)
            {
                if (repoCus.Register(r))
                {

                    return RedirectToAction("Index", "_Home");
                }
                else
                {
                    ModelState.AddModelError("", "Register Failded");
                    return View("LoginRegister", r);
                }
            }
            return View("LoginRegister", r);
        }

        public ActionResult Logout()
        {
            Session.Abandon();
            return RedirectToAction("Index", "_Home");
        }
    }
}