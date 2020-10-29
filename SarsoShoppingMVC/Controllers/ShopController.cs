using SarsoShoppingData;
using SarsoShoppingMVC.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web.Mvc;
using System.Xml.Serialization;

namespace SarsoShoppingMVC.Controllers
{

    public class ShopController : Controller
    {
        public ShopRepository objSRepo = null;
        public Common objCommon = null;

        public ActionResult AddProductInToCart(String ProductCode, int Qty, string ItemCode, string UniqId)
        {
            int? count = 0;
            string Message = string.Empty;
            try
            {
                using (var entities = new sarsobizEntities())
                {
                    var Result = entities.TempCart_SP("Add", UniqId, ProductCode, ItemCode, "", Qty).ToList();
                    if (Result != null)
                    {
                        count = Result.Select(r => r.qty).Sum();
                        Message = Result.FirstOrDefault().result + "-" + count;
                    }

                }
            }
            catch (Exception ex)
            {

            }
            return Json(Message, JsonRequestBehavior.AllowGet);
        }

        public ActionResult getCartCount(string UniqId)
        {
            int? count = 0;
            try
            {
                using (var entities = new sarsobizEntities())
                {
                    if (!string.IsNullOrEmpty(UniqId))
                    {
                        count = entities.TempCarts.Where(r => r.UNQId == UniqId).Select(r => r.Qty).DefaultIfEmpty(0).Sum();
                    }                    
                }
            }
            catch (Exception ex)
            {

            }
            return Json(count, JsonRequestBehavior.AllowGet);
        }

        public ActionResult GetItemCode(String ProductCode, string Fields)
        {
            string itemCode = "";
            try
            {
                using (var entities = new sarsobizEntities())
                {
                    if (string.IsNullOrEmpty(Fields))
                    {
                        Fields = "";
                    }

                    itemCode = entities.GetItemCodesFromAttributes_Sp(ProductCode, Fields).FirstOrDefault();
                }
            }
            catch (Exception ex)
            {

            }
            return Json(itemCode, JsonRequestBehavior.AllowGet);
        }

        public ActionResult GetMemberDetail()
        {
            MemberDetailes_Sp_Result MemDetail = new MemberDetailes_Sp_Result();
            objCommon = new Common();
            objSRepo = new ShopRepository();
            try
            {
                var regId = Convert.ToString(Session["LoginRegId"]);
                var dt = objSRepo.GetMemberDetail(regId);
                var MemDetailList = objCommon.ConvertDataTable<MemberDetailes_Sp_Result>(dt);
                
                if (MemDetailList != null && MemDetailList.Count > 0)
                {
                    MemDetail = MemDetailList.FirstOrDefault();
                }
            }
            catch (Exception ex)
            {

            }
            return Json(MemDetail, JsonRequestBehavior.AllowGet);
        }

        public ActionResult ViewCart()
        {
           
                return View();
            
        }

        public ActionResult CheckLogin()
        {
            string IsLoggedIn = string.Empty;
            IsLoggedIn = "No";

            if (Session["LoginUserName"] != null)
                IsLoggedIn = "Yes";

            return Json(IsLoggedIn, JsonRequestBehavior.AllowGet);
        }

        public ActionResult CartProducts(string Actiontype, string UNQId, string ScRegid)
        {
            objSRepo = new ShopRepository();
            objCommon = new Common();
            var regId = Convert.ToString(Session["LoginRegId"]);
            CartDetails cartDetail = new CartDetails();
            try
            {
                var dt = objSRepo.TempCart(Actiontype, UNQId, "", "", regId, "0");
                var cartProducts = objCommon.ConvertDataTable<TempCart_SP_Result>(dt);
                cartDetail = CalculateTotals(cartProducts);
            }
            catch (Exception ex)
            {

            }
            return PartialView("CartProducts", cartDetail);
        }

        public ActionResult OrderProducts(string Actiontype, string UNQId, string ScRegid)
        {
            objSRepo = new ShopRepository();
            objCommon = new Common();
            CartDetails cartDetail = new CartDetails();
            try
            {
                var dt = objSRepo.TempCart(Actiontype, UNQId, "", "", ScRegid, "0");
                var cartProducts = objCommon.ConvertDataTable<TempCart_SP_Result>(dt);
                cartDetail = CalculateTotals(cartProducts);
            }
            catch (Exception ex)
            {

            }
            return PartialView("OrderProducts", cartDetail);
        }

