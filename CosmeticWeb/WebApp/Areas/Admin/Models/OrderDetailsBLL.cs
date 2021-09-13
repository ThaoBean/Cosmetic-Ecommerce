using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApp.Areas.Admin.Models
{
    public class OrderDetailsBLL
    {
        [Display(Name = "Id Order")]
        public long Id_OrderDetail { get; set; }
        [Display(Name = "Id Order")]
        public Nullable<long> Id_Order { get; set; }
        [Display(Name = "Id Product")]
        public Nullable<long> Id_Product { get; set; }
        [Display(Name = "Quanlity")]
        public Nullable<int> Quantity { get; set; }
        [Display(Name = "Units Total")]
        public Nullable<decimal> Price_OrderDetail { get; set; }
        public bool Status { get; set; }
    }
}