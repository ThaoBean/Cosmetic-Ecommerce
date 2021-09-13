using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebApp.Areas.Admin.Models
{
    public class UsersBLL
    {
        public long Id_User { get; set; }
        [Required(ErrorMessage ="Hãy nhập tên người dùng")]
        public string Name_User { get; set; }

        [Required(ErrorMessage = "Hãy nhập email")]
        public string Email_User { get; set; }
        [Required(ErrorMessage = "Hãy nhập mật khẩu")]
        public string Password_User { get; set; }
        public Nullable<System.DateTime> Date_Created_User { get; set; }
        public Nullable<bool> Status_User { get; set; }

    }
}