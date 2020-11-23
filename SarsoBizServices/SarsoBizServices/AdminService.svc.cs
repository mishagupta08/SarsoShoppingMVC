using System;
using System.Configuration;
using System.Data;
using SarsoBizDal;

namespace SarsoBizServices
{
    // NOTE: If you change the class name "AdminService" here, you must also update the reference to "AdminService" in Web.config.
    public class AdminService : IAdminService
    {
        readonly static Utilities Objutlit = new Utilities();
        readonly string _environment = ConfigurationManager.AppSettings["Environment"];

        public DataTable AdminLogin(string username, string password)
        {
            return SarsoBizsDal.Instance.AdminModule.AdminLogin(_environment, username, Objutlit.Encrypt(password));
        }
        public void CodeErrors(string userid, string pageurl, string errorMsg, string sesid)
        {
            SarsoBizsDal.Instance.AdminModule.CodeErrors(_environment, userid, pageurl, errorMsg, sesid);
        }
        public void SessionsInOut(string action, Int32 uid, string sesid, string ipaddress, string systemname,
                                   string usertype)
        {
            SarsoBizsDal.Instance.AdminModule.SessionsInOut(_environment, action, uid, sesid, ipaddress, systemname, usertype);
        }
        public DataTable CurrlastloginTime(Int32 loginid, string sesid, string usertype)
        {
            return SarsoBizsDal.Instance.AdminModule.CurrlastloginTime(_environment, loginid, sesid, usertype);
        }
        public DataTable MainLinks(int uid, string usertype)
        {
            return SarsoBizsDal.Instance.AdminModule.MainLinks(_environment, uid, usertype);
        }

        public DataTable Sublinks(int lid, int uid, string usertype)
        {
            return SarsoBizsDal.Instance.AdminModule.Sublinks(_environment, lid, uid, usertype);
        }

        public DataTable LinksPremission(int lid, int uid, string usertype)
        {
            return SarsoBizsDal.Instance.AdminModule.LinksPremission(_environment, lid, uid, usertype);
        }
        public int SublinksPermissions(string lids, Int32 itemid, Int32 uid, string sesid, string usertype)
        {
            return SarsoBizsDal.Instance.AdminModule.SublinksPermissions(_environment, lids, itemid, uid, sesid, usertype);
        }
        public DataTable Users(string action, int itemid)
        {
            return SarsoBizsDal.Instance.AdminModule.Users(_environment, action, itemid);
        }
        public int InupUsers(string action, int itemId, string userName, string passWord, string name,
                             string doorno, string lane, string streat, string city, string state,
                             string contactName, string contactPhone, string email, int uid,
                             string sesid, string ipaddress, int flag)
        {
            return SarsoBizsDal.Instance.AdminModule.InupUsers(_environment, action, itemId, userName, passWord, name, doorno,
                                                         lane, streat, city, state, contactName,
                                                         contactPhone, email, uid, sesid, ipaddress, flag);
        }
        public int DelUsers(int itemid, int uid)
        {
            return SarsoBizsDal.Instance.AdminModule.DelUsers(_environment, itemid, uid);
        }
        public int ChangePassword(string action, int itemid, string pwd, int uid)
        {
            return SarsoBizsDal.Instance.AdminModule.ChangePassword(_environment, action, itemid, pwd, uid);
        }

        public string GetValue(string tblname, string getcolum, string columnItem, string itemId)
        {
            return SarsoBizsDal.Instance.AdminModule.GetValue(_environment, tblname, getcolum, columnItem, itemId);
        }

        public DataTable GetData(string tblname, string columnItem, string itemId)
        {
            return SarsoBizsDal.Instance.AdminModule.GetData(_environment, tblname, columnItem, itemId);
        }

        public DataTable UsersLogRpt(DateTime frmdate, DateTime todate, Int32 user, Int32 pageIndex, Int32 pageSize, string usertype)
        {
            return SarsoBizsDal.Instance.AdminModule.UsersLogRpt(_environment, frmdate, todate, user, pageIndex, pageSize, usertype);
        }


        public int AddCompanyBanks(string action, int cbId, string bank, string branch, string accno, string ifsc, string city, string state,
                                                    int cbStatus, string createdBy, string sesid)
        {
            return SarsoBizsDal.Instance.AdminModule.AddCompanyBanks(_environment, action, cbId, bank, branch, accno, ifsc, city, state,
                                                                            cbStatus, createdBy, sesid);
        }
        public DataTable GetCompanyBanks(int cbid)
        {
            return SarsoBizsDal.Instance.AdminModule.GetCompanyBanks(_environment, cbid);
        }

        public DataTable MemberSearch(string key, string style, string keyWords,
                                             string sortby, Int32 pageIndex, Int32 pageSize)
        {
            return SarsoBizsDal.Instance.AdminModule.MemberSearch(_environment, key, style, keyWords,
                                                            sortby, pageIndex, pageSize);
        }

        public DataTable RegistrationReport(string action, string plantype, DateTime frmdate,
                                   DateTime todate, Int64 regid, Int32 pageIndex, Int32 pageSize)
        {
            return SarsoBizsDal.Instance.AdminModule.RegistrationReport(_environment, action, plantype, frmdate, todate, regid, pageIndex, pageSize);
        }

        public DataTable GetPackages(string action)
        {
            return SarsoBizsDal.Instance.AdminModule.GetPackages(_environment, action);
        }

        public DataTable DrcDetails()
        {
            return SarsoBizsDal.Instance.AdminModule.DrcDetails(_environment);
        }

        public int UpDrcDetails(Int32 pid, string postEwallet, double drcAmt)
        {
            return SarsoBizsDal.Instance.AdminModule.UpDrcDetails(_environment, pid, postEwallet, drcAmt);
        }


        public DataTable PairsReport(DateTime frmdate, DateTime todate, Int64 regid, Int32 pageIndex, Int32 pageSize)
        {
            return SarsoBizsDal.Instance.AdminModule.PairsReport(_environment, frmdate, todate, regid, pageIndex, pageSize);
        }

        public DataTable BlockIdorBlockToPaidRpt(string action, DateTime frmdate, DateTime todate, Int32 pageIndex, Int32 pageSize)
        {
            return SarsoBizsDal.Instance.AdminModule.BlockIdorBlockToPaidRpt(_environment, action, frmdate, todate, pageIndex, pageSize);
        }

        public DataTable FeedbackRpt(string action, string idno, string name, string city, string state, string email,
                                     string subject,
                                     string msg, string status, Int32 createdby, DateTime createddate, string plantype,
                                     Int32 pageIndex, Int32 pageSize)
        {
            return SarsoBizsDal.Instance.AdminModule.FeedbackRpt(_environment, action, idno, name, city, state, email, subject,
                                                           msg, status, createdby, createddate, plantype, pageIndex,
                                                           pageSize);
        }

        public DataTable NewsRpt(string action, string description, string status, Int32 createdby, DateTime createddate,
                                 Int32 updatedby,
                                 DateTime updateddate, string plantype, Int32 pageIndex, Int32 pageSize)
        {
            return SarsoBizsDal.Instance.AdminModule.NewsRpt(_environment, action, description, status, createdby, createddate,
                                                       updatedby, updateddate, plantype, pageIndex, pageSize);
        }
        public DataTable SeminarRpt(string action, string titile, string venue, DateTime date, string time, string city,
                                    string state, string vleader,
                                    string phoneno, string status, DateTime createddate, int createdby, int updatedby,
                                    DateTime updateddate, string plantype, Int32 pageIndex, Int32 pageSize)
        {
            return SarsoBizsDal.Instance.AdminModule.SeminarRpt(_environment, action, titile, venue, date, time, city, state,
                                                          vleader,
                                                          phoneno, status, createddate, createdby, updatedby, updateddate,
                                                          plantype, pageIndex, pageSize);
        }

