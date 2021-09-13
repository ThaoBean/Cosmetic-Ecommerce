using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApp.Areas.Admin.Models
{
    public class NationsBLL
    {
        public long Id_Nation { get; set; }

        [Display(Name ="Tên nước")]
        public string Name_Nation { get; set; }
    }
}