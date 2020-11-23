using System;
using System.Data;

namespace SarsoBizDal 
{
    public interface IStocksModule
    {
        DataTable StockLogin(string env, string username, string password);

        DataTable StockUsers(string env, string action, int itemid);

        int InupStockUsers(string env, string action, int itemId, string userName, string passWord, string name,
                           string doorno, string lane, string streat, string city, string state,
                           string contactName, string contactPhone, string email, int uid,
                           string sesid, string ipaddress, int flag);

        int DelStockUsers(string env, int itemid, int uid);

        DataTable Getrpcategories(string env, string action, string category,string category1);

        int Craterpcategories(string env, string category, string subCategory, string subCategoryone,
                              string subCategorytwo, Int16 createdBy, string sesid);

        DataTable Editrpcategories(string env, string action, string category);

        int Updaterpcategories(string env, string category, string subcategory, string subcategoryname, int cstatus, int sid);        

        DataTable RpcategoriesList(string env, string action);

        DataTable GetProducts(string env, string action);

        DataTable RpCategories(string env, string action);


        string Repurchaseproducts(string env, string pcode, string pname, double price, double discAmt, double pv,
                           double shpchrg, string descr,
                           Int32 rpcid, int attr, string alias, int pStatus, string createdBy,
                           string sesId, string shopinfo, double offprice, double dp, Int32 OffSts, string HSNO, double GST);

        void Prod_attributes(string env, string pcode, string attr1, string attr2,
                              string attr3, string attr4, string attr5, string attr6, string attr7, string attr8, string attr9, string attr10);

        void prod_attributes_fields(string env, string pcode, string attrval11, string attrval12,
                                     string attrval13, string attrval14, string attrval15
                                     , string attrval21, string attrval22, string attrval23,
                                     string attrval24, string attrval25
                                     , string attrval31, string attrval32, string attrval33,
                                     string attrval34, string attrval35
                                     , string attrval41, string attrval42, string attrval43,
                                     string attrval44, string attrval45
                                     , string attrval51, string attrval52, string attrval53,
                                     string attrval54, string attrval55, string attrval61, string attrval62,
                                            string attrval63, string attrval64, string attrval65
                                            , string attrval71, string attrval72, string attrval73,
                                            string attrval74, string attrval75
                                            , string attrval81, string attrval82, string attrval83,
                                            string attrval84, string attrval85
                                            , string attrval91, string attrval92, string attrval93,
                                            string attrval94, string attrval95
                                            , string attrval101, string attrval102, string attrval103,
                                            string attrval104, string attrval105);

        void Productprices(string env, string pcode, double vatamt, double cstamt, int stateId, int allow);


        void ItemCodesGeneration(string env, string pcode, string attr1, string attr2,
                              string attr3, string attr4, string attr5, string attr6, string attr7, string attr8, string attr9, string attr10);

        DataTable ItemsList(string env, string action,string searchId, Int32 pageIndex, Int32 pageSize);

        DataTable ProductList(string env, string action, string searchId, Int32 pageIndex, Int32 pageSize);

        DataTable StatewiseProductTaxs(string env, string action, string pcode);

        void ChgPrdDiscPv(string env, string pcode, double oldDisc, double newDisc, double oldpv, double newpv,
                          string changedby, string sesid);

        void Repurchaseproducts_Update(string env, string pcode, string pname, string remarks, int status, double offprice,
                                  double pv, string User, string HSNO, double GST, double MRP, double PRICE);

        DataSet PackageList(string env, string action, string searchId, Int32 pageIndex, Int32 pageSize);

        void PackageUpdate(string env, string packcode, string name, Int16 status, string remarks);

        string StockInward(string env, string itemCode, int qty, string refno, string remarks, string sesid, string packcode, string batchno, DateTime mfgdate, DateTime expdate);

        DataTable StoclLevel(string env, string action, Int32 pageIndex, Int32 pageSize);

        int GetAvlQtyforStockAdj(string env, string action, string itemcode);

        string StockAdjust(string env, string refNo, string fCode, string itemCode, Int16 inward, Int16 outward,
                           string remarks, string sesId);

        DataTable CourierNames(string env, string action);

        DataTable GetBatchForBatchOut(string env, string action, string courier, DateTime fromdate, DateTime todate,
                                      Int32 pageIndex, Int32 pageSize);

        string BatchOut(string env, string courier, string invoiceNos, string sesid);

        DataSet StockInwardRpt(string env, string action, DateTime fromdate, DateTime todate,
                               Int32 pageIndex, Int32 pageSize);

        DataSet StockOrderRpt(string env, string action, DateTime fromdate, DateTime todate,
                                Int32 pageIndex, Int32 pageSize);

        DataSet StockTransforRpt(string env, string action, DateTime fromdate, DateTime todate,
                                   Int32 pageIndex, Int32 pageSize);

        DataSet StockreturnsRpt(string env, string action, DateTime fromdate, DateTime todate,
                                  Int32 pageIndex, Int32 pageSize, string searchid);

        DataTable StockAdjustRpt(string env, string action, DateTime fromdate, DateTime todate,
                                 Int32 pageIndex, Int32 pageSize);

        DataSet StockRejectRpt(string env, string action,string sfcpcode, DateTime fromdate, DateTime todate,
                                 Int32 pageIndex, Int32 pageSize);

