//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SarsoShoppingData
{
    using System;
    using System.Collections.Generic;
    
    public partial class ProductPrice
    {
        public int slno { get; set; }
        public string pcode { get; set; }
        public string pname { get; set; }
        public Nullable<decimal> price { get; set; }
        public Nullable<double> vatrate { get; set; }
        public Nullable<decimal> vatamt { get; set; }
        public Nullable<decimal> totamt { get; set; }
        public string state { get; set; }
        public Nullable<double> cstrate { get; set; }
        public Nullable<decimal> cstamt { get; set; }
        public Nullable<bool> allow { get; set; }
    }
}