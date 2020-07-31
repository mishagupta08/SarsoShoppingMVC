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
    }
}