        public DataSet FaqsRpt(string action, string qusetion, string answer, string catageory, string catageoryname, string user,
                                 string status,
                                 string sessid, string plantype, Int32 pageIndex, Int32 pageSize)
        {
            return SarsoBizsDal.Instance.AdminModule.FaqsRpt(_environment, action, qusetion, answer, catageory, catageoryname, user,
                                                       status, sessid, plantype, pageIndex, pageSize);
        }
        public DataTable FaqsCategorys(string action)
        {
            return SarsoBizsDal.Instance.AdminModule.FaqsCategorys(_environment, action);
        }
        public DataTable MemberBankSlipsRpt(int sts, Int32 pageIndex, Int32 pageSize)
        {
            return SarsoBizsDal.Instance.AdminModule.MemberBankSlipsRpt(_environment, sts, pageIndex, pageSize);
        }
        public DataTable MemberBankSlipsforAppRej(Int32 regid, DateTime fromdate, DateTime todate, Int32 pageIndex,
                                            Int32 pageSize)
        {
            return SarsoBizsDal.Instance.AdminModule.MemberBankSlipsforAppRej(_environment, regid, fromdate, todate, pageIndex, pageSize);
        }

        public void AppRejBankSlips(string slnos, int sts, string sesid, string ipadd, Int32 uid)
        {
            SarsoBizsDal.Instance.AdminModule.AppRejBankSlips(_environment, slnos, sts, sesid, ipadd, uid);
        }

        public DataTable CstCollectionRpt(string action, DateTime fromdate, DateTime todate, Int32 pageIndex, Int32 pageSize)
        {
            return SarsoBizsDal.Instance.AdminModule.CstCollectionRpt(_environment, action, fromdate, todate, pageIndex, pageSize);
        }

        public DataTable VatCollectionRpt(string action, DateTime fromdate, DateTime todate, Int32 pageIndex, Int32 pageSize)
        {
            return SarsoBizsDal.Instance.AdminModule.VatCollectionRpt(_environment, action, fromdate, todate, pageIndex, pageSize);
        }

        public DataTable LboActivationRpt(string action, int regid, DateTime fromdate, DateTime todate, Int32 pageIndex, Int32 pageSize)
        {
            return SarsoBizsDal.Instance.AdminModule.LboActivationRpt(_environment, action, regid, fromdate, todate, pageIndex, pageSize);
        }

        public DataTable ProductSalesRpt(string action, int regid, DateTime fromdate, DateTime todate, Int32 pageIndex, Int32 pageSize)
        {
            return SarsoBizsDal.Instance.AdminModule.ProductSalesRpt(_environment, action, regid, fromdate, todate, pageIndex, pageSize);
        }

        public DataTable RepurchaseSalesRpt(string action, int regid, DateTime fromdate, DateTime todate,
                                            Int32 pageIndex, Int32 pageSize)
        {
            return SarsoBizsDal.Instance.AdminModule.RepurchaseSalesRpt(_environment, action, regid, fromdate, todate, pageIndex, pageSize);
        }
        public DataTable RepurchaseVochersRpt(string action, int regid, DateTime fromdate, DateTime todate, Int32 pageIndex, Int32 pageSize)
        {
            return SarsoBizsDal.Instance.AdminModule.RepurchaseVochersRpt(_environment, action, regid, fromdate, todate, pageIndex, pageSize);
        }
        public DataTable MobileRechargeRpt(string action, int regid, DateTime fromdate, DateTime todate, Int32 pageIndex, Int32 pageSize)
        {
            return SarsoBizsDal.Instance.AdminModule.MobileRechargeRpt(_environment, action, regid, fromdate, todate, pageIndex, pageSize);
        }
        public DataTable NonRpLbosRpt(string action, DateTime fromdate, DateTime todate, Int32 pageIndex, Int32 pageSize)
        {
            return SarsoBizsDal.Instance.AdminModule.NonRpLbosRpt(_environment, action, fromdate, todate, pageIndex, pageSize);
        }
        public DataTable TopMembersRpt(string action, int stateid, Int32 pageIndex, Int32 pageSize)
        {
            return SarsoBizsDal.Instance.AdminModule.TopMembersRpt(_environment, action, stateid, pageIndex, pageSize);
        }
        public DataTable CityWiseRpt(string action, string city, Int32 pageIndex, Int32 pageSize)
        {
            return SarsoBizsDal.Instance.AdminModule.CityWiseRpt(_environment, action, city, pageIndex, pageSize);
        }
        public DataTable RepurVocherValidityExtenRpt(string action, int regid, DateTime fromdate, DateTime todate, Int32 pageIndex, Int32 pageSize)
        {
            return SarsoBizsDal.Instance.AdminModule.RepurVocherValidityExtenRpt(_environment, action, regid, fromdate, todate, pageIndex, pageSize);
        }

        public DataTable PackageWiseRpt(string action, string month, Int32 pageIndex, Int32 pageSize)
        {
            return SarsoBizsDal.Instance.AdminModule.PackageWiseRpt(_environment, action, month, pageIndex, pageSize);
        }
        public DataTable SmsLogRpt(string action, DateTime fromdate, DateTime todate, Int32 pageIndex, Int32 pageSize)
        {
            return SarsoBizsDal.Instance.AdminModule.SmsLogRpt(_environment, action, fromdate, todate, pageIndex, pageSize);
        }
        public DataTable PayoutSmsRpt(string action, Int32 pageIndex, Int32 pageSize)
        {
            return SarsoBizsDal.Instance.AdminModule.PayoutSmsRpt(_environment, action, pageIndex, pageSize);
        }

        public DataTable ShoppingReqRpt(string action, DateTime fromdate, DateTime todate, Int32 pageIndex, Int32 pageSize)
        {
            return SarsoBizsDal.Instance.AdminModule.ShoppingReqRpt(_environment, action, fromdate, todate, pageIndex, pageSize);
        }

        public DataTable CreditReqRpt(string action, Int32 pageIndex, Int32 pageSize)
        {
            return SarsoBizsDal.Instance.AdminModule.CreditReqRpt(_environment, action, pageIndex, pageSize);
        }
        public DataTable CreditSummaryRpt(string action, string fcode, Int32 pageIndex, Int32 pageSize)
        {
            return SarsoBizsDal.Instance.AdminModule.CreditSummaryRpt(_environment, action, fcode, pageIndex, pageSize);
        }
        public DataTable StockReturnsRpt(string action, Int32 pageIndex, Int32 pageSize)
        {
            return SarsoBizsDal.Instance.AdminModule.StockReturnsRpt(_environment, action, pageIndex, pageSize);
        }
        public DataTable FranchiseBalancesRpt(string action, Int32 pageIndex, Int32 pageSize)
        {
            return SarsoBizsDal.Instance.AdminModule.FranchiseBalancesRpt(_environment, action, pageIndex, pageSize);
        }
        public DataTable FranchiseCommissionRpt(string action, string fcode, Int32 pageIndex, Int32 pageSize)
        {
            return SarsoBizsDal.Instance.AdminModule.FranchiseCommissionRpt(_environment, action, fcode, pageIndex, pageSize);
        }
        public DataTable FranchiseSalesCommRpt(string action, string commtype, DateTime fromdate, DateTime todate,
            string fcode, Int32 pageIndex, Int32 pageSize)
        {
            return SarsoBizsDal.Instance.AdminModule.FranchiseSalesCommRpt(_environment, action, commtype, fromdate, todate, fcode, pageIndex, pageSize);
        }
        public DataTable LifeisClubMemRpt(string action, string membership, DateTime fromdate, DateTime todate,
            int regid, Int32 pageIndex, Int32 pageSize)
        {
            return SarsoBizsDal.Instance.AdminModule.LifeisClubMemRpt(_environment, action, membership, fromdate, todate, regid, pageIndex, pageSize);
        }
        public DataTable LifeisClubAchieversRpt(string action, string membership, DateTime fromdate, DateTime todate,
            int regid, Int32 pageIndex, Int32 pageSize)
        {
            return SarsoBizsDal.Instance.AdminModule.LifeisClubAchieversRpt(_environment, action, membership, fromdate, todate, regid, pageIndex, pageSize);
        }
        public DataTable LeadershipIncentivesRpt(string action, int payoutno, int regid, Int32 pageIndex, Int32 pageSize)
        {
            return SarsoBizsDal.Instance.AdminModule.LeadershipIncentivesRpt(_environment, action, payoutno, regid, pageIndex, pageSize);
        }
        public DataTable WithdrawlPendingReqRpt(string action, Int32 pageIndex, Int32 pageSize)
        {
            return SarsoBizsDal.Instance.AdminModule.WithdrawlPendingReqRpt(_environment, action, pageIndex, pageSize);
        }

