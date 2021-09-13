using DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApp.Models;

namespace WebApp.DAL
{
    public interface _ICategoriesDAL
    {
        IEnumerable<_CategoriesBLL> GetAllCategories_();
    }


    public class _CategoriesDAL : _ICategoriesDAL
    {
        DbComesticEntities db = new DbComesticEntities();
        public IEnumerable<_CategoriesBLL> GetAllCategories_()
        {
            List<_CategoriesBLL> lstCategory = new List<_CategoriesBLL>();
            foreach (tbCategory obj in db.tbCategories)
            {
                _CategoriesBLL model = new _CategoriesBLL();
                model.Id_Category = obj.Id_Category;
                model.Name_Category = obj.Name_Category;
                lstCategory.Add(model);
            }
            return lstCategory;
        }
    }
}