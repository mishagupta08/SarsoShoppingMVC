using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SarsoShoppingData
{
    public partial class MemberProfile
    {
        public int SponserID { get; set; }
        public string CompanyName { get; set; }
        public string MobileNo { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string cnfPassword { get; set; }
        public string UserNo { get; set; }
    }

    public partial class repurchaseproduct
    {
        public Nullable<decimal> MRP { get; set; }
        public string pcode { get; set; }
        public string Pname { get; set; }
        public int MostpopularCnt { get; set; }
        public int qty { get; set; }
        public decimal pv { get; set; }
        public string product { get; set; }

    }

    public partial class rpcategory
    {
        public int PrdCnt { get; set; }
    }
    }