        public string WithdrawlPendingReq(string reqids, string sesid)
        {
            return SarsoBizsDal.Instance.AdminModule.WithdrawlPendingReq(_environment, reqids, sesid);
        }


        public DataTable WithdrawlBatchRpt(string action, Int32 pageIndex, Int32 pageSize)
        {
            return SarsoBizsDal.Instance.AdminModule.WithdrawlBatchRpt(_environment, action, pageIndex, pageSize);
        }
        public DataTable ProductAnalasysRpt(string action, DateTime startdate, Int32 pageIndex, Int32 pageSize)
        {
            return SarsoBizsDal.Instance.AdminModule.ProductAnalasysRpt(_environment, action, startdate, pageIndex, pageSize);
        }
        public DataTable DistributionAnalasysRpt(string action, DateTime startdate, Int32 pageIndex, Int32 pageSize)
        {
            return SarsoBizsDal.Instance.AdminModule.DistributionAnalasysRpt(_environment, action, startdate, pageIndex, pageSize);
        }

        public DataTable ActiveInactiveRpt(DateTime fromdate, DateTime todate, Int32 regid, int stateid, Int32 pageIndex, Int32 pageSize)
        {
            return SarsoBizsDal.Instance.AdminModule.ActiveInactiveRpt(_environment, fromdate, todate, regid, stateid, pageIndex, pageSize);
        }

        public DataTable LiisBinary(Int32 regid)
        {
            return SarsoBizsDal.Instance.AdminModule.LiisBinary(_environment, regid);
        }

        public DataTable LiisBinaryInDet(Int32 regid, Int32 payno)
        {
            return SarsoBizsDal.Instance.AdminModule.LiisBinaryInDet(_environment, regid, payno);
        }

        public DataTable InvoicesRpt(string invFrom, string invType, DateTime fromdate, DateTime todate, Int32 pageIndex, Int32 pageSize)
        {
            return SarsoBizsDal.Instance.AdminModule.InvoicesRpt(_environment, invFrom, invType, fromdate, todate, pageIndex, pageSize);
        }
        public DataTable InvoicesRptAll(string action, string idno, string billno, DateTime fromdate, DateTime todate, Int32 pageIndex, Int32 pageSize)
        {
            return SarsoBizsDal.Instance.AdminModule.InvoicesRptAll(_environment, action, idno, billno, fromdate, todate, pageIndex, pageSize);
        }
        public DataTable AppRejMemProfRpt(string action, Int32 regid, DateTime fromdate, DateTime todate, Int32 pageIndex, Int32 pageSize)
        {
            return SarsoBizsDal.Instance.AdminModule.AppRejMemProfRpt(_environment, action, regid, fromdate, todate, pageIndex, pageSize);
        }
        public DataTable MemphotosforAppRej(string action, Int32 regid, DateTime fromdate, DateTime todate, Int32 pageIndex, Int32 pageSize)
        {
            return SarsoBizsDal.Instance.AdminModule.MemphotosforAppRej(_environment, action, regid, fromdate, todate, pageIndex, pageSize);
        }

        public void AppRejMemDetailes(string action, Int32 slno, int status, int byuser, string remarks)
        {
            SarsoBizsDal.Instance.AdminModule.AppRejMemDetailes(_environment, action, slno, status, byuser, remarks);
        }
        public void AppRejMemPhotos(Int32 slno, Int32 status, Int32 byuser, string action, string Remarks)
        {
            SarsoBizsDal.Instance.AdminModule.AppRejMemPhotos(_environment, slno, status, byuser, action, Remarks);
        }

        public DataTable ChkMobRchTransactionNo(string tranno)
        {
            return SarsoBizsDal.Instance.AdminModule.ChkMobRchTransactionNo(_environment, tranno);
        }
        public DataTable UpdateMobRchTransactionNo(string tranno, string sesid, string appby)
        {
            return SarsoBizsDal.Instance.AdminModule.UpdateMobRchTransactionNo(_environment, tranno, sesid, appby);
        }
        public DataTable SpeedGlance(DateTime ondate, string username)
        {
            return SarsoBizsDal.Instance.AdminModule.SpeedGlance(_environment, ondate, username);
        }
        public DataTable GlanceReport(string action, string type, DateTime ondate, string username)
        {
            return SarsoBizsDal.Instance.AdminModule.GlanceReport(_environment, action, type, ondate, username);
        }
        public void Cleartmpsms(string sesid)
        {
            SarsoBizsDal.Instance.AdminModule.Cleartmpsms(_environment, sesid);
        }

        public DataTable InsertResendSmsIds(Int32 regid, string sesid)
        {
            return SarsoBizsDal.Instance.AdminModule.InsertResendSmsIds(_environment, regid, sesid);
        }

        public void InsertResendSms(string sesid)
        {
            SarsoBizsDal.Instance.AdminModule.InsertResendSms(_environment, sesid);
        }

        public DataTable InsertNonMemsmsIds(string name, string mobile, string sesid)
        {
            return SarsoBizsDal.Instance.AdminModule.InsertNonMemsmsIds(_environment, name, mobile, sesid);
        }

        public void InsertNonMemSms(string sesid, string msg)
        {
            SarsoBizsDal.Instance.AdminModule.InsertNonMemSms(_environment, sesid, msg);
        }

        public DataTable SmsLog(string action, DateTime fromdate, DateTime todate, Int32 pageIndex, Int32 pageSize)
        {
            return SarsoBizsDal.Instance.AdminModule.SmsLog(_environment, action, fromdate, todate, pageIndex, pageSize);
        }
        public DataTable GetSmsActions()
        {
            return SarsoBizsDal.Instance.AdminModule.GetSmsActions(_environment);
        }
        public void ResendSms(string sesid)
        {
            SarsoBizsDal.Instance.AdminModule.ResendSms(_environment, sesid);
        }
        public DataTable MemberSms(string sesid, string msg)
        {
            return SarsoBizsDal.Instance.AdminModule.MemberSms(_environment, sesid, msg);
        }
        public void InsertMemberSms(string sesid, string msg)
        {
            SarsoBizsDal.Instance.AdminModule.InsertMemberSms(_environment, sesid, msg);
        }
        public DataTable BulkSms(string stateid, string city, string msg, string sesid)
        {
            return SarsoBizsDal.Instance.AdminModule.BulkSms(_environment, stateid, city, msg, sesid);
        }
        public void InsertBulkSms(string stateid, string city, string msg, string sesid)
        {
            SarsoBizsDal.Instance.AdminModule.InsertBulkSms(_environment, stateid, city, msg, sesid);
        }
        public DataTable GetMemforBirthdaysms()
        {
            return SarsoBizsDal.Instance.AdminModule.GetMemforBirthdaysms(_environment);
        }
        public DataTable BirthdaySms()
        {
            return SarsoBizsDal.Instance.AdminModule.BirthdaySms(_environment);
        }
        public void InsertBirthdaySms(string msg, string sesid)
        {
            SarsoBizsDal.Instance.AdminModule.InsertBirthdaySms(_environment, msg, sesid);
        }

