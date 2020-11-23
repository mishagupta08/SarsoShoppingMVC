using System;
using System.Configuration;
using System.Data;
using SarsoBizDal;

namespace SarsoBizServices
{
    public class MemberService : IMemberService
    {
        readonly string _environment = ConfigurationManager.AppSettings["Environment"];

        public DataTable MemberLogin(string username, string password)
        {
            return SarsoBizsDal.Instance.MemberModule.MemberLogin(_environment, username, password);
        }

        public DataTable GetSponsorDet(Int32 regid)
        {
            return SarsoBizsDal.Instance.MemberModule.GetSponsorDet(_environment, regid);
        }

        public DataTable MemDashBoard(Int32 regid)
        {
            return SarsoBizsDal.Instance.MemberModule.MemDashBoard(_environment, regid);
        }

        public Int32 MomPhotoRequest(Int32 regid, string ipadd, string sesid)
        {
            return SarsoBizsDal.Instance.MemberModule.MomPhotoRequest(_environment, regid, ipadd, sesid);
        }

        public DataSet RegPackDet(int pid)
        {
            return SarsoBizsDal.Instance.MemberModule.RegPackDet(_environment, pid);
        }

        public DataSet RegMcPackDet(int pid, string fullitemcode)
        {
            return SarsoBizsDal.Instance.MemberModule.RegMcPackDet(_environment, pid, fullitemcode);
        }

        public DataTable CheckRegPin(Int32 cardSNo, string keyNo)
        {
            return SarsoBizsDal.Instance.MemberModule.CheckRegPin(_environment, cardSNo, keyNo);
        }

        public DataTable GetCountries()
        {
            return SarsoBizsDal.Instance.MemberModule.GetCountries(_environment);
        }

        public DataTable GetStates(int countryId)
        {
            return SarsoBizsDal.Instance.MemberModule.GetStates(_environment, countryId);
        }

        public DataTable GetDistricts(int stateid)
        {
            return SarsoBizsDal.Instance.MemberModule.GetDistricts(_environment, stateid);
        }

        public DataTable GetCitysInState(string stateid)
        {
            return SarsoBizsDal.Instance.MemberModule.GetCitysInState(_environment, stateid);
        }
        public DataTable InsertTempReg(string userno, Int32 sprno, string spseries, string fname, string lname,
                                                 DateTime dob, string sex, string add1, string add2, string city,
                                                 string district, string state, Int32 pin, string mobile, string eMail, string lpassword,
                                                 string tpassword, string sesid, Int32 downto, string panno, string Title, string guardian,
                                                 string altmobile, string qualification, string subject, string ddrefno, DateTime Refdddate, string refddbank, string ddrefbranch,
                                                 string reftype, Int32 Pid, Int32 BV, string percity,
                                                 string perdistrict, string perstate, Int32 perpin, string landline, string careof, string fullitemcode)
        {
            return SarsoBizsDal.Instance.MemberModule.InsertTempReg(_environment, userno, sprno, spseries, fname, lname, dob, sex, add1, add2, city,
                                                 district, state, pin, mobile, eMail, lpassword, tpassword, sesid, downto, panno, Title, guardian,
                              altmobile, qualification, subject, ddrefno, Refdddate, refddbank, ddrefbranch, reftype, Pid, BV, percity, perdistrict, perstate, perpin, landline, careof, fullitemcode);
        }

        public DataTable InsertSalesTempReg(string userno, Int32 sprno, string spseries, string fname, string lname,
                                                DateTime dob, string sex, string add1, string add2, string city,
                                                string district, string state, Int32 pin, string mobile, string eMail, string lpassword,
                                                string tpassword, string panno, string Title, string guardian, string careof, string sesid)
        {
            return SarsoBizsDal.Instance.MemberModule.InsertSalesTempReg(_environment, userno, sprno, spseries, fname, lname, dob, sex, add1, add2, city,
                                                 district, state, pin, mobile, eMail, lpassword, tpassword, panno, Title, guardian,careof, sesid);
        }

