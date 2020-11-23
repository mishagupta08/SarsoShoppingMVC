using System;
using System.Data;
using System.Data.SqlClient;

// ReSharper disable CheckNamespace
namespace SarsoBizDal
// ReSharper restore CheckNamespace
{
    internal partial class CommandFactory
    {
        internal static SqlCommand MemberLogin(string username, string password)
        {
            var parameters = new[]
            {
                CreateParameter("@username", SqlDbType.VarChar, username),
                CreateParameter("@password", SqlDbType.VarChar, password)
            };
            return CreateCommand("MemberLogin_Sp", parameters);
        }
        internal static SqlCommand GetSponsorDet(Int32 regid)
        {
            var parameters = new[]
            {
                CreateParameter("@regid", SqlDbType.BigInt, regid)                
            };
            return CreateCommand("GetSponsorDet_Sp", parameters);
        }
        internal static SqlCommand MemDashBoard(Int32 regid)
        {
            var parameters = new[]
            {
                CreateParameter("@regid", SqlDbType.BigInt, regid)                
            };
            return CreateCommand("MemDashBoard_Sp", parameters);
        }
        internal static SqlCommand MomPhotoRequest(Int32 regid, string ipadd, string sesid)
        {
            var parameters = new[]
            {
                CreateParameter("@regid", SqlDbType.BigInt, regid) ,
                CreateParameter("@ipadd", SqlDbType.VarChar, ipadd) ,
                CreateParameter("@sesid", SqlDbType.VarChar, sesid) 
            };
            return CreateCommand("MomPhotoRequest_Sp", parameters);
        }
        internal static SqlCommand CheckRegPin(Int32 cardSNo, string keyNo)
        {
            var parameters = new[]
            {
                CreateParameter("@CardSNo", SqlDbType.BigInt, cardSNo),
                CreateParameter("@KeyNo", SqlDbType.VarChar, keyNo)
            };
            return CreateCommand("CheckRegPin_Sp", parameters);
        }
        internal static SqlCommand RegPackDet(Int32 pid)
        {
            var parameters = new[]
            {
                CreateParameter("@pid", SqlDbType.BigInt, pid)                
            };
            return CreateCommand("RegPackDet_Sp", parameters);
        }
        internal static SqlCommand RegMcPackDet(Int32 pid, string fullitemcode)
        {
            var parameters = new[]
            {
                CreateParameter("@pid", SqlDbType.BigInt, pid) ,
                CreateParameter("@fullitemcode", SqlDbType.VarChar, fullitemcode)
            };
            return CreateCommand("RegMCPackDet_Sp", parameters);
        }
        internal static SqlCommand GetCountries()
        {
            return CreateCommand("GetCountries_Sp");
        }
        internal static SqlCommand GetStates(int countryId)
        {
            var parameters = new[]
            {
                CreateParameter("@CountryID", SqlDbType.Int, countryId)                
            };
            return CreateCommand("GetStates_Sp", parameters);
        }
        internal static SqlCommand GetDistricts(int stateid)
        {
            var parameters = new[]
            {
                CreateParameter("@stateid", SqlDbType.Int, stateid)                
            };
            return CreateCommand("GetDistricts_Sp", parameters);
        }
        internal static SqlCommand GetCitysInState(string stateid)
        {
            var parameters = new[]
            {
                CreateParameter("@stateid", SqlDbType.VarChar, stateid)                
            };
            return CreateCommand("GetCitysInState_Sp", parameters);
        }
        internal static SqlCommand InsertTempReg(string userno, Int32 sprno, string spseries, string fname, string lname,
                                                 DateTime dob, string sex, string add1, string add2, string city,
                                                 string district, string state, Int32 pin, string mobile, string eMail, string lpassword,
                                                 string tpassword, string sesid, Int32 downto, string panno, string Title, string guardian,
                                                 string altmobile, string qualification, string subject, string ddrefno, DateTime Refdddate, string refddbank, string ddrefbranch,
                                                 string reftype, Int32 Pid, Int32 BV, string percity,
                                                 string perdistrict, string perstate, Int32 perpin, string landline, string careof, string fullitemcode)
        {
            var parameters = new[]
            {
                CreateParameter("@userno", SqlDbType.VarChar, userno),
                CreateParameter("@sprno", SqlDbType.Int, sprno),
                CreateParameter("@spseries", SqlDbType.VarChar, spseries),
                CreateParameter("@fname", SqlDbType.VarChar, fname),
                CreateParameter("@lname", SqlDbType.VarChar, lname),
                CreateParameter("@dob", SqlDbType.DateTime, dob),
                CreateParameter("@sex", SqlDbType.VarChar, sex),
                CreateParameter("@add1", SqlDbType.VarChar, add1),
                CreateParameter("@add2", SqlDbType.VarChar, add2),
                CreateParameter("@city", SqlDbType.VarChar, city),
                CreateParameter("@district", SqlDbType.VarChar, district),
                CreateParameter("@state", SqlDbType.VarChar, state),
                CreateParameter("@pin", SqlDbType.Int, pin),
                CreateParameter("@mobile", SqlDbType.VarChar, mobile),
                CreateParameter("@eMail", SqlDbType.VarChar, eMail),
                CreateParameter("@lpassword", SqlDbType.VarChar, lpassword),
                CreateParameter("@tpassword", SqlDbType.VarChar, tpassword),
                CreateParameter("@sesid", SqlDbType.VarChar, sesid),
                CreateParameter("@downto", SqlDbType.BigInt, downto),
                CreateParameter("@panno", SqlDbType.VarChar, panno),
                CreateParameter("@Title", SqlDbType.VarChar, Title),
                CreateParameter("@guardian", SqlDbType.VarChar, guardian),
                CreateParameter("@altmobile", SqlDbType.VarChar, altmobile),
                CreateParameter("@qualification", SqlDbType.VarChar, qualification),
                CreateParameter("@subject", SqlDbType.VarChar, subject),
                CreateParameter("@ddrefno", SqlDbType.VarChar, ddrefno),
                CreateParameter("@Refdddate", SqlDbType.DateTime, Refdddate),
                CreateParameter("@refddbank", SqlDbType.VarChar, refddbank),
                CreateParameter("@ddrefbranch", SqlDbType.VarChar, ddrefbranch),
                CreateParameter("@reftype", SqlDbType.VarChar, reftype),
                CreateParameter("@Pid", SqlDbType.Int, Pid),
                CreateParameter("@BV", SqlDbType.Int, BV),
                CreateParameter("@percity", SqlDbType.VarChar, percity),
                CreateParameter("@perdistrict", SqlDbType.VarChar, perdistrict),
                CreateParameter("@perstate", SqlDbType.VarChar, perstate),
                CreateParameter("@perpin", SqlDbType.Int, perpin),
                CreateParameter("@landline", SqlDbType.VarChar, landline),
                CreateParameter("@careof", SqlDbType.VarChar, careof),
                CreateParameter("@fullitemcode", SqlDbType.VarChar, fullitemcode),
            };
            return CreateCommand("InsertTempReg_Sp", parameters);
        }



        internal static SqlCommand InsertSalesTempReg(string userno, Int32 sprno, string spseries, string fname, string lname,
                                                DateTime dob, string sex, string add1, string add2, string city,
                                                string district, string state, Int32 pin, string mobile, string eMail, string lpassword,
                                                string tpassword, string panno, string Title, string guardian, string careof, string sesid)
        {
            var parameters = new[]
            {
                CreateParameter("@userno", SqlDbType.VarChar, userno),
                CreateParameter("@sprno", SqlDbType.Int, sprno),
                CreateParameter("@spseries", SqlDbType.VarChar, spseries),
                CreateParameter("@fname", SqlDbType.VarChar, fname),
                CreateParameter("@lname", SqlDbType.VarChar, lname),
                CreateParameter("@dob", SqlDbType.DateTime, dob),
                CreateParameter("@sex", SqlDbType.VarChar, sex),
                CreateParameter("@add1", SqlDbType.VarChar, add1),
                CreateParameter("@add2", SqlDbType.VarChar, add2),
                CreateParameter("@city", SqlDbType.VarChar, city),
                CreateParameter("@district", SqlDbType.VarChar, district),
                CreateParameter("@state", SqlDbType.VarChar, state),
                CreateParameter("@pin", SqlDbType.Int, pin),
                CreateParameter("@mobile", SqlDbType.VarChar, mobile),
                CreateParameter("@eMail", SqlDbType.VarChar, eMail),
                CreateParameter("@lpassword", SqlDbType.VarChar, lpassword),
                CreateParameter("@tpassword", SqlDbType.VarChar, tpassword),                              
                CreateParameter("@panno", SqlDbType.VarChar, panno),
                CreateParameter("@Title", SqlDbType.VarChar, Title),
                CreateParameter("@guardian", SqlDbType.VarChar, guardian),                                
                CreateParameter("@careof", SqlDbType.VarChar, careof),
                CreateParameter("@sesid", SqlDbType.VarChar, sesid)
            };
            return CreateCommand("InsertSalesTempReg_Sp", parameters);
        }


        internal static SqlCommand InsertGuestReg(string userno, Int32 sprno, string spseries,string Title, string fname, string lname,
                                                string sex, string state, string mobile, string eMail, string lpassword,
                                                string tpassword, string sesid, string decpwd, string CorrAdds, string PerAdds, string CorrCity, string PerCity,
                                                string CorrDistrict, string perDistrict, string Corrddlstate, string perddlstate, string CorrPINCode, string PerPINCode)
        {
            var parameters = new[]
            {
                CreateParameter("@userno", SqlDbType.VarChar, userno),
                CreateParameter("@sprno", SqlDbType.Int, sprno),
                CreateParameter("@spseries", SqlDbType.VarChar, spseries),
                CreateParameter("@Title", SqlDbType.VarChar, Title),
                CreateParameter("@fname", SqlDbType.VarChar, fname),
                CreateParameter("@lname", SqlDbType.VarChar, lname),                
                CreateParameter("@sex", SqlDbType.VarChar, sex),                 
                CreateParameter("@state", SqlDbType.VarChar, state),                
                CreateParameter("@mobile", SqlDbType.VarChar, mobile),
                CreateParameter("@eMail", SqlDbType.VarChar, eMail),
                CreateParameter("@lpassword", SqlDbType.VarChar, lpassword),
                CreateParameter("@tpassword", SqlDbType.VarChar, tpassword),                                                                                              
                CreateParameter("@sesid", SqlDbType.VarChar, sesid),
                CreateParameter("@decpwd", SqlDbType.VarChar, decpwd),
                CreateParameter("@CorrAdds", SqlDbType.VarChar, CorrAdds),
                CreateParameter("@PerAdds", SqlDbType.VarChar, PerAdds),
                CreateParameter("@CorrCity", SqlDbType.VarChar, CorrCity),
                CreateParameter("@PerCity", SqlDbType.VarChar, PerCity),                
                CreateParameter("@CorrDistrict", SqlDbType.VarChar, CorrDistrict),   
                CreateParameter("@perDistrict", SqlDbType.VarChar, perDistrict),
                CreateParameter("@Corrddlstate", SqlDbType.VarChar, Corrddlstate),
                CreateParameter("@perddlstate", SqlDbType.VarChar, perddlstate),
                CreateParameter("@CorrPINCode", SqlDbType.VarChar, CorrPINCode),                
                CreateParameter("@PerPINCode", SqlDbType.VarChar, PerPINCode)
            };
            return CreateCommand("InsertGuestReg_Sp", parameters);
        }

        internal static SqlCommand PartialInsertReg(string userno, Int32 sprno, string spseries, string Title, string fname, string lname,
                                                string sex, string state, string mobile, string eMail, string lpassword, 
                                                string tpassword, string sesid, string decpwd, string ddno, DateTime dddate,
                                                string ddbank, string ddbranch, string mop, Double Amount, string action, string Unqid, string IP)
        {
            var parameters = new[]
            {
                CreateParameter("@userno", SqlDbType.VarChar, userno),
                CreateParameter("@sprno", SqlDbType.Int, sprno),
                CreateParameter("@spseries", SqlDbType.VarChar, spseries),
                CreateParameter("@Title", SqlDbType.VarChar, Title),
                CreateParameter("@fname", SqlDbType.VarChar, fname),
                CreateParameter("@lname", SqlDbType.VarChar, lname),                
                CreateParameter("@sex", SqlDbType.VarChar, sex),                 
                CreateParameter("@state", SqlDbType.VarChar, state),                
                CreateParameter("@mobile", SqlDbType.VarChar, mobile),
                CreateParameter("@eMail", SqlDbType.VarChar, eMail),
                CreateParameter("@lpassword", SqlDbType.VarChar, lpassword),
                CreateParameter("@tpassword", SqlDbType.VarChar, tpassword),                                                                                              
                CreateParameter("@sesid", SqlDbType.VarChar, sesid),
                CreateParameter("@decpwd", SqlDbType.VarChar, decpwd),
                CreateParameter("@ddno", SqlDbType.VarChar, ddno),                 
                CreateParameter("@dddate", SqlDbType.DateTime, dddate),                
                CreateParameter("@ddbank", SqlDbType.VarChar, ddbank),
                CreateParameter("@ddbranch", SqlDbType.VarChar, ddbranch),
                CreateParameter("@mop", SqlDbType.VarChar, mop),
                CreateParameter("@Amount", SqlDbType.Money, Amount),                                                                                              
                CreateParameter("@action", SqlDbType.VarChar, action),
                CreateParameter("@Unqid", SqlDbType.VarChar, Unqid),
                CreateParameter("@Ip", SqlDbType.VarChar, IP)
            };
            return CreateCommand("PartialInsertReg_Sp", parameters);
        }
        internal static SqlCommand GetSprSeries(Int32 regid)
        {
            var parameters = new[]
            {
                CreateParameter("@regid", SqlDbType.Int, regid)                
            };
            return CreateCommand("GetSprSeries", parameters);
        }
        internal static SqlCommand Getitemcode_Pcode(string pcode)
        {
            var parameters = new[]
            {
                CreateParameter("@pcode", SqlDbType.VarChar, pcode)                
            };
            return CreateCommand("Getitemcode_Pcode_Sp", parameters);
        }

        internal static SqlCommand FcpRegCommission(string thru, string sesid)
        {
            var parameters = new[]
            {
                CreateParameter("@thru", SqlDbType.VarChar, thru),
                CreateParameter("@sesid", SqlDbType.VarChar, sesid)
            };
            return CreateCommand("FcpRegCommission_Sp", parameters);
        }

        internal static SqlCommand MemberProfile(Int32 regid)
        {
            var parameters = new[]
            {
                CreateParameter("@regid", SqlDbType.Int, regid)                
            };
            return CreateCommand("MemberProfile_Sp", parameters);
        }
        internal static SqlCommand UpdateMemDetailes(Int64 regid, string fName, string lName, string maiden,
                                                    string mdnMname, string panno, DateTime dob, int age, int sex,
                                                    string add1, string add2, string city, int districtId, int stateid, int countryid,
                                                    int pin, string phoneRes, string phoneOff, string mobile,
                                                    string eMail, string payeeName, string bank, Int64 accno,
                                                    string branch, string ifscode, string nominee, string relation,
                                                    int nomage, string sesid, Int32 updatedby)
        {
            var parameters = new[]
                {
                    CreateParameter("@regid", SqlDbType.Int, regid),
                    CreateParameter("@fName", SqlDbType.VarChar, fName),
                    CreateParameter("@lName", SqlDbType.VarChar, lName),
                    CreateParameter("@maiden", SqlDbType.VarChar, maiden),
                    CreateParameter("@mdnMname", SqlDbType.VarChar, mdnMname),
                    CreateParameter("@Panno", SqlDbType.VarChar, panno),
                    CreateParameter("@dob", SqlDbType.DateTime, dob),
                    CreateParameter("@age", SqlDbType.Int, age),
                    CreateParameter("@sex", SqlDbType.Int, sex),
                    CreateParameter("@add1", SqlDbType.VarChar, add1),
                    CreateParameter("@add2", SqlDbType.VarChar, add2),
                    CreateParameter("@city", SqlDbType.VarChar, city),
                    CreateParameter("@districtId", SqlDbType.Int, districtId),
                    CreateParameter("@stateid", SqlDbType.Int, stateid),
                    CreateParameter("@countryid", SqlDbType.Int, countryid),
                    CreateParameter("@pin", SqlDbType.Int, pin),
                    CreateParameter("@phoneRes", SqlDbType.VarChar, phoneRes),
                    CreateParameter("@phoneOff", SqlDbType.VarChar, phoneOff),
                    CreateParameter("@mobile", SqlDbType.VarChar, mobile),
                    CreateParameter("@eMail", SqlDbType.VarChar, eMail),
                    CreateParameter("@payeeName", SqlDbType.VarChar, payeeName),
                    CreateParameter("@bank", SqlDbType.VarChar, bank),
                    CreateParameter("@accno", SqlDbType.VarChar, accno),
                    CreateParameter("@branch", SqlDbType.VarChar, branch),
                    CreateParameter("@ifscode", SqlDbType.VarChar, ifscode),
                    CreateParameter("@nominee", SqlDbType.VarChar, nominee),
                    CreateParameter("@relation", SqlDbType.VarChar, relation),
                    CreateParameter("@nomage", SqlDbType.Int, nomage),
                    CreateParameter("@sesid", SqlDbType.VarChar, sesid),
                    CreateParameter("@updatedby", SqlDbType.Int, updatedby)
                };
            return CreateCommand("UpdateMemDetailes_Sp", parameters);
        }
        internal static SqlCommand BlockIdorBlockToPaid(string action, Int32 regid, Int16 updatedby, string sesid, string remarks)
        {
            var parameters = new[]
                {
                    CreateParameter("@action", SqlDbType.VarChar, action),
                    CreateParameter("@regid", SqlDbType.Int, regid),
                    CreateParameter("@updatedby", SqlDbType.Int, updatedby),
                    CreateParameter("@sesid", SqlDbType.VarChar, sesid),
                    CreateParameter("@remarks", SqlDbType.VarChar, remarks)
                    
                };
            return CreateCommand("BlockIdorBlockToPaid_Sp", parameters);
        }
        internal static SqlCommand BinaryTreeView(string idno)
        {
            var parameters = new[]
            {
                CreateParameter("@membid", SqlDbType.VarChar, idno)                
            };
            return CreateCommand("BinaryTreeView_Sp", parameters);
        }
        internal static SqlCommand BinaryTreeViewTooltip(string idno)
        {
            var parameters = new[]
            {
                CreateParameter("@membid", SqlDbType.VarChar, idno)                
            };
            return CreateCommand("BinaryTreeViewTooltip_Sp", parameters);
        }
        internal static SqlCommand DirectDownLineReport(Int32 regid)
        {
            var parameters = new[]
            {
                CreateParameter("@regid", SqlDbType.BigInt, regid)                
            };
            return CreateCommand("DirectDownLineReport_Sp", parameters);
        }
        internal static SqlCommand Generationlevels(Int32 regid)
        {
            var parameters = new[]
            {
                CreateParameter("@regid", SqlDbType.BigInt, regid)                
            };
            return CreateCommand("Generationlevels_Sp", parameters);
        }
        internal static SqlCommand BinaryUplevelRpt(Int32 regid, Int32 pageIndex, Int32 pageSize)
        {
            var parameters = new[]
                {
                    CreateParameter("@regid", SqlDbType.BigInt, regid),
                    CreateParameter("@pageIndex", SqlDbType.Int, pageIndex),
                    CreateParameter("@pageSize", SqlDbType.Int, pageSize)
                };
            return CreateCommand("BinaryUplevelRpt_Sp", parameters);
        }
        internal static SqlCommand BinaryPrintView(string action, Int32 idno, DateTime frmdate, DateTime todate, Int32 pageIndex, Int32 pageSize)
        {
            var parameters = new[]
                {
                    CreateParameter("@action", SqlDbType.VarChar, action),
                    CreateParameter("@id", SqlDbType.Int, idno),
                    CreateParameter("@date", SqlDbType.DateTime, frmdate),
                    CreateParameter("@todate", SqlDbType.DateTime, todate),
                    CreateParameter("@pageIndex", SqlDbType.Int, pageIndex),
                    CreateParameter("@pageSize", SqlDbType.Int, pageSize)
                };
            return CreateCommand("BinaryPrintView_Sp", parameters);
        }
        internal static SqlCommand ConfirmationNote(Int32 regid)
        {
            var parameters = new[]
            {
                CreateParameter("@memid", SqlDbType.BigInt, regid)                
            };
            return CreateCommand("ConfirmationNote_Sp", parameters);
        }
        internal static SqlCommand WithdrawlRequestRpt(Int32 regid, Int32 pageIndex, Int32 pageSize)
        {
            var parameters = new[]
                {
                    CreateParameter("@regid", SqlDbType.BigInt, regid),
                    CreateParameter("@pageIndex", SqlDbType.Int, pageIndex),
                    CreateParameter("@pageSize", SqlDbType.Int, pageSize)
                };
            return CreateCommand("WithdrawlRequestRpt_Sp", parameters);
        }
        internal static SqlCommand RankStatusMem(Int32 regid, Int32 pageIndex, Int32 pageSize)
        {
            var parameters = new[]
                {
                    CreateParameter("@regid", SqlDbType.BigInt, regid),
                    CreateParameter("@pageIndex", SqlDbType.Int, pageIndex),
                    CreateParameter("@pageSize", SqlDbType.Int, pageSize)
                };
            return CreateCommand("RankStatusMem_Sp", parameters);
        }

        internal static SqlCommand AddorDeductMemEwallet(Int32 regId, string descr, double inAmt, double outAmt,
                                                         string remarks, string typeOfInc, string thru, int payNo,
                                                         string sessId)
        {
            var parameters = new[]
                {
                    CreateParameter("@regId", SqlDbType.BigInt, regId),
                    CreateParameter("@descr", SqlDbType.VarChar, descr),
                    CreateParameter("@inAmt", SqlDbType.Money, inAmt),
                    CreateParameter("@outAmt", SqlDbType.Money, outAmt),
                    CreateParameter("@remarks", SqlDbType.VarChar, remarks),
                    CreateParameter("@typeOfInc", SqlDbType.VarChar, typeOfInc),
                    CreateParameter("@thru", SqlDbType.VarChar, thru),
                    CreateParameter("@payNo", SqlDbType.Int, payNo),
                    CreateParameter("@sessId", SqlDbType.VarChar, sessId)
                };
            return CreateCommand("AddorDeductMemEwallet_Sp", parameters);
        }
        internal static SqlCommand Myorders(Int32 regid, Int32 pageIndex, Int32 pageSize)
        {
            var parameters = new[]
                {
                    CreateParameter("@regid", SqlDbType.BigInt, regid),             
                    CreateParameter("@pageIndex", SqlDbType.Int, pageIndex),
                    CreateParameter("@pageSize", SqlDbType.Int, pageSize)
                };
            return CreateCommand("Myorders_Sp", parameters);
        }
        internal static SqlCommand UpdateBankSlips(Int32 regid, string prcode, double amount, string ipadd, string sesid, string src)
        {
            var parameters = new[]
                {
                    CreateParameter("@regid", SqlDbType.BigInt, regid),
                    CreateParameter("@prcode", SqlDbType.VarChar, prcode),
                    CreateParameter("@amount", SqlDbType.Money, amount),
                    CreateParameter("@ipadd", SqlDbType.VarChar, ipadd),
                    CreateParameter("@sesid", SqlDbType.VarChar, sesid),
                    CreateParameter("@src", SqlDbType.VarChar, src)
                };
            return CreateCommand("UpdateBankSlips_Sp", parameters);
        }
        internal static SqlCommand Chgaddress(Int32 regid, string maidenname,
                                                 string dob, string sex, string add1, string add2, string city,
                              string district, string state, Int32 pin, string mobile, string eMail, string corcity, string cordistrict, string corstate, Int32 corpin,string GSTNO)
        {
            var parameters = new[]
            {
                CreateParameter("@regid", SqlDbType.BigInt, regid),                 
                CreateParameter("@maidenname", SqlDbType.VarChar, maidenname),
                CreateParameter("@dob", SqlDbType.VarChar, dob),
                CreateParameter("@sex", SqlDbType.VarChar, sex),
                CreateParameter("@add1", SqlDbType.VarChar, add1),
                CreateParameter("@add2", SqlDbType.VarChar, add2),
                CreateParameter("@city", SqlDbType.VarChar, city),
                CreateParameter("@district", SqlDbType.VarChar, district),
                CreateParameter("@state", SqlDbType.VarChar, state),
                CreateParameter("@pin", SqlDbType.Int, pin),
                CreateParameter("@mobile", SqlDbType.VarChar, mobile),
                CreateParameter("@eMail", SqlDbType.VarChar, eMail),
                CreateParameter("@corcity", SqlDbType.VarChar, corcity),
                CreateParameter("@cordistrict", SqlDbType.VarChar, cordistrict),
                CreateParameter("@corstate", SqlDbType.VarChar, corstate),
                CreateParameter("@corpin", SqlDbType.Int, corpin),
                CreateParameter("@GSTNO",SqlDbType.VarChar,GSTNO)
            };
            return CreateCommand("ChgAddress_Sp", parameters);
        }
        internal static SqlCommand Chgbank(Int32 regid, string payeeName, string panno, string bank, string accno, string branch, string ifscode)
        {
            var parameters = new[]
                {
                    CreateParameter("@regid", SqlDbType.BigInt, regid),
                    CreateParameter("@payeeName", SqlDbType.VarChar, payeeName),
                    CreateParameter("@panno", SqlDbType.VarChar, panno),
                    CreateParameter("@bank", SqlDbType.VarChar, bank),
                    CreateParameter("@accno", SqlDbType.VarChar, accno),
                    CreateParameter("@branch", SqlDbType.VarChar, branch),
                    CreateParameter("@ifscode", SqlDbType.VarChar, ifscode)
                };
            return CreateCommand("chgbank_Sp", parameters);
        }
        internal static SqlCommand Chgnominee(Int32 regid, string nominee, string relation, DateTime NomineeDOB)
        {
            var parameters = new[]
                {
                    CreateParameter("@regid", SqlDbType.BigInt, regid),
                    CreateParameter("@nominee", SqlDbType.VarChar, nominee),
                    CreateParameter("@relation", SqlDbType.VarChar, relation),
                    CreateParameter("@NomineeDOB", SqlDbType.DateTime, NomineeDOB)
                };
            return CreateCommand("chgnominee_Sp", parameters);
        }
        internal static SqlCommand BigBossReward(Int32 regid)
        {
            var parameters = new[]
            {
                CreateParameter("@regid", SqlDbType.BigInt, regid)                
            };
            return CreateCommand("BigBossReward_Sp", parameters);
        }
        internal static SqlCommand GetProvidersCircles(string action)
        {
            var parameters = new[]
            {
                CreateParameter("@action", SqlDbType.VarChar, action)                
            };
            return CreateCommand("GetProviderscircles_Sp", parameters);
        }
        internal static SqlCommand TmpMobileRech(Int32 regid, string provider, double amount, Int32 mobile, string ipadd)
        {
            var parameters = new[]
                {
                    CreateParameter("@regid", SqlDbType.BigInt, regid),
                    CreateParameter("@provider", SqlDbType.VarChar, provider),
                    CreateParameter("@amount", SqlDbType.Money, amount),
                    CreateParameter("@mobile", SqlDbType.BigInt, mobile),
                    CreateParameter("@ipadd", SqlDbType.VarChar, ipadd)
                };
            return CreateCommand("tmpMobileRech_SP", parameters);
        }
        internal static SqlCommand Deletetable(string response)
        {
            var parameters = new[]
                {   
                    CreateParameter("@response", SqlDbType.VarChar, response)
                };
            return CreateCommand("deletetable_Sp", parameters);
        }
        internal static SqlCommand MrUpdate(Int32 regid, string mobile, string provider, string circle, string txnId, double rchAmt, string statusType, string remarks)
        {
            var parameters = new[]
                {                       
                    CreateParameter("@regid", SqlDbType.VarChar, regid),
                    CreateParameter("@mobile", SqlDbType.VarChar, mobile),
                    CreateParameter("@provider", SqlDbType.VarChar, provider),
                    CreateParameter("@circle", SqlDbType.VarChar, circle),
                    CreateParameter("@txnId", SqlDbType.VarChar, txnId),
                    CreateParameter("@rchAmt", SqlDbType.Money, rchAmt),
                    CreateParameter("@statusType", SqlDbType.VarChar, statusType),
                    CreateParameter("@remarks", SqlDbType.VarChar, remarks),
                };
            return CreateCommand("MRUpdate", parameters);
        }
        internal static SqlCommand MemberInvoices(string action, Int32 regid)
        {
            var parameters = new[]
                {   
                    CreateParameter("@action", SqlDbType.VarChar, action),
                    CreateParameter("@regid", SqlDbType.BigInt, regid) 
                };
            return CreateCommand("MemberInvoices_Sp", parameters);
        }

        internal static SqlCommand CheckDownTo(Int32 regid, string downto)
        {
            var parameters = new[]
                {                       
                    CreateParameter("@regid", SqlDbType.BigInt, regid) ,
                    CreateParameter("@downto", SqlDbType.VarChar, downto)
                };
            return CreateCommand("CheckDownTo_Sp", parameters);
        }
        internal static SqlCommand MemWithdrawlRequestType(string potratype, string PotraMode, Int32 regid)
        {
            var parameters = new[]
                {                       
                    CreateParameter("@potratype", SqlDbType.VarChar, potratype) ,
                     CreateParameter("@potramode", SqlDbType.VarChar, PotraMode) ,
                    CreateParameter("@regid", SqlDbType.BigInt, regid)
                };
            return CreateCommand("MemWithdrawlRequestType_Sp", parameters);
        }
        internal static SqlCommand ChkMemWithdrawlRequest(string action, Int32 regid)
        {
            var parameters = new[]
                {                       
                    CreateParameter("@action", SqlDbType.VarChar, action) ,
                    CreateParameter("@regid", SqlDbType.BigInt, regid)
                };
            return CreateCommand("ChkMemWithdrawlRequest_SP", parameters);
        }
        internal static SqlCommand MemWithdrawlRequest(string action, Int32 regid, double amount, string remarks, string sesid)
        {
            var parameters = new[]
                {                       
                    CreateParameter("@action", SqlDbType.VarChar, action) ,
                    CreateParameter("@regid", SqlDbType.BigInt, regid),
                    CreateParameter("@amount", SqlDbType.Money, amount) ,
                    CreateParameter("@remarks", SqlDbType.VarChar, remarks) ,
                    CreateParameter("@sesid", SqlDbType.VarChar, sesid)
                };
            return CreateCommand("MemWithdrawlRequest_SP", parameters);
        }
        internal static SqlCommand ChkMobileEmail(string mobemail, string type)
        {
            var parameters = new[]
                {                       
                    CreateParameter("@mobemail", SqlDbType.VarChar, mobemail) ,
                    CreateParameter("@type", SqlDbType.VarChar, type)
                };
            return CreateCommand("ChkMobileEmail_Sp", parameters);
        }
        internal static SqlCommand MemberDetailes(Int32 regid)
        {
            var parameters = new[]
            {                
                CreateParameter("@regid", SqlDbType.BigInt, regid)                
            };
            return CreateCommand("MemberDetailes_Sp", parameters);
        }
        internal static SqlCommand TempMemberDetailes(Int32 regid)
        {
            var parameters = new[]
            {                
                CreateParameter("@regid", SqlDbType.BigInt, regid)                
            };
            return CreateCommand("TempMemberDetailes_Sp", parameters);
        }
        internal static SqlCommand AdminEditPermission(Int32 uid)
        {
            var parameters = new[]
            {                
                CreateParameter("@uid", SqlDbType.Int, uid)                
            };
            return CreateCommand("AdminEditPermission_Sp", parameters);
        }

        internal static SqlCommand BlockorUnBlock(string action, Int32 regid, Int32 updatedby, string remarks, string sesid)
        {
            var parameters = new[]
               {                    
                    CreateParameter("@action", SqlDbType.VarChar, action),                 
                    CreateParameter("@regid", SqlDbType.BigInt, regid),                    
                    CreateParameter("@updatedby", SqlDbType.Int , updatedby),
                    CreateParameter("@remarks", SqlDbType.VarChar, remarks),                                       
                    CreateParameter("@sesid", SqlDbType.VarChar, sesid) 
                };
            return CreateCommand("BlockorUnBlock_Sp", parameters);
        }
        internal static SqlCommand BlockorUnBlockIdsRpt(string action, string idno, string regtype, DateTime frmdate, DateTime todate, Int32 pageIndex, Int32 pageSize)
        {
            var parameters = new[]
               {                    
                    CreateParameter("@action", SqlDbType.VarChar, action),
                    CreateParameter("@idno", SqlDbType.VarChar, idno),
                    CreateParameter("@regtype", SqlDbType.VarChar, regtype),
                    CreateParameter("@frmdate", SqlDbType.DateTime, frmdate),                    
                    CreateParameter("@todate", SqlDbType.DateTime , todate),
                    CreateParameter("@pageIndex", SqlDbType.Int, pageIndex),                                       
                    CreateParameter("@pageSize", SqlDbType.Int, pageSize) 
                };
            return CreateCommand("BlockorUnBlockIdsRpt_sp", parameters);
        }
        internal static SqlCommand BinaryTabular(Int32 regid, DateTime frmdate, DateTime todate, string rtype, Int32 status, string val)
        {
            var parameters = new[]
               {    
                    CreateParameter("@regid", SqlDbType.Int, regid),
                    CreateParameter("@frmdate", SqlDbType.DateTime, frmdate),                    
                    CreateParameter("@todate", SqlDbType.DateTime , todate),
                    CreateParameter("@rtype", SqlDbType.VarChar , rtype),
                    CreateParameter("@status", SqlDbType.Int, status),
                    CreateParameter("@val", SqlDbType.VarChar, val)
                };
            return CreateCommand("BinaryTabular_Sp", parameters);
        }
        internal static SqlCommand SponsorReport(Int32 regid, Int32 pageindex, Int32 pagesize)
        {
            var parameters = new[]
               {                                        
                    CreateParameter("@regid", SqlDbType.Int, regid) ,
                    CreateParameter("@pageindex", SqlDbType.Int, pageindex),                                       
                    CreateParameter("@pagesize", SqlDbType.Int, pagesize)
                };
            return CreateCommand("SponsorReport_sp", parameters);
        }
        internal static SqlCommand UnilevelPrintView(string action, Int32 regid, DateTime frmdate, DateTime todate, Int32 pageindex, Int32 pagesize)
        {
            var parameters = new[]
               {    
                   CreateParameter("@action", SqlDbType.VarChar, action),                  
                    CreateParameter("@regid", SqlDbType.Int, regid),
                    CreateParameter("@frmdate", SqlDbType.DateTime, frmdate),                    
                    CreateParameter("@todate", SqlDbType.DateTime , todate),
                    CreateParameter("@pageindex", SqlDbType.Int, pageindex),                                       
                    CreateParameter("@pagesize", SqlDbType.Int, pagesize) 
                };
            return CreateCommand("UnilevelPrintView_Sp", parameters);
        }
        //29-2 Satish
        internal static SqlCommand EwalletSummaryRpt(string action, Int32 regid, DateTime frmdate, DateTime todate, Int32 pageindex, Int32 pagesize, double Balance)
        {
            var parameters = new[]
               {                       
                   CreateParameter("@action", SqlDbType.VarChar, action),  
                   CreateParameter("@regid", SqlDbType.Int, regid),  
                     CreateParameter("@frmdate", SqlDbType.DateTime, frmdate),                    
                    CreateParameter("@todate", SqlDbType.DateTime , todate),
                    CreateParameter("@pageindex", SqlDbType.Int, pageindex),                                       
                    CreateParameter("@pagesize", SqlDbType.Int, pagesize),                    
                    CreateParameter("@Balance", SqlDbType.Money, Balance)
                };
            return CreateCommand("EwalletSummaryRpt_Sp", parameters);
        }
        //rk
        internal static SqlCommand EwalletSummaryRpt1(string action, Int32 regid, DateTime frmdate, DateTime todate, Int32 pageindex, Int32 pagesize, double Balance,Int32 payno)
        {
            var parameters = new[]
               {                       
                   CreateParameter("@action", SqlDbType.VarChar, action),  
                   CreateParameter("@regid", SqlDbType.Int, regid),  
                     CreateParameter("@frmdate", SqlDbType.DateTime, frmdate),                    
                    CreateParameter("@todate", SqlDbType.DateTime , todate),
                    CreateParameter("@pageindex", SqlDbType.Int, pageindex),                                       
                    CreateParameter("@pagesize", SqlDbType.Int, pagesize),                    
                    CreateParameter("@Balance", SqlDbType.Money, Balance),
                     CreateParameter("@payno", SqlDbType.Int, payno)
                };
            return CreateCommand("EwalletSummaryRpt1_Sp", parameters);
        }
        internal static SqlCommand GetEwalBalance(string action, Int32 regid)
        {
            var parameters = new[]
               {                    
                    CreateParameter("@action", SqlDbType.VarChar, action),                 
                    CreateParameter("@regid", SqlDbType.Int, regid) 
                };
            return CreateCommand("GetEwalBalance_sp", parameters);
        }
        internal static SqlCommand GetWithdrawalEwalBalance(string action, Int32 regid)
        {
            var parameters = new[]
               {                    
                    CreateParameter("@action", SqlDbType.VarChar, action),                 
                    CreateParameter("@regid", SqlDbType.Int, regid) 
                };
            return CreateCommand("GetWithdrawalEwalBalance_sp", parameters);
        }
        internal static SqlCommand AddorDeductWithdrawalWallet(string action, Int32 regid, Double amount, String typeofinc, string remarks, Int32 thru, string sessId)
        {
            var parameters = new[]
               {                       
                   CreateParameter("@action", SqlDbType.VarChar , action), 
                   CreateParameter("@regid", SqlDbType.Int, regid),  
                   CreateParameter("@amount", SqlDbType.Money, amount),                    
                   CreateParameter("@typeofinc", SqlDbType.VarChar , typeofinc),
                   CreateParameter("@remarks", SqlDbType.VarChar, remarks),                                       
                   CreateParameter("@thru", SqlDbType.Int, thru) ,
                   CreateParameter("@sessId", SqlDbType.VarChar, sessId)                                       
                };
            return CreateCommand("AddorDeductWithdrawalWallet_Sp", parameters);
        }
        internal static SqlCommand AddorDeductWithdrawalRpt(Int32 regid, DateTime frmdate, DateTime todate, Int32 pageindex, Int32 pagesize)
        {
            var parameters = new[]
               {                       
                    CreateParameter("@regid", SqlDbType.Int, regid),  
                     CreateParameter("@frmdate", SqlDbType.DateTime, frmdate),                    
                    CreateParameter("@todate", SqlDbType.DateTime , todate),
                    CreateParameter("@pageindex", SqlDbType.Int, pageindex),                                       
                    CreateParameter("@pagesize", SqlDbType.Int, pagesize) 
                };
            return CreateCommand("AddorDeductWithdrawalRpt_Sp", parameters);
        }

        internal static SqlCommand AddorDeductWallet(string action, Int32 regid, Double amount, String typeofinc, string remarks, Int32 thru, string sessId)
        {
            var parameters = new[]
               {                       
                   CreateParameter("@action", SqlDbType.VarChar , action), 
                   CreateParameter("@regid", SqlDbType.Int, regid),  
                   CreateParameter("@amount", SqlDbType.Money, amount),                    
                   CreateParameter("@typeofinc", SqlDbType.VarChar , typeofinc),
                   CreateParameter("@remarks", SqlDbType.VarChar, remarks),                                       
                   CreateParameter("@thru", SqlDbType.Int, thru) ,
                   CreateParameter("@sessId", SqlDbType.VarChar, sessId)                                       
                };
            return CreateCommand("AddorDeductWallet_Sp", parameters);
        }
        internal static SqlCommand AddorDeductRpt(Int32 regid, DateTime frmdate, DateTime todate, Int32 pageindex, Int32 pagesize)
        {
            var parameters = new[]
               {                       
                    CreateParameter("@regid", SqlDbType.Int, regid),  
                     CreateParameter("@frmdate", SqlDbType.DateTime, frmdate),                    
                    CreateParameter("@todate", SqlDbType.DateTime , todate),
                    CreateParameter("@pageindex", SqlDbType.Int, pageindex),                                       
                    CreateParameter("@pagesize", SqlDbType.Int, pagesize) 
                };
            return CreateCommand("AddorDeductRpt_Sp", parameters);
        }
        internal static SqlCommand AppConsultantReport(string searchid, Int16 status, DateTime frmdate, DateTime todate,
                                                     Int32 regid, Int32 stateid, Int32 pageIndex, Int32 pageSize, string Action)
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
                CreateParameter("@pageSize", SqlDbType.BigInt, pageSize),
                 CreateParameter("@Action", SqlDbType.VarChar, Action)
            };
            return CreateCommand("AppConsultantReport_Sp", parameters);
        }
        internal static SqlCommand InsFeedback(string Idno, string Name, string Email, string Qtype, string State, string Mobile, string Enquiry, string Sessid, string Ipadd)
        {
            var parameters = new[]
               {                  
                    CreateParameter("@Idno", SqlDbType.VarChar, Idno),                 
                    CreateParameter("@Name", SqlDbType.VarChar, Name) ,
                    CreateParameter("@Email", SqlDbType.VarChar, Email),                 
                    CreateParameter("@Qtype", SqlDbType.VarChar, Qtype), 
                    CreateParameter("@State", SqlDbType.VarChar, State),                 
                    CreateParameter("@Mobile", SqlDbType.VarChar, Mobile),
                    CreateParameter("@Enquiry", SqlDbType.VarChar, Enquiry),                 
                    CreateParameter("@SessId", SqlDbType.VarChar, Sessid),
                    CreateParameter("@Ipadd", SqlDbType.VarChar, Ipadd)
                };
            return CreateCommand("InsFeedback", parameters);
        }
        //08-03 Satish
        internal static SqlCommand UpdateMemberProfile(Int32 regid, string fname, string lname, string maidenname,
                                                        string dob, string sex, string add1, string add2, string city,
                                                        string district, string state, Int32 pin, string mobile, string eMail, string payeename, string panno, string bank,
                                              string branch, string accno, string ifscode, string nominee,
                         string relation, string nomineedob, string User, string sessid, string ipaddress, string corcity, string cordistrict, string corstate, Int32 corpin,string GSTNO)
        {
            var parameters = new[]
               {                    
                    CreateParameter("@regid", SqlDbType.BigInt, regid), 
                    CreateParameter("@fname", SqlDbType.VarChar, fname),
                    CreateParameter("@lname", SqlDbType.VarChar, lname),
                    CreateParameter("@maidenname", SqlDbType.VarChar, maidenname),
                    CreateParameter("@dob", SqlDbType.VarChar, dob),
                    CreateParameter("@sex", SqlDbType.VarChar, sex),
                    CreateParameter("@add1", SqlDbType.VarChar, add1),
                    CreateParameter("@add2", SqlDbType.VarChar, add2),
                    CreateParameter("@city", SqlDbType.VarChar, city),
                    CreateParameter("@district", SqlDbType.VarChar, district),
                    CreateParameter("@state", SqlDbType.VarChar, state),
                    CreateParameter("@pin", SqlDbType.Int, pin),
                    CreateParameter("@mobile", SqlDbType.VarChar, mobile),
                    CreateParameter("@eMail", SqlDbType.VarChar, eMail),
                    CreateParameter("@payeename", SqlDbType.VarChar, payeename),
                    CreateParameter("@panno", SqlDbType.VarChar, panno),
                    CreateParameter("@bank", SqlDbType.VarChar, bank),
                    CreateParameter("@branch", SqlDbType.VarChar, branch),
                    CreateParameter("@accno", SqlDbType.VarChar, accno),
                    CreateParameter("@ifscode", SqlDbType.VarChar, ifscode),
                    CreateParameter("@nominee", SqlDbType.VarChar, nominee),
                    CreateParameter("@relation", SqlDbType.VarChar, relation),
                    CreateParameter("@nomineedob", SqlDbType.VarChar, nomineedob),
                    CreateParameter("@User", SqlDbType.VarChar, User),
                    CreateParameter("@sessid", SqlDbType.VarChar, sessid),
                    CreateParameter("@ipaddress", SqlDbType.VarChar, ipaddress),                  
                    CreateParameter("@corcity", SqlDbType.VarChar, corcity),
                    CreateParameter("@cordistrict", SqlDbType.VarChar, cordistrict),
                    CreateParameter("@corstate", SqlDbType.VarChar, corstate),
                    CreateParameter("@corpin", SqlDbType.Int, corpin),
                    CreateParameter("@GSTNO",SqlDbType.VarChar,GSTNO)
                };
            return CreateCommand("UpdateMemberProfile_Sp", parameters);
        }

        //16/03 Satish
        internal static SqlCommand UploadKyc(Int32 regid, string ProofType, string panno, string panimg, string bank, string branch, string accno, string ifscode, string chqimg, string sesid, string Remarks, string ModuleType)
        {
            var parameters = new[]
            {
                CreateParameter("@regid", SqlDbType.BigInt, regid ),
                CreateParameter("@ProofType", SqlDbType.VarChar, ProofType ),
                CreateParameter("@panno", SqlDbType.VarChar, panno ),
                CreateParameter("@panimg", SqlDbType.VarChar, panimg ),
                CreateParameter("@bank", SqlDbType.VarChar, bank ),
                CreateParameter("@branch", SqlDbType.VarChar, branch ),
                CreateParameter("@accno", SqlDbType.VarChar, accno ),
                CreateParameter("@ifscode", SqlDbType.VarChar, ifscode ),
                CreateParameter("@chqimg", SqlDbType.VarChar, chqimg ),
                CreateParameter("@sesid", SqlDbType.VarChar, sesid ),
                CreateParameter("@Remarks", SqlDbType.VarChar, Remarks),
                CreateParameter("@ModuleType", SqlDbType.VarChar, ModuleType)
            };
            return CreateCommand("UploadKYC_Sp", parameters);
        }
        internal static SqlCommand Kyc(Int32 regid, string Type)
        {
            var parameters = new[]
            {
                CreateParameter("@regid", SqlDbType.BigInt, regid ),
                  CreateParameter("@type", SqlDbType.VarChar, Type )              
            };
            return CreateCommand("Kyc_Sp", parameters);
        }
        internal static SqlCommand ChkEditProfileSts(string action, Int32 regid)
        {
            var parameters = new[]
               {                                        
                    CreateParameter("@action", SqlDbType.VarChar, action) ,
                    CreateParameter("@regid", SqlDbType.BigInt, regid) 
                };
            return CreateCommand("ChkEditProfileSts_SP", parameters);
        }
        internal static SqlCommand UploadMemPhoto(Int32 regid, string image)
        {
            var parameters = new[]
            {
                CreateParameter("@regid", SqlDbType.BigInt, regid ),
                CreateParameter("@image", SqlDbType.VarChar, image )
                               
            };
            return CreateCommand("UploadMemPhoto_SP", parameters);
        }
        internal static SqlCommand CheckUserName(string IDNO, string RptType)
        {
            var parameters = new[]
            {
             CreateParameter("@IDNO", SqlDbType.NVarChar,IDNO),
             CreateParameter("@RptType", SqlDbType.NVarChar,RptType)
             };
            return CreateCommand("CheckUserName", parameters);
        }

        //17/03 satish
        internal static SqlCommand MakeCreditRequest(Int32 regid, double reqAmt, string mop, string refno,
                                                     DateTime invdate, string invbank, string invbranch, string depbank,
                                                     string depbranch, string depcity, DateTime depdate, string depslip,
                                                     string remarks)
        {
            var parameters = new[]
                {
                    CreateParameter("@regid", SqlDbType.BigInt, regid),
                    CreateParameter("@reqAmt", SqlDbType.Money, reqAmt),
                    CreateParameter("@mop", SqlDbType.VarChar, mop),
                    CreateParameter("@refno", SqlDbType.VarChar, refno),
                    CreateParameter("@invdate", SqlDbType.DateTime, invdate),
                    CreateParameter("@invbank", SqlDbType.VarChar, invbank),
                    CreateParameter("@invbranch", SqlDbType.VarChar, invbranch),
                    CreateParameter("@depbank", SqlDbType.VarChar, depbank),
                    CreateParameter("@depbranch", SqlDbType.VarChar, depbranch),
                    CreateParameter("@depcity", SqlDbType.VarChar, depcity),
                    CreateParameter("@depdate", SqlDbType.DateTime, depdate),
                    CreateParameter("@depslip", SqlDbType.VarChar, depslip),
                    CreateParameter("@remarks", SqlDbType.VarChar, remarks)

                };
            return CreateCommand("MakeCreditRequest_SP", parameters);
        }

        internal static SqlCommand MemeberReport(Int32 regid, String RegType, Int32 Status, Int32 pageindex, Int32 pagesize)
        {
            var parameters = new[]
               {   
                   CreateParameter("@regid", SqlDbType.BigInt, regid),
                    CreateParameter("@RegType", SqlDbType.VarChar, RegType) ,                                
                    CreateParameter("@Status", SqlDbType.Int, Status) ,
                    CreateParameter("@pageindex", SqlDbType.Int, pageindex),                                       
                    CreateParameter("@pagesize", SqlDbType.Int, pagesize)
                };
            return CreateCommand("MemeberReport_SP", parameters);
        }

        internal static SqlCommand chkDwnLine(String RegType, Int32 regid)
        {


            var parameters = new[]
               {   
                    CreateParameter("@idno", SqlDbType.VarChar, RegType) ,                                
                    CreateParameter("@regid", SqlDbType.BigInt, regid) 
                    
                };
            return CreateCommand("chkDwnLine_sp", parameters);
        }

        internal static SqlCommand FundTransfer(String regid, String idno, int Amount, String remarks, String sessid)
        {

            var parameters = new[]
               {   
                    CreateParameter("@regid", SqlDbType.VarChar, regid) ,                                
                    CreateParameter("@idno", SqlDbType.VarChar, idno) ,
                    CreateParameter("@Amount", SqlDbType.Int, Amount) ,                                
                    CreateParameter("@remarks", SqlDbType.VarChar, remarks) ,
                    CreateParameter("@sessid", SqlDbType.VarChar, sessid) 
                    
                };
            return CreateCommand("FundTransfer_sp", parameters);
        }
        internal static SqlCommand MemberCV(String action, DateTime frmdate, DateTime todate, Int32 regid)
        {
            var parameters = new[]
               {    
                    CreateParameter("@action", SqlDbType.VarChar, action ),
                    CreateParameter("@fromdate", SqlDbType.DateTime, frmdate),                    
                    CreateParameter("@todate", SqlDbType.DateTime , todate),
                   CreateParameter("@regid", SqlDbType.Int, regid)
                };
            return CreateCommand("MemberCV_SP", parameters);
        }

        internal static SqlCommand UploadCustomerOrder(String action, Int32 regid, string ProofType, string OrderNo, string OrderPhoto, string bank, string accno, string branch, string ifscode, string chqimg, string sesid, string Remarks)
        {
            var parameters = new[]
            {
                CreateParameter("@action", SqlDbType.VarChar, action ),
                CreateParameter("@regid", SqlDbType.BigInt, regid ),
                CreateParameter("@ProofType", SqlDbType.VarChar, ProofType ),
                CreateParameter("@OrderNo", SqlDbType.VarChar, OrderNo ),
                CreateParameter("@OrderPhoto", SqlDbType.VarChar, OrderPhoto ),
                CreateParameter("@bank", SqlDbType.VarChar, bank ),
                CreateParameter("@accno", SqlDbType.VarChar, accno ),
                CreateParameter("@branch", SqlDbType.VarChar, branch ),
                CreateParameter("@ifscode", SqlDbType.VarChar, ifscode ),
                CreateParameter("@chqimg", SqlDbType.VarChar, chqimg ),
                CreateParameter("@sesid", SqlDbType.VarChar, sesid ),
                CreateParameter("@Remarks", SqlDbType.VarChar, Remarks)
            };
            return CreateCommand("UploadCustomerOrder_sp", parameters);
        }

        internal static SqlCommand GetUniqid()
        {
            return CreateCommand("GetUniqid");
        }

        internal static SqlCommand RegistrationOnlineInsert(string action, string userno, Int32 sprno, string spseries, string fname, string lname,
                                                 DateTime dob, string sex, string add1, string add2, string city,
                                                 string district, string state, Int32 pin, string mobile, string eMail, string lpassword,
                                                 string tpassword, string sesid, Int32 downto, string panno, string Title, string guardian,
                                                 string altmobile, string qualification, string subject, string ddrefno, DateTime Refdddate, string refddbank, string ddrefbranch,
                                                 string reftype, Int32 Pid, Int32 BV, string percity,
                                                 string perdistrict, string perstate, Int32 perpin, string landline, string careof, string fullitemcode,
                                                 string ORDER_ID, string PaymentStatus, string BillStatus, string TXNID, Int32 regid, string CUST_ID, string TXN_AMOUNT, string pgtype)
        {
            var parameters = new[]
            {
                CreateParameter("@action", SqlDbType.VarChar, action) ,
                CreateParameter("@userno", SqlDbType.VarChar, userno) ,
                CreateParameter("@sprno", SqlDbType.BigInt, sprno) ,
                CreateParameter("@spseries", SqlDbType.VarChar, spseries) ,
                CreateParameter("@fname", SqlDbType.VarChar, fname) ,
                CreateParameter("@lname", SqlDbType.VarChar, lname) ,
                CreateParameter("@dob", SqlDbType.DateTime, dob) ,
                CreateParameter("@sex", SqlDbType.VarChar, sex) ,
                CreateParameter("@add1", SqlDbType.VarChar, add1) ,
                CreateParameter("@add2", SqlDbType.VarChar, add2) ,
                CreateParameter("@city", SqlDbType.VarChar, city) ,
                CreateParameter("@district", SqlDbType.VarChar, district) ,
                CreateParameter("@state", SqlDbType.VarChar, state) ,
                CreateParameter("@pin", SqlDbType.BigInt, pin) ,
                CreateParameter("@mobile", SqlDbType.VarChar, mobile) ,
                CreateParameter("@eMail", SqlDbType.VarChar, eMail) ,
                CreateParameter("@lpassword", SqlDbType.VarChar, lpassword) ,
                CreateParameter("@tpassword", SqlDbType.VarChar, tpassword) ,
                CreateParameter("@sesid", SqlDbType.VarChar, sesid) ,
                CreateParameter("@downto", SqlDbType.BigInt, downto) ,
                CreateParameter("@panno", SqlDbType.VarChar, panno) ,
                CreateParameter("@Title", SqlDbType.VarChar, Title) ,
                CreateParameter("@guardian", SqlDbType.VarChar, guardian) ,
                CreateParameter("@altmobile", SqlDbType.VarChar, altmobile) ,
                CreateParameter("@qualification", SqlDbType.VarChar, qualification) ,
                CreateParameter("@subject", SqlDbType.VarChar, subject) ,
                CreateParameter("@ddrefno", SqlDbType.VarChar, ddrefno) ,
                CreateParameter("@Refdddate", SqlDbType.DateTime, Refdddate) ,
                CreateParameter("@refddbank", SqlDbType.VarChar, refddbank) ,
                CreateParameter("@ddrefbranch", SqlDbType.VarChar, ddrefbranch) ,
                CreateParameter("@reftype", SqlDbType.VarChar, reftype) ,
                CreateParameter("@Pid", SqlDbType.BigInt, Pid) ,
                CreateParameter("@BV", SqlDbType.BigInt, BV) ,
                CreateParameter("@percity", SqlDbType.VarChar, percity) ,
                CreateParameter("@perdistrict", SqlDbType.VarChar, perdistrict) ,
                CreateParameter("@perstate", SqlDbType.VarChar, perstate) ,
                CreateParameter("@perpin", SqlDbType.BigInt, perpin) ,
                CreateParameter("@landline", SqlDbType.VarChar, landline) ,
                CreateParameter("@careof", SqlDbType.VarChar, careof) ,
                CreateParameter("@fullitemcode", SqlDbType.VarChar, fullitemcode) ,
                CreateParameter("@ORDER_ID", SqlDbType.VarChar, ORDER_ID) ,
                CreateParameter("@PaymentStatus", SqlDbType.VarChar, PaymentStatus) ,
                CreateParameter("@BillStatus", SqlDbType.VarChar, BillStatus) ,
                CreateParameter("@TXNID", SqlDbType.VarChar, TXNID) ,
                CreateParameter("@regid", SqlDbType.BigInt, regid),
                CreateParameter("@CUST_ID", SqlDbType.VarChar, CUST_ID) ,
                CreateParameter("@TXN_AMOUNT", SqlDbType.Money, Convert.ToDouble(TXN_AMOUNT)),
                CreateParameter("@pgtype", SqlDbType.VarChar, pgtype)
            };
            return CreateCommand("RegistrationOnlineInsert_Sp", parameters);
        }

        internal static SqlCommand GetRegistrationOnline(string ORDERID)
        {
            var parameters = new[]
               {    
                    CreateParameter("@ORDERID", SqlDbType.VarChar, ORDERID)
                };
            return CreateCommand("GetRegistrationOnline_SP", parameters);
        }

        internal static SqlCommand LogOnlineDataNew(string SUBS_ID, string MID, string TXNID, string ORDERID, string BANKTXNID, string TXNAMOUNT, string CURRENCY,
            string STATUS, string RESPCODE, string RESPMSG, string TXNDATE, string GATEWAYNAME, string BANKNAME, string PAYMENTMODE, string PROMO_CAMP_ID,
            string PROMO_STATUS, string PROMO_RESPCODE, string CHECKSUMHASH, string remarks)
        {
            var parameters = new[]
               {    
                    CreateParameter("@SUBS_ID", SqlDbType.VarChar, SUBS_ID),
                    CreateParameter("@MID", SqlDbType.VarChar, MID),
                    CreateParameter("@TXNID", SqlDbType.VarChar, TXNID),
                    CreateParameter("@ORDERID", SqlDbType.VarChar, ORDERID),
                    CreateParameter("@BANKTXNID", SqlDbType.VarChar, BANKTXNID),
                    CreateParameter("@TXNAMOUNT", SqlDbType.VarChar, TXNAMOUNT),
                    CreateParameter("@CURRENCY", SqlDbType.VarChar, CURRENCY),
                    CreateParameter("@STATUS", SqlDbType.VarChar, STATUS),
                    CreateParameter("@RESPCODE", SqlDbType.VarChar, RESPCODE),
                    CreateParameter("@RESPMSG", SqlDbType.VarChar, RESPMSG),
                    CreateParameter("@TXNDATE", SqlDbType.DateTime, Convert.ToDateTime(TXNDATE)),
                    CreateParameter("@GATEWAYNAME", SqlDbType.VarChar, GATEWAYNAME),
                    CreateParameter("@BANKNAME", SqlDbType.VarChar, BANKNAME),
                    CreateParameter("@PAYMENTMODE", SqlDbType.VarChar, PAYMENTMODE),
                    CreateParameter("@PROMO_CAMP_ID", SqlDbType.VarChar, PROMO_CAMP_ID),
                    CreateParameter("@PROMO_STATUS", SqlDbType.VarChar, PROMO_STATUS),
                    CreateParameter("@PROMO_RESPCODE", SqlDbType.VarChar, PROMO_RESPCODE),
                    CreateParameter("@CHECKSUMHASH", SqlDbType.VarChar, CHECKSUMHASH),
                    CreateParameter("@remarks", SqlDbType.VarChar, remarks)

                };
            return CreateCommand("LogOnlineDataNew_Sp", parameters);
        }
        internal static SqlCommand GetPayNo(string type)
        {
            var parameters = new[]
            {
                CreateParameter("@type", SqlDbType.VarChar, type )                 
                              
            };
            return CreateCommand("GetPayNo_SP", parameters);
        }
        internal static SqlCommand GetSchrpt(string payno, DateTime frmdate, DateTime todate, string idno, double fromamt, double toamt, string usertype, Int32 pageindex, Int32 pagesize)
        {
            var parameters = new[]
                {                    
                    CreateParameter("@payno", SqlDbType.VarChar, payno),
                    CreateParameter("@frmdate", SqlDbType.DateTime, frmdate),
                    CreateParameter("@todate", SqlDbType.DateTime, todate),
                    CreateParameter("@regid", SqlDbType.VarChar, idno),
                    CreateParameter("@fromamt", SqlDbType.VarChar, fromamt),
                    CreateParameter("@toamt", SqlDbType.VarChar, toamt),
                    CreateParameter("@usertype", SqlDbType.VarChar, usertype),
                    CreateParameter("@pageindex", SqlDbType.Int, pageindex),                                       
                    CreateParameter("@pagesize", SqlDbType.Int, pagesize) 
                };
            return CreateCommand("Binaryrpt_SP", parameters);
        }
        internal static SqlCommand IneligibleRpt(string type, string val, DateTime frmdate, DateTime todate, string idno, string usertype, Int32 pageindex, Int32 pagesize)
        {
            var parameters = new[]
                {
                    CreateParameter("@type", SqlDbType.VarChar, type),
                    CreateParameter("@val", SqlDbType.VarChar, val),
                    CreateParameter("@frmdate", SqlDbType.DateTime, frmdate),
                    CreateParameter("@todate", SqlDbType.DateTime, todate),
                    CreateParameter("@idno", SqlDbType.VarChar, idno),
                    CreateParameter("@usertype", SqlDbType.VarChar, usertype),
                    CreateParameter("@pageindex", SqlDbType.Int, pageindex),                                       
                    CreateParameter("@pagesize", SqlDbType.Int, pagesize) 
                };
            return CreateCommand("IneligibleRpt_Sp", parameters);
        }
        internal static SqlCommand PayoutReports_Member(string action, Int32 regid, string payno, Int32 pageIndex, Int32 pageSize)
        {
            var parameters = new[]
            {
                CreateParameter("@action", SqlDbType.VarChar, action),
                CreateParameter("@regid", SqlDbType.BigInt, regid),
                CreateParameter("@payno", SqlDbType.VarChar, payno),
                CreateParameter("@pageIndex", SqlDbType.Int, pageIndex),
                CreateParameter("@pageSize", SqlDbType.Int, pageSize)
            };
            return CreateCommand("PayoutReports_Member_Sp", parameters);
        }
        internal static SqlCommand SCOnlineInsert(string action, Int32 regid, string amount, string mobile, string ORDER_ID, string PaymentStatus, string BillStatus, string TXNID, string BillNo, string pgtype, string shpcharge, string scmemtype,string coupon)
        {
            var parameters = new[]
            {
                CreateParameter("@action", SqlDbType.VarChar, action) ,
                CreateParameter("@regid", SqlDbType.BigInt, regid),
                CreateParameter("@amount", SqlDbType.Money, Convert.ToDouble(amount)),
                CreateParameter("@mobile", SqlDbType.VarChar, mobile) ,
                CreateParameter("@ORDER_ID", SqlDbType.VarChar, ORDER_ID) ,
                CreateParameter("@PaymentStatus", SqlDbType.VarChar, PaymentStatus) ,
                CreateParameter("@BillStatus", SqlDbType.VarChar, BillStatus) ,
                CreateParameter("@TXNID", SqlDbType.VarChar, TXNID), 
                CreateParameter("@BillNo", SqlDbType.VarChar, BillNo),
                CreateParameter("@pgtype", SqlDbType.VarChar, pgtype),
                CreateParameter("@shpcharge", SqlDbType.Money, Convert.ToDouble(shpcharge)),
                CreateParameter("@scmemtype", SqlDbType.VarChar, scmemtype),
                CreateParameter("@coupon", SqlDbType.VarChar, coupon ?? "")
            };
            return CreateCommand("SCOnlineInsert_Sp", parameters);
        }
        internal static SqlCommand GetSCOnline(string ORDERID)
        {
            var parameters = new[]
               {    
                    CreateParameter("@ORDERID", SqlDbType.VarChar, ORDERID)
                };
            return CreateCommand("GetSCOnline_SP", parameters);
        }
        internal static SqlCommand LogOnlineDataEBSNew(string ResponseCode, string ResponseMessage, string DateCreated, string PaymentID, string MerchantRefNo, string Amount,
            string Mode, string BillingName, string BillingAddress, string BillingCity, string BillingState, string BillingPostalCode, string BillingCountry,
            string BillingPhone, string BillingEmail, string DeliveryName, string DeliveryAddress, string DeliveryCity, string DeliveryState, string DeliveryPostalCode,
            string DeliveryCountry, string DeliveryPhone, string Description, string IsFlagged, string TransactionID, string PaymentMethod, string RequestID,
            string SecureHash, string remarks)
        {
            var parameters = new[]
               {    
                 CreateParameter("@ResponseCode", SqlDbType.VarChar, ResponseCode),
                CreateParameter("@ResponseMessage", SqlDbType.VarChar, ResponseMessage),
                CreateParameter("@DateCreated", SqlDbType.VarChar, DateCreated),
                CreateParameter("@PaymentID", SqlDbType.VarChar, PaymentID),
                CreateParameter("@MerchantRefNo", SqlDbType.VarChar, MerchantRefNo),
                CreateParameter("@Amount", SqlDbType.VarChar, Amount),
                CreateParameter("@Mode", SqlDbType.VarChar, Mode),
                CreateParameter("@BillingName", SqlDbType.VarChar, BillingName),
                CreateParameter("@BillingAddress", SqlDbType.VarChar, BillingAddress),
                CreateParameter("@BillingCity", SqlDbType.VarChar, BillingCity),
                CreateParameter("@BillingState", SqlDbType.VarChar, BillingState),
                CreateParameter("@BillingPostalCode", SqlDbType.VarChar, BillingPostalCode),
                CreateParameter("@BillingCountry", SqlDbType.VarChar, BillingCountry),
                CreateParameter("@BillingPhone", SqlDbType.VarChar, BillingPhone),
                CreateParameter("@BillingEmail", SqlDbType.VarChar, BillingEmail),
                CreateParameter("@DeliveryName", SqlDbType.VarChar, DeliveryName),
                CreateParameter("@DeliveryAddress", SqlDbType.VarChar, DeliveryAddress),
                CreateParameter("@DeliveryCity", SqlDbType.VarChar, DeliveryCity),
                CreateParameter("@DeliveryState", SqlDbType.VarChar, DeliveryState),
                CreateParameter("@DeliveryPostalCode", SqlDbType.VarChar, DeliveryPostalCode),
                CreateParameter("@DeliveryCountry", SqlDbType.VarChar, DeliveryCountry),
                CreateParameter("@DeliveryPhone", SqlDbType.VarChar, DeliveryPhone),
                CreateParameter("@Description", SqlDbType.VarChar, Description),
                CreateParameter("@IsFlagged", SqlDbType.VarChar, IsFlagged),
                CreateParameter("@TransactionID", SqlDbType.VarChar, TransactionID),
                CreateParameter("@PaymentMethod", SqlDbType.VarChar, PaymentMethod),
                CreateParameter("@RequestID", SqlDbType.VarChar, RequestID),
                CreateParameter("@SecureHash", SqlDbType.VarChar, SecureHash),
                CreateParameter("@remarks", SqlDbType.VarChar, remarks)

                };
            return CreateCommand("LogOnlineDataEBSNew_Sp", parameters);
        }

        internal static SqlCommand CreditRequestOnlineInsert(string action, Int32 regid, double reqAmt, string mop, string refno,
                                                     DateTime invdate, string invbank, string invbranch, string depbank,
                                                     string depbranch, string depcity, DateTime depdate, string depslip,
                                                     string remarks, string ORDER_ID, string PaymentStatus, string BillStatus, string TXNID, string Recode, string pgtype)
        {
            var parameters = new[]
            {
                CreateParameter("@action", SqlDbType.VarChar, action) ,
                CreateParameter("@regid", SqlDbType.BigInt, regid),
                CreateParameter("@reqAmt", SqlDbType.Money, reqAmt),
                CreateParameter("@mop", SqlDbType.VarChar, mop) ,
                CreateParameter("@refno", SqlDbType.VarChar, refno) ,
                CreateParameter("@invdate", SqlDbType.DateTime, invdate) ,
                CreateParameter("@invbank", SqlDbType.VarChar, invbank) ,
                CreateParameter("@invbranch", SqlDbType.VarChar, invbranch) ,
                CreateParameter("@depbank", SqlDbType.VarChar, depbank) ,
                CreateParameter("@depbranch", SqlDbType.VarChar, depbranch) ,
                CreateParameter("@depcity", SqlDbType.VarChar, depcity) ,
                CreateParameter("@depdate", SqlDbType.DateTime, depdate) ,
                CreateParameter("@depslip", SqlDbType.VarChar, depslip) ,
                CreateParameter("@remarks", SqlDbType.VarChar, remarks) ,
                CreateParameter("@ORDER_ID", SqlDbType.VarChar, ORDER_ID) ,
                CreateParameter("@PaymentStatus", SqlDbType.VarChar, PaymentStatus) ,
                CreateParameter("@BillStatus", SqlDbType.VarChar, BillStatus) ,
                CreateParameter("@TXNID", SqlDbType.VarChar, TXNID) ,
                CreateParameter("@Recode", SqlDbType.VarChar, Recode) ,
                CreateParameter("@pgtype", SqlDbType.VarChar, pgtype)
            };
            return CreateCommand("CreditRequestOnlineInsert_Sp", parameters);
        }

        internal static SqlCommand LogResponse(string merrefno, string responsevalues)
        {
            var parameters = new[]
               {    
                 CreateParameter("@merrefno", SqlDbType.VarChar, merrefno),
                 CreateParameter("@responsevalues", SqlDbType.VarChar, responsevalues)
                };
            return CreateCommand("LogResponse_Sp", parameters);
        }
        internal static SqlCommand GetCreditRequestOnline(string ORDERID)
        {
            var parameters = new[]
               {    
                    CreateParameter("@ORDERID", SqlDbType.VarChar, ORDERID)
                };
            return CreateCommand("GetCreditRequestOnline_SP", parameters);
        }

        internal static SqlCommand GVDPurchaseOnlineInsert(string action, int regid, string ddrefno, DateTime Refdddate, string refddbank, string ddrefbranch, string reftype,
            int Pid, int BV, string fullitemcode, string sesid, string fname, string lname, string address, string mobile, string city, string district,
            string states, int pin, string ORDER_ID, string PaymentStatus, string BillStatus, string TXNID, string CUST_ID, string TXN_AMOUNT, string pgtype, string billno)
        {
            var parameters = new[]
            {
                CreateParameter("@action", SqlDbType.VarChar, action) ,
                CreateParameter("@regid", SqlDbType.BigInt, regid) ,
                CreateParameter("@ddrefno", SqlDbType.VarChar, ddrefno) ,
                CreateParameter("@Refdddate", SqlDbType.DateTime, Refdddate) ,
                CreateParameter("@refddbank", SqlDbType.VarChar, refddbank) ,
                CreateParameter("@ddrefbranch", SqlDbType.VarChar, ddrefbranch) ,
                CreateParameter("@reftype", SqlDbType.VarChar, reftype) ,
                CreateParameter("@Pid", SqlDbType.Int, Pid) ,
                CreateParameter("@BV", SqlDbType.Int, BV) ,
                CreateParameter("@fullitemcode", SqlDbType.VarChar, fullitemcode) ,
                CreateParameter("@sesid", SqlDbType.VarChar, sesid) ,
                CreateParameter("@fname", SqlDbType.VarChar, fname) ,
                CreateParameter("@lname", SqlDbType.VarChar, lname) ,
                CreateParameter("@address", SqlDbType.VarChar, address) ,
                CreateParameter("@mobile", SqlDbType.VarChar, mobile) ,
                CreateParameter("@city", SqlDbType.VarChar, city) ,
                CreateParameter("@district", SqlDbType.VarChar, district) ,
                CreateParameter("@states", SqlDbType.VarChar, states) ,
                CreateParameter("@pin", SqlDbType.BigInt, pin) ,
                CreateParameter("@ORDER_ID", SqlDbType.VarChar, ORDER_ID) ,
                CreateParameter("@PaymentStatus", SqlDbType.VarChar, PaymentStatus) ,
                CreateParameter("@BillStatus", SqlDbType.VarChar, BillStatus) ,
                CreateParameter("@TXNID", SqlDbType.VarChar, TXNID) ,
                CreateParameter("@CUST_ID", SqlDbType.VarChar, CUST_ID) ,
                CreateParameter("@TXN_AMOUNT", SqlDbType.Money, Convert.ToDouble(TXN_AMOUNT)),
                CreateParameter("@pgtype", SqlDbType.VarChar, pgtype),
                CreateParameter("@billno", SqlDbType.VarChar, billno)
            };
            return CreateCommand("GVDPurchaseOnlineInsert_Sp", parameters);
        }
        internal static SqlCommand GetGVDPurchaseOnline(string ORDERID)
        {
            var parameters = new[]
               {    
                    CreateParameter("@ORDERID", SqlDbType.VarChar, ORDERID)
                };
            return CreateCommand("GetGVDPurchaseOnline_SP", parameters);
        }

        internal static SqlCommand UploadMemberIHO(String action, Int32 sno, Int32 regid, string ProofType, string IHOPhoto, Int32 apprej, string sesid, Int32 apprejby, string AppRejRemarks)
        {
            var parameters = new[]
            {
                CreateParameter("@action", SqlDbType.VarChar, action ),
                CreateParameter("@sno", SqlDbType.Int, sno ),
                CreateParameter("@regid", SqlDbType.BigInt, regid ),
                CreateParameter("@ProofType", SqlDbType.VarChar, ProofType ),
                CreateParameter("@IHOPhoto", SqlDbType.VarChar, IHOPhoto ),
                CreateParameter("@apprej", SqlDbType.Int, apprej ),
                CreateParameter("@sesid", SqlDbType.VarChar, sesid ),
                CreateParameter("@apprejby", SqlDbType.Int, apprejby ),
                CreateParameter("@AppRejRemarks", SqlDbType.VarChar, AppRejRemarks)
            };
            return CreateCommand("UploadMemberIHO_sp", parameters);
        }


        internal static SqlCommand RePurchageProductRpt(string action, string Category, string SubCategory, string SubCategoryone, Int32 pageIndex, Int32 pageSize)
        {
            var parameters = new[]
            {
                CreateParameter("@action", SqlDbType.VarChar, action),
                CreateParameter("@Category", SqlDbType.VarChar, Category),
                CreateParameter("@SubCategory", SqlDbType.VarChar, SubCategory),
                CreateParameter("@SubCategoryone", SqlDbType.VarChar, SubCategoryone),
                CreateParameter("@PageIndex", SqlDbType.Int, pageIndex),
                CreateParameter("@PageSize", SqlDbType.Int, pageSize)
            };
            return CreateCommand("RePurchageProductRpt_Sp", parameters);
        }

        //rk
        internal static SqlCommand CommEWalletRpt(Int32 regid, DateTime frmdate, DateTime todate, Int32 pageindex, Int32 pagesize)
        {
            var parameters = new[]
               {                       
                    CreateParameter("@regid", SqlDbType.Int, regid),  
                     CreateParameter("@frmdate", SqlDbType.DateTime, frmdate),                    
                    CreateParameter("@todate", SqlDbType.DateTime , todate),
                    CreateParameter("@pageindex", SqlDbType.Int, pageindex),                                       
                    CreateParameter("@pagesize", SqlDbType.Int, pagesize) 
                };
            return CreateCommand("CommEWalletRpt_sp", parameters);
        }
    }
}