        public DataTable GetMemforPayoutsms(Int32 payno)
        {
            return SarsoBizsDal.Instance.AdminModule.GetMemforPayoutsms(_environment, payno);
        }
        public DataTable PayoutSms(string idnos, Int16 payno, string sesid)
        {
            return SarsoBizsDal.Instance.AdminModule.PayoutSms(_environment, idnos, payno, sesid);
        }

        public void InsertPayoutSms(string idnos, Int16 payno, string sesid)
        {
            SarsoBizsDal.Instance.AdminModule.PayoutSms(_environment, idnos, payno, sesid);
        }

        public DataSet Invoices(string action, string billno)
        {
            return SarsoBizsDal.Instance.AdminModule.Invoices(_environment, action, billno);
        }

        public DataTable WithdrawlBatchExcel(string wdno)
        {
            return SarsoBizsDal.Instance.AdminModule.WithdrawlBatchExcel(_environment, wdno);
        }

        public DataTable GetVouchers(string action, Int32 regid, string sfcpCode, string sesid)
        {
            return SarsoBizsDal.Instance.AdminModule.GetVouchers(_environment, action, regid, sfcpCode, sesid);
        }

        public DataSet ShoppingRequests(int sts, Int32 pageindex, Int32 pagesize, DateTime fromdate, DateTime todate)
        {
            return SarsoBizsDal.Instance.AdminModule.ShoppingRequests(_environment, sts, pageindex, pagesize, fromdate, todate);
        }

        public string ShoppingRequestReject(string reqno, string remarks, string sesid, Int32 uid)
        {
            return SarsoBizsDal.Instance.AdminModule.ShoppingRequestReject(_environment, reqno, remarks, sesid, uid);
        }

        public string ShoppingRequestApprove(string reqno, double billamount, string mop, string tranno,
                                                          string tranbank, string tranbranch, DateTime trandate,
                                                          string remarks, string sesid, Int32 uid)
        {
            return SarsoBizsDal.Instance.AdminModule.ShoppingRequestApprove(_environment, reqno, billamount, mop, tranno,
                                                                                     tranbank, tranbranch, trandate,
                                                                                     remarks, sesid, uid);
        }
        public DataTable CrocrepatiRewardReport(int reward, Int32 regid, Int32 payno, Int32 pageindex, Int32 pagesize)
        {
            return SarsoBizsDal.Instance.AdminModule.CrocrepatiRewardReport(_environment, reward, regid, payno, pageindex, pagesize);
        }

        public DataTable BigBossRewardReport(int reward, Int32 pageindex, Int32 pagesize)
        {
            return SarsoBizsDal.Instance.AdminModule.BigBossRewardReport(_environment, reward, pageindex, pagesize);
        }


        public DataTable BigBossRequestsRpt(string sts, DateTime fromdate, DateTime todate, Int32 regid,
                                     Int32 pageIndex, Int32 pageSize)
        {
            return SarsoBizsDal.Instance.AdminModule.BigBossRequestsRpt(_environment, sts, fromdate, todate, regid,
                                     pageIndex, pageSize);
        }

        public string BigBossReqAppRej(Int32 sno, string sts, string remarks, Int32 uid, string sesid)
        {
            return SarsoBizsDal.Instance.AdminModule.BigBossReqAppRej(_environment, sno, sts, remarks, uid, sesid);
        }

        public DataSet PkgPrdMonthWiseCnt(string month)
        {
            return SarsoBizsDal.Instance.AdminModule.PkgPrdMonthWiseCnt(_environment, month);
        }
        public string GetBatch(string tblname, string getcolum, string columnItem, string columnVal, string batchno)
        {
            return SarsoBizsDal.Instance.AdminModule.GetBatch(_environment, tblname, getcolum, columnItem, columnVal, batchno);
        }
        public int ResetPassword(Int32 regid, string pwd, int uid, int pwdType, int sms, int changed)
        {
            return SarsoBizsDal.Instance.AdminModule.ResetPassword(_environment, regid, pwd, uid, pwdType, sms, changed);
        }
        public DataTable InsBankStatement(string action, DateTime stmdate, double Amount, string Description, string bank, DateTime date, string createdby, string sesid, string ipaddress, Int32 pageIndex, Int32 pageSize, string TranType)
        {
            return SarsoBizsDal.Instance.AdminModule.InsBankStatement(_environment, action, stmdate, Amount, Description, bank, date, createdby, sesid, ipaddress, pageIndex, pageSize, TranType);
        }
        public DataTable CompanyNotifications(string type, Int32 regid, string gcmid, string subject, string message, string image, string url)
        {
            return SarsoBizsDal.Instance.AdminModule.CompanyNotifications(_environment, type, regid, gcmid, subject, message, image, url);
        }

        public DataTable KycReport(string action, DateTime frmdate, DateTime todate, Int32 regid, Int32 pageIndex, Int32 pagesize, Int32 status)
        {
            return SarsoBizsDal.Instance.AdminModule.KycReport(_environment, action, frmdate, todate, regid, pageIndex, pagesize, status);
        }
        public DataTable KycPendingRpt(string type, string ModuleType)
        {
            return SarsoBizsDal.Instance.AdminModule.KycPendingRpt(_environment, type, ModuleType);
        }
        public void ApproveKyc(Int32 slno, Int32 apprej, string sesid, string remarks, Int32 apprejby, string type)
        {
            SarsoBizsDal.Instance.AdminModule.ApproveKyc(_environment, slno, apprej, sesid, remarks, apprejby, type);
        }
        public DataTable RegistrationReport1(string searchid, Int32 status, DateTime frmdate, DateTime todate, Int32 regid, Int32 stateid, Int32 pageIndex, Int32 pageSize, string val)
        {
            return SarsoBizsDal.Instance.AdminModule.RegistrationReport1(_environment, searchid, status, frmdate, todate, regid, stateid, pageIndex, pageSize,val);
        }
        public DataTable MemphotosReport(string action, DateTime frmdate, DateTime todate, Int32 regid, Int32 pageIndex, Int32 pagesize)
        {
            return SarsoBizsDal.Instance.AdminModule.MemphotosReport(_environment, action, frmdate, todate, regid, pageIndex, pagesize);
        }
        public DataTable GetCount(string mailid)
        {
            return SarsoBizsDal.Instance.AdminModule.GetCount(_environment, mailid);
        }
        public DataTable GetMails(string mailid)
        {
            return SarsoBizsDal.Instance.AdminModule.GetMails(_environment, mailid);
        }
        public string DeleteMail(Int32 id)
        {
            return SarsoBizsDal.Instance.AdminModule.DeleteMail(_environment, id);
        }
        public string GetAttch(Int32 id)
        {
            return SarsoBizsDal.Instance.AdminModule.GetAttch(_environment, id);
        }
        public DataTable SearchMails(string mailFrom, string mailTo)
        {
            return SarsoBizsDal.Instance.AdminModule.SearchMails(_environment, mailFrom, mailTo);
        }
        public int IsAttachExit(Int32 id)
        {
            return SarsoBizsDal.Instance.AdminModule.IsAttachExit(_environment, id);
        }
        public string GetBulkMessage(Int32 id)
        {
            return SarsoBizsDal.Instance.AdminModule.GetBulkMessage(_environment, id);
        }
        public DataTable GetBulkSubject(Int32 id)
        {
            return SarsoBizsDal.Instance.AdminModule.GetBulkSubject(_environment, id);
        }
        public string GetMessage(Int32 id)
        {
            return SarsoBizsDal.Instance.AdminModule.GetMessage(_environment, id);
        }

