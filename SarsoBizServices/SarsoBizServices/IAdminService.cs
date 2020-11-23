using System;
using System.Data;
using System.ServiceModel;

namespace SarsoBizServices
{
    // NOTE: If you change the interface name "IAdminService" here, you must also update the reference to "IAdminService" in Web.config.
    [ServiceContract]
    public interface IAdminService
    {
        [OperationContract]
        DataTable AdminLogin(string username, string password);

        [OperationContract]
        void CodeErrors(string userid, string pageurl, string errorMsg, string sesid);

        [OperationContract]
        void SessionsInOut(string action, Int32 uid, string sesid, string ipaddress, string systemname,
                           string usertype);

        [OperationContract]
        DataTable CurrlastloginTime(Int32 loginid, string sesid, string usertype);

        [OperationContract]
        DataTable MainLinks(int uid, string usertype);

        [OperationContract]
        DataTable Sublinks(int lid, int uid, string usertype);

        [OperationContract]
        DataTable LinksPremission(int lid, int uid, string usertype);

        [OperationContract]
        int SublinksPermissions(string lids, Int32 itemid, Int32 uid, string sesid, string usertype);

        [OperationContract]
        DataTable Users(string action, int itemid);

        [OperationContract]
        int InupUsers(string action, int itemId, string userName, string passWord, string name,
                      string doorno, string lane, string streat, string city, string state,
                      string contactName, string contactPhone, string email, int uid,
                      string sesid, string ipaddress, int flag);

        [OperationContract]
        int DelUsers(int itemid, int uid);

        [OperationContract]
        int ChangePassword(string action, int itemid, string pwd, int uid);

        [OperationContract]
        string GetValue(string tblname, string getcolum, string columnItem, string itemId);

        [OperationContract]
        DataTable GetData(string tblname, string columnItem, string itemId);

        [OperationContract]
        DataTable UsersLogRpt(DateTime frmdate, DateTime todate, Int32 user, Int32 pageIndex, Int32 pageSize, string usertype);

        [OperationContract]
        int AddCompanyBanks(string action, int cbId, string bank, string branch, string accno, string ifsc, string city, string state,
                            int cbStatus, string createdBy, string sesid);

        [OperationContract]
        DataTable GetCompanyBanks(int cbid);

        [OperationContract]
        DataTable MemberSearch(string key, string style, string keyWords,
                               string sortby, Int32 pageIndex, Int32 pageSize);

        [OperationContract]
        DataTable RegistrationReport(string action, string plantype, DateTime frmdate,
                                     DateTime todate, Int64 regid, Int32 pageIndex, Int32 pageSize);

        [OperationContract]
        DataTable GetPackages(string action);

        [OperationContract]
        DataTable DrcDetails();

        [OperationContract]
        int UpDrcDetails(Int32 pid, string postEwallet, double drcAmt);


        [OperationContract]
        DataTable PairsReport(DateTime frmdate, DateTime todate, Int64 regid, Int32 pageIndex, Int32 pageSize);

        [OperationContract]
        DataTable BlockIdorBlockToPaidRpt(string action, DateTime frmdate, DateTime todate, Int32 pageIndex,
                                          Int32 pageSize);

        [OperationContract]
        DataTable FeedbackRpt(string action, string idno, string name, string city, string state, string email,
                              string subject,
                              string msg, string status, Int32 createdby, DateTime createddate, string plantype,
                              Int32 pageIndex, Int32 pageSize);

        [OperationContract]
        DataTable NewsRpt(string action, string description, string status, Int32 createdby, DateTime createddate, Int32 updatedby,
                                        DateTime updateddate, string plantype, Int32 pageIndex, Int32 pageSize);

        [OperationContract]
        DataTable SeminarRpt(string action, string titile, string venue, DateTime date, string time, string city,
                             string state, string vleader,
                             string phoneno, string status, DateTime createddate, int createdby, int updatedby,
                             DateTime updateddate, string plantype, Int32 pageIndex, Int32 pageSize);

