using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Net;
using System.Runtime.Serialization;
using System.Security.Cryptography;
using System.Text;


namespace SARSOMobileService
{

    [DataContract]
    public class EncParam
    {
        [DataMember]
        public string Info { get; set; }
    }

    [DataContract]
    public class CredentialInfo
    {
        [DataMember]
        public string IDNO { get; set; }
        [DataMember]
        public string PWD { get; set; }
        [DataMember]
        public string MOBINFO { get; set; }
        [DataMember]
        public string GCMID { get; set; }
        [DataMember]
        public string IMEI { get; set; }
        [DataMember]
        public string WLANMAC { get; set; }
        [DataMember]
        public string ANDROIDID { get; set; }
        [DataMember]
        public string VERSION { get; set; }


    }
    [DataContract]
    public class CredentialResult
    {
        [DataMember]
        public string MSG { get; set; }
        [DataMember]
        public string MESSAGE { get; set; }
        [DataMember]
        public string FNAME { get; set; }
        [DataMember]
        public string VERSION { get; set; }
        [DataMember]
        public string MEMTYPE { get; set; }
        [DataMember]
        public string REGID { get; set; }
        [DataMember]
        public string PAYTM { get; set; }
        [DataMember]
        public string EBS { get; set; }

        /* [DataMember]
        public string RANKSSMP { get; set; }
        [DataMember]
        public string RANKSICP { get; set; }
        [DataMember]
        public string WALLETAMT { get; set; }
        [DataMember]
        public string TOTALPAYOUTEARNED { get; set; }
        [DataMember]
        public string PERSONALRECUITS { get; set; }
        */
        [DataMember]
        public List<DisplayImage> IMAGE = new List<DisplayImage>();

    }

    [DataContract]
    public class DisplayImage
    {

        [DataMember]
        public string IMAGE { get; set; }
    }

    [DataContract]
    public class MemberIDPWD
    {
        [DataMember]
        public string IDNO { get; set; }
        [DataMember]
        public string PWD { get; set; }
    }


    [DataContract]
    public class DashboardSummary
    {
        [DataMember]
        public string MSG { get; set; }
        [DataMember]
        public string MESSAGE { get; set; }
        [DataMember]
        public string RANKSSMP { get; set; }
        [DataMember]
        public string RANKSICP { get; set; }
        [DataMember]
        public string WALLETAMT { get; set; }
        [DataMember]
        public string TOTALPAYOUTEARNED { get; set; }
        [DataMember]
        public string PERSONALRECUITS { get; set; }
    }

    [DataContract]
    public class SSMPDetailsData
    {
        [DataMember]
        public string MSG { get; set; }
        [DataMember]
        public string MESSAGE { get; set; }
        [DataMember]
        public string BV { get; set; }
        [DataMember]
        public string TOTLEFTUNIQUEORDPLACEDTODAY { get; set; }
        [DataMember]
        public string TOTLEFTUNIQUEORDPLACEDCURSESSION { get; set; }
        [DataMember]
        public string TOTLEFTUNIQUEORDPLACEDTILLDATE { get; set; }
        [DataMember]
        public string TOTRIGHTUNIQUEORDPLACEDTODAY { get; set; }
        [DataMember]
        public string TOTRIGHTUNIQUEORDPLACEDCURSESSION { get; set; }
        [DataMember]
        public string TOTRIGHTUNIQUEORDPLACEDTILLDATE { get; set; }
        [DataMember]
        public string TOTCLUSTERSALES { get; set; }
        [DataMember]
        public string POSINCURRCLUSTER { get; set; }
        [DataMember]
        public string TOTSSMPINCOME { get; set; }
    }



    [DataContract]
    public class SICPDetailsData
    {

        [DataMember]
        public string TEAMTYPE { get; set; }
        [DataMember]
        public string TOTALGCV { get; set; }
        [DataMember]
        public string NAME { get; set; }
        [DataMember]
        public string TOTSICPINC { get; set; }

    }

    [DataContract]
    public class DesgIncomeDetailsData
    {
        [DataMember]
        public string MSG { get; set; }
        [DataMember]
        public string MESSAGE { get; set; }
        [DataMember]
        public string CURRMONTH { get; set; }
        [DataMember]
        public string RANKNAME { get; set; }
        [DataMember]
        public string RANKACHIEVEDDATE { get; set; }
        [DataMember]
        public string RESIDUALBONUS { get; set; }
        [DataMember]
        public string PERFOMANCEBONUS { get; set; }
        [DataMember]
        public string LEVERANGEBOUNS { get; set; }
        [DataMember]
        public string OVERRIDINGBONUS { get; set; }
        [DataMember]
        public string ARISTOFUNDS { get; set; }
        [DataMember]
        public string ROYALPERKS { get; set; }
        [DataMember]
        public string TOTAL { get; set; }
    }
    [DataContract]
    public class IncomeMonthDetail
    {
        [DataMember]
        public string MSG { get; set; }
        [DataMember]
        public string MESSAGE { get; set; }
        [DataMember]
        public string FormNo { get; set; }
        [DataMember]
        public string SESSID { get; set; }
        [DataMember]
        public string LeverageBonus { get; set; }
        [DataMember]
        public string RetailProfit { get; set; }
        [DataMember]
        public string MRSB { get; set; }
        [DataMember]
        public string PPBonus { get; set; }
        [DataMember]
        public string MatchIncome { get; set; }
        [DataMember]
        public string EarlTreasure { get; set; }
        [DataMember]
        public string DiamondTreasure { get; set; }
        [DataMember]
        public string PPTreasure { get; set; }
        [DataMember]
        public string ConsistencyTreasure { get; set; }
        [DataMember]
        public string TwentyFiveTreasure { get; set; }
        [DataMember]
        public string RoyaltyIncome { get; set; }
        [DataMember]
        public string NetIncome { get; set; }
        [DataMember]
        public string TdsAmount { get; set; }
        [DataMember]
        public string PrevBal { get; set; }
        [DataMember]
        public string ChqAmt { get; set; }
    }
    [DataContract]
    public class IncomeMonth
    {
        //[DataMember]
        //public string MSG { get; set; }
        //[DataMember]
        //public string MESSAGE { get; set; }
        [DataMember]
        public string SESSID { get; set; }
        [DataMember]
        public string MONTHNAME { get; set; }
        [DataMember]
        public string MONTH { get; set; }
        [DataMember]
        public string TOTALAMOUNT { get; set; }
    }
    [DataContract]
    public class IncomeMonthInput
    {
        [DataMember]
        public string MSG { get; set; }
        [DataMember]
        public string MESSAGE { get; set; }
        [DataMember]
        public string FORMNO { get; set; }
        [DataMember]
        public string SESSID { get; set; }
    }
    [DataContract]
    public class ChangePWD
    {
        [DataMember]
        public string IDNO { get; set; }
        [DataMember]
        public string OPWD { get; set; }
        [DataMember]
        public string NPWD { get; set; }
    }


    [DataContract]
    public class StandardResult
    {
        [DataMember]
        public string MSG { get; set; }
        [DataMember]
        public string MESSAGE { get; set; }
    }



    [DataContract]
    public class EwalletRptOutput
    {

        [DataMember]
        public string MSG { get; set; }
        [DataMember]
        public string MESSAGE { get; set; }
        [DataMember]
        public string TOTBALAMT { get; set; }
        [DataMember]
        public List<EwalletRpt> EWALRPT = new List<EwalletRpt>();
    }



    [DataContract]
    public class EwalletRpt
    {
        [DataMember]
        public string DATE { get; set; }
        [DataMember]
        public string DESC { get; set; }
        [DataMember]
        public string TRANTYPE { get; set; }
        [DataMember]
        public string AMOUNT { get; set; }
    }

    [DataContract]
    public class SponsorRpt
    {
        [DataMember]
        public string SBO { get; set; }
        [DataMember]
        public string NAME { get; set; }
        [DataMember]
        public string BV { get; set; }
        [DataMember]
        public string AMOUNT { get; set; }
        [DataMember]
        public string STATUS { get; set; }
        [DataMember]
        public string DATE { get; set; }
    }


    [DataContract]
    public class TreeviewInput
    {
        [DataMember]
        public string IDNO { get; set; }
        [DataMember]
        public string PWD { get; set; }
        [DataMember]
        public string TVIEWIDNO { get; set; }
        [DataMember]
        public string LEG { get; set; }

    }

    [DataContract]
    public class SSMPGenealogyOutput
    {
        [DataMember]
        public string IDNO { get; set; }
        [DataMember]
        public string NAME { get; set; }
        [DataMember]
        public string POSITION { get; set; }
        [DataMember]
        public string ASTATUS { get; set; }


    }

    [DataContract]
    public class SICPGenealogyOutput
    {
        [DataMember]
        public string IDNO { get; set; }
        [DataMember]
        public string NAME { get; set; }
        [DataMember]
        public string ASTATUS { get; set; }


    }


    [DataContract]
    public class SSMPGenealogyToolTip
    {


        [DataMember]
        public string IDNO { get; set; }
        [DataMember]
        public string NAME { get; set; }
        [DataMember]
        public string SPONSOR { get; set; }
        [DataMember]
        public string SPONSORNAME { get; set; }
        [DataMember]
        public string DOR { get; set; }
        [DataMember]
        public string STATUS { get; set; }
        [DataMember]
        public string PAYMENTSTS { get; set; }
        [DataMember]
        public string DESG { get; set; }
        [DataMember]
        public string SELFBV { get; set; }
        [DataMember]
        public string GROUPBV { get; set; }
        [DataMember]
        public string LEFTIDCNT { get; set; }
        [DataMember]
        public string RIGHTIDCNT { get; set; }
        [DataMember]
        public string ACTIVELEFTIDCNT { get; set; }
        [DataMember]
        public string ACTIVERIGHTIDCNT { get; set; }
        [DataMember]
        public string INACTIVELEFTIDCNT { get; set; }
        [DataMember]
        public string INACTIVERIGHTIDCNT { get; set; }
        [DataMember]
        public string LTCURSESSBV { get; set; }
        [DataMember]
        public string RTCURSESSBV { get; set; }
        [DataMember]
        public string CCLCNT { get; set; }
        [DataMember]
        public string CCRCNT { get; set; }


    }
    [DataContract]
    public class SICPGenealogyToolTip
    {
        [DataMember]
        public string IDNO { get; set; }
        [DataMember]
        public string NAME { get; set; }
        [DataMember]
        public string SPONSOR { get; set; }
        [DataMember]
        public string SPONSORNAME { get; set; }
        [DataMember]
        public string DOR { get; set; }
        [DataMember]
        public string STATUS { get; set; }
        [DataMember]
        public string PAYMENTSTS { get; set; }
        [DataMember]
        public string DESG { get; set; }
        [DataMember]
        public string SELFCV { get; set; }
        [DataMember]
        public string GROUPCV { get; set; }
        [DataMember]
        public string ACTIVEIDCNT { get; set; }
        [DataMember]
        public string INACTIVEIDCNT { get; set; }
        [DataMember]
        public string CURSESSIDCNT { get; set; }
        [DataMember]
        public string CURSESSCV { get; set; }

    }

    [DataContract]
    public class NotificationsResult
    {
        [DataMember]
        public string MSG { get; set; }
        [DataMember]
        public string MESSAGE { get; set; }
        [DataMember]
        public string REGISTRATION { get; set; }
        [DataMember]
        public string COMPNYNOTIFY { get; set; }
        [DataMember]
        public string FORGOTPWD { get; set; }
        [DataMember]
        public string EWALLTREQUEST { get; set; }

    }

