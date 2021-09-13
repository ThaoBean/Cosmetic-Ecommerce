using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp.Helper;

namespace WebApp.Controllers
{
    public class _BaseController : Controller
    {
        // GET: _Base
        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var session = (CustomerLogin)Session[Constants.CUSTOMER_SESSION];
            if (session == null)
            {
                filterContext.Result = new RedirectToRouteResult(new System.Web.Routing.RouteValueDictionary(
                    new { controller = "_Customers", action = "LoginRegister" }));
            }
            base.OnActionExecuting(filterContext);
        }
    }
}