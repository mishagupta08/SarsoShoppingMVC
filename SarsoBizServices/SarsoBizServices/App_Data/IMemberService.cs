using System;
using System.Data;
using System.ServiceModel;

namespace SarsoBizServices
{
    [ServiceContract]
    public interface IMemberService
    {
        [OperationContract]
        DataTable MemberLogin(string username, string password);

        [OperationContract]
        DataTable GetSponsorDet(Int32 regid);

        [OperationContract]
        DataTable MemDashBoard(Int32 regid);

        [OperationContract]
        Int32 MomPhotoRequest(Int32 regid, string ipadd, string sesid);

        [OperationContract]
        DataSet RegPackDet(int pid);

        [OperationContract]
        DataSet RegMcPackDet(int pid, string fullitemcode);

        [OperationContract]
        DataTable CheckRegPin(Int32 cardSNo, string keyNo);

        [OperationContract]
        DataTable GetCountries();

        [OperationContract]
        DataTable GetStates(int countryId);

        [OperationContract]
        DataTable GetDistricts(int stateid);

        [OperationContract]
        DataTable GetCitysInState(string stateid);

        [OperationContract]
        DataTable InsertTempReg(string userno, Int32 sprno, string spseries, string fname, string lname,
                                                 DateTime dob, string sex, string add1, string add2, string city,
                                                 string district, string state, Int32 pin, string mobile, string eMail, string lpassword,
                                                 string tpassword, string sesid, Int32 downto, string panno, string Title, string guardian,
                                                 string altmobile, string qualification, string subject, string ddrefno, DateTime Refdddate, string refddbank, string ddrefbranch,
                                                 string reftype, Int32 Pid, Int32 BV, string percity,
                                                 string perdistrict, string perstate, Int32 perpin, string landline, string careof, string fullitemcode);

        [OperationContract]
        DataTable InsertSalesTempReg(string userno, Int32 sprno, string spseries, string fname, string lname,
                                                DateTime dob, string sex, string add1, string add2, string city,
                                                string district, string state, Int32 pin, string mobile, string eMail, string lpassword,
                                                string tpassword, string panno, string Title, string guardian, string careof, string sesid);

        [OperationContract]
        Int32 InsertGuestReg(string userno, Int32 sprno, string spseries, string Title, string fname, string lname,
                                                string sex, string state, string mobile, string eMail, string lpassword,
                                                string tpassword, string sesid, string decpwd, string CorrAdds, string PerAdds, string CorrCity, string PerCity,
                                                string CorrDistrict, string perDistrict, string Corrddlstate, string perddlstate, string CorrPINCode, string PerPINCode);
        [OperationContract]
        Int32 PartialInsertReg(string userno, Int32 sprno, string spseries, string Title, string fname, string lname,
                                               string sex, string state, string mobile, string eMail, string lpassword, string tpassword, string sesid, string decpwd,
                                                string ddno, DateTime dddate, string ddbank, string ddbranch, string mop, Double Amount, string action, string Unqid,string IP);

        [OperationContract]
        void GetSprSeries(Int32 regid);

        [OperationContract]
        string Getitemcode_Pcode(string pcode);

        [OperationContract]
        void FcpRegCommission(string thru, string sesid);

        [OperationContract]
        DataTable MemberProfile(Int32 regid);

        [OperationContract]
        int BlockIdorBlockToPaid(string action, Int32 regid, Int16 updatedby, string sesid, string remarks);

        [OperationContract]
        int UpdateMemDetailes(Int64 regid, string fName, string lName, string maiden,
                              string mdnMname, string panno, DateTime dob, int age, int sex,
                              string add1, string add2, string city, int districtId, int stateid, int countryid,
                              int pin, string phoneRes, string phoneOff, string mobile,
                              string eMail, string payeeName, string bank, Int64 accno,
                              string branch, string ifscode, string nominee, string relation,
                              int nomage, string sesid, Int32 updatedby);

        [OperationContract]
        DataTable BinaryTreeView(string idno);

        [OperationContract]
        DataTable BinaryTreeViewTooltip(string idno);

        [OperationContract]
        DataTable DirectDownLineReport(Int32 regid);

