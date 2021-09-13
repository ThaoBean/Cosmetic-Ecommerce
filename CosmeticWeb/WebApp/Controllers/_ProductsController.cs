using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp.DAL;
using WebApp.Models;

namespace WebApp.Controllers
{
   
    // GET: Home
    public class _ProductsController : Controller
    {
        _IProductsDAL repoProduct = new _ProductsDAL();
        _IBrandsDAL repoBrand = new _BrandsDAL();
        _ICategoriesDAL repoCate = new _CategoriesDAL();
        
        // GET: _Products

        public ActionResult ListProductsByBrand(long idBrand, int page = 1, int pageSize = 9)
        {
            ViewBag.IDBrand = idBrand;
            IEnumerable<_ProductsBLL> lstProduct = repoProduct.GetProByBrand(idBrand, page, pageSize);
            return View(lstProduct);
        }
        public ActionResult ListProductsByCategory(long idCate, int page = 1, int pageSize = 9)
        {
            ViewBag.IDCate = idCate;
            IEnumerable<_ProductsBLL> lstProduct = repoProduct.GetProByCate(idCate, page, pageSize);
            return View(lstProduct);
        }
        public ActionResult ShowDetailProduct(long idProduct)
        {
            _ProductsBLL model = repoProduct.DetailProductById(idProduct);
            return View(model);
        }
    }
}