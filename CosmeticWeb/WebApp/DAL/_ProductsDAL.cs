using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApp.Models;
using DataModels;
using PagedList;

namespace WebApp.DAL
{
    public interface _IProductsDAL
    {
        IEnumerable<_ProductsBLL> DisplayAllProduct();
        IEnumerable<_ProductsBLL> RecommendItem();
        IEnumerable<_ProductsBLL> GetProByCate(long idCate, int page, int pageSize);
        IEnumerable<_ProductsBLL> GetProByBrand(long idBrand, int page, int pageSie);
        _ProductsBLL DetailProductById(long id);
    }
    public class _ProductsDAL : _IProductsDAL
    {
        DbComesticEntities db = new DbComesticEntities();

        public _ProductsBLL DetailProductById(long id)
        {
            tbProduct obj = db.tbProducts.Find(id);
            if (obj == null) return null;
            else
            {
                _ProductsBLL model = new _ProductsBLL();
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
                model.Price_Product = (long)obj.Price_Product;
                model.Sale_Product = (long)obj.Sale_Product;
                model.Hot_Product = obj.Hot_Product;
                model.Rate_Total_Product = obj.Rate_Total_Product;
                model.Price = model.Price_Product - (long)(0.01 * model.Sale_Product * model.Price_Product);
                return model;
            }
        }

        public IEnumerable<_ProductsBLL> DisplayAllProduct()
        {
            List<_ProductsBLL> lst = new List<_ProductsBLL>();
            int count = 0;
            foreach(tbProduct obj in db.tbProducts)
            {
                count++;
                _ProductsBLL model = new _ProductsBLL();
                model.Id_Product = obj.Id_Product;
                model.Id_Brand = obj.Id_Brand;
                model.Name_Product = obj.Name_Product;
                model.Price_Product = (long)obj.Price_Product;
                model.Image_Product = obj.Image_Product;
                model.Sale_Product =(long)obj.Sale_Product;
                model.Name_Brand = obj.tbBrand.Name_Brand;
                model.Quality_Product = obj.Quality_Product;
                model.Price = model.Price_Product - (long)(0.01 * model.Sale_Product* model.Price_Product);
                if (count > 9) break;
                else lst.Add(model);
            }
            return lst;
        }

        public IEnumerable<_ProductsBLL> GetProByBrand(long idBrand, int page, int pageSize)
        {
            List<_ProductsBLL> lst = new List<_ProductsBLL>();

            foreach (tbProduct obj in db.tbProducts)
            {
                
                _ProductsBLL model = new _ProductsBLL();
                model.Id_Product = obj.Id_Product;
                model.Id_Brand = obj.Id_Brand;
                model.Name_Product = obj.Name_Product;
                model.Price_Product = (long)obj.Price_Product;
                model.Image_Product = obj.Image_Product;
                model.Sale_Product = (long)obj.Sale_Product;
                model.Name_Brand = obj.tbBrand.Name_Brand;
                model.Quality_Product = obj.Quality_Product;
                model.Price = model.Price_Product - (long)(0.01 * model.Sale_Product * model.Price_Product);
                
                if(model.Id_Brand == idBrand) lst.Add(model);
            }
            return lst.OrderBy(x=>x.Id_Product).ToPagedList(page, pageSize);
        }

        public IEnumerable<_ProductsBLL> GetProByCate(long idCate, int page, int pageSize)
        {
            List<_ProductsBLL> lst = new List<_ProductsBLL>();

            foreach (tbProduct obj in db.tbProducts)
            {

                _ProductsBLL model = new _ProductsBLL();
                model.Id_Product = obj.Id_Product;
                model.Id_Brand = obj.Id_Brand;
                model.Id_Category = obj.Id_Category;
                model.Name_Product = obj.Name_Product;
                model.Price_Product = (long)obj.Price_Product;
                model.Image_Product = obj.Image_Product;
                model.Sale_Product = (long)obj.Sale_Product;
                model.Name_Brand = obj.tbBrand.Name_Brand;
                model.Quality_Product = obj.Quality_Product;
                model.Price = model.Price_Product - (long)(0.01 * model.Sale_Product * model.Price_Product);

                if (model.Id_Category == idCate) lst.Add(model);
            }
            return lst.OrderBy(x => x.Id_Product).ToPagedList(page, pageSize);
        }

        public IEnumerable<_ProductsBLL> RecommendItem()
        {
            List<_ProductsBLL> lst = new List<_ProductsBLL>();
            int count = 0;
            var prod = from pro in db.tbProducts orderby pro.Id_Product descending select pro;
            foreach (tbProduct obj in prod)
            {
                count++;
                _ProductsBLL model = new _ProductsBLL();
                model.Id_Product = obj.Id_Product;
                model.Name_Product = obj.Name_Product;
                model.Price_Product = (long)obj.Price_Product;
                model.Image_Product = obj.Image_Product;
                model.Sale_Product = (long)obj.Sale_Product;
                model.Name_Brand = obj.tbBrand.Name_Brand;
                model.Quality_Product = obj.Quality_Product;
                model.Price = model.Price_Product - (long)(0.01 * model.Sale_Product * model.Price_Product);
                if (count > 10) break;
                else lst.Add(model);
            }
            return lst;
        }
    }
}