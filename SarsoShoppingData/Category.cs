using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SarsoShoppingData
{
    public class GVDPackage
    {
        public int PID { get; set; }
        public string PackCode { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public double BV { get; set; }
        public string Title { get; set; }
        public string Photo { get; set; }
    }


    public class E_Category {
        public int ID { get; set; }
        public string Name { get; set; }
        public List<E_SubCategory> SubCatList { get; set; }

    }

    public class E_SubCategory
    {
        public int ID { get; set; }
        public string Name { get; set; }

    }
}