        [OperationContract]
        DataTable Generationlevels(Int32 regid);

        [OperationContract]
        DataSet BinaryPrintView(string action, Int32 idno, DateTime frmdate, DateTime todate, Int32 pageIndex, Int32 pageSize);

        [OperationContract]
        DataTable BinaryUplevelRpt(Int32 regid, Int32 pageIndex, Int32 pageSize);

        [OperationContract]
        DataTable ConfirmationNote(Int32 regid);

        [OperationContract]
        DataTable WithdrawlRequestRpt(Int32 regid, Int32 pageIndex, Int32 pageSize);

        [OperationContract]
        DataSet RankStatusMem(Int32 regid, Int32 pageIndex, Int32 pageSize);

        [OperationContract]
        void AddorDeductMemEwallet(Int32 regId, string descr, double inAmt, double outAmt,
                                   string remarks, string typeOfInc, string thru, int payNo,
                                   string sessId);

        [OperationContract]
        DataSet Myorders(Int32 regid, Int32 pageIndex, Int32 pageSize);

        [OperationContract]
        int UpdateBankSlips(Int32 regid, string prcode, double amount, string ipadd, string sesid, string src);

        [OperationContract]
        string Chgaddress(Int32 regid, string maidenname,
                                                 string dob, string sex, string add1, string add2, string city,
                                                 string district, string state, Int32 pin, string mobile, string eMail, string corcity, string cordistrict, string corstate, Int32 corpin,string GSTNO);

        [OperationContract]
        string Chgbank(Int32 regid, string payeeName, string panno, string bank, string accno,
                       string branch, string ifscode);

        [OperationContract]
        string Chgnominee(Int32 regid, string nominee, string relation, DateTime NomineeDOB);

        [OperationContract]
        DataTable BigBossReward(Int32 regid);

        [OperationContract]
        DataTable GetProvidersCircles(string action);

        [OperationContract]
        DataTable TmpMobileRech(Int32 regid, string provider, double amount, Int32 mobile, string ipadd);

        [OperationContract]
        DataSet MemberInvoices(string action, Int32 regid);

        [OperationContract]
        void Deletetable(string response);

        [OperationContract]
        void MrUpdate(Int32 regid, string mobile, string provider, string circle, string txnId, double rchAmt,
                      string statusType, string remarks);

        [OperationContract]
        string CheckDownTo(Int32 regid, string downto);

        [OperationContract]
        DataTable MemWithdrawlRequestType(string potratype,string PotraMode,Int32 regid);

        [OperationContract]
        int ChkMemWithdrawlRequest(string action, Int32 regid);

        [OperationContract]
        void MemWithdrawlRequest(string action, Int32 regid, double amount, string remarks, string sesid);

        [OperationContract]
        string ChkMobileEmail(string mobemail, string type);

        [OperationContract]
        DataTable MemberDetailes(Int32 regid);

        [OperationContract]
        DataTable TempMemberDetailes(Int32 regid);

        [OperationContract]
        DataTable AdminEditPermission(Int32 regid);

        [OperationContract]
        int BlockorUnBlock(string action, Int32 regid, Int32 updatedby, string remarks, string sesid);

        [OperationContract]
        DataTable BlockorUnBlockIdsRpt(string action, string idno, string regtype, DateTime frmdate, DateTime todate, Int32 pageIndex, Int32 pageSize);

        [OperationContract]
        DataTable BinaryTabular(Int32 regid, DateTime frmdate, DateTime todate, string rtype, Int32 status, string val);

        [OperationContract]
        DataTable SponsorReport(Int32 regid, Int32 pageindex, Int32 pagesize);

        [OperationContract]
        DataTable UnilevelPrintView(string action, Int32 regid, DateTime frmdate, DateTime todate, Int32 pageindex, Int32 pagesize);

        [OperationContract]
        DataTable EwalletSummaryRpt(string action, Int32 regid, DateTime frmdate, DateTime todate, Int32 pageindex, Int32 pagesize, double Balance);
        //rk
        [OperationContract]
        DataTable EwalletSummaryRpt1(string action, Int32 regid, DateTime frmdate, DateTime todate, Int32 pageindex, Int32 pagesize, double Balance,Int32 payno);
        [OperationContract]
        string GetEwalBalance(string action, Int32 regid);

