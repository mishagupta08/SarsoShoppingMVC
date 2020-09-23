using PagedList;
using System.Collections.Generic;
namespace SarsoShoppingData
{
    public class Response
    {
        public bool status { get; set; }
        public string Message { get; set; }
        public int Regid { get; set; }
    }

    public class PagewiseProducts
    {
        public IPagedList<int> pagerCount { get; set; }
        public List<repurchaseproduct> ProductList { get; set; }
        public string order { get; set; }
        public string sortby { get; set; }
        public string SearchString { get; set; }

    }
   
    public class PaytmGateway
    {
        public string ORDER_ID { get; set; }
        public decimal Mobile { get; set; }
        public string UniQID { get; set; }
        public string regid { get; set; }
        public string amount { get; set; }
        public string shpcharge { get; set; }
        public string scmemtype { get; set; }
        public string email { get; set; }
        public string coupon { get; set; }
        public string PaymentStatus { get; set; }
        public string BillStatus { get; set; }
        public string TxnId { get; set; }
        public string pgType { get; set; }
        public string pgTranStatus { get; set; }
        public string action { get; set; }
    }

    public class ProductDetails
    {
        public repurchaseproduct product { get; set; }
        public List<Prod_attributes> productAttr { get; set; }
        public List<Prod_attributes_fields> productAttrFields { get; set; }
        public List<ProductImage> productImage { get; set; }
    }

    public class CartDetails
    {
        public List<TempCart_SP_Result> CartProducts { get; set; }
        public decimal TotalPrice { get; set; }
        public decimal IGSTTaxAmt { get; set; }
        public decimal CGSTTax { get; set; }
        public decimal SGSTTax { get; set; }
        public decimal TaxAmt { get; set; }
        public decimal TotalDP { get; set; }
        public decimal TotalQty { get; set; }
        public decimal TotalCV { get; set; }
        public bool CGST { get; set; }
        public bool SGST{ get; set; }
        public bool IGST { get; set; }
        public bool CGSTP { get; set; }
        public bool SGSTP { get; set; }
        public bool IGSTP { get; set; }
        public bool CGSTPV { get; set; }
        public bool SGSTPV{ get; set; }
        public bool IGSTPV { get; set; }
        

    }

   
}
