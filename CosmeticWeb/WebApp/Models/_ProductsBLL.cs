using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp.Models
{
    public class _ProductsBLL
    {
        public long Id_Product { get; set; }
        public Nullable<long> Id_Brand { get; set; }
        public Nullable<long> Id_Nation { get; set; }
        public Nullable<long> Id_Category { get; set; }
        public string Name_Product { get; set; }
        public string Description_Product { get; set; }
        public string Detail_Product { get; set; }
        public string Image_Product { get; set; }
        public Nullable<int> Quality_Product { get; set; }
        public long Price_Product { get; set; }
        //public Nullable<decimal> Sale_Product { get; set; }
        public long Sale_Product { get; set; }
        public Nullable<bool> Hot_Product { get; set; }
        public Nullable<int> Rate_Total_Product { get; set; }
        public string Name_Brand { get; set; }

        public string Name_Nation { get; set; }
        public string Name_Category { get; set; }
        public long Price { get; set; }
    }
}