        public CartDetails CalculateTotals(List<TempCart_SP_Result> cartProduct)
        {
            CartDetails cartDetail = new CartDetails();
            objCommon = new Common();
            try
            {
                cartDetail.TotalPrice = cartProduct.Select(item => item.price * item.qty).Sum() ?? 0;
                cartDetail.TotalCV = cartProduct.Select(item => item.pv * item.qty).Sum() ?? 0;
                cartDetail.TotalDP = cartProduct.Select(item => item.DP * item.qty).Sum() ?? 0;
                cartDetail.TotalQty = cartProduct.Select(item => item.qty).Sum() ?? 0;
                cartDetail.CartProducts = cartProduct;
                var regId = Convert.ToString(Session["LoginRegId"]);

                //var MemDetail = objSRepo.GetMemberDetail(regId);
                //-------
                var dt = objSRepo.GetMemberDetail(regId);
                var MemDetailList = objCommon.ConvertDataTable<MemberDetailes_Sp_Result>(dt);
                var MemDetail = new MemberDetailes_Sp_Result();
                if (MemDetailList != null && MemDetailList.Count > 0)
                {
                    MemDetail = MemDetailList.FirstOrDefault();
                }
                //---------

                if (MemDetail.state.ToUpper() == "HARYANA")
                {
                    cartDetail.CGST = true;
                    cartDetail.SGST = true;
                    cartDetail.IGST = false;
                    cartDetail.CGSTP = true;
                    cartDetail.SGSTP = true;
                    cartDetail.IGSTP = false;
                    cartDetail.CGSTPV = true;
                    cartDetail.SGSTPV = true;
                    cartDetail.IGSTPV = false;

                    cartDetail.TaxAmt = cartProduct.Select(item => (item.price * item.qty) - (((item.price * item.qty) / (100 + (item.CGST + item.SGST))) * 100)).Sum() ?? 0;
                    cartDetail.CGSTTax = cartProduct.Select(item => (item.price * item.qty) - (((item.price * item.qty) / (100 + (item.CGST))) * 100)).Sum() ?? 0;
                    cartDetail.SGSTTax = cartProduct.Select(item => (item.price * item.qty) - (((item.price * item.qty) / (100 + (item.SGST))) * 100)).Sum() ?? 0;
                }

                else
                {
                    cartDetail.CGST = false;
                    cartDetail.SGST = false;
                    cartDetail.IGST = true;
                    cartDetail.CGSTP = false;
                    cartDetail.SGSTP = false;
                    cartDetail.IGSTP = true;
                    cartDetail.CGSTPV = false;
                    cartDetail.SGSTPV = false;
                    cartDetail.IGSTPV = true;

                    cartDetail.IGSTTaxAmt = cartProduct.Select(item => (item.price * item.qty) - (((item.price * item.qty) / (100 + (item.IGST))) * 100)).Sum() ?? 0;
                    cartDetail.TaxAmt = cartProduct.Select(item => (item.price * item.qty) - (((item.price * item.qty) / (100 + (item.IGST))) * 100)).Sum() ?? 0;
                }

            }
            catch (Exception ex)
            {

            }
            return cartDetail;
        }

        [HttpPost]
        public ActionResult payPaytm(PaytmGateway objpay)
        {
            objpay.regid = Convert.ToString(Session["LoginRegId"]);
            //var result = objTransacManager.CreditRequestOnlineInsert(objpay);
            Response.Redirect(@"~/SCPaymentGateway.aspx?Mobile=" + objpay.Mobile + "&UniQID=" + objpay.UniQID + "&shpcharge=" + objpay.shpcharge + "&ORDER_ID=" + objpay.ORDER_ID + "&regid=" + objpay.regid + "&scmemtype=" + objpay.scmemtype + "&amount=" + objpay.amount + "&coupon=" + objpay.coupon + "&email=" + objpay.email);
            return new EmptyResult();
        }