        [OperationContract]
        DataSet FaqsRpt(string action, string qusetion, string answer, string catageory, string catageoryname, string user,
                          string status,
                          string sessid, string plantype, Int32 pageIndex, Int32 pageSize);

        DataTable FaqsCategorys(string action);

        [OperationContract]
        DataTable MemberBankSlipsRpt(int sts, Int32 pageIndex, Int32 pageSize);


        [OperationContract]
        DataTable MemberBankSlipsforAppRej(Int32 regid, DateTime fromdate, DateTime todate, Int32 pageIndex,
                                           Int32 pageSize);

        [OperationContract]
        void AppRejBankSlips(string slnos, int sts, string sesid, string ipadd, Int32 uid);

        [OperationContract]
        DataTable CstCollectionRpt(string action, DateTime fromdate, DateTime todate, Int32 pageIndex, Int32 pageSize);

        [OperationContract]
        DataTable VatCollectionRpt(string action, DateTime fromdate, DateTime todate, Int32 pageIndex,
                                   Int32 pageSize);

        [OperationContract]
        DataTable LboActivationRpt(string action, int regid, DateTime fromdate, DateTime todate, Int32 pageIndex, Int32 pageSize);

        [OperationContract]
        DataTable ProductSalesRpt(string action, int regid, DateTime fromdate, DateTime todate, Int32 pageIndex, Int32 pageSize);


        [OperationContract]
        DataTable RepurchaseSalesRpt(string action, int regid, DateTime fromdate, DateTime todate,
                                     Int32 pageIndex, Int32 pageSize);

        [OperationContract]
        DataTable RepurchaseVochersRpt(string action, int regid, DateTime fromdate, DateTime todate, Int32 pageIndex, Int32 pageSize);

        [OperationContract]
        DataTable MobileRechargeRpt(string action, int regid, DateTime fromdate, DateTime todate, Int32 pageIndex, Int32 pageSize);

        [OperationContract]
        DataTable NonRpLbosRpt(string action, DateTime fromdate, DateTime todate, Int32 pageIndex, Int32 pageSize);

        [OperationContract]
        DataTable TopMembersRpt(string action, int stateid, Int32 pageIndex, Int32 pageSize);

        [OperationContract]
        DataTable CityWiseRpt(string action, string city, Int32 pageIndex, Int32 pageSize);

        [OperationContract]
        DataTable RepurVocherValidityExtenRpt(string action, int regid, DateTime fromdate, DateTime todate, Int32 pageIndex, Int32 pageSize);

        [OperationContract]
        DataTable PackageWiseRpt(string action, string month, Int32 pageIndex, Int32 pageSize);

        [OperationContract]
        DataTable SmsLogRpt(string action, DateTime fromdate, DateTime todate, Int32 pageIndex, Int32 pageSize);

        [OperationContract]
        DataTable PayoutSmsRpt(string action, Int32 pageIndex, Int32 pageSize);

        [OperationContract]
        DataTable ShoppingReqRpt(string action, DateTime fromdate, DateTime todate, Int32 pageIndex, Int32 pageSize);

        [OperationContract]
        DataTable CreditReqRpt(string action, Int32 pageIndex, Int32 pageSize);

        [OperationContract]
        DataTable CreditSummaryRpt(string action, string fcode, Int32 pageIndex, Int32 pageSize);

        [OperationContract]
        DataTable StockReturnsRpt(string action, Int32 pageIndex, Int32 pageSize);

        [OperationContract]
        DataTable FranchiseBalancesRpt(string action, Int32 pageIndex, Int32 pageSize);

        [OperationContract]
        DataTable FranchiseCommissionRpt(string action, string fcode, Int32 pageIndex, Int32 pageSize);

        [OperationContract]
        DataTable FranchiseSalesCommRpt(string action, string commtype, DateTime fromdate, DateTime todate,
            string fcode, Int32 pageIndex, Int32 pageSize);

