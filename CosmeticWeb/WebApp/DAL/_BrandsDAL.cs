using DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApp.Models;

namespace WebApp.DAL
{
    public interface _IBrandsDAL
    {
        IEnumerable<_BrandsBLL> GetAllBrands_();
    }
    public class _BrandsDAL: _IBrandsDAL
    {
        DbComesticEntities db = new DbComesticEntities();

        public IEnumerable<_BrandsBLL> GetAllBrands_()
        {
            List<_BrandsBLL> lstBrand = new List<_BrandsBLL>();
            foreach (tbBrand obj in db.tbBrands)
            {
                _BrandsBLL model = new _BrandsBLL();
                model.Id_Brand = obj.Id_Brand;
                model.Name_Brand = obj.Name_Brand;
                lstBrand.Add(model);
            }
            return lstBrand;
        }
    }
}