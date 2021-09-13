using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApp.Areas.Admin.Models;
using DataModels;

namespace WebApp.Areas.Admin.DAL
{
    public interface ICategoriesDAL
    {
        IEnumerable<CategoriesBLL> GetAllCategories_();
    }


    public class CategoriesDAL : ICategoriesDAL
    {
        DbComesticEntities db = new DbComesticEntities();
        public IEnumerable<CategoriesBLL> GetAllCategories_()
        {
            List<CategoriesBLL> lstCategory = new List<CategoriesBLL>();
            foreach(tbCategory obj in db.tbCategories)
            {
                CategoriesBLL model = new CategoriesBLL();
                model.Id_Category = obj.Id_Category;
                model.Name_Category = obj.Name_Category;
                lstCategory.Add(model);
            }
            return lstCategory;
        }
    }
}