        [OperationContract]
        DataTable LifeisClubMemRpt(string action, string membership, DateTime fromdate, DateTime todate,
            int regid, Int32 pageIndex, Int32 pageSize);

        [OperationContract]
        DataTable LifeisClubAchieversRpt(string action, string membership, DateTime fromdate, DateTime todate,
            int regid, Int32 pageIndex, Int32 pageSize);

        [OperationContract]
        DataTable LeadershipIncentivesRpt(string action, int payoutno, int regid, Int32 pageIndex, Int32 pageSize);

        [OperationContract]
        DataTable WithdrawlPendingReqRpt(string action, Int32 pageIndex, Int32 pageSize);

        [OperationContract]
        string WithdrawlPendingReq(string reqids, string sesid);

        [OperationContract]
        DataTable WithdrawlBatchRpt(string action, Int32 pageIndex, Int32 pageSize);

        [OperationContract]
        DataTable ProductAnalasysRpt(string action, DateTime startdate, Int32 pageIndex, Int32 pageSize);

        [OperationContract]
        DataTable DistributionAnalasysRpt(string action, DateTime startdate, Int32 pageIndex, Int32 pageSize);

        [OperationContract]
        DataTable ActiveInactiveRpt(DateTime fromdate, DateTime todate, Int32 regid, int stateid, Int32 pageIndex,
                                    Int32 pageSize);

        [OperationContract]
        DataTable LiisBinary(Int32 regid);

        [OperationContract]
        DataTable LiisBinaryInDet(Int32 regid, Int32 payno);

        [OperationContract]
        DataTable InvoicesRpt(string invFrom, string invType, DateTime fromdate, DateTime todate, Int32 pageIndex,
                              Int32 pageSize);
        [OperationContract]
        DataTable InvoicesRptAll(string action, string idno, string billno, DateTime fromdate, DateTime todate, Int32 pageIndex, Int32 pageSize);

        [OperationContract]
        DataTable AppRejMemProfRpt(string action, Int32 regid, DateTime fromdate, DateTime todate, Int32 pageIndex,
                                   Int32 pageSize);

        [OperationContract]
        DataTable MemphotosforAppRej(string action, Int32 regid, DateTime fromdate, DateTime todate, Int32 pageIndex,
                                     Int32 pageSize);

        [OperationContract]
        void AppRejMemDetailes(string action, Int32 slno, int status, int byuser, string remarks);

        [OperationContract]
        void AppRejMemPhotos(Int32 slno, Int32 status, Int32 byuser, string action, string Remarks);

        [OperationContract]
        DataTable ChkMobRchTransactionNo(string tranno);

        [OperationContract]
        DataTable UpdateMobRchTransactionNo(string tranno, string sesid, string appby);

        [OperationContract]
        DataTable SpeedGlance(DateTime ondate, string username);

        [OperationContract]
        DataTable GlanceReport(string action, string type, DateTime ondate, string username);

        [OperationContract]
        void Cleartmpsms(string sesid);

        [OperationContract]
        DataTable InsertResendSmsIds(Int32 regid, string sesid);

        [OperationContract]
        void InsertResendSms(string sesid);

        [OperationContract]
        DataTable InsertNonMemsmsIds(string name, string mobile, string sesid);

        [OperationContract]
        void InsertNonMemSms(string sesid, string msg);

        [OperationContract]
        DataTable SmsLog(string action, DateTime fromdate, DateTime todate, Int32 pageIndex, Int32 pageSize);

        [OperationContract]
        DataTable GetSmsActions();

        [OperationContract]
        void ResendSms(string sesid);

        [OperationContract]
        DataTable MemberSms(string sesid, string msg);

        [OperationContract]
        void InsertMemberSms(string sesid, string msg);

        [OperationContract]
        DataTable BulkSms(string stateid, string city, string msg, string sesid);

        [OperationContract]
        void InsertBulkSms(string stateid, string city, string msg, string sesid);

        [OperationContract]
        DataTable GetMemforBirthdaysms();