    [DataContract]
    public class NotificationsParam
    {
        [DataMember]
        public string IDNO { get; set; }
        [DataMember]
        public string PWD { get; set; }
        [DataMember]
        public int REGISTRATION { get; set; }
        [DataMember]
        public int COMPNYNOTIFY { get; set; }
        [DataMember]
        public int FORGOTPWD { get; set; }
        [DataMember]
        public int EWALLTREQUEST { get; set; }
    }

    [DataContract]
    public class CreditReqTpwdInput
    {
        [DataMember]
        public string IDNO { get; set; }
        [DataMember]
        public string PWD { get; set; }
        [DataMember]
        public String TRAPWD { get; set; }
    }

    [DataContract]
    public class SubCatInput
    {
        [DataMember]
        public string IDNO { get; set; }
        [DataMember]
        public string PWD { get; set; }
        [DataMember]
        public String CATEGORY { get; set; }

    }

    [DataContract]
    public class SubCatOneInput
    {
        [DataMember]
        public string IDNO { get; set; }
        [DataMember]
        public string PWD { get; set; }
        [DataMember]
        public String CATEGORY { get; set; }
        [DataMember]
        public String SUBCATEGORY { get; set; }

    }

    [DataContract]
    public class CreditReqTransPwdResult
    {
        [DataMember]
        public string MSG { get; set; }
        [DataMember]
        public string MESSAGE { get; set; }
        [DataMember]
        public string WALLETAMT { get; set; }


    }


    [DataContract]
    public class SICKRanksList
    {


        [DataMember]
        public List<CheckurRankRpt> CHECKURRANK = new List<CheckurRankRpt>();

        [DataMember]
        public List<ElgRpt> ELIGIBILITYRPT = new List<ElgRpt>();
    }

    [DataContract]
    public class CheckurRankRpt
    {
        [DataMember]
        public string RANK { get; set; }
        [DataMember]
        public string CRITIRIA { get; set; }
        [DataMember]
        public string ACCGCV { get; set; }
        [DataMember]
        public string STATUS { get; set; }
    }


    [DataContract]
    public class ElgRpt
    {
        [DataMember]
        public string SBOID { get; set; }
        [DataMember]
        public string NAME { get; set; }
        [DataMember]
        public string RANK { get; set; }
        [DataMember]
        public string ACCGCV { get; set; }
        [DataMember]
        public string CRITIRIA { get; set; }
        [DataMember]
        public string RSTATUS { get; set; }

    }


    [DataContract]
    public class AttributesList
    {
        [DataMember]
        public List<AttNamesRpt> ATTRIBUTENAMES = new List<AttNamesRpt>();

        [DataMember]
        public List<AttTypesRpt> ATTRIBUTETYPES = new List<AttTypesRpt>();
    }


    [DataContract]
    public class AttNamesRpt
    {
        [DataMember]
        public string NAME { get; set; }
        [DataMember]
        public string PCODE { get; set; }

    }


    [DataContract]
    public class AttTypesRpt
    {
        [DataMember]
        public string NAME { get; set; }
        [DataMember]
        public string FIELD { get; set; }
        [DataMember]
        public string PCODE { get; set; }


    }


    [DataContract]
    public class SICPProductsOutput
    {

        [DataMember]
        public string MSG { get; set; }
        [DataMember]
        public string MESSAGE { get; set; }
        [DataMember]
        public string STATUS { get; set; }
        [DataMember]
        public List<ProductsList> PRODUCTSRPT = new List<ProductsList>();
    }



    [DataContract]
    public class ProductsList
    {
        [DataMember]
        public string PID { get; set; }
        [DataMember]
        public string PCODE { get; set; }
        [DataMember]
        public string PNAME { get; set; }
        [DataMember]
        public string MRP { get; set; }
        [DataMember]
        public string OFFERPRICE { get; set; }
        [DataMember]
        public string DISCPRICE { get; set; }
        [DataMember]
        public string CV { get; set; }
        [DataMember]
        public string SMALLIMG { get; set; }
        [DataMember]
        public string MEDIUMIMG { get; set; }
        [DataMember]
        public string BIGIMG { get; set; }
        [DataMember]
        public string DESCR { get; set; }
        [DataMember]
        public string SHIPPINGINFO { get; set; }
        [DataMember]
        public string CATEGORY { get; set; }
        [DataMember]
        public string SUBCAT { get; set; }
        [DataMember]
        public string SUBCATONE { get; set; }


    }



    [DataContract]
    public class CartItems
    {
        [DataMember]
        public string PID { get; set; }
        [DataMember]
        public string PCODE { get; set; }
        [DataMember]
        public string PNAME { get; set; }
        [DataMember]
        public string MRP { get; set; }
        [DataMember]
        public string OFFERPRICE { get; set; }
        [DataMember]
        public string DISCPRICE { get; set; }
        [DataMember]
        public string CV { get; set; }
        [DataMember]
        public string SMALLIMG { get; set; }

        [DataMember]
        public string ATTRIBUTES { get; set; }
        [DataMember]
        public string ITEMCODE { get; set; }
        [DataMember]
        public string CATEGORY { get; set; }
        [DataMember]
        public string SUBCAT { get; set; }
        [DataMember]
        public string SUBCATONE { get; set; }


    }



    [DataContract]
    public class CategoriesList
    {
        [DataMember]
        public string NAME { get; set; }
    }
    [DataContract]
    public class SubCategoriesOneList
    {
        [DataMember]
        public string ID { get; set; }
        [DataMember]
        public string NAME { get; set; }
    }


    [DataContract]
    public class GetprodcutsInput
    {
        [DataMember]
        public string IDNO { get; set; }
        [DataMember]
        public string PWD { get; set; }
        [DataMember]
        public string CATEGORY { get; set; }
        [DataMember]
        public string SUBCAT { get; set; }
        [DataMember]
        public string SUBCATONE { get; set; }
        [DataMember]
        public string ORDERIDNO { get; set; }
        [DataMember]
        public string SEARCH { get; set; }


    }
    [DataContract]
    public class GetprodcutAttributesInput
    {
        [DataMember]
        public string IDNO { get; set; }
        [DataMember]
        public string PWD { get; set; }
        [DataMember]
        public string PID { get; set; }
    }

    [DataContract]
    public class ShippingInfoInput
    {
        [DataMember]
        public string IDNO { get; set; }
        [DataMember]
        public string PWD { get; set; }
        [DataMember]
        public string ORDERIDNO { get; set; }
    }


    [DataContract]
    public class BusinessSummaryList
    {
        [DataMember]
        public string SICP { get; set; }
        [DataMember]
        public string PREVIOUSBALANCE { get; set; }
        [DataMember]
        public string SELF { get; set; }
        [DataMember]
        public string DOWNLINE { get; set; }
        [DataMember]
        public string TOTAL { get; set; }
        [DataMember]
        public string TOTALBUSINESS { get; set; }
        [DataMember]
        public string IDTYPE { get; set; }


    }
    [DataContract]
    public class LoyaltyRankList
    {
        [DataMember]
        public string IDNO { get; set; }
        [DataMember]
        public string NAME { get; set; }
        [DataMember]
        public string RANK { get; set; }
        [DataMember]
        public string CURRACCGCV { get; set; }
        [DataMember]
        public string CURREXCLGCV { get; set; }
    }


    [DataContract]
    public class LoyaltyRankOutput
    {

        [DataMember]
        public string MSG { get; set; }
        [DataMember]
        public string MESSAGE { get; set; }
        [DataMember]
        public string CRITIRIA { get; set; }
        [DataMember]
        public string STATUS { get; set; }
        [DataMember]
        public string RANK { get; set; }
        [DataMember]
        public string CURRACCGCV { get; set; }
        [DataMember]
        public string CURREXCLGCV { get; set; }
        [DataMember]
        public List<DownlineRpt> DOWNLINEIDS = new List<DownlineRpt>();
    }

    [DataContract]
    public class DownlineRpt
    {
        [DataMember]
        public string IDNO { get; set; }
        [DataMember]
        public string NAME { get; set; }
        [DataMember]
        public string RANK { get; set; }
        [DataMember]
        public string CURRACCGCV { get; set; }
        [DataMember]
        public string CURREXCLGCV { get; set; }
    }


    [DataContract]
    public class LoyaltyReportInput
    {
        [DataMember]
        public string IDNO { get; set; }
        [DataMember]
        public string PWD { get; set; }
        [DataMember]
        public string MONTH { get; set; }
        [DataMember]
        public string YEAR { get; set; }

    }

    [DataContract]
    public class ClickandShareList
    {
        [DataMember]
        public string SHAREDATA { get; set; }
        [DataMember]
        public string IMG { get; set; }

    }
    [DataContract]
    public class AddDeleteproductInPut
    {
        [DataMember]
        public string ACTION { get; set; }
        [DataMember]
        public string IDNO { get; set; }
        [DataMember]
        public string PWD { get; set; }
        [DataMember]
        public string UNIQUEID { get; set; }
        [DataMember]
        public string PCODE { get; set; }
        [DataMember]
        public string QTY { get; set; }
        [DataMember]
        public string ATTRIBUTES { get; set; }
        [DataMember]
        public string ITEMCODE { get; set; }


    }

    [DataContract]
    public class AddDeleteproductOutPut
    {
        [DataMember]
        public string MSG { get; set; }
        [DataMember]
        public string MESSAGE { get; set; }
        [DataMember]
        public List<ItemsRpt> CARTPRODUCTS = new List<ItemsRpt>();
    }

    [DataContract]
    public class ItemsRpt
    {
        [DataMember]
        public string PCODE { get; set; }
        [DataMember]
        public string PNAME { get; set; }
        [DataMember]
        public string PV { get; set; }
        [DataMember]
        public string MRP { get; set; }
        [DataMember]
        public string PRICE { get; set; }
        [DataMember]
        public string DP { get; set; }
        [DataMember]
        public string DISCOUNT { get; set; }
        [DataMember]
        public string QTY { get; set; }
        [DataMember]
        public string ITEMCODE { get; set; }
        [DataMember]
        public string ATTRIBUTE { get; set; }
        [DataMember]
        public string IMG { get; set; }
    }


    [DataContract]
    public class ItemCodeInput
    {
        [DataMember]
        public string PCODE { get; set; }
        [DataMember]
        public string ATTRIBUTES { get; set; }
        [DataMember]
        public string QTY { get; set; }


    }

    [DataContract]
    public class ItemCodeOutput
    {
        [DataMember]
        public string MSG { get; set; }
        [DataMember]
        public string MESSAGE { get; set; }
        [DataMember]
        public string ITEMCODE { get; set; }

    }



    [DataContract]
    public class ShippingInfoOutput
    {
        [DataMember]
        public string MSG { get; set; }
        [DataMember]
        public string MESSAGE { get; set; }
        [DataMember]
        public string FNAME { get; set; }
        [DataMember]
        public string LNAME { get; set; }
        [DataMember]
        public string MOBILENO { get; set; }
        [DataMember]
        public string ADDRESS { get; set; }
        [DataMember]
        public string CITY { get; set; }
        [DataMember]
        public string DISTRICT { get; set; }
        [DataMember]
        public string STATE { get; set; }
        [DataMember]
        public string PINCODE { get; set; }
        [DataMember]
        public string EWABAL { get; set; }
        [DataMember]
        public List<StatesRpt> STATES = new List<StatesRpt>();


    }

    [DataContract]
    public class StatesRpt
    {
        [DataMember]
        public string STATEID { get; set; }
        [DataMember]
        public string SNAME { get; set; }
    }

