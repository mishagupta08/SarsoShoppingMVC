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
        public string Action { get; set; }
        public KYC_SP_Result KycDetail { get; set; }
    }
}