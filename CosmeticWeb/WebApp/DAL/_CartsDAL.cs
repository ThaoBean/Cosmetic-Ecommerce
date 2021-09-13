using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DataModels;
using WebApp.Models;

namespace WebApp.DAL
{
    public interface _ICartsDAL
    {
        bool AddToCart(long idCus, string Img, string NamePro, long IdPro, long UnitPrice);
        IEnumerable<_CartsBLL> GetAllItemsByIdCus(long idCus);
        bool DeleteItem(long idCart);
        bool OrderDetail(long idCus, long idOrder);
        bool EmptyCart(long idCus);
    }
    public class _CartsDAL : _ICartsDAL
    {
        DbComesticEntities db = new DbComesticEntities();
        public bool AddToCart(long idCus, string Img, string NamePro, long IdPro, long UnitPrice)
        {
            
            try
            {
                var chk = db.tbCarts.SingleOrDefault(c => c.Id_Product == IdPro && c.Id_Customer == idCus);
                if (chk == null)
                {
                    tbCart obj = new tbCart();
                    obj.Id_Customer = idCus;
                    obj.Image_Product = Img;
                    obj.Name_Product = NamePro;
                    obj.Id_Product = IdPro;
                    obj.UnitPrice = (decimal)UnitPrice;
                    obj.Quantity = 1;
                    obj.UnitsTotal = (long)obj.UnitPrice * obj.Quantity;
                    db.tbCarts.Add(obj);

                }
                else
                {
                    chk.Quantity++;
                    chk.UnitsTotal = (long)chk.UnitPrice * chk.Quantity;
                }
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public IEnumerable<_CartsBLL> GetAllItemsByIdCus(long idCus)
        {
            List<_CartsBLL> lst = new List<_CartsBLL>();
            foreach(tbCart obj in db.tbCarts.Where(c => c.Id_Customer == idCus))
            {
                _CartsBLL model = new _CartsBLL();
                model.Id_Cart = obj.Id_Cart;
                model.Id_Customer = obj.Id_Customer;
                model.Image_Product = obj.Image_Product;
                model.Name_Product = obj.Name_Product; ;
                model.Id_Product = obj.Id_Product;
                model.UnitPrice = obj.UnitPrice;
                model.Quantity = obj.Quantity;
                model.UnitsTotal = obj.UnitsTotal;
                lst.Add(model);
            }
            return lst;
        }

        public bool DeleteItem(long idCart)
        {
            try
            {
                tbCart obj = db.tbCarts.Find(idCart);
                if (obj == null) return false;
                else
                {
                    db.tbCarts.Remove(obj);
                    db.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool OrderDetail(long idCus, long idOrder)
        {
            try
            {
                IEnumerable<_CartsBLL> lst = GetAllItemsByIdCus(idCus);
                foreach (_CartsBLL item in lst)
                {
                    tbOrderDetail obj = new tbOrderDetail();
                    obj.Id_Order = idOrder;
                    obj.Id_Product = item.Id_Product;
                    obj.Quantity = item.Quantity;
                    obj.Price_OrderDetail = item.UnitsTotal;
                    db.tbOrderDetails.Add(obj);   
                }
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool EmptyCart(long idCus)
        {
            try
            {
                var cartItems = db.tbCarts.Where(x => x.Id_Customer == idCus);
                foreach (var cartItem in cartItems)
                {
                    db.tbCarts.Remove(cartItem);
                }
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