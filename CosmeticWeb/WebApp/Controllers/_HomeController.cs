using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp.DAL;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class _HomeController : Controller
    {
        _IProductsDAL repoProduct = new _ProductsDAL();
        _IBrandsDAL repoBrand = new _BrandsDAL();
        _ICategoriesDAL repoCate = new _CategoriesDAL();
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.Brands = repoBrand.GetAllBrands_();
            IEnumerable<_ProductsBLL> lstProduct = repoProduct.DisplayAllProduct();
            return View(lstProduct);
        }
        public ActionResult Mess()
        {
            return View();
        }
        public PartialViewResult BrandCategory()
        {
            var brands = repoBrand.GetAllBrands_();
            var categories = repoCate.GetAllCategories_();
            MixBrandCategory model = new MixBrandCategory();
            model.brands = brands;
            model.categories = categories;
            return PartialView(model);
        }
        public PartialViewResult RecommendItem()
        {
            IEnumerable<_ProductsBLL> lstProduct = repoProduct.RecommendItem();
            return PartialView(lstProduct);
        }
    }
}