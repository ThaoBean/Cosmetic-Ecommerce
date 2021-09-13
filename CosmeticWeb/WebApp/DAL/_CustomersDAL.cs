using DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApp.Helper;
using WebApp.Models;

namespace WebApp.DAL
{
    public interface _ICustomersDAL
    {
        bool Login(string userName, string password);
        bool Register(MixLoginRegis model);
        _CustomersBLL GetUserByUserName(string userName);
    }
    public class _CustomersDAL : _ICustomersDAL
    {
        DbComesticEntities db = new DbComesticEntities();
        public _CustomersBLL GetUserByUserName(string userName)
        {
            tbCustomer obj = db.tbCustomers.SingleOrDefault(x => x.Name_Customer == userName);
            if (obj == null)
            {
                return null;
            }
            else
            {
                _CustomersBLL model = new _CustomersBLL();
                model.Name_Customer = obj.Name_Customer;
                model.Id_Customer = obj.Id_Customer;
                return model;
            }
        }

        public bool Login(string userName, string password)
        {
            string pass = Md5Hash.GetMd5Hash(password);
            var result = db.tbCustomers.Count(x => x.Name_Customer == userName && x.Password_Customer == pass);
            if (result > 0) return true;
            else return false;
        }

        public bool Register(MixLoginRegis model)
        {
            try
            {
                tbCustomer obj = new tbCustomer();
                if (GetUserByUserName(model.MRegister.Name_Customer) != null) return false;
                obj.Name_Customer = model.MRegister.Name_Customer;
                obj.Password_Customer = Md5Hash.GetMd5Hash(model.MRegister.Password_Customer);
                obj.Email_Customer = model.MRegister.Email_Customer;
                obj.Date_Created = DateTime.Now;
                db.tbCustomers.Add(obj);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}