        public string GetSubject(Int32 id)
        {
            return SarsoBizsDal.Instance.AdminModule.GetSubject(_environment, id);
        }

        public string GetMsgFrom(Int32 id)
        {
            return SarsoBizsDal.Instance.AdminModule.GetMsgFrom(_environment, id);
        }
        public string GetMsgTo(Int32 id)
        {
            return SarsoBizsDal.Instance.AdminModule.GetMsgTo(_environment, id);
        }
        public string GetMsgDate(Int32 id)
        {
            return SarsoBizsDal.Instance.AdminModule.GetMsgDate(_environment, id);
        }
        public DataTable GetDraftMsg(Int32 id)
        {
            return SarsoBizsDal.Instance.AdminModule.GetDraftMsg(_environment, id);
        }
        public int ReplyMail(string mailfrom, string mailto, string subject, string msg, DateTime sentdate, int savenSend, Int32 mailId, string repSubject, string file, string ReqNo, string Status)
        {
            return SarsoBizsDal.Instance.AdminModule.ReplyMail(_environment, mailfrom, mailto, subject, msg, sentdate, savenSend, mailId, repSubject, file,ReqNo,Status);
        }
        public int SendMail(string mailfrom, string mailto, string subject, string msg, DateTime sentdate, int savenSend, string file, string toType)
        {
            return SarsoBizsDal.Instance.AdminModule.SendMail(_environment, mailfrom, mailto, subject, msg, sentdate, savenSend, file, toType);
        }
        public DataTable GetSentMails(string mailId)
        {
            return SarsoBizsDal.Instance.AdminModule.GetSentMails(_environment, mailId);
        }
        public int DeleteSentMails(Int32 mailId)
        {
            return SarsoBizsDal.Instance.AdminModule.DeleteSentMails(_environment, mailId);
        }
        public int SendBulkMail(string mailfrom, string subject, string msg, DateTime sentdate)
        {
            return SarsoBizsDal.Instance.AdminModule.SendBulkMail(_environment, mailfrom, subject, msg, sentdate);
        }
        public DataTable GetBulkMails()
        {
            return SarsoBizsDal.Instance.AdminModule.GetBulkMails(_environment);
        }
        public int DeleteBulkMail(Int32 mailId)
        {
            return SarsoBizsDal.Instance.AdminModule.DeleteBulkMail(_environment, mailId);
        }
        public string CreateFolder(string folderName, string memId)
        {
            return SarsoBizsDal.Instance.AdminModule.CreateFolder(_environment, folderName, memId);
        }
        public DataTable GetFolderMailsMails(string mailId, Int32 folderId)
        {
            return SarsoBizsDal.Instance.AdminModule.GetFolderMailsMails(_environment, mailId, folderId);
        }
        //29-02 Satish
        public DataTable Glance(DateTime fromdate, DateTime todate, Int32 uid)
        {
            return SarsoBizsDal.Instance.AdminModule.Glance(_environment, fromdate, todate, uid);
        }
        public DataTable GlanceReportNew(string action, string rpttype, DateTime fromdate, DateTime todate, Int32 mailto, Int32 sts, string searchby, Int32 pageindex, Int32 pagesize)
        {
            return SarsoBizsDal.Instance.AdminModule.GlanceReportNew(_environment, action, rpttype, fromdate, todate, mailto, sts, searchby, pageindex, pagesize);
        }

        public DataTable VATCSTReport(string action, string idno, string billno, Int16 status, DateTime frmdate, DateTime todate, Int32 pageIndex, Int32 pageSize, Int32 month, Int32 year, Int32 month1, Int32 year1, string state)
        {
            return SarsoBizsDal.Instance.AdminModule.VATCSTReport(_environment,action,idno,billno, status, frmdate, todate, pageIndex, pageSize, month, year, month1, year1, state);
        }

        public DataTable GetRegions(string search, string stype)
        {
            return SarsoBizsDal.Instance.AdminModule.GetRegions(_environment, search, stype);
        }
        public DataTable SalesReport(DateTime frmdate, DateTime todate, string orderid, Int32 pageIndex, Int32 pageSize)
        {
            return SarsoBizsDal.Instance.AdminModule.SalesReport(_environment, frmdate, todate, orderid, pageIndex, pageSize);
        }

        //01-03 Satish
        public DataTable NewsRptNew(string action, Int32 nid, string description, Int32 createdby, string ntype, string subject)
        {
            return SarsoBizsDal.Instance.AdminModule.NewsRptNew(_environment, action, nid, description, createdby, ntype, subject);
        }
        public DataTable FaqsRptNew(string action, Int32 faqid, string qusetion, string answer, Int32 user, string sessid)
        {
            return SarsoBizsDal.Instance.AdminModule.FaqsRptNew(_environment, action, faqid, qusetion, answer, user, sessid);
        }
        public DataTable Downloadfiles(string action, int sno, int status)
        {
            return SarsoBizsDal.Instance.AdminModule.Downloadfiles(_environment, action, sno, status);
        }
        public int InsertDownloadfiles(string title, string filename, string uploadby, string sesid)
        {
            return SarsoBizsDal.Instance.AdminModule.InsertDownloadfiles(_environment, title, filename, uploadby, sesid);
        }
        //02-03
        public DataTable GetMailfoldersname(string memid)
        {
            return SarsoBizsDal.Instance.AdminModule.GetMailfoldersname(_environment, memid);
        }
        public string InsertIntoFolder(Int32 mailId, Int32 folderId)
        {
            return SarsoBizsDal.Instance.AdminModule.InsertIntoFolder(_environment, mailId, folderId);
        }
        public string CheckSentID(string to, string toid)
        {
            return SarsoBizsDal.Instance.AdminModule.CheckSentID(_environment, to, toid);
        }
        public string GetSprDetails(string id)
        {
            return SarsoBizsDal.Instance.AdminModule.GetSprDetails(_environment, id);
        }
        public string MemberCheck(string userId)
        {
            return SarsoBizsDal.Instance.AdminModule.MemberCheck(_environment, userId);
        }
        public string VerifyLoginDetails(string userId)
        {
            return SarsoBizsDal.Instance.AdminModule.VerifyLoginDetails(_environment, userId);
        }
        public DataTable UnilevelTreeIdDet(string userId)
        {
            return SarsoBizsDal.Instance.AdminModule.UnilevelTreeIdDet(_environment, userId);
        }
        public DataTable Unilvltree(string userId)
        {
            return SarsoBizsDal.Instance.AdminModule.Unilvltree(_environment, userId);
        }

        public DataTable CreditReqPending()
        {
            return SarsoBizsDal.Instance.AdminModule.CreditReqPending(_environment);
        }
        public DataTable GetCreditreq(string reqcode)
        {
            return SarsoBizsDal.Instance.AdminModule.GetCreditreq(_environment, reqcode);
        }
        public void AppRejCreditRqt(string reqcode, int apprej, Int32 user, string sessid, string remarks)
        {
            SarsoBizsDal.Instance.AdminModule.AppRejCreditRqt(_environment, reqcode, apprej, user, sessid, remarks);
        }
        public DataTable GetCreditReqRpt(int reqstatus, int cbank, DateTime frmdate, DateTime todate, Int32 regid, Int32 pageIndex, Int32 pagesize)
        {
            return SarsoBizsDal.Instance.AdminModule.GetCreditReqRpt(_environment, reqstatus, cbank, frmdate, todate, regid, pageIndex, pagesize);
        }
        //rk
        public DataTable UsedCouponsRpt(DateTime frmdate, DateTime todate, Int32 regid, Int32 pageIndex, Int32 pagesize)
        {
            return SarsoBizsDal.Instance.AdminModule.UsedCouponsRpt(_environment, frmdate, todate, regid, pageIndex, pagesize);
        }