    [DataContract]
    public class OrderInfoTotalsInput
    {
        [DataMember]
        public string IDNO { get; set; }
        [DataMember]
        public string PWD { get; set; }
        [DataMember]
        public string UNIQUEID { get; set; }
        [DataMember]
        public string TRANSPWD { get; set; }
        [DataMember]
        public string ORDERIDNO { get; set; }
    }

    [DataContract]
    public class OrderSubTotalsInfo
    {
        [DataMember]
        public string MSG { get; set; }
        [DataMember]
        public string MESSAGE { get; set; }
        [DataMember]
        public string TOTQTY { get; set; }
        [DataMember]
        public string TOTCV { get; set; }
        [DataMember]
        public string SUBTOTAL { get; set; }
        [DataMember]
        public string DISCOUNTPRICE { get; set; }
        [DataMember]
        public string PAYBLEAMT { get; set; }
        [DataMember]
        public string SHIPCHRGS { get; set; }
        [DataMember]
        public string GRANDTOTAL { get; set; }

    }



    [DataContract]
    public class FinalOrderInPut
    {
        [DataMember]
        public string UNIQUEID { get; set; }
        [DataMember]
        public string IDNO { get; set; }
        [DataMember]
        public string PWD { get; set; }
        [DataMember]
        public string DOWNLOADID { get; set; }
        [DataMember]
        public string MOP { get; set; }
        [DataMember]
        public string MOPAMT { get; set; }
        [DataMember]
        public string FNAME { get; set; }
        [DataMember]
        public string LNAME { get; set; }
        [DataMember]
        public string MOBILE { get; set; }
        [DataMember]
        public string ADDRESS { get; set; }
        [DataMember]
        public string CITY { get; set; }
        [DataMember]
        public string DISTRICT { get; set; }
        [DataMember]
        public string STATE { get; set; }
        [DataMember]
        public string PINCODE { get; set; }
        [DataMember]
        public string ORDERTYPE { get; set; }
        [DataMember]
        public string SHPCHRG { get; set; }
        [DataMember]
        public string SCMEMTYPE { get; set; }


    }

    [DataContract]
    public class OrderOutputResult
    {
        [DataMember]
        public string MSG { get; set; }
        [DataMember]
        public string MESSAGE { get; set; }
        [DataMember]
        public string BILLNO { get; set; }
        [DataMember]
        public string REQNO { get; set; }
    }


    [DataContract]
    public class RegSponsorInput
    {
        [DataMember]
        public string IDNO { get; set; }
        [DataMember]
        public string PWD { get; set; }
        [DataMember]
        public string SPONSORIDNO { get; set; }


    }
    [DataContract]
    public class RegSponsor
    {
        [DataMember]
        public string SPONSORIDNO { get; set; }
    }
    [DataContract]
    public class SCMOnlineResponse
    {
        [DataMember]
        public string MSG { get; set; }
        [DataMember]
        public string MESSAGE { get; set; }
    }
    [DataContract]
    public class TempOrderResponse
    {
        [DataMember]
        public string MSG { get; set; }
        [DataMember]
        public string MESSAGE { get; set; }
    }

    [DataContract]
    public class CreditRequestOnlineResponse
    {
        [DataMember]
        public string MSG { get; set; }
        [DataMember]
        public string MESSAGE { get; set; }
    }
    [DataContract]
    public class RegInput
    {

        [DataMember]
        public string IDNO { get; set; }
        [DataMember]
        public string PWD { get; set; }
        [DataMember]
        public string SPONSOR { get; set; }
        [DataMember]
        public string PLACEMENT { get; set; }
        [DataMember]
        public string TITLE { get; set; }
        [DataMember]
        public string GENDER { get; set; }
        [DataMember]
        public string FNAME { get; set; }
        [DataMember]
        public string LNAME { get; set; }
        [DataMember]
        public string MOBILE { get; set; }
        [DataMember]
        public string EMAIL { get; set; }
        [DataMember]
        public string USERNAME { get; set; }
        [DataMember]
        public string LPWD { get; set; }
        [DataMember]
        public string TPWD { get; set; }
        [DataMember]
        public string CorrAdds { get; set; }
        [DataMember]
        public string PerAdds { get; set; }
        [DataMember]
        public string CorrCity { get; set; }
        [DataMember]
        public string PerCity { get; set; }
        [DataMember]
        public string CorrDistrict { get; set; }
        [DataMember]
        public string PerDistrict { get; set; }
        [DataMember]
        public string Corrddlstate { get; set; }
        [DataMember]
        public string Perddlstate { get; set; }
        [DataMember]
        public string CorrPINCode { get; set; }
        [DataMember]
        public string PerPINCode { get; set; }

    }




    [DataContract]
    public class SICPOrdersList
    {

        [DataMember]
        public string REFNO { get; set; }
        [DataMember]
        public string DATEOFPURCHASE { get; set; }
        [DataMember]
        public string CVPOINTS { get; set; }
        [DataMember]
        public string AMOUNT { get; set; }
        [DataMember]
        public string INVDETAILS { get; set; }
        [DataMember]
        public string PAYMENTDETAILS { get; set; }
        [DataMember]
        public string COURIERDETAILS { get; set; }


    }



    [DataContract]
    public class SICPOrdersListInput
    {

        [DataMember]
        public string IDNO { get; set; }
        [DataMember]
        public string PWD { get; set; }
        [DataMember]
        public string ACTION { get; set; }
        [DataMember]
        public string TYPE { get; set; }
    }

    [DataContract]
    public class EwalTransferTransPwdInput
    {

        [DataMember]
        public string IDNO { get; set; }
        [DataMember]
        public string PWD { get; set; }
        [DataMember]
        public string TRAPWD { get; set; }
        [DataMember]
        public string ACTION { get; set; }



    }

    [DataContract]
    public class EwalletTransferInput
    {
        [DataMember]
        public string IDNO { get; set; }
        [DataMember]
        public string PWD { get; set; }
        [DataMember]
        public string AMOUNT { get; set; }
        [DataMember]
        public string ACTION { get; set; }
    }
    [DataContract]
    public class CommEwalletRpt
    {
        [DataMember]
        public string DATE { get; set; }
        [DataMember]
        public string REMARKS { get; set; }
        [DataMember]
        public string DESC { get; set; }
        [DataMember]
        public string CREDITPOINTS { get; set; }
        [DataMember]
        public string DEBITPOINTS { get; set; }
        [DataMember]
        public string BALANCE { get; set; }
    }


    [DataContract]
    public class CommEwalletRptOutput
    {
        [DataMember]
        public string MSG { get; set; }
        [DataMember]
        public string MESSAGE { get; set; }
        [DataMember]
        public string BALAMT { get; set; }
        [DataMember]
        public List<CommEwalletRpt> COMWALRPT = new List<CommEwalletRpt>();
    }



    [DataContract]
    public class SSMPTabularViewRpt
    {
        [DataMember]
        public string IDNO { get; set; }
        [DataMember]
        public string NAME { get; set; }
        [DataMember]
        public string CITY { get; set; }
        [DataMember]
        public string SPONSORID { get; set; }
        [DataMember]
        public string DOR { get; set; }
        [DataMember]
        public string STATUS { get; set; }
        [DataMember]
        public string BV { get; set; }
        [DataMember]
        public string DOOA { get; set; }
        [DataMember]
        public string PRODUCTDETAILS { get; set; }
        [DataMember]
        public string REPBV { get; set; }

    }


    [DataContract]
    public class DirectSalesRptOutput
    {
        [DataMember]
        public string IDNO { get; set; }
        [DataMember]
        public string NAME { get; set; }
        [DataMember]
        public string BV { get; set; }
        [DataMember]
        public string AMOUNT { get; set; }
        [DataMember]
        public string STATUS { get; set; }
        [DataMember]
        public string DOR { get; set; }
    }



    [DataContract]
    public class BlockIDsRptOutput
    {
        [DataMember]
        public string IDNO { get; set; }
        [DataMember]
        public string NAME { get; set; }
        [DataMember]
        public string ADDRESS { get; set; }
        [DataMember]
        public string CITY { get; set; }
        [DataMember]
        public string DOR { get; set; }
    }



    [DataContract]
    public class InactiveDownOrdersRptOutput
    {
        [DataMember]
        public string IDNO { get; set; }
        [DataMember]
        public string NAME { get; set; }
        [DataMember]
        public string SPONSORID { get; set; }
        [DataMember]
        public string DOO { get; set; }
        [DataMember]
        public string DOR { get; set; }
        [DataMember]
        public string STATUS { get; set; }
        [DataMember]
        public string BV { get; set; }
        [DataMember]
        public string CITY { get; set; }
    }


    [DataContract]
    public class SSMPRPDownnOrdersRptOutput
    {
        [DataMember]
        public string IDNO { get; set; }
        [DataMember]
        public string DATEOFPURCHASE { get; set; }
        [DataMember]
        public string BVPOINTS { get; set; }
        [DataMember]
        public string AMOUNT { get; set; }
        [DataMember]
        public string INVOICEDETAILS { get; set; }
        [DataMember]
        public string PAYMENTRECEIPT { get; set; }
        [DataMember]
        public string COURIERDETAILS { get; set; }

    }


    [DataContract]
    public class SSMPStatisticsOutput
    {

        [DataMember]
        public string MSG { get; set; }
        [DataMember]
        public string MESSAGE { get; set; }

        [DataMember]
        public string SDTOTLEFT { get; set; }
        [DataMember]
        public string SDTOTRIGHT { get; set; }
        [DataMember]
        public string SDLEFTDIST { get; set; }
        [DataMember]
        public string SDLEFTCONSUMER { get; set; }
        [DataMember]
        public string SDRIGHTDIST { get; set; }
        [DataMember]
        public string SDRIGHTCONSUMER { get; set; }



        [DataMember]
        public string BVTOTLEFT { get; set; }
        [DataMember]
        public string BVTOTRIGHT { get; set; }
        [DataMember]
        public string BVLEFTDIST { get; set; }
        [DataMember]
        public string BVLEFTCONSUMER { get; set; }
        [DataMember]
        public string BVRIGHTDIST { get; set; }
        [DataMember]
        public string BVRIGHTCONSUMER { get; set; }

        [DataMember]
        public string CURRENTSESSION { get; set; }


        [DataMember]
        public string REGTOTLEFT { get; set; }
        [DataMember]
        public string REGTOTRIGHT { get; set; }
        [DataMember]
        public string REGLEFTDIST { get; set; }
        [DataMember]
        public string REGLEFTCONSUMER { get; set; }
        [DataMember]
        public string REGRIGHTDIST { get; set; }
        [DataMember]
        public string REGRIGHTCONSUMER { get; set; }


        [DataMember]
        public string SALESBVTOTLEFT { get; set; }
        [DataMember]
        public string SALESBVTOTRIGHT { get; set; }
        [DataMember]
        public string SALESBVLEFTDIST { get; set; }
        [DataMember]
        public string SALESBVLEFTCONSUMER { get; set; }
        [DataMember]
        public string SALESBVRIGHTDIST { get; set; }
        [DataMember]
        public string SALESBVRIGHTCONSUMER { get; set; }



        [DataMember]
        public string ACTIVEIDLEFT { get; set; }
        [DataMember]
        public string ACTIVEIDRIGHT { get; set; }
        [DataMember]
        public string SALEACTIVEBVLEFT { get; set; }
        [DataMember]
        public string SALEACTIVEBVRIGHT { get; set; }



    }


    [DataContract]
    public class SICPstatisticsOutput
    {

