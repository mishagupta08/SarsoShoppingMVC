using System;
using System.Data;

// ReSharper disable CheckNamespace
namespace SarsoBizDal
// ReSharper restore CheckNamespace
{
    public class MemberModule : IMemberModule
    {
        public DataTable MemberLogin(string env, string username, string password)
        {
            return SqlHelpers.GetTable(env, CommandFactory.MemberLogin(username, password));
        }
        public DataTable GetSponsorDet(string env, Int32 regid)
        {
            return SqlHelpers.GetTable(env, CommandFactory.GetSponsorDet(regid));
        }
        public DataTable MemDashBoard(string env, Int32 regid)
        {
            return SqlHelpers.GetTable(env, CommandFactory.MemDashBoard(regid));
        }
        public Int32 MomPhotoRequest(string env, Int32 regid, string ipadd, string sesid)
        {
            return SqlHelpers.GetValue<Int32>(env, CommandFactory.MomPhotoRequest(regid, ipadd, sesid));
        }
        public DataTable CheckRegPin(string env, Int32 cardSNo, string keyNo)
        {
            return SqlHelpers.GetTable(env, CommandFactory.CheckRegPin(cardSNo, keyNo));
        }
        public DataSet RegPackDet(string env, Int32 pid)
        {
            return SqlHelpers.GetDataSet(env, CommandFactory.RegPackDet(pid));
        }
        public DataSet RegMcPackDet(string env, Int32 pid, string fullitemcode)
        {
            return SqlHelpers.GetDataSet(env, CommandFactory.RegMcPackDet(pid, fullitemcode));
        }
        public DataTable GetCountries(string env)
        {
            return SqlHelpers.GetTable(env, CommandFactory.GetCountries());
        }
        public DataTable GetStates(string env, int countryId)
        {
            return SqlHelpers.GetTable(env, CommandFactory.GetStates(countryId));
        }

        public DataTable GetDistricts(string env, int stateid)
        {
            return SqlHelpers.GetTable(env, CommandFactory.GetDistricts(stateid));
        }
        public DataTable GetCitysInState(string env, string stateid)
        {
            return SqlHelpers.GetTable(env, CommandFactory.GetCitysInState(stateid));
        }
        public DataTable InsertTempReg(string env, string userno, Int32 sprno, string spseries, string fname, string lname,
                                                 DateTime dob, string sex, string add1, string add2, string city,
                                                 string district, string state, Int32 pin, string mobile, string eMail, string lpassword,
                                                 string tpassword, string sesid, Int32 downto, string panno, string Title, string guardian,
                                                 string altmobile, string qualification, string subject, string ddrefno, DateTime Refdddate, string refddbank, string ddrefbranch,
                                                 string reftype, Int32 Pid, Int32 BV, string percity,
                                                 string perdistrict, string perstate, Int32 perpin, string landline, string careof, string fullitemcode)
        {
            return SqlHelpers.GetTable(env, CommandFactory.InsertTempReg(userno, sprno, spseries, fname, lname, dob, sex, add1, add2, city, district, state, pin, mobile, eMail,
                lpassword, tpassword, sesid, downto, panno, Title, guardian, altmobile, qualification, subject, ddrefno, Refdddate, refddbank, ddrefbranch, reftype, Pid, BV, percity, perdistrict, perstate, perpin, landline, careof, fullitemcode));
        }

        public DataTable InsertSalesTempReg(string env, string userno, Int32 sprno, string spseries, string fname, string lname,
                                                 DateTime dob, string sex, string add1, string add2, string city,
                                                 string district, string state, Int32 pin, string mobile, string eMail, string lpassword,
                                                 string tpassword, string panno, string Title, string guardian, string careof, string sesid)
        {
            return SqlHelpers.GetTable(env, CommandFactory.InsertSalesTempReg(userno, sprno, spseries, fname, lname, dob, sex, add1, add2, city, district, state, pin, mobile, eMail,
                lpassword, tpassword, panno, Title, guardian, careof, sesid));
        }

        public Int32 InsertGuestReg(string env, string userno, Int32 sprno, string spseries, string Title, string fname, string lname,
                                                string sex, string state, string mobile, string eMail, string lpassword, string tpassword, string sesid, string decpwd, string CorrAdds, string PerAdds, string CorrCity, string PerCity,
                                                string CorrDistrict, string perDistrict, string Corrddlstate, string perddlstate, string CorrPINCode, string PerPINCode)
        {
            return SqlHelpers.GetValue<Int32>(env, CommandFactory.InsertGuestReg(userno, sprno, spseries, Title, fname, lname, sex, state, mobile, eMail, lpassword, tpassword, sesid, decpwd, CorrAdds, PerAdds, CorrCity, PerCity, CorrDistrict, perDistrict, Corrddlstate, perddlstate, CorrPINCode, PerPINCode));
        }

        public Int32 PartialInsertReg(string env, string userno, Int32 sprno, string spseries, string Title, string fname, string lname,
                                               string sex, string state, string mobile, string eMail, string lpassword, string tpassword, string sesid, string decpwd, string ddno, DateTime dddate, string ddbank, string ddbranch, string mop, Double Amount, string action, string Unqid, string IP)
        {
            return SqlHelpers.GetValue<Int32>(env, CommandFactory.PartialInsertReg(userno, sprno, spseries, Title, fname, lname, sex, state, mobile, eMail, lpassword, tpassword, sesid, decpwd,ddno,dddate,ddbank,ddbranch,mop,Amount,action,Unqid,IP));
        }

        public void GetSprSeries(string env, Int32 regid)
        {
            SqlHelpers.GetTable(env, CommandFactory.GetSprSeries(regid));
        }

        public string Getitemcode_Pcode(string env, string pcode)
        {
            return SqlHelpers.GetValue<string>(env, CommandFactory.Getitemcode_Pcode(pcode));
        }

        public void FcpRegCommission(string env, string thru, string sesid)
        {
            SqlHelpers.GetTable(env, CommandFactory.FcpRegCommission(thru, sesid));
        }

        public DataTable MemberProfile(string env, Int32 regid)
        {
            return SqlHelpers.GetTable(env, CommandFactory.MemberProfile(regid));
        }

        public int BlockIdorBlockToPaid(string env, string action, Int32 regid, Int16 updatedby, string sesid, string remarks)
        {
            return SqlHelpers.GetValue<int>(env, CommandFactory.BlockIdorBlockToPaid(action, regid, updatedby, sesid, remarks));
        }
        public int UpdateMemDetailes(string env, Int64 regid, string fName, string lName, string maiden,
                                                    string mdnMname, string panno, DateTime dob, int age, int sex,
                                                    string add1, string add2, string city, int districtId, int stateid, int countryid,
                                                    int pin, string phoneRes, string phoneOff, string mobile,
                                                    string eMail, string payeeName, string bank, Int64 accno,
                                                    string branch, string ifscode, string nominee, string relation,
                                                    int nomage, string sesid, Int32 updatedby)
        {
            return SqlHelpers.GetValue<int>(env, CommandFactory.UpdateMemDetailes(regid, fName, lName, maiden,
                                                     mdnMname, panno, dob, age, sex,
                                                    add1, add2, city, districtId, stateid, countryid,
                                                     pin, phoneRes, phoneOff, mobile,
                                                     eMail, payeeName, bank, accno,
                                                     branch, ifscode, nominee, relation,
                                                     nomage, sesid, updatedby));
        }
        public DataTable BinaryTreeView(string env, string idno)
        {
            return SqlHelpers.GetTable(env, CommandFactory.BinaryTreeView(idno));
        }
        public DataTable BinaryTreeViewTooltip(string env, string idno)
        {
            return SqlHelpers.GetTable(env, CommandFactory.BinaryTreeViewTooltip(idno));
        }
        public DataTable DirectDownLineReport(string env, Int32 regid)
        {
            return SqlHelpers.GetTable(env, CommandFactory.DirectDownLineReport(regid));
        }
        public DataTable Generationlevels(string env, Int32 regid)
        {
            return SqlHelpers.GetTable(env, CommandFactory.Generationlevels(regid));
        }
        public DataSet BinaryPrintView(string env, string action, Int32 idno, DateTime frmdate, DateTime todate, Int32 pageIndex, Int32 pageSize)
        {
            return SqlHelpers.GetDataSet(env, CommandFactory.BinaryPrintView(action, idno, frmdate, todate, pageIndex, pageSize));
        }
        public DataTable BinaryUplevelRpt(string env, Int32 regid, Int32 pageIndex, Int32 pageSize)
        {
            return SqlHelpers.GetTable(env, CommandFactory.BinaryUplevelRpt(regid, pageIndex, pageSize));
        }
        public DataTable ConfirmationNote(string env, Int32 regid)
        {
            return SqlHelpers.GetTable(env, CommandFactory.ConfirmationNote(regid));
        }
        public DataTable WithdrawlRequestRpt(string env, Int32 regid, Int32 pageIndex, Int32 pageSize)
        {
            return SqlHelpers.GetTable(env, CommandFactory.WithdrawlRequestRpt(regid, pageIndex, pageSize));
        }
        public DataSet RankStatusMem(string env, Int32 regid, Int32 pageIndex, Int32 pageSize)
        {
            return SqlHelpers.GetDataSet(env, CommandFactory.RankStatusMem(regid, pageIndex, pageSize));
        }

        public void AddorDeductMemEwallet(string env, Int32 regId, string descr, double inAmt, double outAmt,
                                                         string remarks, string typeOfInc, string thru, int payNo,
                                                         string sessId)
        {
            SqlHelpers.GetValue<int>(env, CommandFactory.AddorDeductMemEwallet(regId, descr, inAmt, outAmt,
                                                                                 remarks, typeOfInc, thru, payNo,
                                                                                 sessId));
        }
        public DataSet Myorders(string env, Int32 regid, Int32 pageIndex, Int32 pageSize)
        {
            return SqlHelpers.GetDataSet(env, CommandFactory.Myorders(regid, pageIndex, pageSize));
        }
        public int UpdateBankSlips(string env, Int32 regid, string prcode, double amount, string ipadd, string sesid, string src)
        {
            return SqlHelpers.GetValue<int>(env, CommandFactory.UpdateBankSlips(regid, prcode, amount, ipadd, sesid, src));
        }
        public string Chgaddress(string env, Int32 regid, string maidenname,
                                                 string dob, string sex, string add1, string add2, string city,
                                                 string district, string state, Int32 pin, string mobile, string eMail, string corcity, string cordistrict, string corstate, Int32 corpin, string GSTNO)
        {
            return SqlHelpers.GetValue<string>(env, CommandFactory.Chgaddress(regid, maidenname,
                                                  dob, sex, add1, add2, city,
                                                  district, state, pin, mobile, eMail, corcity, cordistrict, corstate, corpin,GSTNO));
        }
        public string Chgbank(string env, Int32 regid, string payeeName, string panno, string bank, string accno,
                              string branch, string ifscode)
        {
            return SqlHelpers.GetValue<string>(env,
                                               CommandFactory.Chgbank(regid, payeeName, panno, bank, accno, branch,
                                                                      ifscode));
        }
        public string Chgnominee(string env, Int32 regid, string nominee, string relation, DateTime NomineeDOB)
        {
            return SqlHelpers.GetValue<string>(env,
                                               CommandFactory.Chgnominee(regid, nominee, relation, NomineeDOB));
        }
        public DataTable BigBossReward(string env, Int32 regid)
        {
            return SqlHelpers.GetTable(env, CommandFactory.BigBossReward(regid));
        }
        public DataTable GetProvidersCircles(string env, string action)
        {
            return SqlHelpers.GetTable(env, CommandFactory.GetProvidersCircles(action));
        }
        public DataTable TmpMobileRech(string env, Int32 regid, string provider, double amount, Int32 mobile, string ipadd)
        {
            return SqlHelpers.GetTable(env, CommandFactory.TmpMobileRech(regid, provider, amount, mobile, ipadd));
        }
        public DataSet MemberInvoices(string env, string action, Int32 regid)
        {
            return SqlHelpers.GetDataSet(env, CommandFactory.MemberInvoices(action, regid));
        }
        public void Deletetable(string env, string response)
        {
            SqlHelpers.GetValue<int>(env, CommandFactory.Deletetable(response));
        }
        public void MrUpdate(string env, Int32 regid, string mobile, string provider, string circle, string txnId, double rchAmt, string statusType, string remarks)
        {
            SqlHelpers.GetValue<int>(env, CommandFactory.MrUpdate(regid, mobile, provider, circle, txnId, rchAmt, statusType, remarks));
        }
        public string CheckDownTo(string env, Int32 regid, string downto)
        {
            return SqlHelpers.GetValue<string>(env, CommandFactory.CheckDownTo(regid, downto));
        }
        public DataTable MemWithdrawlRequestType(string env, string potratype,string PotraMode ,Int32 regid)
        {
            return SqlHelpers.GetTable(env, CommandFactory.MemWithdrawlRequestType(potratype, PotraMode, regid));
        }
        public int ChkMemWithdrawlRequest(string env, string action, Int32 regid)
        {
            return SqlHelpers.GetValue<int>(env, CommandFactory.ChkMemWithdrawlRequest(action, regid));
        }
        public void MemWithdrawlRequest(string env, string action, Int32 regid, double amount, string remarks, string sesid)
        {
            SqlHelpers.GetValue<int>(env, CommandFactory.MemWithdrawlRequest(action, regid, amount, remarks, sesid));
        }
        public string ChkMobileEmail(string env, string mobemail, string type)
        {
            return SqlHelpers.GetValue<string>(env, CommandFactory.ChkMobileEmail(mobemail, type));
        }
        public DataTable MemberDetailes(string env, Int32 regid)
        {
            return SqlHelpers.GetTable(env, CommandFactory.MemberDetailes(regid));
        }


        public DataTable TempMemberDetailes(string env, Int32 regid)
        {
            return SqlHelpers.GetTable(env, CommandFactory.TempMemberDetailes(regid));
        }

        public DataTable AdminEditPermission(string env, Int32 regid)
        {
            return SqlHelpers.GetTable(env, CommandFactory.AdminEditPermission(regid));
        }
        public int BlockorUnBlock(string env, string action, Int32 regid, Int32 updatedby,
                                          string remarks, string sesid)
        {
            return SqlHelpers.GetValue<int>(env,
                                            CommandFactory.BlockorUnBlock(action, regid, updatedby,
                                           remarks, sesid));
        }
        public DataTable BlockorUnBlockIdsRpt(string env, string action, string idno, string regtype, DateTime frmdate, DateTime todate,
                                          Int32 pageIndex, Int32 pageSize)
        {
            return SqlHelpers.GetTable(env, CommandFactory.BlockorUnBlockIdsRpt(action, idno, regtype, frmdate, todate,
                                                                                 pageIndex, pageSize));
        }

        public DataTable BinaryTabular(string env, Int32 regid, DateTime frmdate, DateTime todate, string rtype, Int32 status, string val)
        {
            return SqlHelpers.GetTable(env, CommandFactory.BinaryTabular(regid, frmdate, todate, rtype, status, val));
        }
        public DataTable SponsorReport(string env, Int32 regid, Int32 pageindex, Int32 pagesize)
        {
            return SqlHelpers.GetTable(env, CommandFactory.SponsorReport(regid, pageindex, pagesize));
        }

        public DataTable UnilevelPrintView(string env, string action, Int32 regid, DateTime frmdate, DateTime todate, Int32 pageindex, Int32 pagesize)
        {
            return SqlHelpers.GetTable(env, CommandFactory.UnilevelPrintView(action, regid, frmdate, todate, pageindex, pagesize));
        }
        public string GetEwalBalance(string env, string action, Int32 regid)
        {
            return SqlHelpers.GetValue<string>(env, CommandFactory.GetEwalBalance(action, regid));
        }
        public DataTable EwalletSummaryRpt(string env, string action, Int32 regid, DateTime frmdate, DateTime todate, Int32 pageindex, Int32 pagesize, double Balance)
        {
            return SqlHelpers.GetTable(env, CommandFactory.EwalletSummaryRpt(action, regid, frmdate, todate, pageindex, pagesize, Balance));
        }
        //rk
        public DataTable EwalletSummaryRpt1(string env, string action, Int32 regid, DateTime frmdate, DateTime todate, Int32 pageindex, Int32 pagesize, double Balance,Int32 payno)
        {
            return SqlHelpers.GetTable(env, CommandFactory.EwalletSummaryRpt1(action, regid, frmdate, todate, pageindex, pagesize, Balance,payno));
        }
        public string GetWithdrawalEwalBalance(string env, string action, Int32 regid)
        {
            return SqlHelpers.GetValue<string>(env, CommandFactory.GetWithdrawalEwalBalance(action, regid));
        }
        public Int32 AddorDeductWithdrawalWallet(string env, string action, Int32 regid, Double amount, String typeofinc, string remarks, Int32 thru, string sessId)
        {
            return SqlHelpers.GetValue<Int32>(env, CommandFactory.AddorDeductWithdrawalWallet(action, regid, amount, typeofinc, remarks, thru, sessId));
        }
        public DataTable AddorDeductWithdrawalRpt(string env, Int32 regid, DateTime frmdate, DateTime todate, Int32 pageindex, Int32 pagesize)
        {
            return SqlHelpers.GetTable(env, CommandFactory.AddorDeductWithdrawalRpt(regid, frmdate, todate, pageindex, pagesize));
        }
        public Int32 AddorDeductWallet(string env, string action, Int32 regid, Double amount, String typeofinc, string remarks, Int32 thru, string sessId)
        {
            return SqlHelpers.GetValue<Int32>(env, CommandFactory.AddorDeductWallet(action, regid, amount, typeofinc, remarks, thru, sessId));
        }
        public DataTable AddorDeductRpt(string env, Int32 regid, DateTime frmdate, DateTime todate, Int32 pageindex, Int32 pagesize)
        {
            return SqlHelpers.GetTable(env, CommandFactory.AddorDeductRpt(regid, frmdate, todate, pageindex, pagesize));
        }
        public DataTable AppConsultantReport(string env, string searchid, Int16 status, DateTime frmdate, DateTime todate, Int32 regid, Int32 stateid, Int32 pageIndex, Int32 pageSize, string Action)
        {
            return SqlHelpers.GetTable(env, CommandFactory.AppConsultantReport(searchid, status, frmdate, todate, regid, stateid, pageIndex, pageSize, Action));
        }
        //04-03 Satish
        public string InsFeedback(string env, string Idno, string Name, string Email, string Qtype, string State, string Mobile, string Enquiry, string Sessid, string Ipadd)
        {
            return SqlHelpers.GetValue<string>(env, CommandFactory.InsFeedback(Idno, Name, Email, Qtype, State, Mobile, Enquiry, Sessid, Ipadd));
        }

        public DataTable UpdateMemberProfile(string env, Int32 regid, string fname, string lname, string maidenname,
                                                 string dob, string sex, string add1, string add2, string city,
                                                 string district, string state, Int32 pin, string mobile, string eMail, string payeename, string panno, string bank,
                                       string branch, string accno, string ifscode, string nominee,
                                       string relation, string nomineedob, string User, string sessid, string ipaddress, string corcity, string cordistrict, string corstate, Int32 corpin, string GSTNO)
        {
            return SqlHelpers.GetTable(env,
                                            CommandFactory.UpdateMemberProfile(regid, fname, lname, maidenname, dob, sex,
                                                                               add1, add2, city,
                                                                               district, state, pin, mobile,
                                                                               eMail, payeename, panno, bank,
                                                                               branch, accno, ifscode, nominee,
                                                                               relation, nomineedob, User, sessid, ipaddress,corcity,cordistrict,corstate,corpin,GSTNO));
        }

        //16/03 Satish
        public string UploadKyc(string env, Int32 regid, string ProofType, string panno, string panimg, string bank, string branch, string accno, string ifscode, string chqimg, string sesid, string Remarks, string ModuleType)
        {
            return SqlHelpers.GetValue<string>(env, CommandFactory.UploadKyc(regid, ProofType, panno, panimg, bank, branch, accno, ifscode, chqimg, sesid, Remarks, ModuleType));
        }
        public DataTable Kyc(string env, Int32 regid, string Type)
        {
            return SqlHelpers.GetTable(env, CommandFactory.Kyc(regid, Type));
        }
        public Int32 ChkEditProfileSts(string env, string action, Int32 regid)
        {
            return SqlHelpers.GetValue<Int32>(env, CommandFactory.ChkEditProfileSts(action, regid));
        }
        public Int32 UploadMemPhoto(string env, Int32 regid, string image)
        {
            return SqlHelpers.GetValue<Int32>(env, CommandFactory.UploadMemPhoto(regid, image));
        }

        public DataTable CheckUserName(string env, string IDNO, string RptType)
        {
            return SqlHelpers.GetTable(env, CommandFactory.CheckUserName(IDNO, RptType));
        }

        //17/03 Satish
        public DataTable MakeCreditRequest(string env, Int32 regid, double reqAmt, string mop, string refno,
                                                     DateTime invdate, string invbank, string invbranch, string depbank,
                                                     string depbranch, string depcity, DateTime depdate, string depslip,
                                                     string remarks)
        {
            return SqlHelpers.GetTable(env,
                                       CommandFactory.MakeCreditRequest(regid, reqAmt, mop, refno,
                                                                        invdate, invbank, invbranch, depbank,
                                                                        depbranch, depcity, depdate, depslip,
                                                                        remarks));
        }
        public DataTable MemeberReport(string env, Int32 regid, String RegType, Int32 Status, Int32 pageindex, Int32 pagesize)
        {
            return SqlHelpers.GetTable(env, CommandFactory.MemeberReport(regid, RegType, Status, pageindex, pagesize));
        }

        public DataTable chkDwnLine(string env, String RegType, Int32 regid)
        {
            return SqlHelpers.GetTable(env, CommandFactory.chkDwnLine(RegType, regid));
        }

        public DataTable FundTransfer(string env, String regid, String idno, int Amount, String remarks, String sessid)
        {
            return SqlHelpers.GetTable(env, CommandFactory.FundTransfer(regid, idno, Amount, remarks, sessid));
        }

        public DataTable MemberCV(string env, String action, DateTime frmdate, DateTime todate, Int32 regid)
        {
            return SqlHelpers.GetTable(env, CommandFactory.MemberCV(action,frmdate, todate, regid));
        }

        public DataTable UploadCustomerOrder(string env, String action, Int32 regid, string ProofType, string OrderNo, string OrderPhoto, string bank, string accno, string branch, string ifscode, string chqimg, string sesid, string Remarks)
        {
            return SqlHelpers.GetTable(env, CommandFactory.UploadCustomerOrder(action, regid, ProofType, OrderNo, OrderPhoto, bank, accno, branch, ifscode, chqimg, sesid, Remarks));
        }

        public DataTable GetUniqid(string env)
        {
            return SqlHelpers.GetTable(env, CommandFactory.GetUniqid());
        }

        public Int32 RegistrationOnlineInsert(string env, string action, string userno, Int32 sprno, string spseries, string fname, string lname,
                                                  DateTime dob, string sex, string add1, string add2, string city,
                                                  string district, string state, Int32 pin, string mobile, string eMail, string lpassword,
                                                  string tpassword, string sesid, Int32 downto, string panno, string Title, string guardian,
                                                  string altmobile, string qualification, string subject, string ddrefno, DateTime Refdddate, string refddbank, string ddrefbranch,
                                                  string reftype, Int32 Pid, Int32 BV, string percity,
                                                  string perdistrict, string perstate, Int32 perpin, string landline, string careof, string fullitemcode, string ORDER_ID, string PaymentStatus, string BillStatus, string TXNID, Int32 regid, string CUST_ID, string TXN_AMOUNT, string pgtype)
        {
            return SqlHelpers.GetValue<Int32>(env, CommandFactory.RegistrationOnlineInsert(action, userno, sprno, spseries, fname, lname, dob, sex, add1, add2, city, district, state, pin, mobile, eMail, lpassword, tpassword, sesid,
     downto, panno, Title, guardian, altmobile, qualification, subject, ddrefno, Refdddate, refddbank, ddrefbranch, reftype, Pid, BV, percity, perdistrict, perstate,
     perpin, landline, careof, fullitemcode, ORDER_ID, PaymentStatus, BillStatus, TXNID, regid, CUST_ID, TXN_AMOUNT,pgtype));
        }

        public DataTable GetRegistrationOnline(string env, string ORDERID)
        {
            return SqlHelpers.GetTable(env, CommandFactory.GetRegistrationOnline(ORDERID));
        }

        public Int32 LogOnlineDataNew(string env, string SUBS_ID, string MID, string TXNID, string ORDERID, string BANKTXNID, string TXNAMOUNT, string CURRENCY, string STATUS, string RESPCODE, string RESPMSG, string TXNDATE, string GATEWAYNAME, string BANKNAME, string PAYMENTMODE, string PROMO_CAMP_ID, string PROMO_STATUS, string PROMO_RESPCODE, string CHECKSUMHASH, string remarks)
        {
            return SqlHelpers.GetValue<Int32>(env, CommandFactory.LogOnlineDataNew(SUBS_ID, MID, TXNID, ORDERID, BANKTXNID, TXNAMOUNT, CURRENCY, STATUS, RESPCODE, RESPMSG, TXNDATE, GATEWAYNAME, BANKNAME, PAYMENTMODE, PROMO_CAMP_ID, PROMO_STATUS, PROMO_RESPCODE, CHECKSUMHASH, remarks));
        }

        public DataTable GetPayNo(string env, string type)
        {
            return SqlHelpers.GetTable(env, CommandFactory.GetPayNo(type));
        }
        public DataTable GetSchrpt(string env, string payno, DateTime frmdate, DateTime todate, string idno, double fromamt, double toamt, string usertype, Int32 pageindex, Int32 pagesize)
        {
            return SqlHelpers.GetTable(env, CommandFactory.GetSchrpt(payno, frmdate, todate, idno, fromamt, toamt, usertype, pageindex, pagesize));
        }
        public DataTable IneligibleRpt(string env, string type, string val, DateTime frmdate, DateTime todate, string idno, string usertype, Int32 pageindex, Int32 pagesize)
        {
            return SqlHelpers.GetTable(env, CommandFactory.IneligibleRpt(type, val, frmdate, todate, idno, usertype, pageindex, pagesize));
        }
        public DataTable PayoutReports_Member(string env, string action, Int32 regid, string payno, Int32 pageIndex, Int32 pageSize)
        {
            return SqlHelpers.GetTable(env, CommandFactory.PayoutReports_Member(action, regid, payno, pageIndex, pageSize));
        }

        public Int32 SCOnlineInsert(string env, string action, Int32 regid, string amount, string mobile, string ORDER_ID, string PaymentStatus, string BillStatus, string TXNID, string BillNo, string pgtype, string shpcharge, string scmemtype,string coupon)
        {
            return SqlHelpers.GetValue<Int32>(env, CommandFactory.SCOnlineInsert(action, regid, amount, mobile, ORDER_ID, PaymentStatus, BillStatus, TXNID, BillNo, pgtype, shpcharge, scmemtype,coupon));
        }
        public DataTable GetSCOnline(string env, string ORDERID)
        {
            return SqlHelpers.GetTable(env, CommandFactory.GetSCOnline(ORDERID));
        }
        public Int32 LogOnlineDataEBSNew(string env, string ResponseCode, string ResponseMessage, string DateCreated, string PaymentID, string MerchantRefNo, string Amount,
            string Mode, string BillingName, string BillingAddress, string BillingCity, string BillingState, string BillingPostalCode, string BillingCountry,
            string BillingPhone, string BillingEmail, string DeliveryName, string DeliveryAddress, string DeliveryCity, string DeliveryState, string DeliveryPostalCode,
            string DeliveryCountry, string DeliveryPhone, string Description, string IsFlagged, string TransactionID, string PaymentMethod, string RequestID,
            string SecureHash, string remarks)
        {
            return SqlHelpers.GetValue<Int32>(env, CommandFactory.LogOnlineDataEBSNew(ResponseCode, ResponseMessage, DateCreated, PaymentID, MerchantRefNo, Amount,
                Mode, BillingName, BillingAddress, BillingCity, BillingState, BillingPostalCode, BillingCountry,
                BillingPhone, BillingEmail, DeliveryName, DeliveryAddress, DeliveryCity, DeliveryState, DeliveryPostalCode,
                DeliveryCountry, DeliveryPhone, Description, IsFlagged, TransactionID, PaymentMethod, RequestID, SecureHash, remarks));
        }
        public Int32 CreditRequestOnlineInsert(string env, string action, Int32 regid, double reqAmt, string mop, string refno,
                                                     DateTime invdate, string invbank, string invbranch, string depbank,
                                                     string depbranch, string depcity, DateTime depdate, string depslip,
                                                     string remarks, string ORDER_ID, string PaymentStatus, string BillStatus, string TXNID, string Recode, string pgtype)
        {
            return SqlHelpers.GetValue<Int32>(env, CommandFactory.CreditRequestOnlineInsert(action, regid, reqAmt, mop, refno,
                                                     invdate, invbank, invbranch, depbank,
                                                     depbranch, depcity, depdate, depslip,
                                                     remarks, ORDER_ID, PaymentStatus, BillStatus, TXNID, Recode, pgtype));
        }
        public Int32 LogResponse(string env, string merrefno, string responsevalues)
        {
            return SqlHelpers.GetValue<Int32>(env, CommandFactory.LogResponse(merrefno, responsevalues));
        }
        public DataTable GetCreditRequestOnline(string env, string ORDERID)
        {
            return SqlHelpers.GetTable(env, CommandFactory.GetCreditRequestOnline(ORDERID));
        }
        public Int32 GVDPurchaseOnlineInsert(string env, string action, int regid, string ddrefno, DateTime Refdddate, string refddbank, string ddrefbranch, string reftype,
            int Pid, int BV, string fullitemcode, string sesid, string fname, string lname, string address, string mobile, string city, string district,
            string states, int pin, string ORDER_ID, string PaymentStatus, string BillStatus, string TXNID, string CUST_ID, string TXN_AMOUNT, string pgtype, string billno)
        {
            return SqlHelpers.GetValue<Int32>(env, CommandFactory.GVDPurchaseOnlineInsert(action, regid, ddrefno, Refdddate, refddbank, ddrefbranch, reftype,
            Pid, BV, fullitemcode, sesid, fname, lname, address, mobile, city, district,
            states, pin, ORDER_ID, PaymentStatus, BillStatus, TXNID, CUST_ID, TXN_AMOUNT, pgtype, billno));
        }
        public DataTable GetGVDPurchaseOnline(string env, string ORDERID)
        {
            return SqlHelpers.GetTable(env, CommandFactory.GetGVDPurchaseOnline(ORDERID));
        }

        public DataTable UploadMemberIHO(string env, String action, Int32 sno, Int32 regid, string ProofType, string IHOPhoto, Int32 apprej, string sesid, Int32 apprejby, string AppRejRemarks)
        {
            return SqlHelpers.GetTable(env, CommandFactory.UploadMemberIHO(action, sno,  regid,  ProofType,  IHOPhoto,  apprej,  sesid,  apprejby,  AppRejRemarks));
        }

        public DataTable RePurchageProductRpt(string env, string action, string Category, string SubCategory, string SubCategoryone, Int32 pageIndex, Int32 pageSize)
        {
            return SqlHelpers.GetTable(env, CommandFactory.RePurchageProductRpt(action,Category, SubCategory, SubCategoryone, pageIndex, pageSize));
        }
        //rk
        public DataTable CommEWalletRpt(string env, Int32 regid, DateTime frmdate, DateTime todate, Int32 pageindex, Int32 pagesize)
        {
            return SqlHelpers.GetTable(env, CommandFactory.CommEWalletRpt(regid, frmdate, todate, pageindex, pagesize));
        }
    }
}
