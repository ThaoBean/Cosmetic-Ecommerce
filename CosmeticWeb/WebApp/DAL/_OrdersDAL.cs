using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApp.Models;
using DataModels;

namespace WebApp.DAL
{
    public interface _IOrdersDAL
    {
        bool CreateOrder(long IdCus, decimal Total, _OrdersBLL model);
        long getIdOrder();
    }
    public class _OrdersDAL : _IOrdersDAL
    {
        DbComesticEntities db = new DbComesticEntities();
        
        public bool CreateOrder(long IdCus, decimal Total, _OrdersBLL model)
        {
            try
            {
                tbOrder obj = new tbOrder();
                obj.Date = DateTime.Now;
                obj.Id_Customer = IdCus;
                obj.Name_Reciever = model.Name_Reciever;
                obj.Phone_Reciever = model.Phone_Reciever;
                obj.Shipping_Addr = model.Shipping_Addr;
                obj.Price_Total = Total;
                obj.Status = false;
                db.tbOrders.Add(obj);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        //tra ve so ban ghi trong tbOrder
        public long getIdOrder()
        {
            return db.tbOrders.Max(x => x.Id_Order);
        }
    }

}