        public DataTable MemberRpOrders(Int32 regid, Int32 rpstatus, Int32 pageindex, Int32 pagesize, string Action)
        {
            return SarsoBizsDal.Instance.AdminModule.MemberRpOrders(_environment, regid, rpstatus, pageindex, pagesize, Action);
        }
        public DataSet Reg_OrderNo_Check(string RefNo, string Fcode, string ReceiptType)
        {
            return SarsoBizsDal.Instance.AdminModule.Reg_OrderNo_Check(_environment, RefNo, Fcode, ReceiptType);
        }
        public DataSet GetFeedbacks()
        {
            return SarsoBizsDal.Instance.AdminModule.GetFeedbacks(_environment);
        }
        //Modified by suresh on 13/5
        public DataTable AppConsultMOP(string action, Int64 Regid, string mop, double amount, string refno, string refbank, string refbranch, DateTime refDate, string remarks, string orderno, int ApprovedBy)
        {
            return SarsoBizsDal.Instance.AdminModule.AppConsultMOP(_environment, action, Regid, mop, amount, refno, refbank, refbranch, refDate, remarks, orderno, ApprovedBy);
        }
        public DataTable InsertBatchOutSms(Int32 regid, string Mobile, string msg, string sessid)
        {
            return SarsoBizsDal.Instance.AdminModule.InsertBatchOutSms(_environment, regid, Mobile, msg, sessid);
        }

        //14/03 satish
        public DataTable FaqsReport(string Type, DateTime Fromdate, DateTime Todate, int Pagesize, int PageIndex)
        {
            return SarsoBizsDal.Instance.AdminModule.FaqsReport(_environment, Type, Fromdate, Todate, Pagesize, PageIndex);
        }

        //16/03 Satish
        public DataTable OfferPopup(string action, string Title, String Subject, string Image, string Description, int Uid, DateTime Exp, int SNo)
        {
            return SarsoBizsDal.Instance.AdminModule.OfferPopup(_environment, action, Title, Subject, Image, Description, Uid, Exp, SNo);
        }

        //17/03 satish
        public DataTable GetTreeTooltip(string membid)
        {
            return SarsoBizsDal.Instance.AdminModule.GetTreeTooltip(_environment, membid);
        }
        public DataSet TreeView(string id)
        {
            return SarsoBizsDal.Instance.AdminModule.TreeView(_environment, id);
        }
        public DataSet chkmemdown(string id, string down)
        {
            return SarsoBizsDal.Instance.AdminModule.chkmemdown(_environment, id, down);
        }
        public DataTable GetMemberDetails(string Idno, String strType)
        {
            return SarsoBizsDal.Instance.AdminModule.GetMemberDetails(_environment, Idno, strType);
        }
        public int insertsmslog(Int64 regid, string mobile, DateTime senddate, string message, string action, string sessid, string SMSType)
        {
            return SarsoBizsDal.Instance.AdminModule.insertsmslog(_environment, regid, mobile, senddate, message, action, sessid, SMSType);
        }
        public DataTable Newslog(String Action, int Nlid, int Nid, int Regid, int Nread, DateTime CreatedDate, String sesid, int status)
        {
            return SarsoBizsDal.Instance.AdminModule.Newslog(_environment, Action, Nlid, Nid, Regid, Nread, CreatedDate, sesid, status);
        }
        public DataTable GetBulkMailCount(int MRead, string MStatus)
        {
            return SarsoBizsDal.Instance.AdminModule.GetBulkMailCount(_environment, MRead, MStatus);
        }
        public DataTable UnilevelTreeDet(string userId)
        {
            return SarsoBizsDal.Instance.AdminModule.UnilevelTreeDet(_environment, userId);
        }
        public DataTable Unilvltrees(string idno, int first, int end)
        {
            return SarsoBizsDal.Instance.AdminModule.Unilvltrees(_environment, idno, first, end);
        }
        public DataTable ApproveCustomerOrder(string action, Int32 slno, Int32 apprej, string sesid, string remarks, Int32 apprejby)
        {
            return SarsoBizsDal.Instance.AdminModule.ApproveCustomerOrder(_environment, action, slno, apprej, sesid, remarks, apprejby);
        }
        public DataTable RegistrationReport1onlinesucc(string searchid, DateTime frmdate, DateTime todate, Int32 pageIndex, Int32 pageSize, string pgtype)
        {
            return SarsoBizsDal.Instance.AdminModule.RegistrationReport1onlinesucc(_environment, searchid, frmdate, todate, pageIndex, pageSize, pgtype);
        }
        public DataTable RegistrationReport1onlinefail(DateTime frmdate, DateTime todate, Int32 pageIndex, Int32 pageSize)
        {
            return SarsoBizsDal.Instance.AdminModule.RegistrationReport1onlinefail(_environment, frmdate, todate, pageIndex, pageSize);
        }
        public DataTable Boostertrees(string action, string idno, int first, int end)
        {
            return SarsoBizsDal.Instance.AdminModule.Boostertrees(_environment, action,idno, first, end);
        }
        public DataTable BoosterTreeIdDet(string action, string userId)
        {
            return SarsoBizsDal.Instance.AdminModule.BoosterTreeIdDet(_environment, action, userId);
        }
        public DataTable GetApprovePoDetailes(Int32 payno)
        {
            return SarsoBizsDal.Instance.AdminModule.GetApprovePoDetailes(_environment, payno);
        }
        public DataTable PayoutApprove(Int32 payno, Int32 uid, string sessid)
        {
            return SarsoBizsDal.Instance.AdminModule.PayoutApprove(_environment, payno, uid, sessid);
        }
        public DataTable SICPPayoutApprove(string action,Int32 payno, Int32 uid, string sessid)
        {
            return SarsoBizsDal.Instance.AdminModule.SICPPayoutApprove(_environment, action,payno, uid, sessid);
        }
        public DataSet BainaryTrackReport(Int32 regid)
        {
            return SarsoBizsDal.Instance.AdminModule.BainaryTrackReport(_environment, regid);
        }
        public DataTable Steps(string OrbitNo, int OrbitStage, int PayNo)
        {
            return SarsoBizsDal.Instance.AdminModule.Steps(_environment, OrbitNo, OrbitStage, PayNo);
        }
        public DataTable GetBinaryAnalysis(Int32 pageIndex, Int32 pageSize)
        {
            return SarsoBizsDal.Instance.AdminModule.GetBinaryAnalysis(_environment, pageIndex, pageSize);
        }
        public DataTable SCReport1onlinesucc(string searchid, DateTime frmdate, DateTime todate, Int32 pageIndex, Int32 pageSize, string pgtype)
        {
            return SarsoBizsDal.Instance.AdminModule.SCReport1onlinesucc(_environment, searchid, frmdate, todate, pageIndex, pageSize, pgtype);
        }
        public DataTable SCReport1onlinefail(DateTime frmdate, DateTime todate, Int32 pageIndex, Int32 pageSize)
        {
            return SarsoBizsDal.Instance.AdminModule.SCReport1onlinefail(_environment, frmdate, todate, pageIndex, pageSize);
        }

        public DataTable CreditRequestReport1onlinesucc(string searchid, DateTime frmdate, DateTime todate, Int32 pageIndex, Int32 pageSize, string pgtype)
        {
            return SarsoBizsDal.Instance.AdminModule.CreditRequestReport1onlinesucc(_environment, searchid, frmdate, todate, pageIndex, pageSize, pgtype);
        }
        public DataTable CreditRequestReport1onlinefail(DateTime frmdate, DateTime todate, Int32 pageIndex, Int32 pageSize)
        {
            return SarsoBizsDal.Instance.AdminModule.CreditRequestReport1onlinefail(_environment, frmdate, todate, pageIndex, pageSize);
        }
        public DataTable SSMPPayoutProcess(string action, Int32 Uid, string Sessid, string Remarks, Int32 payno)
        {
            return SarsoBizsDal.Instance.AdminModule.SSMPPayoutProcess(_environment, action, Uid, Sessid, Remarks,payno);
        }
        public DataTable SICPPayoutProcess(string action, Int32 Uid, string Sessid, string Remarks)
        {
            return SarsoBizsDal.Instance.AdminModule.SICPPayoutProcess(_environment, action, Uid, Sessid, Remarks);
        }
        public DataTable SSMPRewards( Int32 regid)
        {
            return SarsoBizsDal.Instance.AdminModule.SSMPRewards(_environment, regid);
        }

