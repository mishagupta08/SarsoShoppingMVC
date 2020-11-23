using System;
using System.Data;

// ReSharper disable CheckNamespace
namespace SarsoBizDal
// ReSharper restore CheckNamespace
{
    public class AdminModule : IAdminModule
    {
        public DataTable AdminLogin(string env, string username, string password)
        {
            return SqlHelpers.GetTable(env, CommandFactory.AdminLogin(username, password));
        }
        public void CodeErrors(string env, string userid, string pageurl, string errorMsg, string sesid)
        {
            SqlHelpers.GetTable(env, CommandFactory.CodeErrors(userid, pageurl, errorMsg, sesid));
        }
        public void SessionsInOut(string env, string action, Int32 uid, string sesid, string ipaddress, string systemname,
                                  string usertype)
        {
            SqlHelpers.GetTable(env, CommandFactory.SessionsInOut(action, uid, sesid, ipaddress, systemname, usertype));
        }
        public DataTable CurrlastloginTime(string env, Int32 loginid, string sesid, string usertype)
        {
            return SqlHelpers.GetTable(env, CommandFactory.CurrlastloginTime(loginid, sesid, usertype));
        }
        public DataTable MainLinks(string env, int uid, string usertype)
        {
            return SqlHelpers.GetTable(env, CommandFactory.MainLinks(uid, usertype));
        }
        public DataTable Sublinks(string env, int lid, int uid, string usertype)
        {
            return SqlHelpers.GetTable(env, CommandFactory.Sublinks(lid, uid, usertype));
        }
        public DataTable LinksPremission(string env, int lid, int uid, string usertype)
        {
            return SqlHelpers.GetTable(env, CommandFactory.LinksPremission(lid, uid, usertype));
        }
        public int SublinksPermissions(string env, string lids, Int32 itemid, Int32 uid, string sesid, string usertype)
        {
            return SqlHelpers.GetValue<int>(env, CommandFactory.SublinksPermissions(lids, itemid, uid, sesid, usertype));
        }
        public DataTable Users(string env, string action, int itemid)
        {
            return SqlHelpers.GetTable(env, CommandFactory.Users(action, itemid));
        }
        public int InupUsers(string env, string action, int itemId, string userName, string passWord, string name,
                             string doorno, string lane, string streat, string city, string state,
                             string contactName, string contactPhone, string email, int uid,
                             string sesid, string ipaddress, int flag)
        {
            return SqlHelpers.GetValue<int>(env,
                                            CommandFactory.InupUsers(action, itemId, userName, passWord, name, doorno,
                                                                     lane, streat, city, state, contactName,
                                                                     contactPhone, email, uid, sesid, ipaddress, flag));
        }
        public int DelUsers(string env, int itemid, int uid)
        {
            return SqlHelpers.GetValue<int>(env, CommandFactory.DelUsers(itemid, uid));
        }
        public int ChangePassword(string env, string action, int itemid, string pwd, int uid)
        {
            return SqlHelpers.GetValue<int>(env, CommandFactory.ChangePassword(action, itemid, pwd, uid));
        }

        public string GetValue(string env, string tblname, string getcolum, string columnItem, string itemId)
        {
            return SqlHelpers.GetValue<string>(env, CommandFactory.GetValue(tblname, getcolum, columnItem, itemId));
        }

        public DataTable GetData(string env, string tblname, string columnItem, string itemId)
        {
            return SqlHelpers.GetTable(env, CommandFactory.GetData(tblname, columnItem, itemId));
        }
        public DataTable UsersLogRpt(string env, DateTime frmdate, DateTime todate, Int32 user, Int32 pageIndex, Int32 pageSize, string usertype)
        {
            return SqlHelpers.GetTable(env, CommandFactory.UsersLogRpt(frmdate, todate, user, pageIndex, pageSize, usertype));
        }
        public int AddCompanyBanks(string env, string action, int cbId, string bank, string branch, string accno, string ifsc, string city, string state,
                                                   int cbStatus, string createdBy, string sesid)
        {
            return SqlHelpers.GetValue<int>(env, CommandFactory.AddCompanyBanks(action, cbId, bank, branch, accno, ifsc, city, state,
                                                                           cbStatus, createdBy, sesid));
        }

        public DataTable GetCompanyBanks(string env, int cbId)
        {
            return SqlHelpers.GetTable(env, CommandFactory.GetCompanyBanks(cbId));
        }

        public DataTable MemberSearch(string env, string key, string style, string keyWords,
                                            string sortby, Int32 pageIndex, Int32 pageSize)
        {
            return SqlHelpers.GetTable(env, CommandFactory.MemberSearch(key, style, keyWords,
                                            sortby, pageIndex, pageSize));
        }

        public DataTable RegistrationReport(string env, string action, string plantype, DateTime frmdate,
                                    DateTime todate, Int64 regid, Int32 pageIndex, Int32 pageSize)
        {
            return SqlHelpers.GetTable(env,
                                       CommandFactory.RegistrationReport(action, plantype, frmdate, todate, regid, pageIndex, pageSize));
        }

        public DataTable GetPackages(string env, string action)
        {
            return SqlHelpers.GetTable(env, CommandFactory.GetPackages(action));
        }

        public DataTable DrcDetails(string env)
        {
            return SqlHelpers.GetTable(env, CommandFactory.DrcDetails());
        }

        public int UpDrcDetails(string env, Int32 pid, string postEwallet, double drcAmt)
        {
            return SqlHelpers.GetValue<int>(env, CommandFactory.UpDrcDetails(pid, postEwallet, drcAmt));
        }

        public DataTable PairsReport(string env, DateTime frmdate, DateTime todate, Int64 regid, Int32 pageIndex, Int32 pageSize)
        {
            return SqlHelpers.GetTable(env,
                                       CommandFactory.PairsReport(frmdate, todate, regid, pageIndex, pageSize));
        }

        public DataTable BlockIdorBlockToPaidRpt(string env, string action, DateTime frmdate, DateTime todate, Int32 pageIndex, Int32 pageSize)
        {
            return SqlHelpers.GetTable(env, CommandFactory.BlockIdorBlockToPaidRpt(action, frmdate, todate, pageIndex, pageSize));
        }

        public DataTable FeedbackRpt(string env, string action, string idno, string name, string city, string state, string email, string subject,
                                        string msg, string status, Int32 createdby, DateTime createddate, string plantype, Int32 pageIndex, Int32 pageSize)
        {
            return SqlHelpers.GetTable(env, CommandFactory.FeedbackRpt(action, idno, name, city, state, email, subject, msg, status, createdby, createddate, plantype, pageIndex, pageSize));
        }
        public DataTable NewsRpt(string env, string action, string description, string status, Int32 createdby, DateTime createddate, Int32 updatedby,
                                        DateTime updateddate, string plantype, Int32 pageIndex, Int32 pageSize)
        {
            return SqlHelpers.GetTable(env, CommandFactory.NewsRpt(action, description, status, createdby, createddate, updatedby, updateddate, plantype, pageIndex, pageSize));
        }
        public DataTable SeminarRpt(string env, string action, string titile, string venue, DateTime date, string time, string city, string state, string vleader,
            string phoneno, string status, DateTime createddate, int createdby, int updatedby, DateTime updateddate, string plantype, Int32 pageIndex, Int32 pageSize)
        {
            return SqlHelpers.GetTable(env, CommandFactory.SeminarRpt(action, titile, venue, date, time, city, state, vleader,
                                               phoneno, status, createddate, createdby, updatedby, updateddate, plantype, pageIndex, pageSize));
        }
        public DataSet FaqsRpt(string env, string action, string qusetion, string answer, string catageory, string catageoryname, string user, string status, string sessid, string plantype, Int32 pageIndex, Int32 pageSize)
        {
            return SqlHelpers.GetDataSet(env, CommandFactory.FaqsRpt(action, qusetion, answer, catageory, catageoryname, user,
                                                                   status, sessid, plantype, pageIndex, pageSize));
        }
        public DataTable FaqsCategorys(string env, string action)
        {
            return SqlHelpers.GetTable(env, CommandFactory.FaqsCategorys(action));
        }
        public DataTable MemberBankSlipsRpt(string env, int sts, Int32 pageIndex, Int32 pageSize)
        {
            return SqlHelpers.GetTable(env, CommandFactory.MemberBankSlipsRpt(sts, pageIndex, pageSize));
        }
        public DataTable MemberBankSlipsforAppRej(string env, Int32 regid, DateTime fromdate, DateTime todate, Int32 pageIndex, Int32 pageSize)
        {
            return SqlHelpers.GetTable(env, CommandFactory.MemberBankSlipsforAppRej(regid, fromdate, todate, pageIndex, pageSize));
        }
        public void AppRejBankSlips(string env, string slnos, int sts, string sesid, string ipadd, Int32 uid)
        {
            SqlHelpers.GetValue<int>(env, CommandFactory.AppRejBankSlips(slnos, sts, sesid, ipadd, uid));
        }
        public DataTable CstCollectionRpt(string env, string action, DateTime fromdate, DateTime todate, Int32 pageIndex, Int32 pageSize)
        {
            return SqlHelpers.GetTable(env, CommandFactory.CstCollectionRpt(action, fromdate, todate, pageIndex, pageSize));
        }
        public DataTable VatCollectionRpt(string env, string action, DateTime fromdate, DateTime todate, Int32 pageIndex, Int32 pageSize)
        {
            return SqlHelpers.GetTable(env, CommandFactory.VatCollectionRpt(action, fromdate, todate, pageIndex, pageSize));
        }
        public DataTable LboActivationRpt(string env, string action, int regid, DateTime fromdate, DateTime todate, Int32 pageIndex, Int32 pageSize)
        {
            return SqlHelpers.GetTable(env, CommandFactory.LboActivationRpt(action, regid, fromdate, todate, pageIndex, pageSize));
        }
        public DataTable ProductSalesRpt(string env, string action, int regid, DateTime fromdate, DateTime todate, Int32 pageIndex, Int32 pageSize)
        {
            return SqlHelpers.GetTable(env, CommandFactory.ProductSalesRpt(action, regid, fromdate, todate, pageIndex, pageSize));
        }

        public DataTable RepurchaseSalesRpt(string env, string action, int regid, DateTime fromdate, DateTime todate, Int32 pageIndex, Int32 pageSize)
        {
            return SqlHelpers.GetTable(env, CommandFactory.RepurchaseSalesRpt(action, regid, fromdate, todate, pageIndex, pageSize));
        }
        public DataTable RepurchaseVochersRpt(string env, string action, int regid, DateTime fromdate, DateTime todate, Int32 pageIndex, Int32 pageSize)
        {
            return SqlHelpers.GetTable(env, CommandFactory.RepurchaseVochersRpt(action, regid, fromdate, todate, pageIndex, pageSize));
        }
        public DataTable MobileRechargeRpt(string env, string action, int regid, DateTime fromdate, DateTime todate, Int32 pageIndex, Int32 pageSize)
        {
            return SqlHelpers.GetTable(env, CommandFactory.MobileRechargeRpt(action, regid, fromdate, todate, pageIndex, pageSize));
        }
        public DataTable NonRpLbosRpt(string env, string action, DateTime fromdate, DateTime todate, Int32 pageIndex, Int32 pageSize)
        {
            return SqlHelpers.GetTable(env, CommandFactory.NonRpLbosRpt(action, fromdate, todate, pageIndex, pageSize));
        }
        public DataTable TopMembersRpt(string env, string action, int stateid, Int32 pageIndex, Int32 pageSize)
        {
            return SqlHelpers.GetTable(env, CommandFactory.TopMembersRpt(action, stateid, pageIndex, pageSize));
        }
        public DataTable CityWiseRpt(string env, string action, string city, Int32 pageIndex, Int32 pageSize)
        {
            return SqlHelpers.GetTable(env, CommandFactory.CityWiseRpt(action, city, pageIndex, pageSize));
        }
        public DataTable RepurVocherValidityExtenRpt(string env, string action, int regid, DateTime fromdate, DateTime todate, Int32 pageIndex, Int32 pageSize)
        {
            return SqlHelpers.GetTable(env, CommandFactory.RepurVocherValidityExtenRpt(action, regid, fromdate, todate, pageIndex, pageSize));
        }

        public DataTable PackageWiseRpt(string env, string action, string month, Int32 pageIndex, Int32 pageSize)
        {
            return SqlHelpers.GetTable(env, CommandFactory.PackageWiseRpt(action, month, pageIndex, pageSize));
        }
        public DataTable SmsLogRpt(string env, string action, DateTime fromdate, DateTime todate, Int32 pageIndex, Int32 pageSize)
        {
            return SqlHelpers.GetTable(env, CommandFactory.SmsLogRpt(action, fromdate, todate, pageIndex, pageSize));
        }
        public DataTable PayoutSmsRpt(string env, string action, Int32 pageIndex, Int32 pageSize)
        {
            return SqlHelpers.GetTable(env, CommandFactory.PayoutSmsRpt(action, pageIndex, pageSize));
        }

        public DataTable ShoppingReqRpt(string env, string action, DateTime fromdate, DateTime todate, Int32 pageIndex, Int32 pageSize)
        {
            return SqlHelpers.GetTable(env, CommandFactory.ShoppingReqRpt(action, fromdate, todate, pageIndex, pageSize));
        }

        public DataTable CreditReqRpt(string env, string action, Int32 pageIndex, Int32 pageSize)
        {
            return SqlHelpers.GetTable(env, CommandFactory.CreditReqRpt(action, pageIndex, pageSize));
        }
        public DataTable CreditSummaryRpt(string env, string action, string fcode, Int32 pageIndex, Int32 pageSize)
        {
            return SqlHelpers.GetTable(env, CommandFactory.CreditSummaryRpt(action, fcode, pageIndex, pageSize));
        }
        public DataTable StockReturnsRpt(string env, string action, Int32 pageIndex, Int32 pageSize)
        {
            return SqlHelpers.GetTable(env, CommandFactory.StockReturnsRpt(action, pageIndex, pageSize));
        }
        public DataTable FranchiseBalancesRpt(string env, string action, Int32 pageIndex, Int32 pageSize)
        {
            return SqlHelpers.GetTable(env, CommandFactory.FranchiseBalancesRpt(action, pageIndex, pageSize));
        }
        public DataTable FranchiseCommissionRpt(string env, string action, string fcode, Int32 pageIndex, Int32 pageSize)
        {
            return SqlHelpers.GetTable(env, CommandFactory.FranchiseCommissionRpt(action, fcode, pageIndex, pageSize));
        }
        public DataTable FranchiseSalesCommRpt(string env, string action, string commtype, DateTime fromdate, DateTime todate,
            string fcode, Int32 pageIndex, Int32 pageSize)
        {
            return SqlHelpers.GetTable(env, CommandFactory.FranchiseSalesCommRpt(action, commtype, fromdate, todate, fcode, pageIndex, pageSize));
        }
        public DataTable LifeisClubMemRpt(string env, string action, string membership, DateTime fromdate, DateTime todate,
            int regid, Int32 pageIndex, Int32 pageSize)
        {
            return SqlHelpers.GetTable(env, CommandFactory.LifeisClubMemRpt(action, membership, fromdate, todate, regid, pageIndex, pageSize));
        }
        public DataTable LifeisClubAchieversRpt(string env, string action, string membership, DateTime fromdate, DateTime todate,
            int regid, Int32 pageIndex, Int32 pageSize)
        {
            return SqlHelpers.GetTable(env, CommandFactory.LifeisClubAchieversRpt(action, membership, fromdate, todate, regid, pageIndex, pageSize));
        }
        public DataTable LeadershipIncentivesRpt(string env, string action, int payoutno, int regid, Int32 pageIndex, Int32 pageSize)
        {
            return SqlHelpers.GetTable(env, CommandFactory.LeadershipIncentivesRpt(action, payoutno, regid, pageIndex, pageSize));
        }
        public DataTable WithdrawlPendingReqRpt(string env, string action, Int32 pageIndex, Int32 pageSize)
        {
            return SqlHelpers.GetTable(env, CommandFactory.WithdrawlPendingReqRpt(action, pageIndex, pageSize));
        }
        public string WithdrawlPendingReq(string env, string reqids, string sesid)
        {
            return SqlHelpers.GetValue<string>(env, CommandFactory.WithdrawlPendingReq(reqids, sesid));
        }
        public DataTable WithdrawlBatchRpt(string env, string action, Int32 pageIndex, Int32 pageSize)
        {
            return SqlHelpers.GetTable(env, CommandFactory.WithdrawlBatchRpt(action, pageIndex, pageSize));
        }
        public DataTable ProductAnalasysRpt(string env, string action, DateTime startdate, Int32 pageIndex, Int32 pageSize)
        {
            return SqlHelpers.GetTable(env, CommandFactory.ProductAnalasysRpt(action, startdate, pageIndex, pageSize));
        }
        public DataTable DistributionAnalasysRpt(string env, string action, DateTime startdate, Int32 pageIndex, Int32 pageSize)
        {
            return SqlHelpers.GetTable(env, CommandFactory.DistributionAnalasysRpt(action, startdate, pageIndex, pageSize));
        }
        public DataTable ActiveInactiveRpt(string env, DateTime fromdate, DateTime todate, Int32 regid, int stateid, Int32 pageIndex, Int32 pageSize)
        {
            return SqlHelpers.GetTable(env, CommandFactory.ActiveInactiveRpt(fromdate, todate, regid, stateid, pageIndex, pageSize));
        }
        public DataTable LiisBinary(string env, Int32 regid)
        {
            return SqlHelpers.GetTable(env, CommandFactory.LiisBinary(regid));
        }
        public DataTable LiisBinaryInDet(string env, Int32 regid, Int32 payno)
        {
            return SqlHelpers.GetTable(env, CommandFactory.LiisBinaryInDet(regid, payno));
        }
        public DataTable InvoicesRpt(string env, string invFrom, string invType, DateTime fromdate, DateTime todate, Int32 pageIndex, Int32 pageSize)
        {
            return SqlHelpers.GetTable(env, CommandFactory.InvoicesRpt(invFrom,  invType, fromdate, todate, pageIndex, pageSize));
        }
        public DataTable InvoicesRptAll(string env, string action, string idno, string billno, DateTime fromdate, DateTime todate, Int32 pageIndex, Int32 pageSize)
        {
            return SqlHelpers.GetTable(env, CommandFactory.InvoicesRptAll(action, idno, billno, fromdate, todate, pageIndex, pageSize));
        }
        public DataTable AppRejMemProfRpt(string env, string action, Int32 regid, DateTime fromdate, DateTime todate, Int32 pageIndex, Int32 pageSize)
        {
            return SqlHelpers.GetTable(env, CommandFactory.AppRejMemProfRpt(action, regid, fromdate, todate, pageIndex, pageSize));
        }
        public DataTable MemphotosforAppRej(string env, string action, Int32 regid, DateTime fromdate, DateTime todate, Int32 pageIndex, Int32 pageSize)
        {
            return SqlHelpers.GetTable(env, CommandFactory.MemphotosforAppRej(action, regid, fromdate, todate, pageIndex, pageSize));
        }

        public void AppRejMemDetailes(string env, string action, Int32 slno, int status, int byuser, string remarks)
        {
            SqlHelpers.GetValue<string>(env, CommandFactory.AppRejMemDetailes(action, slno, status, byuser, remarks));
        }
        public void AppRejMemPhotos(string env, Int32 slno, Int32 status, Int32 byuser, string action, string Remarks)
        {
            SqlHelpers.GetValue<string>(env, CommandFactory.AppRejMemPhotos(slno, status, byuser, action, Remarks));
        }

        public DataTable ChkMobRchTransactionNo(string env, string tranno)
        {
            return SqlHelpers.GetTable(env, CommandFactory.ChkMobRchTransactionNo(tranno));
        }
        public DataTable UpdateMobRchTransactionNo(string env, string tranno, string sesid, string appby)
        {
            return SqlHelpers.GetTable(env, CommandFactory.UpdateMobRchTransactionNo(tranno, sesid, appby));
        }
        public DataTable SpeedGlance(string env, DateTime ondate, string username)
        {
            return SqlHelpers.GetTable(env, CommandFactory.SpeedGlance(ondate, username));
        }
        public DataTable GlanceReport(string env, string action, string type, DateTime ondate, string username)
        {
            return SqlHelpers.GetTable(env, CommandFactory.GlanceReport(action, type, ondate, username));
        }
        public void Cleartmpsms(string env, string sesid)
        {
            SqlHelpers.GetValue<string>(env, CommandFactory.Cleartmpsms(sesid));
        }

        public DataTable InsertResendSmsIds(string env, Int32 regid, string sesid)
        {
            return SqlHelpers.GetTable(env, CommandFactory.InsertResendSmsIds(regid, sesid));
        }
        public void InsertResendSms(string env, string sesid)
        {
            SqlHelpers.GetValue<int>(env, CommandFactory.InsertResendSms(sesid));
        }

        public DataTable InsertNonMemsmsIds(string env, string name, string mobile, string sesid)
        {
            return SqlHelpers.GetTable(env, CommandFactory.InsertNonMemsmsIds(name, mobile, sesid));
        }

        public void InsertNonMemSms(string env, string sesid, string msg)
        {
            SqlHelpers.GetValue<int>(env, CommandFactory.InsertNonMemSms(sesid, msg));
        }

        public DataTable SmsLog(string env, string action, DateTime fromdate, DateTime todate, Int32 pageIndex, Int32 pageSize)
        {
            return SqlHelpers.GetTable(env, CommandFactory.SmsLog(action, fromdate, todate, pageIndex, pageSize));
        }
        public DataTable GetSmsActions(string env)
        {
            return SqlHelpers.GetTable(env, CommandFactory.GetSmsActions());
        }
        public void ResendSms(string env, string sesid)
        {
            SqlHelpers.GetValue<string>(env, CommandFactory.ResendSms(sesid));
        }
        public DataTable MemberSms(string env, string sesid, string msg)
        {
            return SqlHelpers.GetTable(env, CommandFactory.MemberSms(sesid, msg));
        }
        public void InsertMemberSms(string env, string sesid, string msg)
        {
            SqlHelpers.GetValue<string>(env, CommandFactory.InsertMemberSms(sesid, msg));
        }
        public DataTable BulkSms(string env, string stateid, string city, string msg, string sesid)
        {
            return SqlHelpers.GetTable(env, CommandFactory.BulkSms(stateid, city, msg, sesid));
        }
        public void InsertBulkSms(string env, string stateid, string city, string msg, string sesid)
        {
            SqlHelpers.GetValue<int>(env, CommandFactory.InsertBulkSms(stateid, city, msg, sesid));
        }
        public DataTable GetMemforBirthdaysms(string env)
        {
            return SqlHelpers.GetTable(env, CommandFactory.GetMemforBirthdaysms());
        }
        public DataTable BirthdaySms(string env)
        {
            return SqlHelpers.GetTable(env, CommandFactory.BirthdaySms());
        }

        public void InsertBirthdaySms(string env, string msg, string sesid)
        {
            SqlHelpers.GetValue<string>(env, CommandFactory.InsertBirthdaySms(msg, sesid));
        }

        public DataTable GetMemforPayoutsms(string env, Int32 payno)
        {
            return SqlHelpers.GetTable(env, CommandFactory.GetMemforPayoutsms(payno));
        }

        public DataTable PayoutSms(string env, string idnos, Int16 payno, string sesid)
        {
            return SqlHelpers.GetTable(env, CommandFactory.PayoutSms(idnos, payno, sesid));
        }

        public void InsertPayoutSms(string env, string idnos, Int16 payno, string sesid)
        {
            SqlHelpers.GetValue<int>(env, CommandFactory.InsertPayoutSms(idnos, payno, sesid));
        }

        public DataSet Invoices(string env, string action, string billno)
        {
            return SqlHelpers.GetDataSet(env, CommandFactory.Invoices(action, billno));
        }
        public DataTable WithdrawlBatchExcel(string env, string wdno)
        {
            return SqlHelpers.GetTable(env, CommandFactory.WithdrawlBatchExcel(wdno));
        }
        public DataTable GetVouchers(string env, string action, Int32 regid, string sfcpCode, string sesid)
        {
            return SqlHelpers.GetTable(env, CommandFactory.GetVouchers(action, regid, sfcpCode, sesid));
        }
        public DataSet ShoppingRequests(string env, int sts, Int32 pageindex, Int32 pagesize, DateTime fromdate, DateTime todate)
        {
            return SqlHelpers.GetDataSet(env, CommandFactory.ShoppingRequests(sts, pageindex, pagesize, fromdate, todate));
        }

        public string ShoppingRequestReject(string env, string reqno, string remarks, string sesid, Int32 uid)
        {
            return SqlHelpers.GetValue<string>(env, CommandFactory.ShoppingRequestReject(reqno, remarks, sesid, uid));
        }
        public string ShoppingRequestApprove(string env, string reqno, double billamount, string mop, string tranno,
                                                          string tranbank, string tranbranch, DateTime trandate,
                                                          string remarks, string sesid, Int32 uid)
        {
            return SqlHelpers.GetValue<string>(env,
                                               CommandFactory.ShoppingRequestApprove(reqno, billamount, mop, tranno,
                                                                                     tranbank, tranbranch, trandate,
                                                                                     remarks, sesid, uid));
        }
        public DataTable CrocrepatiRewardReport(string env, int reward, Int32 regid, Int32 payno, Int32 pageindex, Int32 pagesize)
        {
            return SqlHelpers.GetTable(env, CommandFactory.CrocrepatiRewardReport(reward, regid, payno, pageindex, pagesize));
        }
        public DataTable BigBossRewardReport(string env, int reward, Int32 pageindex, Int32 pagesize)
        {
            return SqlHelpers.GetTable(env, CommandFactory.BigBossRewardReport(reward, pageindex, pagesize));
        }
        public DataTable BigBossRequestsRpt(string env, string sts, DateTime fromdate, DateTime todate, Int32 regid, Int32 pageIndex, Int32 pageSize)
        {
            return SqlHelpers.GetTable(env, CommandFactory.BigBossRequestsRpt(sts, fromdate, todate, regid, pageIndex, pageSize));
        }
        public string BigBossReqAppRej(string env, Int32 sno, string sts, string remarks, Int32 uid, string sesid)
        {
            return SqlHelpers.GetValue<string>(env, CommandFactory.BigBossReqAppRej(sno, sts, remarks, uid, sesid));
        }
        public DataSet PkgPrdMonthWiseCnt(string env, string month)
        {
            return SqlHelpers.GetDataSet(env, CommandFactory.PkgPrdMonthWiseCnt(month));
        }
        public string GetBatch(string env, string tblname, string getcolum, string columnItem, string columnVal, string batchno)
        {
            return SqlHelpers.GetValue<string>(env, CommandFactory.GetBatch(tblname, getcolum, columnItem, columnVal, batchno));
        }
        public Int32 ResetPassword(string env, Int32 regid, string pwd, int uid, int pwdType, int sms, int changed)
        {
            return SqlHelpers.GetValue<int>(env, CommandFactory.ResetPassword(regid, pwd, uid, pwdType, sms, changed));
        }
        public DataTable InsBankStatement(string env, string action, DateTime stmdate, double Amount, string Description, string bank, DateTime date, string createdby, string sesid, string ipaddress, Int32 pageIndex, Int32 pageSize, string TranType)
        {
            return SqlHelpers.GetTable(env, CommandFactory.InsBankStatement(action, stmdate, Amount, Description, bank, date, createdby, sesid, ipaddress, pageIndex, pageSize, TranType));
        }
        public DataTable CompanyNotifications(string env, string type, Int32 regid, string gcmid, string subject, string message, string image, string url)
        {
            return SqlHelpers.GetTable(env, CommandFactory.CompanyNotifications(type, regid, gcmid, subject, message, image, url));
        }

        public DataTable KycReport(string env, string action, DateTime frmdate, DateTime todate, Int32 regid, Int32 pageIndex, Int32 pagesize, Int32 status)
        {
            return SqlHelpers.GetTable(env, CommandFactory.KycReport(action, frmdate, todate, regid, pageIndex, pagesize, status));
        }
        public DataTable KycPendingRpt(string env, string type, string ModuleType)
        {
            return SqlHelpers.GetTable(env, CommandFactory.KycPendingRpt(type, ModuleType));
        }
        public void ApproveKyc(string env, Int32 slno, Int32 apprej, string sesid, string remarks, Int32 apprejby, string type)
        {
            SqlHelpers.GetValue<int>(env, CommandFactory.ApproveKyc(slno, apprej, sesid, remarks, apprejby, type));
        }

        public DataTable RegistrationReport1(string env, string searchid, Int32 status, DateTime frmdate, DateTime todate, Int32 regid, Int32 stateid, Int32 pageIndex, Int32 pageSize, string val)
        {
            return SqlHelpers.GetTable(env, CommandFactory.RegistrationReport1(searchid, status, frmdate, todate,
                                                                               regid, stateid, pageIndex, pageSize,val));
        }
        public DataTable MemphotosReport(string env, string action, DateTime frmdate, DateTime todate, Int32 regid, Int32 pageIndex, Int32 pagesize)
        {
            return SqlHelpers.GetTable(env, CommandFactory.MemphotosReport(action, frmdate, todate, regid, pageIndex, pagesize));
        }
        public DataTable GetCount(string env, string mailid)
        {
            return SqlHelpers.GetTable(env, CommandFactory.GetCount(mailid));
        }
        public DataTable GetMails(string env, string mailid)
        {
            return SqlHelpers.GetTable(env, CommandFactory.GetMails(mailid));
        }
        public DataTable SearchMails(string env, string mailFrom, string mailTo)
        {
            return SqlHelpers.GetTable(env, CommandFactory.SearchMails(mailFrom, mailTo));
        }
        public string DeleteMail(string env, Int32 id)
        {
            return SqlHelpers.GetValue<string>(env, CommandFactory.DeleteMail(id));
        }
        public string GetAttch(string env, Int32 id)
        {
            return SqlHelpers.GetValue<string>(env, CommandFactory.GetAttch(id));
        }
        public int IsAttachExit(string env, Int32 id)
        {
            return SqlHelpers.GetValue<int>(env, CommandFactory.IsAttachExit(id));
        }
        public string GetBulkMessage(string env, Int32 id)
        {
            return SqlHelpers.GetValue<string>(env, CommandFactory.GetBulkMessage(id));
        }
        public DataTable GetBulkSubject(string env, Int32 id)
        {
            return SqlHelpers.GetTable(env, CommandFactory.GetBulkSubject(id));
        }
        public string GetMessage(string env, Int32 id)
        {
            return SqlHelpers.GetValue<string>(env, CommandFactory.GetMessage(id));
        }

        public string GetSubject(string env, Int32 id)
        {
            return SqlHelpers.GetValue<string>(env, CommandFactory.GetSubject(id));
        }

        public string GetMsgFrom(string env, Int32 id)
        {
            return SqlHelpers.GetValue<string>(env, CommandFactory.GetMsgFrom(id));
        }
        public string GetMsgTo(string env, Int32 id)
        {
            return SqlHelpers.GetValue<string>(env, CommandFactory.GetMsgTo(id));
        }
        public string GetMsgDate(string env, Int32 id)
        {
            return SqlHelpers.GetValue<string>(env, CommandFactory.GetMsgDate(id));
        }
        public DataTable GetDraftMsg(string env, Int32 id)
        {
            return SqlHelpers.GetTable(env, CommandFactory.GetDraftMsg(id));
        }
        public int ReplyMail(string env, string mailfrom, string mailto, string subject, string msg, DateTime sentdate, int savenSend, Int32 mailId, string repSubject, string file, string ReqNo, string Status)
        {
            return SqlHelpers.GetValue<int>(env, CommandFactory.ReplyMail(mailfrom, mailto, subject, msg, sentdate, savenSend, mailId, repSubject, file,ReqNo,Status));
        }
        public int SendMail(string env, string mailfrom, string mailto, string subject, string msg, DateTime sentdate, int savenSend, string file, string toType)
        {
            return SqlHelpers.GetValue<int>(env, CommandFactory.SendMail(mailfrom, mailto, subject, msg, sentdate, savenSend, file, toType));
        }
        public DataTable GetSentMails(string env, string mailId)
        {
            return SqlHelpers.GetTable(env, CommandFactory.GetSentMails(mailId));
        }
        public int DeleteSentMails(string env, Int32 mailId)
        {
            return SqlHelpers.GetValue<int>(env, CommandFactory.DeleteSentMails(mailId));
        }
        public int SendBulkMail(string env, string mailfrom, string subject, string msg, DateTime sentdate)
        {
            return SqlHelpers.GetValue<int>(env, CommandFactory.SendBulkMail(mailfrom, subject, msg, sentdate));
        }
        public DataTable GetBulkMails(string env)
        {
            return SqlHelpers.GetTable(env, CommandFactory.GetBulkMails());
        }
        public Int32 DeleteBulkMail(string env, Int32 mailId)
        {
            return SqlHelpers.GetValue<Int32>(env, CommandFactory.DeleteBulkMail(mailId));
        }
        public string CreateFolder(string env, string folderName, string memId)
        {
            return SqlHelpers.GetValue<string>(env, CommandFactory.CreateFolder(folderName, memId));
        }
        public DataTable GetFolderMailsMails(string env, string mailId, Int32 folderId)
        {
            return SqlHelpers.GetTable(env, CommandFactory.GetFolderMailsMails(mailId, folderId));
        }
        //29-02 Satish
        public DataTable Glance(string env, DateTime fromdate, DateTime todate, Int32 uid)
        {
            return SqlHelpers.GetTable(env, CommandFactory.Glance(fromdate, todate, uid));
        }

        public DataTable GlanceReportNew(string env, string action, string rpttype, DateTime fromdate, DateTime todate, Int32 mailto, Int32 sts, string searchby, Int32 pageindex, Int32 pagesize)
        {
            return SqlHelpers.GetTable(env, CommandFactory.GlanceReportNew(action, rpttype, fromdate, todate, mailto, sts, searchby, pageindex, pagesize));
        }

        public DataTable VATCSTReport(string env, string action, string idno, string billno, Int16 status, DateTime frmdate, DateTime todate, Int32 pageIndex, Int32 pageSize, Int32 month, Int32 year, Int32 month1, Int32 year1, string state)
        {
            return SqlHelpers.GetTable(env, CommandFactory.VATCSTReport(action, idno, billno, status, frmdate, todate, pageIndex, pageSize, month, year, month1, year1, state));
        }
        public DataTable GetRegions(string env, string search, string stype)
        {
            return SqlHelpers.GetTable(env, CommandFactory.GetRegions(search, stype));
        }
        public DataTable SalesReport(string env, DateTime frmdate, DateTime todate, string orderid, Int32 pageIndex, Int32 pageSize)
        {
            return SqlHelpers.GetTable(env, CommandFactory.SalesReport(frmdate, todate, orderid, pageIndex, pageSize));
        }
        //01-03 Satish
        public DataTable NewsRptNew(string env, string action, Int32 nid, string description, Int32 createdby, string ntype, string subject)
        {
            return SqlHelpers.GetTable(env, CommandFactory.NewsRptNew(action, nid, description, createdby, ntype, subject));
        }
        public DataTable FaqsRptNew(string env, string action, Int32 faqid, string qusetion, string answer, Int32 user, string sessid)
        {
            return SqlHelpers.GetTable(env, CommandFactory.FaqsRptNew(action, faqid, qusetion, answer, user, sessid));
        }
        public DataTable Downloadfiles(string env, string action, int sno, int status)
        {
            return SqlHelpers.GetTable(env, CommandFactory.Downloadfiles(action, sno, status));
        }
        public int InsertDownloadfiles(string env, string title, string filename, string uploadby, string sesid)
        {
            return SqlHelpers.GetValue<int>(env, CommandFactory.InsertDownloadfiles(title, filename, uploadby, sesid));
        }
        //02-03 Satsih
        public DataTable GetMailfoldersname(string env, string memid)
        {
            return SqlHelpers.GetTable(env, CommandFactory.GetMailfoldersname(memid));
        }
        public string InsertIntoFolder(string env, Int32 mailId, Int32 folderId)
        {
            return SqlHelpers.GetValue<string>(env, CommandFactory.InsertIntoFolder(mailId, folderId));
        }
        public string CheckSentID(string env, string to, string toid)
        {
            return SqlHelpers.GetValue<string>(env, CommandFactory.CheckSentID(to, toid));
        }
        public string GetSprDetails(string env, string id)
        {
            return SqlHelpers.GetValue<string>(env, CommandFactory.GetSprDetails(id));
        }
        public string MemberCheck(string env, string userId)
        {
            return SqlHelpers.GetValue<string>(env, CommandFactory.MemberCheck(userId));
        }
        public string VerifyLoginDetails(string env, string userId)
        {
            return SqlHelpers.GetValue<string>(env, CommandFactory.VerifyLoginDetails(userId));
        }
        public DataTable UnilevelTreeIdDet(string env, string userId)
        {
            return SqlHelpers.GetTable(env, CommandFactory.UnilevelTreeIdDet(userId));
        }
        public DataTable Unilvltree(string env, string userId)
        {
            return SqlHelpers.GetTable(env, CommandFactory.Unilvltree(userId));
        }

        public DataTable CreditReqPending(string env)
        {
            return SqlHelpers.GetTable(env, CommandFactory.CreditReqPending());
        }
        public DataTable GetCreditreq(string env, string reqcode)
        {
            return SqlHelpers.GetTable(env, CommandFactory.GetCreditreq(reqcode));
        }
        public void AppRejCreditRqt(string env, string reqcode, int apprej, Int32 user, string sessid, string remarks)
        {
            SqlHelpers.GetValue<int>(env, CommandFactory.AppRejCreditRqt(reqcode, apprej, user, sessid, remarks));
        }
        public DataTable GetCreditReqRpt(string env, int reqstatus, int cbank, DateTime frmdate, DateTime todate, Int32 regid, Int32 pageIndex, Int32 pagesize)
        {
            return SqlHelpers.GetTable(env, CommandFactory.GetCreditReqRpt(reqstatus, cbank, frmdate, todate, regid, pageIndex, pagesize));
        }
        //rk
        public DataTable UsedCouponsRpt(string env, DateTime frmdate, DateTime todate, Int32 regid, Int32 pageIndex, Int32 pagesize)
        {
            return SqlHelpers.GetTable(env, CommandFactory.UsedCouponsRpt(frmdate, todate, regid, pageIndex, pagesize));
        }
        public DataTable MemberRpOrders(string env, Int32 regid, Int32 rpstatus, Int32 pageindex, Int32 pagesize, string Action)
        {
            return SqlHelpers.GetTable(env, CommandFactory.MemberRpOrders(regid, rpstatus, pageindex, pagesize, Action));
        }
        public DataSet Reg_OrderNo_Check(string env, string RefNo, string Fcode, string ReceiptType)
        {
            return SqlHelpers.GetDataSet(env, CommandFactory.Reg_OrderNo_Check(RefNo, Fcode, ReceiptType));
        }
        public DataSet GetFeedbacks(string env)
        {
            return SqlHelpers.GetDataSet(env, CommandFactory.GetFeedbacks());
        }
        //Modified by suresh on 13/5
        public DataTable AppConsultMOP(string env, string action, Int64 Regid, string mop, double amount, string refno, string refbank, string refbranch, DateTime refDate, string remarks, string orderno, int AppConsultMOP)
        {
            return SqlHelpers.GetTable(env, CommandFactory.AppConsultMOP(action, Regid, mop, amount, refno, refbank, refbranch, refDate, remarks, orderno, AppConsultMOP));
        }
        public DataTable InsertBatchOutSms(string env, Int32 regid, string Mobile, string msg, string sessid)
        {
            return SqlHelpers.GetTable(env, CommandFactory.InsertBatchOutSms(regid, Mobile, msg, sessid));
        }
        //14/03 satish
        public DataTable FaqsReport(string env, string Type, DateTime Fromdate, DateTime Todate, int Pagesize, int PageIndex)
        {
            return SqlHelpers.GetTable(env, CommandFactory.FaqsReport(Type, Fromdate, Todate, Pagesize, PageIndex));
        }

        //16/03 Satish
        public DataTable OfferPopup(string env, string action, string Title, String Subject, string Image, string Description, int Uid, DateTime Exp, int SNo)
        {
            return SqlHelpers.GetTable(env, CommandFactory.OfferPopup(action, Title, Subject, Image, Description, Uid, Exp, SNo));
        }

        //17/03 Satish
        public DataTable GetTreeTooltip(string env, string membid)
        {
            return SqlHelpers.GetTable(env, CommandFactory.GetTreeTooltip(membid));
        }
        public DataSet TreeView(string env, string id)
        {
            return SqlHelpers.GetDataSet(env, CommandFactory.TreeView(id));
        }
        public DataSet chkmemdown(string env, string id, string down)
        {
            return SqlHelpers.GetDataSet(env, CommandFactory.chkmemdown(id, down));
        }
        public DataTable GetMemberDetails(string env, string Idno, String strType)
        {
            return SqlHelpers.GetTable(env, CommandFactory.GetMemberDetails(Idno, strType));
        }
        public int insertsmslog(string env, Int64 regid, string mobile, DateTime senddate, string message, string action, string sessid, string SMSType)
        {
            return SqlHelpers.GetValue<int>(env, CommandFactory.insertsmslog(regid, mobile, senddate, message, action, sessid, SMSType));
        }

        public DataTable Newslog(string env, String Action, int Nlid, int Nid, int Regid, int Nread, DateTime CreatedDate, String sesid, int status)
        {
            return SqlHelpers.GetTable(env, CommandFactory.Newslog(Action, Nlid, Nid, Regid, Nread, CreatedDate, sesid, status));
        }
        public DataTable GetBulkMailCount(string env, int MRead, string MStatus)
        {
            return SqlHelpers.GetTable(env, CommandFactory.GetBulkMailCount(MRead, MStatus));
        }
        public DataTable UnilevelTreeDet(string env, string userId)
        {
            return SqlHelpers.GetTable(env, CommandFactory.UnilevelTreeDet(userId));
        }
        public DataTable Unilvltrees(string env, string idno, int first, int end)
        {
            return SqlHelpers.GetTable(env, CommandFactory.Unilvltrees(idno, first, end));
        }
        public DataTable ApproveCustomerOrder(string env, string action, Int32 slno, Int32 apprej, string sesid, string remarks, Int32 apprejby)
        {
            return SqlHelpers.GetTable(env, CommandFactory.ApproveCustomerOrder(  action,  slno,  apprej,  sesid,  remarks,  apprejby));
        }
        public DataTable RegistrationReport1onlinesucc(string env, string searchid, DateTime frmdate, DateTime todate, Int32 pageIndex, Int32 pageSize, string pgtype)
        {
            return SqlHelpers.GetTable(env, CommandFactory.RegistrationReport1onlinesucc(searchid, frmdate, todate, pageIndex, pageSize, pgtype));
        }
        public DataTable RegistrationReport1onlinefail(string env, DateTime frmdate, DateTime todate, Int32 pageIndex, Int32 pageSize)
        {
            return SqlHelpers.GetTable(env, CommandFactory.RegistrationReport1onlinefail(frmdate, todate, pageIndex, pageSize));
        }
        public DataTable Boostertrees(string env, string action, string idno, int first, int end)
        {
            return SqlHelpers.GetTable(env, CommandFactory.Boostertrees(action, idno, first, end));
        }
        public DataTable BoosterTreeIdDet(string env, string action, string userId)
        {
            return SqlHelpers.GetTable(env, CommandFactory.BoosterTreeIdDet(action,userId));
        }
        public DataTable GetApprovePoDetailes(string env, Int32 payno)
        {
            return SqlHelpers.GetTable(env, CommandFactory.GetApprovePoDetailes(payno));
        }
        public DataTable PayoutApprove(string env, Int32 payno, Int32 uid, string sessid)
        {
            return SqlHelpers.GetTable(env, CommandFactory.PayoutApprove(payno, uid, sessid));
        }
        public DataTable SICPPayoutApprove(string env,string action, Int32 payno, Int32 uid, string sessid)
        {
            return SqlHelpers.GetTable(env, CommandFactory.SICPPayoutApprove(action,payno, uid, sessid));
        }
        public DataSet BainaryTrackReport(string env, Int32 regid)
        {
            return SqlHelpers.GetDataSet(env, CommandFactory.BainaryTrackReport(regid));
        }
        public DataTable Steps(string env, string OrbitNo, int OrbitStage, int PayNo)
        {
            return SqlHelpers.GetTable(env, CommandFactory.Steps(OrbitNo, OrbitStage, PayNo));
        }
        public DataTable GetBinaryAnalysis(string env, Int32 pageIndex, Int32 pageSize)
        {
            return SqlHelpers.GetTable(env, CommandFactory.GetBinaryAnalysis(pageIndex, pageSize));
        }
        public DataTable SCReport1onlinesucc(string env, string searchid, DateTime frmdate, DateTime todate, Int32 pageIndex, Int32 pageSize, string pgtype)
        {
            return SqlHelpers.GetTable(env, CommandFactory.SCReport1onlinesucc(searchid, frmdate, todate, pageIndex, pageSize, pgtype));
        }
        public DataTable SCReport1onlinefail(string env, DateTime frmdate, DateTime todate, Int32 pageIndex, Int32 pageSize)
        {
            return SqlHelpers.GetTable(env, CommandFactory.SCReport1onlinefail(frmdate, todate, pageIndex, pageSize));
        }
        public DataTable CreditRequestReport1onlinesucc(string env, string searchid, DateTime frmdate, DateTime todate, Int32 pageIndex, Int32 pageSize, string pgtype)
        {
            return SqlHelpers.GetTable(env, CommandFactory.CreditRequestReport1onlinesucc(searchid, frmdate, todate, pageIndex, pageSize, pgtype));
        }
        public DataTable CreditRequestReport1onlinefail(string env, DateTime frmdate, DateTime todate, Int32 pageIndex, Int32 pageSize)
        {
            return SqlHelpers.GetTable(env, CommandFactory.CreditRequestReport1onlinefail(frmdate, todate, pageIndex, pageSize));
        }

        public DataTable SSMPPayoutProcess(string env, string action, Int32 Uid, string Sessid, string Remarks,Int32 payno)
        {
            return SqlHelpers.GetTable(env, CommandFactory.SSMPPayoutProcess(action, Uid, Sessid, Remarks,payno));
        }

        public DataTable SICPPayoutProcess(string env, string action, Int32 Uid, string Sessid, string Remarks)
        {
            return SqlHelpers.GetTable(env, CommandFactory.SICPPayoutProcess(action, Uid, Sessid, Remarks));
        }

        public DataTable SSMPRewards(string env,  Int32 regid)
        {
            return SqlHelpers.GetTable(env, CommandFactory.SSMPRewards(regid));
        }
        public DataTable ApprovePaymentrpt(string env, string action,string Ordertype, string Paymenttype, String SBOID, DateTime fromdate, DateTime todate, Int32 pageIndex, Int32 pageSize)
        {
            return SqlHelpers.GetTable(env, CommandFactory.ApprovePaymentrpt(action,Ordertype, Paymenttype, SBOID, fromdate, todate, pageIndex, pageSize));
        }
        public DataTable PendingGatewayOrdersRpt(string env, string action, DateTime fromdate, DateTime todate, Int32 pageIndex, Int32 pageSize)
        {
            return SqlHelpers.GetTable(env, CommandFactory.PendingGatewayOrdersRpt(action, fromdate, todate, pageIndex, pageSize));
        }
        public DataTable TDSRpt(string env, string action, Int32 payno, String regid, string type, string mnths, string yrs, Int32 PageIndex, Int32 PageSize)
        {
            return SqlHelpers.GetTable(env, CommandFactory.TDSRpt(action, payno, regid, type, mnths, yrs, PageIndex, PageSize));
        }
        public DataTable BusinessStatsRpt(string env, string action, string state, string district, string SBOID, string Packcode, string Pcode, string Sts, string Plantype, DateTime fromdate, DateTime todate, Int32 pageIndex, Int32 pageSize)
        {
            return SqlHelpers.GetTable(env, CommandFactory.BusinessStatsRpt(action, state, district, SBOID, Packcode, Pcode, Sts, Plantype, fromdate, todate, pageIndex, pageSize));
        }
        public DataTable GetReport(string env, string action, string Type, Int32 payno, string regid, DateTime frmdate, DateTime todate, Int32 pageindex, Int32 pagesize)
        {
            return SqlHelpers.GetTable(env, CommandFactory.GetReport(action, Type, payno, regid, frmdate, todate, pageindex, pagesize));
        }
        public DataTable GetRegFields(string env, string action, string fname1, string lname1, string dob1, string careof1, string mobile1, string eMail1)
        {
            return SqlHelpers.GetTable(env, CommandFactory.GetRegFields(action, fname1, lname1, dob1, careof1, mobile1, eMail1));
        }
        public DataTable UpdateDuplicateIdsRpt(string env, int regid, string remarks, int uid, string sesid, string ipaddress)
        {
            return SqlHelpers.GetTable(env, CommandFactory.UpdateDuplicateIdsRpt(regid, remarks, uid, sesid, ipaddress));
        }

        public DataTable GetMinRegIdDuplicateIdsRpt(string env, string Fname, string Lname, string UserName, DateTime dob, string Mobile, string Email)
        {
            return SqlHelpers.GetTable(env, CommandFactory.GetMinRegIdDuplicateIdsRpt(Fname, Lname, UserName, dob, Mobile, Email));
        }

        public DataTable BusinessReport(string env, string action, string type, Int32 pageIndex, Int32 pageSize)
        {
            return SqlHelpers.GetTableWithHugeTime(env, CommandFactory.BusinessReport(action,type, pageIndex, pageSize), 120);
        }

        public DataTable DateWiseBusinessReport(string env, string action, string type,DateTime date, Int32 pageIndex, Int32 pageSize)
        {
            return SqlHelpers.GetTable(env, CommandFactory.DateWiseBusinessReport(action, type,date, pageIndex, pageSize));
        }

        public DataTable NewsSubcription_Log(string env, string action, Int32 NSLId, string Subject, string Body, string UploadFile, Int32 Status, Int32 uid, string sesid, Int32 pageindex, Int32 pagesize)
        {
            return SqlHelpers.GetTable(env, CommandFactory.NewsSubcription_Log(action, NSLId, Subject, Body, UploadFile, Status, uid, sesid,pageindex, pagesize));
        }

        public DataTable DespNewsLetter(string env, string action, string EmailId, string Subject, string Body, string UploadFile, string sesid, string IPaddress)
        {
            return SqlHelpers.GetTable(env, CommandFactory.DespNewsLetter(action, EmailId, Subject, Body, UploadFile, sesid, IPaddress));
        }

        public DataTable CheckDownto(string env,string action, string idno, string downto)
        {
            return SqlHelpers.GetTable(env, CommandFactory.CheckDownto(action,idno, downto));
        }
        
        public DataTable UpdateUnSuccessfulPGTranRpt(string env, string CCRemarks, string ORDER_ID, int UpdatedBy)
        {
            return SqlHelpers.GetTable(env, CommandFactory.UpdateUnSuccessfulPGTranRpt(CCRemarks, ORDER_ID, UpdatedBy));
        }

        public DataSet GetRewardsReport(string env, string action, string Type, Int32 payno, string regid, DateTime frmdate, DateTime todate, Int32 pageindex, Int32 pagesize)
        {
            return SqlHelpers.GetDataSet(env, CommandFactory.GetRewardsReport(action, Type, payno, regid, frmdate, todate, pageindex, pagesize));
        }
        public int MobileAppsmslog(string env, Int64 regid, string mobile, DateTime senddate, string message, string action, string sessid, string SMSType)
        {
            return SqlHelpers.GetValue<int>(env, CommandFactory.MobileAppsmslog(regid, mobile, senddate, message, action, sessid, SMSType));
        }
        public int OfferCreate(string env, string action, string type, string pcode, string Itemid, string offName, Int32 noofcupons, DateTime frmdate, DateTime todate, string sessid, string ipaddress, Int32 createdby, string Remarks, int Status,
           Int32 NoofCoupCnts, Int32 txtcuponval1, Int32 MinValue1, Int32 MaxValue1, Int32 txtcuponval2, Int32 MinValue2, Int32 MaxValue2, Int32 txtcuponval3, Int32 MinValue3, Int32 MaxValue3,
            Int32 txtcuponval4, Int32 MinValue4, Int32 MaxValue4, Int32 txtcuponval5, Int32 MinValue5, Int32 MaxValue5)
        {
            return SqlHelpers.GetValue<int>(env, CommandFactory.OfferCreate(action, type, pcode, Itemid, offName, noofcupons, frmdate, todate, sessid, ipaddress, createdby, Remarks, Status,
                NoofCoupCnts, txtcuponval1, MinValue1, MaxValue1, txtcuponval2, MinValue2, MaxValue2, txtcuponval3, MinValue3, MaxValue3, txtcuponval4, MinValue4, MaxValue4, txtcuponval5, MinValue5, MaxValue5));
        }

        public DataTable OfferReport(string env, string Action, string Offname, DateTime frmdate, DateTime todate, Int32 pageIndex, Int32 pageSize, string Type)
        {
            return SqlHelpers.GetTable(env, CommandFactory.OfferReport( Action, Offname, frmdate, todate, pageIndex, pageSize, Type));
        }

        public DataTable MobileSlides(string env, string Action, string CreatedBy, string SessId, string IpAdd, string ImgName, Int32 OrderNo)
        {
            return SqlHelpers.GetTable(env, CommandFactory.MobileSlides(Action,CreatedBy,SessId,IpAdd,ImgName,OrderNo));
        }

        public DataTable ClickAndShare(string env, string Action, Int32 id, string CreatedBy, string Description, string Status, string ImgName, string SessId, string IpAdd)
        {
            return SqlHelpers.GetTable(env, CommandFactory.ClickAndShare(Action, id, CreatedBy, Description, Status, ImgName, SessId, IpAdd));
        }

        public int CreateWalletOffer(string env, string action, string OfferCode, string pcode, string offName, string OffType, Double WalletValue, Int32 Pid, DateTime frmdate, DateTime todate, string sessid, string ipaddress, Int32 createdby, string Remarks, int Status)
        {
            return SqlHelpers.GetValue<int>(env, CommandFactory.CreateWalletOffer(action, OfferCode, pcode, offName, OffType, WalletValue, Pid, frmdate, todate, sessid, ipaddress, createdby, Remarks, Status));
        }

        public DataSet DayStatisticsRpt(string env, string action, string Type,string regid)
        {
            return SqlHelpers.GetDataSet(env, CommandFactory.DayStatisticsRpt(action, Type, regid));
        }

        public DataTable Stockreturn(string env, string Action, string billno, string Refno, Int32 type, DateTime frmdate, DateTime todate, Int32 pageIndex, Int32 pageSize, string ssid, string remarks)
        {
            return SqlHelpers.GetTable(env, CommandFactory.Stockreturn(Action, billno, Refno, type, frmdate, todate, pageIndex, pageSize, ssid, remarks));
        }

        public DataTable GVDInstalPayment(string env, string Action,string UnqId,string billno, Int32 Regid, Int32 pid,string MOP,double PayAmt, string ssid, string remarks)
        {
            return SqlHelpers.GetTable(env, CommandFactory.GVDInstalPayment(Action, UnqId, billno, Regid,pid,MOP,PayAmt, ssid, remarks));
        }
        public DataTable GVDFullPayment(string env, string Action, string UnqId, string billno, Int32 Regid, Int32 pid, string MOP, double PayAmt, string ssid, string remarks, string DDno, string ddbank, string ddbranch, DateTime dddate, string mobile, string add1, string city, string district, string states, string pin)
        {
            return SqlHelpers.GetTable(env, CommandFactory.GVDFullPayment(Action, UnqId, billno, Regid, pid, MOP, PayAmt, ssid, remarks, DDno, ddbank, ddbranch, dddate, mobile, add1, city, district, states, pin));
        }
        public DataTable GetMemMails(string env, string Action, string Reqno, Int32 Regid, Int32 id, string Type)
        {
            return SqlHelpers.GetTable(env, CommandFactory.GetMemMails(Action, Reqno, Regid, id, Type));
        }

        #region Franchisee

        public DataSet InsertFranchise(string env, string FCCode, string FranchiseName, string Address1, string Address2, string city, string state, string Email, string Status, string CreatedBy, DateTime CreatedDate, string Phone, string stkLimit, string JoinAmt, string CompanyName, string UserName, string Password, string Bank, string AccNo, string IFSC, string BankAddress, string type, string tinno, string GST)
        {
            return SqlHelpers.GetDataSet(env, CommandFactory.InsertFranchise(FCCode, FranchiseName, Address1, Address2, city, state, Email, Status, CreatedBy, CreatedDate, Phone, stkLimit, JoinAmt, CompanyName, UserName, Password, Bank, AccNo, IFSC, BankAddress, type, tinno, GST));
        }

        public DataSet GetFCcode(string env, string Action)
        {
            return SqlHelpers.GetDataSet(env, CommandFactory.GetFCcode(Action));
        }

        public DataSet ExistFranchiseIdno(string env, string idno)
        {
            return SqlHelpers.GetDataSet(env, CommandFactory.ExistFranchiseIdno(idno));
        }

        public DataSet Editfranchise(string env, string FCCode)
        {
            return SqlHelpers.GetDataSet(env, CommandFactory.Editfranchise(FCCode));
        }

        public DataTable FCPLogin(string env, string username, string password)
        {
            return SqlHelpers.GetTable(env, CommandFactory.FCPLogin(username, password));
        }
        public DataTable TempStockOrder_FCP(string env, string action, string UNQId, string pcode, string ItemCode, string Attribute, string Qty, string Item)
        {
            return SqlHelpers.GetTable(env, CommandFactory.TempStockOrder_FCP(action, UNQId, pcode, ItemCode, Attribute, Qty, Item));
        }
        public DataTable StockOrder_FCP(string env, string action, string Id, string remarks, string Sessid, string UID)
        {
            return SqlHelpers.GetTable(env, CommandFactory.StockOrder_FCP(action, Id, remarks, Sessid, UID));
        }
        public DataTable StockOrderReport_FCP(string env, string action, string Id, DateTime frmdate, DateTime todate, Int32 pageIndex, Int32 pageSize)
        {
            return SqlHelpers.GetTable(env, CommandFactory.StockOrderReport_FCP(action, Id, frmdate, todate, pageIndex, pageSize));

        }
        public DataTable ApprovedStockOrder_FCP(string env, string action, string orderrefid, string fcode, string pcode, string qty, string sessionid, string SesUser, string dmode, string modname, string modno, string moddate, string modremarks, string VehicleNo)
        {
            return SqlHelpers.GetTable(env, CommandFactory.ApprovedStockOrder_FCP(action, orderrefid, fcode, pcode, qty, sessionid, SesUser, dmode, modname, modno, moddate, modremarks, VehicleNo));
        }
        public DataTable MakeFCPCreditRequest(string env,string fcode, double reqAmt, string mop, string refno, DateTime date,string invbank, string invbranch, string VarcharNo, DateTime cdate,string depbank, string depbranch, string depcity, DateTime depdate, string depslip,string remarks)
        {
            return SqlHelpers.GetTable(env, CommandFactory.MakeFCPCreditRequest(fcode, reqAmt, mop, refno, date, invbank, invbranch, VarcharNo, cdate, depbank, depbranch, depcity, depdate, depslip, remarks));
        }
        public DataTable GetFCPCreditReqRpt(string env, int reqstatus, DateTime frmdate, DateTime todate, string fcode, Int32 pageIndex, Int32 pagesize,string reqcode,string action)
        {
            return SqlHelpers.GetTable(env, CommandFactory.GetFCPCreditReqRpt(reqstatus, frmdate, todate, fcode, pageIndex, pagesize, reqcode,action));
        }
        public DataTable TempRepOrder_FCP(string env, string action, string UNQId, string pcode, string ItemCode, string Attribute, string Qty, string Item, string Fcode)
        {
            return SqlHelpers.GetTable(env, CommandFactory.TempRepOrder_FCP(action, UNQId, pcode, ItemCode, Attribute, Qty, Item, Fcode));
        }
        public DataTable ScOrder_FCP(string env, string UNQId, Int32 regid, Int32 downlineid, string mop, string mopamt, string Fname, string LName, string Mobile, string Address, string City, string District, string state, string PiCode, string ordertype, string shpchrg, string scmemtype, string sesid, string ipadd, string Fcode)
        {
            return SqlHelpers.GetTable(env, CommandFactory.ScOrder_FCP(UNQId, regid, downlineid, mop, mopamt, Fname, LName, Mobile, Address, City, District, state, PiCode, ordertype, shpchrg, scmemtype, sesid, ipadd, Fcode));
        }

        public int GetAvlQtyforStockAdj_FCP(string env, string action, string itemcode, string Fcode)
        {
            return SqlHelpers.GetValue<int>(env, CommandFactory.GetAvlQtyforStockAdj_FCP(action, itemcode, Fcode));
        }
        public DataTable FCPGlance(string env, DateTime date, string user)
        {
            return SqlHelpers.GetTable(env, CommandFactory.FCPGlance(date, user));
        }
        public DataTable GlanceReport_FCP(string env, string action, string rpttype, DateTime ondate, string username, string sts, string searchby, Int32 pageindex, Int32 pagesize)
        {
            return SqlHelpers.GetTable(env, CommandFactory.GlanceReport_FCP(action, rpttype, ondate, username, sts, searchby, pageindex, pagesize));
        }
        #endregion

    }
}
