//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataModels
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbReviewer
    {
        public long Id_Reviewer { get; set; }
        public Nullable<long> Id_Product { get; set; }
        public Nullable<long> Id_Customer { get; set; }
        public string Content { get; set; }
        public Nullable<System.DateTime> Date_Created_Reviewer { get; set; }
        public Nullable<int> Rate_Reviewer { get; set; }
    
        public virtual tbCustomer tbCustomer { get; set; }
        public virtual tbProduct tbProduct { get; set; }
    }
}