        public Int32 InsertGuestReg(string userno, Int32 sprno, string spseries, string Title, string fname, string lname,
                                                string sex, string state, string mobile, string eMail, string lpassword,
                                                string tpassword, string sesid, string decpwd, string CorrAdds, string PerAdds, string CorrCity, string PerCity, 
                                                string CorrDistrict, string perDistrict, string Corrddlstate, string perddlstate, string CorrPINCode, string PerPINCode)
        {
            return SarsoBizsDal.Instance.MemberModule.InsertGuestReg(_environment, userno, sprno, spseries, Title, fname, lname, sex, state, mobile, eMail, lpassword, tpassword, sesid, decpwd, CorrAdds, PerAdds, CorrCity, PerCity, CorrDistrict, perDistrict, Corrddlstate, perddlstate, CorrPINCode, PerPINCode);
        }
        public Int32 PartialInsertReg(string userno, Int32 sprno, string spseries, string Title, string fname, string lname,
                                               string sex, string state, string mobile, string eMail, string lpassword, string tpassword, string sesid, string decpwd,
                                                string ddno, DateTime dddate, string ddbank, string ddbranch, string mop, Double Amount, string action, string Unqid, string IP)
        {
            return SarsoBizsDal.Instance.MemberModule.PartialInsertReg(_environment, userno, sprno, spseries, Title, fname, lname, sex, state, mobile, eMail, lpassword, tpassword, sesid, decpwd, ddno, dddate, ddbank, ddbranch, mop, Amount, action, Unqid,IP);
        }
        public void GetSprSeries(Int32 regid)
        {
            SarsoBizsDal.Instance.MemberModule.GetSprSeries(_environment, regid);
        }

        public string Getitemcode_Pcode(string pcode)
        {
            return SarsoBizsDal.Instance.MemberModule.Getitemcode_Pcode(_environment, pcode);
        }

        public void FcpRegCommission(string thru, string sesid)
        {
            SarsoBizsDal.Instance.MemberModule.FcpRegCommission(_environment, thru, sesid);
        }

        public DataTable MemberProfile(Int32 regid)
        {
            return SarsoBizsDal.Instance.MemberModule.MemberProfile(_environment, regid);
        }

        public int BlockIdorBlockToPaid(string action, Int32 regid, Int16 updatedby, string sesid, string remarks)
        {
            return SarsoBizsDal.Instance.MemberModule.BlockIdorBlockToPaid(_environment, action, regid, updatedby, sesid, remarks);
        }

        public int UpdateMemDetailes(Int64 regid, string fName, string lName, string maiden,
                              string mdnMname, string panno, DateTime dob, int age, int sex,
                              string add1, string add2, string city, int districtId, int stateid, int countryid,
                              int pin, string phoneRes, string phoneOff, string mobile,
                              string eMail, string payeeName, string bank, Int64 accno,
                              string branch, string ifscode, string nominee, string relation,
                              int nomage, string sesid, Int32 updatedby)
        {
            return SarsoBizsDal.Instance.MemberModule.UpdateMemDetailes(_environment, regid, fName, lName, maiden,
                                                                  mdnMname, panno, dob, age, sex,
                                                                  add1, add2, city, districtId, stateid, countryid,
                                                                  pin, phoneRes, phoneOff, mobile,
                                                                  eMail, payeeName, bank, accno,
                                                                  branch, ifscode, nominee, relation,
                                                                  nomage, sesid, updatedby);
        }

        public DataTable BinaryTreeView(string idno)
        {
            return SarsoBizsDal.Instance.MemberModule.BinaryTreeView(_environment, idno);
        }

        public DataTable BinaryTreeViewTooltip(string idno)
        {
            return SarsoBizsDal.Instance.MemberModule.BinaryTreeViewTooltip(_environment, idno);
        }

        public DataTable DirectDownLineReport(Int32 regid)
        {
            return SarsoBizsDal.Instance.MemberModule.DirectDownLineReport(_environment, regid);
        }

