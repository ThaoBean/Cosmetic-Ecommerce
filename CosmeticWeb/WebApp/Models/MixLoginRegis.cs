using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp.Models
{
    public class MixLoginRegis
    {
        public _LoginBLL MLogin { get; set; }

        public _CustomersBLL MRegister { get; set; }
    }
}