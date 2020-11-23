using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using SarsoBizDal;


namespace SarsoBizServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ShoppingService" in code, svc and config file together.
    public class ShoppingService : IShoppingService
    {
        readonly string _environment = ConfigurationManager.AppSettings["Environment"];

        public string GetItemCodesFromAttributes(string pcode, string attributes)
        {
            return SarsoBizsDal.Instance.ShoppingModule.GetItemCodesFromAttributes(_environment, pcode, attributes);
        }

        public DataTable TempCart(string action, string UNQId, string pcode, string ItemCode, string Attribute, string Qty)
        {
            return SarsoBizsDal.Instance.ShoppingModule.TempCart(_environment, action, UNQId, pcode, ItemCode, Attribute, Qty);
        }

        public Int32 TempOrder(string UNQId, Int32 regid, Int32 downlineid, string mop, string mopamt, string Fname, string LName, string Mobile, string Address, string City, string District, string state, string PiCode)
        {
            return SarsoBizsDal.Instance.ShoppingModule.TempOrder(_environment, UNQId, regid, downlineid, mop, mopamt, Fname, LName, Mobile, Address, City, District, state, PiCode);
        }
        public DataTable ScOrder(string UNQId, Int32 regid, Int32 downlineid, string mop, string mopamt, string Fname, string LName, string Mobile, string Address, string City, string District, string state, string PiCode, string ordertype, string shpchrg, string scmemtype, string sesid, string ipadd,string coupon)
        {
            return SarsoBizsDal.Instance.ShoppingModule.ScOrder(_environment, UNQId, regid, downlineid, mop, mopamt,Fname, LName, Mobile, Address, City, District, state, PiCode, ordertype, shpchrg, scmemtype, sesid, ipadd,coupon);
        }
        public string SCOrderInvoice(string refno, string billno)
        {
            return SarsoBizsDal.Instance.ShoppingModule.SCOrderInvoice(_environment, refno, billno);
        }
        public DataTable CheckSponsor(string idno)
        {
            return SarsoBizsDal.Instance.ShoppingModule.CheckSponsor(_environment, idno);
        }
        public DataTable ScOrderPG(string orderid, Int32 regid, string ordertype, string shpchrg, string sesid, string ipadd, string scmemtype)
        {
            return SarsoBizsDal.Instance.ShoppingModule.ScOrderPG(_environment, orderid, regid, ordertype, shpchrg, sesid, ipadd, scmemtype);
        }
        public DataTable GVDPurchase(Int32 regid, string ddrefno, DateTime Refdddate, string refddbank, string ddrefbranch,
                                               string reftype, Int32 Pid, Int32 BV, string fullitemcode, string sesid, string fname, string lname, string address,
                                                string mobile, string city, string district, string state, Int32 pin)
        {
            return SarsoBizsDal.Instance.ShoppingModule.GVDPurchase(_environment, regid, ddrefno, Refdddate, refddbank, ddrefbranch,
                                                 reftype, Pid, BV, fullitemcode, sesid, fname, lname, address, mobile, city, district, state, pin);
        
        }
        public string GetAvailableQty(string Action, string pcode, string itemcode, Int32 AvailQty, Int32 OrdQty, Int32 regid)
        {
            return SarsoBizsDal.Instance.ShoppingModule.GetAvailableQty(_environment, Action, pcode, itemcode, AvailQty, OrdQty, regid);
        }

        public Int32 InsertPaymentGateWayLog(string UID, string sessid, string ReqUrl, string parms, string ReturnUrl, string payment, string RegID, string downto)
        {
            return SarsoBizsDal.Instance.ShoppingModule.InsertPaymentGateWayLog(_environment, UID, sessid, ReqUrl, parms, ReturnUrl, payment, RegID, downto);
        }

        public void UpdatePaymentGatewayLog(string action, string UID, string returnparams, string reqsts, string message, string IsFlagged, string PaymentID, string TransactionID, string PaymentMethod, string RequestID)
        {
            SarsoBizsDal.Instance.ShoppingModule.UpdatePaymentGatewayLog(_environment, action, UID, returnparams, reqsts, message, IsFlagged, PaymentID, TransactionID, PaymentMethod, RequestID);
        }
        //rk
        public string GetCouponamt(string Action, string regid, string coupon,string invamt)
        {
            return SarsoBizsDal.Instance.ShoppingModule.GetCouponamt(_environment, Action, regid, coupon, invamt);
        }
        //venkey
        public string CreditPosting(string action, string regid, Double Amount, string billno, string UNQId)
        {
            return SarsoBizsDal.Instance.ShoppingModule.CreditPosting(_environment, action, regid, Amount, billno, UNQId);
        }
        public string InsertCourier(string action, string regid, string Courier, string billno, string type, string UNQId)
        {
            return SarsoBizsDal.Instance.ShoppingModule.InsertCourier(_environment, action, regid, Courier, billno, type,UNQId);
        }
        public string InsertInvProducts(string action, string UNQId, Int32 regid,DataTable dt)
        {
            return SarsoBizsDal.Instance.ShoppingModule.InsertInvProducts(_environment, action, UNQId, regid,dt);
        }
        public string InsertOffProducts(string action, string UNQId, Int32 regid, DataTable dt)
        {
            return SarsoBizsDal.Instance.ShoppingModule.InsertOffProducts(_environment, action, UNQId, regid, dt);
        }
    }
}