        [DataMember]
        public string MSG { get; set; }
        [DataMember]
        public string MESSAGE { get; set; }
        [DataMember]
        public string FIRSTPURTOTORDERS { get; set; }
        [DataMember]
        public string FIRSTPURTOTNOFACCCV { get; set; }
        [DataMember]
        public string REPURTOTORDERS { get; set; }
        [DataMember]
        public string REPURTOTNOFACCCV { get; set; }
        [DataMember]
        public string CURSESFIRSTPURTOTORDERS { get; set; }
        [DataMember]
        public string CURSESFIRSTPURTOTNOFACCCV { get; set; }
        [DataMember]
        public string CURSESREPURTOTORDERS { get; set; }
        [DataMember]
        public string CURSESREPURTOTNOFACCCV { get; set; }
        [DataMember]
        public string PAYNO { get; set; }
        [DataMember]
        public string SCHFROM { get; set; }
        [DataMember]
        public string SCHTO { get; set; }

    }



    [DataContract]
    public class SICPTabularRptOutput
    {
        [DataMember]
        public string LVL { get; set; }
        [DataMember]
        public string LVLSLNO { get; set; }
        [DataMember]
        public string SBOID { get; set; }
        [DataMember]
        public string NAME { get; set; }
        [DataMember]
        public string CITY { get; set; }
        [DataMember]
        public string DOR { get; set; }
        [DataMember]
        public string SPONSOR { get; set; }
        [DataMember]
        public string STATUS { get; set; }
        [DataMember]
        public string CV { get; set; }

    }




    [DataContract]
    public class SICPMonthwiseStatasticsRpt
    {

        [DataMember]
        public string MSG { get; set; }
        [DataMember]
        public string MESSAGE { get; set; }
        [DataMember]
        public List<CurMonRpt> CURMONTH = new List<CurMonRpt>();
        [DataMember]
        public List<PrevMonRptRpt> PREMONTH = new List<PrevMonRptRpt>();
    }

    [DataContract]
    public class CurMonRpt
    {
        [DataMember]
        public string MONTH { get; set; }
        [DataMember]
        public string SELF { get; set; }
        [DataMember]
        public string DOWNLINE { get; set; }
        [DataMember]
        public string TOTAL { get; set; }
    }
    [DataContract]
    public class PrevMonRptRpt
    {
        [DataMember]
        public string MONTH { get; set; }
        [DataMember]
        public string SELF { get; set; }
        [DataMember]
        public string DOWNLINE { get; set; }
        [DataMember]
        public string TOTAL { get; set; }
    }

    [DataContract]
    public class SSMPReportOutput
    {
        [DataMember]
        public string SESSIONID { get; set; }
        [DataMember]
        public string SCHDATES { get; set; }
        [DataMember]
        public string SSMPINCOME { get; set; }
        [DataMember]
        public string REWARDINC { get; set; }
        [DataMember]
        public string BOOSTERINC { get; set; }
        [DataMember]
        public string BOOSTERBONUS { get; set; }
        [DataMember]
        public string BRFWDAMT { get; set; }
        [DataMember]
        public string GROSSAMT { get; set; }
        [DataMember]
        public string TDS { get; set; }
        [DataMember]
        public string NETAMT { get; set; }

    }
    [DataContract]
    public class SSMPBinaryIncOutput
    {
        [DataMember]
        public string LINK2SESSIONID { get; set; }
        [DataMember]
        public string TSLNO { get; set; }
        [DataMember]
        public string TSRO { get; set; }
        [DataMember]
        public string NSLL { get; set; }
        [DataMember]
        public string NSLR { get; set; }
        [DataMember]
        public string TBVLO { get; set; }
        [DataMember]
        public string TBVRO { get; set; }
        [DataMember]
        public string NBVLL { get; set; }
        [DataMember]
        public string NBVLR { get; set; }
        [DataMember]
        public string GRBVLS { get; set; }
        [DataMember]
        public string GRBVRS { get; set; }
        [DataMember]
        public string SRBVLS { get; set; }
        [DataMember]
        public string SRBVRS { get; set; }
        [DataMember]
        public string BVCCL { get; set; }
        [DataMember]
        public string BVCCR { get; set; }
        [DataMember]
        public string BVCFL { get; set; }
        [DataMember]
        public string BVCFR { get; set; }

    }

    [DataContract]
    public class SICPMonthlyOutput
    {
        [DataMember]
        public string SESSIONID { get; set; }
        [DataMember]
        public string SCHDATES { get; set; }
        [DataMember]
        public string RANK { get; set; }
        [DataMember]
        public string AMOUNT { get; set; }
        [DataMember]
        public string SELFCV { get; set; }
        [DataMember]
        public string GROUPCV { get; set; }
        [DataMember]
        public string TOTALCV { get; set; }
        [DataMember]
        public string RETAILPROFIT { get; set; }
        [DataMember]
        public string RESIDUALBONUS { get; set; }
        [DataMember]
        public string LEVERAGEBONUS { get; set; }
        [DataMember]
        public string OVERRIDINGBONUS { get; set; }
        [DataMember]
        public string PERFOMANCEBONUS { get; set; }
        [DataMember]
        public string ARISTOFUND { get; set; }
        [DataMember]
        public string ROYALTYFUND { get; set; }
        [DataMember]
        public string TOTALPAYOUT { get; set; }
        [DataMember]
        public string BRFWDAMT { get; set; }
        [DataMember]
        public string GROSSAMT { get; set; }
        [DataMember]
        public string TDS { get; set; }
        [DataMember]
        public string NETAMT { get; set; }


    }


    [DataContract]
    public class PaynoOutput
    {
        [DataMember]
        public string PAYNO { get; set; }
        [DataMember]
        public string PAYNODATES { get; set; }

    }
    [DataContract]
    public class PaynoInput
    {
        [DataMember]
        public string PAYNOTYPE { get; set; }

    }

    [DataContract]
    public class HighestEarningsOutput
    {
        [DataMember]
        public string USERID { get; set; }
        [DataMember]
        public string NAME { get; set; }
        [DataMember]
        public string CITY { get; set; }
        [DataMember]
        public string MOBILE { get; set; }
        [DataMember]
        public string AMOUNT { get; set; }

    }



    [DataContract]
    public class SICPResidualOutput
    {
        [DataMember]
        public string USERID { get; set; }
        [DataMember]
        public string NAME { get; set; }
        [DataMember]
        public string INCOMELEVEL { get; set; }
        [DataMember]
        public string PHYSICALLVL { get; set; }
        [DataMember]
        public string CV { get; set; }
        [DataMember]
        public string INCOME { get; set; }
        [DataMember]
        public string APPPERCENTAGE { get; set; }

    }


    [DataContract]
    public class SICPLeverageBonusOutput
    {
        [DataMember]
        public string USERID { get; set; }
        [DataMember]
        public string NAME { get; set; }
        [DataMember]
        public string DESGNAME { get; set; }
        [DataMember]
        public string SPONSORID { get; set; }
        [DataMember]
        public string TOTALGCV { get; set; }
        [DataMember]
        public string CONSIDERGCV { get; set; }
        [DataMember]
        public string AMOUNT { get; set; }

    }



    [DataContract]
    public class SICPNewMonthlyOutput
    {
        [DataMember]
        public string SESSIONID { get; set; }
        [DataMember]
        public string RANK { get; set; }
        [DataMember]
        public string SELFCV { get; set; }
        [DataMember]
        public string DOWNLINECV { get; set; }
        [DataMember]
        public string GCV { get; set; }
        [DataMember]
        public string RETAILPROFIT { get; set; }
        [DataMember]
        public string LEVERAGEBONUS { get; set; }
        [DataMember]
        public string MONTHLYRETAILSTARTBONUS { get; set; }
        [DataMember]
        public string POWERPOOLBONUS { get; set; }
        [DataMember]
        public string K25MATCHINGBONUS { get; set; }
        [DataMember]
        public string LEADERSHIPBONUS { get; set; }
        [DataMember]
        public string ROYALTYPERKS { get; set; }
        [DataMember]
        public string TOTALINC { get; set; }
        [DataMember]
        public string BFAMT { get; set; }
        [DataMember]
        public string GROSSAMT { get; set; }
        [DataMember]
        public string TDS { get; set; }
        [DataMember]
        public string NETAMT { get; set; }


    }


    [DataContract]
    public class SICPMonRetailsStarOutput
    {
        [DataMember]
        public string PAYNO { get; set; }
        [DataMember]
        public string SELFCV { get; set; }
        [DataMember]
        public string NOFUNITS { get; set; }
        [DataMember]
        public string AMT { get; set; }
    }



    [DataContract]
    public class SICPLeadershipBonusOutput
    {
        [DataMember]
        public string SESSIONID { get; set; }
        [DataMember]
        public string SBOID { get; set; }
        [DataMember]
        public string NAME { get; set; }
        [DataMember]
        public string CONLVL { get; set; }
        [DataMember]
        public string ACTLVL { get; set; }
        [DataMember]
        public string EXCLUSIVELVL { get; set; }
        [DataMember]
        public string APPPERCENTAGE { get; set; }
        [DataMember]
        public string INCOME { get; set; }

    }


    [DataContract]
    public class SICPRoyaltyperksOutput
    {
        [DataMember]
        public string PAYNO { get; set; }
        [DataMember]
        public string INCTYPE { get; set; }
        [DataMember]
        public string LOYALINC { get; set; }
        [DataMember]
        public string APPLICABLEPER { get; set; }
        [DataMember]
        public string AMT { get; set; }


    }



    [DataContract]
    public class SICPMatchingBounsOutput
    {
        [DataMember]
        public string PAYNO { get; set; }
        [DataMember]
        public string UNITVAL { get; set; }
        [DataMember]
        public string NOUNITS { get; set; }
        [DataMember]
        public string AMT { get; set; }


    }


    [DataContract]
    public class SSMPRewardOutput
    {
        [DataMember]
        public string MSG { get; set; }
        [DataMember]
        public string MESSAGE { get; set; }
        [DataMember]
        public string RESULT { get; set; }
        [DataMember]
        public string DESGRESULT { get; set; }

        /*[DataMember]
        public string NAME { get; set; }
        [DataMember]
        public List<RewardRpt> REWARDDATA = new List<RewardRpt>();
        */

