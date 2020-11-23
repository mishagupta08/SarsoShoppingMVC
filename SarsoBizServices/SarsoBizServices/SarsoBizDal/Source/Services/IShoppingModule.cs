using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace SarsoBizDal
{
    public interface IShoppingModule
    {
        string GetItemCodesFromAttributes(string env, string pcode, string attributes);

        DataTable TempCart(string env, string action, string UNQId, string pcode, string ItemCode, string Attribute, string Qty);

        Int32 TempOrder(string env, string UNQId, Int32 regid, Int32 downlineid, string mop, string mopamt, string Fname, string LName, string Mobile, string Address, string City, string District, string state, string PiCode);

        DataTable ScOrder(string env, string UNQId, Int32 regid, Int32 downlineid, string mop,string mopamt, string Fname, string LName, string Mobile, string Address, string City, string District, string state, string PiCode, string ordertype, string shpchrg, string scmemtype, string sesid, string ipadd,string coupon);

        string SCOrderInvoice(string env, string refno, string billno);

        DataTable CheckSponsor(string env, string idno);

        DataTable ScOrderPG(string env, string orderid, Int32 regid, string ordertype, string shpchrg, string sesid, string ipadd, string scmemtype);
       
        DataTable GVDPurchase(string env, Int32 regid, string ddrefno, DateTime Refdddate, string refddbank, string ddrefbranch,
                                               string reftype, Int32 Pid, Int32 BV, string fullitemcode, string sesid, string fname, string lname, string address,
                                                string mobile, string city, string district, string state, Int32 pin);
        string GetAvailableQty(string env, string Action, string pcode, string itemcode, Int32 AvailQty, Int32 OrdQty, Int32 regid);

        Int32 InsertPaymentGateWayLog(string env, string UID, string sessid, string ReqUrl, string parms, string ReturnUrl, string payment, string RegID, string downto);

        void UpdatePaymentGatewayLog(string env, string action, string UID, string returnparams, string reqsts, string message, string IsFlagged, string PaymentID, string TransactionID, string PaymentMethod, string RequestID);

        //rk
        string GetCouponamt(string env, string Action, string regid, string coupon, string invamt);
        string CreditPosting(string env, string action, string regid, Double Amount, string billno, string UNQId);
        string InsertCourier(string env, string action, string regid, string Courier, string billno, string type, string UNQId);
        string InsertInvProducts(string env, string action, string UNQId, Int32 regid,DataTable dt);
        string InsertOffProducts(string env, string action, string UNQId, Int32 regid, DataTable dt);

      
    }
}
