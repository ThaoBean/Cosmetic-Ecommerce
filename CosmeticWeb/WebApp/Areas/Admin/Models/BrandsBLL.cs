using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApp.Areas.Admin.Models
{
    public class BrandsBLL
    {
        public long Id_Brand { get; set; }
        [Display(Name ="Tên hãng")]
        public string Name_Brand { get; set; }
    }
}