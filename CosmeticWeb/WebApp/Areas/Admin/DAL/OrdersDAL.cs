using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DataModels;
using WebApp.Areas.Admin.Models;

namespace WebApp.Areas.Admin.DAL
{
    public interface IOrdersDAL
    {
        IEnumerable<OrdersBLL> GetAllOrders_();
    }

    public class OrdersDAL : IOrdersDAL
    {
        DbComesticEntities db = new DbComesticEntities();
        public IEnumerable<OrdersBLL> GetAllOrders_()
        {
            List<OrdersBLL> lstOrder = new List<OrdersBLL>();
            foreach(tbOrder obj in db.tbOrders)
            {
                OrdersBLL model = new OrdersBLL();
                model.Id_Customer = obj.Id_Customer;
                model.Id_Order = obj.Id_Order;
                model.Shipping_Addr = obj.Shipping_Addr;
                model.Phone_Reciever = obj.Phone_Reciever;
                model.Name_Reciever = obj.Name_Reciever;
                model.Date = obj.Date;
                model.Price_Total = obj.Price_Total;
                model.Name_Customer = obj.tbCustomer.Name_Customer;
                model.Status = obj.Status;
                lstOrder.Add(model);
            }
            return lstOrder;
        }
    }
}