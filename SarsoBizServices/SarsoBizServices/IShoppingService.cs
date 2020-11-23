using System;
using System.Data;
using System.ServiceModel;

namespace SarsoBizServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IShoppingService" in both code and config file together.
    [ServiceContract]
    public interface IShoppingService
    {
        [OperationContract]
        string GetItemCodesFromAttributes(string pcode, string attributes);

        [OperationContract]
        DataTable TempCart(string action, string UNQId, string pcode, string ItemCode, string Attribute, string Qty);

        [OperationContract]
        Int32 TempOrder(string UNQId, Int32 regid, Int32 downlineid, string mop, string mopamt, string Fname, string LName, string Mobile, string Address, string City, string District, string state, string PiCode);

        [OperationContract]
        DataTable ScOrder(string UNQId, Int32 regid, Int32 downlineid, string mop, string mopamt, string Fname, string LName, string Mobile, string Address, string City, string District, string state, string PiCode, string ordertype, string shpchrg, string scmemtype, string sesid, string ipadd, string coupon);

        [OperationContract]
        string SCOrderInvoice(string refno, string billno);

        [OperationContract]
        DataTable CheckSponsor(string idno);

        [OperationContract]
        DataTable ScOrderPG(string orderid, Int32 regid,string ordertype, string shpchrg, string sesid, string ipadd, string scmemtype);

        [OperationContract]
        DataTable GVDPurchase(Int32 regid, string ddrefno, DateTime Refdddate, string refddbank, string ddrefbranch,
                                               string reftype, Int32 Pid, Int32 BV, string fullitemcode, string sesid, string fname, string lname, string address,
                                                string mobile, string city, string district, string state, Int32 pin);
        [OperationContract]
        string GetAvailableQty(string Action, string pcode, string itemcode, Int32 AvailQty, Int32 OrdQty, Int32 regid);

        [OperationContract]
        Int32 InsertPaymentGateWayLog(string UID, string sessid, string ReqUrl, string parms, string ReturnUrl, string payment, string RegID, string downto);

        [OperationContract]
        void UpdatePaymentGatewayLog(string action, string UID, string returnparams, string reqsts, string message, string IsFlagged, string PaymentID, string TransactionID, string PaymentMethod, string RequestID);
        //rk
        [OperationContract]
        string GetCouponamt(string Action, string regid, string coupon, string invamt);
        [OperationContract]
        string CreditPosting(string action, string regid, Double Amount, string billno, string UNQId);
        [OperationContract]
        string InsertCourier(string action, string regid, string Courier, string billno, string type, string UNQId);
        [OperationContract]
        string InsertInvProducts(string action, string UNQId, Int32 regid, DataTable dt);
        [OperationContract]
        string InsertOffProducts(string action, string UNQId, Int32 regid, DataTable dt);
    }
}