        [OperationContract]
        DataTable BirthdaySms();

        [OperationContract]
        void InsertBirthdaySms(string msg, string sesid);

        [OperationContract]
        DataTable GetMemforPayoutsms(Int32 payno);

        [OperationContract]
        DataTable PayoutSms(string idnos, Int16 payno, string sesid);

        [OperationContract]
        void InsertPayoutSms(string idnos, Int16 payno, string sesid);

        [OperationContract]
        DataSet Invoices(string action, string billno);

        [OperationContract]
        DataTable WithdrawlBatchExcel(string wdno);

        [OperationContract]
        DataTable GetVouchers(string action, Int32 regid, string sfcpCode, string sesid);

        [OperationContract]
        DataSet ShoppingRequests(int sts, Int32 pageindex, Int32 pagesize, DateTime fromdate, DateTime todate);

        [OperationContract]
        string ShoppingRequestReject(string reqno, string remarks, string sesid, Int32 uid);


        [OperationContract]
        string ShoppingRequestApprove(string reqno, double billamount, string mop, string tranno,
                                      string tranbank, string tranbranch, DateTime trandate,
                                      string remarks, string sesid, Int32 uid);

        [OperationContract]
        DataTable CrocrepatiRewardReport(int reward, Int32 regid, Int32 payno, Int32 pageindex, Int32 pagesize);

        [OperationContract]
        DataTable BigBossRewardReport(int reward, Int32 pageindex, Int32 pagesize);

        [OperationContract]
        DataTable BigBossRequestsRpt(string sts, DateTime fromdate, DateTime todate, Int32 regid,
                                     Int32 pageIndex, Int32 pageSize);

        [OperationContract]
        string BigBossReqAppRej(Int32 sno, string sts, string remarks, Int32 uid, string sesid);

        [OperationContract]
        DataSet PkgPrdMonthWiseCnt(string month);

        [OperationContract]
        string GetBatch(string tblname, string getcolum, string columnItem, string columnVal, string batchno);

        [OperationContract]
        int ResetPassword(Int32 regid, string pwd, int uid, int pwdType, int sms, int changed);

        [OperationContract]
        DataTable InsBankStatement(string action, DateTime stmdate, double Amount, string Description, string bank, DateTime date, string createdby, string sesid, string ipaddress, Int32 pageIndex, Int32 pageSize, string TranType);

        [OperationContract]
        DataTable CompanyNotifications(string type, Int32 regid, string gcmid, string subject, string message, string image, string url);

        [OperationContract]
        DataTable KycReport(string action, DateTime frmdate, DateTime todate, Int32 regid, Int32 pageIndex, Int32 pagesize, Int32 status);

        [OperationContract]
        DataTable KycPendingRpt(string type, string ModuleType);

        [OperationContract]
        void ApproveKyc(Int32 slno, Int32 apprej, string sesid, string remarks, Int32 apprejby, string type);

        [OperationContract]
        DataTable RegistrationReport1(string searchid, Int32 status, DateTime frmdate, DateTime todate, Int32 regid, Int32 stateid, Int32 pageIndex, Int32 pageSize, string val);

        [OperationContract]
        DataTable MemphotosReport(string action, DateTime frmdate, DateTime todate, Int32 regid, Int32 pageIndex, Int32 pagesize);

        [OperationContract]
        DataTable GetCount(string mailid);

        [OperationContract]
        DataTable GetMails(string mailid);

        [OperationContract]
        string DeleteMail(Int32 id);

        [OperationContract]
        string GetAttch(Int32 id);

        [OperationContract]
        DataTable SearchMails(string mailFrom, string mailTo);

        [OperationContract]
        int IsAttachExit(Int32 id);

        [OperationContract]
        string GetBulkMessage(Int32 id);

        [OperationContract]
        DataTable GetBulkSubject(Int32 id);

        [OperationContract]
        string GetMessage(Int32 id);

        [OperationContract]
        string GetSubject(Int32 id);

