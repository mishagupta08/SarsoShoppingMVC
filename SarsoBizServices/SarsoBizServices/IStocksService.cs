using System;
using System.Data;
using System.ServiceModel;

namespace SarsoBizServices
{
    [ServiceContract]
    public interface IStocksService
    {
        [OperationContract]
        DataTable StockLogin(string username, string password);

        [OperationContract]
        DataTable StockUsers(string action, int itemid);

        [OperationContract]
        int InupStockUsers(string action, int itemId, string userName, string passWord, string name,
                           string doorno, string lane, string streat, string city, string state,
                           string contactName, string contactPhone, string email, int uid,
                           string sesid, string ipaddress, int flag);

        [OperationContract]
        int DelStockUsers(int itemid, int uid);

        [OperationContract]
        DataTable Getrpcategories(string action, string category, string category1);


        [OperationContract]
        int Craterpcategories(string category, string subCategory, string subCategoryone,
                              string subCategorytwo, Int16 createdBy, string sesid);

        [OperationContract]
        DataTable Editrpcategories(string action, string category);

        [OperationContract]
        int Updaterpcategories(string category, string subcategory, string subcategoryname, int cstatus, int sid);

        [OperationContract]
        DataTable RpcategoriesList(string action);

        [OperationContract]
        DataTable GetProducts(string action);

        [OperationContract]
        DataTable RpCategories(string action);

        [OperationContract]
        string Repurchaseproducts(string pcode, string pname, double price, double discAmt, double pv,
                               double shpchrg, string descr,
                               Int32 rpcid, int attr, string alias, int pStatus, string createdBy,
                               string sesId, string shopinfo, double offprice, double dp, Int32 OffSts,string HSNO,double GST);

        [OperationContract]
        void Prod_attributes(string pcode, string attr1, string attr2,
                            string attr3, string attr4, string attr5, string attr6, string attr7, string attr8, string attr9, string attr10);

        [OperationContract]
        void prod_attributes_fields(string pcode, string attrval11, string attrval12,
                                   string attrval13, string attrval14, string attrval15
                                   , string attrval21, string attrval22, string attrval23,
                                   string attrval24, string attrval25
                                   , string attrval31, string attrval32, string attrval33,
                                   string attrval34, string attrval35
                                   , string attrval41, string attrval42, string attrval43,
                                   string attrval44, string attrval45
                                   , string attrval51, string attrval52, string attrval53,
                                   string attrval54, string attrval55,
                                            string attrval61, string attrval62,
                                            string attrval63, string attrval64, string attrval65
                                            , string attrval71, string attrval72, string attrval73,
                                            string attrval74, string attrval75
                                            , string attrval81, string attrval82, string attrval83,
                                            string attrval84, string attrval85
                                            , string attrval91, string attrval92, string attrval93,
                                            string attrval94, string attrval95
                                            , string attrval101, string attrval102, string attrval103,
                                            string attrval104, string attrval105);

        [OperationContract]
        void Productprices(string pcode, double vatamt, double cstamt, int stateId, int allow);

        [OperationContract]
        void ItemCodesGeneration(string pcode, string attr1, string attr2,
                                 string attr3, string attr4, string attr5,
                                  string attr6, string attr7, string attr8, string attr9, string attr10);

        [OperationContract]
        DataTable ItemsList(string action,string searchId, Int32 pageIndex, Int32 pageSize);

        [OperationContract]
        DataTable ProductList(string action, string searchId, Int32 pageIndex, Int32 pageSize);

        [OperationContract]
        DataTable StatewiseProductTaxs(string action, string pcode);

        [OperationContract]
        void ChgPrdDiscPv(string pcode, double oldDisc, double newDisc, double oldpv, double newpv, string changedby,
                          string sesid);

        
        [OperationContract]
        void Repurchaseproducts_Update(string pcode, string pname, string remarks, int status, double offprice,
                                       double pv, string User, string HSNO, double GST, double MRP, double PRICE);