        [OperationContract]
        Int32 AddorDeductWithdrawalWallet(string action, Int32 regid, Double amount, String typeofinc, string remarks, Int32 thru, string sessId);

        [OperationContract]
        string GetWithdrawalEwalBalance(string action, Int32 regid);

        [OperationContract]
        DataTable AddorDeductWithdrawalRpt(Int32 regid, DateTime frmdate, DateTime todate, Int32 pageindex, Int32 pagesize);

        [OperationContract]
        DataTable AddorDeductRpt(Int32 regid, DateTime frmdate, DateTime todate, Int32 pageindex, Int32 pagesize);

        [OperationContract]
        Int32 AddorDeductWallet(string action, Int32 regid, Double amount, String typeofinc, string remarks, Int32 thru, string sessId);

        [OperationContract]
        DataTable AppConsultantReport(string searchid, Int16 status, DateTime frmdate, DateTime todate, Int32 regid, Int32 stateid, Int32 pageIndex, Int32 pageSize, string Action);

        //04-03
        [OperationContract]
        string InsFeedback(string Idno, string Name, string Email, string Qtype, string State, string Mobile, string Enquiry, string Sessid, string Ipadd);

        [OperationContract]
        DataTable UpdateMemberProfile(Int32 regid, string fname, string lname, string maidenname,
                                       string dob, string sex, string add1, string add2, string city,
                                       string district, string state, Int32 pin, string mobile, string eMail, string payeename, string panno, string bank,
                                       string branch, string accno, string ifscode, string nominee,
                                       string relation, string nomineedob, string User, string sessid, string ipaddress, string corcity, string cordistrict, string corstate, Int32 corpin, string GSTNO);

        [OperationContract]
        DataTable Kyc(Int32 regid, string Type);

        [OperationContract]
        string UploadKyc(Int32 regid, string ProofType, string panno, string panimg, string bank, string branch, string accno, string ifscode, string chqimg, string sesid, string Remarks, string ModuleType);

        [OperationContract]
        Int32 ChkEditProfileSts(string action, Int32 regid);

        [OperationContract]
        Int32 UploadMemPhoto(Int32 regid, string image);

        [OperationContract]
        DataTable CheckUserName(string IDNO, string RptType);

        [OperationContract]
        DataTable MakeCreditRequest(Int32 regid, double reqAmt, string mop, string refno,
                                                     DateTime invdate, string invbank, string invbranch, string depbank,
                                                     string depbranch, string depcity, DateTime depdate, string depslip,
                                                     string remarks);
        [OperationContract]
        DataTable MemeberReport(Int32 regid, String RegType, Int32 Status, Int32 pageindex, Int32 pagesize);

        [OperationContract]
        DataTable chkDwnLine(String RegType, Int32 regid);

        [OperationContract]
        DataTable FundTransfer(String regid, String idno, int Amount, String remarks, String sessid);

        [OperationContract]
        DataTable MemberCV(String action, DateTime frmdate, DateTime todate, Int32 regid);

        [OperationContract]
        DataTable UploadCustomerOrder(String action, Int32 regid, string ProofType, string OrderNo, string OrderPhoto, string bank, string accno, string branch, string ifscode, string chqimg, string sesid, string Remarks);

        [OperationContract]
        DataTable GetUniqid();

        [OperationContract]
        Int32 RegistrationOnlineInsert(string action, string userno, Int32 sprno, string spseries, string fname, string lname,
                                                 DateTime dob, string sex, string add1, string add2, string city,
                                                 string district, string state, Int32 pin, string mobile, string eMail, string lpassword,
                                                 string tpassword, string sesid, Int32 downto, string panno, string Title, string guardian,
                                                 string altmobile, string qualification, string subject, string ddrefno, DateTime Refdddate, string refddbank, string ddrefbranch,
                                                 string reftype, Int32 Pid, Int32 BV, string percity,
                                                 string perdistrict, string perstate, Int32 perpin, string landline, string careof, string fullitemcode, string ORDER_ID, string PaymentStatus, string BillStatus, string TXNID, Int32 regid, string CUST_ID, string TXN_AMOUNT, string pgtype);

