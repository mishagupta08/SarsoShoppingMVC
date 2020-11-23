using System;
using System.Collections.Generic;
using System.Data;
using System.Security.Cryptography;
using System.Web.Script.Serialization;
using Utilities;


// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "SARSOMService" in code, svc and config file together.

namespace SARSOMobileService
{


    public class SARSOMService : ISARSOMService
    {
        
        private ExecuteFunction obj = new ExecuteFunction();
        

        private T GetObject<T>(EncParam encData)
        {
            var decData = obj.Decrypt(encData.Info);
            AesManaged aes = new AesManaged();
            aes.Padding = PaddingMode.Zeros;
            var jss = new JavaScriptSerializer();
            T cInfo = jss.Deserialize<T>(decData);
            return cInfo;
        }

        public CredentialResult getLoginStatus(EncParam encInfo)
        {
            CredentialResult result = new CredentialResult();
            try
            {

                if (encInfo == null)
                {
                    result.MSG = "FAILED";
                    result.MESSAGE = "Provided information was not in a correct format.";
                    result.FNAME = "--";
                    result.VERSION = "--";

                }
                else
                {

                    var cInfo = GetObject<CredentialInfo>(encInfo);
                    DataSet ds = obj.LoginStatus(cInfo);
                    if (ds.Tables.Count == 0)
                    {
                        result.MSG = "FAILED";
                        result.MESSAGE = "No information found for " + cInfo.IDNO + ".";
                        result.FNAME = "--";
                        result.VERSION = "--";



                    }
                    else
                    {
                        if (ds.Tables[0].Rows.Count == 0)
                        {
                            result.MSG = "FAILED";
                            result.MESSAGE = "No information found for " + cInfo.IDNO + ". Kindly try after sometime";
                            result.FNAME = "--";
                            result.VERSION = "--";



                        }
                        else
                        {
                            if (ds.Tables[0].Rows[0]["Msg"].ToString() == "SUCCESS")
                            {
                                result.MSG = "SUCCESS";
                                result.MESSAGE = "SUCCESS";
                                result.FNAME = ds.Tables[0].Rows[0]["FullName"].ToString();
                                result.VERSION = ds.Tables[0].Rows[0]["VERSION"].ToString();
                                result.REGID = ds.Tables[0].Rows[0]["regid"].ToString();
                                result.MEMTYPE = ds.Tables[0].Rows[0]["Astatus"].ToString();
                                result.PAYTM = ds.Tables[0].Rows[0]["paytmsts"].ToString();
                                result.EBS = ds.Tables[0].Rows[0]["ebssts"].ToString();


                                if (ds.Tables[1].Rows.Count > 0)
                                {
                                    foreach (DataRow dr in ds.Tables[1].Rows)
                                    {
                                        DisplayImage objRet = new DisplayImage();
                                        objRet.IMAGE = dr["MBImage"].ToString();
                                        result.IMAGE.Add(objRet);
                                    }
                                }


                            }
                            else
                            {
                                result.MSG = "FAILED";
                                result.MESSAGE = ds.Tables[0].Rows[0]["Message"].ToString();
                                result.FNAME = "";
                                result.VERSION = "";
                            }


                        }
                    }
                }
            }
            catch (Exception ex)
            {
                result.MSG = "FAILED";
                result.MESSAGE = "Error occured" + ex.Message;
                result.FNAME = "--";
                result.VERSION = "--";



            }
            finally
            {
            }
            return result;
        }


        public DashboardSummary Dashboard(EncParam encInfo)
        {
            DashboardSummary result = new DashboardSummary();
            try
            {
                if (encInfo == null)
                {
                    result.MSG = "FAILED";
                    result.MESSAGE = "Provided information was not in a correct format.";
                }
                else
                {
                    var param = GetObject<MemberIDPWD>(encInfo);
                    DataTable dt = obj.getDashboardSummary(param);



                    if (dt.Rows.Count == 0)
                    {
                        result.MSG = "FAILED";
                        result.MESSAGE = "No information found for " + param.IDNO + ". Kindly try after sometime";
                    }
                    else
                    {
                        result.MSG = dt.Rows[0]["Msg"].ToString();
                        result.RANKSSMP = dt.Rows[0]["SSMPRank"].ToString();
                        result.RANKSICP = dt.Rows[0]["SICPRank"].ToString();
                        result.WALLETAMT = dt.Rows[0]["EwalletAmt"].ToString();
                        result.TOTALPAYOUTEARNED = dt.Rows[0]["PayoutEarn"].ToString();
                        result.PERSONALRECUITS = dt.Rows[0]["CustCount"].ToString();
                    }

                }
            }
            catch (Exception ex)
            {
                result.MSG = "FAILED";
                result.MESSAGE = "Server Error " + encInfo + " " + ex.Message + "-" + ex.StackTrace;
            }
            finally
            {
            }
            return result;
        }



        public DashboardSummary DashboardDemo(MemberIDPWD encInfo)
        {
            DashboardSummary result = new DashboardSummary();
            try
            {
                if (encInfo == null)
                {
                    result.MSG = "FAILED";
                    result.MESSAGE = "Provided information was not in a correct format.";
                }
                else
                {
                    var param = encInfo;
                    DataTable dt = obj.getDashboardSummary(param);



                    if (dt.Rows.Count == 0)
                    {
                        result.MSG = "FAILED";
                        result.MESSAGE = "No information found for " + param.IDNO + ". Kindly try after sometime";
                    }
                    else
                    {
                        result.MSG = dt.Rows[0]["Msg"].ToString();
                        result.RANKSSMP = dt.Rows[0]["SSMPRank"].ToString();
                        result.RANKSICP = dt.Rows[0]["SICPRank"].ToString();
                        result.WALLETAMT = dt.Rows[0]["EwalletAmt"].ToString();
                        result.TOTALPAYOUTEARNED = dt.Rows[0]["PayoutEarn"].ToString();
                        result.PERSONALRECUITS = dt.Rows[0]["CustCount"].ToString();
                    }

                }
            }
            catch (Exception ex)
            {
                result.MSG = "FAILED";
                result.MESSAGE = "Server Error";
            }
            finally
            {
            }
            return result;
        }

        public SSMPDetailsData GetSSMPDetails(EncParam encInfo)
        {
            SSMPDetailsData result = new SSMPDetailsData();
            try
            {
                if (encInfo == null)
                {
                    result.MSG = "FAILED";
                    result.MESSAGE = "Provided information was not in a correct format.";
                }
                else
                {
                    var param = GetObject<MemberIDPWD>(encInfo);
                    DataTable dt = obj.getDashboardSSMPDetails(param);



                    if (dt.Rows.Count == 0)
                    {
                        result.MSG = "FAILED";
                        result.MESSAGE = "No information found for " + param.IDNO + ". Kindly try after sometime";
                    }
                    else
                    {
                        result.MSG = dt.Rows[0]["Msg"].ToString();
                        result.BV = dt.Rows[0]["selfBV"].ToString();
                        result.TOTLEFTUNIQUEORDPLACEDTODAY = dt.Rows[0]["Lefttoday"].ToString();
                        result.TOTLEFTUNIQUEORDPLACEDCURSESSION = dt.Rows[0]["LeftWeek"].ToString();
                        result.TOTLEFTUNIQUEORDPLACEDTILLDATE = dt.Rows[0]["TotLeft"].ToString();
                        result.TOTRIGHTUNIQUEORDPLACEDTODAY = dt.Rows[0]["Righttoday"].ToString();
                        result.TOTRIGHTUNIQUEORDPLACEDCURSESSION = dt.Rows[0]["RightWeek"].ToString();
                        result.TOTRIGHTUNIQUEORDPLACEDTILLDATE = dt.Rows[0]["TotRight"].ToString();
                        result.TOTCLUSTERSALES = dt.Rows[0]["clustpos"].ToString();
                        result.POSINCURRCLUSTER = dt.Rows[0]["cluststage"].ToString();
                        result.TOTSSMPINCOME = dt.Rows[0]["SSMPIncRwd"].ToString();


                    }

                }
            }
            catch (Exception ex)
            {
                result.MSG = "FAILED";
                result.MESSAGE = "Server Error";
            }
            finally
            {
            }
            return result;
        }