        [OperationContract]
        string GetMsgFrom(Int32 id);

        [OperationContract]
        string GetMsgTo(Int32 id);

        [OperationContract]
        string GetMsgDate(Int32 id);

        [OperationContract]
        DataTable GetDraftMsg(Int32 id);

        [OperationContract]
        int ReplyMail(string mailfrom, string mailto, string subject, string msg, DateTime sentdate, int savenSend, Int32 mailId, string repSubject, string file, string ReqNo, string Status);

        [OperationContract]
        int SendMail(string mailfrom, string mailto, string subject, string msg, DateTime sentdate, int savenSend, string file, string toType);

        [OperationContract]
        DataTable GetSentMails(string mailId);

        [OperationContract]
        int DeleteSentMails(Int32 mailId);

        [OperationContract]
        int SendBulkMail(string mailfrom, string subject, string msg, DateTime sentdate);

        [OperationContract]
        DataTable GetBulkMails();

        [OperationContract]
        int DeleteBulkMail(Int32 mailId);

        [OperationContract]
        string CreateFolder(string folderName, string memId);

        [OperationContract]
        DataTable GetFolderMailsMails(string mailId, Int32 folderId);

        //29-02 Satish
        [OperationContract]
        DataTable GlanceReportNew(string action, string rpttype, DateTime fromdate, DateTime todate, Int32 mailto, Int32 sts, string searchby, Int32 pageindex, Int32 pagesize);

        [OperationContract]
        DataTable Glance(DateTime fromdate, DateTime todate, Int32 uid);

        [OperationContract]
        DataTable GetRegions(string search, string stype);

        [OperationContract]
        DataTable VATCSTReport(string action,string idno, string billno, Int16 status, DateTime frmdate, DateTime todate, Int32 pageIndex, Int32 pageSize, Int32 month, Int32 year, Int32 month1, Int32 year1, string state);

        [OperationContract]
        DataTable SalesReport(DateTime frmdate, DateTime todate, string orderid, Int32 pageIndex, Int32 pageSize);
        //30-01 Satish
        [OperationContract]
        DataTable NewsRptNew(string action, Int32 nid, string description, Int32 createdby, string ntype, string subject);

        [OperationContract]
        DataTable FaqsRptNew(string action, Int32 faqid, string qusetion, string answer, Int32 user, string sessid);

        [OperationContract]
        DataTable Downloadfiles(string action, int sno, int status);

        [OperationContract]
        int InsertDownloadfiles(string title, string filename, string uploadby, string sesid);

        [OperationContract]
        DataTable GetMailfoldersname(string memid);

        [OperationContract]
        string InsertIntoFolder(Int32 mailId, Int32 folderId);

        [OperationContract]
        string CheckSentID(string to, string toid);

        [OperationContract]
        string GetSprDetails(string id);

        [OperationContract]
        string MemberCheck(string userId);

        [OperationContract]
        string VerifyLoginDetails(string userId);

        [OperationContract]
        DataTable UnilevelTreeIdDet(string userId);

        [OperationContract]
        DataTable Unilvltree(string userId);

        [OperationContract]
        DataTable CreditReqPending();

        [OperationContract]
        DataTable GetCreditreq(string reqcode);

        [OperationContract]
        void AppRejCreditRqt(string reqcode, int apprej, Int32 user, string sessid, string remarks);

        [OperationContract]
        DataTable GetCreditReqRpt(int reqstatus, int cbank, DateTime frmdate, DateTime todate, Int32 regid, Int32 pageIndex, Int32 pagesize);

        //rk
        [OperationContract]
        DataTable UsedCouponsRpt(DateTime frmdate, DateTime todate, Int32 regid, Int32 pageIndex, Int32 pagesize);

        [OperationContract]
        DataTable MemberRpOrders(Int32 regid, Int32 rpstatus, Int32 pageindex, Int32 pagesize, string Action);

        [OperationContract]
        DataSet Reg_OrderNo_Check(string RefNo, string Fcode, string ReceiptType);

