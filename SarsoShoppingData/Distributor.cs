using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SarsoShoppingData
{
    public class Distributor
    {
        public string Name { get; set; }

        public decimal RegId { get; set; }        

        public string RankImage { get; set; }

        public string Rank { get; set; }

        public string Memtype { get; set; }

        public double  WalletAmount { get; set; }

        public double TotalPayoutEarned { get; set; }

        public int PersonalRecruits { get; set; }
    }
}