        [DataMember]
        public string RESTYPE { get; set; }
        [DataMember]
        public string IDNO { get; set; }
        [DataMember]
        public string NAME { get; set; }
        [DataMember]
        public string DATEOFREG { get; set; }
        [DataMember]
        public string RANK { get; set; }
        [DataMember]
        public string STARTDATE { get; set; }
        [DataMember]
        public string ENDDATE { get; set; }
        [DataMember]
        public string TOTALDAYS { get; set; }
        [DataMember]
        public string DAYSLEFT { get; set; }
        [DataMember]
        public string TOTALSALESLEFT { get; set; }
        [DataMember]
        public string TOTALSALESRIGHT { get; set; }
        [DataMember]
        public string ACCSALESBVLEFT { get; set; }
        [DataMember]
        public string ACCSALESBVRIGHT { get; set; }
        [DataMember]
        public string INACTIVESALESLEFT { get; set; }
        [DataMember]
        public string INACTIVESALESRIGHT { get; set; }
        [DataMember]
        public string ACTIVESALESLEFT { get; set; }
        [DataMember]
        public string ACTIVESALESRIGHT { get; set; }
        [DataMember]
        public string DEACTIVELEFT { get; set; }
        [DataMember]
        public string DEACTIVERIGHT { get; set; }
        [DataMember]
        public string AASBVLEFT { get; set; }
        [DataMember]
        public string AASBVRIGHT { get; set; }
        [DataMember]
        public string TARGETBVLEFT { get; set; }
        [DataMember]
        public string TARGETBVRIGHT { get; set; }
        [DataMember]
        public string REQUIREDBVLEFT { get; set; }
        [DataMember]
        public string REQUIREDBVRIGHT { get; set; }
        [DataMember]
        public string STATUS { get; set; }

    }
    /*
         [DataContract]
         public class RewardRpt
         {
             [DataMember]
             public string IDNO { get; set; }
             [DataMember]
             public string NAME { get; set; }
             [DataMember]
             public string DATEOFREG { get; set; }
             [DataMember]
             public string RANK { get; set; }
             [DataMember]
             public string STARTDATE { get; set; }
             [DataMember]
             public string ENDDATE { get; set; }
             [DataMember]
             public string TOTALDAYS { get; set; }
             [DataMember]
             public string DAYSLEFT { get; set; }
             [DataMember]
             public string TOTALSALESLEFT { get; set; }
             [DataMember]
             public string TOTALSALESRIGHT { get; set; }
             [DataMember]
             public string ACCSALESBVLEFT { get; set; }
             [DataMember]
             public string ACCSALESBVRIGHT { get; set; }
             [DataMember]
             public string INACTIVESALESLEFT { get; set; }
             [DataMember]
             public string INACTIVESALESRIGHT { get; set; }
             [DataMember]
             public string ACTIVESALESLEFT { get; set; }
             [DataMember]
             public string ACTIVESALESRIGHT { get; set; }
             [DataMember]
             public string DEACTIVELEFT { get; set; }
             [DataMember]
             public string DEACTIVERIGHT { get; set; }
             [DataMember]
             public string AASBVLEFT { get; set; }
             [DataMember]
             public string AASBVRIGHT { get; set; }
             [DataMember]
             public string TARGETBVLEFT { get; set; }
             [DataMember]
             public string TARGETBVRIGHT { get; set; }
             [DataMember]
             public string REQUIREDBVLEFT { get; set; }
             [DataMember]
             public string REQUIREDBVRIGHT { get; set; }
             [DataMember]
             public string STATUS { get; set; }
         }

    */
    [DataContract]
    public class SCMPOnline
    {
        [DataMember]
        public string ACTION { get; set; }
        [DataMember]
        public string REGID { get; set; }
        [DataMember]
        public string MOBILE { get; set; }
        [DataMember]
        public string ORDER_ID { get; set; }
        [DataMember]
        public string PAYMENTSTATUS { get; set; }
        [DataMember]
        public string BILLSTATUS { get; set; }
        [DataMember]
        public string TXNID { get; set; }
        [DataMember]
        public string BillNo { get; set; }
        [DataMember]
        public string PGTYPE { get; set; }
        [DataMember]
        public string SHOPCHARGE { get; set; }
        [DataMember]
        public string SCMEMTYPE { get; set; }
        [DataMember]
        public string COUPON { get; set; }
        [DataMember]
        public string AMOUNT { get; set; }
    }
    [DataContract]
    public class CreditRequest
    {
        [DataMember]
        public string action { get; set; }
        [DataMember]
        public string REGID { get; set; }
        [DataMember]
        public string reqAmt { get; set; }
        [DataMember]
        public string mop { get; set; }
        [DataMember]
        public string refno { get; set; }
        [DataMember]
        public DateTime invdate { get; set; }
        [DataMember]
        public string invbank { get; set; }
        [DataMember]
        public string invbranch { get; set; }
        [DataMember]
        public string depbank { get; set; }
        [DataMember]
        public string depbranch { get; set; }
        [DataMember]
        public string depcity { get; set; }
        [DataMember]
        public DateTime depdate { get; set; }
        [DataMember]
        public string depslip { get; set; }
        [DataMember]
        public string remarks { get; set; }
        [DataMember]
        public string ORDER_ID { get; set; }
        [DataMember]
        public string PaymentStatus { get; set; }
        [DataMember]
        public string BillStatus { get; set; }
        [DataMember]
        public string TXNID { get; set; }
        [DataMember]
        public string Recode { get; set; }
        [DataMember]
        public string pgtype { get; set; }
        

    }
    [DataContract]
    public class TempOrderRequest
    {
        [DataMember]
        public string UNQId { get; set; }
        [DataMember]
        public string regid { get; set; }
        [DataMember]
        public string downlineid { get; set; }
        [DataMember]
        public string mop { get; set; }
        [DataMember]
        public string mopamt { get; set; }
        [DataMember]
        public string Fname { get; set; }
        [DataMember]
        public string LName { get; set; }
        [DataMember]
        public string Mobile { get; set; }
        [DataMember]
        public string Address { get; set; }
        [DataMember]
        public string City { get; set; }
        [DataMember]
        public string District { get; set; }
        [DataMember]
        public string state { get; set; }
        [DataMember]
        public string PiCode { get; set; }
    }

    public class ExecuteFunction
    {
        private string strConnection = ConfigurationManager.ConnectionStrings["MobileAppConn"].ConnectionString;
        // Encryption and Decription
        public RijndaelManaged GetRijndaelManaged(String secretKey)
        {
            var keyBytes = new byte[16];
            var secretKeyBytes = Encoding.UTF8.GetBytes(secretKey);
            Array.Copy(secretKeyBytes, keyBytes, Math.Min(keyBytes.Length, secretKeyBytes.Length));
            return new RijndaelManaged
            {
                Mode = CipherMode.CBC,
                Padding = PaddingMode.PKCS7,
                KeySize = 128,
                BlockSize = 128,
                Key = keyBytes,
                IV = keyBytes
            };
        }

        public byte[] Encrypt(byte[] plainBytes, RijndaelManaged rijndaelManaged)
        {
            return rijndaelManaged.CreateEncryptor()
                                  .TransformFinalBlock(plainBytes, 0, plainBytes.Length);
        }

        public byte[] Decrypt(byte[] encryptedData, RijndaelManaged rijndaelManaged)
        {
            return rijndaelManaged.CreateDecryptor()
                                  .TransformFinalBlock(encryptedData, 0, encryptedData.Length);
        }

        public String Encrypt(String plainText, String key)
        {
            var plainBytes = Encoding.UTF8.GetBytes(plainText);
            return Convert.ToBase64String(Encrypt(plainBytes, GetRijndaelManaged(key)));
        }

        public String Decrypt(String encryptedText)
        {

            var keyext = DateTime.Now.Year.ToString(CultureInfo.InvariantCulture).Substring(0, 2) + DateTime.Now.Month.ToString("d2") + DateTime.Now.Day.ToString("d2") + DateTime.Now.Year.ToString(CultureInfo.InvariantCulture).Substring(2, 2);
            var encryptedBytes = Convert.FromBase64String(encryptedText);
            //  keyext = "";
            return Encoding.UTF8.GetString(Decrypt(encryptedBytes, GetRijndaelManaged(keyext + ConfigurationManager.AppSettings["EncriptionKey"]))); // Sending Key
        }

        public string Decryption(string cipherString)
        {
            try
            {
                cipherString = cipherString.Replace(' ', '+');
                byte[] keyArray;
                byte[] toEncryptArray = Convert.FromBase64String(cipherString);
                var settingsReader = new AppSettingsReader();
                var key = (string)settingsReader.GetValue("SARSO", typeof(String));
                {
                    var hashmd5 = new MD5CryptoServiceProvider();
                    keyArray = hashmd5.ComputeHash(Encoding.UTF8.GetBytes(key));
                    hashmd5.Clear();
                }
                var tdes = new TripleDESCryptoServiceProvider
                {
                    Key = keyArray,
                    Mode = CipherMode.ECB,
                    Padding = PaddingMode.PKCS7
                };
                var cTransform = tdes.CreateDecryptor();
                byte[] resultArray = cTransform.TransformFinalBlock(
                    toEncryptArray, 0, toEncryptArray.Length);
                tdes.Clear();
                return Encoding.UTF8.GetString(resultArray);
            }
            catch (Exception ex)
            {
                return "";
            }
        }
        public string Encrypt(string toEncrypt)
        {
            byte[] keyArray;
            byte[] toEncryptArray = Encoding.UTF8.GetBytes(toEncrypt);
            var settingsReader = new AppSettingsReader();
            var key = (string)settingsReader.GetValue("SARSO", typeof(String));
            {
                var hashmd5 = new MD5CryptoServiceProvider();
                keyArray = hashmd5.ComputeHash(Encoding.UTF8.GetBytes(key));
                hashmd5.Clear();
            }
            var tdes = new TripleDESCryptoServiceProvider
            {
                Key = keyArray,
                Mode = CipherMode.ECB,
                Padding = PaddingMode.PKCS7
            };
            var cTransform = tdes.CreateEncryptor();
            byte[] resultArray =
              cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);
            tdes.Clear();
            return Convert.ToBase64String(resultArray, 0, resultArray.Length);
        }

        public DataSet LoginStatus(CredentialInfo cInfo)
        {
            SqlParameter[] objParam = new SqlParameter[8];
            objParam[0] = new SqlParameter("@idno", cInfo.IDNO);
            objParam[1] = new SqlParameter("@pwd", Encrypt(cInfo.PWD));
            objParam[2] = new SqlParameter("@ANDROIDID", cInfo.ANDROIDID);
            objParam[3] = new SqlParameter("@WLANMAC", cInfo.WLANMAC);
            objParam[4] = new SqlParameter("@GCMID", cInfo.GCMID);
            objParam[5] = new SqlParameter("@IMEI", cInfo.IMEI);
            objParam[6] = new SqlParameter("@MOBINFO", cInfo.MOBINFO);
            objParam[7] = new SqlParameter("@VERSION", cInfo.VERSION);
            DataSet ds = SqlHelper.ExecuteDataset(strConnection, CommandType.StoredProcedure, "MA_LoginStatus_SP", objParam);
            return ds;
        }

        public DataTable getDashboardSummary(MemberIDPWD param)
        {
            SqlParameter[] objParam = new SqlParameter[2];
            objParam[0] = new SqlParameter("@idno", param.IDNO);
            objParam[1] = new SqlParameter("@pwd", Encrypt(param.PWD));
            DataSet ds = SqlHelper.ExecuteDataset(strConnection, CommandType.StoredProcedure, "MA_DashBoard_SP", objParam);
            return ds.Tables[0];
        }

        public DataTable getDashboardSSMPDetails(MemberIDPWD param)
        {
            SqlParameter[] objParam = new SqlParameter[2];
            objParam[0] = new SqlParameter("@IDNO", param.IDNO);
            objParam[1] = new SqlParameter("@PWD", Encrypt(param.PWD));
            DataSet ds = SqlHelper.ExecuteDataset(strConnection, CommandType.StoredProcedure, "MA_SSMPDetails_SP", objParam);
            return ds.Tables[0];
        }

        public DataTable getDashboardSICPDetails(MemberIDPWD param)
        {
            SqlParameter[] objParam = new SqlParameter[2];
            objParam[0] = new SqlParameter("@IDNO", param.IDNO);
            objParam[1] = new SqlParameter("@PWD", Encrypt(param.PWD));
            DataSet ds = SqlHelper.ExecuteDataset(strConnection, CommandType.StoredProcedure, "MA_SICPDetails_SP", objParam);
            return ds.Tables[0];
        }
        public DataTable getDesgIncomeDetails(MemberIDPWD param)
        {
            SqlParameter[] objParam = new SqlParameter[2];
            objParam[0] = new SqlParameter("@IDNO", param.IDNO);
            objParam[1] = new SqlParameter("@PWD", Encrypt(param.PWD));
            DataSet ds = SqlHelper.ExecuteDataset(strConnection, CommandType.StoredProcedure, "MA_DesgIncomeDetails_SP", objParam);
            return ds.Tables[0];
        }

