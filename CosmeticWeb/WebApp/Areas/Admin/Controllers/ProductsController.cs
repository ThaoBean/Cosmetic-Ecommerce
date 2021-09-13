using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp.Areas.Admin.DAL;
using WebApp.Areas.Admin.Models;

namespace WebApp.Areas.Admin.Controllers
{
    public class ProductsController : BaseController
    {
        IProductsDAL repoProducts = new ProductsDAL();
        INationsDAL repoNations = new NationsDAL();
        IBrandsDAL repoBrands = new BrandsDAL();
        ICategoriesDAL repoCategories = new CategoriesDAL();
        
        // GET: Admin/Products
        public ActionResult GetAllProducts()
        {
            IEnumerable<ProductsBLL> lstProduct = repoProducts.GetAllProducts_();
            return View(lstProduct);
        }
        //--------------
        public ActionResult CreateProduct()
        {
            ViewBag.BrandList = repoBrands.GetAllBrands_();
            ViewBag.NationList = repoNations.GetAllNation_();
            ViewBag.CateList = repoCategories.GetAllCategories_();
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ValidateInput(false)]
        public ActionResult CreateProduct( HttpPostedFileBase filePath, ProductsBLL model)
        {
            if (repoProducts.Create_( filePath, model, Server.MapPath("~/ImagesUpload/")))
            {
                return RedirectToAction("GetAllProducts");
            }
            else
            {
                ModelState.AddModelError("", "Thêm không thành công.");
                ViewBag.BrandList = repoBrands.GetAllBrands_();
                ViewBag.NationList = repoNations.GetAllNation_();
                ViewBag.CateList = repoCategories.GetAllCategories_();
                return View();
            }
        }
        //--------------------
        public ActionResult Edit(long id)
        {
            ProductsBLL model = repoProducts.GetProductById_(id);
            Session["imgPath"] = model.Image_Product;

            ViewBag.BrandList = repoBrands.GetAllBrands_();
            ViewBag.NationList = repoNations.GetAllNation_();
            ViewBag.CateList = repoCategories.GetAllCategories_();
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ValidateInput(false)]
        public ActionResult Edit(HttpPostedFileBase filePath, ProductsBLL model)
        {
            if (repoProducts.Edit_(filePath, model, Server.MapPath("~/ImagesUpload/"), Request.MapPath(Session["imgPath"].ToString()), Session["imgPath"].ToString()))
            {
                return RedirectToAction("GetAllProducts");
            }
            else
            {
                ModelState.AddModelError("", "Sửa không thành công.");
                ViewBag.BrandList = repoBrands.GetAllBrands_();
                ViewBag.NationList = repoNations.GetAllNation_();
                ViewBag.CateList = repoCategories.GetAllCategories_();
                return View();
            }
        }
        //----------------------
        public ActionResult Delete(long id)
        {
            if (repoProducts.Delete_(id))
            {
                return RedirectToAction("GetAllProducts");
            }
            else
            {
                return RedirectToAction("GetAllProducts");
            }
        }
    }
}