        public DataTable ApprovePaymentrpt( string action,string Ordertype, string Paymenttype, String SBOID, DateTime fromdate, DateTime todate, Int32 pageIndex, Int32 pageSize)
        {
            return SarsoBizsDal.Instance.AdminModule.ApprovePaymentrpt(_environment, action,Ordertype, Paymenttype, SBOID, fromdate, todate, pageIndex, pageSize);
        }

        public DataTable PendingGatewayOrdersRpt(string action, DateTime fromdate, DateTime todate, Int32 pageIndex, Int32 pageSize)
        {
            return SarsoBizsDal.Instance.AdminModule.PendingGatewayOrdersRpt(_environment, action, fromdate, todate, pageIndex, pageSize);
        }

        public DataTable TDSRpt(string action, Int32 payno, String regid, string type, string mnths, string yrs, Int32 PageIndex, Int32 PageSize)
        {
            return SarsoBizsDal.Instance.AdminModule.TDSRpt(_environment, action, payno, regid, type, mnths, yrs, PageIndex, PageSize);
        }
        public DataTable BusinessStatsRpt(string action, string state, string district, string SBOID, string Packcode, string Pcode, string Sts, string Plantype, DateTime fromdate, DateTime todate, Int32 pageIndex, Int32 pageSize)
        {
            return SarsoBizsDal.Instance.AdminModule.BusinessStatsRpt(_environment, action, state, district, SBOID, Packcode, Pcode, Sts, Plantype, fromdate, todate, pageIndex, pageSize);
        }
        public DataTable GetReport(string action, string Type, Int32 payno, string regid, DateTime frmdate, DateTime todate, Int32 pageindex, Int32 pagesize)
        {
            return SarsoBizsDal.Instance.AdminModule.GetReport(_environment, action, Type, payno, regid, frmdate, todate, pageindex, pagesize);
        }
        public DataTable GetRegFields(string action, string fname1, string lname1, string dob1, string careof1, string mobile1, string eMail1)
        {
            return SarsoBizsDal.Instance.AdminModule.GetRegFields(_environment, action, fname1, lname1, dob1, careof1, mobile1, eMail1);
        }
        public DataTable UpdateDuplicateIdsRpt(int regid, string remarks, int uid, string sesid, string ipaddress)
        {
            return SarsoBizsDal.Instance.AdminModule.UpdateDuplicateIdsRpt(_environment, regid, remarks, uid, sesid, ipaddress);
        }
        public DataTable GetMinRegIdDuplicateIdsRpt(string Fname, string Lname, string UserName, DateTime dob, string Mobile, string Email)
        {
            return SarsoBizsDal.Instance.AdminModule.GetMinRegIdDuplicateIdsRpt(_environment, Fname, Lname, UserName, dob, Mobile, Email);
        }
        public DataTable BusinessReport(string action, string type, Int32 pageIndex, Int32 pageSize)
        {
            return SarsoBizsDal.Instance.AdminModule.BusinessReport(_environment, action, type,pageIndex, pageSize);
        }
        public DataTable DateWiseBusinessReport(string action, string type,DateTime date, Int32 pageIndex, Int32 pageSize)
        {
            return SarsoBizsDal.Instance.AdminModule.DateWiseBusinessReport(_environment, action, type, date, pageIndex, pageSize);
        }

        public DataTable NewsSubcription_Log(string action, Int32 NSLId, string Subject, string Body, string UploadFile, Int32 Status, Int32 uid, string sesid, Int32 pageindex, Int32 pagesize)
        {
            return SarsoBizsDal.Instance.AdminModule.NewsSubcription_Log(_environment, action, NSLId, Subject, Body, UploadFile, Status, uid, sesid,pageindex, pagesize);
        }

        public DataTable DespNewsLetter(string action, string EmailId, string Subject, string Body, string UploadFile, string sesid, string IPaddress)
        {
            return SarsoBizsDal.Instance.AdminModule.DespNewsLetter(_environment, action, EmailId, Subject, Body, UploadFile, sesid, IPaddress);
        }

        public DataTable CheckDownto(string action, string idno, string downto)
        {
            return SarsoBizsDal.Instance.AdminModule.CheckDownto(_environment,action, idno, downto);
        }

        public DataTable UpdateUnSuccessfulPGTranRpt(string CCRemarks, string ORDER_ID, int UpdatedBy)
        {
            return SarsoBizsDal.Instance.AdminModule.UpdateUnSuccessfulPGTranRpt(_environment, CCRemarks, ORDER_ID, UpdatedBy);
        }

        public DataSet GetRewardsReport(string action, string Type, Int32 payno, string regid, DateTime frmdate, DateTime todate, Int32 pageindex, Int32 pagesize)
        {
            return SarsoBizsDal.Instance.AdminModule.GetRewardsReport(_environment, action, Type, payno, regid, frmdate, todate, pageindex, pagesize);
        }
        public int MobileAppsmslog(Int64 regid, string mobile, DateTime senddate, string message, string action, string sessid, string SMSType)
        {
            return SarsoBizsDal.Instance.AdminModule.MobileAppsmslog(_environment, regid, mobile, senddate, message, action, sessid, SMSType);
        }
        public int OfferCreate(string action, string type, string pcode, string Itemid, string offName, Int32 noofcupons, DateTime frmdate, DateTime todate, string sessid, string ipaddress, Int32 createdby, string Remarks, int Status,
           Int32 NoofCoupCnts, Int32 txtcuponval1, Int32 MinValue1, Int32 MaxValue1, Int32 txtcuponval2, Int32 MinValue2, Int32 MaxValue2, Int32 txtcuponval3, Int32 MinValue3, Int32 MaxValue3,
            Int32 txtcuponval4, Int32 MinValue4, Int32 MaxValue4, Int32 txtcuponval5, Int32 MinValue5, Int32 MaxValue5)
        {
            return SarsoBizsDal.Instance.AdminModule.OfferCreate(_environment, action, type, pcode, Itemid,offName, noofcupons, frmdate, todate, sessid, ipaddress, createdby, Remarks,Status,
                NoofCoupCnts, txtcuponval1, MinValue1, MaxValue1, txtcuponval2, MinValue2, MaxValue2, txtcuponval3, MinValue3, MaxValue3, txtcuponval4, MinValue4, MaxValue4, txtcuponval5, MinValue5, MaxValue5);
        }

        public DataTable OfferReport(string Action, string Offname, DateTime frmdate, DateTime todate, Int32 pageIndex, Int32 pageSize, string Type)
        {
            return SarsoBizsDal.Instance.AdminModule.OfferReport(_environment, Action,Offname, frmdate, todate,pageIndex,pageSize,Type);
        }

        public DataTable MobileSlides(string Action, string CreatedBy, string SessId, string IpAdd, string ImgName, Int32 OrderNo)
        {
            return SarsoBizsDal.Instance.AdminModule.MobileSlides(_environment, Action, CreatedBy, SessId, IpAdd, ImgName, OrderNo);
        }

        public DataTable ClickAndShare(string Action, Int32 id, string CreatedBy, string Description, string Status, string ImgName, string SessId, string IpAdd)
        {
            return SarsoBizsDal.Instance.AdminModule.ClickAndShare(_environment, Action, id, CreatedBy, Description, Status, ImgName, SessId, IpAdd);
        }

