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
    
    public partial class CreateOffer
    {
        public int Sno { get; set; }
        public string OfferCode { get; set; }
        public Nullable<int> PackCode { get; set; }
        public string Type { get; set; }
        public string OffName { get; set; }
        public Nullable<int> NoOfCoupons { get; set; }
        public Nullable<int> CouponValue { get; set; }
        public Nullable<System.DateTime> validFromdate { get; set; }
        public Nullable<System.DateTime> validTodate { get; set; }
        public Nullable<int> OfferSts { get; set; }
        public string IPAddress { get; set; }
        public string SessID { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string Remarks { get; set; }
        public Nullable<System.DateTime> Updatedate { get; set; }
    }
}