        public DataTable Generationlevels(Int32 regid)
        {
            return SarsoBizsDal.Instance.MemberModule.Generationlevels(_environment, regid);
        }

        public DataSet BinaryPrintView(string action, Int32 idno, DateTime frmdate, DateTime todate, Int32 pageIndex, Int32 pageSize)
        {
            return SarsoBizsDal.Instance.MemberModule.BinaryPrintView(_environment, action, idno, frmdate, todate, pageIndex, pageSize);
        }

        public DataTable BinaryUplevelRpt(Int32 regid, Int32 pageIndex, Int32 pageSize)
        {
            return SarsoBizsDal.Instance.MemberModule.BinaryUplevelRpt(_environment, regid, pageIndex, pageSize);
        }
        public DataTable ConfirmationNote(Int32 regid)
        {
            return SarsoBizsDal.Instance.MemberModule.ConfirmationNote(_environment, regid);
        }

        public DataTable WithdrawlRequestRpt(Int32 regid, Int32 pageIndex, Int32 pageSize)
        {
            return SarsoBizsDal.Instance.MemberModule.WithdrawlRequestRpt(_environment, regid, pageIndex, pageSize);
        }

        public DataSet RankStatusMem(Int32 regid, Int32 pageIndex, Int32 pageSize)
        {
            return SarsoBizsDal.Instance.MemberModule.RankStatusMem(_environment, regid, pageIndex, pageSize);
        }

        public void AddorDeductMemEwallet(Int32 regId, string descr, double inAmt, double outAmt,
                                                         string remarks, string typeOfInc, string thru, int payNo,
                                                         string sessId)
        {
            SarsoBizsDal.Instance.MemberModule.AddorDeductMemEwallet(_environment, regId, descr, inAmt, outAmt,
                                                                                 remarks, typeOfInc, thru, payNo,
                                                                                 sessId);
        }

        public DataSet Myorders(Int32 regid, Int32 pageIndex, Int32 pageSize)
        {
            return SarsoBizsDal.Instance.MemberModule.Myorders(_environment, regid, pageIndex, pageSize);
        }


        public int UpdateBankSlips(Int32 regid, string prcode, double amount, string ipadd, string sesid, string src)
        {
            return SarsoBizsDal.Instance.MemberModule.UpdateBankSlips(_environment, regid, prcode, amount, ipadd, sesid, src);
        }

        public string Chgaddress(Int32 regid, string maidenname,
                                                 string dob, string sex, string add1, string add2, string city,
                                                 string district, string state, Int32 pin, string mobile, string eMail, string corcity, string cordistrict, string corstate, Int32 corpin, string GSTNO)
        {
            return SarsoBizsDal.Instance.MemberModule.Chgaddress(_environment, regid, maidenname,
                                                  dob,  sex,  add1,  add2,  city,
                                                  district,  state,  pin,  mobile,  eMail, corcity, cordistrict, corstate, corpin,GSTNO);
        }
        public string Chgbank(Int32 regid, string payeeName, string panno, string bank, string accno,
                              string branch, string ifscode)
        {
            return SarsoBizsDal.Instance.MemberModule.Chgbank(_environment, regid, payeeName, panno, bank, accno, branch,
                                                                      ifscode);
        }
        public string Chgnominee(Int32 regid, string nominee, string relation, DateTime NomineeDOB)
        {
            return SarsoBizsDal.Instance.MemberModule.Chgnominee(_environment, regid, nominee, relation, NomineeDOB);
        }
        public DataTable BigBossReward(Int32 regid)
        {
            return SarsoBizsDal.Instance.MemberModule.BigBossReward(_environment, regid);
        }
        public DataTable GetProvidersCircles(string action)
        {
            return SarsoBizsDal.Instance.MemberModule.GetProvidersCircles(_environment, action);
        }
        public DataTable TmpMobileRech(Int32 regid, string provider, double amount, Int32 mobile, string ipadd)
        {
            return SarsoBizsDal.Instance.MemberModule.TmpMobileRech(_environment, regid, provider, amount, mobile, ipadd);
        }
        public DataSet MemberInvoices(string action, Int32 regid)
        {
            return SarsoBizsDal.Instance.MemberModule.MemberInvoices(_environment, action, regid);
        }

