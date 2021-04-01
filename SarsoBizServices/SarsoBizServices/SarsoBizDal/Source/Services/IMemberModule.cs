using System;
using System.Data;

// ReSharper disable CheckNamespace
namespace SarsoBizDal
// ReSharper restore CheckNamespace
{
    public interface IMemberModule
    {
        DataTable MemberLogin(string env, string username, string password);

        DataTable GetSponsorDet(string env, Int32 regid);

        DataTable MemDashBoard(string env, Int32 regid);

        Int32 MomPhotoRequest(string env, Int32 regid, string ipadd, string sesid);

        DataTable CheckRegPin(string env, Int32 cardSNo, string keyNo);

        DataSet RegPackDet(string env, Int32 pid);

        DataSet RegMcPackDet(string env, Int32 pid, string fullitemcode);

        DataTable GetCountries(string env);

        DataTable GetStates(string env, int countryId);

        DataTable GetDistricts(string env, int stateid);

        DataTable GetCitysInState(string env, string stateid);

        DataTable InsertTempReg(string env, string userno, Int32 sprno, string spseries, string fname, string lname,
                                                 DateTime dob, string sex, string add1, string add2, string city,
                                                 string district, string state, Int32 pin, string mobile, string eMail, string lpassword,
                                                 string tpassword, string sesid, Int32 downto, string panno, string Title, string guardian,
                                                 string altmobile, string qualification, string subject, string ddrefno, DateTime Refdddate, string refddbank, string ddrefbranch,
                                                 string reftype, Int32 Pid, Int32 BV, string percity,
                                                 string perdistrict, string perstate, Int32 perpin, string landline, string careof, string fullitemcode);

        DataTable InsertSalesTempReg(string env, string userno, Int32 sprno, string spseries, string fname, string lname,
                                                DateTime dob, string sex, string add1, string add2, string city,
                                                string district, string state, Int32 pin, string mobile, string eMail, string lpassword,
                                                string tpassword, string panno, string Title, string guardian,string careof, string sesid);


        Int32 InsertGuestReg(string env, string userno, Int32 sprno, string spseries, string Title, string fname, string lname,
                                               string sex, string state, string mobile, string eMail, string lpassword,
                                               string tpassword, string sesid, string decpwd, string CorrAdds, string PerAdds, string CorrCity, string PerCity,
                                                string CorrDistrict, string perDistrict, string Corrddlstate, string perddlstate, string CorrPINCode, string PerPINCode);

        Int32 PartialInsertReg(string env, string userno, Int32 sprno, string spseries, string Title, string fname, string lname,
                                               string sex, string state, string mobile, string eMail, string lpassword, string tpassword, string sesid, string decpwd, string ddno, DateTime dddate, string ddbank, string ddbranch, string mop, Double Amount, string action, string Unqid, string IP);

        void GetSprSeries(string env, Int32 regid);

        string Getitemcode_Pcode(string env, string pcode);

        void FcpRegCommission(string env, string thru, string sesid);

        DataTable MemberProfile(string env, Int32 regid);

        int BlockIdorBlockToPaid(string env, string action, Int32 regid, Int16 updatedby, string sesid, string remarks);

        int UpdateMemDetailes(string env, Int64 regid, string fName, string lName, string maiden,
                              string mdnMname, string panno, DateTime dob, int age, int sex,
                              string add1, string add2, string city, int districtId, int stateid, int countryid,
                              int pin, string phoneRes, string phoneOff, string mobile,
                              string eMail, string payeeName, string bank, Int64 accno,
                              string branch, string ifscode, string nominee, string relation,
                              int nomage, string sesid, Int32 updatedby);

        DataTable BinaryTreeView(string env, string idno);

        DataTable BinaryTreeViewTooltip(string env, string idno);

        DataTable DirectDownLineReport(string env, Int32 regid);

        DataTable Generationlevels(string env, Int32 regid);

        DataSet BinaryPrintView(string env, string action, Int32 idno, DateTime frmdate, DateTime todate, Int32 pageIndex, Int32 pageSize);

        DataTable BinaryUplevelRpt(string env, Int32 regid, Int32 pageIndex, Int32 pageSize);

        DataTable ConfirmationNote(string env, Int32 regid);

        DataTable WithdrawlRequestRpt(string env, Int32 regid, Int32 pageIndex, Int32 pageSize);

        DataSet RankStatusMem(string env, Int32 regid, Int32 pageIndex, Int32 pageSize);

        void AddorDeductMemEwallet(string env, Int32 regId, string descr, double inAmt, double outAmt,
                                   string remarks, string typeOfInc, string thru, int payNo,
                                   string sessId);

        DataSet Myorders(string env, Int32 regid, Int32 pageIndex, Int32 pageSize);

        int UpdateBankSlips(string env, Int32 regid, string prcode, double amount, string ipadd, string sesid,
                            string src);

        string Chgaddress(string env, Int32 regid, string maidenname,
                                                 string dob, string sex, string add1, string add2, string city,
                                                 string district, string state, Int32 pin, string mobile, string eMail, string corcity, string cordistrict, string corstate, Int32 corpin, string GSTNO);

        string Chgbank(string env, Int32 regid, string payeeName, string panno, string bank, string accno, string branch,
                       string ifscode);

        string Chgnominee(string env, Int32 regid, string nominee, string relation, DateTime NomineeDOB);

        DataTable BigBossReward(string env, int regid);

        DataTable GetProvidersCircles(string env, string action);

        DataTable TmpMobileRech(string env, Int32 regid, string provider, double amount, Int32 mobile, string ipadd);

        DataSet MemberInvoices(string env, string action, Int32 regid);

        void Deletetable(string env, string response);

        void MrUpdate(string env, Int32 regid, string mobile, string provider, string circle, string txnId,
                      double rchAmt, string statusType, string remarks);

        string CheckDownTo(string env, Int32 regid, string downto);

        DataTable MemWithdrawlRequestType(string env, string potratype,string PotraMode, Int32 regid);

        int ChkMemWithdrawlRequest(string env, string action, Int32 regid);

        void MemWithdrawlRequest(string env, string action, Int32 regid, double amount, string remarks, string sesid);

        string ChkMobileEmail(string env, string mobemail, string type);

        DataTable MemberDetailes(string env, Int32 regid);

        DataTable TempMemberDetailes(string env, Int32 regid);

        DataTable AdminEditPermission(string env, Int32 regid);

        int BlockorUnBlock(string env, string action, Int32 regid, Int32 updatedby, string remarks, string sesid);

        DataTable BlockorUnBlockIdsRpt(string env, string action,string idno, string regtype, DateTime frmdate, DateTime todate, Int32 pageIndex, Int32 pageSize);

        DataTable BinaryTabular(string env, Int32 regid, DateTime frmdate, DateTime todate, string rtype, Int32 status, string val);

        DataTable SponsorReport(string env, Int32 regid, Int32 pageindex, Int32 pagesize);

        DataTable UnilevelPrintView(string env, string action, Int32 regid, DateTime frmdate, DateTime todate, Int32 pageindex, Int32 pagesize);

        string GetEwalBalance(string env, string action, int regid);

        DataTable EwalletSummaryRpt(string env, string action, Int32 regid, DateTime frmdate, DateTime todate, Int32 pageindex, Int32 pagesize, double Balance);
        //rk
        DataTable EwalletSummaryRpt1(string env, string action, Int32 regid, DateTime frmdate, DateTime todate, Int32 pageindex, Int32 pagesize, double Balance,Int32 payno);
        string GetWithdrawalEwalBalance(string env, string action, Int32 regid);

        Int32 AddorDeductWithdrawalWallet(string env, string action, Int32 regid, Double amount, String typeofinc, string remarks, Int32 thru, string sessId);

        DataTable AddorDeductWithdrawalRpt(string env, Int32 regid, DateTime frmdate, DateTime todate, Int32 pageindex, Int32 pagesize);

        Int32 AddorDeductWallet(string env, string action, Int32 regid, Double amount, String typeofinc, string remarks, Int32 thru, string sessId);

        DataTable AddorDeductRpt(string env, Int32 regid, DateTime frmdate, DateTime todate, Int32 pageindex, Int32 pagesize);

        DataTable AppConsultantReport(string env, string searchid, Int16 status, DateTime frmdate, DateTime todate, Int32 regid, Int32 stateid, Int32 pageIndex, Int32 pageSize, string Action);

        string InsFeedback(string env, string Idno, string Name, string Email, string Qtype, string State, string Mobile, string Enquiry, string Sessid, string Ipadd);

        DataTable UpdateMemberProfile(string env, Int32 regid, string fname, string lname, string maidenname,
                                                 string dob, string sex, string add1, string add2, string city,
                                                 string district, string state, Int32 pin, string mobile, string eMail, string payeename, string panno, string bank,
                                       string branch, string accno, string ifscode, string nominee,
                                       string relation, string nomineedob, string User, string sessid, string ipaddress, string corcity, string cordistrict, string corstate, Int32 corpin, string GSTNO);

        string UploadKyc(string env, Int32 regid, string ProofType, string panno, string panimg, string bank, string branch, string accno, string ifscode, string chqimg, string sesid, string Remarks, string ModuleType);

        DataTable Kyc(string env, Int32 regid, string Type);

        Int32 ChkEditProfileSts(string env, string action, Int32 regid);

        Int32 UploadMemPhoto(string env, Int32 regid, string image);

        DataTable CheckUserName(string env, string IDNO, string RptType);

        DataTable MakeCreditRequest(string env, Int32 regid, double reqAmt, string mop, string refno,
                                                     DateTime invdate, string invbank, string invbranch, string depbank,
                                                     string depbranch, string depcity, DateTime depdate, string depslip,
                                                     string remarks);
        DataTable MemeberReport(string env,Int32 regid, String RegType, Int32 Status, Int32 pageindex, Int32 pagesize);

        DataTable chkDwnLine(string env, String RegType, Int32 regid);

        DataTable FundTransfer(string env, String regid, String idno, int Amount, String remarks, String sessid);

        DataTable MemberCV(string env, String action, DateTime frmdate, DateTime todate, Int32 regid);

        DataTable UploadCustomerOrder(string env, String action, Int32 regid, string ProofType, string OrderNo, string OrderPhoto, string bank, string accno, string branch, string ifscode, string chqimg, string sesid, string Remarks);

        DataTable GetUniqid(string env);

        Int32 RegistrationOnlineInsert(string env, string action, string userno, Int32 sprno, string spseries, string fname, string lname,
                                                 DateTime dob, string sex, string add1, string add2, string city,
                                                 string district, string state, Int32 pin, string mobile, string eMail, string lpassword,
                                                 string tpassword, string sesid, Int32 downto, string panno, string Title, string guardian,
                                                 string altmobile, string qualification, string subject, string ddrefno, DateTime Refdddate, string refddbank, string ddrefbranch,
                                                 string reftype, Int32 Pid, Int32 BV, string percity,
                                                 string perdistrict, string perstate, Int32 perpin, string landline, string careof, string fullitemcode, string ORDER_ID, string PaymentStatus, string BillStatus, string TXNID, Int32 regid, string CUST_ID, string TXN_AMOUNT, string pgtype);

        DataTable GetRegistrationOnline(string env, string ORDERID);

        Int32 LogOnlineDataNew(string env, string SUBS_ID, string MID, string TXNID, string ORDERID, string BANKTXNID, string TXNAMOUNT, string CURRENCY, string STATUS, string RESPCODE, string RESPMSG, string TXNDATE, string GATEWAYNAME, string BANKNAME, string PAYMENTMODE, string PROMO_CAMP_ID, string PROMO_STATUS, string PROMO_RESPCODE, string CHECKSUMHASH, string remarks);

        DataTable GetPayNo(string env, string type);

        DataTable GetSchrpt(string env, string payno, DateTime frmdate, DateTime todate, string idno, double fromamt, double toamt, string usertype, Int32 pageindex, Int32 pagesize);

        DataTable IneligibleRpt(string env, string type, string val, DateTime frmdate, DateTime todate, string idno, string usertype, Int32 pageindex, Int32 pagesize);

        DataTable PayoutReports_Member(string env, string action, Int32 regid, string payno, Int32 pageIndex, Int32 pageSize);

        Int32 SCOnlineInsert(string env, string action, Int32 regid, string amount, string mobile, string ORDER_ID, string PaymentStatus, string BillStatus, string TXNID, string BillNo, string pgtype, string shpcharge, string scmemtype,string coupon);

        DataTable GetSCOnline(string env, string ORDERID);

        Int32 LogOnlineDataEBSNew(string env, string ResponseCode, string ResponseMessage, string DateCreated, string PaymentID, string MerchantRefNo, string Amount,
            string Mode, string BillingName, string BillingAddress, string BillingCity, string BillingState, string BillingPostalCode, string BillingCountry,
            string BillingPhone, string BillingEmail, string DeliveryName, string DeliveryAddress, string DeliveryCity, string DeliveryState, string DeliveryPostalCode,
            string DeliveryCountry, string DeliveryPhone, string Description, string IsFlagged, string TransactionID, string PaymentMethod, string RequestID,
            string SecureHash, string remarks);

        Int32 CreditRequestOnlineInsert(string env, string action, Int32 regid, double reqAmt, string mop, string refno,
                                                     DateTime invdate, string invbank, string invbranch, string depbank,
                                                     string depbranch, string depcity, DateTime depdate, string depslip,
                                                     string remarks, string ORDER_ID, string PaymentStatus, string BillStatus, string TXNID, string Recode, string pgtype);

        Int32 LogResponse(string env, string merrefno, string responsevalues);

        DataTable GetCreditRequestOnline(string env, string ORDERID);

        Int32 GVDPurchaseOnlineInsert(string env, string action, int regid, string ddrefno, DateTime Refdddate, string refddbank, string ddrefbranch, string reftype,
            int Pid, int BV, string fullitemcode, string sesid, string fname, string lname, string address, string mobile, string city, string district,
            string states, int pin, string ORDER_ID, string PaymentStatus, string BillStatus, string TXNID, string CUST_ID, string TXN_AMOUNT, string pgtype, string billno);

        DataTable GetGVDPurchaseOnline(string env, string ORDERID);

        DataTable UploadMemberIHO(string env, String action, Int32 sno, Int32 regid, string ProofType, string IHOPhoto, Int32 apprej, string sesid, Int32 apprejby, string AppRejRemarks);

        DataTable RePurchageProductRpt(string env, string action,string Category, string SubCategory, string SubCategoryone, Int32 pageIndex, Int32 pageSize);
        //rk
        DataTable CommEWalletRpt(string env, Int32 regid, DateTime frmdate, DateTime todate, Int32 pageindex, Int32 pagesize);
    }
}
