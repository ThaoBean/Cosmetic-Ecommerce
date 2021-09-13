using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp.Models
{
    public class _OrderDetails
    {
        public long Id_OrderDetail { get; set; }
        public Nullable<long> Id_Order { get; set; }
        public Nullable<long> Id_Product { get; set; }
        public Nullable<int> Quantity { get; set; }
        public Nullable<decimal> Price_OrderDetail { get; set; }
    }
}