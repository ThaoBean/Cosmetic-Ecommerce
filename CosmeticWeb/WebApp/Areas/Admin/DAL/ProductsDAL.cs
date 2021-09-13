using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApp.Areas.Admin.Models;
using DataModels;
using System.IO;
using System.Data.Entity;

namespace WebApp.Areas.Admin.DAL
{
    public interface IProductsDAL
    {
        bool Create_(HttpPostedFileBase filePath, ProductsBLL model,  string basePath);
        bool Edit_(HttpPostedFileBase filePath, ProductsBLL model, string basePath, string oldPathImg, string oldPathImg1);
        bool Delete_(long id);
        ProductsBLL GetProductById_(long id);
        IEnumerable<ProductsBLL> GetAllProducts_();
    }

    public class ProductsDAL : IProductsDAL
    {
        DbComesticEntities db = new DbComesticEntities();
        public bool Create_(HttpPostedFileBase filePath, ProductsBLL model,  string basePath)
        {
            try
            {
                tbProduct obj = new tbProduct();
                obj.Id_Brand = model.Id_Brand;
                obj.Id_Nation = model.Id_Nation;
                obj.Id_Category = model.Id_Category;
                obj.Name_Product = model.Name_Product;
                obj.Description_Product = model.Description_Product;
                obj.Detail_Product = model.Detail_Product;

                //-------------------IMG

                string filename = Path.GetFileName(filePath.FileName);
                string _filename = DateTime.Now.ToString("yymmssfff") + filename;
                string extension = Path.GetExtension(filePath.FileName);
                string path = Path.Combine(basePath, _filename);
                model.Image_Product = "~/ImagesUpload/" + _filename;

                obj.Image_Product = model.Image_Product;
                //---------------
                obj.Quality_Product = model.Quality_Product;
                obj.Price_Product = model.Price_Product;
                obj.Sale_Product = model.Sale_Product;
                obj.Hot_Product = true;
                obj.Rate_Total_Product = 0;
                db.tbProducts.Add(obj);
                if (db.SaveChanges() > 0)
                {
                    filePath.SaveAs(path);
                    return true;
                }
                return false;
            }
            catch (Exception)
            {

                return false;
            }
        }
        public bool Edit_(HttpPostedFileBase filePath, ProductsBLL model, string basePath, string oldPathImg, string oldPathImg1)
        {
            try
            {
                tbProduct obj = new tbProduct();
                obj.Id_Product = model.Id_Product;
                obj.Id_Brand = model.Id_Brand;
                obj.Id_Nation = model.Id_Nation;
                obj.Id_Category = model.Id_Category;
                obj.Name_Product = model.Name_Product;
                obj.Description_Product = model.Description_Product;
                obj.Detail_Product = model.Detail_Product;
                obj.Quality_Product = model.Quality_Product;
                obj.Price_Product = model.Price_Product;
                obj.Sale_Product = model.Sale_Product;
                obj.Hot_Product = model.Hot_Product;
                obj.Rate_Total_Product = model.Rate_Total_Product;
                if(filePath != null)
                {
                    string filename = Path.GetFileName(filePath.FileName);
                    string _filename = DateTime.Now.ToString("yymmssfff") + filename;
                    string extension = Path.GetExtension(filePath.FileName);
                    string path = Path.Combine(basePath, _filename);
                    model.Image_Product = "~/ImagesUpload/" + _filename;

                    obj.Image_Product = model.Image_Product;

                    db.Entry(obj).State = EntityState.Modified;
                    if (db.SaveChanges() > 0)
                    {
                        filePath.SaveAs(path);
                        if (System.IO.File.Exists(oldPathImg))
                        {
                            System.IO.File.Delete(oldPathImg);
                        }
                        return true;
                    }
                    return false;
                }
                else
                {
                    obj.Image_Product = oldPathImg1;
                    db.Entry(obj).State = EntityState.Modified;
                    if (db.SaveChanges() > 0)
                    {
                        return true;
                    }
                    return false;
                }
                
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool Delete_(long id)
        {
            try
            {
                tbProduct obj = db.tbProducts.Find(id);
                if (obj == null) return false;
                else
                {
                    db.tbProducts.Remove(obj);
                    db.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public IEnumerable<ProductsBLL> GetAllProducts_()
        {
            List<ProductsBLL> lstProduct = new List<ProductsBLL>();
            foreach(tbProduct obj in db.tbProducts)
            {
                ProductsBLL model = new ProductsBLL();
                model.Id_Product = obj.Id_Product;
                model.Id_Brand = obj.Id_Brand;

                model.Name_Brand = obj.tbBrand.Name_Brand;
                model.Name_Nation = obj.tbNation.Name_Nation;
                model.Name_Category = obj.tbCategory.Name_Category;

                model.Id_Nation = obj.Id_Nation;
                
                model.Id_Category = obj.Id_Category;
                model.Name_Product = obj.Name_Product;
                model.Description_Product = obj.Description_Product;
                model.Detail_Product = obj.Detail_Product;
                model.Image_Product = obj.Image_Product;
                model.Quality_Product = obj.Quality_Product;
                model.Price_Product = obj.Price_Product;
                model.Sale_Product = obj.Sale_Product;
                model.Hot_Product = obj.Hot_Product;
                model.Rate_Total_Product = obj.Rate_Total_Product;
                lstProduct.Add(model);
            }
            return lstProduct;
        }

        public ProductsBLL GetProductById_(long id)
        {
            tbProduct obj = db.tbProducts.Find(id);
            if (obj == null) return null;
            else
            {
                ProductsBLL model = new ProductsBLL();
                model.Id_Product = obj.Id_Product;
                model.Id_Brand = obj.Id_Brand;

                model.Name_Brand = obj.tbBrand.Name_Brand;
                model.Name_Nation = obj.tbNation.Name_Nation;
                model.Name_Category = obj.tbCategory.Name_Category;

                model.Id_Nation = obj.Id_Nation;

                model.Id_Category = obj.Id_Category;
                model.Name_Product = obj.Name_Product;
                model.Description_Product = obj.Description_Product;
                model.Detail_Product = obj.Detail_Product;
                model.Image_Product = obj.Image_Product;
                model.Quality_Product = obj.Quality_Product;
                model.Price_Product = obj.Price_Product;
                model.Sale_Product = obj.Sale_Product;
                model.Hot_Product = obj.Hot_Product;
                model.Rate_Total_Product = obj.Rate_Total_Product;
                return model;
            }
        }

        
    }
}