        public List<SICPDetailsData> GetSICPDetails(EncParam encInfo)
        {
            List<SICPDetailsData> result = new List<SICPDetailsData>();
            try
            {
                if (encInfo == null)
                {

                }
                else
                {
                    var param = GetObject<MemberIDPWD>(encInfo);
                    DataTable dt = obj.getDashboardSICPDetails(param);
                    if (dt.Rows.Count > 0)
                    {
                        for (int iRow = 0; iRow < dt.Rows.Count; iRow++)
                        {
                            result.Add(new SICPDetailsData()
                            {

                                TEAMTYPE = dt.Rows[iRow]["teamtype"].ToString(),
                                TOTALGCV = dt.Rows[iRow]["totalGCV"].ToString(),
                                NAME = dt.Rows[iRow]["Name"].ToString(),
                                TOTSICPINC = dt.Rows[iRow]["TotSCIPInc"].ToString()

                            });
                        }
                    }




                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
            }
            return result;
        }
        public DesgIncomeDetailsData GetDesgIncomeDetails(EncParam encInfo)
        {
            DesgIncomeDetailsData result = new DesgIncomeDetailsData();
            try
            {
                if (encInfo == null)
                {
                    result.MSG = "FAILED";
                    result.MESSAGE = "Provided information was not in a correct format.";
                }
                else
                {
                    var param = GetObject<MemberIDPWD>(encInfo);
                    DataTable dt = obj.getDesgIncomeDetails(param);

                    if (dt.Rows.Count == 0)
                    {
                        result.MSG = "FAILED";
                        result.MESSAGE = "No Records Found";

                    }
                    else if (dt.Rows[0]["Msg"].ToString() == "SUCCESS")
                    {

                        result.MSG = "SUCCESS";
                        result.MESSAGE = dt.Rows[0]["Mesage"].ToString();
                        result.CURRMONTH = dt.Rows[0]["MonthYear"].ToString();
                        result.RANKNAME = dt.Rows[0]["SICPRank"].ToString();
                        result.RANKACHIEVEDDATE = dt.Rows[0]["achdate"].ToString();
                        result.RESIDUALBONUS = dt.Rows[0]["ResBouns"].ToString();
                        result.PERFOMANCEBONUS = dt.Rows[0]["PerfBouns"].ToString();
                        result.LEVERANGEBOUNS = dt.Rows[0]["LVBouns"].ToString();
                        result.OVERRIDINGBONUS = dt.Rows[0]["OverBouns"].ToString();
                        result.ARISTOFUNDS = dt.Rows[0]["ArisBouns"].ToString();
                        result.ROYALPERKS = dt.Rows[0]["RoyBouns"].ToString();
                        result.TOTAL = dt.Rows[0]["Total"].ToString();

                    }
                    else
                    {
                        result.MSG = "FAILED";
                        result.MESSAGE = "Invalid Details";

                    }

                }
            }
            catch (Exception ex)
            {
                result.MSG = "FAILED";
                result.MESSAGE = "Server Error";

            }
            finally
            {
            }
            return result;
        }

        public EwalletRptOutput EwalletRptData(EncParam encInfo)
        {
            EwalletRptOutput result = new EwalletRptOutput();
            try
            {
                if (encInfo.Info == null)
                {

                }
                else
                {
                    var param = GetObject<MemberIDPWD>(encInfo);
                    DataSet ds = obj.geteWalletRptData(param);

                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        if (ds.Tables[0].Rows[0]["Msg"].ToString() == "SUCCESS")
                        {
                            result.MSG = "SUCCESS";
                            result.TOTBALAMT = ds.Tables[0].Rows[0]["BalAmt"].ToString();


                            if (ds.Tables[1].Rows.Count > 0)
                            {
                                foreach (DataRow dr in ds.Tables[1].Rows)
                                {
                                    EwalletRpt objRet = new EwalletRpt();
                                    objRet.DATE = dr["Dated"].ToString();
                                    objRet.DESC = dr["Descr"].ToString();
                                    objRet.TRANTYPE = dr["TranType"].ToString();
                                    objRet.AMOUNT = dr["Amount"].ToString();
                                    result.EWALRPT.Add(objRet);
                                }
                            }

                        }
                        else
                        {
                            result.MSG = "FAILED";
                            result.MESSAGE = "Try Again";
                        }
                    }
                    else
                    {
                        result.MSG = "FAILED";
                        result.MESSAGE = "Try Again";
                    }

                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
            }
            return result;
        }


        public List<SponsorRpt> SponsorDetailsRpt(EncParam encInfo)
        {
            List<SponsorRpt> result = new List<SponsorRpt>();
            try
            {
                if (encInfo.Info == null)
                {

                }
                else
                {
                    var param = GetObject<MemberIDPWD>(encInfo);
                    DataTable dt = obj.getSponsorRptData(param);

                    if (dt.Rows.Count > 0)
                    {
                        for (int iRow = 0; iRow < dt.Rows.Count; iRow++)
                        {
                            result.Add(new SponsorRpt()
                            {

                                SBO = dt.Rows[iRow]["Idno"].ToString(),
                                NAME = dt.Rows[iRow]["name"].ToString(),
                                BV = dt.Rows[iRow]["BV"].ToString(),
                                AMOUNT = dt.Rows[iRow]["Amount"].ToString(),
                                STATUS = dt.Rows[iRow]["MemStatus"].ToString(),
                                DATE = dt.Rows[iRow]["JoinDate"].ToString()
                            });
                        }
                    }

                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
            }
            return result;
        }

        public List<SSMPGenealogyOutput> GetSSMPGenealogy(EncParam encInfo)
        {
            List<SSMPGenealogyOutput> result = new List<SSMPGenealogyOutput>();
            try
            {
                if (encInfo.Info == null)
                {

                }
                else
                {
                    var param = GetObject<TreeviewInput>(encInfo);
                    DataTable dt = obj.getSSMPTreeviewData(param);

                    if (dt.Rows.Count > 0)
                    {
                        for (int iRow = 0; iRow < dt.Rows.Count; iRow++)
                        {
                            result.Add(new SSMPGenealogyOutput()
                            {


                                IDNO = dt.Rows[iRow]["idno"].ToString(),
                                NAME = dt.Rows[iRow]["Name"].ToString(),
                                ASTATUS = dt.Rows[iRow]["Astatus"].ToString(),
                                POSITION = dt.Rows[iRow]["position"].ToString()


                            });
                        }
                    }

                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
            }
            return result;
        }

        public List<SICPGenealogyOutput> GetSICPGenealogy(EncParam encInfo)
        {
            List<SICPGenealogyOutput> result = new List<SICPGenealogyOutput>();
            try
            {
                if (encInfo.Info == null)
                {

                }
                else
                {
                    var param = GetObject<TreeviewInput>(encInfo);
                    DataTable dt = obj.getSICPTreeviewData(param);

                    if (dt.Rows.Count > 0)
                    {
                        for (int iRow = 0; iRow < dt.Rows.Count; iRow++)
                        {
                            result.Add(new SICPGenealogyOutput()
                            {


                                IDNO = dt.Rows[iRow]["idno"].ToString(),
                                NAME = dt.Rows[iRow]["Name"].ToString(),
                                ASTATUS = dt.Rows[iRow]["Astatus"].ToString()



                            });
                        }
                    }

                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
            }
            return result;
        }

        public List<SSMPGenealogyToolTip> GetSSMPGenealogyToolTip(EncParam encInfo)
        {
            List<SSMPGenealogyToolTip> result = new List<SSMPGenealogyToolTip>();
            try
            {
                if (encInfo.Info == null)
                {

                }
                else
                {
                    var param = GetObject<TreeviewInput>(encInfo);
                    DataTable dt = obj.getSSMPTreeviewToolTipData(param);

                    if (dt.Rows.Count > 0)
                    {
                        for (int iRow = 0; iRow < dt.Rows.Count; iRow++)
                        {
                            result.Add(new SSMPGenealogyToolTip()
                            {

                                IDNO = dt.Rows[iRow]["idno"].ToString(),
                                NAME = dt.Rows[iRow]["Name"].ToString(),
                                SPONSOR = dt.Rows[iRow]["Spr"].ToString(),
                                SPONSORNAME = dt.Rows[iRow]["sprname"].ToString(),
                                DOR = dt.Rows[iRow]["DOR"].ToString(),
                                STATUS = dt.Rows[iRow]["Astatus"].ToString(),
                                PAYMENTSTS = dt.Rows[iRow]["ApSts"].ToString(),
                                DESG = dt.Rows[iRow]["Designation"].ToString(),
                                SELFBV = dt.Rows[iRow]["CV"].ToString(),
                                GROUPBV = dt.Rows[iRow]["grpcv"].ToString(),
                                LEFTIDCNT = dt.Rows[iRow]["Ltotcnt"].ToString(),
                                RIGHTIDCNT = dt.Rows[iRow]["Rtotcnt"].ToString(),
                                ACTIVELEFTIDCNT = dt.Rows[iRow]["ALtotcnt"].ToString(),
                                ACTIVERIGHTIDCNT = dt.Rows[iRow]["ARtotcnt"].ToString(),
                                INACTIVELEFTIDCNT = dt.Rows[iRow]["InLtotcnt"].ToString(),
                                INACTIVERIGHTIDCNT = dt.Rows[iRow]["InRtotcnt"].ToString(),
                                LTCURSESSBV = dt.Rows[iRow]["LTCCBV"].ToString(),
                                RTCURSESSBV = dt.Rows[iRow]["RTCCBV"].ToString(),
                                CCLCNT = dt.Rows[iRow]["CCLCnt"].ToString(),
                                CCRCNT = dt.Rows[iRow]["CCRCnt"].ToString()


                            });
                        }
                    }

                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
            }
            return result;
        }

        public List<SICPGenealogyToolTip> GetSICPGenealogyToolTip(EncParam encInfo)
        {
            List<SICPGenealogyToolTip> result = new List<SICPGenealogyToolTip>();
            try
            {
                if (encInfo.Info == null)
                {

                }
                else
                {
                    var param = GetObject<TreeviewInput>(encInfo);
                    DataTable dt = obj.getSICPTreeviewToolTipData(param);

                    if (dt.Rows.Count > 0)
                    {
                        for (int iRow = 0; iRow < dt.Rows.Count; iRow++)
                        {
                            result.Add(new SICPGenealogyToolTip()
                            {

                                IDNO = dt.Rows[iRow]["idno"].ToString(),
                                NAME = dt.Rows[iRow]["Name"].ToString(),
                                SPONSOR = dt.Rows[iRow]["Spr"].ToString(),
                                SPONSORNAME = dt.Rows[iRow]["sprname"].ToString(),
                                DOR = dt.Rows[iRow]["DOR"].ToString(),
                                STATUS = dt.Rows[iRow]["Mstatus"].ToString(),
                                PAYMENTSTS = dt.Rows[iRow]["Astatus"].ToString(),
                                DESG = dt.Rows[iRow]["Designation"].ToString(),
                                SELFCV = dt.Rows[iRow]["SbV"].ToString(),
                                GROUPCV = dt.Rows[iRow]["Gbv"].ToString(),
                                ACTIVEIDCNT = dt.Rows[iRow]["Atotcnt"].ToString(),
                                INACTIVEIDCNT = dt.Rows[iRow]["InLotcnt"].ToString(),
                                CURSESSIDCNT = dt.Rows[iRow]["CCSIDcnt"].ToString(),
                                CURSESSCV = dt.Rows[iRow]["CCSCV"].ToString()


                            });
                        }
                    }

                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
            }
            return result;
        }

        public StandardResult AddNotification(EncParam encInfo)
        {
            StandardResult result = new StandardResult();

            if (encInfo == null)
            {
                result.MSG = "";
                result.MESSAGE = "";
            }
            else
            {
                try
                {
                    var param = GetObject<NotificationsParam>(encInfo);
                    string strResult = obj.getStatusAddNotification(param);

                    if (strResult.Trim().ToUpper().Contains("SUCCESS"))
                    {
                        result.MSG = "SUCCESS";
                        result.MESSAGE = "Successfully Updated";
                    }
                    else
                    {
                        result.MSG = "FAILED";
                        result.MESSAGE = strResult.Trim();
                    }

                }
                catch (Exception ex)
                {
                    string strException = ex.Message;
                    result.MSG = "";
                    result.MESSAGE = strException;
                }
            }
            return result;
        }

        public NotificationsResult RetrieveNotification(EncParam encInfo)
        {
            NotificationsResult result = new NotificationsResult();

            if (encInfo == null)
            {
                result.MSG = "FAILED";
                result.MESSAGE = "";
            }
            else
            {
                try
                {
                    var param = GetObject<MemberIDPWD>(encInfo);
                    DataSet ds = obj.getNotification(param);
                    if (ds.Tables.Count == 0)
                    {

                        result.MSG = "SUCCESS";
                        result.MESSAGE = "Sucessfully retrieved information.";
                        result.REGISTRATION = "NO";
                        result.EWALLTREQUEST = "NO";
                        result.FORGOTPWD = "NO";
                        result.COMPNYNOTIFY = "NO";

                    }
                    else
                    {
                        if (ds.Tables[0].Rows.Count == 0)
                        {
                            result.MSG = "SUCCESS";
                            result.MESSAGE = "Sucessfully retrieved information.";
                            result.REGISTRATION = "NO";
                            result.EWALLTREQUEST = "NO";
                            result.FORGOTPWD = "NO";
                            result.COMPNYNOTIFY = "NO";


                        }
                        else
                        {
                            for (int iRow = 0; iRow < ds.Tables[0].Rows.Count; iRow++)
                            {
                                result.MSG = "SUCCESS";
                                result.MESSAGE = "Sucessfully retrieved information.";
                                result.REGISTRATION = ds.Tables[0].Rows[iRow]["Registration"].ToString();
                                result.EWALLTREQUEST = ds.Tables[0].Rows[iRow]["EwalletReq"].ToString();
                                result.FORGOTPWD = ds.Tables[0].Rows[iRow]["ForgotPwd"].ToString();
                                result.COMPNYNOTIFY = ds.Tables[0].Rows[iRow]["CompnyNotify"].ToString();
                            }

                        }
                    }
                }
                catch (Exception ex)
                {
                    string strException = ex.Message;
                    result.MSG = "FAILED";
                    result.MESSAGE = strException;
                }
            }
            return result;
        }

        public CreditReqTransPwdResult CreditReqTranPwdCheck(EncParam encInfo)
        {
            CreditReqTransPwdResult result = new CreditReqTransPwdResult();
            try
            {
                if (encInfo == null)
                {
                    result.MSG = "FAILED";
                    result.MESSAGE = "Provided information was not in a correct format.";
                }
                else
                {
                    var param = GetObject<CreditReqTpwdInput>(encInfo);
                    DataTable dt = obj.EwalCreditReqTpwdChecking(param);

                    if (dt.Rows.Count == 0)
                    {
                        result.MSG = "FAILED";
                        result.MESSAGE = "No Records Found";

                    }
                    else if (dt.Rows[0]["Msg"].ToString() == "Success")
                    {

                        result.MSG = "SUCCESS";
                        result.MESSAGE = "SUCCESS";
                        result.WALLETAMT = dt.Rows[0]["EwalletAmt"].ToString();


                    }
                    else
                    {
                        result.MSG = "FAILED";
                        result.MESSAGE = dt.Rows[0]["Message"].ToString();

                    }

                }
            }
            catch (Exception ex)
            {
                result.MSG = "FAILED";
                result.MESSAGE = "Server Error";

            }
            finally
            {
            }
            return result;
        }

        public SICKRanksList GetSICKRanks(EncParam encInfo)
        {
            SICKRanksList result = new SICKRanksList();
            try
            {
                if (encInfo == null)
                {

                }
                else
                {
                    var param = GetObject<MemberIDPWD>(encInfo);

                    DataSet ds = obj.CheckSICPRanksList(param);

                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        foreach (DataRow dr in ds.Tables[0].Rows)
                        {
                            CheckurRankRpt objRet = new CheckurRankRpt();
                            objRet.RANK = dr["Rank"].ToString();
                            objRet.CRITIRIA = dr["criteria"].ToString();
                            objRet.ACCGCV = dr["ACCGCV"].ToString();
                            objRet.STATUS = dr["Rstatus"].ToString();
                            result.CHECKURRANK.Add(objRet);
                        }
                    }
                    if (ds.Tables[1].Rows.Count > 0)
                    {
                        foreach (DataRow dr in ds.Tables[1].Rows)
                        {
                            ElgRpt objRet = new ElgRpt();
                            objRet.SBOID = dr["SBOID"].ToString();
                            objRet.NAME = dr["Name"].ToString();
                            objRet.CRITIRIA = dr["criteria"].ToString();
                            objRet.ACCGCV = dr["ACCGCV"].ToString();
                            objRet.RANK = dr["Rank"].ToString();
                            objRet.RSTATUS = dr["Rstatus"].ToString();

                            result.ELIGIBILITYRPT.Add(objRet);
                        }
                    }



                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
            }
            return result;
        }

        public AttributesList GetProductAttributes(EncParam encInfo)
        {
            AttributesList result = new AttributesList();
            try
            {
                if (encInfo == null)
                {

                }
                else
                {
                    var param = GetObject<GetprodcutAttributesInput>(encInfo);

                    DataSet ds = obj.GetProductAttributes(param);

                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        foreach (DataRow dr in ds.Tables[0].Rows)
                        {
                            AttNamesRpt objRet = new AttNamesRpt();
                            objRet.NAME = dr["Attribute_Name"].ToString();
                            objRet.PCODE = dr["pcode"].ToString();
                            result.ATTRIBUTENAMES.Add(objRet);
                        }
                    }
                    if (ds.Tables[1].Rows.Count > 0)
                    {
                        foreach (DataRow dr in ds.Tables[1].Rows)
                        {
                            AttTypesRpt objRet = new AttTypesRpt();
                            objRet.NAME = dr["Attribute_Name"].ToString();
                            objRet.FIELD = dr["Field"].ToString();
                            objRet.PCODE = dr["pcode"].ToString();
                            result.ATTRIBUTETYPES.Add(objRet);
                        }
                    }



                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
            }
            return result;
        }

        public StandardResult GetForgetPassword(EncParam encInfo)
        {
            StandardResult result = new StandardResult();

            string Passwords = string.Empty;
            string MobileMsg = string.Empty;
            if (encInfo == null)
            {
                result.MSG = "";
                result.MESSAGE = "";
            }
            else
            {
                try
                {
                    var param = GetObject<MemberIDPWD>(encInfo);
                    DataSet ds = obj.GetUserDetails(param);

                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        if (ds.Tables[0].Rows[0]["Msg"].ToString() == "FAILED")
                        {
                            result.MSG = "FAILED";
                            result.MESSAGE = ds.Tables[0].Rows[0]["Message"].ToString();
                        }

                        else if (ds.Tables[0].Rows[0]["Msg"].ToString() == "Success")
                        {


                            Passwords = ds.Tables[0].Rows[0]["Lpassword"].ToString();
                            MobileMsg = "Welcome to SARSOBIZ, Your login Details are SBO ID";



                            var msg = "Welcome to SARSOBIZ, Your login Details are SBO ID " + ds.Tables[0].Rows[0]["idno"] + " and Password " + obj.Decryption(Passwords) + ".";

                            if (ds.Tables[0].Rows[0]["mobile"].ToString() != string.Empty && ds.Tables[0].Rows[0]["mobile"].ToString().Length <= 12)
                            {
                                if (ds.Tables[0].Rows[0]["mobile"].ToString().Length < 10)
                                {
                                    result.MSG = "FAILED";
                                    result.MESSAGE = "Your Mobile No not with us please contact administrator.";
                                }
                                else
                                {
                                    obj.insertsmslog(Convert.ToInt32(ds.Tables[0].Rows[0]["Regid"].ToString()), ds.Tables[0].Rows[0]["mobile"].ToString(), DateTime.Now, msg, "ForgotPassword", "Mobile APP", "Member");

                                    obj.SmsThroughGateWay(ds.Tables[0].Rows[0]["mobile"].ToString(), msg);

                                    result.MSG = "SUCCESS";
                                    result.MESSAGE = "Your Password sent sucessfully to your Registered Mobile No.";
                                    if (ds.Tables[0].Rows[0]["GcmID"].ToString().Length > 10 && ds.Tables[0].Rows[0]["GcmSts"].ToString() == "YES")
                                    {
                                        int f = obj.ShootNotification(ds.Tables[0].Rows[0]["GcmID"].ToString(), "Forgot Password", result.MESSAGE, "", "");
                                    }
                                }
                            }
                            else
                            {
                                result.MSG = "FAILED";
                                result.MESSAGE = "Your Mobile No not with us please contact administrator.";
                            }

                        }
                        else
                        {
                            result.MSG = "FAILED";
                            result.MESSAGE = "Incorrect User ID";

                        }
                    }
                    else
                    {
                        result.MSG = "FAILED";
                        result.MESSAGE = "Please enter a Valid User ID";
                    }

                }
                catch (Exception ex)
                {
                    string strException = ex.Message;
                    result.MSG = "FAILED";
                    result.MESSAGE = strException;
                }
            }
            return result;
        }

        public List<CategoriesList> GetCategories(EncParam encInfo)
        {
            List<CategoriesList> result = new List<CategoriesList>();
            try
            {
                if (encInfo.Info == null)
                {

                }
                else
                {
                    var param = GetObject<MemberIDPWD>(encInfo);
                    DataTable dt = obj.getProductCategories(param);

                    if (dt.Rows.Count > 0)
                    {
                        for (int iRow = 0; iRow < dt.Rows.Count; iRow++)
                        {
                            result.Add(new CategoriesList()
                            {
                                NAME = dt.Rows[iRow]["Category"].ToString()

                            });
                        }
                    }

                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
            }
            return result;
        }

        public List<CategoriesList> GetSubCategories(EncParam encInfo)
        {
            List<CategoriesList> result = new List<CategoriesList>();
            try
            {
                if (encInfo.Info == null)
                {

                }
                else
                {
                    var param = GetObject<SubCatInput>(encInfo);
                    DataTable dt = obj.getProductSubCategories(param);

                    if (dt.Rows.Count > 0)
                    {
                        for (int iRow = 0; iRow < dt.Rows.Count; iRow++)
                        {
                            result.Add(new CategoriesList()
                            {
                                NAME = dt.Rows[iRow]["Category"].ToString()
                            });
                        }
                    }

                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
            }
            return result;
        }

        public List<SubCategoriesOneList> GetSubCategoriesOne(EncParam encInfo)
        {
            List<SubCategoriesOneList> result = new List<SubCategoriesOneList>();
            try
            {
                if (encInfo.Info == null)
                {

                }
                else
                {
                    var param = GetObject<SubCatOneInput>(encInfo);
                    DataTable dt = obj.getProductSubCategoriesOne(param);
                    if (dt.Rows.Count > 0)
                    {
                        for (int iRow = 0; iRow < dt.Rows.Count; iRow++)
                        {
                            result.Add(new SubCategoriesOneList()
                            {
                                ID = dt.Rows[iRow]["RPCId"].ToString(),
                                NAME = dt.Rows[iRow]["SubCategoryone"].ToString()
                            });
                        }
                    }

                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
            }
            return result;
        }

        public SICPProductsOutput GetSICPProducts(EncParam encInfo)
        {
            SICPProductsOutput result = new SICPProductsOutput();
            try
            {
                if (encInfo.Info == null)
                {

                }
                else
                {
                    var param = GetObject<GetprodcutsInput>(encInfo);
                    DataSet ds = obj.getSICPProductsData(param);

                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        if (ds.Tables[0].Rows[0]["Msg"].ToString() == "SUCCESS")
                        {
                            result.MSG = "SUCCESS";
                            result.MESSAGE = "SUCCESS";
                            result.STATUS = ds.Tables[0].Rows[0]["Sts"].ToString();


                            if (ds.Tables[1].Rows.Count > 0)
                            {
                                foreach (DataRow dr in ds.Tables[1].Rows)
                                {
                                    ProductsList objRet = new ProductsList();
                                    objRet.PID = dr["RpPid"].ToString();
                                    objRet.PCODE = dr["PCode"].ToString();
                                    objRet.PNAME = dr["PName"].ToString();
                                    objRet.MRP = dr["Price"].ToString();
                                    objRet.OFFERPRICE = dr["offprice"].ToString();
                                    objRet.DISCPRICE = dr["DP"].ToString();
                                    objRet.CV = dr["PV"].ToString();
                                    objRet.SMALLIMG = dr["img"].ToString();
                                    objRet.MEDIUMIMG = dr["img"].ToString();
                                    objRet.BIGIMG = dr["images"].ToString();
                                    objRet.DESCR = dr["Descr"].ToString();
                                    objRet.SHIPPINGINFO = "We have delivery of our products all over India for our customers / distributors. There are no shipping charges for orders of Rs. 2500 or more (order amount as on invoice).";
                                    objRet.CATEGORY = dr["Category"].ToString();
                                    objRet.SUBCAT = dr["SubCategory"].ToString();
                                    objRet.SUBCATONE = dr["SubCategoryone"].ToString();
                                    result.PRODUCTSRPT.Add(objRet);
                                }
                            }

                        }
                        else
                        {
                            result.MSG = "FAILED";
                            result.MESSAGE = ds.Tables[0].Rows[0]["Message"].ToString();
                        }
                    }

                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
            }
            return result;
        }

        public List<BusinessSummaryList> BusinessSummaryRpt(EncParam encInfo)
        {
            List<BusinessSummaryList> result = new List<BusinessSummaryList>();
            try
            {
                if (encInfo.Info == null)
                {

                }
                else
                {
                    var param = GetObject<MemberIDPWD>(encInfo);
                    DataTable dt = obj.BusinessSummaryRpt(param);

                    if (dt.Rows.Count > 0)
                    {
                        for (int iRow = 0; iRow < dt.Rows.Count; iRow++)
                        {
                            result.Add(new BusinessSummaryList()
                            {
                                SICP = dt.Rows[iRow]["idno"].ToString(),
                                PREVIOUSBALANCE = dt.Rows[iRow]["PrvBV"].ToString(),
                                SELF = dt.Rows[iRow]["Selfbv"].ToString(),
                                DOWNLINE = dt.Rows[iRow]["Gbv"].ToString(),
                                TOTAL = dt.Rows[iRow]["TotalGBV"].ToString(),
                                TOTALBUSINESS = dt.Rows[iRow]["TotalBusinessBV"].ToString(),
                                IDTYPE = dt.Rows[iRow]["IdType"].ToString()
                            });
                        }
                    }

                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
            }
            return result;
        }

        public LoyaltyRankOutput LoyaltyRankRpt(EncParam encInfo)
        {
            LoyaltyRankOutput result = new LoyaltyRankOutput();
            try
            {
                if (encInfo == null)
                {
                    result.MSG = "FAILED";
                    result.MESSAGE = "Provided information was not in a correct format.";
                }
                else
                {
                    var param = GetObject<LoyaltyReportInput>(encInfo);
                    DataSet ds = obj.GetLoyalryReport(param);
                    if (ds.Tables.Count == 0)
                    {
                        result.MSG = "FAILED";
                        result.MESSAGE = "No information found for " + param.IDNO + ".";
                    }
                    else
                    {

                        if (ds.Tables[0].Rows.Count == 0)
                        {
                            result.MSG = "FAILED";
                            result.MESSAGE = "No information found for " + param.IDNO;
                        }

                        else if (Int32.Parse(ds.Tables[0].Rows[0]["Desgno"].ToString()) < 6)
                        {
                            result.MSG = "FAILED";
                            result.MESSAGE = "you are not Eligible for any Loyal Rank";
                        }
                        else
                        {
                            result.MSG = "SUCCESS";
                            result.MESSAGE = "SUCCESS";
                            result.RANK = ds.Tables[0].Rows[0]["DesgName"].ToString();
                            result.STATUS = ds.Tables[0].Rows[0]["RankStatus"].ToString();
                            result.CRITIRIA = ds.Tables[0].Rows[0]["Cstatus"].ToString();
                            result.CURRACCGCV = ds.Tables[0].Rows[0]["GroupCV"].ToString();
                            result.CURREXCLGCV = ds.Tables[0].Rows[0]["ConsideredCV"].ToString();



                            if (ds.Tables[1].Rows.Count > 0)
                            {
                                foreach (DataRow dr in ds.Tables[1].Rows)
                                {
                                    DownlineRpt objRet = new DownlineRpt();
                                    objRet.IDNO = dr["idno"].ToString();
                                    objRet.NAME = dr["Name"].ToString();
                                    objRet.RANK = dr["DesgName"].ToString();
                                    objRet.CURRACCGCV = dr["GroupCV"].ToString();
                                    objRet.CURREXCLGCV = dr["ConsideredCV"].ToString();
                                    result.DOWNLINEIDS.Add(objRet);
                                }
                            }

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                result.MSG = "FAILED";
                result.MESSAGE = "Server Error";
            }
            finally
            {
            }
            return result;
        }

        public List<ClickandShareList> GetClickandShareData(EncParam encInfo)
        {
            List<ClickandShareList> result = new List<ClickandShareList>();
            try
            {
                if (encInfo == null)
                {

                }
                else
                {

                    var param = GetObject<MemberIDPWD>(encInfo);

                    DataSet ds = obj.GetClickandShareList(param);

                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        for (int iRow = 0; iRow < ds.Tables[0].Rows.Count; iRow++)
                        {
                            result.Add(new ClickandShareList()
                            {
                                SHAREDATA = ds.Tables[0].Rows[iRow]["Description"].ToString(),
                                IMG = ds.Tables[0].Rows[iRow]["img"].ToString()
                            });
                        }
                    }

                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
            }
            return result;
        }

        public AddDeleteproductOutPut AddDelUpdateProductToCart(EncParam encInfo)
        {
            AddDeleteproductOutPut result = new AddDeleteproductOutPut();
            try
            {
                if (encInfo == null)
                {
                    result.MSG = "FAILED";
                    result.MESSAGE = "Provided information was not in a correct format.";
                }
                else
                {
                    var param = GetObject<AddDeleteproductInPut>(encInfo);
                    DataSet ds = obj.AddDeleteProductsCart(param);


                    if (ds.Tables.Count == 0)
                    {
                        result.MSG = "FAILED";
                        result.MESSAGE = "No information found for " + param.IDNO + ".";
                    }
                    else
                    {

                        if (ds.Tables[0].Rows.Count == 0)
                        {
                            result.MSG = "FAILED";
                            result.MESSAGE = "No information found for " + param.IDNO;
                        }
                        else if (ds.Tables[0].Rows[0]["result"].ToString() == "SUCCESS")
                        {
                            result.MSG = "SUCCESS";
                            result.MESSAGE = "SUCCESS";

                            if (ds.Tables[1].Rows.Count > 0)
                            {
                                foreach (DataRow dr in ds.Tables[1].Rows)
                                {
                                    ItemsRpt objRet = new ItemsRpt();
                                    objRet.PCODE = dr["pcode"].ToString();
                                    objRet.PNAME = dr["PName"].ToString();
                                    objRet.PV = dr["pv"].ToString();
                                    objRet.MRP = dr["MRP"].ToString();
                                    objRet.PRICE = dr["price"].ToString();
                                    objRet.DP = dr["DP"].ToString();
                                    objRet.DISCOUNT = dr["Discount"].ToString();
                                    objRet.QTY = dr["qty"].ToString();
                                    objRet.ITEMCODE = dr["itemcode"].ToString();
                                    objRet.ATTRIBUTE = dr["Attribute"].ToString();
                                    objRet.IMG = dr["pcode"].ToString() + ".png";
                                    result.CARTPRODUCTS.Add(objRet);
                                }
                            }

                        }
                        else
                        {
                            result.MSG = "FAILED";
                            result.MESSAGE = ds.Tables[0].Rows[0]["result"].ToString();

                        }
                    }


                }
            }
            catch (Exception ex)
            {
                result.MSG = "FAILED";
                result.MESSAGE = "Server Error";

            }
            finally
            {
            }
            return result;
        }

        public ItemCodeOutput GetItemCode(EncParam encInfo)
        {
            ItemCodeOutput result = new ItemCodeOutput();
            try
            {
                if (encInfo == null)
                {
                    result.MSG = "FAILED";
                    result.MESSAGE = "Provided information was not in a correct format.";
                }
                else
                {
                    var param = GetObject<ItemCodeInput>(encInfo);
                    DataTable dt = obj.GetItemCodeResult(param);

                    if (dt.Rows.Count == 0)
                    {
                        result.MSG = "FAILED";
                        result.MESSAGE = "No Data";

                    }
                    else if (dt.Rows[0]["Msg"].ToString() == "SUCCESS")
                    {

                        result.MSG = "SUCCESS";
                        result.MESSAGE = "SUCCESS";
                        result.ITEMCODE = dt.Rows[0]["Itemcode"].ToString();
                    }
                    else
                    {
                        result.MSG = "FAILED";
                        result.MESSAGE = dt.Rows[0]["Msg"].ToString();

                    }

                }
            }
            catch (Exception ex)
            {
                result.MSG = "FAILED";
                result.MESSAGE = "Server Error";

            }
            finally
            {
            }
            return result;
        }

        public ShippingInfoOutput GetShippingInfo(EncParam encInfo)
        {
            ShippingInfoOutput result = new ShippingInfoOutput();
            try
            {

                if (encInfo == null)
                {
                    result.MSG = "FAILED";
                    result.MESSAGE = "Provided information was not in a correct format.";



                }
                else
                {

                    var cInfo = GetObject<ShippingInfoInput>(encInfo);
                    DataSet ds = obj.getShippingInfo(cInfo);
                    if (ds.Tables.Count == 0)
                    {
                        result.MSG = "FAILED";
                        result.MESSAGE = "No information found for " + cInfo.IDNO + ".";





                    }
                    else
                    {
                        if (ds.Tables[0].Rows.Count == 0)
                        {
                            result.MSG = "FAILED";
                            result.MESSAGE = "No information found for " + cInfo.IDNO + ". Kindly try after sometime";
                        }
                        else
                        {
                            result.MSG = "SUCCESS";
                            result.MESSAGE = "SUCCESS";
                            result.FNAME = ds.Tables[0].Rows[0]["fName"].ToString();
                            result.LNAME = ds.Tables[0].Rows[0]["lname"].ToString();
                            result.MOBILENO = ds.Tables[0].Rows[0]["Mobile"].ToString();
                            result.ADDRESS = ds.Tables[0].Rows[0]["Add1"].ToString();

                            result.CITY = ds.Tables[0].Rows[0]["City"].ToString();
                            result.DISTRICT = ds.Tables[0].Rows[0]["District"].ToString();
                            result.STATE = ds.Tables[0].Rows[0]["state"].ToString();
                            result.PINCODE = ds.Tables[0].Rows[0]["Pin"].ToString();
                            result.EWABAL = ds.Tables[0].Rows[0]["EwalletBalance"].ToString();


                            if (ds.Tables[1].Rows.Count > 0)
                            {
                                foreach (DataRow dr in ds.Tables[1].Rows)
                                {
                                    StatesRpt objRet = new StatesRpt();
                                    objRet.STATEID = dr["StateID"].ToString();
                                    objRet.SNAME = dr["StateName"].ToString();
                                    result.STATES.Add(objRet);
                                }
                            }





                        }
                    }
                }
            }
            catch (Exception ex)
            {
                result.MSG = "FAILED";
                result.MESSAGE = "Error occured" + ex.Message;
                result.FNAME = "--";




            }
            finally
            {
            }
            return result;
        }

        public OrderSubTotalsInfo CheckOrderTransPwd(EncParam encInfo)
        {
            OrderSubTotalsInfo result = new OrderSubTotalsInfo();
            try
            {

                if (encInfo == null)
                {
                    result.MSG = "FAILED";
                    result.MESSAGE = "Provided information was not in a correct format.";



                }
                else
                {

                    var cInfo = GetObject<OrderInfoTotalsInput>(encInfo);
                    DataSet ds = obj.getOrderInfoTotals(cInfo);
                    if (ds.Tables.Count == 0)
                    {
                        result.MSG = "FAILED";
                        result.MESSAGE = "No information found for " + cInfo.IDNO + ".";





                    }
                    else
                    {
                        if (ds.Tables[0].Rows.Count == 0)
                        {
                            result.MSG = "FAILED";
                            result.MESSAGE = "No information found for " + cInfo.IDNO + ". Kindly try after sometime";
                        }
                        else if (ds.Tables[0].Rows[0]["Msg"].ToString() == "SUCCESS")
                        {
                            result.MSG = "SUCCESS";
                            result.MESSAGE = "Your Order Successfully Generated.";
                            result.TOTQTY = ds.Tables[0].Rows[0]["TotalQty"].ToString();
                            result.TOTCV = ds.Tables[0].Rows[0]["TotalCV"].ToString();
                            result.SUBTOTAL = ds.Tables[0].Rows[0]["SubTotal"].ToString();
                            result.DISCOUNTPRICE = ds.Tables[0].Rows[0]["DiscountAmount"].ToString();
                            result.PAYBLEAMT = ds.Tables[0].Rows[0]["PaybleAmount"].ToString();
                            result.SHIPCHRGS = ds.Tables[0].Rows[0]["ShipCharg"].ToString();
                            result.GRANDTOTAL = ds.Tables[0].Rows[0]["GrandTotal"].ToString();
                        }
                        else
                        {
                            result.MSG = "FAILED";
                            result.MESSAGE = ds.Tables[0].Rows[0]["Message"].ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                result.MSG = "FAILED";
                result.MESSAGE = "Error occured" + ex.Message;





            }
            finally
            {
            }
            return result;
        }

        public OrderOutputResult FinalOrder(EncParam encInfo)
        {
            OrderOutputResult result = new OrderOutputResult();
            try
            {

                if (encInfo == null)
                {
                    result.MSG = "FAILED";
                    result.MESSAGE = "Provided information was not in a correct format.";
                    
                }
                else
                {

                    var cInfo = GetObject<FinalOrderInPut>(encInfo);
                    DataSet ds = obj.PostFinalOrder(cInfo);
                    if (ds.Tables.Count == 0)
                    {
                        result.MSG = "FAILED";
                        result.MESSAGE = "No information found for " + cInfo.IDNO + ".";

                    }
                    else
                    {
                        if (ds.Tables[0].Rows.Count == 0)
                        {
                            result.MSG = "FAILED";
                            result.MESSAGE = "No information found for " + cInfo.IDNO + ". Kindly try after sometime";
                        }
                        else if (ds.Tables[0].Rows[0]["res"].ToString() == "SUCCESS")
                        {
                            result.MSG = "SUCCESS";
                            result.MESSAGE = "Your Order Successfully Generated.";
                            result.BILLNO = ds.Tables[0].Rows[0]["billno"].ToString();
                            result.REQNO = ds.Tables[0].Rows[0]["reqno"].ToString();

                        }
                        else
                        {
                            result.MSG = "FAILED";
                            result.MESSAGE = ds.Tables[0].Rows[0]["res"].ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                result.MSG = "FAILED";
                result.MESSAGE = "Error occured" + ex.Message;
            }
            finally
            {
            }
            return result;
        }
        public SCMOnlineResponse SCMOnlineResquest(EncParam encInfo)
        {
            SCMOnlineResponse result = new SCMOnlineResponse();
            try
            {

                if (encInfo == null)
                {
                    result.MSG = "FAILED";
                    result.MESSAGE = "Provided information was not in a correct format.";

                }
                else
                {

                    var cInfo = GetObject<SCMPOnline>(encInfo);
                    DataSet ds = obj.ScmOnlineRequest(cInfo);
                    if (ds.Tables.Count == 0)
                    {
                        result.MSG = "FAILED";
                        result.MESSAGE = "No information found for " + cInfo.ORDER_ID + ".";

                    }
                    else
                    {
                        result.MSG = "SUCCESS";
                        result.MESSAGE = "Request Inserted successfuly";
                    }
                }
            }
            catch (Exception ex)
            {
                result.MSG = "FAILED";
                result.MESSAGE = "Error occured" + ex.Message;
            }
            finally
            {
            }
            return result;
        }
        public TempOrderResponse TempOrderRequest(EncParam encInfo)
        {
            TempOrderResponse result = new TempOrderResponse();
            try
            {

                if (encInfo == null)
                {
                    result.MSG = "FAILED";
                    result.MESSAGE = "Provided information was not in a correct format.";

                }
                else
                {

                    var cInfo = GetObject<TempOrderRequest>(encInfo);
                    DataSet ds = obj.TempOrder(cInfo);
                    if (ds.Tables.Count == 0)
                    {
                        result.MSG = "FAILED";
                        result.MESSAGE = "No information found for " + cInfo.UNQId + ".";

                    }
                    else
                    {
                        result.MSG = "SUCCESS";
                        result.MESSAGE = "Request Inserted successfuly for " + cInfo.UNQId + "."; ;
                    }
                }
            }
            catch (Exception ex)
            {
                result.MSG = "FAILED";
                result.MESSAGE = "Error occured" + ex.Message;
            }
            finally
            {
            }
            return result;
        }
        public TempOrderResponse ResponseOrderRequest()
        {
            TempOrderResponse result = new TempOrderResponse();
            try
            {

                //if (encInfo == null)
                //{
                //    result.MSG = "FAILED";
                //    result.MESSAGE = "Provided information was not in a correct format.";

                //}
                //else
                //{

                //    var cInfo = GetObject<TempOrderRequest>(encInfo);
                //    DataSet ds = obj.TempOrder(cInfo);
                //    if (ds.Tables.Count == 0)
                //    {
                //        result.MSG = "FAILED";
                //        result.MESSAGE = "No information found for " + cInfo.UNQId + ".";

                //    }
                //    else
                //    {
                //        result.MSG = "SUCCESS";
                //        result.MESSAGE = "Request Inserted successfuly for " + cInfo.UNQId + "."; ;
                //    }
                //}
                result.MSG = "SUCCESS";
                result.MESSAGE = "Request Inserted successfuly for";
            }
            catch (Exception ex)
            {
                result.MSG = "FAILED";
                result.MESSAGE = "Error occured" + ex.Message;
            }
            finally
            {
            }
            return result;
        }

        public StandardResult CheckRegSponsor(EncParam encInfo)
        {
            StandardResult result = new StandardResult();
            try
            {
                if (encInfo == null)
                {
                    result.MSG = "FAILED";
                    result.MESSAGE = "Provided information was not in a correct format.";
                }
                else
                {
                    var param = GetObject<RegSponsorInput>(encInfo);
                    DataTable dt = obj.RegSponsorChecking(param);

                    if (dt.Rows.Count == 0)
                    {
                        result.MSG = "FAILED";
                        result.MESSAGE = "No Data";

                    }
                    else if (dt.Rows[0]["Msg"].ToString() == "Exist")
                    {
                        result.MSG = "SUCCESS";
                        result.MESSAGE = dt.Rows[0]["Name"].ToString();
                    }
                    else
                    {
                        result.MSG = "FAILED";
                        result.MESSAGE = dt.Rows[0]["Msg"].ToString();

                    }

                }
            }
            catch (Exception ex)
            {
                result.MSG = "FAILED";
                result.MESSAGE = ex.Message;

            }
            finally
            {
            }
            return result;
        }
        public StandardResult CheckRegSponsorFormNo(EncParam encInfo)
        {
            StandardResult result = new StandardResult();
            try
            {
                if (encInfo == null)
                {
                    result.MSG = "FAILED";
                    result.MESSAGE = "Provided information was not in a correct format.";
                }
                else
                {
                    var param = GetObject<RegSponsor>(encInfo);
                    DataTable dt = obj.RegSponsorCheck(param);

                    if (dt.Rows.Count == 0)
                    {
                        result.MSG = "FAILED";
                        result.MESSAGE = "No Data";

                    }
                    else if (dt.Rows[0]["Msg"].ToString() == "Exist")
                    {
                        result.MSG = "SUCCESS";
                        result.MESSAGE = dt.Rows[0]["Name"].ToString();
                    }
                    else
                    {
                        result.MSG = "FAILED";
                        result.MESSAGE = dt.Rows[0]["Msg"].ToString();

                    }

                }
            }
            catch (Exception ex)
            {
                result.MSG = "FAILED";
                result.MESSAGE = ex.Message;

            }
            finally
            {
            }
            return result;
        }

        public StandardResult NewRegostration(EncParam encInfo)
        {
            //UtilitiesClient objutlit = new UtilitiesClient();
            StandardResult result = new StandardResult();
            try
            {
                if (encInfo == null)
                {
                    result.MSG = "FAILED";
                    result.MESSAGE = "Provided information was not in a correct format.";
                }
                else
                {
                    var param = GetObject<RegInput>(encInfo);
                    DataTable dt = obj.Registration(param);
                    //param.LPWD = objutlit.Encrypt(param.LPWD);
                    //param.TPWD = objutlit.Encrypt(param.TPWD);
                    if (dt.Rows.Count == 0)
                    {
                        result.MSG = "FAILED";
                        result.MESSAGE = "No Data";

                    }
                    else if (dt.Rows[0]["res"].ToString() == "SUCCESS")
                    {
                        result.MSG = "SUCCESS";
                        result.MESSAGE = dt.Rows[0]["idno"].ToString();
                    }
                    else
                    {
                        result.MSG = "FAILED";
                        result.MESSAGE = dt.Rows[0]["res"].ToString();
                    }

                }
            }
            catch (Exception ex)
            {
                result.MSG = "FAILED";
                result.MESSAGE = ex.Message;

            }
            finally
            {
            }
            return result;
        }
        public StandardResult NewOuterRegistration(EncParam encInfo)
        {
            //UtilitiesClient objutlit = new UtilitiesClient();
            StandardResult result = new StandardResult();
            try
            {
                if (encInfo == null)
                {
                    result.MSG = "FAILED";
                    result.MESSAGE = "Provided information was not in a correct format.";
                }
                else
                {
                    var param = GetObject<RegInput>(encInfo);
                    DataTable dt = obj.OuterRegistration(param);
                    //param.LPWD = objutlit.Encrypt(param.LPWD);
                    //param.TPWD = objutlit.Encrypt(param.TPWD);
                    if (dt.Rows.Count == 0)
                    {
                        result.MSG = "FAILED";
                        result.MESSAGE = "No Data";

                    }
                    else if (dt.Rows[0]["res"].ToString() == "SUCCESS")
                    {
                        result.MSG = "SUCCESS";
                        result.MESSAGE = dt.Rows[0]["idno"].ToString();
                    }
                    else
                    {
                        result.MSG = "FAILED";
                        result.MESSAGE = dt.Rows[0]["res"].ToString();
                    }

                }
            }
            catch (Exception ex)
            {
                result.MSG = "FAILED";
                result.MESSAGE = ex.Message;

            }
            finally
            {
            }
            return result;
        }

        public StandardResult UsernameChecking(EncParam encInfo)
        {
            StandardResult result = new StandardResult();
            try
            {
                if (encInfo == null)
                {
                    result.MSG = "FAILED";
                    result.MESSAGE = "Provided information was not in a correct format.";
                }
                else
                {
                    var param = GetObject<MemberIDPWD>(encInfo);
                    DataTable dt = obj.CheckUserNameAvailability(param);

                    if (dt.Rows.Count == 0)
                    {
                        result.MSG = "FAILED";
                        result.MESSAGE = "Please try again.";

                    }
                    else if (dt.Rows[0]["result"].ToString() == "SUCC")
                    {
                        result.MSG = "SUCCESS";
                        result.MESSAGE = dt.Rows[0]["result"].ToString();
                    }
                    else
                    {
                        result.MSG = "FAILED";
                        result.MESSAGE = "Username Already Exists.";
                    }

                }
            }
            catch (Exception ex)
            {
                result.MSG = "FAILED";
                result.MESSAGE = "FAILED";

            }
            finally
            {
            }
            return result;
        }

        public List<SICPOrdersList> GetSICPOrdersReport(EncParam encInfo)
        {
            List<SICPOrdersList> result = new List<SICPOrdersList>();
            try
            {
                if (encInfo.Info == null)
                {

                }
                else
                {


                    var param = GetObject<SICPOrdersListInput>(encInfo);
                    DataTable dt = obj.getSICPOrdersList(param);
                    if (dt.Rows.Count > 0)
                    {
                        for (int iRow = 0; iRow < dt.Rows.Count; iRow++)
                        {
                            result.Add(new SICPOrdersList()
                            {
                                REFNO = dt.Rows[iRow]["RefNo"].ToString(),
                                DATEOFPURCHASE = dt.Rows[iRow]["DateofPurchase"].ToString(),
                                CVPOINTS = dt.Rows[iRow]["PV"].ToString(),
                                AMOUNT = dt.Rows[iRow]["Amount"].ToString(),
                                INVDETAILS = dt.Rows[iRow]["InvoiceNo"].ToString(),
                                PAYMENTDETAILS = dt.Rows[iRow]["PaymentReceipt"].ToString(),
                                COURIERDETAILS = dt.Rows[iRow]["CourierName"].ToString()
                            });
                        }
                    }

                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
            }
            return result;
        }

        public CreditReqTransPwdResult TransPwdChecing(EncParam encInfo)
        {
            CreditReqTransPwdResult result = new CreditReqTransPwdResult();
            try
            {
                if (encInfo == null)
                {
                    result.MSG = "FAILED";
                    result.MESSAGE = "Provided information was not in a correct format.";
                }
                else
                {
                    var param = GetObject<EwalTransferTransPwdInput>(encInfo);
                    DataTable dt = obj.CheckTransPwdChecking(param);

                    if (dt.Rows.Count == 0)
                    {
                        result.MSG = "FAILED";
                        result.MESSAGE = "Please try again.";

                    }
                    else if (dt.Rows[0]["Msg"].ToString() == "Success")
                    {


                        if (Convert.ToInt64(dt.Rows[0]["Amount"]) > 0)
                        {
                            result.MSG = "SUCCESS";
                            result.WALLETAMT = dt.Rows[0]["Amount"].ToString();
                            result.MESSAGE = dt.Rows[0]["name"].ToString();
                        }
                        else
                        {
                            result.MSG = "FAILED";
                            result.WALLETAMT = "0";
                            result.MESSAGE = "You have 0 Balance to Transfer";
                        }

                    }
                    else
                    {
                        result.MSG = "FAILED";
                        result.MESSAGE = dt.Rows[0]["Message"].ToString();
                    }

                }
            }
            catch (Exception ex)
            {
                result.MSG = "FAILED";
                result.MESSAGE = "FAILED";

            }
            finally
            {
            }
            return result;
        }

        public StandardResult EwalAmtTransfer(EncParam encInfo)
        {
            StandardResult result = new StandardResult();
            try
            {
                if (encInfo == null)
                {
                    result.MSG = "FAILED";
                    result.MESSAGE = "Provided information was not in a correct format.";
                }
                else
                {
                    var param = GetObject<EwalletTransferInput>(encInfo);
                    DataTable dt = obj.EwalTransfer(param);

                    if (dt.Rows.Count == 0)
                    {
                        result.MSG = "FAILED";
                        result.MESSAGE = "Please try again.";

                    }
                    else if (dt.Rows[0]["Msg"].ToString() == "Success")
                    {
                        result.MSG = "SUCCESS";
                        result.MESSAGE = dt.Rows[0]["Message"].ToString();
                    }
                    else
                    {
                        result.MSG = "FAILED";
                        result.MESSAGE = dt.Rows[0]["Message"].ToString();
                    }

                }
            }
            catch (Exception ex)
            {
                result.MSG = "FAILED";
                result.MESSAGE = "FAILED";

            }
            finally
            {
            }
            return result;
        }





        public CommEwalletRptOutput GetEwalletRpts(EncParam encInfo)
        {
            CommEwalletRptOutput result = new CommEwalletRptOutput();
            try
            {
                if (encInfo == null)
                {
                    result.MSG = "FAILED";
                    result.MESSAGE = "Provided information was not in a correct format.";
                }
                else
                {
                    var param = GetObject<EwalletTransferInput>(encInfo);
                    DataSet ds = obj.EwalletTrasferRpt(param);


                    if (ds.Tables.Count == 0)
                    {
                        result.MSG = "FAILED";
                        result.MESSAGE = "No information found for " + param.IDNO + ".";
                    }
                    else
                    {

                        if (ds.Tables[0].Rows.Count == 0)
                        {
                            result.MSG = "FAILED";
                            result.MESSAGE = "No information found for " + param.IDNO;
                        }
                        else if (ds.Tables[0].Rows.Count > 0)
                        {
                            result.MSG = "SUCCESS";
                            result.MESSAGE = "SUCCESS";
                            result.BALAMT = ds.Tables[0].Rows[0]["Amount"].ToString();

                            if (ds.Tables[1].Rows.Count > 0)
                            {
                                foreach (DataRow dr in ds.Tables[1].Rows)
                                {
                                    CommEwalletRpt objRet = new CommEwalletRpt();
                                    objRet.DATE = dr["dated"].ToString();
                                    objRet.REMARKS = dr["remarks"].ToString();
                                    objRet.DESC = dr["descr"].ToString();
                                    objRet.CREDITPOINTS = dr["inamt"].ToString();
                                    objRet.DEBITPOINTS = dr["outamt"].ToString();
                                    objRet.BALANCE = dr["Balance"].ToString();
                                    result.COMWALRPT.Add(objRet);
                                }
                            }

                        }
                        else
                        {
                            result.MSG = "FAILED";
                            result.MESSAGE = "FAILED";

                        }
                    }


                }
            }
            catch (Exception ex)
            {
                result.MSG = "FAILED";
                result.MESSAGE = "Server Error";

            }
            finally
            {
            }
            return result;
        }

        public List<SSMPTabularViewRpt> GetSSMPTabularView(EncParam encInfo)
        {
            List<SSMPTabularViewRpt> result = new List<SSMPTabularViewRpt>();
            try
            {
                if (encInfo.Info == null)
                {

                }
                else
                {


                    var param = GetObject<SICPOrdersListInput>(encInfo);
                    DataTable dt = obj.getSSMPTabularViewData(param);
                    if (dt.Rows.Count > 0)
                    {
                        for (int iRow = 0; iRow < dt.Rows.Count; iRow++)
                        {
                            result.Add(new SSMPTabularViewRpt()
                            {
                                IDNO = dt.Rows[iRow]["idno"].ToString(),
                                NAME = dt.Rows[iRow]["Name"].ToString(),
                                CITY = dt.Rows[iRow]["city"].ToString(),
                                SPONSORID = dt.Rows[iRow]["sponsor"].ToString(),
                                DOR = dt.Rows[iRow]["memdate"].ToString(),
                                STATUS = dt.Rows[iRow]["Status"].ToString(),
                                BV = dt.Rows[iRow]["TotPV"].ToString(),
                                DOOA = dt.Rows[iRow]["mopdate"].ToString(),
                                PRODUCTDETAILS = dt.Rows[iRow]["packname"].ToString(),
                                REPBV = dt.Rows[iRow]["RREPBV"].ToString()
                            });
                        }
                    }

                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
            }
            return result;
        }

        public List<DirectSalesRptOutput> GetDirectSalesRpt(EncParam encInfo)
        {
            List<DirectSalesRptOutput> result = new List<DirectSalesRptOutput>();
            try
            {
                if (encInfo.Info == null)
                {

                }
                else
                {


                    var param = GetObject<SICPOrdersListInput>(encInfo);
                    DataTable dt = obj.getSSMPTabularViewData(param);
                    if (dt.Rows.Count > 0)
                    {
                        for (int iRow = 0; iRow < dt.Rows.Count; iRow++)
                        {
                            result.Add(new DirectSalesRptOutput()
                            {
                                IDNO = dt.Rows[iRow]["UserID"].ToString(),
                                NAME = dt.Rows[iRow]["name"].ToString(),
                                DOR = dt.Rows[iRow]["JoinDate"].ToString(),
                                STATUS = dt.Rows[iRow]["MemStatus"].ToString(),
                                AMOUNT = dt.Rows[iRow]["Amount"].ToString(),
                                BV = dt.Rows[iRow]["CV"].ToString()

                            });
                        }
                    }

                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
            }
            return result;
        }

        public List<BlockIDsRptOutput> GetBlockIDsReport(EncParam encInfo)
        {
            List<BlockIDsRptOutput> result = new List<BlockIDsRptOutput>();
            try
            {
                if (encInfo.Info == null)
                {

                }
                else
                {


                    var param = GetObject<SICPOrdersListInput>(encInfo);
                    DataTable dt = obj.getSSMPTabularViewData(param);
                    if (dt.Rows.Count > 0)
                    {
                        for (int iRow = 0; iRow < dt.Rows.Count; iRow++)
                        {
                            result.Add(new BlockIDsRptOutput()
                            {
                                IDNO = dt.Rows[iRow]["UserID"].ToString(),
                                NAME = dt.Rows[iRow]["name"].ToString(),
                                DOR = dt.Rows[iRow]["JoinDate"].ToString(),
                                ADDRESS = dt.Rows[iRow]["Address1"].ToString(),
                                CITY = dt.Rows[iRow]["City"].ToString()
                            });
                        }
                    }

                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
            }
            return result;
        }

        public List<InactiveDownOrdersRptOutput> GetInactiveDownOrders(EncParam encInfo)
        {
            List<InactiveDownOrdersRptOutput> result = new List<InactiveDownOrdersRptOutput>();
            try
            {
                if (encInfo.Info == null)
                {

                }
                else
                {


                    var param = GetObject<SICPOrdersListInput>(encInfo);
                    DataTable dt = obj.getSSMPTabularViewData(param);
                    if (dt.Rows.Count > 0)
                    {
                        for (int iRow = 0; iRow < dt.Rows.Count; iRow++)
                        {
                            result.Add(new InactiveDownOrdersRptOutput()
                            {
                                IDNO = dt.Rows[iRow]["idno"].ToString(),
                                NAME = dt.Rows[iRow]["name"].ToString(),
                                DOR = dt.Rows[iRow]["memdate"].ToString(),
                                SPONSORID = dt.Rows[iRow]["Sponsor"].ToString(),
                                CITY = dt.Rows[iRow]["city"].ToString(),
                                DOO = dt.Rows[iRow]["DateofOrd"].ToString(),
                                BV = dt.Rows[iRow]["TotPV"].ToString(),
                                STATUS = dt.Rows[iRow]["Status"].ToString()

                            });
                        }
                    }

                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
            }
            return result;
        }

        public List<SSMPRPDownnOrdersRptOutput> GetSSMPRPDownnOrders(EncParam encInfo)
        {
            List<SSMPRPDownnOrdersRptOutput> result = new List<SSMPRPDownnOrdersRptOutput>();
            try
            {
                if (encInfo.Info == null)
                {

                }
                else
                {


                    var param = GetObject<SICPOrdersListInput>(encInfo);
                    DataTable dt = obj.getSSMPTabularViewData(param);
                    if (dt.Rows.Count > 0)
                    {
                        for (int iRow = 0; iRow < dt.Rows.Count; iRow++)
                        {
                            result.Add(new SSMPRPDownnOrdersRptOutput()
                            {
                                IDNO = dt.Rows[iRow]["Idno"].ToString(),
                                DATEOFPURCHASE = dt.Rows[iRow]["Date of Purchase"].ToString(),
                                BVPOINTS = dt.Rows[iRow]["PV"].ToString(),
                                AMOUNT = dt.Rows[iRow]["Amount"].ToString(),
                                INVOICEDETAILS = dt.Rows[iRow]["Invoice No"].ToString(),
                                PAYMENTRECEIPT = dt.Rows[iRow]["Payment Receipt"].ToString(),
                                COURIERDETAILS = dt.Rows[iRow]["CourierName"].ToString()
                            });
                        }
                    }

                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
            }
            return result;
        }


        public SSMPStatisticsOutput GetSSMPStatisticsRpt(EncParam encInfo)
        {
            SSMPStatisticsOutput result = new SSMPStatisticsOutput();
            try
            {
                if (encInfo == null)
                {
                    result.MSG = "FAILED";
                    result.MESSAGE = "Provided information was not in a correct format.";
                }
                else
                {
                    var param = GetObject<SICPOrdersListInput>(encInfo);
                    DataTable dt = obj.getSSMPTabularViewData(param);

                    if (dt.Rows.Count == 0)
                    {
                        result.MSG = "FAILED";
                        result.MESSAGE = "Please try again.";

                    }
                    else
                    {
                        result.MSG = "SUCCESS";
                        result.MESSAGE = "SUCCESS";
                        result.SDTOTLEFT = dt.Rows[0]["totlecnt"].ToString();
                        result.SDTOTRIGHT = dt.Rows[0]["totrgcnt"].ToString();

                        result.SDLEFTDIST = dt.Rows[0]["totleACcnt"].ToString();
                        result.SDLEFTCONSUMER = dt.Rows[0]["totleIncnt1"].ToString();

                        result.SDRIGHTDIST = dt.Rows[0]["totrgACcnt"].ToString();
                        result.SDRIGHTCONSUMER = dt.Rows[0]["totrgIncnt"].ToString();


                        result.BVTOTLEFT = dt.Rows[0]["totleBV"].ToString();
                        result.BVTOTRIGHT = dt.Rows[0]["totrgBV"].ToString();
                        result.BVLEFTDIST = dt.Rows[0]["totleACBV"].ToString();
                        result.BVLEFTCONSUMER = dt.Rows[0]["totleInBV"].ToString();
                        result.BVRIGHTDIST = dt.Rows[0]["totrgACBV"].ToString();
                        result.BVRIGHTCONSUMER = dt.Rows[0]["totrgInBV"].ToString();

                        result.CURRENTSESSION = dt.Rows[0]["sessid"].ToString();

                        result.REGTOTLEFT = dt.Rows[0]["totCClecnt"].ToString();
                        result.REGTOTRIGHT = dt.Rows[0]["totCCrgcnt"].ToString();
                        result.REGLEFTDIST = dt.Rows[0]["totCCleACcnt"].ToString();
                        result.REGLEFTCONSUMER = dt.Rows[0]["totCCleIncnt"].ToString();
                        result.REGRIGHTDIST = dt.Rows[0]["totCCrgACcnt"].ToString();
                        result.REGRIGHTCONSUMER = dt.Rows[0]["totCCrgIncnt"].ToString();

                        result.SALESBVTOTLEFT = dt.Rows[0]["totCCleBV"].ToString();
                        result.SALESBVTOTRIGHT = dt.Rows[0]["totCCrgBV"].ToString();
                        result.SALESBVLEFTDIST = dt.Rows[0]["totCCleACBV"].ToString();
                        result.SALESBVLEFTCONSUMER = dt.Rows[0]["totCCleInBV"].ToString();
                        result.SALESBVRIGHTDIST = dt.Rows[0]["totCCrgACBV"].ToString();
                        result.SALESBVRIGHTCONSUMER = dt.Rows[0]["totCCrgInBV"].ToString();


                        result.ACTIVEIDLEFT = dt.Rows[0]["leftcount"].ToString();
                        result.ACTIVEIDRIGHT = dt.Rows[0]["rightcount"].ToString();
                        result.SALEACTIVEBVLEFT = dt.Rows[0]["leftbv"].ToString();
                        result.SALEACTIVEBVRIGHT = dt.Rows[0]["rightbv"].ToString();

                    }


                }
            }
            catch (Exception ex)
            {
                result.MSG = "FAILED";
                result.MESSAGE = "FAILED";

            }
            finally
            {
            }
            return result;
        }


        public List<SICPTabularRptOutput> GetSICPTabularView(EncParam encInfo)
        {
            List<SICPTabularRptOutput> result = new List<SICPTabularRptOutput>();
            try
            {
                if (encInfo.Info == null)
                {

                }
                else
                {
                    var param = GetObject<SICPOrdersListInput>(encInfo);
                    DataTable dt = obj.getSSMPTabularViewData(param);
                    if (dt.Rows.Count > 0)
                    {
                        for (int iRow = 0; iRow < dt.Rows.Count; iRow++)
                        {
                            result.Add(new SICPTabularRptOutput()
                            {
                                LVL = dt.Rows[iRow]["lvl"].ToString(),
                                LVLSLNO = dt.Rows[iRow]["lvlsno"].ToString(),
                                SBOID = dt.Rows[iRow]["idno"].ToString(),
                                NAME = dt.Rows[iRow]["name"].ToString(),
                                CITY = dt.Rows[iRow]["city"].ToString(),
                                DOR = dt.Rows[iRow]["doj"].ToString(),
                                STATUS = dt.Rows[iRow]["Status"].ToString(),
                                CV = dt.Rows[iRow]["CV"].ToString(),
                                SPONSOR = dt.Rows[iRow]["sponser"].ToString()
                            });
                        }
                    }

                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
            }
            return result;
        }



        public List<InactiveDownOrdersRptOutput> GetSICPInActRpt(EncParam encInfo)
        {
            List<InactiveDownOrdersRptOutput> result = new List<InactiveDownOrdersRptOutput>();
            try
            {
                if (encInfo.Info == null)
                {

                }
                else
                {


                    var param = GetObject<SICPOrdersListInput>(encInfo);
                    DataTable dt = obj.getSSMPTabularViewData(param);
                    if (dt.Rows.Count > 0)
                    {
                        for (int iRow = 0; iRow < dt.Rows.Count; iRow++)
                        {
                            result.Add(new InactiveDownOrdersRptOutput()
                            {
                                IDNO = dt.Rows[iRow]["idno"].ToString(),
                                NAME = dt.Rows[iRow]["Name"].ToString(),
                                DOR = dt.Rows[iRow]["memdate"].ToString(),
                                SPONSORID = dt.Rows[iRow]["Sponsor"].ToString(),
                                CITY = dt.Rows[iRow]["city"].ToString(),
                                DOO = dt.Rows[iRow]["DateofOrd"].ToString(),
                                BV = dt.Rows[iRow]["TotCV"].ToString()
                            });
                        }
                    }

                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
            }
            return result;
        }


        public SICPstatisticsOutput GetSICPStatistics(EncParam encInfo)
        {
            SICPstatisticsOutput result = new SICPstatisticsOutput();
            try
            {
                if (encInfo == null)
                {
                    result.MSG = "FAILED";
                    result.MESSAGE = "Provided information was not in a correct format.";
                }
                else
                {
                    var param = GetObject<SICPOrdersListInput>(encInfo);
                    DataTable dt = obj.getSSMPTabularViewData(param);

                    if (dt.Rows.Count == 0)
                    {
                        result.MSG = "FAILED";
                        result.MESSAGE = "Please try again.";

                    }
                    else
                    {
                        result.MSG = "SUCCESS";
                        result.MESSAGE = "SUCCESS";
                        result.FIRSTPURTOTORDERS = dt.Rows[0]["SIFjCnt"].ToString();
                        result.FIRSTPURTOTNOFACCCV = dt.Rows[0]["SIFjAmt"].ToString();
                        result.REPURTOTORDERS = dt.Rows[0]["SIRjCnt"].ToString();
                        result.REPURTOTNOFACCCV = dt.Rows[0]["SIRjAmt"].ToString();
                        result.CURSESFIRSTPURTOTORDERS = dt.Rows[0]["SIFjCntC"].ToString();
                        result.CURSESFIRSTPURTOTNOFACCCV = dt.Rows[0]["SIFjAmtC"].ToString();
                        result.CURSESREPURTOTORDERS = dt.Rows[0]["SIRjCntC"].ToString();
                        result.CURSESREPURTOTNOFACCCV = dt.Rows[0]["SIRjAmtC"].ToString();
                        result.PAYNO = dt.Rows[0]["payno"].ToString();
                        result.SCHFROM = dt.Rows[0]["schfrom"].ToString();
                        result.SCHTO = dt.Rows[0]["schto"].ToString();

                    }


                }
            }
            catch (Exception ex)
            {
                result.MSG = "FAILED";
                result.MESSAGE = "FAILED";

            }
            finally
            {
            }
            return result;
        }


        public List<SSMPRPDownnOrdersRptOutput> GetSICPDownnOrders(EncParam encInfo)
        {
            List<SSMPRPDownnOrdersRptOutput> result = new List<SSMPRPDownnOrdersRptOutput>();
            try
            {
                if (encInfo.Info == null)
                {

                }
                else
                {


                    var param = GetObject<SICPOrdersListInput>(encInfo);
                    DataTable dt = obj.getSSMPTabularViewData(param);
                    if (dt.Rows.Count > 0)
                    {
                        for (int iRow = 0; iRow < dt.Rows.Count; iRow++)
                        {
                            result.Add(new SSMPRPDownnOrdersRptOutput()
                            {
                                IDNO = dt.Rows[iRow]["Idno"].ToString(),
                                DATEOFPURCHASE = dt.Rows[iRow]["DateofPurchase"].ToString(),
                                BVPOINTS = dt.Rows[iRow]["PV"].ToString(),
                                AMOUNT = dt.Rows[iRow]["Amount"].ToString(),
                                INVOICEDETAILS = dt.Rows[iRow]["InvoiceNo"].ToString(),
                                PAYMENTRECEIPT = dt.Rows[iRow]["PaymentReceipt"].ToString(),
                                COURIERDETAILS = dt.Rows[iRow]["CourierName"].ToString()
                            });
                        }
                    }

                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
            }
            return result;
        }

        public SICPMonthwiseStatasticsRpt GetSICPCurrSess(EncParam encInfo)
        {
            SICPMonthwiseStatasticsRpt result = new SICPMonthwiseStatasticsRpt();
            try
            {
                if (encInfo == null)
                {
                    result.MSG = "FAILED";
                    result.MESSAGE = "Provided information was not in a correct format.";
                }
                else
                {
                    var param = GetObject<SICPOrdersListInput>(encInfo);
                    DataSet ds = obj.SICPCurrSessRpt(param);


                    if (ds.Tables.Count == 0)
                    {
                        result.MSG = "FAILED";
                        result.MESSAGE = "No information found for " + param.IDNO + ".";
                    }
                    else
                    {

                        if (ds.Tables[0].Rows.Count == 0 && ds.Tables[1].Rows.Count == 0)
                        {
                            result.MSG = "FAILED";
                            result.MESSAGE = "No information found for " + param.IDNO;
                        }
                        else if (ds.Tables[0].Rows.Count > 0 || ds.Tables[1].Rows.Count > 0)
                        {
                            result.MSG = "SUCCESS";
                            result.MESSAGE = "SUCCESS";


                            if (ds.Tables[0].Rows.Count > 0)
                            {
                                foreach (DataRow dr in ds.Tables[0].Rows)
                                {
                                    CurMonRpt objRet = new CurMonRpt();
                                    objRet.MONTH = dr["CMOnthName"].ToString();
                                    objRet.SELF = dr["selfCV"].ToString();
                                    objRet.DOWNLINE = dr["GroupCV"].ToString();
                                    objRet.TOTAL = dr["TotalCV"].ToString();
                                    result.CURMONTH.Add(objRet);
                                }
                            }


                            if (ds.Tables[1].Rows.Count > 0)
                            {
                                foreach (DataRow dr in ds.Tables[1].Rows)
                                {
                                    PrevMonRptRpt objRet = new PrevMonRptRpt();
                                    objRet.MONTH = dr["CMOnthName"].ToString();
                                    objRet.SELF = dr["selfCV"].ToString();
                                    objRet.DOWNLINE = dr["GroupCV"].ToString();
                                    objRet.TOTAL = dr["TotalCV"].ToString();
                                    result.PREMONTH.Add(objRet);
                                }
                            }

                        }
                        else
                        {
                            result.MSG = "FAILED";
                            result.MESSAGE = "FAILED";

                        }
                    }


                }
            }
            catch (Exception ex)
            {
                result.MSG = "FAILED";
                result.MESSAGE = ex.Message;

            }
            finally
            {
            }
            return result;
        }


        public List<SSMPReportOutput> GetSSMPReport(EncParam encInfo)
        {
            List<SSMPReportOutput> result = new List<SSMPReportOutput>();
            try
            {
                if (encInfo.Info == null)
                {

                }
                else
                {


                    var param = GetObject<SICPOrdersListInput>(encInfo);
                    DataTable dt = obj.getPayoutReportsData(param);
                    if (dt.Rows.Count > 0)
                    {
                        for (int iRow = 0; iRow < dt.Rows.Count; iRow++)
                        {
                            result.Add(new SSMPReportOutput()
                            {
                                SESSIONID = dt.Rows[iRow]["payno"].ToString(),
                                SCHDATES = dt.Rows[iRow]["schdates"].ToString(),
                                SSMPINCOME = dt.Rows[iRow]["SchInc"].ToString(),
                                REWARDINC = dt.Rows[iRow]["RewardIncome"].ToString(),
                                BOOSTERINC = dt.Rows[iRow]["BoosterInc"].ToString(),
                                BOOSTERBONUS = dt.Rows[iRow]["DirInc"].ToString(),
                                BRFWDAMT = dt.Rows[iRow]["BFAmt"].ToString(),
                                GROSSAMT = dt.Rows[iRow]["GrAmt"].ToString(),
                                TDS = dt.Rows[iRow]["TDS"].ToString(),
                                NETAMT = dt.Rows[iRow]["netamt"].ToString()

                            });
                        }
                    }

                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
            }
            return result;
        }


        public List<SSMPBinaryIncOutput> GetBinaryIncRpt(EncParam encInfo)
        {
            List<SSMPBinaryIncOutput> result = new List<SSMPBinaryIncOutput>();
            try
            {
                if (encInfo.Info == null)
                {

                }
                else
                {
                    var param = GetObject<SICPOrdersListInput>(encInfo);
                    DataTable dt = obj.getPayoutReportsData(param);
                    if (dt.Rows.Count > 0)
                    {
                        for (int iRow = 0; iRow < dt.Rows.Count; iRow++)
                        {
                            result.Add(new SSMPBinaryIncOutput()
                            {
                                LINK2SESSIONID = dt.Rows[iRow]["payno"].ToString(),
                                TSLNO = dt.Rows[iRow]["TSLO"].ToString(),
                                TSRO = dt.Rows[iRow]["TSRO"].ToString(),
                                NSLL = dt.Rows[iRow]["NSLL"].ToString(),
                                NSLR = dt.Rows[iRow]["NSLR"].ToString(),
                                TBVLO = dt.Rows[iRow]["TBVLO"].ToString(),
                                TBVRO = dt.Rows[iRow]["TBVRO"].ToString(),
                                NBVLL = dt.Rows[iRow]["NBVLL"].ToString(),
                                NBVLR = dt.Rows[iRow]["NBVLR"].ToString(),
                                GRBVLS = dt.Rows[iRow]["GRBVLS"].ToString(),
                                GRBVRS = dt.Rows[iRow]["GRBVRS"].ToString(),
                                SRBVLS = dt.Rows[iRow]["SRBVLS"].ToString(),
                                SRBVRS = dt.Rows[iRow]["SRBVRS"].ToString(),
                                BVCCL = dt.Rows[iRow]["BVCCL"].ToString(),
                                BVCCR = dt.Rows[iRow]["BVCCR"].ToString(),
                                BVCFL = dt.Rows[iRow]["BVCFL"].ToString(),
                                BVCFR = dt.Rows[iRow]["BVCFR"].ToString()
                            });
                        }
                    }

                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
            }
            return result;
        }



        public List<SICPMonthlyOutput> GetMonthlyReport(EncParam encInfo)
        {
            List<SICPMonthlyOutput> result = new List<SICPMonthlyOutput>();
            try
            {
                if (encInfo.Info == null)
                {

                }
                else
                {
                    var param = GetObject<SICPOrdersListInput>(encInfo);
                    DataTable dt = obj.getPayoutReportsData(param);
                    if (dt.Rows.Count > 0)
                    {
                        for (int iRow = 0; iRow < dt.Rows.Count; iRow++)
                        {
                            result.Add(new SICPMonthlyOutput()
                            {
                                SESSIONID = dt.Rows[iRow]["payno"].ToString(),
                                SCHDATES = dt.Rows[iRow]["schdates"].ToString(),
                                RANK = dt.Rows[iRow]["RankName"].ToString(),
                                AMOUNT = dt.Rows[iRow]["Amount"].ToString(),
                                SELFCV = dt.Rows[iRow]["SelfCV"].ToString(),
                                GROUPCV = dt.Rows[iRow]["GroupCV"].ToString(),
                                TOTALCV = dt.Rows[iRow]["TotalCV"].ToString(),
                                RETAILPROFIT = dt.Rows[iRow]["RetailProfit"].ToString(),
                                RESIDUALBONUS = dt.Rows[iRow]["ResidualBonus"].ToString(),
                                LEVERAGEBONUS = dt.Rows[iRow]["LeverageBonus"].ToString(),
                                OVERRIDINGBONUS = dt.Rows[iRow]["overRidingBonus"].ToString(),
                                PERFOMANCEBONUS = dt.Rows[iRow]["PerformanceBonus"].ToString(),
                                ARISTOFUND = dt.Rows[iRow]["AristocracyFund"].ToString(),
                                ROYALTYFUND = dt.Rows[iRow]["RoyaltyFund"].ToString(),
                                TOTALPAYOUT = dt.Rows[iRow]["TotalPayout"].ToString(),
                                BRFWDAMT = dt.Rows[iRow]["BroughtForwardAmount"].ToString(),
                                GROSSAMT = dt.Rows[iRow]["GrossAmount"].ToString(),
                                TDS = dt.Rows[iRow]["TDS"].ToString(),
                                NETAMT = dt.Rows[iRow]["NetAmount"].ToString()
                            });
                        }
                    }

                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
            }
            return result;
        }



        public List<PaynoOutput> GetPayoutNumbers(EncParam encInfo)
        {
            List<PaynoOutput> result = new List<PaynoOutput>();
            try
            {
                if (encInfo.Info == null)
                {

                }
                else
                {
                    var param = GetObject<PaynoInput>(encInfo);
                    DataTable dt = obj.getPayoutData(param);
                    if (dt.Rows.Count > 0)
                    {
                        for (int iRow = 0; iRow < dt.Rows.Count; iRow++)
                        {
                            result.Add(new PaynoOutput()
                            {
                                PAYNO = dt.Rows[iRow]["payno"].ToString(),
                                PAYNODATES = dt.Rows[iRow]["paynodate"].ToString()

                            });
                        }
                    }

                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
            }
            return result;
        }



        public List<HighestEarningsOutput> GetHighestEarnData(EncParam encInfo)
        {
            List<HighestEarningsOutput> result = new List<HighestEarningsOutput>();
            try
            {
                if (encInfo.Info == null)
                {

                }
                else
                {
                    var param = GetObject<SICPOrdersListInput>(encInfo);
                    DataTable dt = obj.getPayoutReportsData(param);
                    if (dt.Rows.Count > 0)
                    {
                        for (int iRow = 0; iRow < dt.Rows.Count; iRow++)
                        {
                            result.Add(new HighestEarningsOutput()
                            {
                                USERID = dt.Rows[iRow]["Idno"].ToString(),
                                NAME = dt.Rows[iRow]["name"].ToString(),
                                CITY = dt.Rows[iRow]["city"].ToString(),
                                AMOUNT = dt.Rows[iRow]["GrAmt"].ToString(),
                                MOBILE = dt.Rows[iRow]["mobile"].ToString()

                            });
                        }
                    }

                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
            }
            return result;
        }




        public List<SICPResidualOutput> GetResidualBonusRpt(EncParam encInfo)
        {
            List<SICPResidualOutput> result = new List<SICPResidualOutput>();
            try
            {
                if (encInfo.Info == null)
                {

                }
                else
                {
                    var param = GetObject<SICPOrdersListInput>(encInfo);
                    DataTable dt = obj.getPayoutReportsData(param);
                    if (dt.Rows.Count > 0)
                    {
                        for (int iRow = 0; iRow < dt.Rows.Count; iRow++)
                        {
                            result.Add(new SICPResidualOutput()
                            {
                                USERID = dt.Rows[iRow]["IDNo"].ToString(),
                                NAME = dt.Rows[iRow]["Name"].ToString(),
                                INCOMELEVEL = dt.Rows[iRow]["IncomeLevel"].ToString(),
                                PHYSICALLVL = dt.Rows[iRow]["PhysicalLevel"].ToString(),
                                CV = dt.Rows[iRow]["CV"].ToString(),
                                INCOME = dt.Rows[iRow]["Income"].ToString(),
                                APPPERCENTAGE = dt.Rows[iRow]["ApplicablePercenatge"].ToString()

                            });
                        }
                    }

                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
            }
            return result;
        }



        public List<SICPLeverageBonusOutput> GetLeverageBonusRpt(EncParam encInfo)
        {
            List<SICPLeverageBonusOutput> result = new List<SICPLeverageBonusOutput>();
            try
            {
                if (encInfo.Info == null)
                {

                }
                else
                {
                    var param = GetObject<SICPOrdersListInput>(encInfo);
                    DataTable dt = obj.getPayoutReportsData(param);
                    if (dt.Rows.Count > 0)
                    {
                        for (int iRow = 0; iRow < dt.Rows.Count; iRow++)
                        {
                            result.Add(new SICPLeverageBonusOutput()
                            {
                                USERID = dt.Rows[iRow]["IDNo"].ToString(),
                                NAME = dt.Rows[iRow]["Name"].ToString(),
                                DESGNAME = dt.Rows[iRow]["DesginationName"].ToString(),
                                SPONSORID = dt.Rows[iRow]["SponsorID"].ToString(),
                                TOTALGCV = dt.Rows[iRow]["TotalGCV"].ToString(),
                                CONSIDERGCV = dt.Rows[iRow]["ConsiderGCV"].ToString(),
                                AMOUNT = dt.Rows[iRow]["Amount"].ToString()

                            });
                        }
                    }

                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
            }
            return result;
        }

        public List<SICPNewMonthlyOutput> GetNewMonthlyReport(EncParam encInfo)
        {
            List<SICPNewMonthlyOutput> result = new List<SICPNewMonthlyOutput>();
            try
            {
                if (encInfo.Info == null)
                {

                }
                else
                {
                    var param = GetObject<SICPOrdersListInput>(encInfo);
                    DataTable dt = obj.getPayoutReportsData(param);
                    if (dt.Rows.Count > 0)
                    {
                        for (int iRow = 0; iRow < dt.Rows.Count; iRow++)
                        {
                            result.Add(new SICPNewMonthlyOutput()
                            {
                                SESSIONID = dt.Rows[iRow]["payno"].ToString(),
                                RANK = dt.Rows[iRow]["RankName"].ToString(),
                                SELFCV = dt.Rows[iRow]["SelfCV"].ToString(),
                                DOWNLINECV = dt.Rows[iRow]["GroupCV"].ToString(),
                                GCV = dt.Rows[iRow]["TotalCV"].ToString(),
                                RETAILPROFIT = dt.Rows[iRow]["RetailProfit"].ToString(),
                                LEVERAGEBONUS = dt.Rows[iRow]["LeveragBonus"].ToString(),
                                MONTHLYRETAILSTARTBONUS = dt.Rows[iRow]["MRSBonus"].ToString(),
                                POWERPOOLBONUS = dt.Rows[iRow]["PowerPoolBonus"].ToString(),
                                K25MATCHINGBONUS = dt.Rows[iRow]["BBBonus"].ToString(),
                                LEADERSHIPBONUS = dt.Rows[iRow]["LOYALBonus"].ToString(),
                                ROYALTYPERKS = dt.Rows[iRow]["ROYALBonus"].ToString(),
                                TOTALINC = dt.Rows[iRow]["TotalPayout"].ToString(),
                                BFAMT = dt.Rows[iRow]["BroughtForwardAmount"].ToString(),
                                GROSSAMT = dt.Rows[iRow]["GrossAmount"].ToString(),
                                TDS = dt.Rows[iRow]["TDS"].ToString(),
                                NETAMT = dt.Rows[iRow]["NetAmount"].ToString()

                            });
                        }
                    }

                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
            }
            return result;
        }



        public List<SICPMonRetailsStarOutput> GetMonRetailsStarReport(EncParam encInfo)
        {
            List<SICPMonRetailsStarOutput> result = new List<SICPMonRetailsStarOutput>();
            try
            {
                if (encInfo.Info == null)
                {

                }
                else
                {
                    var param = GetObject<SICPOrdersListInput>(encInfo);
                    DataTable dt = obj.getPayoutReportsData(param);
                    if (dt.Rows.Count > 0)
                    {
                        for (int iRow = 0; iRow < dt.Rows.Count; iRow++)
                        {
                            result.Add(new SICPMonRetailsStarOutput()
                            {
                                PAYNO = dt.Rows[iRow]["payno"].ToString(),
                                NOFUNITS = dt.Rows[iRow]["NoOfUnits"].ToString(),
                                SELFCV = dt.Rows[iRow]["SelfBV"].ToString(),
                                AMT = dt.Rows[iRow]["Amount"].ToString()
                            });
                        }
                    }

                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
            }
            return result;
        }


        public List<SICPLeadershipBonusOutput> GetLeadershipBonusReport(EncParam encInfo)
        {
            List<SICPLeadershipBonusOutput> result = new List<SICPLeadershipBonusOutput>();
            try
            {
                if (encInfo.Info == null)
                {

                }
                else
                {
                    var param = GetObject<SICPOrdersListInput>(encInfo);
                    DataTable dt = obj.getPayoutReportsData(param);
                    if (dt.Rows.Count > 0)
                    {
                        for (int iRow = 0; iRow < dt.Rows.Count; iRow++)
                        {
                            result.Add(new SICPLeadershipBonusOutput()
                            {
                                SESSIONID = dt.Rows[iRow]["payno"].ToString(),
                                SBOID = dt.Rows[iRow]["ThruID"].ToString(),
                                NAME = dt.Rows[iRow]["Thruname"].ToString(),
                                CONLVL = dt.Rows[iRow]["ConsideredLevel"].ToString(),
                                ACTLVL = dt.Rows[iRow]["ActualLevel"].ToString(),
                                EXCLUSIVELVL = dt.Rows[iRow]["ExclusiveCV"].ToString(),
                                APPPERCENTAGE = dt.Rows[iRow]["ApplicablePercenatge"].ToString(),
                                INCOME = dt.Rows[iRow]["Income"].ToString()
                            });
                        }
                    }

                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
            }
            return result;
        }



        public List<SICPRoyaltyperksOutput> GetRoyaltyperksReport(EncParam encInfo)
        {
            List<SICPRoyaltyperksOutput> result = new List<SICPRoyaltyperksOutput>();
            try
            {
                if (encInfo.Info == null)
                {

                }
                else
                {
                    var param = GetObject<SICPOrdersListInput>(encInfo);
                    DataTable dt = obj.getPayoutReportsData(param);
                    if (dt.Rows.Count > 0)
                    {
                        for (int iRow = 0; iRow < dt.Rows.Count; iRow++)
                        {
                            result.Add(new SICPRoyaltyperksOutput()
                            {
                                PAYNO = dt.Rows[iRow]["payno"].ToString(),
                                INCTYPE = dt.Rows[iRow]["IncomeType"].ToString(),
                                LOYALINC = dt.Rows[iRow]["loyalincome"].ToString(),
                                APPLICABLEPER = dt.Rows[iRow]["Applicablepercentage"].ToString(),
                                AMT = dt.Rows[iRow]["Amount"].ToString()

                            });
                        }
                    }

                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
            }
            return result;
        }


        public List<SICPMatchingBounsOutput> GetMatchingBounsReport(EncParam encInfo)
        {
            List<SICPMatchingBounsOutput> result = new List<SICPMatchingBounsOutput>();
            try
            {
                if (encInfo.Info == null)
                {

                }
                else
                {
                    var param = GetObject<SICPOrdersListInput>(encInfo);
                    DataTable dt = obj.getPayoutReportsData(param);
                    if (dt.Rows.Count > 0)
                    {
                        for (int iRow = 0; iRow < dt.Rows.Count; iRow++)
                        {
                            result.Add(new SICPMatchingBounsOutput()
                            {
                                PAYNO = dt.Rows[iRow]["payno"].ToString(),
                                UNITVAL = dt.Rows[iRow]["UntValue"].ToString(),
                                NOUNITS = dt.Rows[iRow]["NoofUnits"].ToString(),
                                AMT = dt.Rows[iRow]["Amount"].ToString()

                            });
                        }
                    }

                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
            }
            return result;
        }
        public SSMPRewardOutput GetSSMPRewardReport(EncParam encInfo)
        {
            SSMPRewardOutput result = new SSMPRewardOutput();
            try
            {
                if (encInfo == null)
                {
                    result.MSG = "FAILED";
                    result.MESSAGE = "Provided information was not in a correct format.";
                }
                else
                {
                    var param = GetObject<SICPOrdersListInput>(encInfo);
                    DataSet ds = obj.getSICPPayoutReportsData(param);


                    if (ds.Tables.Count == 0)
                    {
                        result.MSG = "FAILED";
                        result.MESSAGE = "No information found for " + param.IDNO + ".";
                    }
                    else
                    {

                        if (ds.Tables[0].Rows.Count == 0)
                        {
                            result.MSG = "FAILED";
                            result.MESSAGE = "No information found for " + param.IDNO;
                        }
                        else if (ds.Tables[0].Rows.Count > 0)
                        {
                            result.MSG = "SUCCESS";
                            result.MESSAGE = "SUCCESS";
                            result.RESULT = ds.Tables[0].Rows[0]["result"].ToString();
                            result.DESGRESULT = ds.Tables[0].Rows[0]["Desgresult"].ToString();
                            result.NAME = ds.Tables[0].Rows[0]["Name"].ToString();

                            if (ds.Tables[1].Rows.Count > 0)
                            {

                                result.RESTYPE = ds.Tables[1].Rows[0]["Result"].ToString();
                                result.IDNO = ds.Tables[1].Rows[0]["Idno"].ToString();
                                result.DATEOFREG = ds.Tables[1].Rows[0]["JDate"].ToString();
                                result.RANK = ds.Tables[1].Rows[0]["desgname"].ToString();
                                result.STARTDATE = ds.Tables[1].Rows[0]["SDate"].ToString();
                                result.ENDDATE = ds.Tables[1].Rows[0]["EDate"].ToString();
                                result.TOTALDAYS = ds.Tables[1].Rows[0]["NoofDays"].ToString();
                                result.DAYSLEFT = ds.Tables[1].Rows[0]["Nofdaysleft"].ToString();

                                result.TOTALSALESLEFT = ds.Tables[1].Rows[0]["TSLeft"].ToString();
                                result.TOTALSALESRIGHT = ds.Tables[1].Rows[0]["TSRIght"].ToString();

                                result.ACCSALESBVLEFT = ds.Tables[1].Rows[0]["TSLeftPV"].ToString();
                                result.ACCSALESBVRIGHT = ds.Tables[1].Rows[0]["TSRIghtPV"].ToString();

                                result.INACTIVESALESLEFT = ds.Tables[1].Rows[0]["INSLeft"].ToString();
                                result.INACTIVESALESRIGHT = ds.Tables[1].Rows[0]["INSRight"].ToString();

                                result.ACTIVESALESLEFT = ds.Tables[1].Rows[0]["ASLeft"].ToString();
                                result.ACTIVESALESRIGHT = ds.Tables[1].Rows[0]["ASRight"].ToString();

                                result.DEACTIVELEFT = ds.Tables[1].Rows[0]["BLeft"].ToString();
                                result.DEACTIVERIGHT = ds.Tables[1].Rows[0]["BSRight"].ToString();

                                result.AASBVLEFT = ds.Tables[1].Rows[0]["TSACCLeft"].ToString();
                                result.AASBVRIGHT = ds.Tables[1].Rows[0]["TSACCRIght"].ToString();

                                result.TARGETBVLEFT = ds.Tables[1].Rows[0]["LeftTarget"].ToString();
                                result.TARGETBVRIGHT = ds.Tables[1].Rows[0]["RightTarget"].ToString();

                                result.REQUIREDBVLEFT = ds.Tables[1].Rows[0]["LeftRequired"].ToString();
                                result.REQUIREDBVRIGHT = ds.Tables[1].Rows[0]["RightRequired"].ToString();

                                result.STATUS = ds.Tables[1].Rows[0]["RwdStatus"].ToString();

                            }




                        }
                        else
                        {
                            result.MSG = "FAILED";
                            result.MESSAGE = "FAILED";
                            result.RESULT = "FAILED";

                        }
                    }


                }
            }
            catch (Exception ex)
            {
                result.MSG = "FAILED";
                result.MESSAGE = ex.Message;

            }
            finally
            {
            }
            return result;
        }
        public CreditRequestOnlineResponse CreditRequestOnlineInsert(EncParam encInfo)
        {
            CreditRequestOnlineResponse result = new CreditRequestOnlineResponse();
            try
            {

                if (encInfo == null)
                {
                    result.MSG = "FAILED";
                    result.MESSAGE = "Provided information was not in a correct format.";

                }
                else
                {
                    var cInfo = GetObject<CreditRequest>(encInfo);
                    DataSet ds = obj.CreditRequestOnlineInsert(cInfo);
                    if (ds.Tables.Count == 0)
                    {
                        result.MSG = "FAILED";
                        result.MESSAGE = "No information found for " + cInfo.ORDER_ID + ".";

                    }
                    else
                    {
                        result.MSG = "SUCCESS";
                        result.MESSAGE = "Request Inserted successfuly";
                    }
                }
            }
            catch (Exception ex)
            {
                result.MSG = "FAILED";
                result.MESSAGE = "Error occured" + ex.Message;
            }
            finally
            {
            }
            return result;
        }
        public List<IncomeMonth> GetIncomeMonth(EncParam encInfo)
        {
            IncomeMonth result = new IncomeMonth();
            List<IncomeMonth> lstMonth = new List<IncomeMonth>();
            try
            {

                if (encInfo == null)
                {
                    //result.MSG = "FAILED";
                    //result.MESSAGE = "Provided information was not in a correct format.";

                }
                else
                {
                    var cInfo = GetObject<IncomeMonthInput>(encInfo);
                    DataSet ds = obj.GetPayoutMonth(cInfo);
                    if (ds.Tables.Count == 0)
                    {
                        //result.MSG = "FAILED";
                        //result.MESSAGE = "No record found";

                    }
                    else
                    {
                        foreach (DataRow dr in ds.Tables[0].Rows)
                        {
                            result = new IncomeMonth();
                            result.MONTH = Convert.ToString(dr["MONTH"]);
                            result.SESSID = Convert.ToString(dr["SESSID"]);
                            result.MONTHNAME = Convert.ToString(dr["MonthYear"]);
                            result.TOTALAMOUNT = Convert.ToString(dr["TOTALAMOUNT"]);
                            lstMonth.Add(result);
                           // result.MSG = "SUCCESS";
                            //result.MESSAGE = "SUCCESS";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                //result.MSG = "FAILED";
               // result.MESSAGE = "Error occured" + ex.Message;
            }
            finally
            {
            }
            return lstMonth;
        }
        public List<IncomeMonthDetail> GetIncomeMonthDetail(EncParam encInfo)
        {
            IncomeMonthDetail result = new IncomeMonthDetail();
            List<IncomeMonthDetail> lstMonthDetail = new List<IncomeMonthDetail>();
            try
            {

                if (encInfo == null)
                {
                    //result.MSG = "FAILED";
                    //result.MESSAGE = "Provided information was not in a correct format.";

                }
                else
                {
                    var cInfo = GetObject<IncomeMonthInput>(encInfo);
                    DataSet ds = obj.GetPayoutMonthDetail(cInfo);
                    if (ds.Tables.Count == 0)
                    {
                        //result.MSG = "FAILED";
                        //result.MESSAGE = "No record found";

                    }
                    else
                    {
                        foreach (DataRow dr in ds.Tables[0].Rows)
                        {
                            result = new IncomeMonthDetail();
                            result.FormNo = Convert.ToString(dr["Formno"]);
                            result.SESSID = Convert.ToString(dr["SESSID"]);
                            result.LeverageBonus = Convert.ToString(dr["LeverageBonus"]);
                            result.RetailProfit = Convert.ToString(dr["RetailProfit"]);
                            result.PPBonus = Convert.ToString(dr["PPBonus"]);
                            result.MatchIncome = Convert.ToString(dr["MatchIncome"]);
                            result.EarlTreasure = Convert.ToString(dr["EarlTreasure"]);
                            result.DiamondTreasure = Convert.ToString(dr["DiamondTreasure"]);
                            result.PPTreasure = Convert.ToString(dr["PPTreasure"]);
                            result.ConsistencyTreasure = Convert.ToString(dr["ConsistencyTreasure"]);
                            result.TwentyFiveTreasure = Convert.ToString(dr["25KTreasure"]);
                            result.RoyaltyIncome = Convert.ToString(dr["RoyaltyIncome"]);
                            result.MRSB = Convert.ToString(dr["MRSB"]);
                            result.NetIncome = Convert.ToString(dr["NetIncome"]);
                            result.TdsAmount = Convert.ToString(dr["TdsAmount"]);
                            result.PrevBal = Convert.ToString(dr["PrevBal"]);
                            result.ChqAmt = Convert.ToString(dr["ChqAmt"]);
                            lstMonthDetail.Add(result);
                            // result.MSG = "SUCCESS";
                            //result.MESSAGE = "SUCCESS";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                //result.MSG = "FAILED";
                // result.MESSAGE = "Error occured" + ex.Message;
            }
            finally
            {
            }
            return lstMonthDetail;
        }

        public List<IncomeMonthDetail> GetCurrentIncomeMonthDetail(EncParam encInfo)
        {
            IncomeMonthDetail result = new IncomeMonthDetail();
            List<IncomeMonthDetail> lstMonthDetail = new List<IncomeMonthDetail>();
            try
            {

                if (encInfo == null)
                {
                    //result.MSG = "FAILED";
                    //result.MESSAGE = "Provided information was not in a correct format.";

                }
                else
                {
                    var cInfo = GetObject<IncomeMonthInput>(encInfo);
                    DataSet ds = obj.GetCurrentPayoutMonthDetail(cInfo);
                    if (ds.Tables.Count == 0)
                    {
                        //result.MSG = "FAILED";
                        //result.MESSAGE = "No record found";
                        
                    }
                    else
                    {
                        foreach (DataRow dr in ds.Tables[0].Rows)
                        {
                            result = new IncomeMonthDetail();
                            result.FormNo = Convert.ToString(dr["Formno"]);
                            result.SESSID = Convert.ToString(dr["SESSID"]);
                            result.LeverageBonus = Convert.ToString(dr["LeverageBonus"]);
                            result.RetailProfit = Convert.ToString(dr["RetailProfit"]);
                            result.PPBonus = Convert.ToString(dr["PPBonus"]);
                            result.MatchIncome = Convert.ToString(dr["MatchIncome"]);
                            result.EarlTreasure = Convert.ToString(dr["EarlTreasure"]);
                            result.DiamondTreasure = Convert.ToString(dr["DiamondTreasure"]);
                            result.PPTreasure = Convert.ToString(dr["PPTreasure"]);
                            result.ConsistencyTreasure = Convert.ToString(dr["ConsistencyTreasure"]);
                            result.TwentyFiveTreasure = Convert.ToString(dr["25KTreasure"]);
                            result.RoyaltyIncome = Convert.ToString(dr["RoyaltyIncome"]);
                            result.MRSB = Convert.ToString(dr["MRSB"]);
                            result.NetIncome = Convert.ToString(dr["NetIncome"]);
                            result.TdsAmount = Convert.ToString(dr["TdsAmount"]);
                            result.PrevBal = Convert.ToString(dr["PrevBal"]);
                            result.ChqAmt = Convert.ToString(dr["ChqAmt"]);
                            lstMonthDetail.Add(result);
                            // result.MSG = "SUCCESS";
                            //result.MESSAGE = "SUCCESS";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                //result.MSG = "FAILED";
                // result.MESSAGE = "Error occured" + ex.Message;
            }
            finally
            {
            }
            return lstMonthDetail;
        }
    }
}