using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApp.Models
{
    public class _CustomersBLL
    {
        public long Id_Customer { get; set; }

        [Required]
        [Display(Name ="Username")]
        public string Name_Customer { get; set; }

        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "E-mail is not valid")]
        [Display(Name = "Email")]
        [Required]
        public string Email_Customer { get; set; }

        public string Addr_Customer { get; set; }

        public string Phone_Customer { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password_Customer { get; set; }

        public DateTime Date_Created { get; set; }
    }
}