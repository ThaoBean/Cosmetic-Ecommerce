using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApp.Models
{
    public class _LoginBLL
    {
        [Required]
        [Display(Name = "Username")]
        public string Name_Customer { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password_Customer { get; set; }
    }
}