        [OperationContract]
        DataSet PackageList(string action, string searchId, Int32 pageIndex, Int32 pageSize);

        [OperationContract]
        void PackageUpdate(string packcode, string name, Int16 status, string remarks);

        [OperationContract]
        string StockInward(string itemCode, int qty, string refno, string remarks, string sesid, string packcode, string batchno, DateTime mfgdate, DateTime expdate);

        [OperationContract]
        DataTable StoclLevel(string action, Int32 pageIndex, Int32 pageSize);

        [OperationContract]
        int GetAvlQtyforStockAdj(string action, string itemcode);

        [OperationContract]
        string StockAdjust(string refNo, string fCode, string itemCode, Int16 inward, Int16 outward,
                           string remarks, string sesId);

        [OperationContract]
        DataTable CourierNames(string action);

        [OperationContract]
        DataTable GetBatchForBatchOut(string action, string courier, DateTime fromdate, DateTime todate,
                                      Int32 pageIndex, Int32 pageSize);

        [OperationContract]
        string BatchOut(string courier, string invoiceNos, string sesid);

        [OperationContract]
        DataSet StockInwardRpt(string action, DateTime fromdate, DateTime todate,
                               Int32 pageIndex, Int32 pageSize);

        [OperationContract]
        DataSet StockOrderRpt(string action, DateTime fromdate, DateTime todate,
                                Int32 pageIndex, Int32 pageSize);
        [OperationContract]
        DataSet StockTransforRpt(string action, DateTime fromdate, DateTime todate,
                                   Int32 pageIndex, Int32 pageSize);

        [OperationContract]
        DataSet StockreturnsRpt(string action, DateTime fromdate, DateTime todate,
                                Int32 pageIndex, Int32 pageSize, string searchid);

        [OperationContract]
        DataTable StockAdjustRpt(string action, DateTime fromdate, DateTime todate,
                                 Int32 pageIndex, Int32 pageSize);
        
        [OperationContract]
        DataSet StockRejectRpt(string action,string sfcpcode, DateTime fromdate, DateTime todate,
                                 Int32 pageIndex, Int32 pageSize);

        [OperationContract]
        DataTable StockDispatchRpt(string action, DateTime fromdate, DateTime todate,
                                   Int32 pageIndex, Int32 pageSize, string status, string order, string paytype);

        [OperationContract]
        DataTable StockDispatchItems(string refno);

        [OperationContract]
        DataTable BatchOutRpt(Int32 pageIndex, Int32 pageSize);
        
        [OperationContract]
        DataTable BatchDetRpt(string despbno);

        [OperationContract]
        DataTable BatchDetExcel(string despbno);

        [OperationContract]
        DataSet GetStockforReturns(string action, Int32 pageIndex, Int32 pageSize);

        [OperationContract]
        DataSet TmpPackageItems(string action, string randomno, string itemCode, Int32 qty, double price, Int32 rpcId, string pcode, string type, double CV,double GSTPrice);

        [OperationContract]
        int PackageMaster(string name, double price, Int32 bv, int pStatus, string remarks,
                          string plantype, double discamt, double unitcomm, int regType,
                          string randomno, string sesid);

        [OperationContract]
        DataTable CourierStatusRpt(string status, string batchNo, Int32 regid, DateTime fromdate, DateTime todate,
                                   Int32 pageIndex, Int32 pageSize);

        [OperationContract]
        int MyChoicePackageCreation(Int32 pid,string packcode, string name, double price, Int32 bv, int status,
                                    string remarks, double discamt, double unitcomm, int regType);

        [OperationContract]
        DataTable StkNote(string action, string orderno, string refno);

        [OperationContract]
        DataTable GetItemsForStockReturn(string action, string refno);

        [OperationContract]
        void ApproveStkReturn(string action, string refno, string remarks);

        [OperationContract]
        DataSet GetStockforTransfor(string action,string refno, Int32 pageindex, Int32 pagesize);

        [OperationContract]
        DataTable StockTransfer(string refno, string itemCodes, string sesid);

