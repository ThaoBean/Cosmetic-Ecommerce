using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApp.Areas.Admin.Models
{
    public class CategoriesBLL
    {
        public long Id_Category { get; set; }

        [Display(Name ="Tên thể loại")]
        public string Name_Category { get; set; }
    }
}