using paytm;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web.UI;
using SarsoShoppingData;
using SarsoShoppingMVC.Models;

namespace CreditResponse
{
    public partial class CreditResponse : System.Web.UI.Page
    {

        string responseparm = "";
        string resmerchantrefno = "";
        string lbl_MID = string.Empty;
        string lbl_TXNID = string.Empty;
        string lbl_ORDERID = string.Empty;
        string lbl_BANKTXNID = string.Empty;
        string lbl_TXNAMOUNT = string.Empty;
        string lbl_CURRENCY = string.Empty;
        string lbl_STATUS = string.Empty;
        string lbl_RESPCODE = string.Empty;
        string lbl_RESPMSG = string.Empty;
        string lbl_TXNDATE = string.Empty;
        string lbl_GATEWAYNAME = string.Empty;
        string lbl_BANKNAME = string.Empty;
        string lbl_PAYMENTMODE = string.Empty;
        string lbl_CHECKSUMHASH = string.Empty;
        string lbl_EMAIL = string.Empty;
        string lbl_MOBILE_NO = string.Empty;
        string lbl_CUST_ID = string.Empty;
        string lblerrormsg = string.Empty;
        protected void Page_Load(object sender, EventArgs e)
        {

            try
            {
                lbl_MID = Request.Form["MID"];
                lbl_TXNID = Request.Form["TXNID"];
                lbl_ORDERID = Request.Form["ORDERID"];
                lbl_BANKTXNID = Request.Form["BANKTXNID"];
                lbl_TXNAMOUNT = Request.Form["TXNAMOUNT"];
                lbl_CURRENCY = Request.Form["CURRENCY"];
                lbl_STATUS = Request.Form["STATUS"];
                lbl_RESPCODE = Request.Form["RESPCODE"];
                lbl_RESPMSG = Request.Form["RESPMSG"];
                lbl_TXNDATE = Request.Form["TXNDATE"];
                lbl_GATEWAYNAME = Request.Form["GATEWAYNAME"];
                lbl_BANKNAME = Request.Form["BANKNAME"];
                lbl_PAYMENTMODE = Request.Form["PAYMENTMODE"];
                lbl_CHECKSUMHASH = Request.Form["CHECKSUMHASH"];
                lbl_EMAIL = Request.Form["EMAIL"];
                lbl_MOBILE_NO = Request.Form["MOBILE_NO"];
                lbl_CUST_ID = Request.Form["CUST_ID"];
                OrderRepository objORepo = new OrderRepository();
                Common objCommon = new Common();

                List<KeyValuePair<string, string>> postparamslist = new List<KeyValuePair<string, string>>();
                for (int i = 0; i < Request.Form.Keys.Count; i++)
                {
                    KeyValuePair<string, string> postparam = new KeyValuePair<string, string>(Request.Form.Keys[i],
                                                                                              Request.Form[i]);
                    postparamslist.Add(postparam);
                }

                foreach (KeyValuePair<string, string> param in postparamslist)
                {
                    if (param.Key == "ORDERID") resmerchantrefno = param.Value != null ? param.Value : "";
                    responseparm += (param.Key + ":" + param.Value + "|");
                }

                LogResponse(resmerchantrefno, responseparm);


                using (var entities = new sarsobizEntities())
                {
                    if (lbl_STATUS == "TXN_SUCCESS")
                    {

                        if (IsValidChecksum())
                        {

                            var dtonline = entities.GetSCOnline_SP(lbl_ORDERID).FirstOrDefault();
                            if (dtonline != null)
                            {
                                var dt = objORepo.CallSCOrder(lbl_ORDERID, Convert.ToInt32(dtonline.regid.ToString()), "PAYTM",
                                                         dtonline.shpcharge, "", "",
                                                         dtonline.scmemtype.ToString());
                                if (dt.Rows.Count > 0)
                                {
                                    if (dt.Rows[0]["res"].ToString() == "")
                                    {
                                        if (Convert.ToDecimal(dtonline.amount.ToString()) == Convert.ToDecimal(lbl_TXNAMOUNT))
                                        {

                                            int cnt = entities.SCOnlineInsert_Sp("UPDATE", 0, 0, "", lbl_ORDERID,
                                                                            "SUCCESS", "SUCCESS", lbl_TXNID,
                                                                            dt.Rows[0]["billno"].ToString(), "", 0, "", "").FirstOrDefault()?? 0;

                                            LogOnlineData("SUCCESS");

                                            ScriptManager.RegisterClientScriptBlock(this, GetType(), "clientScript",
                                                                                    "javascript:repurchaseInvoice('" +
                                                                                    dt.Rows[0]["reqno"] + "','" +
                                                                                    dt.Rows[0]["billno"] + "')", true);
                                        }
                                        else
                                        {
                                            //payment success bill failed
                                            int cnt = entities.SCOnlineInsert_Sp("UPDATE", 0, 0, "", lbl_ORDERID,
                                                                            "SUCCESS", "PAYMENT SUCCESS BILL FAILED",
                                                                            lbl_TXNID, "", "", 0, "", "").FirstOrDefault() ?? 0;

                                            LogOnlineData("PAYMENT SUCCESS BILL FAILED Amount Mismatch");
                                            lblerrormsg =
                                                "PAYMENT SUCCESS BILL FAILED Amount Mismatch for Order id: " +
                                                lbl_ORDERID;
                                        }
                                    }
                                }
                                else
                                {
                                    //payment success bill failed

                                    int cnt = entities.SCOnlineInsert_Sp("UPDATE", 0, 0, "", lbl_ORDERID, "SUCCESS",
                                                                    "PAYMENT SUCCESS BILL FAILED", lbl_TXNID, "", "",
                                                                    0, "", "").FirstOrDefault() ?? 0; ;

                                    LogOnlineData("PAYMENT SUCCESS BILL FAILED");
                                    lblerrormsg = "PAYMENT SUCCESS BILL FAILED for Order id: " + lbl_ORDERID;
                                }

                            }
                            else
                            {
                                //payment success bill failed
                                int cnt = entities.SCOnlineInsert_Sp("UPDATE", 0, 0, "", lbl_ORDERID, "SUCCESS",
                                                                "PAYMENT SUCCESS BILL FAILED", lbl_TXNID, "", "", 0,
                                                                "", "").FirstOrDefault() ?? 0; ;

                                LogOnlineData("PAYMENT SUCCESS BILL FAILED");
                                lblerrormsg = "PAYMENT SUCCESS BILL FAILED for Order id: " + lbl_ORDERID;
                            }
                        }


                        else
                        {
                            //payment success bill failed
                            int cnt = entities.SCOnlineInsert_Sp("UPDATE", 0, 0, "", lbl_ORDERID, "SUCCESS",
                                                            "PAYMENT SUCCESS BILL FAILED", lbl_TXNID, "", "", 0, "", "").FirstOrDefault() ?? 0;

                            LogOnlineData("PAYMENT SUCCESS BILL FAILED Checksum Mismatch");
                            lblerrormsg = "PAYMENT SUCCESS BILL FAILED Checksum Mismatch for Order id: " +
                                               lbl_ORDERID;
                        }

                    }
                    else if (lbl_STATUS == "PENDING") //response pending with the gateway
                    {
                        //var objmem = new MemberServiceClient();

                        //int cnt = objmem.SCOnlineInsert("UPDATEPGPENDING", 0, "0", "", lbl_ORDERID, "PGPENDING",
                        //                                "PGPENDING", lbl_TXNID, "", "", "0", "");

                        LogOnlineData("PGPENDING-pending with gateway");
                        lblerrormsg =
                            "Transaction is Pending with the Gateway. Please check with the Admin for Order id: " +
                            lbl_ORDERID;
                    }
                    else
                    {
                        //Response.Redirect("OnlineError.aspx?errmsg=Transaction Failed.");
                        lblerrormsg = lbl_RESPMSG + "Transaction Failed for Order id: " + lbl_ORDERID;
                    }
                }
            }
            catch (Exception ex)
            {
                LogResponse(!string.IsNullOrEmpty(resmerchantrefno) ? resmerchantrefno : "Order ID getting empty",
                            ex.Message);
            }


        }