        [OperationContract]
        int StockReject(string refno, string remarks);

        [OperationContract]
        DataTable Dispatchs(string action, string dispType, DateTime fromdate, DateTime todate, Int32 pageIndex,
                            Int32 pageSize);

        [OperationContract]
        DataTable DispatchItems(string action, string idno);

        [OperationContract]
        DataTable DispatchItemCodes(string action, string fullitemcode, string packcode);

        [OperationContract]
        DataTable CourierMaster(string action);

        [OperationContract]
        string StockDispatch(string action, string fullitemcode, string idno, string courier, string sesid);

        [OperationContract]
        DataSet GetStockforReturn(string action, string refno, Int32 pageindex, Int32 pagesize);

        [OperationContract]
        int StockReturn(string refno, string itemCodes, string sfcpcode, string remarks, string sesid);

        [OperationContract]
        void DespBatchExceltoDt(DataTable dt);

        [OperationContract]
        void DespBatchExcel(string action, string invno, string dockNo, DateTime dockDate, string batchNo, string Bank, string idno);

        [OperationContract]
        DataTable DespBatchExcelRpt();

        [OperationContract]
        void UpdateDockDet(string invoiceNos);

        [OperationContract]
        DataSet EstimateStock(string action, string packcodes, string packQtys);

        [OperationContract]
        DataTable ScViewHistory(Int32 sno, Int32 regid, string pcode);

        [OperationContract]
        void AddToCart(Int32 regid, string pcode, Int16 qty, string ipadd, string usertype);

        [OperationContract]
        DataTable MyCartRpt(Int32 regid);

        [OperationContract]
        DataTable ChkAvailScProduct(string pcode, Int32 regid);

        [OperationContract]
        void DelMyCart(Int32 sno,Int32 qty);

        [OperationContract]
        DataSet GetSCProd_Attributes(string pcode);

        [OperationContract]
        void shoppe_Attr_fields_clear(Int32 regid, string pcode, string memtype);

        [OperationContract]
        void shoppe_Attr_fields(Int32 regid, string pcode, string attributeName, string field, string memtype);

        [OperationContract]
        DataTable Getshoppe_Attr_fields(Int32 regid, string pcode, string memtype);

        //[OperationContract]
        //DataTable ScOrder(Int32 regid, string sesid, string mop, double orderamt, string memtype,
        //                  double shpchrg);

        [OperationContract]
        DataSet ScOrderInvoice(string action, string reqno, string billno);

        [OperationContract]
        DataTable ScMyOrders(Int32 regid);

        [OperationContract]
        DataTable StoresGlance(DateTime date, string user);

        [OperationContract]
        DataTable GlanceReport(string action, string rpttype, DateTime ondate, string username, string sts, string searchby, Int32 pageindex, Int32 pagesize);

        [OperationContract]
        DataTable CourierDetails(int sno, string CName, string Remarks, string AddedBy, int Status, string Action);

        [OperationContract]
        DataTable GetAllcategories(string action, string category, string category1, string category2);

        [OperationContract]
        DataTable EditOrderItems(string action, string idno, Int32 pid, string itemcode, Int32 packcode, string billno, Int32 prices);

        [OperationContract]
        DataTable IHODispatch(string action, string regid, string CourierName, string IHONo, string DockNo, string Approveby);

        [OperationContract]
        DataTable GVDOfferVouchers(string action, string Packcode, string Voucher, string Offer, string Remarks);

        [OperationContract]
        DataTable InsertCourierNos(string action, string Courier, string DocNo, string SesUser, string SesID);

        [OperationContract]
        DataTable StockLevelRpt(string action, string filter, Int32 pageIndex, Int32 pageSize);
        [OperationContract]
        DataTable GetFilters(string action, string rpcid, string category, string pname, string price, string cv, string highprice, string highcv, string field);

        //rk 10/27/2016
        [OperationContract]
        DataTable tempInvOfferPrds(string action, Int32 sno, Int32 pcode, string itemcode, string sesid, string uqid, int regid, string Attrname);
    }
}