        public DataSet geteWalletRptData(MemberIDPWD param)
        {
            SqlParameter[] objParam = new SqlParameter[2];
            objParam[0] = new SqlParameter("@IDNO", param.IDNO);
            objParam[1] = new SqlParameter("@PWD", Encrypt(param.PWD));
            DataSet ds = SqlHelper.ExecuteDataset(strConnection, CommandType.StoredProcedure, "MA_EwalletRpt_SP", objParam);
            return ds;
        }
        public DataTable getSponsorRptData(MemberIDPWD param)
        {
            SqlParameter[] objParam = new SqlParameter[2];
            objParam[0] = new SqlParameter("@IDNO", param.IDNO);
            objParam[1] = new SqlParameter("@PWD", Encrypt(param.PWD));
            DataSet ds = SqlHelper.ExecuteDataset(strConnection, CommandType.StoredProcedure, "MA_SponsorDetails_SP", objParam);
            return ds.Tables[0];
        }
        public DataTable getSSMPTreeviewData(TreeviewInput param)
        {
            SqlParameter[] objParam = new SqlParameter[4];
            objParam[0] = new SqlParameter("@idno", param.IDNO);
            objParam[1] = new SqlParameter("@pwd", Encrypt(param.PWD));
            objParam[2] = new SqlParameter("@TreeViewId", param.TVIEWIDNO);
            objParam[3] = new SqlParameter("@Leg", param.LEG);
            DataSet ds = SqlHelper.ExecuteDataset(strConnection, CommandType.StoredProcedure, "MA_SSMPGenealogyTreeview_SP", objParam);
            return ds.Tables[0];
        }

        public DataTable getSSMPTreeviewToolTipData(TreeviewInput param)
        {
            SqlParameter[] objParam = new SqlParameter[3];
            objParam[0] = new SqlParameter("@idno", param.IDNO);
            objParam[1] = new SqlParameter("@pwd", Encrypt(param.PWD));
            objParam[2] = new SqlParameter("@TreeViewId", param.TVIEWIDNO);
            DataSet ds = SqlHelper.ExecuteDataset(strConnection, CommandType.StoredProcedure, "MA_SSMPGenealogy_SP", objParam);
            return ds.Tables[0];
        }


        public DataTable getSICPTreeviewData(TreeviewInput param)
        {
            SqlParameter[] objParam = new SqlParameter[3];
            objParam[0] = new SqlParameter("@idno", param.IDNO);
            objParam[1] = new SqlParameter("@pwd", Encrypt(param.PWD));
            objParam[2] = new SqlParameter("@TreeViewId", param.TVIEWIDNO);
            DataSet ds = SqlHelper.ExecuteDataset(strConnection, CommandType.StoredProcedure, "MA_SICPGenealogyTreeview_SP", objParam);
            return ds.Tables[0];
        }

        public DataTable getSICPTreeviewToolTipData(TreeviewInput param)
        {
            SqlParameter[] objParam = new SqlParameter[3];
            objParam[0] = new SqlParameter("@idno", param.IDNO);
            objParam[1] = new SqlParameter("@pwd", Encrypt(param.PWD));
            objParam[2] = new SqlParameter("@TreeViewId", param.TVIEWIDNO);
            DataSet ds = SqlHelper.ExecuteDataset(strConnection, CommandType.StoredProcedure, "MA_SICPGenealogyTooltip_SP", objParam);
            return ds.Tables[0];
        }

        public DataSet getNotification(MemberIDPWD param)
        {
            SqlParameter[] objParam = new SqlParameter[2];
            objParam[0] = new SqlParameter("@idno", param.IDNO);
            objParam[1] = new SqlParameter("@pwd", Encrypt(param.PWD));
            DataSet ds = SqlHelper.ExecuteDataset(strConnection, CommandType.StoredProcedure, "MA_GetNotification_SP", objParam);
            return ds;
        }


        public string getStatusAddNotification(NotificationsParam param)
        {
            SqlParameter[] objParam = new SqlParameter[6];
            objParam[0] = new SqlParameter("@idno", param.IDNO);
            objParam[1] = new SqlParameter("@pwd", Encrypt(param.PWD));
            objParam[2] = new SqlParameter("@REGISTRATION", param.REGISTRATION);
            objParam[3] = new SqlParameter("@EWALLTREQUEST", param.EWALLTREQUEST);
            objParam[4] = new SqlParameter("@FORGOTPWD", param.FORGOTPWD);
            objParam[5] = new SqlParameter("@COMPNYNOTIFY", param.COMPNYNOTIFY);
            string strResult = SqlHelper.ExecuteScalar(strConnection, CommandType.StoredProcedure, "MA_AddNotification_SP", objParam).ToString();
            return strResult;
        }

        public DataTable EwalCreditReqTpwdChecking(CreditReqTpwdInput param)
        {
            SqlParameter[] objParam = new SqlParameter[3];
            objParam[0] = new SqlParameter("@IDNO", param.IDNO);
            objParam[1] = new SqlParameter("@PWD", Encrypt(param.PWD));
            objParam[2] = new SqlParameter("@TPWD", Encrypt(param.TRAPWD));
            DataSet ds = SqlHelper.ExecuteDataset(strConnection, CommandType.StoredProcedure, "MA_CrdReqTraPwdChk_SP", objParam);
            return ds.Tables[0];
        }
        public DataSet CheckSICPRanksList(MemberIDPWD param)
        {
            SqlParameter[] objParam = new SqlParameter[2];
            objParam[0] = new SqlParameter("@IDNO", param.IDNO);
            objParam[1] = new SqlParameter("@PWD", Encrypt(param.PWD));
            DataSet ds = SqlHelper.ExecuteDataset(strConnection, CommandType.StoredProcedure, "MA_CheckSICPRank_SP", objParam);
            return ds;
        }

        public int ShootNotification(string gcmid, string sub, string msg, string img, string url)
        {
            SqlParameter[] objParam = new SqlParameter[5];
            objParam[0] = new SqlParameter("@gcmid", gcmid);
            objParam[1] = new SqlParameter("@sentMsg", msg);
            objParam[2] = new SqlParameter("@subject", sub);
            objParam[3] = new SqlParameter("@link", url);
            objParam[4] = new SqlParameter("@image", img);
            return SqlHelper.ExecuteNonQuery(strConnection, CommandType.StoredProcedure, "MA_SendNotification_SP", objParam);
        }

        public DataSet GetUserDetails(MemberIDPWD param)
        {
            SqlParameter[] objParam = new SqlParameter[1];
            objParam[0] = new SqlParameter("@idno", param.IDNO);
            DataSet ds = SqlHelper.ExecuteDataset(strConnection, CommandType.StoredProcedure, "MA_ForgotPwd_SP", objParam);
            return ds;
        }

        public int SmsThroughGateWay(string mobiles, string message)
        {
            try
            {
                // Mobiles = "91" + Mobiles;
                //we creating the necessary URL string:
                string OzSurl = "http://mysms.versatileitsolution.com/submitsms.jsp?"; //where Ozeki NG SMS Gateway is running
                //string ozSPort = "9501"; //port number where Ozeki NG SMS Gateway is listening
                string Username = "SarsoTrn"; //username for successful login
                string Password = "ce41381891XX";
                string Sender = "SARSOB";
                string To = mobiles;
                string Unicodes = "1";

                string CreatedUrl = OzSurl +
                             "user=" + Username +
                             "&key=" + Password +
                             "&senderid=" + Sender +
                             "&mobile=" + To +
                             "&message=" + message +
                             "&accusage=" + Unicodes;

                //Create the request and send data to SMS Gateway Server by HTTP connection
                var myReq = (HttpWebRequest)WebRequest.Create(CreatedUrl);

                ////Get response from Ozeki NG SMS Gateway Server and read the answer
                var myResp = (HttpWebResponse)myReq.GetResponse();
                var respStreamReader = new System.IO.StreamReader(myResp.GetResponseStream());
                // var responseString = respStreamReader.ReadToEnd();
                respStreamReader.Close();
                myResp.Close();
                return 1;
            }
            catch (Exception)
            {

                return 0;
            }

        }


        public int insertsmslog(Int64 regid, string mobile, DateTime senddate, string message, string action, string sessid, string SMSType)
        {
            try
            {
                SqlParameter[] objParam = new SqlParameter[7];
                objParam[0] = new SqlParameter("@regid", regid);
                objParam[1] = new SqlParameter("@mobile", mobile);
                objParam[2] = new SqlParameter("@senddate", senddate);
                objParam[3] = new SqlParameter("@msg", message);
                objParam[4] = new SqlParameter("@action", action);
                objParam[5] = new SqlParameter("@sessid", sessid);
                objParam[6] = new SqlParameter("@SMSType", SMSType);
                return SqlHelper.ExecuteNonQuery(strConnection, CommandType.StoredProcedure, "insertsmslog_Sp", objParam);

            }
            catch (Exception)
            {

                return 0;
            }

        }


        public DataSet getSICPProductsData(GetprodcutsInput param)
        {
            SqlParameter[] objParam = new SqlParameter[7];
            objParam[0] = new SqlParameter("@idno", param.IDNO);
            objParam[1] = new SqlParameter("@pwd", Encrypt(param.PWD));
            objParam[2] = new SqlParameter("@category", param.CATEGORY);
            objParam[3] = new SqlParameter("@Subcategory", param.SUBCAT);
            objParam[4] = new SqlParameter("@SubCategoryone", param.SUBCATONE);
            objParam[5] = new SqlParameter("@orderidno", param.ORDERIDNO);
            objParam[6] = new SqlParameter("@search", param.SEARCH);
            DataSet ds = SqlHelper.ExecuteDataset(strConnection, CommandType.StoredProcedure, "MA_ProductsDetails_SP", objParam);
            return ds;
            //Test_RePurchageProductRpt_Sp
        }

        public DataTable getProductCategories(MemberIDPWD param)
        {
            SqlParameter[] objParam = new SqlParameter[2];
            objParam[0] = new SqlParameter("@IDNO", param.IDNO);
            objParam[1] = new SqlParameter("@PWD", Encrypt(param.PWD));
            DataSet ds = SqlHelper.ExecuteDataset(strConnection, CommandType.StoredProcedure, "MA_Categories_SP", objParam);
            return ds.Tables[0];
        }


        public DataTable BusinessSummaryRpt(MemberIDPWD param)
        {
            SqlParameter[] objParam = new SqlParameter[2];
            objParam[0] = new SqlParameter("@IDNO", param.IDNO);
            objParam[1] = new SqlParameter("@PWD", Encrypt(param.PWD));
            DataSet ds = SqlHelper.ExecuteDataset(strConnection, CommandType.StoredProcedure, "MA_BusinessSummary_SP", objParam);
            return ds.Tables[0];
        }
        public DataTable getProductSubCategories(SubCatInput param)
        {
            SqlParameter[] objParam = new SqlParameter[3];
            objParam[0] = new SqlParameter("@IDNO", param.IDNO);
            objParam[1] = new SqlParameter("@PWD", Encrypt(param.PWD));
            objParam[2] = new SqlParameter("@category", param.CATEGORY);
            DataSet ds = SqlHelper.ExecuteDataset(strConnection, CommandType.StoredProcedure, "MA_SubCategories_SP", objParam);
            return ds.Tables[0];
        }

        public DataTable getProductSubCategoriesOne(SubCatOneInput param)
        {
            SqlParameter[] objParam = new SqlParameter[4];
            objParam[0] = new SqlParameter("@IDNO", param.IDNO);
            objParam[1] = new SqlParameter("@PWD", Encrypt(param.PWD));
            objParam[2] = new SqlParameter("@category", param.CATEGORY);
            objParam[3] = new SqlParameter("@category1", param.SUBCATEGORY);
            DataSet ds = SqlHelper.ExecuteDataset(strConnection, CommandType.StoredProcedure, "MA_SubCategoriesOne_SP", objParam);
            return ds.Tables[0];
        }


