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
    
    public partial class RandomCoupon
    {
        public int Sno { get; set; }
        public string CouponCode { get; set; }
        public string OfferCode { get; set; }
        public Nullable<int> CouponValue { get; set; }
        public Nullable<int> PackCode { get; set; }
        public Nullable<int> AssignSts { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> Regid { get; set; }
        public Nullable<int> UsedBy { get; set; }
        public Nullable<System.DateTime> AssignDate { get; set; }
        public string billno { get; set; }
        public Nullable<System.DateTime> UsedDate { get; set; }
        public string UsedBillno { get; set; }
        public Nullable<decimal> MinAmt { get; set; }
        public Nullable<decimal> MaxAmt { get; set; }
        public Nullable<System.DateTime> CoupValidity { get; set; }
    }
}