        public void Deletetable(string response)
        {
            SarsoBizsDal.Instance.MemberModule.Deletetable(_environment, response);
        }

        public void MrUpdate(Int32 regid, string mobile, string provider, string circle, string txnId, double rchAmt, string statusType, string remarks)
        {
            SarsoBizsDal.Instance.MemberModule.MrUpdate(_environment, regid, mobile, provider, circle, txnId, rchAmt, statusType, remarks);
        }

        public string CheckDownTo(Int32 regid, string downto)
        {
            return SarsoBizsDal.Instance.MemberModule.CheckDownTo(_environment, regid, downto);
        }
        public DataTable MemWithdrawlRequestType(string potratype,string PotraMode ,Int32 regid)
        {
            return SarsoBizsDal.Instance.MemberModule.MemWithdrawlRequestType(_environment, potratype, PotraMode,regid);
        }
        public int ChkMemWithdrawlRequest(string action, Int32 regid)
        {
            return SarsoBizsDal.Instance.MemberModule.ChkMemWithdrawlRequest(_environment, action, regid);
        }
        public void MemWithdrawlRequest(string action, Int32 regid, double amount, string remarks, string sesid)
        {
            SarsoBizsDal.Instance.MemberModule.MemWithdrawlRequest(_environment, action, regid, amount, remarks, sesid);
        }
        public string ChkMobileEmail(string mobemail, string type)
        {
            return SarsoBizsDal.Instance.MemberModule.ChkMobileEmail(_environment, mobemail, type);
        }
        public DataTable MemberDetailes(Int32 regid)
        {
            return SarsoBizsDal.Instance.MemberModule.MemberDetailes(_environment, regid);
        }
        public DataTable TempMemberDetailes(Int32 regid)
        {
            return SarsoBizsDal.Instance.MemberModule.TempMemberDetailes(_environment, regid);
        }
        public DataTable AdminEditPermission(Int32 regid)
        {
            return SarsoBizsDal.Instance.MemberModule.AdminEditPermission(_environment, regid);
        }
        public int BlockorUnBlock(string action, Int32 regid, Int32 updatedby, string remarks, string sesid)
        {
            return SarsoBizsDal.Instance.MemberModule.BlockorUnBlock(_environment, action, regid, updatedby, remarks, sesid);
        }

        public DataTable BlockorUnBlockIdsRpt(string action, string idno, string regtype, DateTime frmdate, DateTime todate, Int32 pageIndex, Int32 pageSize)
        {
            return SarsoBizsDal.Instance.MemberModule.BlockorUnBlockIdsRpt(_environment, action, idno, regtype, frmdate, todate, pageIndex, pageSize);
        }

        public DataTable BinaryTabular(Int32 regid, DateTime frmdate, DateTime todate, string rtype, Int32 status, string val)
        {
            return SarsoBizsDal.Instance.MemberModule.BinaryTabular(_environment, regid, frmdate, todate, rtype, status, val);
        }

        public DataTable SponsorReport(Int32 regid, Int32 pageindex, Int32 pagesize)
        {
            return SarsoBizsDal.Instance.MemberModule.SponsorReport(_environment, regid, pageindex, pagesize);
        }
        public DataTable UnilevelPrintView(string action, Int32 regid, DateTime frmdate, DateTime todate, Int32 pageindex, Int32 pagesize)
        {
            return SarsoBizsDal.Instance.MemberModule.UnilevelPrintView(_environment, action, regid, frmdate, todate, pageindex, pagesize);
        }