        [OperationContract]
        DataSet GetFeedbacks();

        //Modified by suresh on 13/5
        [OperationContract]
        DataTable AppConsultMOP(string action, Int64 Regid, string mop, double amount, string refno, string refbank, string refbranch, DateTime refDate, string remarks, string orderno, int ApprovedBy);

        [OperationContract]
        DataTable InsertBatchOutSms(Int32 regid, string Mobile, string msg, string sessid);

        [OperationContract]
        DataTable FaqsReport(string Type, DateTime Fromdate, DateTime Todate, int Pagesize, int PageIndex);

        [OperationContract]
        DataTable OfferPopup(string action, string Title, String Subject, string Image, string Description, int Uid, DateTime Exp, int SNo);

        //17/03 Satish
        [OperationContract]
        DataTable GetTreeTooltip(string membid);

        [OperationContract]
        DataSet TreeView(string id);

        [OperationContract]
        DataSet chkmemdown(string id, string down);

        [OperationContract]
        DataTable GetMemberDetails(string Idno, String strType);

        [OperationContract]
        int insertsmslog(Int64 regid, string mobile, DateTime senddate, string message, string action, string sessid, string SMSType);

        [OperationContract]
        DataTable Newslog(String Action, int Nlid, int Nid, int Regid, int Nread, DateTime CreatedDate, String sesid, int status);

        [OperationContract]
        DataTable GetBulkMailCount(int MRead, string MStatus);

        [OperationContract]
        DataTable UnilevelTreeDet(string userId);

        [OperationContract]
        DataTable Unilvltrees(string idno, int first, int end);

        [OperationContract]
        DataTable ApproveCustomerOrder(string action, Int32 slno, Int32 apprej, string sesid, string remarks, Int32 apprejby);

        [OperationContract]
        DataTable RegistrationReport1onlinesucc(string searchid, DateTime frmdate, DateTime todate, Int32 pageIndex, Int32 pageSize, string pgtype);

        [OperationContract]
        DataTable RegistrationReport1onlinefail(DateTime frmdate, DateTime todate, Int32 pageIndex, Int32 pageSize);

        [OperationContract]
        DataTable Boostertrees(string action, string idno, int first, int end);

        [OperationContract]
        DataTable BoosterTreeIdDet(string action, string userId);

        [OperationContract]
        DataTable GetApprovePoDetailes(Int32 payno);

        [OperationContract]
        DataTable PayoutApprove(Int32 payno, Int32 uid, string sessid);

        [OperationContract]
        DataTable SICPPayoutApprove(string action, Int32 payno, Int32 uid, string sessid);

        [OperationContract]
        DataSet BainaryTrackReport(Int32 regid);

        [OperationContract]
        DataTable Steps(string OrbitNo, int OrbitStage, int PayNo);

        [OperationContract]
        DataTable GetBinaryAnalysis(Int32 pageIndex, Int32 pageSize);

        [OperationContract]
        DataTable SCReport1onlinesucc(string searchid, DateTime frmdate, DateTime todate, Int32 pageIndex, Int32 pageSize, string pgtype);

        [OperationContract]
        DataTable SCReport1onlinefail(DateTime frmdate, DateTime todate, Int32 pageIndex, Int32 pageSize);

        [OperationContract]
        DataTable CreditRequestReport1onlinesucc(string searchid, DateTime frmdate, DateTime todate, Int32 pageIndex, Int32 pageSize, string pgtype);

        [OperationContract]
        DataTable CreditRequestReport1onlinefail(DateTime frmdate, DateTime todate, Int32 pageIndex, Int32 pageSize);

        [OperationContract]
        DataTable SSMPPayoutProcess(string action, Int32 Uid, string Sessid, string Remarks,Int32 Payno);

        [OperationContract]
        DataTable SICPPayoutProcess(string action, Int32 Uid, string Sessid, string Remarks);

        [OperationContract]
        DataTable SSMPRewards(Int32 regid);

