using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebApp.Models
{
    public class _CategoriesBLL
    {
        public long Id_Category { get; set; }

        [Display(Name ="Tên loại")]
        public string Name_Category { get; set; }
    }
}