        //29-2 Satish
        public string GetEwalBalance(string action, Int32 regid)
        {
            return SarsoBizsDal.Instance.MemberModule.GetEwalBalance(_environment, action, regid);
        }
        public DataTable EwalletSummaryRpt(string action, Int32 regid, DateTime frmdate, DateTime todate, Int32 pageindex, Int32 pagesize, double Balance)
        {
            return SarsoBizsDal.Instance.MemberModule.EwalletSummaryRpt(_environment, action, regid, frmdate, todate, pageindex, pagesize, Balance);
        }
        //rk
        public DataTable EwalletSummaryRpt1(string action, Int32 regid, DateTime frmdate, DateTime todate, Int32 pageindex, Int32 pagesize, double Balance,Int32 payno)
        {
            return SarsoBizsDal.Instance.MemberModule.EwalletSummaryRpt1(_environment, action, regid, frmdate, todate, pageindex, pagesize, Balance,payno);
        }
        public string GetWithdrawalEwalBalance(string action, Int32 regid)
        {
            return SarsoBizsDal.Instance.MemberModule.GetWithdrawalEwalBalance(_environment, action, regid);
        }
        public Int32 AddorDeductWithdrawalWallet(string action, Int32 regid, Double amount, String typeofinc, string remarks, Int32 thru, string sessId)
        {
            return SarsoBizsDal.Instance.MemberModule.AddorDeductWithdrawalWallet(_environment, action, regid, amount, typeofinc, remarks, thru, sessId);
        }
        public DataTable AddorDeductWithdrawalRpt(Int32 regid, DateTime frmdate, DateTime todate, Int32 pageindex, Int32 pagesize)
        {
            return SarsoBizsDal.Instance.MemberModule.AddorDeductWithdrawalRpt(_environment, regid, frmdate, todate, pageindex, pagesize);
        }
        public DataTable AddorDeductRpt(Int32 regid, DateTime frmdate, DateTime todate, Int32 pageindex, Int32 pagesize)
        {
            return SarsoBizsDal.Instance.MemberModule.AddorDeductRpt(_environment, regid, frmdate, todate, pageindex, pagesize);
        }
        public Int32 AddorDeductWallet(string action, Int32 regid, Double amount, String typeofinc, string remarks, Int32 thru, string sessId)
        {
            return SarsoBizsDal.Instance.MemberModule.AddorDeductWallet(_environment, action, regid, amount, typeofinc, remarks, thru, sessId);
        }
        public DataTable AppConsultantReport(string searchid, Int16 status, DateTime frmdate, DateTime todate, Int32 regid, Int32 stateid, Int32 pageIndex, Int32 pageSize, string Action)
        {
            return SarsoBizsDal.Instance.MemberModule.AppConsultantReport(_environment, searchid, status, frmdate, todate, regid, stateid, pageIndex, pageSize, Action);
        }
        //04-03
        public string InsFeedback(string Idno, string Name, string Email, string Qtype, string State, string Mobile, string Enquiry, string Sessid, string Ipadd)
        {
            return SarsoBizsDal.Instance.MemberModule.InsFeedback(_environment, Idno, Name, Email, Qtype, State, Mobile, Enquiry, Sessid, Ipadd);
        }

        public DataTable UpdateMemberProfile(Int32 regid, string fname, string lname, string maidenname,
                                                 string dob, string sex, string add1, string add2, string city,
                                                 string district, string state, Int32 pin, string mobile, string eMail, string payeename, string panno, string bank,
                                       string branch, string accno, string ifscode, string nominee,
                                       string relation, string nomineedob, string User, string sessid, string ipaddress, string corcity, string cordistrict, string corstate, Int32 corpin, string GSTNO)
        {
            return SarsoBizsDal.Instance.MemberModule.UpdateMemberProfile(_environment, regid, fname, lname, maidenname, dob, sex,
                                                                               add1, add2, city,
                                                                               district, state, pin, mobile,
                                                                               eMail, payeename, panno, bank,
                                                                               branch, accno, ifscode, nominee,
                                                                               relation, nomineedob, User, sessid, ipaddress,corcity,cordistrict,corstate,corpin,GSTNO);
        }

        public string UploadKyc(Int32 regid, string ProofType, string panno, string panimg, string bank, string branch, string accno, string ifscode, string chqimg, string sesid, string Remarks, string ModuleType)
        {
            return SarsoBizsDal.Instance.MemberModule.UploadKyc(_environment, regid, ProofType, panno, panimg, bank, branch, accno, ifscode, chqimg, sesid, Remarks, ModuleType);
        }