        [OperationContract]
        DataTable ApprovePaymentrpt(string action, string Ordertype, string Paymenttype, String SBOID, DateTime fromdate, DateTime todate, Int32 pageIndex, Int32 pageSize);

        [OperationContract]
        DataTable PendingGatewayOrdersRpt(string action, DateTime fromdate, DateTime todate, Int32 pageIndex, Int32 pageSize);

        [OperationContract]
        DataTable TDSRpt(string action, Int32 payno, String regid, string type, string mnths, string yrs, Int32 PageIndex, Int32 PageSize);

        [OperationContract]
        DataTable BusinessStatsRpt(string action, string state, string district, string SBOID, string Packcode, string Pcode, string Sts, string Plantype, DateTime fromdate, DateTime todate, Int32 pageIndex, Int32 pageSize);

        [OperationContract]
        DataTable GetReport(string action, string Type, Int32 payno, string regid, DateTime frmdate, DateTime todate, Int32 pageindex, Int32 pagesize);

        [OperationContract]
        DataTable GetRegFields(string action, string fname1, string lname1, string dob1, string careof1, string mobile1, string eMail1);

        [OperationContract]
        DataTable UpdateDuplicateIdsRpt(int regid, string remarks, int uid, string sesid, string ipaddress);

        [OperationContract]
        DataTable GetMinRegIdDuplicateIdsRpt(string Fname, string Lname, string UserName, DateTime dob, string Mobile, string Email);

        [OperationContract]
        DataTable BusinessReport(string action,string type, Int32 pageIndex, Int32 pageSize);
        
        [OperationContract]
        DataTable DateWiseBusinessReport(string action, string type,DateTime date, Int32 pageIndex, Int32 pageSize);

        [OperationContract]
        DataTable NewsSubcription_Log(string action, Int32 NSLId, string Subject, string Body, string UploadFile, Int32 Status, Int32 uid, string sesid, Int32 pageindex, Int32 pagesize);

        [OperationContract]
        DataTable DespNewsLetter(string action, string EmailId, string Subject, string Body, string UploadFile, string sesid, string IPaddress);

        [OperationContract]
        DataTable CheckDownto(string action,string idno, string downto);

        [OperationContract]
        DataTable UpdateUnSuccessfulPGTranRpt(string CCRemarks, string ORDER_ID, int UpdatedBy);

        [OperationContract]
        DataSet GetRewardsReport(string action, string Type, Int32 payno, string regid, DateTime frmdate, DateTime todate, Int32 pageindex, Int32 pagesize);

        [OperationContract]
        int MobileAppsmslog(Int64 regid, string mobile, DateTime senddate, string message, string action, string sessid, string SMSType);

        [OperationContract]
        int OfferCreate(string action, string type, string pcode, string Itemid, string offName, Int32 noofcupons, DateTime frmdate, DateTime todate, string sessid, string ipaddress, Int32 createdby, string Remarks, int Status,
           Int32 NoofCoupCnts, Int32 txtcuponval1, Int32 MinValue1, Int32 MaxValue1, Int32 txtcuponval2, Int32 MinValue2, Int32 MaxValue2, Int32 txtcuponval3, Int32 MinValue3, Int32 MaxValue3,
            Int32 txtcuponval4, Int32 MinValue4, Int32 MaxValue4, Int32 txtcuponval5, Int32 MinValue5, Int32 MaxValue5);

        [OperationContract]
        DataTable OfferReport(string Action, string Offname, DateTime frmdate, DateTime todate, Int32 pageIndex, Int32 pageSize, string Type);

        [OperationContract]
        DataTable MobileSlides(string Action, string CreatedBy, string SessId, string IpAdd, string ImgName, Int32 OrderNo);

        [OperationContract]
        DataTable ClickAndShare(string Action, Int32 id, string CreatedBy, string Description, string Status, string ImgName, string SessId, string IpAdd);