        public DataSet GetProductAttributes(GetprodcutAttributesInput param)
        {
            SqlParameter[] objParam = new SqlParameter[3];
            objParam[0] = new SqlParameter("@IDNO", param.IDNO);
            objParam[1] = new SqlParameter("@PWD", Encrypt(param.PWD));
            objParam[2] = new SqlParameter("@PCode", int.Parse(param.PID));
            DataSet ds = SqlHelper.ExecuteDataset(strConnection, CommandType.StoredProcedure, "MA_GetAttributes_SP", objParam);
            return ds;
        }

        public DataSet GetLoyalryReport(LoyaltyReportInput param)
        {
            SqlParameter[] objParam = new SqlParameter[4];
            objParam[0] = new SqlParameter("@idno", param.IDNO);
            objParam[1] = new SqlParameter("@pwd", Encrypt(param.PWD));
            objParam[2] = new SqlParameter("@month", param.MONTH);
            objParam[3] = new SqlParameter("@year", param.YEAR);
            DataSet ds = SqlHelper.ExecuteDataset(strConnection, CommandType.StoredProcedure, "MA_LoyaltyRank_SP", objParam);
            return ds;
        }

        public DataSet GetClickandShareList(MemberIDPWD param)
        {
            SqlParameter[] objParam = new SqlParameter[2];
            objParam[0] = new SqlParameter("@idno", param.IDNO);
            objParam[1] = new SqlParameter("@pwd", Encrypt(param.PWD));
            DataSet ds = SqlHelper.ExecuteDataset(strConnection, CommandType.StoredProcedure, "MA_ClickandShare_SP", objParam);
            return ds;
        }


        public DataTable GetItemCodeResult(ItemCodeInput param)
        {
            SqlParameter[] objParam = new SqlParameter[3];

            objParam[0] = new SqlParameter("@PCode", param.PCODE);
            objParam[1] = new SqlParameter("@fields", param.ATTRIBUTES);
            objParam[2] = new SqlParameter("@qty", param.QTY);

            DataSet ds = SqlHelper.ExecuteDataset(strConnection, CommandType.StoredProcedure, "MA_GetItemCodesFromAttributes_Sp", objParam);
            return ds.Tables[0];
        }

        public DataSet AddDeleteProductsCart(AddDeleteproductInPut param)
        {
            SqlParameter[] objParam = new SqlParameter[8];

            objParam[0] = new SqlParameter("@Idno", param.IDNO);
            objParam[1] = new SqlParameter("@pwd", Encrypt(param.PWD));
            objParam[2] = new SqlParameter("@UNQId", param.UNIQUEID);
            objParam[3] = new SqlParameter("@Pcode", param.PCODE);
            objParam[4] = new SqlParameter("@Qty", param.QTY);
            objParam[5] = new SqlParameter("@Attribute", param.ATTRIBUTES);
            objParam[6] = new SqlParameter("@ItemCode", param.ITEMCODE);
            objParam[7] = new SqlParameter("@Action", param.ACTION);
            DataSet ds = SqlHelper.ExecuteDataset(strConnection, CommandType.StoredProcedure, "Ma_AddDeleteProduct_Sp", objParam);
            return ds;
        }

        public DataSet getShippingInfo(ShippingInfoInput param)
        {
            SqlParameter[] objParam = new SqlParameter[3];
            objParam[0] = new SqlParameter("@idno", param.IDNO);
            objParam[1] = new SqlParameter("@pwd", Encrypt(param.PWD));
            objParam[2] = new SqlParameter("@orderidno", param.ORDERIDNO);
            DataSet ds = SqlHelper.ExecuteDataset(strConnection, CommandType.StoredProcedure, "MA_MemberDetailes_sp", objParam);
            return ds;
        }

        public DataSet getOrderInfoTotals(OrderInfoTotalsInput param)
        {
            SqlParameter[] objParam = new SqlParameter[5];
            objParam[0] = new SqlParameter("@idno", param.IDNO);
            objParam[1] = new SqlParameter("@pwd", Encrypt(param.PWD));
            objParam[2] = new SqlParameter("@Tpwd", Encrypt(param.TRANSPWD));
            objParam[3] = new SqlParameter("@UNQId", param.UNIQUEID);
            objParam[4] = new SqlParameter("@orderidno", param.ORDERIDNO);
            DataSet ds = SqlHelper.ExecuteDataset(strConnection, CommandType.StoredProcedure, "MA_CheckTrans_SP", objParam);
            return ds;
        }


        public DataSet PostFinalOrder(FinalOrderInPut param)
        {
            SqlParameter[] objParam = new SqlParameter[19];
            objParam[0] = new SqlParameter("@UNQid", param.UNIQUEID);
            objParam[1] = new SqlParameter("@Idno", param.IDNO);
            objParam[2] = new SqlParameter("@pwd", Encrypt(param.PWD));
            objParam[3] = new SqlParameter("@downlineid", param.DOWNLOADID);
            objParam[4] = new SqlParameter("@mop", param.MOP);
            objParam[5] = new SqlParameter("@mopamt", param.MOPAMT);
            objParam[6] = new SqlParameter("@Fname", param.FNAME);
            objParam[7] = new SqlParameter("@LName", param.LNAME);
            objParam[8] = new SqlParameter("@Mobile", param.MOBILE);
            objParam[9] = new SqlParameter("@Address", param.ADDRESS);
            objParam[10] = new SqlParameter("@City", param.CITY);
            objParam[11] = new SqlParameter("@District", param.DISTRICT);
            objParam[12] = new SqlParameter("@state", param.STATE);
            objParam[13] = new SqlParameter("@PiCode", param.PINCODE);
            objParam[14] = new SqlParameter("@Ordertype", param.ORDERTYPE);
            objParam[15] = new SqlParameter("@shpchrg", param.SHPCHRG);
            objParam[16] = new SqlParameter("@scmemtype", param.SCMEMTYPE);
            objParam[17] = new SqlParameter("@sesid", "");
            objParam[18] = new SqlParameter("@ipadd", "");
            DataSet ds = SqlHelper.ExecuteDataset(strConnection, CommandType.StoredProcedure, "MA_SCOrder_SP", objParam);
            return ds;
        }


        public DataTable RegSponsorChecking(RegSponsorInput param)
        {
            SqlParameter[] objParam = new SqlParameter[3];

            objParam[0] = new SqlParameter("@idno", param.IDNO);
            objParam[1] = new SqlParameter("@pwd", Encrypt(param.PWD));
            objParam[2] = new SqlParameter("@Downto", param.SPONSORIDNO);
            DataSet ds = SqlHelper.ExecuteDataset(strConnection, CommandType.StoredProcedure, "MA_CheckSpr", objParam);
            return ds.Tables[0];
        }
        public DataTable RegSponsorCheck(RegSponsor param)
        {
            SqlParameter[] objParam = new SqlParameter[1];
            objParam[0] = new SqlParameter("@Downto", param.SPONSORIDNO);
            DataSet ds = SqlHelper.ExecuteDataset(strConnection, CommandType.StoredProcedure, "MA_CheckSponser", objParam);
            return ds.Tables[0];
        }
        public DataTable Registration(RegInput param)
        {
            SqlParameter[] objParam = new SqlParameter[26];
            objParam[0] = new SqlParameter("@idno", param.IDNO);
            objParam[1] = new SqlParameter("@pwd", Encrypt(param.PWD));
            objParam[2] = new SqlParameter("@sprid", param.SPONSOR);
            objParam[3] = new SqlParameter("@spseries", param.PLACEMENT);
            objParam[4] = new SqlParameter("@Title", param.TITLE);
            objParam[5] = new SqlParameter("@sex", -1);
            objParam[6] = new SqlParameter("@fname", param.FNAME);
            objParam[7] = new SqlParameter("@lname", param.LNAME);
            objParam[8] = new SqlParameter("@mobile", param.MOBILE);
            objParam[9] = new SqlParameter("@eMail", param.EMAIL);
            objParam[10] = new SqlParameter("@userno", param.USERNAME);
            objParam[11] = new SqlParameter("@lpassword", Encrypt(param.LPWD));
            objParam[12] = new SqlParameter("@tpassword", Encrypt(param.TPWD));
            objParam[13] = new SqlParameter("@Decpwd", param.LPWD);
            objParam[14] = new SqlParameter("@state", "");
            objParam[15] = new SqlParameter("@sesid", "");
            objParam[16] = new SqlParameter("@CorrAdds", param.CorrAdds);
            objParam[17] = new SqlParameter("@PerAdds", param.PerAdds);
            objParam[18] = new SqlParameter("@CorrCity", param.CorrCity);
            objParam[19] = new SqlParameter("@PerCity", param.PerCity);
            objParam[20] = new SqlParameter("@CorrDistrict", param.CorrDistrict);
            objParam[21] = new SqlParameter("@perDistrict", param.PerDistrict);
            objParam[22] = new SqlParameter("@Corrddlstate", param.Corrddlstate);
            objParam[23] = new SqlParameter("@perddlstate", param.Perddlstate);
            objParam[24] = new SqlParameter("@CorrPINCode", param.CorrPINCode);
            objParam[25] = new SqlParameter("@PerPINCode", param.PerPINCode);
            DataSet ds = SqlHelper.ExecuteDataset(strConnection, CommandType.StoredProcedure, "MA_InsertGuestReg_Sp", objParam);
            return ds.Tables[0];
        }
        public DataTable OuterRegistration(RegInput param)
        {
            SqlParameter[] objParam = new SqlParameter[25];
            objParam[0] = new SqlParameter("@idno", param.IDNO);
            objParam[1] = new SqlParameter("@sprid", param.SPONSOR);
            objParam[2] = new SqlParameter("@spseries", param.PLACEMENT);
            objParam[3] = new SqlParameter("@Title", param.TITLE);
            objParam[4] = new SqlParameter("@sex", -1);
            objParam[5] = new SqlParameter("@fname", param.FNAME);
            objParam[6] = new SqlParameter("@lname", param.LNAME);
            objParam[7] = new SqlParameter("@mobile", param.MOBILE);
            objParam[8] = new SqlParameter("@eMail", param.EMAIL);
            objParam[9] = new SqlParameter("@userno", param.USERNAME);
            objParam[10] = new SqlParameter("@lpassword", Encrypt(param.LPWD));
            objParam[11] = new SqlParameter("@tpassword", Encrypt(param.TPWD));
            objParam[12] = new SqlParameter("@Decpwd", param.LPWD);
            objParam[13] = new SqlParameter("@state", "");
            objParam[14] = new SqlParameter("@sesid", "");
            objParam[15] = new SqlParameter("@CorrAdds", param.CorrAdds);
            objParam[16] = new SqlParameter("@PerAdds", param.PerAdds);
            objParam[17] = new SqlParameter("@CorrCity", param.CorrCity);
            objParam[18] = new SqlParameter("@PerCity", param.PerCity);
            objParam[19] = new SqlParameter("@CorrDistrict", param.CorrDistrict);
            objParam[20] = new SqlParameter("@perDistrict", param.PerDistrict);
            objParam[21] = new SqlParameter("@Corrddlstate", param.Corrddlstate);
            objParam[22] = new SqlParameter("@perddlstate", param.Perddlstate);
            objParam[23] = new SqlParameter("@CorrPINCode", param.CorrPINCode);
            objParam[24] = new SqlParameter("@PerPINCode", param.PerPINCode);
            DataSet ds = SqlHelper.ExecuteDataset(strConnection, CommandType.StoredProcedure, "MA_InsertGuestRegOuter_Sp", objParam);
            return ds.Tables[0];
        }
        public DataTable CheckUserNameAvailability(MemberIDPWD param)
        {
            SqlParameter[] objParam = new SqlParameter[1];
            objParam[0] = new SqlParameter("@UserName", param.IDNO);
            DataSet ds = SqlHelper.ExecuteDataset(strConnection, CommandType.StoredProcedure, "MA_CheckUser_sp", objParam);
            return ds.Tables[0];
        }

