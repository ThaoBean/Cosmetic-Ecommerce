using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp.Models
{
    public class MixCartOrder
    {
        public _CartsBLL MCart { get; set; }
        public _OrdersBLL MOrder { get; set; }
    }
}