        [OperationContract]
        int CreateWalletOffer(string action, string OfferCode, string pcode, string offName, string OffType, Double WalletValue, Int32 Pid, DateTime frmdate, DateTime todate, string sessid, string ipaddress, Int32 createdby, string Remarks, int Status);

        [OperationContract]
        DataSet DayStatisticsRpt(string action, string Type, string regid);

        [OperationContract]
        DataTable Stockreturn(string Action, string billno, string Refno, Int32 type, DateTime frmdate, DateTime todate, Int32 pageIndex, Int32 pageSize, string ssid, string remarks);

        [OperationContract]
        DataTable GVDInstalPayment(string Action, string UnqId, string billno, Int32 Regid, Int32 pid, string MOP, double PayAmt, string ssid, string remarks);

        [OperationContract]
        DataTable GVDFullPayment(string Action, string UnqId, string billno, Int32 Regid, Int32 pid, string MOP, double PayAmt, string ssid, string remarks, string DDno, string ddbank, string ddbranch, DateTime dddate, string mobile, string add1, string city, string district, string states, string pin);

        [OperationContract]
        DataTable GetMemMails(string Action, string Reqno, Int32 Regid, Int32 id, string Type);


        #region Franchisee

        [OperationContract]
        DataSet InsertFranchise(string FCCode, string FranchiseName, string Address1, string Address2, string city, string state, string Email, string Status, string CreatedBy, DateTime CreatedDate, string Phone, string stkLimit, string JoinAmt, string CompanyName, string UserName, string Password, string Bank, string AccNo, string IFSC, string BankAddress, string type, string tinno, string GST);

        [OperationContract]
         DataSet GetFCcode(string Action);

        [OperationContract]
        DataSet ExistFranchiseIdno(string idno);

        [OperationContract]
        DataSet Editfranchise(string FCCode);

        [OperationContract]
        DataTable FCPLogin(string username, string password);

        [OperationContract]
        DataTable TempStockOrder_FCP(string action, string UNQId, string pcode, string ItemCode, string Attribute, string Qty, string Item);

        [OperationContract]
        DataTable StockOrder_FCP(string action, string Id, string remarks, string Sessid, string UID);

        [OperationContract]
        DataTable StockOrderReport_FCP(string action, string Id, DateTime frmdate, DateTime todate, Int32 pageIndex, Int32 pageSize);
        
        [OperationContract]
        DataTable ApprovedStockOrder_FCP(string action, string orderrefid, string fcode, string pcode, string qty, string sessionid,string SesUser,string dmode,string modname,string modno,string moddate,string modremarks,string VehicleNo);
        
        [OperationContract]
        DataTable TempRepOrder_FCP(string action, string UNQId, string pcode, string ItemCode, string Attribute, string Qty, string Item, string Fcode);
        [OperationContract]
        DataTable ScOrder_FCP(string UNQId, Int32 regid, Int32 downlineid, string mop, string mopamt, string Fname, string LName, string Mobile, string Address, string City, string District, string state, string PiCode, string ordertype, string shpchrg, string scmemtype, string sesid, string ipadd, string Fcode);

        [OperationContract]
        DataTable MakeFCPCreditRequest(string fcode, double reqAmt, string mop, string refno, DateTime date, string invbank, string invbranch, string VarcharNo, DateTime cdate, string depbank, string depbranch, string depcity, DateTime depdate, string depslip, string remarks);

        [OperationContract]
        DataTable GetFCPCreditReqRpt(int reqstatus, DateTime frmdate, DateTime todate, string fcode, Int32 pageIndex, Int32 pagesize, string reqcode, string action);

        [OperationContract]
        int GetAvlQtyforStockAdj_FCP(string action, string itemcode,string Fcode);

        [OperationContract]
        DataTable FCPGlance(DateTime date, string user);

        [OperationContract]
        DataTable GlanceReport_FCP(string action, string rpttype, DateTime ondate, string username, string sts, string searchby, Int32 pageindex, Int32 pagesize);

        #endregion
    }
}