        public int CreateWalletOffer(string action, string OfferCode, string pcode, string offName, string OffType, Double WalletValue, Int32 Pid, DateTime frmdate, DateTime todate, string sessid, string ipaddress, Int32 createdby, string Remarks, int Status)
        {
            return SarsoBizsDal.Instance.AdminModule.CreateWalletOffer(_environment, action, OfferCode, pcode, offName, OffType, WalletValue, Pid, frmdate, todate, sessid, ipaddress, createdby, Remarks, Status);
        }

        public DataSet DayStatisticsRpt(string action, string Type, string regid)
        {
            return SarsoBizsDal.Instance.AdminModule.DayStatisticsRpt(_environment, action, Type, regid);
        }
        public DataTable Stockreturn(string Action, string billno, string Refno, Int32 type, DateTime frmdate, DateTime todate, Int32 pageIndex, Int32 pageSize, string ssid, string remarks)
        {
            return SarsoBizsDal.Instance.AdminModule.Stockreturn(_environment, Action, billno, Refno, type, frmdate, todate, pageIndex, pageSize, ssid, remarks);
        }
        public DataTable GVDInstalPayment(string Action, string UnqId, string billno, Int32 Regid, Int32 pid, string MOP, double PayAmt, string ssid, string remarks)
        {
            return SarsoBizsDal.Instance.AdminModule.GVDInstalPayment(_environment, Action, UnqId, billno, Regid, pid, MOP, PayAmt, ssid, remarks);
        }
        public DataTable GVDFullPayment(string Action, string UnqId, string billno, Int32 Regid, Int32 pid, string MOP, double PayAmt, string ssid, string remarks, string DDno, string ddbank, string ddbranch, DateTime dddate, string mobile, string add1, string city, string district, string states, string pin)
        {
            return SarsoBizsDal.Instance.AdminModule.GVDFullPayment(_environment, Action, UnqId, billno, Regid, pid, MOP, PayAmt, ssid, remarks, DDno, ddbank, ddbranch, dddate, mobile, add1, city, district, states, pin);
        }
        public DataTable GetMemMails(string Action, string Reqno, Int32 Regid, Int32 id, string Type)
        {
            return SarsoBizsDal.Instance.AdminModule.GetMemMails(_environment, Action, Reqno, Regid, id, Type);
        }

        #region Franchisee
        public DataSet InsertFranchise(string FCCode, string FranchiseName, string Address1, string Address2, string city, string state, string Email, string Status, string CreatedBy, DateTime CreatedDate, string Phone, string stkLimit, string JoinAmt, string CompanyName, string UserName, string Password, string Bank, string AccNo, string IFSC, string BankAddress, string type, string tinno,string GST)
        {
            return SarsoBizsDal.Instance.AdminModule.InsertFranchise(_environment, FCCode, FranchiseName, Address1, Address2, city, state, Email, Status, CreatedBy, CreatedDate, Phone, stkLimit, JoinAmt, CompanyName, UserName, Password, Bank, AccNo, IFSC, BankAddress, type, tinno, GST);
        }
        public DataSet GetFCcode(string Action)
        {
            return SarsoBizsDal.Instance.AdminModule.GetFCcode(_environment, Action);
        }
        public DataSet ExistFranchiseIdno(string idno)
        {
            return SarsoBizsDal.Instance.AdminModule.ExistFranchiseIdno(_environment, idno);
        }
        public DataSet Editfranchise(string FCCode)
        {
            return SarsoBizsDal.Instance.AdminModule.Editfranchise(_environment, FCCode);
        }

        public DataTable FCPLogin(string username, string password)
        {
            return SarsoBizsDal.Instance.AdminModule.FCPLogin(_environment, username, Objutlit.Encrypt(password));
        }

        public DataTable TempStockOrder_FCP(string action, string UNQId, string pcode, string ItemCode, string Attribute, string Qty,string Item)
        {
            return SarsoBizsDal.Instance.AdminModule.TempStockOrder_FCP(_environment, action, UNQId, pcode, ItemCode, Attribute, Qty, Item);
        }

        public DataTable StockOrder_FCP(string action, string Id, string remarks, string Sessid, string UID)
        {
            return SarsoBizsDal.Instance.AdminModule.StockOrder_FCP(_environment, action, Id, remarks, Sessid, UID);
        }
        public DataTable StockOrderReport_FCP(string action, string Id, DateTime frmdate, DateTime todate, Int32 pageIndex, Int32 pageSize)
        {
            return SarsoBizsDal.Instance.AdminModule.StockOrderReport_FCP(_environment, action, Id, frmdate, todate, pageIndex, pageSize);
        }
        public DataTable ApprovedStockOrder_FCP(string action, string orderrefid, string fcode, string pcode, string qty, string sessionid, string SesUser, string dmode, string modname, string modno, string moddate, string modremarks, string VehicleNo)
        {
            return SarsoBizsDal.Instance.AdminModule.ApprovedStockOrder_FCP(_environment, action, orderrefid, fcode, pcode, qty, sessionid, SesUser, dmode, modname, modno, moddate, modremarks, VehicleNo);
        }
        public DataTable TempRepOrder_FCP(string action, string UNQId, string pcode, string ItemCode, string Attribute, string Qty, string Item, string Fcode)
        {
            return SarsoBizsDal.Instance.AdminModule.TempRepOrder_FCP(_environment, action, UNQId, pcode, ItemCode, Attribute, Qty, Item, Fcode);
        }
        public DataTable ScOrder_FCP(string UNQId, Int32 regid, Int32 downlineid, string mop, string mopamt, string Fname, string LName, string Mobile, string Address, string City, string District, string state, string PiCode, string ordertype, string shpchrg, string scmemtype, string sesid, string ipadd, string Fcode)
        {
            return SarsoBizsDal.Instance.AdminModule.ScOrder_FCP(_environment, UNQId, regid, downlineid, mop, mopamt, Fname, LName, Mobile, Address, City, District, state, PiCode, ordertype, shpchrg, scmemtype, sesid, ipadd, Fcode);
        }
        //dd
        public DataTable MakeFCPCreditRequest(string fcode, double reqAmt, string mop, string refno, DateTime date, string invbank, string invbranch, string VarcharNo, DateTime cdate, string depbank, string depbranch, string depcity, DateTime depdate, string depslip, string remarks)
        {
            return SarsoBizsDal.Instance.AdminModule.MakeFCPCreditRequest(_environment, fcode, reqAmt, mop, refno, date, invbank, invbranch, VarcharNo, cdate, depbank, depbranch, depcity, depdate, depslip, remarks);
        }
        public DataTable GetFCPCreditReqRpt(int reqstatus, DateTime frmdate, DateTime todate, string fcode, Int32 pageIndex, Int32 pagesize, string reqcode, string action)
        {
            return SarsoBizsDal.Instance.AdminModule.GetFCPCreditReqRpt(_environment, reqstatus, frmdate, todate, fcode, pageIndex, pagesize, reqcode,action);
        }
        public int GetAvlQtyforStockAdj_FCP(string action, string itemcode, string Fcode)
        {
            return SarsoBizsDal.Instance.AdminModule.GetAvlQtyforStockAdj_FCP(_environment, action, itemcode, Fcode);
        }
        public DataTable FCPGlance(DateTime date, string user)
        {
            return SarsoBizsDal.Instance.AdminModule.FCPGlance(_environment, date, user);
        }
        public DataTable GlanceReport_FCP(string action, string rpttype, DateTime ondate, string username, string sts, string searchby, Int32 pageindex, Int32 pagesize)
        {
            return SarsoBizsDal.Instance.AdminModule.GlanceReport_FCP(_environment, action, rpttype, ondate, username, sts, searchby, pageindex, pagesize);
        }
        #endregion
    }
}