        public DataTable Kyc(Int32 regid, string Type)
        {
            return SarsoBizsDal.Instance.MemberModule.Kyc(_environment, regid, Type);
        }
        public Int32 UploadMemPhoto(Int32 regid, string image)
        {
            return SarsoBizsDal.Instance.MemberModule.UploadMemPhoto(_environment, regid, image);
        }
        public Int32 ChkEditProfileSts(string action, Int32 regid)
        {
            return SarsoBizsDal.Instance.MemberModule.ChkEditProfileSts(_environment, action, regid);
        }

        public DataTable CheckUserName(string IDNO, string RptType)
        {
            return SarsoBizsDal.Instance.MemberModule.CheckUserName(_environment, IDNO, RptType);
        }

        public DataTable MakeCreditRequest(Int32 regid, double reqAmt, string mop, string refno,
                                                     DateTime invdate, string invbank, string invbranch, string depbank,
                                                     string depbranch, string depcity, DateTime depdate, string depslip,
                                                     string remarks)
        {
            return SarsoBizsDal.Instance.MemberModule.MakeCreditRequest(_environment, regid, reqAmt, mop, refno, invdate, invbank, invbranch, depbank, depbranch, depcity, depdate, depslip, remarks);
        }
        public DataTable MemeberReport(Int32 regid, String RegType, Int32 Status, Int32 pageindex, Int32 pagesize)
        {
            return SarsoBizsDal.Instance.MemberModule.MemeberReport(_environment, regid, RegType, Status, pageindex, pagesize);
        }
        public DataTable chkDwnLine(String RegType, Int32 regid)
        {
            return SarsoBizsDal.Instance.MemberModule.chkDwnLine(_environment, RegType, regid);
        }

        public DataTable FundTransfer(String regid, String idno, int Amount, String remarks, String sessid)
        {
            return SarsoBizsDal.Instance.MemberModule.FundTransfer(_environment, regid, idno, Amount, remarks, sessid);
        }

        public DataTable MemberCV(String action, DateTime frmdate, DateTime todate, Int32 regid)
        {
            return SarsoBizsDal.Instance.MemberModule.MemberCV(_environment, action,frmdate, todate, regid);
        }

        public DataTable UploadCustomerOrder(String action, Int32 regid, string ProofType, string OrderNo, string OrderPhoto, string bank, string accno, string branch, string ifscode, string chqimg, string sesid, string Remarks)
        {
            return SarsoBizsDal.Instance.MemberModule.UploadCustomerOrder(_environment, action, regid, ProofType, OrderNo, OrderPhoto, bank, accno, branch, ifscode, chqimg, sesid, Remarks);
        }

        public DataTable GetUniqid()
        {
            return SarsoBizsDal.Instance.MemberModule.GetUniqid(_environment);
        }
        public Int32 RegistrationOnlineInsert(string action, string userno, Int32 sprno, string spseries, string fname, string lname,
                                                 DateTime dob, string sex, string add1, string add2, string city,
                                                 string district, string state, Int32 pin, string mobile, string eMail, string lpassword,
                                                 string tpassword, string sesid, Int32 downto, string panno, string Title, string guardian,
                                                 string altmobile, string qualification, string subject, string ddrefno, DateTime Refdddate, string refddbank, string ddrefbranch,
                                                 string reftype, Int32 Pid, Int32 BV, string percity,
                                                 string perdistrict, string perstate, Int32 perpin, string landline, string careof, string fullitemcode, string ORDER_ID, string PaymentStatus, string BillStatus, string TXNID, Int32 regid, string CUST_ID, string TXN_AMOUNT, string pgtype)
        {
            return SarsoBizsDal.Instance.MemberModule.RegistrationOnlineInsert(_environment, action, userno, sprno, spseries, fname, lname, dob, sex, add1, add2, city, district, state, pin, mobile, eMail, lpassword, tpassword, sesid,
    downto, panno, Title, guardian, altmobile, qualification, subject, ddrefno, Refdddate, refddbank, ddrefbranch, reftype, Pid, BV, percity, perdistrict, perstate,
    perpin, landline, careof, fullitemcode, ORDER_ID, PaymentStatus, BillStatus, TXNID, regid, CUST_ID, TXN_AMOUNT,pgtype);
        }

