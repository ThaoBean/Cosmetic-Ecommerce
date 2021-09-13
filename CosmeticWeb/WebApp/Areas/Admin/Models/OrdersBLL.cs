using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DataModels;

namespace WebApp.Areas.Admin.Models
{
    public class OrdersBLL
    {
        public long Id_Order { get; set; }
        public Nullable<long> Id_Customer { get; set; }
        public string Shipping_Addr { get; set; }
        public string Phone_Reciever { get; set; }
        public string Name_Reciever { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public Nullable<decimal> Price_Total { get; set; }
        public Nullable<bool> Status { get; set; }
        public string Name_Customer { get; set; }
    }
}