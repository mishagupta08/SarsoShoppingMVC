using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SarsoShoppingData
{
    class Orders
    {
        public int Sno { get; set; }

        public string RefNo { get; set; }

        public DateTime DateOfPurchase { get; set; }

        public double CvPoints { get; set; }

        public double BonusCvPoints { get; set; }

        public double Amount { get; set; }

        public string InvoiceDetail { get; set; }

        public string PaymentReceipt { get; set; }

        public string CourierDetail { get; set; }
    }
}
