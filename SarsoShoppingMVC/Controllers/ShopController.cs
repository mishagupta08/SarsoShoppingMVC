using SarsoShoppingData;
using SarsoShoppingMVC.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;

namespace SarsoShoppingMVC.Controllers
{

    public class ShopController : Controller
    {
        public ShopRepository objSRepo = null;
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
            objSRepo = new ShopRepository();
            try
            {
                var regId = Convert.ToString(Session["LoginRegId"]);
                var dt = objSRepo.GetMemberDetail(regId);
                var MemDetailList = ConvertDataTable<MemberDetailes_Sp_Result>(dt);
                
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
            var regId = Convert.ToString(Session["LoginRegId"]);
            CartDetails cartDetail = new CartDetails();
            try
            {
                var dt = objSRepo.TempCart(Actiontype, UNQId, "", "", regId, "0");
                var cartProducts = ConvertDataTable<TempCart_SP_Result>(dt);
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
            CartDetails cartDetail = new CartDetails();
            try
            {
                var dt = objSRepo.TempCart(Actiontype, UNQId, "", "", ScRegid, "0");
                var cartProducts = ConvertDataTable<TempCart_SP_Result>(dt);
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
                var MemDetailList = ConvertDataTable<MemberDetailes_Sp_Result>(dt);
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
            var regId = Convert.ToString(Session["LoginRegId"]);
            //            var MemDetail = objSRepo.GetMemberDetail(regId);
            //--------
            var dt = objSRepo.GetMemberDetail(regId);
            var MemDetailList = ConvertDataTable<MemberDetailes_Sp_Result>(dt);
            var MemDetail = new MemberDetailes_Sp_Result();
            if (MemDetailList != null && MemDetailList.Count > 0 )
            {
                MemDetail = MemDetailList.FirstOrDefault();
            }            
            
            //----------

            var StateList = objSRepo.GetStates();
            ViewBag.StateList = StateList;
            return View(MemDetail);
        }


        private static List<T> ConvertDataTable<T>(DataTable dt)
        {
            List<T> data = new List<T>();
            foreach (DataRow row in dt.Rows)
            {
                T item = GetItem<T>(row);
                data.Add(item);
            }
            return data;
        }
        private static T GetItem<T>(DataRow dr)
        {
            Type temp = typeof(T);
            T obj = Activator.CreateInstance<T>();

            foreach (DataColumn column in dr.Table.Columns)
            {
                foreach (PropertyInfo pro in temp.GetProperties())
                {
                    if (pro.Name == column.ColumnName)
                        pro.SetValue(obj, dr[column.ColumnName], null);
                    else
                        continue;
                }
            }
            return obj;
        }
    }
}