        public DataTable GetRegistrationOnline(string ORDERID)
        {
            return SarsoBizsDal.Instance.MemberModule.GetRegistrationOnline(_environment, ORDERID);
        }

        public Int32 LogOnlineDataNew(string SUBS_ID, string MID, string TXNID, string ORDERID, string BANKTXNID, string TXNAMOUNT, string CURRENCY, string STATUS, string RESPCODE, string RESPMSG, string TXNDATE, string GATEWAYNAME, string BANKNAME, string PAYMENTMODE, string PROMO_CAMP_ID, string PROMO_STATUS, string PROMO_RESPCODE, string CHECKSUMHASH, string remarks)
        {
            return SarsoBizsDal.Instance.MemberModule.LogOnlineDataNew(_environment, SUBS_ID, MID, TXNID, ORDERID, BANKTXNID, TXNAMOUNT, CURRENCY, STATUS, RESPCODE, RESPMSG, TXNDATE, GATEWAYNAME, BANKNAME, PAYMENTMODE, PROMO_CAMP_ID, PROMO_STATUS, PROMO_RESPCODE, CHECKSUMHASH, remarks);
        }

        public DataTable GetPayNo(string type)
        {
            return SarsoBizsDal.Instance.MemberModule.GetPayNo(_environment, type);
        }
        public DataTable GetSchrpt(string payno, DateTime frmdate, DateTime todate, string idno, double fromamt, double toamt, string usertype, Int32 pageindex, Int32 pagesize)
        {
            return SarsoBizsDal.Instance.MemberModule.GetSchrpt(_environment, payno, frmdate, todate, idno, fromamt, toamt, usertype, pageindex, pagesize);
        }
        public DataTable IneligibleRpt(string type, string val, DateTime frmdate, DateTime todate, string idno, string usertype, Int32 pageindex, Int32 pagesize)
        {
            return SarsoBizsDal.Instance.MemberModule.IneligibleRpt(_environment, type, val, frmdate, todate, idno, usertype, pageindex, pagesize);
        }
        public DataTable PayoutReports_Member(string action, Int32 regid, string payno, Int32 pageIndex, Int32 pageSize)
        {
            return SarsoBizsDal.Instance.MemberModule.PayoutReports_Member(_environment, action, regid, payno, pageIndex, pageSize);
        }


