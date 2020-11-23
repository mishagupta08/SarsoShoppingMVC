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

        public List<Orders> OrderList { get; set; }
    }
}