        DataTable StockDispatchRpt(string env, string action, DateTime fromdate, DateTime todate,
                                   Int32 pageIndex, Int32 pageSize, string status, string order, string paytype);

        DataTable StockDispatchItems(string env, string refno);

        DataTable BatchOutRpt(string env, Int32 pageIndex, Int32 pageSize);        

        DataTable BatchDetRpt(string env, string despbno);

        DataTable BatchDetExcel(string env, string despbno);

        DataSet GetStockforReturns(string env, string action,Int32 pageIndex, Int32 pageSize);

        DataSet TmpPackageItems(string env, string action, string randomno, string itemCode, Int32 qty, double price, Int32 rpcId, string pcode, string type, double CV, double GSTPrice);

        int PackageMaster(string env, string name, double price, Int32 bv, int pStatus, string remarks,
                          string plantype, double discamt, double unitcomm, int regType,
                          string randomno, string sesid);

        DataTable CourierStatusRpt(string env, string status, string batchNo, Int32 regid, DateTime fromdate,
                                   DateTime todate, Int32 pageIndex, Int32 pageSize);

        int MyChoicePackageCreation(string env,Int32 pid, string packcode, string name, double price, Int32 bv, int status,
                                    string remarks,
                                    double discamt, double unitcomm, int regType);
        
        DataTable StkNote(string env, string action, string orderno, string refno);

        DataTable GetItemsForStockReturn(string env, string action, string refno);

        void ApproveStkReturn(string env, string action, string refno, string remarks);

        DataSet GetStockforTransfor(string env, string action,string refno, Int32 pageindex, Int32 pagesize);

        DataTable StockTransfer(string env, string refno, string itemCodes, string sesid);

        int StockReject(string env, string refno, string remarks);

        DataTable Dispatchs(string env, string action, string dispType, DateTime fromdate, DateTime todate,
                            Int32 pageIndex, Int32 pageSize);
        DataTable DispatchItems(string env, string action, string idno);

        DataTable DispatchItemCodes(string env, string action, string fullitemcode, string packcode);

        DataTable CourierMaster(string env, string action);

        string StockDispatch(string env, string action, string fullitemcode, string idno, string courier, string sesid);

        DataSet GetStockforReturn(string env, string action, string refno, Int32 pageindex, Int32 pagesize);

        int StockReturn(string env, string refno, string itemCodes, string sfcpcode, string remarks, string sesid);

        void DespBatchExceltoDt(string env, DataTable dt);

        void DespBatchExcel(string env, string action, string invno, string dockNo, DateTime dockDate, string batchNo, string Bank, string idno);

        DataTable DespBatchExcelRpt(string env);

        void UpdateDockDet(string env, string invoiceNos);

        DataSet EstimateStock(string env, string action, string packcodes, string packQtys);

        DataTable ScViewHistory(string env,  Int32 sno, Int32 regid, string pcode);

        void AddToCart(string env, Int32 regid, string pcode, Int16 qty, string ipadd, string usertype);
      
        DataTable MyCartRpt(string env, Int32 regid);

        DataTable ChkAvailScProduct(string env, string pcode, Int32 regid);

        void DelMyCart(string env, Int32 sno,Int32 qty);

        DataSet GetSCProd_Attributes(string env, string pcode);

        void shoppe_Attr_fields_clear(string env, Int32 regid, string pcode, string memtype);

        void shoppe_Attr_fields(string env, Int32 regid, string pcode, string attributeName, string field,
                                string memtype);

        DataTable Getshoppe_Attr_fields(string env, Int32 regid, string pcode, string memtype);

        //DataTable ScOrder(string env, Int32 regid, string sesid, string mop, double orderamt, string memtype,
        //                  double shpchrg);

        DataSet ScOrderInvoice(string env, string action, string reqno, string billno);

        DataTable ScMyOrders(string env, Int32 regid);

        DataTable StoresGlance(string env, DateTime date, string user);

        DataTable GlanceReport(string env, string action, string rpttype, DateTime ondate, string username, string sts, string searchby, Int32 pageindex, Int32 pagesize);

        DataTable CourierDetails(string env, int sno, string CName, string Remarks, string AddedBy, int Status, string Action);

        DataTable GetAllcategories(string env, string action, string category, string category1, string category2);

        DataTable EditOrderItems(string env, string action, string idno, Int32 pid, string itemcode, Int32 packcode, string billno, Int32 prices);

        DataTable IHODispatch(string env, string action, string regid, string CourierName, string IHONo, string DockNo, string Approveby);

        DataTable GVDOfferVouchers(string env, string action, string Packcode, string Voucher, string Offer, string Remarks);

        DataTable InsertCourierNos(string env, string action, string Courier, string DocNo, string SesUser, string SesID);

        DataTable StockLevelRpt(string env, string action, string filter, Int32 pageIndex, Int32 pageSize);
        DataTable GetFilters(string env, string action,string rpcid, string category, string pname, string price, string cv, string highprice, string highcv, string field);
        //rk 10/27/2016
        DataTable tempInvOfferPrds(string env, string action, Int32 sno, Int32 pcode, string itemcode, string sesid, string uqid, int regid, string Attrname);

    }
}
