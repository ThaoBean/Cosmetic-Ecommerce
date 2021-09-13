using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp.Areas.Admin.Models
{
    public class CustomersBLL
    {
        public long Id_Customer { get; set; }
        public string Name_Customer { get; set; }
        public string Email_Customer { get; set; }
        public string Addr_Customer { get; set; }
        public string Phone_Customer { get; set; }
        public string Password_Customer { get; set; }
        public Nullable<System.DateTime> Date_Created { get; set; }
    }
}