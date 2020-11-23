using System;
using System.Data;

// ReSharper disable CheckNamespace
namespace SarsoBizDal
// ReSharper restore CheckNamespace
{
    public interface IAdminModule
    {
        DataTable AdminLogin(string env, string username, string password);

        void CodeErrors(string env, string userid, string pageurl, string errorMsg, string sesid);

        void SessionsInOut(string env, string action, Int32 uid, string sesid, string ipaddress, string systemname,
                           string usertype);

        DataTable CurrlastloginTime(string env, Int32 loginid, string sesid, string usertype);

        DataTable MainLinks(string env, int uid, string usertype);

        DataTable Sublinks(string env, int lid, int uid, string usertype);

        DataTable LinksPremission(string env, int lid, int uid, string usertype);

        int SublinksPermissions(string env, string lids, Int32 itemid, Int32 uid, string sesid, string usertype);

        DataTable Users(string env, string action, int itemid);

        int InupUsers(string env, string action, int itemId, string userName, string passWord, string name,
                      string doorno, string lane, string streat, string city, string state,
                      string contactName, string contactPhone, string email, int uid,
                      string sesid, string ipaddress, int flag);

        int DelUsers(string env, int itemid, int uid);

        int ChangePassword(string env, string action, int itemid, string pwd, int uid);

        string GetValue(string env, string tblname, string getcolum, string columnItem, string itemId);

        DataTable GetData(string env, string tblname, string columnItem, string itemId);

        DataTable UsersLogRpt(string env, DateTime frmdate, DateTime todate, Int32 user, Int32 pageIndex, Int32 pageSize, string usertype);

        int AddCompanyBanks(string env, string action, int cbId, string bank, string branch, string accno, string ifsc,
                            string city, string state,
                            int cbStatus, string createdBy, string sesid);

        DataTable GetCompanyBanks(string env, int cbId);

        DataTable MemberSearch(string env, string key, string style, string keyWords,
                               string sortby, Int32 pageIndex, Int32 pageSize);

        DataTable RegistrationReport(string env, string action, string plantype, DateTime frmdate,
                                     DateTime todate, Int64 regid, Int32 pageIndex, Int32 pageSize);

        DataTable GetPackages(string env, string action);

        DataTable DrcDetails(string env);

        int UpDrcDetails(string env, Int32 pid, string postEwallet, double drcAmt);


        DataTable PairsReport(string env, DateTime frmdate, DateTime todate, Int64 regid, Int32 pageIndex,
                              Int32 pageSize);

        DataTable BlockIdorBlockToPaidRpt(string env, string action, DateTime frmdate, DateTime todate, Int32 pageIndex,
                                         Int32 pageSize);

        DataTable FeedbackRpt(string env, string action, string idno, string name, string city, string state, string email, string subject,
                                        string msg, string status, Int32 createdby, DateTime createddate, string plantype, Int32 pageIndex, Int32 pageSize);

        DataTable NewsRpt(string env, string action, string description, string status, Int32 createdby, DateTime createddate, Int32 updatedby,
                                        DateTime updateddate, string plantype, Int32 pageIndex, Int32 pageSize);

        DataTable SeminarRpt(string env, string action, string titile, string venue, DateTime date, string time, string city, string state, string vleader,
            string phoneno, string status, DateTime createddate, int createdby, int updatedby, DateTime updateddate, string plantype, Int32 pageIndex, Int32 pageSize);

        DataSet FaqsRpt(string env, string action, string qusetion, string answer, string catageory, string catageoryname, string user,
                           string status, string sessid, string plantype, Int32 pageIndex, Int32 pageSize);

        DataTable FaqsCategorys(string env, string action);

        DataTable MemberBankSlipsRpt(string env, int sts, Int32 pageIndex, Int32 pageSize);

        DataTable MemberBankSlipsforAppRej(string env, Int32 regid, DateTime fromdate, DateTime todate, Int32 pageIndex,
                                           Int32 pageSize);

        void AppRejBankSlips(string env, string slnos, int sts, string sesid, string ipadd, Int32 uid);

        DataTable CstCollectionRpt(string env, string action, DateTime fromdate, DateTime todate, Int32 pageIndex, Int32 pageSize);

        DataTable VatCollectionRpt(string env, string action, DateTime fromdate, DateTime todate, Int32 pageIndex, Int32 pageSize);

        DataTable LboActivationRpt(string env, string action, int regid, DateTime fromdate, DateTime todate, Int32 pageIndex, Int32 pageSize);

        DataTable ProductSalesRpt(string env, string action, int regid, DateTime fromdate, DateTime todate, Int32 pageIndex, Int32 pageSize);


        DataTable RepurchaseSalesRpt(string env, string action, int regid, DateTime fromdate, DateTime todate, Int32 pageIndex, Int32 pageSize);

        DataTable RepurchaseVochersRpt(string env, string action, int regid, DateTime fromdate, DateTime todate, Int32 pageIndex, Int32 pageSize);

        DataTable MobileRechargeRpt(string env, string action, int regid, DateTime fromdate, DateTime todate, Int32 pageIndex, Int32 pageSize);

        DataTable NonRpLbosRpt(string env, string action, DateTime fromdate, DateTime todate, Int32 pageIndex, Int32 pageSize);

        DataTable TopMembersRpt(string env, string action, int stateid, Int32 pageIndex, Int32 pageSize);

        DataTable CityWiseRpt(string env, string action, string city, Int32 pageIndex, Int32 pageSize);

        DataTable RepurVocherValidityExtenRpt(string env, string action, int regid, DateTime fromdate, DateTime todate, Int32 pageIndex, Int32 pageSize);

        DataTable PackageWiseRpt(string env, string action, string month, Int32 pageIndex, Int32 pageSize);

        DataTable SmsLogRpt(string env, string action, DateTime fromdate, DateTime todate, Int32 pageIndex, Int32 pageSize);

        DataTable PayoutSmsRpt(string env, string action, Int32 pageIndex, Int32 pageSize);

        DataTable ShoppingReqRpt(string env, string action, DateTime fromdate, DateTime todate, Int32 pageIndex, Int32 pageSize);

        DataTable CreditReqRpt(string env, string action, Int32 pageIndex, Int32 pageSize);

        DataTable CreditSummaryRpt(string env, string action, string fcode, Int32 pageIndex, Int32 pageSize);

        DataTable StockReturnsRpt(string env, string action, Int32 pageIndex, Int32 pageSize);

        DataTable FranchiseBalancesRpt(string env, string action, Int32 pageIndex, Int32 pageSize);

        DataTable FranchiseCommissionRpt(string env, string action, string fcode, Int32 pageIndex, Int32 pageSize);

        DataTable FranchiseSalesCommRpt(string env, string action, string commtype, DateTime fromdate, DateTime todate,
            string fcode, Int32 pageIndex, Int32 pageSize);

        DataTable LifeisClubMemRpt(string env, string action, string membership, DateTime fromdate, DateTime todate,
            int regid, Int32 pageIndex, Int32 pageSize);

        DataTable LifeisClubAchieversRpt(string env, string action, string membership, DateTime fromdate, DateTime todate,
            int regid, Int32 pageIndex, Int32 pageSize);

        DataTable LeadershipIncentivesRpt(string env, string action, int payoutno, int regid, Int32 pageIndex, Int32 pageSize);

        DataTable WithdrawlPendingReqRpt(string env, string action, Int32 pageIndex, Int32 pageSize);

        string WithdrawlPendingReq(string env, string reqids, string sesid);

        DataTable WithdrawlBatchRpt(string env, string action, Int32 pageIndex, Int32 pageSize);

        DataTable ProductAnalasysRpt(string env, string action, DateTime startdate, Int32 pageIndex, Int32 pageSize);

        DataTable DistributionAnalasysRpt(string env, string action, DateTime startdate, Int32 pageIndex, Int32 pageSize);

        DataTable ActiveInactiveRpt(string env, DateTime fromdate, DateTime todate, Int32 regid, int stateid,
                                    Int32 pageIndex, Int32 pageSize);

        DataTable LiisBinary(string env, Int32 regid);

        DataTable LiisBinaryInDet(string env, Int32 regid, Int32 payno);

        DataTable InvoicesRpt(string env, string invFrom, string invType, DateTime fromdate, DateTime todate,
                              Int32 pageIndex, Int32 pageSize);

        DataTable InvoicesRptAll(string env, string action, string idno, string billno, DateTime fromdate, DateTime todate, Int32 pageIndex, Int32 pageSize);

        DataTable AppRejMemProfRpt(string env, string action, Int32 regid, DateTime fromdate, DateTime todate,
                                   Int32 pageIndex, Int32 pageSize);


        DataTable MemphotosforAppRej(string env, string action, Int32 regid, DateTime fromdate, DateTime todate,
                                     Int32 pageIndex, Int32 pageSize);

        void AppRejMemDetailes(string env, string action, Int32 slno, int status, int byuser, string remarks);

        void AppRejMemPhotos(string env, Int32 slno, Int32 status, Int32 byuser, string action, string Remarks);

        DataTable ChkMobRchTransactionNo(string env, string tranno);

        DataTable UpdateMobRchTransactionNo(string env, string tranno, string sesid, string appby);

        DataTable SpeedGlance(string env, DateTime ondate, string username);

        DataTable GlanceReport(string env, string action, string type, DateTime ondate, string username);

        void Cleartmpsms(string env, string sesid);

        DataTable InsertResendSmsIds(string env, Int32 regid, string sesid);

        void InsertResendSms(string env, string sesid);

        DataTable InsertNonMemsmsIds(string env, string name, string mobile, string sesid);

        void InsertNonMemSms(string env, string sesid, string msg);

        DataTable SmsLog(string env, string action, DateTime fromdate, DateTime todate, Int32 pageIndex, Int32 pageSize);

        DataTable GetSmsActions(string env);

        void ResendSms(string env, string sesid);

        DataTable MemberSms(string env, string sesid, string msg);

        void InsertMemberSms(string env, string sesid, string msg);

        DataTable BulkSms(string env, string stateid, string city, string msg, string sesid);

        void InsertBulkSms(string env, string stateid, string city, string msg, string sesid);

        DataTable GetMemforBirthdaysms(string env);

        DataTable BirthdaySms(string env);

        void InsertBirthdaySms(string env, string msg, string sesid);

        DataTable GetMemforPayoutsms(string env, Int32 payno);

        DataTable PayoutSms(string env, string idnos, Int16 payno, string sesid);

        void InsertPayoutSms(string env, string idnos, Int16 payno, string sesid);

        DataSet Invoices(string env, string action, string billno);

        DataTable WithdrawlBatchExcel(string env, string wdno);

        DataTable GetVouchers(string env, string action, Int32 regid, string sfcpCode, string sesid);

        DataSet ShoppingRequests(string env, int sts, Int32 pageindex, Int32 pagesize, DateTime fromdate, DateTime todate);

        string ShoppingRequestReject(string env, string reqno, string remarks, string sesid, Int32 uid);

        string ShoppingRequestApprove(string env, string reqno, double billamount, string mop, string tranno,
                                      string tranbank, string tranbranch, DateTime trandate,
                                      string remarks, string sesid, Int32 uid);

        DataTable CrocrepatiRewardReport(string env, int reward, Int32 regid, Int32 payno, Int32 pageindex,
                                         Int32 pagesize);

        DataTable BigBossRewardReport(string env, int reward, Int32 pageindex, Int32 pagesize);

        DataTable BigBossRequestsRpt(string env, string sts, DateTime fromdate, DateTime todate, Int32 regid,
                                     Int32 pageIndex, Int32 pageSize);

        string BigBossReqAppRej(string env, Int32 sno, string sts, string remarks, Int32 uid, string sesid);

        DataSet PkgPrdMonthWiseCnt(string env, string month);

        string GetBatch(string env, string tblname, string getcolum, string columnItem, string columnVal, string batchno);

        Int32 ResetPassword(string env, Int32 regid, string pwd, int uid, int pwdType, int sms, int changed);

        DataTable InsBankStatement(string env, string action, DateTime stmdate, double Amount, string Description, string bank, DateTime date, string createdby, string sesid, string ipaddress, Int32 pageIndex, Int32 pageSize, string TranType);

        DataTable CompanyNotifications(string env, string type, Int32 regid, string gcmid, string subject, string message, string image, string url);

        DataTable KycReport(string env, string action, DateTime frmdate, DateTime todate, Int32 regid, Int32 pageIndex, Int32 pagesize, Int32 status);

        DataTable KycPendingRpt(string env, string type, string ModuleType);

        void ApproveKyc(string env, Int32 slno, Int32 apprej, string sesid, string remarks, Int32 apprejby, string type);

        DataTable RegistrationReport1(string env, string searchid, Int32 status, DateTime frmdate, DateTime todate, Int32 regid, Int32 stateid, Int32 pageIndex, Int32 pageSize, string val);

        DataTable MemphotosReport(string env, string action, DateTime frmdate, DateTime todate, Int32 regid, Int32 pageIndex, Int32 pagesize);

        DataTable GetCount(string env, string mailid);

        DataTable GetMails(string env, string mailid);

        string DeleteMail(string env, Int32 id);

        string GetAttch(string env, Int32 id);

        DataTable SearchMails(string env, string mailFrom, string mailTo);

        int IsAttachExit(string env, Int32 id);

        string GetBulkMessage(string env, Int32 id);

        DataTable GetBulkSubject(string env, Int32 id);

        string GetMessage(string env, Int32 id);

        string GetSubject(string env, Int32 id);

        string GetMsgFrom(string env, Int32 id);

        string GetMsgTo(string env, Int32 id);

        string GetMsgDate(string env, Int32 id);

        DataTable GetDraftMsg(string env, Int32 id);

        int ReplyMail(string env, string mailfrom, string mailto, string subject, string msg, DateTime sentdate, int savenSend, Int32 mailId, string repSubject, string file, string ReqNo, string Status);

        int SendMail(string env, string mailfrom, string mailto, string subject, string msg, DateTime sentdate, int savenSend, string file, string toType);

        DataTable GetSentMails(string env, string mailId);

        int DeleteSentMails(string env, Int32 mailId);

        int SendBulkMail(string env, string mailfrom, string subject, string msg, DateTime sentdate);

        DataTable GetBulkMails(string env);

        int DeleteBulkMail(string env, Int32 mailId);

        string CreateFolder(string env, string folderName, string memId);

        DataTable GetFolderMailsMails(string env, string mailId, Int32 folderId);

        //29-02 Satish
        DataTable Glance(string env, DateTime fromdate, DateTime todate, Int32 uid);

        DataTable GlanceReportNew(string env, string action, string rpttype, DateTime fromdate, DateTime todate, Int32 mailto, Int32 sts, string searchby, Int32 pageindex, Int32 pagesize);

        DataTable VATCSTReport(string env, string action, string idno, string billno, Int16 status, DateTime frmdate, DateTime todate, Int32 pageIndex, Int32 pageSize, Int32 month, Int32 year, Int32 month1, Int32 year1, string state);

        DataTable GetRegions(string env, string search, string stype);

        DataTable SalesReport(string env, DateTime frmdate, DateTime todate, string orderid, Int32 pageIndex, Int32 pageSize);

        //01-03 satish
        DataTable NewsRptNew(string env, string action, Int32 nid, string description, Int32 createdby, string ntype, string subject);

        DataTable FaqsRptNew(string env, string action, Int32 faqid, string qusetion, string answer, Int32 user, string sessid);

        DataTable Downloadfiles(string env, string action, int sno, int status);

        int InsertDownloadfiles(string env, string title, string filename, string uploadby, string sesid);

        DataTable GetMailfoldersname(string env, string memid);

        string InsertIntoFolder(string env, Int32 mailId, Int32 folderId);

        string CheckSentID(string env, string to, string toid);

        string GetSprDetails(string env, string id);

        string MemberCheck(string env, string userId);

        string VerifyLoginDetails(string env, string userId);

        DataTable UnilevelTreeIdDet(string env, string userId);

        DataTable Unilvltree(string env, string userId);

        DataTable CreditReqPending(string env);

        DataTable GetCreditreq(string env, string reqcode);

        void AppRejCreditRqt(string env, string reqcode, int apprej, Int32 user, string sessid, string remarks);

        DataTable GetCreditReqRpt(string env, int reqstatus, int cbank, DateTime frmdate, DateTime todate, Int32 regid, Int32 pageIndex, Int32 pagesize);
        //rk
        DataTable UsedCouponsRpt(string env, DateTime frmdate, DateTime todate, Int32 regid, Int32 pageIndex, Int32 pagesize);

        DataTable MemberRpOrders(string env, Int32 regid, Int32 rpstatus, Int32 pageindex, Int32 pagesize, string Action);

        DataSet Reg_OrderNo_Check(string env, string RefNo, string Fcode, string ReceiptType);

        DataSet GetFeedbacks(string env);

        //Modified by suresh on 13/5
        DataTable AppConsultMOP(string env, string action, Int64 Regid, string mop, double amount, string refno, string refbank, string refbranch, DateTime refDate, string remarks, string orderno, int AppConsultMOP);

        DataTable InsertBatchOutSms(string env, Int32 regid, string Mobile, string msg, string sessid);
        //14/03 Satish
        DataTable FaqsReport(string env, string Type, DateTime Fromdate, DateTime Todate, int Pagesize, int PageIndex);

        //16/03 satish
        DataTable OfferPopup(string env, string action, string Title, String Subject, string Image, string Description, int Uid, DateTime Exp, int SNo);

        //17/03 Satish
        DataTable GetTreeTooltip(string env, string membid);

        DataSet TreeView(string env, string id);

        DataSet chkmemdown(string env, string id, string down);

        DataTable GetMemberDetails(string env, string Idno, string strType);

        int insertsmslog(string env, Int64 regid, string mobile, DateTime senddate, string message, string action, string sessid,
                         string SMSType);

        DataTable Newslog(string env, String Action, int Nlid, int Nid, int Regid, int Nread, DateTime CreatedDate, String sesid, int status);

        DataTable GetBulkMailCount(string env, int MRead, string MStatus);

        DataTable UnilevelTreeDet(string env, string userId);

        DataTable Unilvltrees(string env, string idno, int first, int end);

        DataTable ApproveCustomerOrder(string env, string action, Int32 slno, Int32 apprej, string sesid, string remarks, Int32 apprejby);

        DataTable RegistrationReport1onlinesucc(string env, string searchid, DateTime frmdate, DateTime todate, Int32 pageIndex, Int32 pageSize, string pgtype);

        DataTable RegistrationReport1onlinefail(string env, DateTime frmdate, DateTime todate, Int32 pageIndex, Int32 pageSize);

        DataTable Boostertrees(string env, string action, string idno, int first, int end);

        DataTable BoosterTreeIdDet(string env, string action, string userId);

        DataTable GetApprovePoDetailes(string env, Int32 payno);

        DataTable PayoutApprove(string env, Int32 payno, Int32 uid, string sessid);

        DataTable SICPPayoutApprove(string env,string action, Int32 payno, Int32 uid, string sessid);

        DataSet BainaryTrackReport(string env, Int32 regid);

        DataTable Steps(string env, string OrbitNo, int OrbitStage, int PayNo);

        DataTable GetBinaryAnalysis(string env, Int32 pageIndex, Int32 pageSize);

        DataTable SCReport1onlinesucc(string env, string searchid, DateTime frmdate, DateTime todate, Int32 pageIndex, Int32 pageSize, string pgtype);

        DataTable SCReport1onlinefail(string env, DateTime frmdate, DateTime todate, Int32 pageIndex, Int32 pageSize);

        DataTable CreditRequestReport1onlinesucc(string env, string searchid, DateTime frmdate, DateTime todate, Int32 pageIndex, Int32 pageSize, string pgtype);

        DataTable CreditRequestReport1onlinefail(string env, DateTime frmdate, DateTime todate, Int32 pageIndex, Int32 pageSize);

        DataTable SSMPPayoutProcess(string env, string action, Int32 Uid, string Sessid, string Remarks, Int32 Payno);

        DataTable SICPPayoutProcess(string env, string action, Int32 Uid, string Sessid, string Remarks);

        DataTable SSMPRewards(string env, Int32 regid);

        DataTable ApprovePaymentrpt(string env, string action,string Ordertype, string Paymenttype, String SBOID, DateTime fromdate, DateTime todate, Int32 pageIndex, Int32 pageSize);

        DataTable PendingGatewayOrdersRpt(string env, string action, DateTime fromdate, DateTime todate, Int32 pageIndex, Int32 pageSize);

        DataTable TDSRpt(string env, string action, Int32 payno, String regid, string type, string mnths, string yrs, Int32 PageIndex, Int32 PageSize);

        DataTable BusinessStatsRpt(string env, string action, string state, string district, string SBOID, string Packcode, string Pcode, string Sts, string Plantype, DateTime fromdate, DateTime todate, Int32 pageIndex, Int32 pageSize);

        DataTable GetReport(string env, string action, string Type, Int32 payno, string regid, DateTime frmdate, DateTime todate, Int32 pageindex, Int32 pagesize);

        DataTable GetRegFields(string env, string action, string fname1, string lname1, string dob1, string careof1, string mobile1, string eMail1);

        DataTable UpdateDuplicateIdsRpt(string env, int regid, string remarks, int uid, string sesid, string ipaddress);

        DataTable GetMinRegIdDuplicateIdsRpt(string env, string Fname, string Lname, string UserName, DateTime dob, string Mobile, string Email);

        DataTable BusinessReport(string env, string action, string type, Int32 pageIndex, Int32 pageSize);

        DataTable DateWiseBusinessReport(string env, string action, string type,DateTime date, Int32 pageIndex, Int32 pageSize);

        DataTable NewsSubcription_Log(string env, string action, Int32 NSLId, string Subject, string Body, string UploadFile, Int32 Status, Int32 uid, string sesid, Int32 pageindex, Int32 pagesize);
        
        DataTable DespNewsLetter(string env, string action, string EmailId, string Subject, string Body, string UploadFile, string sesid, string IPaddress);

        DataTable CheckDownto(string env,string action, string idno, string downto);

        DataTable UpdateUnSuccessfulPGTranRpt(string env, string CCRemarks, string ORDER_ID, int UpdatedBy);

        DataSet GetRewardsReport(string env, string action, string Type, Int32 payno, string regid, DateTime frmdate, DateTime todate, Int32 pageindex, Int32 pagesize);

        int MobileAppsmslog(string env, Int64 regid, string mobile, DateTime senddate, string message, string action, string sessid,string SMSType);

        int OfferCreate(string env, string action, string type, string pcode, string Itemid, string offName, Int32 noofcupons, DateTime frmdate, DateTime todate, string sessid, string ipaddress, Int32 createdby, string Remarks, int Status,
            Int32 NoofCoupCnts, Int32 txtcuponval1, Int32 MinValue1, Int32 MaxValue1, Int32 txtcuponval2, Int32 MinValue2, Int32 MaxValue2, Int32 txtcuponval3, Int32 MinValue3, Int32 MaxValue3,
            Int32 txtcuponval4, Int32 MinValue4, Int32 MaxValue4, Int32 txtcuponval5, Int32 MinValue5, Int32 MaxValue5);

        DataTable OfferReport(string env, string Action, string Offname, DateTime frmdate, DateTime todate, Int32 pageIndex, Int32 pageSize, string Type);

        DataTable MobileSlides(string env, string Action, string CreatedBy, string SessId, string IpAdd,string ImgName, Int32 OrderNo);

        DataTable ClickAndShare(string env, string Action, Int32 id, string CreatedBy, string Description, string Status, string ImgName, string SessId, string IpAdd);

        int CreateWalletOffer(string env, string action, string OfferCode, string pcode, string offName, string OffType, Double WalletValue, Int32 Pid, DateTime frmdate, DateTime todate, string sessid, string ipaddress, Int32 createdby, string Remarks, int Status);

        DataSet DayStatisticsRpt(string env, string action, string Type,string regid);

        DataTable Stockreturn(string env, string Action, string billno, string Refno, Int32 type, DateTime frmdate, DateTime todate, Int32 pageIndex, Int32 pageSize, string ssid, string remarks);

        DataTable GVDInstalPayment(string env, string Action,string UnqId,string billno, Int32 Regid, Int32 pid,string MOP,double PayAmt, string ssid, string remarks);

        DataTable GVDFullPayment(string env, string Action, string UnqId, string billno, Int32 Regid, Int32 pid, string MOP, double PayAmt, string ssid, string remarks, string DDno, string ddbank, string ddbranch, DateTime dddate, string mobile, string add1, string city, string district, string states, string pin);

        DataTable GetMemMails(string env, string Action, string Reqno, Int32 Regid, Int32 id, string Type);

        #region Franchisee
        DataSet InsertFranchise(string env,string FCCode, string FranchiseName, string Address1, string Address2, string city, string state, string Email, string Status, string CreatedBy, DateTime CreatedDate, string Phone, string stkLimit, string JoinAmt, string CompanyName, string UserName, string Password, string Bank, string AccNo, string IFSC, string BankAddress, string type, string tinno, string GST);
        DataSet GetFCcode(string env,string Action);
        DataSet ExistFranchiseIdno(string env, string idno);
        DataSet Editfranchise(string env,string FCCode);
        DataTable FCPLogin(string env, string username, string password);
        DataTable TempStockOrder_FCP(string env, string action, string UNQId, string pcode, string ItemCode, string Attribute, string Qty, string Item);
        DataTable StockOrder_FCP(string env, string action, string Id, string remarks, string Sessid, string UID);
        DataTable StockOrderReport_FCP(string env, string action, string Id, DateTime frmdate, DateTime todate, Int32 pageIndex, Int32 pageSize);
        DataTable ApprovedStockOrder_FCP(string env, string action, string orderrefid, string fcode, string pcode, string qty, string sessionid, string SesUser, string dmode, string modname, string modno, string moddate, string modremarks, string VehicleNo);
        DataTable MakeFCPCreditRequest(string env, string fcode, double reqAmt, string mop, string refno, DateTime date, string invbank, string invbranch, string VarcharNo, DateTime cdate, string depbank, string depbranch, string depcity, DateTime depdate, string depslip, string remarks);
        DataTable GetFCPCreditReqRpt(string env, int reqstatus, DateTime frmdate, DateTime todate, string fcode, Int32 pageIndex, Int32 pagesize, string reqcode, string action);
        DataTable TempRepOrder_FCP(string env, string action, string UNQId, string pcode, string ItemCode, string Attribute, string Qty, string Item, string Fcode);
        DataTable ScOrder_FCP(string env, string UNQId, Int32 regid, Int32 downlineid, string mop, string mopamt, string Fname, string LName, string Mobile, string Address, string City, string District, string state, string PiCode, string ordertype, string shpchrg, string scmemtype, string sesid, string ipadd, string Fcode);
        int GetAvlQtyforStockAdj_FCP(string env, string action, string itemcode, string Fcode);
        DataTable FCPGlance(string env, DateTime date, string user);

        DataTable GlanceReport_FCP(string env, string action, string rpttype, DateTime ondate, string username, string sts, string searchby, Int32 pageindex, Int32 pagesize);

        #endregion
    }

}
