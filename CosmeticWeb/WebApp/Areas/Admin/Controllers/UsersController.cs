using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp.Areas.Admin.DAL;
using WebApp.Areas.Admin.Models;
using WebApp.Helper;

namespace WebApp.Areas.Admin.Controllers
{
    public class UsersController : Controller
    {
        IUsersDAL repoUsers = new UsersDAL();
        // GET: Admin/Users
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(UsersBLL model)
        {
            if(repoUsers.Login(model.Name_User, model.Password_User)){
                var user = repoUsers.GetUserByUserName(model.Name_User);
                var userSession = new UserLogin();
                userSession.UserID = user.Id_User;
                userSession.UserName = user.Name_User;
                Session.Add(Constants.USER_SESSION, userSession);
                return RedirectToAction("Index","Home");
            }
            else
            {
                ModelState.AddModelError("","Tên tài khoản, mật khẩu sai hoặc chưa tồn tại");
            }
            return View();
        }

        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(UsersBLL model)
        {
            if (repoUsers.Register_(model))
            {
                return RedirectToAction("Login", "Users");
            }
            else
            {
                ModelState.AddModelError("", "Tên đăng nhập đã tồn tại!");
            }
            return View();
        }
    }
}