        public string ConvertedDate(string Date)
        {
            var SDate = Date.Split('/');
            return SDate[0] + "/" + SDate[1] + "/" + SDate[2];
            // return Date;
        }


        public bool IsValidChecksum()
        {
            bool isvalid = false;
            string MerchantKey = ConfigurationManager.AppSettings["MerchantKey"];

            Dictionary<string, string> parameters = new Dictionary<string, string>();
            string paytmChecksum = "";
            foreach (string key in Request.Form.Keys)
            {
                parameters.Add(key.Trim(), Request.Form[key].Trim());
            }

            if (parameters.ContainsKey("CHECKSUMHASH"))
            {
                paytmChecksum = parameters["CHECKSUMHASH"];
                parameters.Remove("CHECKSUMHASH");
            }

            if (CheckSum.verifyCheckSum(MerchantKey, parameters, paytmChecksum))
            {
                isvalid = true;
            }
            return isvalid;
        }

        public void LogOnlineData(string remarks)
        {
            var objmem = new sarsobizEntities();
            int cnt = objmem.LogOnlineDataNew_Sp(Request.Form["SUBS_ID"] == null ? "" : Request.Form["SUBS_ID"],
                lbl_MID,
                lbl_TXNID,
                lbl_ORDERID,
                lbl_BANKTXNID,
                lbl_TXNAMOUNT,
                lbl_CURRENCY,
                lbl_STATUS,
                lbl_RESPCODE,
                lbl_RESPMSG,
                Convert.ToDateTime(lbl_TXNDATE),
                lbl_GATEWAYNAME,
                lbl_BANKNAME,
                lbl_PAYMENTMODE,
                Request.Form["PROMO_CAMP_ID"] == null ? "" : Request.Form["PROMO_CAMP_ID"],
                Request.Form["PROMO_STATUS"] == null ? "" : Request.Form["PROMO_STATUS"],
                Request.Form["PROMO_RESPCODE"] == null ? "" : Request.Form["PROMO_RESPCODE"],
                lbl_CHECKSUMHASH,
                remarks).FirstOrDefault() ?? 0;
        }

        public void LogResponse(string merrefno, string responsevalues)
        {
            var objmem = new sarsobizEntities();
            var cnt = objmem.LogResponse_Sp(merrefno, responsevalues);
        }
    }
}