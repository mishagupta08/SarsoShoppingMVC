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
    
    public partial class CustomerOrder
    {
        public int SNo { get; set; }
        public Nullable<decimal> regid { get; set; }
        public string ProofType { get; set; }
        public string OrderNo { get; set; }
        public string OrderPhoto { get; set; }
        public string Bank { get; set; }
        public string Accno { get; set; }
        public string Branch { get; set; }
        public string Ifscode { get; set; }
        public string ChqLeaf { get; set; }
        public Nullable<int> OrderSts { get; set; }
        public Nullable<System.DateTime> Dated { get; set; }
        public string Sesid { get; set; }
        public string Remarks { get; set; }
        public Nullable<int> AppRejBy { get; set; }
        public Nullable<System.DateTime> AppRejDate { get; set; }
        public string AppRejSesid { get; set; }
        public string AppRejRemarks { get; set; }
    }
}