        public Int32 SCOnlineInsert(string action, Int32 regid, string amount, string mobile, string ORDER_ID, string PaymentStatus, string BillStatus, string TXNID, string BillNo, string pgtype, string shpcharge, string scmemtype,string coupon)
        {
            return SarsoBizsDal.Instance.MemberModule.SCOnlineInsert(_environment, action, regid, amount, mobile, ORDER_ID, PaymentStatus, BillStatus, TXNID, BillNo, pgtype, shpcharge, scmemtype, coupon);
        }
        public DataTable GetSCOnline(string ORDERID)
        {
            return SarsoBizsDal.Instance.MemberModule.GetSCOnline(_environment, ORDERID);
        }
        public Int32 LogOnlineDataEBSNew(string ResponseCode, string ResponseMessage, string DateCreated, string PaymentID, string MerchantRefNo, string Amount,
            string Mode, string BillingName, string BillingAddress, string BillingCity, string BillingState, string BillingPostalCode, string BillingCountry,
            string BillingPhone, string BillingEmail, string DeliveryName, string DeliveryAddress, string DeliveryCity, string DeliveryState, string DeliveryPostalCode,
            string DeliveryCountry, string DeliveryPhone, string Description, string IsFlagged, string TransactionID, string PaymentMethod, string RequestID,
            string SecureHash, string remarks)
        {
            return SarsoBizsDal.Instance.MemberModule.LogOnlineDataEBSNew(_environment, ResponseCode, ResponseMessage, DateCreated, PaymentID, MerchantRefNo, Amount, 
                Mode, BillingName, BillingAddress, BillingCity, BillingState,BillingPostalCode, BillingCountry, 
                BillingPhone, BillingEmail, DeliveryName, DeliveryAddress, DeliveryCity, DeliveryState, DeliveryPostalCode,
                DeliveryCountry, DeliveryPhone, Description, IsFlagged, TransactionID, PaymentMethod, RequestID, SecureHash, remarks);
        }
        public Int32 CreditRequestOnlineInsert(string action, Int32 regid, double reqAmt, string mop, string refno,
                                                     DateTime invdate, string invbank, string invbranch, string depbank,
                                                     string depbranch, string depcity, DateTime depdate, string depslip,
                                                     string remarks, string ORDER_ID, string PaymentStatus, string BillStatus, string TXNID, string Recode, string pgtype)
        {
            return SarsoBizsDal.Instance.MemberModule.CreditRequestOnlineInsert(_environment, action, regid, reqAmt, mop, refno,
                                                     invdate, invbank, invbranch, depbank,
                                                     depbranch, depcity, depdate, depslip,
                                                     remarks, ORDER_ID, PaymentStatus, BillStatus, TXNID, Recode, pgtype);
        }
        public Int32 LogResponse(string merrefno, string responsevalues)
        {
            return SarsoBizsDal.Instance.MemberModule.LogResponse(_environment, merrefno, responsevalues);
        }
        public DataTable GetCreditRequestOnline(string ORDERID)
        {
            return SarsoBizsDal.Instance.MemberModule.GetCreditRequestOnline(_environment, ORDERID);
        }
        public Int32 GVDPurchaseOnlineInsert(string action, int regid, string ddrefno, DateTime Refdddate, string refddbank, string ddrefbranch, string reftype,
            int Pid, int BV, string fullitemcode, string sesid, string fname, string lname, string address, string mobile, string city, string district,
            string states, int pin, string ORDER_ID, string PaymentStatus, string BillStatus, string TXNID, string CUST_ID, string TXN_AMOUNT, string pgtype, string billno)
        {
            return SarsoBizsDal.Instance.MemberModule.GVDPurchaseOnlineInsert(_environment, action, regid, ddrefno, Refdddate, refddbank, ddrefbranch, reftype,
            Pid, BV, fullitemcode, sesid, fname, lname, address, mobile, city, district,
            states, pin, ORDER_ID, PaymentStatus, BillStatus, TXNID, CUST_ID, TXN_AMOUNT, pgtype, billno);
        }
        public DataTable GetGVDPurchaseOnline(string ORDERID)
        {
            return SarsoBizsDal.Instance.MemberModule.GetGVDPurchaseOnline(_environment, ORDERID);
        }
        public DataTable UploadMemberIHO(String action, Int32 sno, Int32 regid, string ProofType, string IHOPhoto, Int32 apprej, string sesid, Int32 apprejby, string AppRejRemarks)
        {
            return SarsoBizsDal.Instance.MemberModule.UploadMemberIHO(_environment, action, sno, regid, ProofType, IHOPhoto, apprej, sesid, apprejby, AppRejRemarks);
        }

        public DataTable RePurchageProductRpt(string action, string Category, string SubCategory, string SubCategoryone, Int32 pageIndex, Int32 pageSize)
        {
            return SarsoBizsDal.Instance.MemberModule.RePurchageProductRpt(_environment, action, Category, SubCategory,SubCategoryone, pageIndex, pageSize);
        }

        //rk com ewalletrpt
        public DataTable CommEWalletRpt(Int32 regid, DateTime frmdate, DateTime todate, Int32 pageindex, Int32 pagesize)
        {
            return SarsoBizsDal.Instance.MemberModule.CommEWalletRpt(_environment, regid, frmdate, todate, pageindex, pagesize);
        }
    }
}
