using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SarsoShoppingData
{
    public class DashboardViewModel
    {
        public Distributor DistributorDetail { get; set; }

        public MyProfile ProfileDetail { get; set; }

        public MemberCV_SP_Result CVDetail { get; set; }

        public MemberCV_SP_Result OverAllCVDetail { get; set; }        

        public List<Orders> OrderList { get; set; }

        public List<Sicp_detail> Sicp_detail { get; set; }
    } 

    public class Sicp_detail
    {
        public string teamtype { get; set; }
        public string Name { get; set; }
        public decimal? CURtotalGCV { get; set; }
        public decimal?  totalGCV { get; set; }
    }

    public class KYC
    {
        public KYC_Address KycPAN { get; set; }
        public KYC_Address KycAddress { get; set; }
        public KYC_Bank KycBank { get; set; }
    }

    public class KYC_Address
    {
        public string res { get; set; }
        public string ProofType { get; set; }
        public string panno { get; set; }
        public string Remarks { get; set; }
        public string PANPhoto { get; set; }
        public string kycsts { get; set; }
    }

    public class KYC_Bank
    {
        public string res { get; set; }
        public string panno { get; set; }
        public string Bank { get; set; }
        public string Branch { get; set; }
        public string Accno { get; set; }
        public string ifscode { get; set; }
        public string Remark { get; set; }
        public string PANPhoto { get; set; }
        public string kycst{ get; set; }
    }
}