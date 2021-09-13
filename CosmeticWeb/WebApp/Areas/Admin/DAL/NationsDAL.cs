using DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApp.Areas.Admin.Models;

namespace WebApp.Areas.Admin.DAL
{
    public interface INationsDAL
    {
        IEnumerable<NationsBLL> GetAllNation_();
    }
    public class NationsDAL : INationsDAL
    {
        DbComesticEntities db = new DbComesticEntities();

        public IEnumerable<NationsBLL> GetAllNation_()
        {
            List<NationsBLL> lstNation = new List<NationsBLL>();
            foreach(tbNation obj in db.tbNations)
            {
                NationsBLL model = new NationsBLL();
                model.Id_Nation = obj.Id_Nation;
                model.Name_Nation = obj.Name_Nation;
                lstNation.Add(model);
            }
            return lstNation;
        }
    }
}