using PagedList;
using System.Collections.Generic;
namespace SarsoShoppingData
{
    public class Response
    {
        public bool status { get; set; }
        public string Message { get; set; }
    }

    public class PagewiseProducts
    {
        public IPagedList<int> pagerCount { get; set; }
        public List<repurchaseproduct> ProductList { get; set; }
        public string order { get; set; }
        public string sortby { get; set; }
        public string SearchString { get; set; }

    }

    public class ProductDetails
    {
        public repurchaseproduct product { get; set; }
        public List<Prod_attributes> productAttr { get; set; }
        public List<Prod_attributes_fields> productAttrFields { get; set; }
        public List<ProductImage> productImage { get; set; }
    }

   
}
