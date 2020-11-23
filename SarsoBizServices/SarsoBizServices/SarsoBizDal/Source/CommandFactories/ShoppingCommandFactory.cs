using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace SarsoBizDal
{
    internal partial class CommandFactory
    {
        internal static SqlCommand GetItemCodesFromAttributes(string pcode, string fields)
        {
            var parameters = new[]
               {                                                           
                   CreateParameter("@PCode", SqlDbType.VarChar, pcode),                   
                   CreateParameter("@fields", SqlDbType.VarChar, fields)
                };
            return CreateCommand("GetItemCodesFromAttributes_Sp", parameters);
        }
        internal static SqlCommand TempCart(string action, string UNQId, string pcode, string ItemCode, string Attribute,string Qty)
        {
            var parameters = new[]
               {                                                           
                   CreateParameter("@action", SqlDbType.VarChar, action), 
                   CreateParameter("@UNQId", SqlDbType.VarChar, UNQId), 
                   CreateParameter("@PCode", SqlDbType.VarChar, pcode),                   
                   CreateParameter("@ItemCode", SqlDbType.VarChar, ItemCode),
                   CreateParameter("@Attribute", SqlDbType.VarChar, Attribute),
                   CreateParameter("@Qty", SqlDbType.Int, Convert.ToInt32(Qty))
                };
            return CreateCommand("TempCart_SP", parameters);
        }
        internal static SqlCommand TempOrder(string UNQId, Int32 regid, Int32 downlineid, string mop, string mopamt, string Fname, string LName, string Mobile, string Address, string City, string District, string state, string PiCode)
        {
            var parameters = new[]
                {
                    CreateParameter("@UNQId", SqlDbType.VarChar, UNQId),
                    CreateParameter("@regid", SqlDbType.Int, regid),
                    CreateParameter("@downlineid", SqlDbType.Int, downlineid),
                    CreateParameter("@mop", SqlDbType.VarChar, mop),
                    CreateParameter("@mopamt", SqlDbType.VarChar, mopamt),
                    CreateParameter("@Fname", SqlDbType.VarChar, Fname),
                    CreateParameter("@LName", SqlDbType.VarChar, LName),
                    CreateParameter("@Mobile", SqlDbType.VarChar, Mobile),
                    CreateParameter("@Address", SqlDbType.VarChar, Address),
                    CreateParameter("@City", SqlDbType.VarChar, City),
                    CreateParameter("@District", SqlDbType.VarChar, District),
                    CreateParameter("@state", SqlDbType.VarChar, state),
                    CreateParameter("@PiCode", SqlDbType.VarChar, PiCode) 
                };
            return CreateCommand("TempOrder_SP", parameters);
        }        
        internal static SqlCommand ScOrder(string UNQId, Int32 regid, Int32 downlineid,string mop,string mopamt,string Fname,string LName, string Mobile, string Address, string City, string District, string state, string PiCode, string ordertype, string shpchrg, string scmemtype, string sesid, string ipadd,string coupon)
        {
            var parameters = new[]
                {
                    CreateParameter("@UNQId", SqlDbType.VarChar, UNQId),
                    CreateParameter("@regid", SqlDbType.Int, regid),
                    CreateParameter("@downlineid", SqlDbType.Int, downlineid), 
                    CreateParameter("@mop", SqlDbType.VarChar, mop),
                    CreateParameter("@mopamt", SqlDbType.VarChar, mopamt),
                    CreateParameter("@Fname", SqlDbType.VarChar, Fname),
                    CreateParameter("@LName", SqlDbType.VarChar, LName),
                    CreateParameter("@Mobile", SqlDbType.VarChar, Mobile),
                    CreateParameter("@Address", SqlDbType.VarChar, Address),
                    CreateParameter("@City", SqlDbType.VarChar, City),
                    CreateParameter("@District", SqlDbType.VarChar, District),
                    CreateParameter("@state", SqlDbType.VarChar, state),
                    CreateParameter("@PiCode", SqlDbType.VarChar, PiCode),                                        
                    CreateParameter("@ordertype", SqlDbType.VarChar, ordertype),
                    CreateParameter("@shpchrg", SqlDbType.VarChar, shpchrg),
                    CreateParameter("@scmemtype", SqlDbType.VarChar, scmemtype),
                    CreateParameter("@sesid", SqlDbType.VarChar, sesid),
                    CreateParameter("@ipadd", SqlDbType.VarChar, ipadd),
                    CreateParameter("@coupon", SqlDbType.VarChar, coupon ?? ""),
                };
            return CreateCommand("SCOrder_SP", parameters);
        }
        internal static SqlCommand SCOrderInvoice(string refno, string billno)
        {
            var parameters = new[]
               {                                                           
                   CreateParameter("@reqno", SqlDbType.VarChar, refno),                   
                   CreateParameter("@billno", SqlDbType.VarChar, billno)
                };
            return CreateCommand("SCOrderInvoice_SP", parameters);
        }
        internal static SqlCommand CheckSponsor(string idno)
        {
            var parameters = new[]
               {                                                           
                   CreateParameter("@idno", SqlDbType.VarChar, idno) 
                };
            return CreateCommand("CheckSponsor_SP", parameters);
        }
        internal static SqlCommand ScOrderPG(string orderid, Int32 regid, string ordertype, string shpchrg, string sesid, string ipadd, string scmemtype)
        {
            var parameters = new[]
                {
                    CreateParameter("@UniqID", SqlDbType.VarChar, orderid),
                    CreateParameter("@regid", SqlDbType.Int, regid),                    
                    CreateParameter("@ordertype", SqlDbType.VarChar, ordertype),
                    CreateParameter("@shpchrg", SqlDbType.VarChar, shpchrg),
                    CreateParameter("@sesid", SqlDbType.VarChar, sesid),
                    CreateParameter("@ipadd", SqlDbType.VarChar, ipadd),
                    CreateParameter("@scmemtype", SqlDbType.VarChar, scmemtype)
                    
                };
            return CreateCommand("SCOrderPG_SP", parameters);
        }
        internal static SqlCommand GVDPurchase(Int32 regid, string ddrefno, DateTime Refdddate, string refddbank, string ddrefbranch,
                                                string reftype, Int32 Pid, Int32 BV, string fullitemcode, string sesid, string fname, string lname, string address,
                                                string mobile, string city, string district, string state, Int32 pin)
        {
            var parameters = new[]
            {
              
                CreateParameter("@regid", SqlDbType.Int, regid),
                CreateParameter("@ddrefno", SqlDbType.VarChar, ddrefno),
                CreateParameter("@Refdddate", SqlDbType.DateTime, Refdddate),
                CreateParameter("@refddbank", SqlDbType.VarChar, refddbank),
                CreateParameter("@ddrefbranch", SqlDbType.VarChar, ddrefbranch),
                CreateParameter("@reftype", SqlDbType.VarChar, reftype),
                CreateParameter("@Pid", SqlDbType.Int, Pid),
                CreateParameter("@BV", SqlDbType.Int, BV),
                CreateParameter("@fullitemcode", SqlDbType.VarChar, fullitemcode),
                CreateParameter("@sesid", SqlDbType.VarChar, sesid),
                CreateParameter("@fname", SqlDbType.VarChar, fname),
                CreateParameter("@lname", SqlDbType.VarChar, lname),
                CreateParameter("@address", SqlDbType.VarChar, address),
                CreateParameter("@mobile", SqlDbType.VarChar, mobile),
                CreateParameter("@city", SqlDbType.VarChar, city),
                CreateParameter("@district", SqlDbType.VarChar, district),
                CreateParameter("@states", SqlDbType.VarChar, state),
                CreateParameter("@pin", SqlDbType.Int, pin)
            };
            return CreateCommand("GVDPurchase_Sp", parameters);
        }
        internal static SqlCommand GetAvailableQty(string Action, string pcode, string itemcode, Int32 AvailQty, Int32 OrdQty, Int32 regid)
        {
            var parameters = new[]
               {          
                   CreateParameter("@Action", SqlDbType.VarChar, Action),                                
                   CreateParameter("@PCode", SqlDbType.VarChar, pcode),                   
                   CreateParameter("@itemcode", SqlDbType.VarChar, itemcode),
                   CreateParameter("@AvailQty", SqlDbType.Int, AvailQty),
                   CreateParameter("@OrdQty", SqlDbType.Int, OrdQty),
                   CreateParameter("@regid", SqlDbType.Int, regid)
                };
            return CreateCommand("GetAvailableQty_Sp", parameters);
        }

        internal static SqlCommand InsertPaymentGateWayLog(string UID, string sessid, string ReqUrl, string parms, string ReturnUrl,string payment, string RegID, string downto)
        {
            var parameters = new[]
               {          
                   CreateParameter("@UID", SqlDbType.VarChar, UID),                                
                   CreateParameter("@sessid", SqlDbType.VarChar, sessid),                   
                   CreateParameter("@ReqUrl", SqlDbType.VarChar, ReqUrl),
                   CreateParameter("@parms", SqlDbType.VarChar, parms),
                   CreateParameter("@ReturnUrl", SqlDbType.VarChar, ReturnUrl),
                   CreateParameter("@payment", SqlDbType.VarChar, payment),
                   CreateParameter("@RegID", SqlDbType.VarChar, RegID),
                   CreateParameter("@downto", SqlDbType.VarChar, downto)
                };
            return CreateCommand("InsertPaymentGateWayLog_SP", parameters);
        }

        internal static SqlCommand UpdatePaymentGatewayLog(string action, string UID, string returnparams, string reqsts, string message, string IsFlagged, string PaymentID, string TransactionID, string PaymentMethod, string RequestID)
        {
            var parameters = new[]
            {                                        
                CreateParameter("@action", SqlDbType.VarChar, action),                
                CreateParameter("@UID", SqlDbType.VarChar, UID),
                CreateParameter("@returnparams", SqlDbType.VarChar, returnparams) ,
                CreateParameter("@reqsts", SqlDbType.VarChar, reqsts) ,
                CreateParameter("@message", SqlDbType.VarChar, message),
                CreateParameter("@IsFlagged", SqlDbType.VarChar, IsFlagged),
                CreateParameter("@PaymentID", SqlDbType.VarChar, PaymentID),
                CreateParameter("@TransactionID", SqlDbType.VarChar, TransactionID),
                CreateParameter("@PaymentMethod", SqlDbType.VarChar, PaymentMethod),
                CreateParameter("@RequestID", SqlDbType.VarChar, RequestID)
            };
            return CreateCommand("UpdatePaymentGatewayLog_Sp", parameters);
        }
        //rk
        internal static SqlCommand GetCouponamt(string Action, string regid, string coupon, string invamt)
        {
            var parameters = new[]
            {                                        
                CreateParameter("@action", SqlDbType.VarChar, Action),                
                CreateParameter("@regid", SqlDbType.Int,Convert.ToInt32(regid)),
                CreateParameter("@coupon", SqlDbType.VarChar, coupon),
                CreateParameter("@invamt", SqlDbType.Money,Convert.ToDecimal(invamt))
            };
            return CreateCommand("GetCouponAmount_sp", parameters);
        }
        internal static SqlCommand CreditPosting(string action, string regid, Double Amount, string billno, string UNQId)
        {
            var parameters = new[]
            {                                        
                CreateParameter("@action", SqlDbType.VarChar, action),                
                CreateParameter("@regid", SqlDbType.VarChar,regid),
                CreateParameter("@Amount", SqlDbType.Money, Amount),
                CreateParameter("@billno", SqlDbType.VarChar, billno),
                CreateParameter("@UNQId", SqlDbType.VarChar, UNQId)
            };
            return CreateCommand("CreditPosting_sp", parameters);
        }
        internal static SqlCommand InsertCourier(string action, string regid, string Courier, string billno,string type, string UNQId)
        {
            var parameters = new[]
            {                                        
                CreateParameter("@action", SqlDbType.VarChar, action),                
                CreateParameter("@regid", SqlDbType.VarChar,regid),
                CreateParameter("@Courier", SqlDbType.VarChar, Courier),
                CreateParameter("@billno", SqlDbType.VarChar, billno),
                CreateParameter("@type", SqlDbType.VarChar, type),
                CreateParameter("@UNQId", SqlDbType.VarChar, UNQId)
            };
            return CreateCommand("InsertCourier_sp", parameters);
        }
        internal static SqlCommand InsertInvProducts(string action, string UNQId, Int32 regid,DataTable dt)
        {
            var parameters = new[]
            {                                        
                CreateParameter("@action", SqlDbType.VarChar, action), 
                CreateParameter("@UNQId", SqlDbType.VarChar, UNQId),
                CreateParameter("@regid", SqlDbType.Int,regid),
                CreateParameter("@TmpInvProducts", SqlDbType.Structured, dt,"dbo.TmpInvProducts")
                
            };
            return CreateCommand("InsertInvProducts_sp", parameters);
        }
        internal static SqlCommand InsertOffProducts(string action, string UNQId, Int32 regid, DataTable dt)
        {
            var parameters = new[]
            {                                        
                CreateParameter("@action", SqlDbType.VarChar, action), 
                CreateParameter("@UNQId", SqlDbType.VarChar, UNQId),
                CreateParameter("@regid", SqlDbType.Int,regid),
                CreateParameter("@TmpoffProducts", SqlDbType.Structured, dt,"dbo.TmpOffProducts")
                
            };
            return CreateCommand("InsertOffProducts_sp", parameters);
        }

    }
}
