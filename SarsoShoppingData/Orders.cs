using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SarsoShoppingData
{
    public class Orders
    {
        public string Sno { get; set; }

        public string RefNo { get; set; }

        public string DateOfPurchase { get; set; }

        public string CvPoints { get; set; }

        public string BonusCvPoints { get; set; }

        public string Amount { get; set; }

        public string InvoiceDetail { get; set; }

        public string InvDate { get; set; }        

        public string PaymentReceipt { get; set; }

        public string CourierDetail { get; set; }

        public string DispatchCourierName { get; set; }

        public string CourierAddress { get; set; }
    }
}