        public DataTable getSICPOrdersList(SICPOrdersListInput param)
        {
            SqlParameter[] objParam = new SqlParameter[4];
            objParam[0] = new SqlParameter("@IDNO", param.IDNO);
            objParam[1] = new SqlParameter("@PWD", Encrypt(param.PWD));
            objParam[2] = new SqlParameter("@action", param.ACTION);
            objParam[3] = new SqlParameter("@type", param.TYPE);
            DataSet ds = SqlHelper.ExecuteDataset(strConnection, CommandType.StoredProcedure, "MA_OrderReport_sp", objParam);
            return ds.Tables[0];
        }


        public DataTable CheckTransPwdChecking(EwalTransferTransPwdInput param)
        {
            SqlParameter[] objParam = new SqlParameter[4];
            objParam[0] = new SqlParameter("@idno", param.IDNO);
            objParam[1] = new SqlParameter("@pwd", Encrypt(param.PWD));
            objParam[2] = new SqlParameter("@Tpwd", Encrypt(param.TRAPWD));
            objParam[3] = new SqlParameter("@action", param.ACTION);
            DataSet ds = SqlHelper.ExecuteDataset(strConnection, CommandType.StoredProcedure, "MA_CheckTransPwd_SP", objParam);
            return ds.Tables[0];
        }

        public DataTable EwalTransfer(EwalletTransferInput param)
        {
            SqlParameter[] objParam = new SqlParameter[4];
            objParam[0] = new SqlParameter("@idno", param.IDNO);
            objParam[1] = new SqlParameter("@pwd", Encrypt(param.PWD));
            objParam[2] = new SqlParameter("@amount", param.AMOUNT);
            objParam[3] = new SqlParameter("@action", param.ACTION);
            DataSet ds = SqlHelper.ExecuteDataset(strConnection, CommandType.StoredProcedure, "MA_TrnsCommfunds_SP", objParam);
            return ds.Tables[0];
        }


        public DataSet EwalletTrasferRpt(EwalletTransferInput param)
        {
            SqlParameter[] objParam = new SqlParameter[4];
            objParam[0] = new SqlParameter("@idno", param.IDNO);
            objParam[1] = new SqlParameter("@pwd", Encrypt(param.PWD));
            objParam[2] = new SqlParameter("@amount", param.AMOUNT);
            objParam[3] = new SqlParameter("@action", param.ACTION);
            DataSet ds = SqlHelper.ExecuteDataset(strConnection, CommandType.StoredProcedure, "MA_TrnsCommfunds_SP", objParam);
            return ds;
        }

        public DataTable getSSMPTabularViewData(SICPOrdersListInput param)
        {
            SqlParameter[] objParam = new SqlParameter[4];
            objParam[0] = new SqlParameter("@Idno", param.IDNO);
            objParam[1] = new SqlParameter("@pwd", Encrypt(param.PWD));
            objParam[2] = new SqlParameter("@type", param.TYPE);
            objParam[3] = new SqlParameter("@Action", param.ACTION);
            DataSet ds = SqlHelper.ExecuteDataset(strConnection, CommandType.StoredProcedure, "MA_GenealogyRpt_sp", objParam);
            return ds.Tables[0];
        }

        public DataSet SICPCurrSessRpt(SICPOrdersListInput param)
        {
            SqlParameter[] objParam = new SqlParameter[4];
            objParam[0] = new SqlParameter("@Idno", param.IDNO);
            objParam[1] = new SqlParameter("@pwd", Encrypt(param.PWD));
            objParam[2] = new SqlParameter("@type", param.TYPE);
            objParam[3] = new SqlParameter("@Action", param.ACTION);
            DataSet ds = SqlHelper.ExecuteDataset(strConnection, CommandType.StoredProcedure, "MA_GenealogyRpt_sp", objParam);
            return ds;
        }

        public DataTable getPayoutReportsData(SICPOrdersListInput param)
        {
            SqlParameter[] objParam = new SqlParameter[4];
            objParam[0] = new SqlParameter("@idno", param.IDNO);
            objParam[1] = new SqlParameter("@pwd", Encrypt(param.PWD));
            objParam[2] = new SqlParameter("@payno", Int16.Parse(param.TYPE));
            objParam[3] = new SqlParameter("@Action", param.ACTION);
            DataSet ds = SqlHelper.ExecuteDataset(strConnection, CommandType.StoredProcedure, "MA_PayoutRpts_sp", objParam);
            return ds.Tables[0];
        }
        public DataSet getSICPPayoutReportsData(SICPOrdersListInput param)
        {
            SqlParameter[] objParam = new SqlParameter[4];
            objParam[0] = new SqlParameter("@idno", param.IDNO);
            objParam[1] = new SqlParameter("@pwd", Encrypt(param.PWD));
            objParam[2] = new SqlParameter("@payno", Int16.Parse(param.TYPE));
            objParam[3] = new SqlParameter("@Action", param.ACTION);
            DataSet ds = SqlHelper.ExecuteDataset(strConnection, CommandType.StoredProcedure, "MA_PayoutRpts_sp", objParam);
            return ds;
        }

        public DataTable getPayoutData(PaynoInput param)
        {
            SqlParameter[] objParam = new SqlParameter[1];
            objParam[0] = new SqlParameter("@type", param.PAYNOTYPE);
            DataSet ds = SqlHelper.ExecuteDataset(strConnection, CommandType.StoredProcedure, "MA_GetPayNo_sp", objParam);
            return ds.Tables[0];
        }
        public DataSet ScmOnlineRequest(SCMPOnline param)
        {
            SqlParameter[] objParam = new SqlParameter[13];
            objParam[0] = new SqlParameter("@action", param.ACTION);
            objParam[1] = new SqlParameter("@regid", param.REGID);
            objParam[2] = new SqlParameter("@amount", param.AMOUNT);
            objParam[3] = new SqlParameter("@mobile", param.MOBILE);
            objParam[4] = new SqlParameter("@ORDER_ID", param.ORDER_ID);
            objParam[5] = new SqlParameter("@PaymentStatus", param.PAYMENTSTATUS);
            objParam[6] = new SqlParameter("@BillStatus", param.BILLSTATUS);
            objParam[7] = new SqlParameter("@TXNID", param.TXNID);
            objParam[8] = new SqlParameter("@BillNo", param.BillNo);
            objParam[9] = new SqlParameter("@pgtype", param.PGTYPE);
            objParam[10] = new SqlParameter("@shpcharge", param.SHOPCHARGE);
            objParam[11] = new SqlParameter("@scmemtype", param.SCMEMTYPE);
            objParam[12] = new SqlParameter("@coupon", param.COUPON);
            DataSet ds = SqlHelper.ExecuteDataset(strConnection, CommandType.StoredProcedure, "SCOnlineInsert_SP", objParam);
            return ds;
        }
        public DataSet TempOrder(TempOrderRequest param)
        {
            SqlParameter[] objParam = new SqlParameter[13];
            objParam[0] = new SqlParameter("@UNQId", param.UNQId);
            objParam[1] = new SqlParameter("@regid", param.regid);
            objParam[2] = new SqlParameter("@downlineid", param.downlineid);
            objParam[3] = new SqlParameter("@mop", param.mop);
            objParam[4] = new SqlParameter("@mopamt", param.mopamt);
            objParam[5] = new SqlParameter("@Fname", param.Fname);
            objParam[6] = new SqlParameter("@Lname", param.LName);
            objParam[7] = new SqlParameter("@Mobile", param.Mobile);
            objParam[8] = new SqlParameter("@Address", param.Address);
            objParam[9] = new SqlParameter("@City", param.City);
            objParam[10] = new SqlParameter("@District", param.District);
            objParam[11] = new SqlParameter("@state", param.state);
            objParam[12] = new SqlParameter("@PiCode", param.PiCode);
            DataSet ds = SqlHelper.ExecuteDataset(strConnection, CommandType.StoredProcedure, "TempOrder_SP", objParam);
            return ds;
        }
        public DataSet CreditRequestOnlineInsert(CreditRequest param)
        {  
            SqlParameter[] objParam = new SqlParameter[20];
            objParam[0] = new SqlParameter("@action", param.action);
            objParam[1] = new SqlParameter("@regid", param.REGID);
            objParam[2] = new SqlParameter("@reqAmt", param.reqAmt);
            objParam[3] = new SqlParameter("@mop", param.mop);
            objParam[4] = new SqlParameter("@refno", param.refno);
            objParam[5] = new SqlParameter("@invdate", param.invdate);
            objParam[6] = new SqlParameter("@invbank", param.invbank);
            objParam[7] = new SqlParameter("@invbranch", param.invbranch);
            objParam[8] = new SqlParameter("@depbank", param.depbank);
            objParam[9] = new SqlParameter("@depbranch", param.depbranch);
            objParam[10] = new SqlParameter("@depcity", param.depcity);
            objParam[11] = new SqlParameter("@depdate", param.depdate);
            objParam[12] = new SqlParameter("@depslip", param.depslip);
            objParam[13] = new SqlParameter("@remarks", param.remarks);
            objParam[14] = new SqlParameter("@ORDER_ID", param.ORDER_ID);
            objParam[15] = new SqlParameter("@PaymentStatus", param.PaymentStatus);
            objParam[16] = new SqlParameter("@BillStatus", param.BillStatus);
            objParam[17] = new SqlParameter("@TXNID", param.TXNID);
            objParam[18] = new SqlParameter("@Recode", param.Recode);
            objParam[19] = new SqlParameter("@pgtype", param.pgtype);
            DataSet ds = SqlHelper.ExecuteDataset(strConnection, CommandType.StoredProcedure, "CreditRequestOnlineInsert_Sp", objParam);
            return ds;
        }
        public DataSet GetPayoutMonth(IncomeMonthInput param)
        {
            SqlParameter[] objParam = new SqlParameter[1];
            objParam[0] = new SqlParameter("@FormNo", param.FORMNO);
            DataSet ds = SqlHelper.ExecuteDataset(strConnection, CommandType.StoredProcedure, "sp_GetPayoutMonth", objParam);
            return ds;
        }
        public DataSet GetCurrentPayoutMonthDetail(IncomeMonthInput param)
        {
            SqlParameter[] objParam = new SqlParameter[2];
            objParam[0] = new SqlParameter("@FormNo", param.FORMNO);
            objParam[1] = new SqlParameter("@SESSID", param.SESSID);
            DataSet ds = SqlHelper.ExecuteDataset(strConnection, CommandType.StoredProcedure, "sp_GetCURRENTPayoutMonthDetail", objParam);
            return ds;
        }
        public DataSet GetPayoutMonthDetail(IncomeMonthInput param)
        {
            SqlParameter[] objParam = new SqlParameter[2];
            objParam[0] = new SqlParameter("@FormNo", param.FORMNO);
            objParam[1] = new SqlParameter("@SESSID", param.SESSID);
            DataSet ds = SqlHelper.ExecuteDataset(strConnection, CommandType.StoredProcedure, "sp_GetPayoutMonthDetail", objParam);
            return ds;
        }
    }

}