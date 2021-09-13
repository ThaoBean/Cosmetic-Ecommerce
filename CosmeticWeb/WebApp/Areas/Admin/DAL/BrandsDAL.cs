using DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApp.Areas.Admin.Models;

namespace WebApp.Areas.Admin.DAL
{
    public interface IBrandsDAL
    {
        IEnumerable<BrandsBLL> GetAllBrands_();
    }
    public class BrandsDAL : IBrandsDAL
    {
        DbComesticEntities db = new DbComesticEntities();

        public IEnumerable<BrandsBLL> GetAllBrands_()
        {
            List<BrandsBLL> lstBrand = new List<BrandsBLL>();
            foreach(tbBrand obj in db.tbBrands)
            {
                BrandsBLL model = new BrandsBLL();
                model.Id_Brand = obj.Id_Brand;
                model.Name_Brand = obj.Name_Brand;
                lstBrand.Add(model);
            }
            return lstBrand;
        }
    }
}