using DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApp.Areas.Admin.Models;

namespace WebApp.Areas.Admin.DAL
{
    public interface ICustomersDAL
    {
        IEnumerable<CustomersBLL> GetAllCustomers_();
    }
    public class CustomersDAL : ICustomersDAL
    {
        DbComesticEntities db = new DbComesticEntities();
        public IEnumerable<CustomersBLL> GetAllCustomers_()
        {
            List<CustomersBLL> lstCus = new List<CustomersBLL>();
            foreach(tbCustomer obj in db.tbCustomers)
            {
                CustomersBLL model = new CustomersBLL();
                model.Id_Customer = obj.Id_Customer;
                model.Name_Customer = obj.Name_Customer;
                model.Password_Customer = obj.Password_Customer;
                model.Phone_Customer = obj.Phone_Customer;
                model.Addr_Customer = obj.Addr_Customer;
                model.Email_Customer = obj.Email_Customer;
                model.Date_Created = obj.Date_Created;
                lstCus.Add(model);
            }
            return lstCus;
        }
    }
}