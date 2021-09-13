using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApp.Areas.Admin.Models;
using DataModels;
namespace WebApp.Areas.Admin.DAL
{
    public interface IOrderDetailsDAL
    {
        IEnumerable<OrderDetailsBLL> GetOrderDetailsByIdOrder(long idOrder);
    }
    public class OrderDetailsDAL : IOrderDetailsDAL
    {
        DbComesticEntities db = new DbComesticEntities();
        public IEnumerable<OrderDetailsBLL> GetOrderDetailsByIdOrder(long idOrder)
        {
            List<OrderDetailsBLL> lst = new List<OrderDetailsBLL>();
            var lst_ = db.tbOrderDetails.Where(x => x.Id_Order == idOrder);
            foreach(var item in lst_)
            {
                OrderDetailsBLL model = new OrderDetailsBLL();
                model.Id_Order = item.Id_Order;
                model.Id_Product = item.Id_Product;
                model.Quantity = item.Quantity;
                model.Price_OrderDetail = item.Price_OrderDetail;
                model.Status = false;
                lst.Add(model);
            }
            return lst;
        }
    }
}