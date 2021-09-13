using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp.Models
{
    public class _CartsBLL
    {
        public long Id_Cart { get; set; }
        public Nullable<long> Id_Customer { get; set; }
        public string Image_Product { get; set; }
        public string Name_Product { get; set; }
        public Nullable<long> Id_Product { get; set; }
        public Nullable<decimal> UnitPrice { get; set; }
        public Nullable<int> Quantity { get; set; }
        public Nullable<decimal> UnitsTotal { get; set; }
        public decimal Total { get; set; }
    }
}