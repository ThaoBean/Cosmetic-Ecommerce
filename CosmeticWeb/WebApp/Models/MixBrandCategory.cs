using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp.Models
{
    public class MixBrandCategory
    {
        public IEnumerable<_BrandsBLL> brands { get; set; }
        public IEnumerable<_CategoriesBLL> categories { get; set; }
        //public IEnumerable<_ProductsBLL> products { get; set; }
    }
}