        [OperationContract]
        DataTable GetRegistrationOnline(string ORDERID);

        [OperationContract]
        Int32 LogOnlineDataNew(string SUBS_ID, string MID, string TXNID, string ORDERID, string BANKTXNID, string TXNAMOUNT, string CURRENCY, string STATUS, string RESPCODE, string RESPMSG, string TXNDATE, string GATEWAYNAME, string BANKNAME, string PAYMENTMODE, string PROMO_CAMP_ID, string PROMO_STATUS, string PROMO_RESPCODE, string CHECKSUMHASH, string remarks);

        [OperationContract]
        DataTable GetPayNo(string type);

        [OperationContract]
        DataTable GetSchrpt(string payno, DateTime frmdate, DateTime todate, string idno, double fromamt, double toamt, string usertype, Int32 pageindex, Int32 pagesize);

        [OperationContract]
        DataTable IneligibleRpt(string type, string val, DateTime frmdate, DateTime todate, string idno, string usertype, Int32 pageindex, Int32 pagesize);

        [OperationContract]
        DataTable PayoutReports_Member(string action, Int32 regid, string payno, Int32 pageIndex, Int32 pageSize);

        [OperationContract]
        Int32 SCOnlineInsert(string action, Int32 regid, string amount, string mobile, string ORDER_ID, string PaymentStatus, string BillStatus, string TXNID, string BillNo, string pgtype, string shpcharge, string scmemtype,string coupon);

        [OperationContract]
        DataTable GetSCOnline(string ORDERID);

        [OperationContract]
        Int32 LogOnlineDataEBSNew(string ResponseCode, string ResponseMessage, string DateCreated, string PaymentID, string MerchantRefNo, string Amount, 
            string Mode, string BillingName, string BillingAddress, string BillingCity, string BillingState, string BillingPostalCode, string BillingCountry, 
            string BillingPhone, string BillingEmail, string DeliveryName, string DeliveryAddress, string DeliveryCity, string DeliveryState, string DeliveryPostalCode, 
            string DeliveryCountry, string DeliveryPhone, string Description, string IsFlagged, string TransactionID, string PaymentMethod, string RequestID, 
            string SecureHash, string remarks);

        [OperationContract]
        Int32 CreditRequestOnlineInsert(string action, Int32 regid, double reqAmt, string mop, string refno,
                                                     DateTime invdate, string invbank, string invbranch, string depbank,
                                                     string depbranch, string depcity, DateTime depdate, string depslip,
                                                     string remarks, string ORDER_ID, string PaymentStatus, string BillStatus, string TXNID, string Recode, string pgtype);
        [OperationContract]
        Int32 LogResponse(string merrefno, string responsevalues);

        [OperationContract]
        DataTable GetCreditRequestOnline(string ORDERID);

        [OperationContract]
        Int32 GVDPurchaseOnlineInsert(string action, int regid, string ddrefno, DateTime Refdddate, string refddbank, string ddrefbranch, string reftype, 
            int Pid, int BV, string fullitemcode,string sesid, string fname, string lname, string address, string mobile, string city, string district, 
            string states, int pin, string ORDER_ID, string PaymentStatus, string BillStatus, string TXNID, string CUST_ID, string TXN_AMOUNT, string pgtype,string billno);

        [OperationContract]
        DataTable GetGVDPurchaseOnline(string ORDERID);

        [OperationContract]
        DataTable UploadMemberIHO(String action, Int32 sno, Int32 regid, string ProofType, string IHOPhoto, Int32 apprej, string sesid, Int32 apprejby, string AppRejRemarks);

        [OperationContract]
        DataTable RePurchageProductRpt(string action, string Category, string SubCategory, string SubCategoryone, Int32 pageIndex, Int32 pageSize);
        //rk
        [OperationContract]
        DataTable CommEWalletRpt(Int32 regid, DateTime frmdate, DateTime todate, Int32 pageindex, Int32 pagesize);
    }
}
