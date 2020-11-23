using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Xml;
using Newtonsoft.Json;


namespace SarsoBizDal
{
    public class ShoppingModule : IShoppingModule
    {
        public string GetItemCodesFromAttributes(string env, string pcode, string attributes)
        {
            return SqlHelpers.GetValue<string>(env, CommandFactory.GetItemCodesFromAttributes(pcode, attributes));
        }

        public DataTable TempCart(string env, string action, string UNQId, string pcode, string ItemCode, string Attribute, string Qty)
        {
            return SqlHelpers.GetTable(env, CommandFactory.TempCart( action,  UNQId,  pcode,  ItemCode,  Attribute,Qty));
        }

        public Int32 TempOrder(string env, string UNQId, Int32 regid, Int32 downlineid, string mop, string mopamt, string Fname, string LName, string Mobile, string Address, string City, string District, string state, string PiCode)
        {
            return SqlHelpers.GetValue<Int32>(env, CommandFactory.TempOrder(UNQId, regid, downlineid, mop,mopamt, Fname,LName, Mobile, Address, City, District, state, PiCode));
        }
        public DataTable ScOrder(string env, string UNQId, Int32 regid, Int32 downlineid, string mop,string mopamt, string Fname, string LName, string Mobile, string Address, string City, string District, string state, string PiCode, string ordertype, string shpchrg, string scmemtype, string sesid, string ipadd,string coupon)
        {
            return SqlHelpers.GetTable(env, CommandFactory.ScOrder(UNQId, regid, downlineid, mop, mopamt, Fname, LName, Mobile, Address, City, District, state, PiCode, ordertype, shpchrg, scmemtype, sesid, ipadd, coupon));
        }
        
        public string SCOrderInvoice(string env, string refno, string billno)
        {
            //return SqlHelpers.GetValue<string>(env, CommandFactory.SCOrderInvoice(refno, billno));

            var xmldata = SqlHelpers.GetXMLObjects(env, CommandFactory.SCOrderInvoice(refno, billno));
            //var dic = XDocument.Parse(xmldata);
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xmldata);
            string json = JsonConvert.SerializeXmlNode(doc);

            return json;
        }
        public DataTable CheckSponsor(string env, string idno)
        {
            return SqlHelpers.GetTable(env, CommandFactory.CheckSponsor(idno));
        }

        public DataTable ScOrderPG(string env, string orderid, Int32 regid, string ordertype, string shpchrg, string sesid, string ipadd, string scmemtype)
        {
            return SqlHelpers.GetTable(env, CommandFactory.ScOrderPG(orderid, regid, ordertype, shpchrg, sesid, ipadd, scmemtype));
        }
        public DataTable GVDPurchase(string env, Int32 regid, string ddrefno, DateTime Refdddate, string refddbank, string ddrefbranch,
                                                string reftype, Int32 Pid, Int32 BV, string fullitemcode, string sesid, string fname, string lname, string address,
                                                string mobile, string city, string district, string state, Int32 pin)
        {
            return SqlHelpers.GetTable(env, CommandFactory.GVDPurchase( regid,  ddrefno,  Refdddate,  refddbank,  ddrefbranch,
                                                 reftype,  Pid,  BV,  fullitemcode,  sesid , fname, lname, address, mobile, city, district, state, pin));
        }
        public string GetAvailableQty(string env, string Action, string pcode, string itemcode, Int32 AvailQty, Int32 OrdQty, Int32 regid)
        {
            return SqlHelpers.GetValue<string>(env, CommandFactory.GetAvailableQty(Action, pcode, itemcode, AvailQty, OrdQty, regid));
        }

        public Int32 InsertPaymentGateWayLog(string env, string UID, string sessid, string ReqUrl, string parms, string ReturnUrl, string payment, string RegID, string downto)
        {
            return SqlHelpers.GetValue<Int32>(env, CommandFactory.InsertPaymentGateWayLog(UID, sessid, ReqUrl, parms, ReturnUrl, payment, RegID, downto));
        }

        public void UpdatePaymentGatewayLog(string env, string action, string UID, string returnparams, string reqsts, string message, string IsFlagged, string PaymentID, string TransactionID, string PaymentMethod, string RequestID)
        {
            SqlHelpers.GetValue<Int32>(env, CommandFactory.UpdatePaymentGatewayLog(action, UID, returnparams, reqsts, message, IsFlagged, PaymentID, TransactionID, PaymentMethod, RequestID));
        }

        //rk
        public string GetCouponamt(string env, string Action, string regid, string coupon, string invamt)
        {
            return SqlHelpers.GetValue<string>(env, CommandFactory.GetCouponamt(Action, regid, coupon,invamt));
        }
        public string CreditPosting(string env, string action, string regid, Double Amount, string billno, string UNQId)
        {
            return SqlHelpers.GetValue<string>(env, CommandFactory.CreditPosting(action, regid, Amount, billno, UNQId));
        }
        public string InsertCourier(string env, string action, string regid, string Courier, string billno, string type, string UNQId)
        {
            return SqlHelpers.GetValue<string>(env, CommandFactory.InsertCourier(action, regid, Courier, billno,type, UNQId));
        }
        public string InsertInvProducts(string env, string action, string UNQId, Int32 regid, DataTable dt)
        {
            return SqlHelpers.GetValue<string>(env, CommandFactory.InsertInvProducts(action, UNQId, regid, dt));
        }
        public string InsertOffProducts(string env, string action, string UNQId, Int32 regid, DataTable dt)
        {
            return SqlHelpers.GetValue<string>(env, CommandFactory.InsertOffProducts(action, UNQId, regid, dt));
        }
    }
}
