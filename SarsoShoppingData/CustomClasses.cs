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
}
