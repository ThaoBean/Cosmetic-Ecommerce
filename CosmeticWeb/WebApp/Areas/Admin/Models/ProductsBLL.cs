using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApp.Areas.Admin.Models
{
    public class ProductsBLL
    {
        
        [Display(Name = "Id")]
        public long Id_Product { get; set; }
        [Display(Name = "Brand")]
        public Nullable<long> Id_Brand { get; set; }
        [Display(Name = "Nation")]
        public Nullable<long> Id_Nation { get; set; }
        [Display(Name = "Category")]
        public Nullable<long> Id_Category { get; set; }
        [Display(Name = "Product")]
        public string Name_Product { get; set; }

        [Display(Name = "Description")]
        public string Description_Product { get; set; }
        [Display(Name = "Detail")]
        public string Detail_Product { get; set; }
        [Display(Name = "Image")]
        public string Image_Product { get; set; }
        [Display(Name = "Quantity")]
        public Nullable<int> Quality_Product { get; set; }
        [Display(Name = "Price")]
        public Nullable<decimal> Price_Product { get; set; }
        [Display(Name = "Sale")]
        public Nullable<decimal> Sale_Product { get; set; }
        [Display(Name = "Hot")]
        public Nullable<bool> Hot_Product { get; set; }
        [Display(Name = "Rate")]
        public Nullable<int> Rate_Total_Product { get; set; }

        public string Name_Brand { get; set; }
        public string Name_Nation { get; set; }
        public string Name_Category { get; set; }
    }
}