        [HttpPost]
        public ActionResult PlaceOrder(string UNQId, string regid, string downlineid, string mop, string mopamt, string Fname, string LName, string Mobile, string Address, string City, string District, string state, string PiCode)
        {
            int OrderNo = 0;
            try
            {
                objSRepo = new ShopRepository();
                regid = Convert.ToString(Session["LoginRegId"]);
                OrderNo = objSRepo.TempOrder(UNQId, regid, "0", mop, mopamt, Fname, LName, Mobile, Address, City, District, state, PiCode);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            return Json(OrderNo, JsonRequestBehavior.AllowGet);
        }

        public ActionResult ShippingAddress()
        {
            objSRepo = new ShopRepository();
            objCommon = new Common();
            if (Session["LoginUserName"] != null)
            {
                var regId = Convert.ToString(Session["LoginRegId"]);

                var dt = objSRepo.GetMemberDetail(regId);
                var MemDetailList = objCommon.ConvertDataTable<MemberDetailes_Sp_Result>(dt);
                var MemDetail = new MemberDetailes_Sp_Result();
                if (MemDetailList != null && MemDetailList.Count > 0)
                {
                    MemDetail = MemDetailList.FirstOrDefault();
                }

                //----------

                var StateList = objSRepo.GetStates();
                ViewBag.StateList = StateList;
                return View(MemDetail);
            }
            return null;
        }

        public ActionResult GetProductQuickView(string ProdID)
        {
            ProductDetails objProduct = new ProductDetails();
            HomeController objhome = new HomeController();
            try
            {
                objProduct = objhome.GetProductInfo(ProdID);
            }
            catch (Exception ex)
            {
                throw ex;

            }
            return PartialView("QuickBuy", objProduct);
        }

        public ActionResult GetQuickSearchProducts(string Actiontype)
        {
            DataTable dt = new DataTable();            
            objSRepo = new ShopRepository();
            objCommon = new Common();

            dt = objSRepo.Call_Getrpcategories(Actiontype, "", "");
            List<repurchaseproduct> productList = new List<repurchaseproduct>();
            productList = objCommon.ConvertDataTable<repurchaseproduct>(dt);           
            if (productList != null)
            {               
                productList = productList.Select(r => new repurchaseproduct
                {
                    Descr = !string.IsNullOrEmpty(r.Descr) ? Regex.Replace(r.Descr, @"<[^>]+>|&nbsp;", "").Trim() : "",
                    PCode = r.pcode,
                    PName = r.PName,
                    pcode = r.pcode,
                    Pname = r.Pname,
                    MRP = r.MRP,
                    PV = r.pv,
                    product = r.product,
                    offprice = r.offprice,
                    Category = r.Category,
                    SubCategory = r.SubCategory,
                    SubCategoryone = r.SubCategoryone
                }).ToList();
            }            
            return Json(productList,JsonRequestBehavior.AllowGet);
        }

        public ActionResult RepurchaseInvoice()
        {
            return View();

        }


        public ActionResult GetInvoice(string reqno, string billno)
        {
            Invoice InvoicePrint = new Invoice();
            try
            {
                using (var entities = new sarsobizEntities())
                {
                    var SCReponse = entities.SCOrderInvoice_SP(reqno, billno).FirstOrDefault();
                    XmlSerializer serializer = new XmlSerializer(typeof(Invoice));
                    StringReader rdr = new StringReader(SCReponse);
                    InvoicePrint = (Invoice)serializer.Deserialize(rdr);

                    if (InvoicePrint.Receipt.Shoppingaddress.state == "HARYANA") {
                        InvoicePrint.Receipt.CGSTP = true;
                        InvoicePrint.Receipt.SGSTP = true;
                        InvoicePrint.Receipt.IGSTP = false;
                        InvoicePrint.Receipt.CGSTPV = true;
                        InvoicePrint.Receipt.SGSTPV = true;
                        InvoicePrint.Receipt.IGSTPV = false;
                        InvoicePrint.Receipt.TaxType = "CGST & SGST";
                    }
                else {
                        InvoicePrint.Receipt.CGSTP = false;
                        InvoicePrint.Receipt.SGSTP = false;
                        InvoicePrint.Receipt.IGSTP = true;
                        InvoicePrint.Receipt.CGSTPV = false;
                        InvoicePrint.Receipt.SGSTPV = false;
                        InvoicePrint.Receipt.IGSTPV = true;
                        InvoicePrint.Receipt.TaxType = "IGST";
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return PartialView("_Invoice", InvoicePrint);
        }
    }
}