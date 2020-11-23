
using System;
using System.Data;
using System.Data.SqlClient;

// ReSharper disable CheckNamespace
namespace SarsoBizDal
// ReSharper restore CheckNamespace
{
    internal partial class CommandFactory
    {
        internal static SqlCommand AdminLogin(string username, string password)
        {
            var parameters = new[]
            {
                CreateParameter("@username", SqlDbType.VarChar, username),
                CreateParameter("@password", SqlDbType.VarChar, password)
            };
            return CreateCommand("AdminLogin_Sp", parameters);
        }
        internal static SqlCommand CodeErrors(string userid, string pageurl, string errorMsg, string sesid)
        {
            var parameters = new[]
                {                       
                    CreateParameter("@userid", SqlDbType.VarChar, userid) ,
                    CreateParameter("@pageurl", SqlDbType.VarChar, pageurl) ,
                    CreateParameter("@errorMsg", SqlDbType.VarChar, errorMsg) ,
                    CreateParameter("@sesid", SqlDbType.VarChar, sesid) 
                };
            return CreateCommand("CodeErrors_SP", parameters);
        }
        internal static SqlCommand SessionsInOut(string action, Int32 uid, string sesid, string ipaddress, string systemname, string usertype)
        {
            var parameters = new[]
            {
                CreateParameter("@action", SqlDbType.VarChar, action),
                CreateParameter("@uid", SqlDbType.Int, uid),
                CreateParameter("@sesid", SqlDbType.VarChar, sesid),
                CreateParameter("@ipaddress", SqlDbType.VarChar, ipaddress),
                CreateParameter("@systemname", SqlDbType.VarChar, systemname),
                CreateParameter("@usertype", SqlDbType.VarChar, usertype)
            };
            return CreateCommand("SessionsInOut_SP", parameters);
        }
        internal static SqlCommand CurrlastloginTime(Int32 loginid, string sesid, string usertype)
        {
            var parameters = new[]
            {
                CreateParameter("@loginid", SqlDbType.BigInt, loginid),
                CreateParameter("@sesid", SqlDbType.VarChar, sesid),
                CreateParameter("@usertype", SqlDbType.VarChar, usertype)
            };
            return CreateCommand("CurrlastloginTime_Sp", parameters);
        }
        internal static SqlCommand MainLinks(int uid, string usertype)
        {
            var parameters = new[]
            {
                CreateParameter("@uid", SqlDbType.Int, uid),
                CreateParameter("@usertype", SqlDbType.VarChar, usertype)
            };
            return CreateCommand("MainLinks_Sp", parameters);
        }
        internal static SqlCommand Sublinks(int lid, int uid, string usertype)
        {
            var parameters = new[]
            {
                CreateParameter("@lid", SqlDbType.Int, lid),
                CreateParameter("@uid", SqlDbType.Int, uid),
                CreateParameter("@usertype", SqlDbType.VarChar, usertype)
            };
            return CreateCommand("sublinks_Sp", parameters);
        }
        internal static SqlCommand LinksPremission(int lid, int uid, string usertype)
        {
            var parameters = new[]
            {
                CreateParameter("@lid", SqlDbType.Int, lid),
                CreateParameter("@uid", SqlDbType.Int, uid),
                CreateParameter("@usertype", SqlDbType.VarChar, usertype)
            };
            return CreateCommand("LinksPremission_Sp", parameters);
        }
        internal static SqlCommand SublinksPermissions(string lids, Int32 itemid, Int32 uid, string sesid, string usertype)
        {
            var parameters = new[]
            {
                CreateParameter("@lids", SqlDbType.VarChar, lids),
                CreateParameter("@itemid", SqlDbType.Int, itemid),
                CreateParameter("@uid", SqlDbType.Int, uid),
                CreateParameter("@sesid", SqlDbType.VarChar, sesid),                
                CreateParameter("@usertype", SqlDbType.VarChar, usertype)
            };
            return CreateCommand("SublinksPermissions_Sp", parameters);
        }
        internal static SqlCommand Users(string action, int itemid)
        {
            var parameters = new[]
            {
                CreateParameter("@action", SqlDbType.VarChar, action), 
                CreateParameter("@itemid", SqlDbType.Int, itemid)
            };
            return CreateCommand("Users_Sp", parameters);
        }
        internal static SqlCommand InupUsers(string action, int itemId, string userName, string passWord, string name,
                                             string doorno, string lane, string streat, string city, string state,
                                             string contactName, string contactPhone, string email, int uid,
                                             string sesid, string ipaddress, int flag)
        {
            var parameters = new[]
            {
                CreateParameter("@action", SqlDbType.VarChar, action),  
                CreateParameter("@itemId", SqlDbType.Int, itemId),  
                CreateParameter("@userName", SqlDbType.VarChar, userName),  
                CreateParameter("@passWord", SqlDbType.VarChar, passWord),  
                CreateParameter("@name", SqlDbType.VarChar, name),  
                CreateParameter("@doorno", SqlDbType.VarChar, doorno),  
                CreateParameter("@lane", SqlDbType.VarChar, lane),  
                CreateParameter("@streat", SqlDbType.VarChar, streat),  
                CreateParameter("@city", SqlDbType.VarChar, city),  
                CreateParameter("@state", SqlDbType.VarChar, state),  
                CreateParameter("@Contact_Name", SqlDbType.VarChar, contactName),  
                CreateParameter("@Contact_Phone", SqlDbType.VarChar, contactPhone),  
                CreateParameter("@email", SqlDbType.VarChar, email),  
                CreateParameter("@uid", SqlDbType.Int, uid),  
                CreateParameter("@sesid", SqlDbType.VarChar, sesid), 
                CreateParameter("@ipaddress", SqlDbType.VarChar, ipaddress), 
                CreateParameter("@flag", SqlDbType.Int, flag)
            };
            return CreateCommand("INUPUsers_SP", parameters);
        }
        internal static SqlCommand DelUsers(int itemid, int uid)
        {
            var parameters = new[]
            {
                CreateParameter("@itemid", SqlDbType.Int, itemid),                
                CreateParameter("@uid", SqlDbType.Int, uid)
            };
            return CreateCommand("DelUsers_Sp", parameters);
        }
        internal static SqlCommand ChangePassword(string action, int itemid, string pwd, int uid)
        {
            var parameters = new[]
            {
                CreateParameter("@action", SqlDbType.VarChar, action),
                CreateParameter("@itemid", SqlDbType.Int, itemid),    
                CreateParameter("@pwd", SqlDbType.VarChar, pwd),
                CreateParameter("@uid", SqlDbType.Int, uid)
            };
            return CreateCommand("ChangePassword_Sp", parameters);
        }
        internal static SqlCommand GetValue(string tblname, string getcolum, string columnItem, string itemId)
        {
            var parameters = new[]
            {
                CreateParameter("@tblname", SqlDbType.VarChar,tblname),                 
                CreateParameter("@getcolum", SqlDbType.VarChar,getcolum),                 
                CreateParameter("@columnItem", SqlDbType.VarChar,columnItem),                 
                CreateParameter("@itemId", SqlDbType.VarChar,itemId)
            };
            return CreateCommand("GetValue_Sp", parameters);
        }
        internal static SqlCommand GetData(string tblname, string columnItem, string itemId)
        {
            var parameters = new[]
            {
                CreateParameter("@tblname", SqlDbType.VarChar,tblname),                                                  
                CreateParameter("@columnItem", SqlDbType.VarChar,columnItem),                 
                CreateParameter("@itemId", SqlDbType.VarChar,itemId)
            };
            return CreateCommand("GetData_Sp", parameters);
        }
        internal static SqlCommand UsersLogRpt(DateTime frmdate, DateTime todate, Int32 user, Int32 pageIndex, Int32 pageSize, string usertype)
        {
            var parameters = new[]  
            {
                CreateParameter("@frmdate", SqlDbType.DateTime,frmdate),                 
                CreateParameter("@todate", SqlDbType.DateTime,todate),                 
                CreateParameter("@user", SqlDbType.Int,user) ,
                CreateParameter("@pageIndex", SqlDbType.Int,pageIndex) ,
                CreateParameter("@pageSize", SqlDbType.Int,pageSize) ,
                CreateParameter("@usertype", SqlDbType.VarChar,usertype)                
            };
            return CreateCommand("UsersLogRpt_Sp", parameters);
        }
        internal static SqlCommand AddCompanyBanks(string action, int cbId, string bank, string branch, string accno, string ifsc, string city, string state,
                                                   int cbStatus, string createdBy, string sesid)
        {
            var parameters = new[]
                {
                    CreateParameter("@action", SqlDbType.VarChar, action),
                    CreateParameter("@cbId", SqlDbType.Int, cbId),
                    CreateParameter("@Bank", SqlDbType.VarChar, bank),
                    CreateParameter("@branch", SqlDbType.VarChar, branch),
                    CreateParameter("@accno", SqlDbType.VarChar, accno),
                    CreateParameter("@ifsc", SqlDbType.VarChar, ifsc),
                    CreateParameter("@city", SqlDbType.VarChar, city),
                    CreateParameter("@state", SqlDbType.VarChar, state),
                    CreateParameter("@cbStatus", SqlDbType.Int, cbStatus),
                    CreateParameter("@createdBy", SqlDbType.Int, createdBy),
                    CreateParameter("@sesid", SqlDbType.VarChar, sesid)
                };
            return CreateCommand("AddCompanyBanks_Sp", parameters);
        }
        internal static SqlCommand GetCompanyBanks(int cbId)
        {
            var parameters = new[]
               {                    
                    CreateParameter("@cbId", SqlDbType.Int, cbId)                 
                };
            return CreateCommand("GetCompanyBanks_Sp", parameters);
        }
        internal static SqlCommand MemberSearch(string key, string style, string keyWords,
                                            string sortby, int pageIndex, int pageSize)
        {
            var parameters = new[]
               {                    
                    CreateParameter("@key", SqlDbType.VarChar, key),                 
                    CreateParameter("@style", SqlDbType.VarChar, style),                    
                    CreateParameter("@keyWords", SqlDbType.VarChar, keyWords),
                    CreateParameter("@sortby", SqlDbType.VarChar, sortby),                                       
                    CreateParameter("@pageIndex", SqlDbType.Int, pageIndex),
                    CreateParameter("@pageSize", SqlDbType.Int, pageSize)
                };
            return CreateCommand("MemberSearch_Sp", parameters);
        }

        internal static SqlCommand RegistrationReport(string action, string plantype, DateTime frmdate,
                                             DateTime todate, Int64 regid, Int32 pageIndex, Int32 pageSize)
        {
            var parameters = new[]
               {                    
                    CreateParameter("@action", SqlDbType.VarChar, action),                 
                    CreateParameter("@plantype", SqlDbType.VarChar, plantype),                    
                    CreateParameter("@frmdate", SqlDbType.DateTime, frmdate),
                    CreateParameter("@todate", SqlDbType.DateTime, todate),
                    CreateParameter("@regid", SqlDbType.Int, regid),                    
                    CreateParameter("@pageIndex", SqlDbType.Int, pageIndex),
                    CreateParameter("@pageSize", SqlDbType.Int, pageSize)
                };
            return CreateCommand("RegistrationReport_Sp", parameters);
        }
        internal static SqlCommand GetPackages(string action)
        {
            var parameters = new[]
               {                    
                    CreateParameter("@action", SqlDbType.VarChar, action)                 
                };
            return CreateCommand("GetPackages_Sp", parameters);
        }


        internal static SqlCommand DrcDetails()
        {
            return CreateCommand("DRCDetails_SP");
        }

        internal static SqlCommand UpDrcDetails(Int32 pid, string postEwallet, double drcAmt)
        {
            var parameters = new[]
               {                                        
                   CreateParameter("@pid", SqlDbType.Int, pid),
                   CreateParameter("@postEwallet", SqlDbType.VarChar, postEwallet),
                   CreateParameter("@drcAmt", SqlDbType.Money, drcAmt)
                };
            return CreateCommand("UpDrcDetails_SP", parameters);
        }



        internal static SqlCommand PairsReport(DateTime frmdate, DateTime todate, Int64 regid, Int32 pageIndex, Int32 pageSize)
        {
            var parameters = new[]
               {                                        
                    CreateParameter("@frmdate", SqlDbType.DateTime, frmdate),
                    CreateParameter("@todate", SqlDbType.DateTime, todate),
                    CreateParameter("@regid", SqlDbType.Int, regid),                    
                    CreateParameter("@pageIndex", SqlDbType.Int, pageIndex),
                    CreateParameter("@pageSize", SqlDbType.Int, pageSize)
                };
            return CreateCommand("PairsReport_Sp", parameters);
        }
        internal static SqlCommand BlockIdorBlockToPaidRpt(string action, DateTime frmdate, DateTime todate, Int32 pageIndex, Int32 pageSize)
        {
            var parameters = new[]
                {
                    CreateParameter("@action", SqlDbType.VarChar, action),                    
                    CreateParameter("@frmdate", SqlDbType.DateTime, frmdate),
                    CreateParameter("@todate", SqlDbType.DateTime, todate),
                    CreateParameter("@pageIndex", SqlDbType.BigInt, pageIndex),
                    CreateParameter("@pageSize", SqlDbType.BigInt, pageSize)
                };
            return CreateCommand("BlockIdorBlockToPaidRpt_Sp", parameters);
        }
        internal static SqlCommand FeedbackRpt(string action, string idno, string name, string city, string state, string email, string subject,
                                        string msg, string status, Int32 createdby, DateTime createddate, string plantype, Int32 pageIndex, Int32 pageSize)
        {
            var parameters = new[]
                {
                    CreateParameter("@Action", SqlDbType.VarChar, action),                    
                    CreateParameter("@IDno", SqlDbType.VarChar, idno),
                    CreateParameter("@Name", SqlDbType.VarChar, name),
                    CreateParameter("@City", SqlDbType.VarChar, city),
                    CreateParameter("@State", SqlDbType.VarChar, state),
                    CreateParameter("@Email", SqlDbType.VarChar, email),                    
                    CreateParameter("@Subject", SqlDbType.VarChar, subject),
                    CreateParameter("@Message", SqlDbType.VarChar, msg),
                    CreateParameter("@Status", SqlDbType.VarChar, status),
                    CreateParameter("@CreatedBy", SqlDbType.Int, createdby),
                    CreateParameter("@CreatedDate", SqlDbType.DateTime, createddate),
                    CreateParameter("@PlanTYpe", SqlDbType.VarChar, plantype),
                    CreateParameter("@pageIndex", SqlDbType.BigInt, pageIndex),
                    CreateParameter("@pageSizes", SqlDbType.BigInt, pageSize)
                };
            return CreateCommand("FeedbackRpt_Sp", parameters);
        }
        internal static SqlCommand NewsRpt(string action, string description, string status, Int32 createdby, DateTime createddate, Int32 updatedby,
                                        DateTime updateddate, string plantype, Int32 pageIndex, Int32 pageSize)
        {
            var parameters = new[]
                {
                    CreateParameter("@Action", SqlDbType.VarChar, action),                    
                    CreateParameter("@Description", SqlDbType.VarChar, description),
                    CreateParameter("@Status", SqlDbType.VarChar, status),
                    CreateParameter("@CreatedBy", SqlDbType.Int, createdby),
                    CreateParameter("@CreatedDate", SqlDbType.DateTime, createddate),
                     CreateParameter("@UpdatedBy", SqlDbType.Int, updatedby),                    
                    CreateParameter("@UpdatedDate", SqlDbType.DateTime, updateddate),
                    CreateParameter("@PlanTYpe", SqlDbType.VarChar, plantype),
                    CreateParameter("@pageIndex", SqlDbType.BigInt, pageIndex),
                    CreateParameter("@pageSizes", SqlDbType.BigInt, pageSize)
                };
            return CreateCommand("NewsRpt_Sp", parameters);
        }
        internal static SqlCommand SeminarRpt(string action, string titile, string venue, DateTime date, string time, string city, string state, string vleader,
            string phoneno, string status, DateTime createddate, int createdby, int updatedby, DateTime updateddate, string plantype, Int32 pageIndex, Int32 pageSize)
        {
            var parameters = new[]
                {
                   CreateParameter("@Action", SqlDbType.VarChar, action),                    
                   CreateParameter("@Title", SqlDbType.VarChar, titile),
                   CreateParameter("@Venue", SqlDbType.VarChar, venue),
                   CreateParameter("@Date", SqlDbType.DateTime, date),
                   CreateParameter("@Vtime", SqlDbType.VarChar, time),
                    CreateParameter("@City", SqlDbType.VarChar, city),                    
                   CreateParameter("@State", SqlDbType.VarChar, state),
                   CreateParameter("@Vleader", SqlDbType.VarChar, vleader),
                   CreateParameter("@contactno", SqlDbType.VarChar, phoneno),
                   CreateParameter("@Status", SqlDbType.VarChar, status),
                   CreateParameter("@CreationDate", SqlDbType.DateTime, createddate),                    
                   CreateParameter("@CreatedBy", SqlDbType.Int, createdby),
                   CreateParameter("@UpdatedBy", SqlDbType.Int, updatedby),
                   CreateParameter("@UpdateDate", SqlDbType.DateTime, updateddate),
                   CreateParameter("@PlanType", SqlDbType.VarChar, plantype),
                   CreateParameter("@pageIndex", SqlDbType.BigInt, pageIndex),
                   CreateParameter("@pageSize", SqlDbType.BigInt, pageSize)
                };
            return CreateCommand("SeminarRpt_Sp", parameters);
        }

        internal static SqlCommand FaqsRpt(string action, string qusetion, string answer, string catageory, string catageoryname, string user,
                            string status, string sessid, string plantype, Int32 pageIndex, Int32 pageSize)
        {
            var parameters = new[]
                {
                    CreateParameter("@Action", SqlDbType.VarChar, action),                    
                    CreateParameter("@Question", SqlDbType.VarChar, qusetion),
                    CreateParameter("@Answer", SqlDbType.VarChar, answer),
                    CreateParameter("@Category", SqlDbType.VarChar, catageory),
                    CreateParameter("@CategoryName", SqlDbType.VarChar, catageoryname),
                    CreateParameter("@user", SqlDbType.VarChar, user), 
                    CreateParameter("@Status", SqlDbType.VarChar, status),                 
                    CreateParameter("@Sessid", SqlDbType.VarChar, sessid),
                    CreateParameter("@PlanType", SqlDbType.VarChar, plantype),                    
                    CreateParameter("@pageIndex", SqlDbType.BigInt, pageIndex),
                    CreateParameter("@pageSize", SqlDbType.BigInt, pageSize)
                };
            return CreateCommand("FAQSRpt_Sp", parameters);
        }
        internal static SqlCommand FaqsCategorys(string action)
        {
            var parameters = new[]
                {
                    CreateParameter("@action", SqlDbType.VarChar, action)  
                };
            return CreateCommand("FaqsCategorys_sp", parameters);
        }
        internal static SqlCommand MemberBankSlipsRpt(int sts, Int32 pageIndex, Int32 pageSize)
        {
            var parameters = new[]
                {
                    CreateParameter("@sts", SqlDbType.Int, sts),                                                                  
                    CreateParameter("@pageIndex", SqlDbType.BigInt, pageIndex),
                    CreateParameter("@pageSize", SqlDbType.BigInt, pageSize)
                };
            return CreateCommand("MemberBankSlipsRpt_Sp", parameters);
        }
        internal static SqlCommand MemberBankSlipsforAppRej(Int32 regid, DateTime fromdate, DateTime todate, Int32 pageIndex, Int32 pageSize)
        {
            var parameters = new[]
                {
                    CreateParameter("@regid", SqlDbType.Int, regid), 
                    CreateParameter("@fromdate", SqlDbType.DateTime, fromdate),
                    CreateParameter("@todate", SqlDbType.DateTime, todate),
                    CreateParameter("@pageIndex", SqlDbType.BigInt, pageIndex),
                    CreateParameter("@pageSize", SqlDbType.BigInt, pageSize)
                };
            return CreateCommand("MemberBankSlipsforAppRej_Sp", parameters);
        }
        internal static SqlCommand AppRejBankSlips(string slnos, int sts, string sesid, string ipadd, Int32 uid)
        {
            var parameters = new[]
                {
                    CreateParameter("@slnos", SqlDbType.VarChar, slnos), 
                    CreateParameter("@sts", SqlDbType.Int, sts),
                    CreateParameter("@sesid", SqlDbType.VarChar, sesid),
                    CreateParameter("@ipadd", SqlDbType.VarChar, ipadd),
                    CreateParameter("@uid", SqlDbType.BigInt, uid)
                };
            return CreateCommand("AppRejBankSlips_Sp", parameters);
        }
        internal static SqlCommand CstCollectionRpt(string action, DateTime fromdate, DateTime todate, Int32 pageIndex, Int32 pageSize)
        {
            var parameters = new[]
                {
                    CreateParameter("@action", SqlDbType.VarChar, action),                                                                                                                    
                    CreateParameter("@fromdate", SqlDbType.DateTime, fromdate),                                                                             
                    CreateParameter("@todate", SqlDbType.DateTime,todate),                                               
                    CreateParameter("@pageIndex", SqlDbType.BigInt, pageIndex),
                    CreateParameter("@pageSize", SqlDbType.BigInt, pageSize)
                };
            return CreateCommand("CSTCollectionRpt_Sp", parameters);
        }
        internal static SqlCommand VatCollectionRpt(string action, DateTime fromdate, DateTime todate, Int32 pageIndex, Int32 pageSize)
        {
            var parameters = new[]
                {
                    CreateParameter("@action", SqlDbType.VarChar, action),                    
                    CreateParameter("@fromdate", SqlDbType.DateTime, fromdate),                                                                             
                    CreateParameter("@todate", SqlDbType.DateTime,todate),                                               
                    CreateParameter("@pageIndex", SqlDbType.BigInt, pageIndex),
                    CreateParameter("@pageSize", SqlDbType.BigInt, pageSize)
                };
            return CreateCommand("VATCollectionRpt_Sp", parameters);
        }
        internal static SqlCommand LboActivationRpt(string action, int regid, DateTime fromdate, DateTime todate, Int32 pageIndex, Int32 pageSize)
        {
            var parameters = new[]
                {
                    CreateParameter("@action", SqlDbType.VarChar, action),                                                                                                
                    CreateParameter("@regid", SqlDbType.Int,regid),
                    CreateParameter("@fromdate", SqlDbType.DateTime, fromdate),                                                                             
                    CreateParameter("@todate", SqlDbType.DateTime,todate),                                               
                    CreateParameter("@pageIndex", SqlDbType.BigInt, pageIndex),
                    CreateParameter("@pageSize", SqlDbType.BigInt, pageSize)
                };
            return CreateCommand("LBOActivationRpt_Sp", parameters);
        }
        internal static SqlCommand ProductSalesRpt(string action, int regid, DateTime fromdate, DateTime todate, Int32 pageIndex, Int32 pageSize)
        {
            var parameters = new[]
                {
                    CreateParameter("@action", SqlDbType.VarChar, action),                                                                                                
                    CreateParameter("@regid", SqlDbType.Int,regid),
                    CreateParameter("@fromdate", SqlDbType.DateTime, fromdate),                                                                             
                    CreateParameter("@todate", SqlDbType.DateTime,todate),                                               
                    CreateParameter("@pageIndex", SqlDbType.BigInt, pageIndex),
                    CreateParameter("@pageSize", SqlDbType.BigInt, pageSize)
                };
            return CreateCommand("ProductSalesRpt_Sp", parameters);
        }

        internal static SqlCommand RepurchaseSalesRpt(string action, int regid, DateTime fromdate, DateTime todate, Int32 pageIndex, Int32 pageSize)
        {
            var parameters = new[]
                {
                    CreateParameter("@action", SqlDbType.VarChar, action),                                                                                              
                    CreateParameter("@regid", SqlDbType.Int,regid),
                    CreateParameter("@fromdate", SqlDbType.DateTime, fromdate),                                                                             
                    CreateParameter("@todate", SqlDbType.DateTime,todate),                                               
                    CreateParameter("@pageIndex", SqlDbType.BigInt, pageIndex),
                    CreateParameter("@pageSize", SqlDbType.BigInt, pageSize)
                };
            return CreateCommand("RepurchaseSalesRpt_Sp", parameters);
        }
        internal static SqlCommand RepurchaseVochersRpt(string action, int regid, DateTime fromdate, DateTime todate, Int32 pageIndex, Int32 pageSize)
        {
            var parameters = new[]
                {
                    CreateParameter("@action", SqlDbType.VarChar, action),                                                                                                
                    CreateParameter("@regid", SqlDbType.Int,regid),
                    CreateParameter("@fromdate", SqlDbType.DateTime, fromdate),                                                                             
                    CreateParameter("@todate", SqlDbType.DateTime,todate),                                               
                    CreateParameter("@pageIndex", SqlDbType.BigInt, pageIndex),
                    CreateParameter("@pageSize", SqlDbType.BigInt, pageSize)
                };
            return CreateCommand("RepurchaseVochersRpt_Sp", parameters);
        }
        internal static SqlCommand MobileRechargeRpt(string action, int regid, DateTime fromdate, DateTime todate, Int32 pageIndex, Int32 pageSize)
        {
            var parameters = new[]
                {
                    CreateParameter("@action", SqlDbType.VarChar, action),                                                                                                
                    CreateParameter("@regid", SqlDbType.Int,regid),
                    CreateParameter("@fromdate", SqlDbType.DateTime, fromdate),                                                                             
                    CreateParameter("@todate", SqlDbType.DateTime,todate),                                               
                    CreateParameter("@pageIndex", SqlDbType.BigInt, pageIndex),
                    CreateParameter("@pageSize", SqlDbType.BigInt, pageSize)
                };
            return CreateCommand("MobileRechargeRpt_Sp", parameters);
        }
        internal static SqlCommand NonRpLbosRpt(string action, DateTime fromdate, DateTime todate, Int32 pageIndex, Int32 pageSize)
        {
            var parameters = new[]
                {
                    CreateParameter("@action", SqlDbType.VarChar, action),                                                                                                                    
                    CreateParameter("@fromdate", SqlDbType.DateTime, fromdate),                                                                             
                    CreateParameter("@todate", SqlDbType.DateTime,todate),                                               
                    CreateParameter("@pageIndex", SqlDbType.BigInt, pageIndex),
                    CreateParameter("@pageSize", SqlDbType.BigInt, pageSize)
                };
            return CreateCommand("NonRPLbosRpt_Sp", parameters);
        }
        internal static SqlCommand TopMembersRpt(string action, int stateid, Int32 pageIndex, Int32 pageSize)
        {
            var parameters = new[]
                {
                    CreateParameter("@action", SqlDbType.VarChar, action),                                                                                                                                        
                    CreateParameter("@stateid", SqlDbType.Int,stateid),                                               
                    CreateParameter("@pageIndex", SqlDbType.BigInt, pageIndex),
                    CreateParameter("@pageSize", SqlDbType.BigInt, pageSize)
                };
            return CreateCommand("TopMembersRpt_Sp", parameters);
        }
        internal static SqlCommand CityWiseRpt(string action, string city, Int32 pageIndex, Int32 pageSize)
        {
            var parameters = new[]
                {
                    CreateParameter("@action", SqlDbType.VarChar, action),                                                                                                 
                    CreateParameter("@city", SqlDbType.VarChar,city),                                               
                    CreateParameter("@pageIndex", SqlDbType.BigInt, pageIndex),
                    CreateParameter("@pageSize", SqlDbType.BigInt, pageSize)
                };
            return CreateCommand("CityWiseRpt_Sp", parameters);
        }
        internal static SqlCommand RepurVocherValidityExtenRpt(string action, int regid, DateTime fromdate, DateTime todate, Int32 pageIndex, Int32 pageSize)
        {
            var parameters = new[]
            {
                    CreateParameter("@action", SqlDbType.VarChar, action),
                    CreateParameter("@regid", SqlDbType.Int,regid),  
                    CreateParameter("@fromdate", SqlDbType.DateTime, fromdate),
                    CreateParameter("@todate", SqlDbType.DateTime,todate),                                            
                    CreateParameter("@pageIndex", SqlDbType.BigInt, pageIndex),
                    CreateParameter("@pageSize", SqlDbType.BigInt, pageSize)
            };
            return CreateCommand("RepurVocherValidityExtenRpt_Sp", parameters);
        }

        internal static SqlCommand PackageWiseRpt(string action, string month, Int32 pageIndex, Int32 pageSize)
        {
            var parameters = new[]
            {
                    CreateParameter("@action", SqlDbType.VarChar, action),  
                    CreateParameter("@month", SqlDbType.VarChar, month),                                     
                    CreateParameter("@pageIndex", SqlDbType.BigInt, pageIndex),
                    CreateParameter("@pageSize", SqlDbType.BigInt, pageSize)
            };
            return CreateCommand("PackageWiseRpt_Sp", parameters);
        }
        internal static SqlCommand SmsLogRpt(string action, DateTime fromdate, DateTime todate, Int32 pageIndex, Int32 pageSize)
        {
            var parameters = new[]
            {
                    CreateParameter("@action", SqlDbType.VarChar, action), 
                    CreateParameter("@fromdate", SqlDbType.DateTime, fromdate),     
                    CreateParameter("@todate", SqlDbType.DateTime, todate),                 
                    CreateParameter("@pageIndex", SqlDbType.BigInt, pageIndex),
                    CreateParameter("@pageSize", SqlDbType.BigInt, pageSize)
            };
            return CreateCommand("SmsLogRpt_Sp", parameters);
        }
        internal static SqlCommand PayoutSmsRpt(string action, Int32 pageIndex, Int32 pageSize)
        {
            var parameters = new[]
            {
                    CreateParameter("@action", SqlDbType.VarChar, action),                                             
                    CreateParameter("@pageIndex", SqlDbType.BigInt, pageIndex),
                    CreateParameter("@pageSize", SqlDbType.BigInt, pageSize)
            };
            return CreateCommand("PayoutSmsRpt_Sp", parameters);
        }

        internal static SqlCommand ShoppingReqRpt(string action, DateTime fromdate, DateTime todate, Int32 pageIndex, Int32 pageSize)
        {
            var parameters = new[]
            {
                    CreateParameter("@action", SqlDbType.VarChar, action),     
                    CreateParameter("@fromdate", SqlDbType.DateTime,fromdate),     
                    CreateParameter("@todate", SqlDbType.DateTime, todate),                         
                    CreateParameter("@pageIndex", SqlDbType.BigInt, pageIndex),
                    CreateParameter("@pageSize", SqlDbType.BigInt, pageSize)
            };
            return CreateCommand("ShoppingReqRpt_Sp", parameters);
        }

        internal static SqlCommand CreditReqRpt(string action, Int32 pageIndex, Int32 pageSize)
        {
            var parameters = new[]
            {
                    CreateParameter("@action", SqlDbType.VarChar, action),                                                  
                    CreateParameter("@pageIndex", SqlDbType.BigInt, pageIndex),
                    CreateParameter("@pageSize", SqlDbType.BigInt, pageSize)
            };
            return CreateCommand("CreditReqRpt_Sp", parameters);
        }
        internal static SqlCommand CreditSummaryRpt(string action, string fcode, Int32 pageIndex, Int32 pageSize)
        {
            var parameters = new[]
            {
                    CreateParameter("@action", SqlDbType.VarChar, action), 
                    CreateParameter("@fcode", SqlDbType.VarChar,fcode),                              
                    CreateParameter("@pageIndex", SqlDbType.BigInt, pageIndex),
                    CreateParameter("@pageSize", SqlDbType.BigInt, pageSize)
            };
            return CreateCommand("CreditSummaryRpt_Sp", parameters);
        }
        internal static SqlCommand StockReturnsRpt(string action, Int32 pageIndex, Int32 pageSize)
        {
            var parameters = new[]
            {
                    CreateParameter("@action", SqlDbType.VarChar, action),                                                  
                    CreateParameter("@pageIndex", SqlDbType.BigInt, pageIndex),
                    CreateParameter("@pageSize", SqlDbType.BigInt, pageSize)
            };
            return CreateCommand("StockReturnsRpt_Sp", parameters);
        }
        internal static SqlCommand FranchiseBalancesRpt(string action, Int32 pageIndex, Int32 pageSize)
        {
            var parameters = new[]
            {
                    CreateParameter("@action", SqlDbType.VarChar, action),                                                  
                    CreateParameter("@pageIndex", SqlDbType.BigInt, pageIndex),
                    CreateParameter("@pageSize", SqlDbType.BigInt, pageSize)
            };
            return CreateCommand("FranchiseBalancesRpt_Sp", parameters);
        }
        internal static SqlCommand FranchiseCommissionRpt(string action, string fcode, Int32 pageIndex, Int32 pageSize)
        {
            var parameters = new[]
            {
                    CreateParameter("@action", SqlDbType.VarChar, action),                                                  
                    CreateParameter("@fcode", SqlDbType.VarChar, fcode),                                                  
                    CreateParameter("@pageIndex", SqlDbType.BigInt, pageIndex),
                    CreateParameter("@pageSize", SqlDbType.BigInt, pageSize)
            };
            return CreateCommand("FranchiseCommissionRpt_Sp", parameters);
        }
        internal static SqlCommand FranchiseSalesCommRpt(string action, string commtype, DateTime fromdate, DateTime todate,
           string fcode, Int32 pageIndex, Int32 pageSize)
        {
            var parameters = new[]
            {
                    CreateParameter("@action", SqlDbType.VarChar, action),
                    CreateParameter("@commtype", SqlDbType.VarChar, commtype),
                    CreateParameter("@fromdate", SqlDbType.DateTime, fromdate),
                    CreateParameter("@todate", SqlDbType.DateTime, todate),                              
                    CreateParameter("@fcode", SqlDbType.VarChar, fcode),                                                  
                    CreateParameter("@pageIndex", SqlDbType.BigInt, pageIndex),
                    CreateParameter("@pageSize", SqlDbType.BigInt, pageSize)
            };
            return CreateCommand("FranchiseSalesCommRpt_Sp", parameters);
        }
        internal static SqlCommand LifeisClubMemRpt(string action, string membership, DateTime fromdate, DateTime todate,
            int regid, Int32 pageIndex, Int32 pageSize)
        {
            var parameters = new[]
            {
                    CreateParameter("@action", SqlDbType.VarChar, action),
                    CreateParameter("@membership", SqlDbType.VarChar,membership ),
                    CreateParameter("@fromdate", SqlDbType.DateTime, fromdate),
                    CreateParameter("@todate", SqlDbType.DateTime, todate),                              
                    CreateParameter("@regid", SqlDbType.Int, regid),                                                  
                    CreateParameter("@pageIndex", SqlDbType.BigInt, pageIndex),
                    CreateParameter("@pageSize", SqlDbType.BigInt, pageSize)
            };
            return CreateCommand("LifeisClubMemRpt_Sp", parameters);
        }
        internal static SqlCommand LifeisClubAchieversRpt(string action, string membership, DateTime fromdate, DateTime todate,
            int regid, Int32 pageIndex, Int32 pageSize)
        {
            var parameters = new[]
            {
                    CreateParameter("@action", SqlDbType.VarChar, action),
                    CreateParameter("@membership", SqlDbType.VarChar,membership ),
                    CreateParameter("@fromdate", SqlDbType.DateTime, fromdate),
                    CreateParameter("@todate", SqlDbType.DateTime, todate),                              
                    CreateParameter("@regid", SqlDbType.Int, regid),                                                  
                    CreateParameter("@pageIndex", SqlDbType.BigInt, pageIndex),
                    CreateParameter("@pageSize", SqlDbType.BigInt, pageSize)
            };
            return CreateCommand("LifeisClubAchieversRpt_Sp", parameters);
        }
        internal static SqlCommand LeadershipIncentivesRpt(string action, int payoutno, int regid, Int32 pageIndex, Int32 pageSize)
        {
            var parameters = new[]
            {
                    CreateParameter("@action", SqlDbType.VarChar, action),
                    CreateParameter("@payoutno", SqlDbType.Int, payoutno),                              
                    CreateParameter("@regid", SqlDbType.Int, regid),                                                  
                    CreateParameter("@pageIndex", SqlDbType.BigInt, pageIndex),
                    CreateParameter("@pageSize", SqlDbType.BigInt, pageSize)
            };
            return CreateCommand("LeadershipIncentivesRpt_Sp", parameters);
        }
        internal static SqlCommand WithdrawlPendingReqRpt(string action, Int32 pageIndex, Int32 pageSize)
        {
            var parameters = new[]
            {
                    CreateParameter("@action", SqlDbType.VarChar, action),                                                                     
                    CreateParameter("@pageIndex", SqlDbType.BigInt, pageIndex),
                    CreateParameter("@pageSize", SqlDbType.BigInt, pageSize)
            };
            return CreateCommand("WithdrawlPendingReqRpt_Sp", parameters);
        }
        internal static SqlCommand WithdrawlPendingReq(string reqids, string sesid)
        {
            var parameters = new[]
            {
                    CreateParameter("@reqids", SqlDbType.VarChar, reqids),                                                                     
                    CreateParameter("@sesid", SqlDbType.VarChar, sesid) 
            };
            return CreateCommand("WithdrawlPendingReq_Sp", parameters);
        }
        internal static SqlCommand WithdrawlBatchRpt(string action, Int32 pageIndex, Int32 pageSize)
        {
            var parameters = new[]
            {
                    CreateParameter("@action", SqlDbType.VarChar, action),                                                                     
                    CreateParameter("@pageIndex", SqlDbType.BigInt, pageIndex),
                    CreateParameter("@pageSize", SqlDbType.BigInt, pageSize)
            };
            return CreateCommand("WithdrawlBatchRpt_Sp", parameters);
        }
        internal static SqlCommand ProductAnalasysRpt(string action, DateTime startdate, Int32 pageIndex, Int32 pageSize)
        {
            var parameters = new[]
            {
                    CreateParameter("@action", SqlDbType.VarChar, action),                                                                     
                    CreateParameter("@startdate", SqlDbType.DateTime, startdate),                                                                     
                    CreateParameter("@pageIndex", SqlDbType.BigInt, pageIndex),
                    CreateParameter("@pageSize", SqlDbType.BigInt, pageSize)
            };
            return CreateCommand("ProductAnalasysRpt_Sp", parameters);
        }
        internal static SqlCommand DistributionAnalasysRpt(string action, DateTime startdate, Int32 pageIndex, Int32 pageSize)
        {
            var parameters = new[]
            {
                    CreateParameter("@action", SqlDbType.VarChar, action),                                                                     
                    CreateParameter("@startdate", SqlDbType.DateTime, startdate),                                                                     
                    CreateParameter("@pageIndex", SqlDbType.BigInt, pageIndex),
                    CreateParameter("@pageSize", SqlDbType.BigInt, pageSize)
            };
            return CreateCommand("DistributionAnalasysRpt_Sp", parameters);
        }
        internal static SqlCommand ActiveInactiveRpt(DateTime fromdate, DateTime todate, Int32 regid, int stateid, Int32 pageIndex, Int32 pageSize)
        {
            var parameters = new[]
            {                                                                                       
                    CreateParameter("@fromdate", SqlDbType.DateTime, fromdate), 
                    CreateParameter("@todate", SqlDbType.DateTime, todate),                                                 
                    CreateParameter("@regid", SqlDbType.BigInt, regid),
                    CreateParameter("@stateid", SqlDbType.Int, stateid),
                    CreateParameter("@pageIndex", SqlDbType.BigInt, pageIndex),
                    CreateParameter("@pageSize", SqlDbType.BigInt, pageSize)
            };
            return CreateCommand("ActiveInactiveRpt_Sp", parameters);
        }
        internal static SqlCommand LiisBinary(Int32 regid)
        {
            var parameters = new[]
                {
                    CreateParameter("@regid", SqlDbType.BigInt, regid)
                };
            return CreateCommand("LifeBinary_Sp", parameters);
        }
        internal static SqlCommand LiisBinaryInDet(Int32 regid, Int32 payno)
        {
            var parameters = new[]
                {
                    CreateParameter("@regid", SqlDbType.BigInt, regid),
                    CreateParameter("@payno", SqlDbType.BigInt, payno)
                };
            return CreateCommand("LifeBinaryInDet_Sp", parameters);
        }
        internal static SqlCommand InvoicesRpt(string invFrom, string invType, DateTime fromdate, DateTime todate, Int32 pageIndex, Int32 pageSize)
        {
            var parameters = new[]
            {       
                CreateParameter("@invFrom", SqlDbType.VarChar, invFrom),
               // CreateParameter("@idno", SqlDbType.VarChar, idno),
                CreateParameter("@invType", SqlDbType.VarChar, invType),
                CreateParameter("@fromdate", SqlDbType.DateTime, fromdate), 
                CreateParameter("@todate", SqlDbType.DateTime, todate),                                                                                         
                CreateParameter("@pageIndex", SqlDbType.BigInt, pageIndex),
                CreateParameter("@pageSize", SqlDbType.BigInt, pageSize)
            };
            return CreateCommand("InvoicesRpt_Sp", parameters);
        }
        internal static SqlCommand InvoicesRptAll(string action, string idno, string billno, DateTime fromdate, DateTime todate, Int32 pageIndex, Int32 pageSize)
        {
            var parameters = new[]
            {       
                CreateParameter("@Action", SqlDbType.VarChar, action),
                CreateParameter("@idno", SqlDbType.VarChar, idno),
                CreateParameter("@billno", SqlDbType.VarChar, billno),
                CreateParameter("@fromdate", SqlDbType.DateTime, fromdate), 
                CreateParameter("@todate", SqlDbType.DateTime, todate),                                                                                         
                CreateParameter("@pageIndex", SqlDbType.BigInt, pageIndex),
                CreateParameter("@pageSize", SqlDbType.BigInt, pageSize)
            };
            return CreateCommand("InvoicesRptAll_Sp", parameters);
        }
        internal static SqlCommand AppRejMemProfRpt(string action, Int32 regid, DateTime fromdate, DateTime todate, Int32 pageIndex, Int32 pageSize)
        {
            var parameters = new[]
            {       
                CreateParameter("@action", SqlDbType.VarChar, action),
                CreateParameter("@regid", SqlDbType.BigInt, regid),
                CreateParameter("@fromdate", SqlDbType.DateTime, fromdate), 
                CreateParameter("@todate", SqlDbType.DateTime, todate),                                                                                         
                CreateParameter("@pageIndex", SqlDbType.BigInt, pageIndex),
                CreateParameter("@pageSize", SqlDbType.BigInt, pageSize)
            };
            return CreateCommand("AppRejMemProfRpt_Sp", parameters);
        }
        internal static SqlCommand MemphotosforAppRej(string action, Int32 regid, DateTime fromdate, DateTime todate, Int32 pageIndex, Int32 pageSize)
        {
            var parameters = new[]
            {       
                CreateParameter("@action", SqlDbType.VarChar, action),
                CreateParameter("@regid", SqlDbType.BigInt, regid),
                CreateParameter("@fromdate", SqlDbType.DateTime, fromdate), 
                CreateParameter("@todate", SqlDbType.DateTime, todate),                                                                                         
                CreateParameter("@pageIndex", SqlDbType.BigInt, pageIndex),
                CreateParameter("@pageSize", SqlDbType.BigInt, pageSize)
            };
            return CreateCommand("MemphotosforAppRej_Sp", parameters);
        }
        internal static SqlCommand AppRejMemDetailes(string action, Int32 slno, Int32 status, Int32 byuser, string Remarks)
        {
            var parameters = new[]
                {
                    CreateParameter("@action", SqlDbType.VarChar, action) ,                                         
                    CreateParameter("@slno", SqlDbType.BigInt, slno) ,
                    CreateParameter("@status", SqlDbType.BigInt, status) ,
                    CreateParameter("@byuser", SqlDbType.BigInt, byuser),
                    CreateParameter("@Remarks", SqlDbType.VarChar, Remarks)
                };
            return CreateCommand("AppRejMemDetailes_SP", parameters);
        }
        internal static SqlCommand AppRejMemPhotos(Int32 slno, Int32 status, Int32 byuser, string action, string Remarks)
        {
            var parameters = new[]
                {                    
                    CreateParameter("@slno", SqlDbType.BigInt, slno) ,
                    CreateParameter("@status", SqlDbType.BigInt, status) ,                    
                    CreateParameter("@byuser", SqlDbType.BigInt, byuser) ,
                    CreateParameter("@action", SqlDbType.VarChar, action),
                    CreateParameter("@Remarks", SqlDbType.VarChar, Remarks)
                };
            return CreateCommand("AppRejMemPhotos_SP", parameters);
        }
        internal static SqlCommand ChkMobRchTransactionNo(string tranno)
        {
            var parameters = new[]
           {                                                                                                                                                       
                    CreateParameter("@tranno", SqlDbType.VarChar, tranno)                    
            };
            return CreateCommand("ChkMobRchTransactionNo_Sp", parameters);
        }
        internal static SqlCommand UpdateMobRchTransactionNo(string tranno, string sesid, string appby)
        {
            var parameters = new[]
           {                                                                                                                                                       
                    CreateParameter("@tranno", SqlDbType.VarChar, tranno),
                    CreateParameter("@sesid", SqlDbType.VarChar, sesid),
                    CreateParameter("@appby", SqlDbType.VarChar, appby)
            };
            return CreateCommand("UpdateMobRchTransactionNo_Sp", parameters);
        }
        internal static SqlCommand SpeedGlance(DateTime ondate, string username)
        {
            var parameters = new[]
           {                                                                                                                                                       
                    CreateParameter("@ondate", SqlDbType.DateTime, ondate) ,
                    CreateParameter("@username", SqlDbType.VarChar, username)
            };
            return CreateCommand("SpeedGlance_Sp", parameters);
        }
        internal static SqlCommand GlanceReport(string action, string type, DateTime ondate, string mailto)
        {
            var parameters = new[]
                {
                    CreateParameter("@action", SqlDbType.VarChar, action),
                    CreateParameter("@type", SqlDbType.VarChar, type),
                    CreateParameter("@ondate", SqlDbType.DateTime, ondate),
                    CreateParameter("@mailto", SqlDbType.VarChar, mailto)
                };
            return CreateCommand("GlanceReport_Sp", parameters);
        }
        internal static SqlCommand Cleartmpsms(string sesid)
        {
            var parameters = new[]
           {                                                                                                                                                                       
                    CreateParameter("@sesid", SqlDbType.VarChar, sesid) 
            };
            return CreateCommand("Cleartmpsms_SP", parameters);
        }

        internal static SqlCommand InsertResendSmsIds(Int32 regid, string sesid)
        {
            var parameters = new[]
           {                                                                                                                                                       
                    CreateParameter("@regid", SqlDbType.BigInt, regid) ,                    
                    CreateParameter("@sesid", SqlDbType.VarChar, sesid) 
            };
            return CreateCommand("insertresendsmsids_sp", parameters);
        }
        internal static SqlCommand InsertResendSms(string sesid)
        {
            var parameters = new[]
           {                                                                                                                                                                                             
                    CreateParameter("@sesid", SqlDbType.VarChar, sesid) 
            };
            return CreateCommand("InsertResendSms_sp", parameters);
        }
        internal static SqlCommand InsertNonMemsmsIds(string name, string mobile, string sesid)
        {
            var parameters = new[]
           {                                                                                                                                                       
                    CreateParameter("@name", SqlDbType.VarChar, name) ,  
                    CreateParameter("@mobile", SqlDbType.VarChar, mobile) ,  
                    CreateParameter("@sesid", SqlDbType.VarChar, sesid) 
            };
            return CreateCommand("insertnonmemsmsids_sp", parameters);
        }
        internal static SqlCommand InsertNonMemSms(string sesid, string msg)
        {
            var parameters = new[]
           {                                                                                                                                                                                             
                    CreateParameter("@sesid", SqlDbType.VarChar, sesid) ,
                    CreateParameter("@msg", SqlDbType.VarChar, msg) 
            };
            return CreateCommand("InsertNonMemSms_sp", parameters);
        }

        internal static SqlCommand GetSmsActions()
        {
            return CreateCommand("GetSmsActions_Sp");
        }
        internal static SqlCommand SmsLog(string action, DateTime fromdate, DateTime todate, Int32 pageIndex, Int32 pageSize)
        {
            var parameters = new[]
            {       
                CreateParameter("@action", SqlDbType.VarChar, action),               
                CreateParameter("@fromdate", SqlDbType.DateTime, fromdate), 
                CreateParameter("@todate", SqlDbType.DateTime, todate),                                                                                         
                CreateParameter("@pageIndex", SqlDbType.BigInt, pageIndex),
                CreateParameter("@pageSize", SqlDbType.BigInt, pageSize)
            };
            return CreateCommand("smslog_Sp", parameters);
        }
        internal static SqlCommand ResendSms(string sesid)
        {
            var parameters = new[]
           {                                                                                                                                                                       
                    CreateParameter("@sesid", SqlDbType.VarChar, sesid) 
            };
            return CreateCommand("ResendSms_Sp", parameters);
        }
        internal static SqlCommand MemberSms(string sesid, string msg)
        {
            var parameters = new[]
           {                                                                                                                                                                       
                    CreateParameter("@sesid", SqlDbType.VarChar, sesid),
                    CreateParameter("@msg", SqlDbType.VarChar, msg)
            };
            return CreateCommand("MemberSms_Sp", parameters);
        }
        internal static SqlCommand InsertMemberSms(string sesid, string msg)
        {
            var parameters = new[]
           {                                                                                                                                                                       
                    CreateParameter("@sesid", SqlDbType.VarChar, sesid),
                    CreateParameter("@msg", SqlDbType.VarChar, msg)
            };
            return CreateCommand("InsertMemberSms_Sp", parameters);
        }
        internal static SqlCommand BulkSms(string stateid, string city, string msg, string sesid)
        {
            var parameters = new[]
                {
                    CreateParameter("@stateid", SqlDbType.VarChar, stateid),
                    CreateParameter("@city", SqlDbType.VarChar, city),
                    CreateParameter("@msg", SqlDbType.VarChar, msg),
                    CreateParameter("@sesid", SqlDbType.VarChar, sesid)
                };
            return CreateCommand("BulkSms_Sp", parameters);
        }
        internal static SqlCommand InsertBulkSms(string stateid, string city, string msg, string sesid)
        {
            var parameters = new[]
                {
                    CreateParameter("@stateid", SqlDbType.VarChar, stateid),
                    CreateParameter("@city", SqlDbType.VarChar, city),
                    CreateParameter("@msg", SqlDbType.VarChar, msg),
                    CreateParameter("@sesid", SqlDbType.VarChar, sesid)
                };
            return CreateCommand("InsertBulkSms_Sp", parameters);
        }
        internal static SqlCommand GetMemforBirthdaysms()
        {
            return CreateCommand("GetMemforBirthdaysms_Sp");
        }
        internal static SqlCommand BirthdaySms()
        {
            return CreateCommand("BirthdaySms_Sp");
        }
        internal static SqlCommand InsertBirthdaySms(string msg, string sesid)
        {
            var parameters = new[]
                {
                    CreateParameter("@msg", SqlDbType.VarChar, msg),
                    CreateParameter("@sesid", SqlDbType.VarChar, sesid)
                };
            return CreateCommand("InsertBirthdaySms_Sp", parameters);
        }
        internal static SqlCommand GetMemforPayoutsms(Int32 payno)
        {
            var parameters = new[]
                {
                    CreateParameter("@payno", SqlDbType.Int, payno)
                };
            return CreateCommand("GetMemforPayoutsms_SP", parameters);
        }

        internal static SqlCommand PayoutSms(string idnos, Int16 payno, string sesid)
        {
            var parameters = new[]
                {
                    CreateParameter("@idnos", SqlDbType.VarChar, idnos),
                    CreateParameter("@payno", SqlDbType.Int, payno) ,
                    CreateParameter("@sesid", SqlDbType.VarChar, sesid)
                };
            return CreateCommand("PayoutSms_Sp", parameters);
        }

        internal static SqlCommand InsertPayoutSms(string idnos, Int16 payno, string sesid)
        {
            var parameters = new[]
                {
                    CreateParameter("@idnos", SqlDbType.VarChar, idnos),
                    CreateParameter("@payno", SqlDbType.Int, payno) ,
                    CreateParameter("@sesid", SqlDbType.VarChar, sesid)
                };
            return CreateCommand("InsertPayoutSms_Sp", parameters);
        }

        internal static SqlCommand Invoices(string action, string billno)
        {
            var parameters = new[]
                {   
                    CreateParameter("@action", SqlDbType.VarChar, action),
                    CreateParameter("@billno", SqlDbType.VarChar, billno) 
                };
            return CreateCommand("Invoices_Sp", parameters);
        }
        internal static SqlCommand WithdrawlBatchExcel(string wdno)
        {
            var parameters = new[]
                {                       
                    CreateParameter("@wdno", SqlDbType.VarChar, wdno) 
                };
            return CreateCommand("WithdrawlBatchExcel_Sp", parameters);
        }
        internal static SqlCommand GetVouchers(string action, Int32 regid, string sfcpCode, string sesid)
        {
            var parameters = new[]
                {                       
                    CreateParameter("@action", SqlDbType.VarChar, action) ,
                    CreateParameter("@regid", SqlDbType.BigInt, regid) ,
                    CreateParameter("@sfcpCode", SqlDbType.VarChar, sfcpCode) ,
                    CreateParameter("@sesid", SqlDbType.VarChar, sesid) 
                };
            return CreateCommand("GetVouchers_SP", parameters);
        }
        internal static SqlCommand ShoppingRequests(int sts, Int32 pageindex, Int32 pagesize, DateTime fromdate, DateTime todate)
        {
            var parameters = new[]
                {   
                    CreateParameter("@sts", SqlDbType.Int, sts),
                    CreateParameter("@pageindex", SqlDbType.BigInt, pageindex),
                    CreateParameter("@pagesize", SqlDbType.BigInt, pagesize),
                    CreateParameter("@fromdate", SqlDbType.DateTime, fromdate),
                    CreateParameter("@todate", SqlDbType.DateTime, todate)
                };
            return CreateCommand("ShoppingRequests_Sp", parameters);
        }
        internal static SqlCommand ShoppingRequestReject(string reqno, string remarks, string sesid, Int32 uid)
        {
            var parameters = new[]
                {   
                    CreateParameter("@reqno", SqlDbType.VarChar, reqno),
                    CreateParameter("@remarks", SqlDbType.VarChar, remarks),
                    CreateParameter("@sesid", SqlDbType.VarChar, sesid),
                    CreateParameter("@uid", SqlDbType.BigInt, uid) 
                };
            return CreateCommand("ShoppingRequestReject_Sp", parameters);
        }
        internal static SqlCommand ShoppingRequestApprove(string reqno, double billamount, string mop, string tranno,
                                                          string tranbank, string tranbranch, DateTime trandate,
                                                          string remarks, string sesid, Int32 uid)
        {
            var parameters = new[]
                {   
                    CreateParameter("@reqno", SqlDbType.VarChar, reqno),
                    CreateParameter("@billamount", SqlDbType.Money, billamount),
                    CreateParameter("@mop", SqlDbType.VarChar, mop),
                    CreateParameter("@tranno", SqlDbType.VarChar, tranno),
                    CreateParameter("@tranbank", SqlDbType.VarChar, tranbank),                    
                    CreateParameter("@tranbranch", SqlDbType.VarChar, tranbranch),
                    CreateParameter("@trandate", SqlDbType.DateTime, trandate),
                    CreateParameter("@remarks", SqlDbType.VarChar, remarks),
                    CreateParameter("@sesid", SqlDbType.VarChar, sesid),
                    CreateParameter("@uid", SqlDbType.BigInt, uid) 
                };
            return CreateCommand("ShoppingRequestApprove_Sp", parameters);
        }
        internal static SqlCommand CrocrepatiRewardReport(int reward, Int32 regid, Int32 payno, Int32 pageindex, Int32 pagesize)
        {
            var parameters = new[]
                {   
                    CreateParameter("@reward", SqlDbType.Int, reward ),
                    CreateParameter("@regid", SqlDbType.BigInt, regid),
                    CreateParameter("@payno", SqlDbType.BigInt, payno),
                    CreateParameter("@pageindex", SqlDbType.BigInt, pageindex),
                    CreateParameter("@pagesize", SqlDbType.BigInt, pagesize)
                };
            return CreateCommand("CrocrepatiRewardReport_SP", parameters);
        }
        internal static SqlCommand BigBossRewardReport(int reward, Int32 pageindex, Int32 pagesize)
        {
            var parameters = new[]
                {   
                    CreateParameter("@reward", SqlDbType.Int, reward ),            
                    CreateParameter("@pageindex", SqlDbType.BigInt, pageindex),
                    CreateParameter("@pagesize", SqlDbType.BigInt, pagesize)
                };
            return CreateCommand("BigBossRewardReport_Sp", parameters);
        }
        internal static SqlCommand BigBossRequestsRpt(string sts, DateTime fromdate, DateTime todate, Int32 regid, Int32 pageIndex, Int32 pageSize)
        {
            var parameters = new[]
            {       
                CreateParameter("@sts", SqlDbType.VarChar, sts),               
                CreateParameter("@fromdate", SqlDbType.DateTime, fromdate), 
                CreateParameter("@todate", SqlDbType.DateTime, todate),                                                                                         
                CreateParameter("@regid", SqlDbType.BigInt, regid),
                CreateParameter("@pageIndex", SqlDbType.BigInt, pageIndex),
                CreateParameter("@pageSize", SqlDbType.BigInt, pageSize)
            };
            return CreateCommand("BigBossRequestsRpt_Sp", parameters);
        }
        internal static SqlCommand BigBossReqAppRej(Int32 sno, string sts, string remarks, Int32 uid, string sesid)
        {
            var parameters = new[]
                {   
                    CreateParameter("@sno", SqlDbType.BigInt, sno) ,
                    CreateParameter("@sts", SqlDbType.VarChar, sts),
                    CreateParameter("@remarks", SqlDbType.VarChar, remarks),
                    CreateParameter("@uid", SqlDbType.BigInt, uid) ,
                    CreateParameter("@sesid", SqlDbType.VarChar, sesid)
                    
                };
            return CreateCommand("BigBossReqAppRej_SP", parameters);
        }
        internal static SqlCommand PkgPrdMonthWiseCnt(string month)
        {
            var parameters = new[]
                {                       
                    CreateParameter("@month", SqlDbType.VarChar, month)
                };
            return CreateCommand("PkgPrdMonthWiseCnt_SP", parameters);
        }
        internal static SqlCommand GetBatch(string tblname, string getcolum, string columnItem, string columnVal, string batchno)
        {
            var parameters = new[]
            {
                CreateParameter("@tblname", SqlDbType.VarChar,tblname),                 
                CreateParameter("@getcolum", SqlDbType.VarChar,getcolum),                 
                CreateParameter("@columnItem", SqlDbType.VarChar,columnItem),
                CreateParameter("@itemId", SqlDbType.VarChar,columnVal),
                CreateParameter("@Batchno", SqlDbType.VarChar,batchno)
            };
            return CreateCommand("GetBatch_Sp", parameters);
        }
        internal static SqlCommand ResetPassword(Int32 regid, string pwd, int uid, int pwdType, int sms, int changed)
        {
            var parameters = new[]
                {
                    CreateParameter("@regid", SqlDbType.Int, regid),
                    CreateParameter("@pwd", SqlDbType.VarChar, pwd),
                    CreateParameter("@UpdatedBy", SqlDbType.Int, uid),
                    CreateParameter("@pwdType", SqlDbType.Int, pwdType),
                    CreateParameter("@sms", SqlDbType.Int, sms),
                    CreateParameter("@changed", SqlDbType.Int, changed)

                };
            return CreateCommand("ResetPassword_Sp", parameters);
        }
        internal static SqlCommand InsBankStatement(string action, DateTime stmdate, double Amount, string Description, string bank, DateTime date, string createdby, string sesid, string ipaddress, Int32 pageIndex, Int32 pageSize, string TranType)
        {
            var parameters = new[]
            {
                CreateParameter("@action", SqlDbType.VarChar, action),  
                CreateParameter("@stmdate", SqlDbType.DateTime, stmdate) ,
                CreateParameter("@Amount", SqlDbType.Money, Amount),
                CreateParameter("@Bank", SqlDbType.VarChar, bank),
                CreateParameter("@Description", SqlDbType.VarChar, Description),
                CreateParameter("@date", SqlDbType.DateTime, date) ,
                CreateParameter("@createdBy", SqlDbType.VarChar,createdby),
                CreateParameter("@sesid", SqlDbType.VarChar, sesid), 
                CreateParameter("@ipaddress", SqlDbType.VarChar, ipaddress),
                CreateParameter("@pageIndex", SqlDbType.Int,pageIndex) ,
                CreateParameter("@pageSize", SqlDbType.Int,pageSize) ,
                CreateParameter("@TranType", SqlDbType.VarChar, TranType)
            };
            return CreateCommand("InsBankStatement_SP", parameters);
        }
        internal static SqlCommand CompanyNotifications(string type, Int32 regid, string gcmid, string subject, string message, string image, string url)
        {
            var parameters = new[]
            {
                CreateParameter("@type", SqlDbType.VarChar, type),
                CreateParameter("@regid", SqlDbType.BigInt, regid) ,
                CreateParameter("@gcmid", SqlDbType.VarChar, gcmid),
                CreateParameter("@subject", SqlDbType.VarChar, subject ),
                CreateParameter("@message", SqlDbType.VarChar, message ),
                CreateParameter("@image", SqlDbType.VarChar, image ),
                CreateParameter("@url", SqlDbType.VarChar, url )
                               
            };
            return CreateCommand("CompanyNotifications_SP", parameters);
        }
        internal static SqlCommand KycPendingRpt(string type, string ModuleType)
        {
            var parameters = new[]
                {
                    CreateParameter("@type", SqlDbType.VarChar, type),
                    CreateParameter("@ModuleType", SqlDbType.VarChar, ModuleType)
                };
            return CreateCommand("KYCPendingRpt_Sp", parameters);
        }
        internal static SqlCommand KycReport(string action, DateTime frmdate, DateTime todate, Int32 regid, Int32 pageIndex, Int32 pagesize, Int32 status)
        {
            var parameters = new[]
                {
                    CreateParameter("@action", SqlDbType.VarChar, action) ,                    
                    CreateParameter("@frmdate", SqlDbType.DateTime, frmdate) ,
                    CreateParameter("@todate", SqlDbType.DateTime, todate) ,
                    CreateParameter("@regid", SqlDbType.BigInt, regid) ,
                    CreateParameter("@pageIndex", SqlDbType.BigInt, pageIndex) ,
                    CreateParameter("@pagesize", SqlDbType.BigInt, pagesize), 
                    CreateParameter("@Status", SqlDbType.BigInt, status) 
                };
            return CreateCommand("KycReport_Sp", parameters);
        }
        internal static SqlCommand ApproveKyc(Int32 slno, Int32 apprej, string sesid, string remarks, Int32 apprejby, string type)
        {
            var parameters = new[]
                {                    
                    CreateParameter("@sno", SqlDbType.BigInt, slno) ,
                    CreateParameter("@apprej", SqlDbType.BigInt, apprej) ,
                    CreateParameter("@sesid", SqlDbType.VarChar, sesid) ,
                    CreateParameter("@remarks", SqlDbType.VarChar, remarks) ,
                    CreateParameter("@apprejby", SqlDbType.BigInt, apprejby) ,
                    CreateParameter("@Type", SqlDbType.VarChar, type) 
                };
            return CreateCommand("ApproveKYC_SP", parameters);
        }
        internal static SqlCommand MemphotosReport(string action, DateTime frmdate, DateTime todate, Int32 regid, Int32 pageIndex, Int32 pagesize)
        {
            var parameters = new[]
                {
                    CreateParameter("@action", SqlDbType.VarChar, action) ,                    
                    CreateParameter("@frmdate", SqlDbType.DateTime, frmdate) ,
                    CreateParameter("@todate", SqlDbType.DateTime, todate) ,
                    CreateParameter("@regid", SqlDbType.BigInt, regid) ,
                    CreateParameter("@pageIndex", SqlDbType.BigInt, pageIndex) ,
                    CreateParameter("@pagesize", SqlDbType.BigInt, pagesize) 
                };
            return CreateCommand("MemphotosReport_Sp", parameters);
        }
        internal static SqlCommand RegistrationReport1(string searchid, Int32 status, DateTime frmdate, DateTime todate,
                                                      Int32 regid, Int32 stateid, Int32 pageIndex, Int32 pageSize, string val)
        {
            var parameters = new[]
            {                
                CreateParameter("@searchid", SqlDbType.VarChar, searchid) ,
                CreateParameter("@status", SqlDbType.Int, status) ,
                CreateParameter("@frmdate", SqlDbType.DateTime, frmdate) ,
                CreateParameter("@todate", SqlDbType.DateTime, todate) ,                
                CreateParameter("@regid", SqlDbType.BigInt, regid) ,
                CreateParameter("@stateid", SqlDbType.Int, stateid) ,
                CreateParameter("@pageIndex", SqlDbType.BigInt, pageIndex) ,
                CreateParameter("@pageSize", SqlDbType.BigInt, pageSize) ,
                CreateParameter("@val", SqlDbType.VarChar, val) ,
            };
            return CreateCommand("RegistrationReport_Sp", parameters);
        }
        internal static SqlCommand GetCount(string mailid)
        {
            var parameters = new[]
            {
                CreateParameter("@mailid", SqlDbType.VarChar, mailid)                
            };
            return CreateCommand("GetmailCount_Sp", parameters);
        }
        internal static SqlCommand GetMails(string mailid)
        {
            var parameters = new[]
            {
                CreateParameter("@mailid", SqlDbType.VarChar, mailid)                
            };
            return CreateCommand("GetMails_Sp", parameters);
        }
        internal static SqlCommand GetAttch(Int32 id)
        {
            var parameters = new[]
            {
                CreateParameter("@mailid", SqlDbType.VarChar, id)                
            };
            return CreateCommand("GetAttach_SP", parameters);
        }
        internal static SqlCommand SearchMails(string mailFrom, string mailTo)
        {
            var parameters = new[]
            {
                CreateParameter("@mailFrom", SqlDbType.VarChar, mailFrom),                
                CreateParameter("@mailTo", SqlDbType.VarChar, mailTo)                
            };
            return CreateCommand("SearchMails_Sp", parameters);
        }
        internal static SqlCommand DeleteMail(Int32 id)
        {
            var parameters = new[]
            {
                CreateParameter("@mailid", SqlDbType.Int, id)                
            };
            return CreateCommand("DeleteMail_Sp", parameters);
        }
        internal static SqlCommand IsAttachExit(Int32 id)
        {
            var parameters = new[]
            {
                CreateParameter("@id", SqlDbType.Int, id)                
            };
            return CreateCommand("IsAttachExit_Sp", parameters);
        }
        internal static SqlCommand GetBulkMessage(Int32 id)
        {
            var parameters = new[]
            {
                CreateParameter("@MailId", SqlDbType.Int, id)                
            };
            return CreateCommand("GetBulkMessage_Sp", parameters);
        }
        internal static SqlCommand GetBulkSubject(Int32 id)
        {
            var parameters = new[]
            {
                CreateParameter("@MailId", SqlDbType.Int, id)                
            };
            return CreateCommand("GetBulkMessageSubject_SP", parameters);
        }
        internal static SqlCommand GetMessage(Int32 id)
        {
            var parameters = new[]
            {
                CreateParameter("@MailId", SqlDbType.Int, id)                
            };
            return CreateCommand("GetMessage_SP", parameters);
        }
        internal static SqlCommand GetSubject(Int32 id)
        {
            var parameters = new[]
            {
                CreateParameter("@MailId", SqlDbType.Int, id)                
            };
            return CreateCommand("GetMessageSubject_SP", parameters);
        }
        internal static SqlCommand GetMsgFrom(Int32 id)
        {
            var parameters = new[]
            {
                CreateParameter("@MailId", SqlDbType.Int, id)                
            };
            return CreateCommand("GetMessageFrom_SP", parameters);
        }
        internal static SqlCommand GetMsgTo(Int32 id)
        {
            var parameters = new[]
            {
                CreateParameter("@MailId", SqlDbType.Int, id)                
            };
            return CreateCommand("GetMessageTo_SP", parameters);
        }
        internal static SqlCommand GetMsgDate(Int32 id)
        {
            var parameters = new[]
            {
                CreateParameter("@MailId", SqlDbType.Int, id)                
            };
            return CreateCommand("GetMessageDate_SP", parameters);
        }
        internal static SqlCommand GetDraftMsg(Int32 id)
        {
            var parameters = new[]
            {
                CreateParameter("@MailId", SqlDbType.Int, id)                
            };
            return CreateCommand("GetDraftMsg_SP", parameters);
        }
        internal static SqlCommand ReplyMail(string mailfrom, string mailto, string subject, string msg, DateTime sentdate, int savenSend, Int32 mailId, string repSubject, string file,string ReqNo,string Status)
        {
            var parameters = new[]
            {
                CreateParameter("@mailfrom", SqlDbType.VarChar, mailfrom) ,
                CreateParameter("@mailto", SqlDbType.VarChar, mailto) ,
                CreateParameter("@subject", SqlDbType.VarChar, subject) ,
                CreateParameter("@msg", SqlDbType.VarChar, msg) ,
                CreateParameter("@sentdate", SqlDbType.DateTime, sentdate) ,
                CreateParameter("@savenSend", SqlDbType.Int, savenSend) ,
                CreateParameter("@MailId", SqlDbType.Int, mailId) ,
                CreateParameter("@RepSubject", SqlDbType.VarChar, repSubject),
                CreateParameter("@file", SqlDbType.VarChar, file),
                CreateParameter("@ReqNo", SqlDbType.VarChar, ReqNo),
                CreateParameter("@Status", SqlDbType.VarChar, Status)
            };
            return CreateCommand("ReplyMail_SP", parameters);
        }
        internal static SqlCommand SendMail(string mailfrom, string mailto, string subject, string msg, DateTime sentdate, int savenSend, string file, string toType)
        {
            var parameters = new[]
            {
                CreateParameter("@mailfrom", SqlDbType.VarChar, mailfrom) ,
                CreateParameter("@mailto", SqlDbType.VarChar, mailto) ,
                CreateParameter("@subject", SqlDbType.VarChar, subject) ,
                CreateParameter("@msg", SqlDbType.VarChar, msg) ,
                CreateParameter("@sentdate", SqlDbType.DateTime, sentdate) ,
                CreateParameter("@savenSend", SqlDbType.Int, savenSend) ,
                CreateParameter("@file", SqlDbType.VarChar, file) ,
                CreateParameter("@toType", SqlDbType.VarChar, toType) 
            };
            return CreateCommand("Inbox_SP", parameters);
        }
        internal static SqlCommand GetSentMails(string mailId)
        {
            var parameters = new[]
            {
                CreateParameter("@MailId", SqlDbType.VarChar, mailId)                
            };
            return CreateCommand("GetSentMails_SP", parameters);
        }
        internal static SqlCommand DeleteSentMails(Int32 mailId)
        {
            var parameters = new[]
            {
                CreateParameter("@MailId", SqlDbType.Int, mailId)                
            };
            return CreateCommand("DeleteSentMails_SP", parameters);
        }
        internal static SqlCommand SendBulkMail(string mailfrom, string subject, string msg, DateTime sentdate)
        {
            var parameters = new[]
            {
                CreateParameter("@mailfrom", SqlDbType.VarChar, mailfrom) ,                
                CreateParameter("@subject", SqlDbType.VarChar, subject) ,
                CreateParameter("@msg", SqlDbType.VarChar, msg) ,
                CreateParameter("@sentdate", SqlDbType.DateTime, sentdate)  
            };
            return CreateCommand("insert_bulkmails_SP", parameters);
        }
        internal static SqlCommand GetBulkMails()
        {
            return CreateCommand("GetBulkMails_SP");
        }
        internal static SqlCommand DeleteBulkMail(Int32 mailId)
        {
            var parameters = new[]
            {
                CreateParameter("@MailId", SqlDbType.Int, mailId)                
            };
            return CreateCommand("DeleteBulkMail_SP", parameters);
        }
        internal static SqlCommand CreateFolder(string folderName, string memId)
        {
            var parameters = new[]
            {
                CreateParameter("@folderName", SqlDbType.VarChar, folderName),
                CreateParameter("@memId", SqlDbType.VarChar, memId)  
            };
            return CreateCommand("CreateFolder_SP", parameters);
        }
        internal static SqlCommand GetFolderMailsMails(string mailId, Int32 folderId)
        {
            var parameters = new[]
            {
                CreateParameter("@mailId", SqlDbType.VarChar, mailId),
                CreateParameter("@folderId", SqlDbType.Int, folderId)  
            };
            return CreateCommand("GetFolderMails_SP", parameters);
        }
        //29-02 Satish Added
        internal static SqlCommand Glance(DateTime fromdate, DateTime todate, Int32 uid)
        {
            var parameters = new[]
                {   
                    CreateParameter("@fromdate", SqlDbType.DateTime, fromdate) ,
                    CreateParameter("@todate", SqlDbType.DateTime, todate) ,
                    CreateParameter("@uid", SqlDbType.Int, uid)  
                };
            return CreateCommand("Glance_SP", parameters);
        }
        internal static SqlCommand GlanceReportNew(string action, string rpttype, DateTime fromdate, DateTime todate, Int32 mailto, Int32 sts, string searchby, Int32 pageindex, Int32 pagesize)
        {
            var parameters = new[]
                {   
                    CreateParameter("@action", SqlDbType.VarChar, action) ,
                    CreateParameter("@rpttype", SqlDbType.VarChar, rpttype) ,
                    CreateParameter("@fromdate", SqlDbType.DateTime, fromdate) ,
                    CreateParameter("@todate", SqlDbType.DateTime, todate) ,
                    CreateParameter("@mailto", SqlDbType.Int, mailto)  ,
                    CreateParameter("@sts", SqlDbType.Int, sts) ,
                    CreateParameter("@searchby", SqlDbType.VarChar, searchby) ,
                    CreateParameter("@pageindex", SqlDbType.Int, pageindex) ,
                    CreateParameter("@pagesize", SqlDbType.Int, pagesize) 
                };
            return CreateCommand("GlanceReport_Sp", parameters);
        }
        internal static SqlCommand VATCSTReport(string action, string idno, string billno, Int16 status, DateTime frmdate, DateTime todate, Int32 pageIndex, Int32 pageSize,
            Int32 month, Int32 year, Int32 month1, Int32 year1, string state)
        {
            var parameters = new[]
            {   
                CreateParameter("@action", SqlDbType.VarChar, action) ,
                CreateParameter("@idno", SqlDbType.VarChar, idno) ,
                CreateParameter("@billno", SqlDbType.VarChar, billno) ,
                CreateParameter("@status", SqlDbType.Int, status) ,
                CreateParameter("@frmdate", SqlDbType.DateTime, frmdate) ,
                CreateParameter("@todate", SqlDbType.DateTime, todate) ,  
                CreateParameter("@pageIndex", SqlDbType.BigInt, pageIndex) ,
                CreateParameter("@pageSize", SqlDbType.BigInt, pageSize),
                CreateParameter("@month", SqlDbType.BigInt, month),
                CreateParameter("@year", SqlDbType.BigInt, year),
                CreateParameter("@month1", SqlDbType.BigInt, month1),
                CreateParameter("@year1", SqlDbType.BigInt, year1),
                CreateParameter("@state", SqlDbType.VarChar, state)
            };
            return CreateCommand("VATCSTReport_Sp", parameters);
        }
        internal static SqlCommand GetRegions(string search, string stype)
        {
            var parameters = new[]
            {                
                CreateParameter("@search", SqlDbType.VarChar, search),
                CreateParameter("@stype", SqlDbType.VarChar, stype)                
            };
            return CreateCommand("GetRegions_Sp", parameters);
        }
        internal static SqlCommand SalesReport(DateTime frmdate, DateTime todate, string orderid, Int32 pageIndex, Int32 pageSize)
        {
            var parameters = new[]
            {   
                CreateParameter("@frmdate", SqlDbType.DateTime, frmdate) ,
                CreateParameter("@todate", SqlDbType.DateTime, todate) , 
                CreateParameter("@orderid", SqlDbType.VarChar, orderid) ,
                CreateParameter("@pageIndex", SqlDbType.BigInt, pageIndex) ,
                CreateParameter("@pageSize", SqlDbType.BigInt, pageSize) 
            };
            return CreateCommand("SalesReport_Sp", parameters);
        }

        //01-03 Satish
        internal static SqlCommand NewsRptNew(string action, Int32 nid, string description, Int32 createdby, string ntype, string subject)
        {
            var parameters = new[]
                {
                    CreateParameter("@Action", SqlDbType.VarChar, action),                    
                    CreateParameter("@nid", SqlDbType.Int, nid),
                    CreateParameter("@Description", SqlDbType.VarChar, description),                    
                    CreateParameter("@CreatedBy", SqlDbType.Int, createdby),                   
                    CreateParameter("@ntype", SqlDbType.VarChar, ntype),
                    CreateParameter("@subject", SqlDbType.VarChar, subject)
                };
            return CreateCommand("NewsRpt_Sp", parameters);
        }

        internal static SqlCommand FaqsRptNew(string action, Int32 faqid, string qusetion, string answer, Int32 user, string sessid)
        {
            var parameters = new[]
                {
                    CreateParameter("@Action", SqlDbType.VarChar, action),   
                    CreateParameter("@faqid", SqlDbType.Int, faqid), 
                    CreateParameter("@Question", SqlDbType.VarChar, qusetion),
                    CreateParameter("@Answer", SqlDbType.VarChar, answer),               
                    CreateParameter("@user", SqlDbType.Int, user),                                     
                    CreateParameter("@Sessid", SqlDbType.VarChar, sessid) 
                };
            return CreateCommand("FAQSRpt_Sp", parameters);
        }
        internal static SqlCommand Downloadfiles(string action, Int32 sno, Int32 status)
        {
            var parameters = new[]
               {    
                    CreateParameter("@action", SqlDbType.VarChar, action),
                    CreateParameter("@sno", SqlDbType.Int, sno),
                    CreateParameter("@status", SqlDbType.Int, status)
                };
            return CreateCommand("Downloadfiles_Sp", parameters);
        }
        internal static SqlCommand InsertDownloadfiles(string title, string filename, string uploadby, string sesid)
        {
            var parameters = new[]
               {                    
                    CreateParameter("@title", SqlDbType.VarChar, title),
                    CreateParameter("@Downloadfile", SqlDbType.VarChar, filename),
                    CreateParameter("@Uploadby", SqlDbType.VarChar, uploadby),
                    CreateParameter("@sesid", SqlDbType.VarChar, sesid),
                };
            return CreateCommand("InsertDownloadfiles_Sp", parameters);
        }
        //02-03 Satish
        internal static SqlCommand GetMailfoldersname(string memid)
        {
            var parameters = new[]
            {
                CreateParameter("@memid", SqlDbType.VarChar, memid)                
            };
            return CreateCommand("GetMailfoldersname_Sp", parameters);
        }
        internal static SqlCommand InsertIntoFolder(Int32 mailId, Int32 folderId)
        {
            var parameters = new[]
            {
                CreateParameter("@mailId", SqlDbType.Int, mailId),                
                CreateParameter("@folderId", SqlDbType.Int, folderId)                
            };
            return CreateCommand("InsertIntoFolder_Sp", parameters);
        }
        internal static SqlCommand CheckSentID(string to, string toid)
        {
            var parameters = new[]
            {
                CreateParameter("@MailTo", SqlDbType.VarChar, to),                
                CreateParameter("@ToID", SqlDbType.VarChar, toid)  
            };
            return CreateCommand("CheckSentID", parameters);
        }
        //03-03
        public static SqlCommand GetSprDetails(string id)
        {
            var parameters = new[]
            {
                CreateParameter("@uid", SqlDbType.Int, id)                
            };
            return CreateCommand("GetMemberId", parameters);
        }
        public static SqlCommand MemberCheck(string id)
        {
            var parameters = new[]
            {
                CreateParameter("@uid", SqlDbType.Int, id)                
            };
            return CreateCommand("CheckMember_SP", parameters);
        }
        public static SqlCommand VerifyLoginDetails(string id)
        {
            var parameters = new[]
            {
                CreateParameter("@uid", SqlDbType.Int, id)                
            };
            return CreateCommand("GetMemberId", parameters);
        }
        public static SqlCommand UnilevelTreeIdDet(string id)
        {
            var parameters = new[]
            {
                CreateParameter("@uid", SqlDbType.Int, id)                
            };
            return CreateCommand("UnilevelTreeIDDet_Sp", parameters);
        }
        public static SqlCommand Unilvltree(string id)
        {
            var parameters = new[]
            {
                CreateParameter("@uid", SqlDbType.Int, id)                
            };
            return CreateCommand("sp_unilvltreeview", parameters);
        }
        internal static SqlCommand CreditReqPending()
        {
            return CreateCommand("CreditReqPending_SP");
        }
        internal static SqlCommand GetCreditreq(string reqcode)
        {
            var parameters = new[]
                {
                    CreateParameter("@reqcode", SqlDbType.VarChar, reqcode) 
                };
            return CreateCommand("GetCreditreq_sp", parameters);
        }
        internal static SqlCommand AppRejCreditRqt(string reqcode, int apprej, Int32 user, string sessid, string remarks)
        {
            var parameters = new[]
                {
                    CreateParameter("@reqcode", SqlDbType.VarChar, reqcode) ,
                    CreateParameter("@apprej", SqlDbType.Int, apprej) ,
                    CreateParameter("@user", SqlDbType.Int, user) ,
                    CreateParameter("@sessid", SqlDbType.VarChar, sessid) ,
                    CreateParameter("@remarks", SqlDbType.VarChar, remarks) 
                };
            return CreateCommand("AppRejCreditRqt_SP", parameters);
        }
        internal static SqlCommand GetCreditReqRpt(int reqstatus, int cbank, DateTime frmdate, DateTime todate, Int32 regid, Int32 pageIndex, Int32 pagesize)
        {
            var parameters = new[]
                {
                    CreateParameter("@reqstatus", SqlDbType.Int, reqstatus) ,
                    CreateParameter("@cbank", SqlDbType.Int, cbank) ,
                    CreateParameter("@frmdate", SqlDbType.DateTime, frmdate) ,
                    CreateParameter("@todate", SqlDbType.DateTime, todate) ,
                    CreateParameter("@regid", SqlDbType.BigInt, regid) ,
                    CreateParameter("@pageIndex", SqlDbType.BigInt, pageIndex) ,
                    CreateParameter("@pagesize", SqlDbType.BigInt, pagesize) 
                };
            return CreateCommand("GetCreditReqRpt_SP", parameters);
        }
        //rk
        internal static SqlCommand UsedCouponsRpt(DateTime frmdate, DateTime todate, Int32 regid, Int32 pageIndex, Int32 pagesize)
        {
            var parameters = new[]
                {
                  
                    CreateParameter("@frmdate", SqlDbType.DateTime, frmdate) ,
                    CreateParameter("@todate", SqlDbType.DateTime, todate) ,
                    CreateParameter("@regid", SqlDbType.BigInt, regid) ,
                    CreateParameter("@pageIndex", SqlDbType.BigInt, pageIndex) ,
                    CreateParameter("@pagesize", SqlDbType.BigInt, pagesize) 
                };
            return CreateCommand("UsedCouponsRpt_SP", parameters);
        }
        internal static SqlCommand MemberRpOrders(Int32 regid, Int32 rpstatus, Int32 pageindex, Int32 pagesize, string Action)
        {
            var parameters = new[]
                {
                    CreateParameter("@regid", SqlDbType.Int, regid),
                    CreateParameter("@rpstatus", SqlDbType.Int, rpstatus),                                        
                    CreateParameter("@pageindex", SqlDbType.BigInt, pageindex),
                    CreateParameter("@pagesize", SqlDbType.BigInt, pagesize),
                    CreateParameter("@Action", SqlDbType.VarChar, Action)
                };
            return CreateCommand("MemberRpOrders_Sp", parameters);
        }
        internal static SqlCommand Reg_OrderNo_Check(string RefNo, string Fcode, string ReceiptType)
        {
            var parameters = new[]
                {
                    CreateParameter("@RefNo", SqlDbType.Int, RefNo),
                    CreateParameter("@Fcode", SqlDbType.Int, Fcode),                                        
                    CreateParameter("@ReceiptType", SqlDbType.BigInt, ReceiptType),
                };
            return CreateCommand("Reg_OrderNo_Check_SP", parameters);
        }
        internal static SqlCommand GetFeedbacks()
        {
            return CreateCommand("GetFeedback_sp");
        }
        internal static SqlCommand AppConsultMOP(string action, Int64 Regid, string mop, double amount, string refno, string refbank, string refbranch, DateTime refDate, string remarks, string orderno, int ApprovedBy)
        {
            var parameters = new[]
                {
                    CreateParameter("@action", SqlDbType.VarChar, action),
                    CreateParameter("@Regid", SqlDbType.Int, Regid),                    
                    CreateParameter("@mop", SqlDbType.VarChar, mop),
                    CreateParameter("@amount", SqlDbType.Money, amount),
                    CreateParameter("@refno", SqlDbType.VarChar, refno),
                    CreateParameter("@refbank", SqlDbType.VarChar, refbank),
                    CreateParameter("@refbranch", SqlDbType.VarChar, refbranch),
                    CreateParameter("@refDate", SqlDbType.DateTime, refDate),
                    CreateParameter("@remarks", SqlDbType.VarChar, remarks),
                    CreateParameter("@orderno", SqlDbType.VarChar, orderno),
                     CreateParameter("@ApprovedBy", SqlDbType.Int, ApprovedBy)//Modified by suresh on 13/5
                };
            return CreateCommand("AppConsultMOP_Sp", parameters);
        }
        internal static SqlCommand InsertBatchOutSms(Int32 regid, string Mobile, string msg, string sessid)
        {
            var parameters = new[]
                {
                    CreateParameter("@regid", SqlDbType.Int, regid),
                    CreateParameter("@mobile", SqlDbType.VarChar, Mobile),                                        
                    CreateParameter("@msg", SqlDbType.VarChar, msg),
                    CreateParameter("@sesid", SqlDbType.VarChar, sessid)
                };
            return CreateCommand("InsertBatchOutSms_Sp", parameters);
        }

        //14/03/2016 Satish
        internal static SqlCommand FaqsReport(string Type, DateTime Fromdate, DateTime Todate, int Pagesize, int PageIndex)
        {
            var parameters = new[]
            {
                CreateParameter("@Type", SqlDbType.VarChar, Type),
                CreateParameter("@Fromdate", SqlDbType.DateTime, Fromdate),                                        
                CreateParameter("@Todate", SqlDbType.DateTime, Todate),
                CreateParameter("@Pagesize", SqlDbType.Int, Pagesize),
                CreateParameter("@PageIndex", SqlDbType.Int, PageIndex)
            };
            return CreateCommand("Faqreport", parameters);
        }

        //16/03 Satish
        internal static SqlCommand OfferPopup(string action, string Title, string Subject, string Image, string Description, int Uid, DateTime Exp, int SNo)
        {
            var parameters = new[]
            {
                CreateParameter("@action", SqlDbType.VarChar, action),
                CreateParameter("@Title", SqlDbType.VarChar, Title),
                CreateParameter("@Subject", SqlDbType.VarChar, Subject),
                CreateParameter("@Image", SqlDbType.VarChar, Image),
                CreateParameter("@Description", SqlDbType.VarChar, Description),
                CreateParameter("@Uid", SqlDbType.Int, Uid),
                CreateParameter("@Exp", SqlDbType.VarChar, Exp),
                CreateParameter("@SNo", SqlDbType.VarChar, SNo)
            };
            return CreateCommand("OfferPopups", parameters);
        }
        //17/03 Satish
        internal static SqlCommand chkmemdown(string id, string down)
        {
            var parameters = new[]
            {
                CreateParameter("@membid", SqlDbType.VarChar, id),
                 CreateParameter("@down", SqlDbType.VarChar, down)
            };
            return CreateCommand("chkmemdown", parameters);
        }
        internal static SqlCommand TreeView(string id)
        {
            var parameters = new[]
            {
                CreateParameter("@membid", SqlDbType.VarChar, id)
            };
            return CreateCommand("GetTreeView", parameters);
        }

        internal static SqlCommand GetTreeTooltip(string membid)
        {

            var parameters = new[]
            {
                CreateParameter("@membid", SqlDbType.VarChar, membid)
            };
            return CreateCommand("GetTreeTooltip_Sp", parameters);
        }
        internal static SqlCommand GetMemberDetails(string Idno, String strType)
        {

            var parameters = new[]
            {
                CreateParameter("@Idno", SqlDbType.VarChar, Idno),
                 CreateParameter("@Type", SqlDbType.VarChar, strType)
            };
            return CreateCommand("GetMemberDetails", parameters);
        }
        internal static SqlCommand insertsmslog(Int64 regid, string mobile, DateTime senddate, string message, string action, string sessid, string SMSType)
        {
            var parameters = new[]
           {                                                                                                                                                                       
                    CreateParameter("@regid", SqlDbType.VarChar, regid),
                    CreateParameter("@mobile", SqlDbType.VarChar, mobile),
                    CreateParameter("@senddate", SqlDbType.DateTime, senddate),
                    CreateParameter("@msg", SqlDbType.VarChar, message),
                    CreateParameter("@action", SqlDbType.VarChar, action),
                    CreateParameter("@sessid", SqlDbType.VarChar, sessid),
                    CreateParameter("@SMSType", SqlDbType.VarChar, SMSType)
            };
            return CreateCommand("insertsmslog_Sp", parameters);
        }
        internal static SqlCommand Newslog(String Action, int Nlid, int Nid, int Regid, int Nread, DateTime CreatedDate, String sesid, int status)
        {
            var parameters = new[]
           {         
                                                                                                                                                 
                    CreateParameter("@Action", SqlDbType.VarChar, Action),
                    CreateParameter("@Nlid", SqlDbType.Int, Nlid),
                    CreateParameter("@Nid", SqlDbType.Int, Nid),
                    CreateParameter("@Regid", SqlDbType.Int, Regid),
                    CreateParameter("@Nread", SqlDbType.Int, Nread),
                    CreateParameter("@CreatedDate", SqlDbType.DateTime, CreatedDate),
                    CreateParameter("@sesid", SqlDbType.VarChar, sesid),
                    CreateParameter("@status", SqlDbType.Int, status)
            };
            return CreateCommand("Newslog_sp", parameters);
        }
        internal static SqlCommand GetBulkMailCount(int MRead, string MStatus)
        {
            var parameters = new[]
            {
                CreateParameter("@MRead", SqlDbType.Int, MRead),                
                CreateParameter("@MStatus", SqlDbType.VarChar, MStatus)                
            };
            return CreateCommand("GetBulkMailCount", parameters);
        }
        public static SqlCommand UnilevelTreeDet(string id)
        {
            var parameters = new[]
            {
                CreateParameter("@idno", SqlDbType.Int, id)                
            };
            return CreateCommand("UnilevelTreeDet_Sp", parameters);
        }
        internal static SqlCommand Unilvltrees(string idno, int first, int end)
        {
            var parameters = new[]
               {    
                    CreateParameter("@idno", SqlDbType.VarChar, idno),
                    CreateParameter("@first", SqlDbType.Int, first),
                    CreateParameter("@end", SqlDbType.Int, end)
                };
            return CreateCommand("sp_unitreeview", parameters);
        }
        internal static SqlCommand ApproveCustomerOrder(string action, Int32 slno, Int32 apprej, string sesid, string remarks, Int32 apprejby)
        {
            var parameters = new[]
                {             
                    CreateParameter("@action", SqlDbType.VarChar, action) ,
                    CreateParameter("@sno", SqlDbType.BigInt, slno) ,
                    CreateParameter("@apprej", SqlDbType.BigInt, apprej) ,
                    CreateParameter("@sesid", SqlDbType.VarChar, sesid) ,
                    CreateParameter("@remarks", SqlDbType.VarChar, remarks) ,
                    CreateParameter("@apprejby", SqlDbType.BigInt, apprejby) 
                    
                };
            return CreateCommand("ApproveCustomerOrder_SP", parameters);
        }

        internal static SqlCommand RegistrationReport1onlinesucc(string searchid, DateTime frmdate, DateTime todate, Int32 pageIndex, Int32 pageSize, string pgtype)
        {
            var parameters = new[]
            {                
                CreateParameter("@searchid", SqlDbType.VarChar, searchid) ,
                CreateParameter("@frmdate", SqlDbType.DateTime, frmdate) ,
                CreateParameter("@todate", SqlDbType.DateTime, todate) ,  
                CreateParameter("@pageIndex", SqlDbType.BigInt, pageIndex) ,
                CreateParameter("@pageSize", SqlDbType.BigInt, pageSize),
                CreateParameter("@pgtype", SqlDbType.VarChar, pgtype)
            };
            return CreateCommand("OnlinepaymentSuccess_Sp", parameters);
        }

        internal static SqlCommand RegistrationReport1onlinefail(DateTime frmdate, DateTime todate, Int32 pageIndex, Int32 pageSize)
        {
            var parameters = new[]
            {    
                CreateParameter("@frmdate", SqlDbType.DateTime, frmdate) ,
                CreateParameter("@todate", SqlDbType.DateTime, todate) ,  
                CreateParameter("@pageIndex", SqlDbType.BigInt, pageIndex) ,
                CreateParameter("@pageSize", SqlDbType.BigInt, pageSize) 
            };
            return CreateCommand("OnlinepaymentFailed_Sp", parameters);
        }
        internal static SqlCommand Boostertrees(string action, string idno, int first, int end)
        {
            var parameters = new[]
               {
                    CreateParameter("@action", SqlDbType.VarChar, action),
                    CreateParameter("@idno", SqlDbType.VarChar, idno),
                    CreateParameter("@first", SqlDbType.Int, first),
                    CreateParameter("@end", SqlDbType.Int, end)
                };
            return CreateCommand("sp_Boostertrees", parameters);
        }
        public static SqlCommand BoosterTreeIdDet(string action, string id)
        {
            var parameters = new[]
            {
                CreateParameter("@action", SqlDbType.VarChar, action),
                CreateParameter("@uid", SqlDbType.Int, id)                
            };
            return CreateCommand("BoosterTreeIdDet_Sp", parameters);
        }
        internal static SqlCommand GetApprovePoDetailes(Int32 payno)
        {
            var parameters = new[]
                {
                    CreateParameter("@payno", SqlDbType.Int, payno)
                };
            return CreateCommand("GetApprovePODetailes_SP", parameters);
        }
        internal static SqlCommand PayoutApprove(Int32 payno, Int32 uid, string sessid)
        {
            var parameters = new[]
                {
                    CreateParameter("@payno", SqlDbType.Int, payno),
                    CreateParameter("@uid", SqlDbType.Int, uid),
                    CreateParameter("@Sessid", SqlDbType.VarChar, sessid),
                };
            return CreateCommand("PayoutApprove_SP", parameters);
        }
        internal static SqlCommand SICPPayoutApprove(string action, Int32 payno, Int32 uid, string sessid)
        {
            var parameters = new[]
                {
                    CreateParameter("@action", SqlDbType.VarChar, action),
                    CreateParameter("@payno", SqlDbType.Int, payno),
                    CreateParameter("@uid", SqlDbType.Int, uid),
                    CreateParameter("@Sessid", SqlDbType.VarChar, sessid)
                };
            return CreateCommand("SICPPayoutApprove_SP", parameters);
        }
        internal static SqlCommand BainaryTrackReport(Int32 regid)
        {
            var parameters = new[]
            {
                CreateParameter("@regid", SqlDbType.Int, regid)              
            };
            return CreateCommand("BinaryTrackReport", parameters);
        }
        internal static SqlCommand Steps(string OrbitNo, int OrbitStage, int PayNo)
        {
            var parameters = new[]
            {
                CreateParameter("@Orbit", SqlDbType.VarChar, OrbitNo),
                CreateParameter("@Steps", SqlDbType.Int, OrbitStage ),
                CreateParameter("@PayNo", SqlDbType.Int, PayNo )
            };
            return CreateCommand("getsteps", parameters);
        }
        internal static SqlCommand GetBinaryAnalysis(Int32 pageIndex, Int32 pageSize)
        {
            var parameters = new[]
                {
                    CreateParameter("@pageIndex", SqlDbType.Int, pageIndex),
                    CreateParameter("@pageSize", SqlDbType.Int, pageSize)
                };
            return CreateCommand("GetBinaryAnalysis_Sp", parameters);
        }

        internal static SqlCommand SCReport1onlinesucc(string searchid, DateTime frmdate, DateTime todate, Int32 pageIndex, Int32 pageSize, string pgtype)
        {
            var parameters = new[]
            {                
                CreateParameter("@searchid", SqlDbType.VarChar, searchid) ,
                CreateParameter("@frmdate", SqlDbType.DateTime, frmdate) ,
                CreateParameter("@todate", SqlDbType.DateTime, todate) ,  
                CreateParameter("@pageIndex", SqlDbType.BigInt, pageIndex) ,
                CreateParameter("@pageSize", SqlDbType.BigInt, pageSize),
                CreateParameter("@pgtype", SqlDbType.VarChar, pgtype)
            };
            return CreateCommand("SCOnlinepaymentSuccess_Sp", parameters);
        }

        internal static SqlCommand SCReport1onlinefail(DateTime frmdate, DateTime todate, Int32 pageIndex, Int32 pageSize)
        {
            var parameters = new[]
            {    
                CreateParameter("@frmdate", SqlDbType.DateTime, frmdate) ,
                CreateParameter("@todate", SqlDbType.DateTime, todate) ,  
                CreateParameter("@pageIndex", SqlDbType.BigInt, pageIndex) ,
                CreateParameter("@pageSize", SqlDbType.BigInt, pageSize) 
            };
            return CreateCommand("SCOnlinepaymentFailed_Sp", parameters);
        }

        internal static SqlCommand CreditRequestReport1onlinesucc(string searchid, DateTime frmdate, DateTime todate, Int32 pageIndex, Int32 pageSize, string pgtype)
        {
            var parameters = new[]
            {                
                CreateParameter("@searchid", SqlDbType.VarChar, searchid) ,
                CreateParameter("@frmdate", SqlDbType.DateTime, frmdate) ,
                CreateParameter("@todate", SqlDbType.DateTime, todate) ,  
                CreateParameter("@pageIndex", SqlDbType.BigInt, pageIndex) ,
                CreateParameter("@pageSize", SqlDbType.BigInt, pageSize),
                CreateParameter("@pgtype", SqlDbType.VarChar, pgtype)
            };
            return CreateCommand("CreditRequestOnlinepaymentSuccess_Sp", parameters);
        }

        internal static SqlCommand CreditRequestReport1onlinefail(DateTime frmdate, DateTime todate, Int32 pageIndex, Int32 pageSize)
        {
            var parameters = new[]
            {    
                CreateParameter("@frmdate", SqlDbType.DateTime, frmdate) ,
                CreateParameter("@todate", SqlDbType.DateTime, todate) ,  
                CreateParameter("@pageIndex", SqlDbType.BigInt, pageIndex) ,
                CreateParameter("@pageSize", SqlDbType.BigInt, pageSize) 
            };
            return CreateCommand("CreditRequestOnlinepaymentFailed_Sp", parameters);
        }

        internal static SqlCommand SSMPPayoutProcess(string action, Int32 Uid, string Sessid, string Remarks,Int32 payno)
        {
            var parameters = new[]
            {    
                CreateParameter("@Action", SqlDbType.VarChar, action) ,
                CreateParameter("@Uid", SqlDbType.BigInt, Uid) ,  
                CreateParameter("@Sessid", SqlDbType.VarChar, Sessid) ,
                CreateParameter("@Remarks", SqlDbType.VarChar, Remarks),
                CreateParameter("@StartPayno", SqlDbType.Int, payno)
            };
            return CreateCommand("Stp_SSMP_PayoutProcess", parameters);
        }

        internal static SqlCommand SICPPayoutProcess(string action, Int32 Uid, string Sessid, string Remarks)
        {
            var parameters = new[]
            {    
                CreateParameter("@Action", SqlDbType.VarChar, action) ,
                CreateParameter("@Uid", SqlDbType.BigInt, Uid) ,  
                CreateParameter("@Sessid", SqlDbType.VarChar, Sessid) ,
                CreateParameter("@Remarks", SqlDbType.VarChar, Remarks) 
            };
            return CreateCommand("Stp_SICP_PayoutProcess", parameters);
        }

        internal static SqlCommand SSMPRewards(Int32 regid)
        {
            var parameters = new[]
            {    
                CreateParameter("@regid", SqlDbType.BigInt, regid) 
            };
            return CreateCommand("Stp_SSMP_RewardID_details", parameters);
        }

        internal static SqlCommand ApprovePaymentrpt(string action, string Ordertype, string Paymenttype, String SBOID, DateTime fromdate, DateTime todate, Int32 pageIndex, Int32 pageSize)
        {
            var parameters = new[]
            {       
                CreateParameter("@action", SqlDbType.VarChar, action),
                CreateParameter("@Ordertype", SqlDbType.VarChar, Ordertype),
                CreateParameter("@Paymenttype", SqlDbType.VarChar, Paymenttype),
                CreateParameter("@SBOID", SqlDbType.VarChar, SBOID),
                CreateParameter("@fromdate", SqlDbType.DateTime, fromdate), 
                CreateParameter("@todate", SqlDbType.DateTime, todate),                                                                                         
                CreateParameter("@pageIndex", SqlDbType.BigInt, pageIndex),
                CreateParameter("@pageSize", SqlDbType.BigInt, pageSize)
            };
            return CreateCommand("ApprovePayment_SP", parameters);
        }

        internal static SqlCommand PendingGatewayOrdersRpt(string action, DateTime fromdate, DateTime todate, Int32 pageIndex, Int32 pageSize)
        {
            var parameters = new[]
            {    
                CreateParameter("@action", SqlDbType.VarChar, action),
                CreateParameter("@frmdate", SqlDbType.DateTime, fromdate), 
                CreateParameter("@todate", SqlDbType.DateTime, todate),                                                                                         
                CreateParameter("@pageIndex", SqlDbType.BigInt, pageIndex),
                CreateParameter("@pageSize", SqlDbType.BigInt, pageSize)
            };
            return CreateCommand("PendingGatewayOrdersRpt_Sp", parameters);
        }

        internal static SqlCommand TDSRpt(string action, Int32 payno, String regid, string type, string mnths, string yrs, Int32 PageIndex, Int32 PageSize)
        {
            var parameters = new[]
            {    
                CreateParameter("@action", SqlDbType.VarChar, action),
                CreateParameter("@payno", SqlDbType.Int, payno ),
                CreateParameter("@regid", SqlDbType.VarChar, regid),
                CreateParameter("@type", SqlDbType.VarChar, type),
                CreateParameter("@mnths", SqlDbType.VarChar, mnths ),
                CreateParameter("@yrs", SqlDbType.VarChar, yrs ),
                CreateParameter("@PageIndex", SqlDbType.Int, PageIndex ),
                CreateParameter("@PageSize", SqlDbType.Int, PageSize ) 
            };
            return CreateCommand("GetTDSRpt_sp", parameters);
        }
        internal static SqlCommand BusinessStatsRpt(string action, string state, string district, string SBOID, string Packcode, string Pcode, string Sts, string Plantype, DateTime fromdate, DateTime todate, Int32 pageIndex, Int32 pageSize)
        {
            var parameters = new[]
            {       
                CreateParameter("@action", SqlDbType.VarChar, action),
                CreateParameter("@state", SqlDbType.VarChar, state),
                CreateParameter("@district", SqlDbType.VarChar, district),
                CreateParameter("@SBOID", SqlDbType.VarChar, SBOID),
                CreateParameter("@Packcode", SqlDbType.VarChar, Packcode),
                CreateParameter("@Pcode", SqlDbType.VarChar, Pcode),
                CreateParameter("@Sts", SqlDbType.VarChar, Sts),
                CreateParameter("@Plantype", SqlDbType.VarChar, Plantype),
                CreateParameter("@fromdate", SqlDbType.DateTime, fromdate), 
                CreateParameter("@todate", SqlDbType.DateTime, todate),                                                                                         
                CreateParameter("@pageIndex", SqlDbType.BigInt, pageIndex),
                CreateParameter("@pageSize", SqlDbType.BigInt, pageSize)
            };
            return CreateCommand("BusinessStatsRpt_SP", parameters);
        }
        internal static SqlCommand GetReport(string action, string Type, Int32 payno, string regid, DateTime frmdate, DateTime todate, Int32 pageindex, Int32 pagesize)
        {
            var parameters = new[]
            {       
                CreateParameter("@action", SqlDbType.VarChar, action),
                    CreateParameter("@Type", SqlDbType.VarChar, Type),                    
                    CreateParameter("@payno", SqlDbType.Int, payno),
                    CreateParameter("@regid", SqlDbType.VarChar, regid),
                    CreateParameter("@frmdate", SqlDbType.DateTime, frmdate),
                    CreateParameter("@todate", SqlDbType.DateTime, todate),                    
                    CreateParameter("@pageindex", SqlDbType.Int, pageindex),                                       
                    CreateParameter("@pagesize", SqlDbType.Int, pagesize) 
            };
            return CreateCommand("GetReport_Sp", parameters);
        }
        internal static SqlCommand GetRegFields(string action, string fname1, string lname1, string dob1, string careof1, string mobile1, string eMail1)
        {
            var parameters = new[]
            {       
                CreateParameter("@action", SqlDbType.VarChar, action),
                CreateParameter("@fname1", SqlDbType.VarChar, fname1),                    
                CreateParameter("@lname1", SqlDbType.VarChar, lname1),
                CreateParameter("@dob1", SqlDbType.VarChar, dob1),
                CreateParameter("@careof1", SqlDbType.VarChar, careof1),
                CreateParameter("@mobile1", SqlDbType.VarChar, mobile1),                    
                CreateParameter("@eMai1l", SqlDbType.VarChar, eMail1)
            };
            return CreateCommand("GetRegFields_Sp", parameters);
        }
        internal static SqlCommand UpdateDuplicateIdsRpt(int regid, string remarks, int uid, string sesid, string ipaddress)
        {
            var parameters = new[]
            {                
                CreateParameter("@regid", SqlDbType.Int, regid),  
                CreateParameter("@Remarks", SqlDbType.VarChar, remarks),  
                CreateParameter("@uid", SqlDbType.Int, uid),  
                CreateParameter("@sesid", SqlDbType.VarChar, sesid), 
                CreateParameter("@ipaddress", SqlDbType.VarChar, ipaddress)
            };
            return CreateCommand("UpdateDuplicateIdsRpt_SP", parameters);
        }
        internal static SqlCommand GetMinRegIdDuplicateIdsRpt(string Fname, string Lname, string UserName, DateTime dob, string Mobile, string Email)
        {
            var parameters = new[]
               { 
                   CreateParameter("@Fname", SqlDbType.VarChar, Fname), 
                   CreateParameter("@Lname", SqlDbType.VarChar, Lname), 
                   CreateParameter("@UserName", SqlDbType.VarChar, UserName), 
                   CreateParameter("@dob", SqlDbType.DateTime, dob),     
                   CreateParameter("@Mobile", SqlDbType.VarChar, Mobile), 
                   CreateParameter("@Email", SqlDbType.VarChar, Email) 
                };
            return CreateCommand("GetMinRegIdDuplicateIdsRpt_SP", parameters);
        }
        internal static SqlCommand BusinessReport(string action, string type, Int32 pageIndex, Int32 pageSize)
        {
            var parameters = new[]
            {    
                CreateParameter("@action", SqlDbType.VarChar, action),    
                CreateParameter("@type", SqlDbType.VarChar, type),      
                CreateParameter("@pageIndex", SqlDbType.Int, pageIndex),
                CreateParameter("@pageSize", SqlDbType.Int, pageSize)
            };
            return CreateCommand("BusinessReport_Sp", parameters);
        }
        internal static SqlCommand DateWiseBusinessReport(string action, string type,DateTime date, Int32 pageIndex, Int32 pageSize)
        {
            var parameters = new[]
            {    
                CreateParameter("@action", SqlDbType.VarChar, action),    
                CreateParameter("@type", SqlDbType.VarChar, type), 
                 CreateParameter("@date", SqlDbType.DateTime, date),      
                CreateParameter("@pageIndex", SqlDbType.Int, pageIndex),
                CreateParameter("@pageSize", SqlDbType.Int, pageSize)
            };
            return CreateCommand("DateWiseBusinessReport_Sp", parameters);
        }

        internal static SqlCommand NewsSubcription_Log(string action, Int32 NSLId, string Subject, string Body, string UploadFile, Int32 Status, Int32 uid, string sesid, Int32 pageindex, Int32 pagesize)
        {
            var parameters = new[]
                {
                    CreateParameter("@action", SqlDbType.VarChar, action),   
                    CreateParameter("@NSLId", SqlDbType.Int, NSLId), 
                    CreateParameter("@Subject", SqlDbType.VarChar, Subject),
                    CreateParameter("@Body", SqlDbType.VarChar, Body),
                    CreateParameter("@UploadFile", SqlDbType.VarChar, UploadFile),       
                    CreateParameter("@Status", SqlDbType.Int, Status), 
                    CreateParameter("@uid", SqlDbType.Int, uid),                                     
                    CreateParameter("@sesid", SqlDbType.VarChar, sesid),

                    CreateParameter("@pageIndex", SqlDbType.Int, pageindex),   
                    CreateParameter("@pageSize", SqlDbType.Int, pagesize)  
                };
            return CreateCommand("NewsSubcription_Log_SP", parameters);
        }


        internal static SqlCommand DespNewsLetter(string action, string EmailId, string Subject, string Body, string UploadFile, string sesid, string IPaddress)
        {
            var parameters = new[]
                {
                    CreateParameter("@Action", SqlDbType.VarChar, action),   
                    CreateParameter("@EmailId", SqlDbType.VarChar, EmailId),
                    CreateParameter("@Subject", SqlDbType.VarChar, Subject),
                    CreateParameter("@Body", SqlDbType.VarChar, Body),                   
                    CreateParameter("@UploadFile", SqlDbType.VarChar, UploadFile),
                    CreateParameter("@sesid", SqlDbType.VarChar, sesid),   
                    CreateParameter("@IPaddress", SqlDbType.VarChar, IPaddress) 
                };
            return CreateCommand("DespNewsLetter_SP", parameters);
        }

        internal static SqlCommand CheckDownto(string action,string idno, string downto)
        {
            var parameters = new[]
            {   CreateParameter("@action", SqlDbType.VarChar, action),                     
                CreateParameter("@idno", SqlDbType.VarChar, idno),      
                CreateParameter("@downto", SqlDbType.VarChar, downto)                
            };
            return CreateCommand("CheckDownto_SP", parameters);
        }

        internal static SqlCommand UpdateUnSuccessfulPGTranRpt(string CCRemarks, string ORDER_ID, int UpdatedBy)
        {
            var parameters = new[]
            {                
                CreateParameter("@CCRemarks", SqlDbType.VarChar, CCRemarks),  
                CreateParameter("@ORDER_ID", SqlDbType.VarChar, ORDER_ID), 
                CreateParameter("@UpdatedBy", SqlDbType.Int, UpdatedBy)
            };
            return CreateCommand("UpdateUnSuccessfulPGTranRpt_SP", parameters);
        }

        internal static SqlCommand GetRewardsReport(string action, string Type, Int32 payno, string regid, DateTime frmdate, DateTime todate, Int32 pageindex, Int32 pagesize)
        {
            var parameters = new[]
            {       
                CreateParameter("@action", SqlDbType.VarChar, action),
                    CreateParameter("@Type", SqlDbType.VarChar, Type),                    
                    CreateParameter("@payno", SqlDbType.Int, payno),
                    CreateParameter("@regid", SqlDbType.VarChar, regid),
                    CreateParameter("@frmdate", SqlDbType.DateTime, frmdate),
                    CreateParameter("@todate", SqlDbType.DateTime, todate),                    
                    CreateParameter("@pageindex", SqlDbType.Int, pageindex),                                       
                    CreateParameter("@pagesize", SqlDbType.Int, pagesize) 
            };
            return CreateCommand("GetRewardsReport_Sp", parameters);
        }

        internal static SqlCommand MobileAppsmslog(Int64 regid, string mobile, DateTime senddate, string message, string action, string sessid, string SMSType)
        {
            var parameters = new[]
           {                                                                                                                                                                       
                    CreateParameter("@regid", SqlDbType.VarChar, regid),
                    CreateParameter("@mobile", SqlDbType.VarChar, mobile),
                    CreateParameter("@senddate", SqlDbType.DateTime, senddate),
                    CreateParameter("@msg", SqlDbType.VarChar, message),
                    CreateParameter("@action", SqlDbType.VarChar, action),
                    CreateParameter("@sessid", SqlDbType.VarChar, sessid),
                    CreateParameter("@SMSType", SqlDbType.VarChar, SMSType)
            };
            return CreateCommand("MobileAppsmslog_Sp", parameters);
        }
        internal static SqlCommand OfferCreate(string action, string type, string pcode, string Itemid, string offName, Int32 noofcupons, DateTime frmdate, DateTime todate, string sessid, string ipaddress, Int32 createdby, string Remarks, int Status,
           Int32 NoofCoupCnts, Int32 txtcuponval1, Int32 MinValue1, Int32 MaxValue1, Int32 txtcuponval2, Int32 MinValue2, Int32 MaxValue2, Int32 txtcuponval3, Int32 MinValue3, Int32 MaxValue3,
            Int32 txtcuponval4, Int32 MinValue4, Int32 MaxValue4, Int32 txtcuponval5, Int32 MinValue5, Int32 MaxValue5)
        {
            var parameters = new[]
           {                                                                                                                                                                       
                    CreateParameter("@action", SqlDbType.VarChar, action),
                    CreateParameter("@pcode", SqlDbType.VarChar, pcode),
                    CreateParameter("@type", SqlDbType.VarChar, type),
                    CreateParameter("@Itemid", SqlDbType.VarChar, Itemid),
                    CreateParameter("@offName", SqlDbType.VarChar, offName),
                    CreateParameter("@noofcupons", SqlDbType.Int, noofcupons),                    
                    CreateParameter("@frmdate", SqlDbType.DateTime, frmdate),
                    CreateParameter("@todate", SqlDbType.DateTime, todate),
                    CreateParameter("@sessid", SqlDbType.VarChar, sessid),
                    CreateParameter("@ipaddress", SqlDbType.VarChar, ipaddress),
                    CreateParameter("@createdby", SqlDbType.Int, createdby),
                    CreateParameter("@Remarks", SqlDbType.VarChar, Remarks),
                    CreateParameter("@Status", SqlDbType.Int, Status),
                    CreateParameter("@NoofCoupVal", SqlDbType.Int, NoofCoupCnts),
                    CreateParameter("@txtcuponval1", SqlDbType.Int, txtcuponval1),
                    CreateParameter("@MinValue1", SqlDbType.Int, MinValue1),
                    CreateParameter("@MaxValue1", SqlDbType.Int, MaxValue1),
                    CreateParameter("@txtcuponval2", SqlDbType.Int, txtcuponval2),
                    CreateParameter("@MinValue2", SqlDbType.Int, MinValue2),
                    CreateParameter("@MaxValue2", SqlDbType.Int, MaxValue2),
                    CreateParameter("@txtcuponval3", SqlDbType.Int, txtcuponval3),
                    CreateParameter("@MinValue3", SqlDbType.Int, MinValue3),
                    CreateParameter("@MaxValue3", SqlDbType.Int, MaxValue3),
                    CreateParameter("@txtcuponval4", SqlDbType.Int, txtcuponval4),
                    CreateParameter("@MinValue4", SqlDbType.Int, MinValue4),
                    CreateParameter("@MaxValue4", SqlDbType.Int, MaxValue4),
                    CreateParameter("@txtcuponval5", SqlDbType.Int, txtcuponval5),
                    CreateParameter("@MinValue5", SqlDbType.Int, MinValue5),
                    CreateParameter("@MaxValue5", SqlDbType.Int, MaxValue5)
            };
            return CreateCommand("OfferCreate_Sp", parameters);
        }
        internal static SqlCommand OfferReport(string Action, string Offname, DateTime frmdate, DateTime todate, Int32 pageIndex, Int32 pageSize, string Type)
        {
            var parameters = new[]
            {       
                CreateParameter("@action", SqlDbType.VarChar, Action),
                    CreateParameter("@Offname", SqlDbType.VarChar, Offname),
                    CreateParameter("@frmdate", SqlDbType.DateTime, frmdate),
                    CreateParameter("@todate", SqlDbType.DateTime, todate),                    
                    CreateParameter("@pageIndex", SqlDbType.Int, pageIndex),                                       
                    CreateParameter("@pageSize", SqlDbType.Int, pageSize),
                     CreateParameter("@Type", SqlDbType.VarChar, Type) 
            };
            return CreateCommand("OfferReport_Sp", parameters);
        }
        internal static SqlCommand MobileSlides(string Action, string CreatedBy, string SessId, string IpAdd, string ImgName, Int32 OrderNo)
        {
            var parameters = new[]
            {       
                CreateParameter("@action", SqlDbType.VarChar, Action),
                    CreateParameter("@CreatedBy", SqlDbType.VarChar, CreatedBy),
                    CreateParameter("@SessId", SqlDbType.VarChar, SessId),
                    CreateParameter("@IpAdd", SqlDbType.VarChar, IpAdd),                    
                    CreateParameter("@ImgName", SqlDbType.VarChar, ImgName),                                       
                    CreateParameter("@OrderNo", SqlDbType.Int, OrderNo)                  
            };
            return CreateCommand("MobileSlides_Sp", parameters);
        }
        internal static SqlCommand ClickAndShare(string Action, Int32 id, string CreatedBy, string Description, string Status, string ImgName, string SessId, string IpAdd)
        {
            var parameters = new[]
            {       
                    CreateParameter("@action", SqlDbType.VarChar, Action),
                    CreateParameter("@id", SqlDbType.Int, id),
                    CreateParameter("@user", SqlDbType.VarChar, CreatedBy),
                    CreateParameter("@Description", SqlDbType.VarChar, Description),                    
                    CreateParameter("@Status", SqlDbType.VarChar, Status),                                       
                    CreateParameter("@img", SqlDbType.VarChar, ImgName) ,
                    CreateParameter("@SessId", SqlDbType.VarChar, SessId),
                    CreateParameter("@IpAdd", SqlDbType.VarChar, IpAdd)
            };
            return CreateCommand("ClickAndShare_Sp", parameters);
        }
        internal static SqlCommand CreateWalletOffer(string action, string OfferCode, string pcode, string offName, string OffType, Double WalletValue, Int32 Pid, DateTime frmdate, DateTime todate, string sessid, string ipaddress, Int32 createdby, string Remarks, int Status)
        {
            var parameters = new[]
           {                                                                                                                                                                       
                    CreateParameter("@action", SqlDbType.VarChar, action),
                    CreateParameter("@OfferCode", SqlDbType.VarChar, OfferCode),
                    CreateParameter("@pcode", SqlDbType.VarChar, pcode),
                    CreateParameter("@offName", SqlDbType.VarChar, offName),
                    CreateParameter("@OffType", SqlDbType.VarChar, OffType),
                    CreateParameter("@WalletValue", SqlDbType.Money, WalletValue),
                    CreateParameter("@Pid", SqlDbType.Int, Pid),
                    CreateParameter("@frmdate", SqlDbType.DateTime, frmdate),
                    CreateParameter("@todate", SqlDbType.DateTime, todate),
                    CreateParameter("@sessid", SqlDbType.VarChar, sessid),
                    CreateParameter("@ipaddress", SqlDbType.VarChar, ipaddress),
                    CreateParameter("@createdby", SqlDbType.Int, createdby),
                    CreateParameter("@Remarks", SqlDbType.VarChar, Remarks),
                    CreateParameter("@Status", SqlDbType.Int, Status)
            };
            return CreateCommand("CreateWalletOffer_Sp", parameters);
        }
        internal static SqlCommand DayStatisticsRpt(string action, string Type, string regid)
        {
            var parameters = new[]
            {       
                CreateParameter("@action", SqlDbType.VarChar, action),
                CreateParameter("@Type", SqlDbType.VarChar, Type), 
                CreateParameter("@regid", SqlDbType.VarChar, regid)                   
            };
            return CreateCommand("DayStatisticsRpt_Sp", parameters);
        }
        internal static SqlCommand Stockreturn(string Action, string billno, string Refno, Int32 type, DateTime frmdate, DateTime todate, Int32 pageIndex, Int32 pageSize, string ssid, string remarks)
        {
            var parameters = new[]
           {                                                                                                                                                                       
                    CreateParameter("@action", SqlDbType.VarChar, Action),
                    CreateParameter("@billno", SqlDbType.VarChar, billno),
                    CreateParameter("@RefNo", SqlDbType.VarChar, Refno),
                    CreateParameter("@type", SqlDbType.Int, type),                  
                    CreateParameter("@frmdate", SqlDbType.DateTime, frmdate),
                    CreateParameter("@todate", SqlDbType.DateTime, todate),
                    CreateParameter("@pageIndex", SqlDbType.Int, pageIndex),                                       
                    CreateParameter("@pageSize", SqlDbType.Int, pageSize),
                    CreateParameter("@ssid", SqlDbType.VarChar, ssid),          
                    CreateParameter("@remarks", SqlDbType.VarChar, remarks)
                    
            };
            return CreateCommand("ReqStockreturn_sp", parameters);
        }
        internal static SqlCommand GVDInstalPayment(string Action, string UnqId, string billno, Int32 Regid, Int32 pid, string MOP, double PayAmt, string ssid, string remarks)
        {
            var parameters = new[]
           {                                                                                                                                                                       
                    CreateParameter("@action", SqlDbType.VarChar, Action),
                    CreateParameter("@UnqId", SqlDbType.VarChar, UnqId),
                    CreateParameter("@billno", SqlDbType.VarChar, billno),                    
                    CreateParameter("@Regid", SqlDbType.Int, Regid), 
                    CreateParameter("@pid", SqlDbType.Int, pid),                                       
                    CreateParameter("@MOP", SqlDbType.VarChar, MOP),
                    CreateParameter("@PayAmt", SqlDbType.Money, PayAmt),    
                    CreateParameter("@ssid", SqlDbType.VarChar, ssid),      
                    CreateParameter("@remarks", SqlDbType.VarChar, remarks)
                    
            };
            return CreateCommand("GVDInstalPayment_sp", parameters);
        }

        internal static SqlCommand GVDFullPayment(string Action, string UnqId, string billno, Int32 Regid, Int32 pid, string MOP, double PayAmt, string ssid, string remarks, string DDno, string ddbank, string ddbranch, DateTime dddate, string mobile, string add1, string city, string district, string states, string pin)
        {
            var parameters = new[]
           {                                                                                                                                                                       
                    CreateParameter("@action", SqlDbType.VarChar, Action),
                    CreateParameter("@UnqId", SqlDbType.VarChar, UnqId),
                    CreateParameter("@billno", SqlDbType.VarChar, billno),                    
                    CreateParameter("@Regid", SqlDbType.Int, Regid), 
                    CreateParameter("@pid", SqlDbType.Int, pid),                                       
                    CreateParameter("@MOP", SqlDbType.VarChar, MOP),
                    CreateParameter("@PayAmt", SqlDbType.Money, PayAmt),    
                    CreateParameter("@ssid", SqlDbType.VarChar, ssid),      
                    CreateParameter("@remarks", SqlDbType.VarChar, remarks),
                    CreateParameter("@ddno", SqlDbType.VarChar, DDno),
                    CreateParameter("@ddbank", SqlDbType.VarChar, ddbank),    
                    CreateParameter("@ddbranch", SqlDbType.VarChar, ddbranch),      
                    CreateParameter("@dddate", SqlDbType.DateTime, dddate),
                    CreateParameter("@Gmobile", SqlDbType.VarChar, mobile),
                    CreateParameter("@Gadd1", SqlDbType.VarChar, add1),
                    CreateParameter("@Gcity", SqlDbType.VarChar, city),
                    CreateParameter("@Gdistrict", SqlDbType.VarChar, district),
                    CreateParameter("@GMstate", SqlDbType.VarChar, states),
                    CreateParameter("@Gpin", SqlDbType.VarChar, pin)                   
                                       
            };
            return CreateCommand("GVDFullPayment_sp", parameters);
        }

        internal static SqlCommand GetMemMails(string Action, string Reqno, Int32 Regid, Int32 id, string Type)
        {
            var parameters = new[]
           {                                                                                                                                                                       
                    CreateParameter("@action", SqlDbType.VarChar, Action),
                    CreateParameter("@Reqno", SqlDbType.VarChar, Reqno),                               
                    CreateParameter("@Regid", SqlDbType.Int, Regid), 
                    CreateParameter("@id", SqlDbType.Int, id),                                       
                    CreateParameter("@Type", SqlDbType.VarChar, Type)                    
            };
            return CreateCommand("GetMemMails_sp", parameters);
        }


        #region Franchisee

        internal static SqlCommand InsertFranchise(string FCCode, string FranchiseName, string Address1, string Address2, string city, string state, string Email, string Status, string CreatedBy, DateTime CreatedDate, string Phone, string stkLimit, string JoinAmt, string CompanyName, string UserName, string Password, string Bank, string AccNo, string IFSC, string BankAddress, string type, string tinno, string GST)
        {
            var parameters = new[]
           {                                                                                                                                                                       
                    CreateParameter("@Fcode", SqlDbType.VarChar, FCCode),
                    CreateParameter("@fname", SqlDbType.VarChar, FranchiseName),                               
                    CreateParameter("@Address1", SqlDbType.VarChar, Address1), 
                    CreateParameter("@Address2", SqlDbType.VarChar, Address2),                                       
                    CreateParameter("@City", SqlDbType.VarChar, city) ,
                    CreateParameter("@State", SqlDbType.VarChar, state),
                    CreateParameter("@Email", SqlDbType.VarChar, Email),                               
                    CreateParameter("@Status", SqlDbType.VarChar, Status), 
                    CreateParameter("@CreatedBy", SqlDbType.VarChar, CreatedBy),                                       
                    CreateParameter("@CreationDate", SqlDbType.DateTime, CreatedDate) , 
                    CreateParameter("@PhoneNo", SqlDbType.VarChar, Phone),
                    CreateParameter("@StkLimit", SqlDbType.VarChar, stkLimit),                               
                    CreateParameter("@JoinAmt", SqlDbType.VarChar, JoinAmt), 
                    CreateParameter("@UserName", SqlDbType.VarChar, UserName),                                       
                    CreateParameter("@Password", SqlDbType.VarChar, Password) ,
                    CreateParameter("@Bank", SqlDbType.VarChar, Bank),
                    CreateParameter("@AccountNo", SqlDbType.VarChar, AccNo),                               
                    CreateParameter("@IFCS", SqlDbType.VarChar, IFSC), 
                    CreateParameter("@BankAddress", SqlDbType.VarChar, BankAddress),                                       
                    CreateParameter("@type", SqlDbType.VarChar, type) ,  
                    CreateParameter("@tinno", SqlDbType.VarChar, tinno),                                       
                    CreateParameter("@GST", SqlDbType.VarChar, GST)   
            };

            return CreateCommand("InsertFranchise_Sp", parameters);
        }

        internal static SqlCommand GetFCcode(string Action)
        {
            var parameters = new[]
           {                                                                                                                                                                       
                    CreateParameter("@Action", SqlDbType.VarChar, Action)
                                                          
            };
            return CreateCommand("GetFCcode_Sp", parameters);
        }

        internal static SqlCommand ExistFranchiseIdno(string idno)
        {
            var parameters = new[]
           {                                                                                                                                                                       
                    CreateParameter("@Idno", SqlDbType.VarChar, idno)
                                                          
            };
            return CreateCommand("ExistFranchiseIdno_Sp", parameters);
        }

        internal static SqlCommand Editfranchise(string FCCode)
        {
            var parameters = new[]
           {                                                                                                                                                                       
                    CreateParameter("@FCCode", SqlDbType.VarChar, FCCode)                                       
            };
            return CreateCommand("Editfranchise_sp", parameters);
        }

        internal static SqlCommand FCPLogin(string username, string password)
        {
            var parameters = new[]
            {
                CreateParameter("@username", SqlDbType.VarChar, username),
                CreateParameter("@password", SqlDbType.VarChar, password)
            };
            return CreateCommand("FCPLogin_Sp", parameters);
        }

        internal static SqlCommand TempStockOrder_FCP(string action, string UNQId, string pcode, string ItemCode, string Attribute, string Qty, string Item)
        {
            var parameters = new[]
               {                                                           
                   CreateParameter("@action", SqlDbType.VarChar, action), 
                   CreateParameter("@UNQId", SqlDbType.VarChar, UNQId), 
                   CreateParameter("@PCode", SqlDbType.VarChar, pcode),                   
                   CreateParameter("@ItemCode", SqlDbType.VarChar, ItemCode),
                   CreateParameter("@Attribute", SqlDbType.VarChar, Attribute),
                   CreateParameter("@Qty", SqlDbType.Int, Convert.ToInt32(Qty)),
                   CreateParameter("@Item", SqlDbType.VarChar, Item)
                };
            return CreateCommand("TempStockOrder_FCP_SP", parameters);
        }
        internal static SqlCommand StockOrder_FCP(string action, string Id, string remarks, string Sessid, string UID)
        {
            var parameters = new[]
               {                                                           
                   CreateParameter("@action", SqlDbType.VarChar, action), 
                   CreateParameter("@Id", SqlDbType.VarChar, Id), 
                   CreateParameter("@remarks", SqlDbType.VarChar, remarks),                   
                   CreateParameter("@Sessid", SqlDbType.VarChar, Sessid),
                   CreateParameter("@UID", SqlDbType.VarChar, UID)                   
                };
            return CreateCommand("StockOrder_SP", parameters);
        }
        internal static SqlCommand StockOrderReport_FCP(string action, string Id, DateTime frmdate, DateTime todate, Int32 pageIndex, Int32 pageSize)
        {
            var parameters = new[]
               {                                                           
                   CreateParameter("@action", SqlDbType.VarChar, action), 
                   CreateParameter("@Id", SqlDbType.VarChar, Id), 
                   CreateParameter("@frmdate", SqlDbType.DateTime, frmdate),                   
                   CreateParameter("@todate", SqlDbType.DateTime, todate),
                   CreateParameter("@pageIndex", SqlDbType.Int, pageIndex)  ,
                   CreateParameter("@pageSize", SqlDbType.Int, pageSize)
                };
            return CreateCommand("StockOrderReport_SP", parameters);
        }

        internal static SqlCommand ApprovedStockOrder_FCP(string action, string orderrefid, string fcode, string pcode, string qty, string sessionid, string SesUser, string dmode, string modname, string modno, string moddate, string modremarks, string VehicleNo)
        {
            var parameters = new[]
               {                                                           
                   CreateParameter("@action", SqlDbType.VarChar, action), 
                   CreateParameter("@orderrefid", SqlDbType.VarChar, orderrefid), 
                   CreateParameter("@fcode", SqlDbType.VarChar, fcode),                   
                   CreateParameter("@pcode", SqlDbType.VarChar, pcode),
                   CreateParameter("@qty", SqlDbType.Int, Convert.ToInt32( qty))  ,
                   CreateParameter("@sessionid", SqlDbType.VarChar, sessionid),
                   CreateParameter("@SesUser", SqlDbType.VarChar, SesUser),                   
                   CreateParameter("@dmode", SqlDbType.VarChar, dmode),
                   CreateParameter("@modname", SqlDbType.VarChar, modname)  ,
                   CreateParameter("@modno", SqlDbType.VarChar, modno),
                   CreateParameter("@moddate", SqlDbType.VarChar, moddate),                   
                   CreateParameter("@modremarks", SqlDbType.VarChar, modremarks),
                   CreateParameter("@VehicleNo", SqlDbType.VarChar, VehicleNo)  
                };
            return CreateCommand("ApprovedStockOrder_CnF", parameters);
        }
        internal static SqlCommand MakeFCPCreditRequest(string fcode, double reqAmt, string mop, string refno,DateTime date,
                                                     string invbank, string invbranch, string VarcharNo,DateTime cdate,
                                                     string depbank, string depbranch, string depcity, DateTime depdate, string depslip,
                                                     string remarks)
        {
            var parameters = new[]
                {
                    CreateParameter("@fcode", SqlDbType.VarChar, fcode),
                    CreateParameter("@reqamt", SqlDbType.Money, reqAmt),
                    CreateParameter("@MOP", SqlDbType.VarChar, mop),
                    CreateParameter("@no", SqlDbType.VarChar, refno),
                    CreateParameter("@Date", SqlDbType.DateTime, date),
                    CreateParameter("@Bank", SqlDbType.VarChar, invbank),
                    CreateParameter("@Branch", SqlDbType.VarChar, invbranch),
                    CreateParameter("@VarcharNo", SqlDbType.VarChar, VarcharNo),
                    CreateParameter("@CDate", SqlDbType.DateTime, cdate),
                    CreateParameter("@Remarks", SqlDbType.VarChar, remarks),
                    CreateParameter("@DepBank", SqlDbType.VarChar, depbank),
                    CreateParameter("@DepBranch", SqlDbType.VarChar, depbranch),
                    CreateParameter("@DepCity", SqlDbType.VarChar, depcity),
                    CreateParameter("@DepDate", SqlDbType.DateTime, depdate),
                    CreateParameter("@DepSlip", SqlDbType.VarChar, depslip)

                };
            return CreateCommand("fcpCreditReq_Sp", parameters);
        }

        internal static SqlCommand GetFCPCreditReqRpt(int reqstatus, DateTime frmdate, DateTime todate, string fcode, Int32 pageIndex, Int32 pagesize,string reqcode,string action)
        {
            var parameters = new[]
                {
                    CreateParameter("@reqstatus", SqlDbType.Int, reqstatus) ,
                    CreateParameter("@frmdate", SqlDbType.DateTime, frmdate) ,
                    CreateParameter("@todate", SqlDbType.DateTime, todate) ,
                    CreateParameter("@fcode", SqlDbType.VarChar, fcode) ,
                    CreateParameter("@pageIndex", SqlDbType.BigInt, pageIndex) ,
                    CreateParameter("@pagesize", SqlDbType.BigInt, pagesize),
                    CreateParameter("@reqcode", SqlDbType.VarChar, reqcode),
                    CreateParameter("@action", SqlDbType.VarChar, action) 
                };
            return CreateCommand("GetFCPCreditReqRpt_SP", parameters);
        }
        internal static SqlCommand TempRepOrder_FCP(string action, string UNQId, string pcode, string ItemCode, string Attribute, string Qty, string Item, string Fcode)
        {
            var parameters = new[]
               {                                                           
                   CreateParameter("@action", SqlDbType.VarChar, action), 
                   CreateParameter("@UNQId", SqlDbType.VarChar, UNQId), 
                   CreateParameter("@PCode", SqlDbType.VarChar, pcode),                   
                   CreateParameter("@ItemCode", SqlDbType.VarChar, ItemCode),
                   CreateParameter("@Attribute", SqlDbType.VarChar, Attribute),
                   CreateParameter("@Qty", SqlDbType.Int, Convert.ToInt32(Qty)),
                   CreateParameter("@Item", SqlDbType.VarChar, Item),
                   CreateParameter("@Fcode", SqlDbType.VarChar, Fcode)
                };
            return CreateCommand("TempRepOrder_FCP_SP", parameters);
        }
        internal static SqlCommand ScOrder_FCP(string UNQId, Int32 regid, Int32 downlineid, string mop, string mopamt, string Fname, string LName, string Mobile, string Address, string City, string District, string state, string PiCode, string ordertype, string shpchrg, string scmemtype, string sesid, string ipadd, string Fcode)
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
                    CreateParameter("@Fcode", SqlDbType.VarChar, Fcode ?? ""),
                };
            return CreateCommand("SCOrder_FCP_SP", parameters);
        }
        internal static SqlCommand GetAvlQtyforStockAdj_FCP(string action, string itemcode, string Fcode)
        {
            var parameters = new[]
                {
                    CreateParameter("@action", SqlDbType.VarChar, action),                     
                    CreateParameter("@Itemcode", SqlDbType.VarChar, itemcode),
                    CreateParameter("@Fcode", SqlDbType.VarChar, Fcode) 
                };
            return CreateCommand("GetAvlQtyforStockAdj_FCP_Sp", parameters);
        }
        internal static SqlCommand FCPGlance(DateTime date, string user)
        {
            var parameters = new[]
                {                                           
                    CreateParameter("@date", SqlDbType.DateTime, date),
                    CreateParameter("@user", SqlDbType.NVarChar, user) 
                };
            return CreateCommand("FCPGlance_SP", parameters);
        }
        internal static SqlCommand GlanceReport_FCP(string action, string rpttype, DateTime ondate, string username, string sts, string searchby, Int32 pageindex, Int32 pagesize)
        {
            var parameters = new[]
                {                                           
                    CreateParameter("@action", SqlDbType.NVarChar, action),
                    CreateParameter("@rpttype", SqlDbType.NVarChar, rpttype),
                    CreateParameter("@ondate", SqlDbType.DateTime, ondate),
                    CreateParameter("@username", SqlDbType.NVarChar, username),
                    CreateParameter("@sts", SqlDbType.NVarChar, sts),
                    CreateParameter("@searchby", SqlDbType.NVarChar, searchby),
                    CreateParameter("@pageindex", SqlDbType.Int, pageindex),
                    CreateParameter("@pagesize", SqlDbType.Int, pagesize)
                };
            return CreateCommand("GlanceReport_FCP_SP", parameters);
        }
        #endregion
    }
}
