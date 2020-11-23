using System;
using System.Data;

namespace SarsoBizDal
{
    public class StocksModule : IStocksModule
    {
        public DataTable StockLogin(string env, string username, string password)
        {
            return SqlHelpers.GetTable(env, CommandFactory.StockLogin(username, password));
        }

        public DataTable StockUsers(string env, string action, int itemid)
        {
            return SqlHelpers.GetTable(env, CommandFactory.StockUsers(action, itemid));
        }

        public int InupStockUsers(string env, string action, int itemId, string userName, string passWord, string name,
                                  string doorno, string lane, string streat, string city, string state,
                                  string contactName, string contactPhone, string email, int uid,
                                  string sesid, string ipaddress, int flag)
        {
            return SqlHelpers.GetValue<int>(env,
                                            CommandFactory.InupStockUsers(action, itemId, userName, passWord, name,
                                                                          doorno,
                                                                          lane, streat, city, state, contactName,
                                                                          contactPhone, email, uid, sesid, ipaddress,
                                                                          flag));
        }

        public int DelStockUsers(string env, int itemid, int uid)
        {
            return SqlHelpers.GetValue<int>(env, CommandFactory.DelStockUsers(itemid, uid));
        }

        public DataTable Getrpcategories(string env, string action, string category, string category1)
        {
            return SqlHelpers.GetTable(env, CommandFactory.Getrpcategories(action, category, category1));
        }

        public int Craterpcategories(string env, string category, string subCategory, string subCategoryone,
                                     string subCategorytwo, Int16 createdBy, string sesid)
        {
            return SqlHelpers.GetValue<int>(env,
                                            CommandFactory.Craterpcategories(category, subCategory, subCategoryone,
                                                                             subCategorytwo, createdBy, sesid));
        }

        public DataTable Editrpcategories(string env, string action, string category)
        {
            return SqlHelpers.GetTable(env, CommandFactory.Editrpcategories(action, category));
        }

        public int Updaterpcategories(string env, string category, string subcategory, string subcategoryname, int cstatus, int sid)
        {
            return SqlHelpers.GetValue<int>(env, CommandFactory.Updaterpcategories(category, subcategory, subcategoryname, cstatus, sid));
        }

        public DataTable RpcategoriesList(string env, string action)
        {
            return SqlHelpers.GetTable(env, CommandFactory.RpcategoriesList(action));
        }

        public DataTable GetProducts(string env, string action)
        {
            return SqlHelpers.GetTable(env, CommandFactory.GetProducts(action));
        }

        public DataTable RpCategories(string env, string action)
        {
            return SqlHelpers.GetTable(env, CommandFactory.RpCategories(action));
        }

        public string Repurchaseproducts(string env, string pcode, string pname, double price, double discAmt, double pv,
                                         double shpchrg, string descr,
                                         Int32 rpcid, int attr, string alias, int pStatus, string createdBy,
                                         string sesId, string shopinfo, double offprice, double dp, Int32 OffSts, string HSNO, double GST)
        {
            return SqlHelpers.GetValue<string>(env, CommandFactory.Repurchaseproducts(pcode, pname, price, discAmt, pv,
                                                                                      shpchrg, descr,
                                                                                      rpcid, attr, alias, pStatus,
                                                                                      createdBy,
                                                                                      sesId,shopinfo,offprice,dp,OffSts,HSNO,GST));
        }

        public void Prod_attributes(string env, string pcode, string attr1, string attr2,
                                    string attr3, string attr4, string attr5, string attr6, string attr7, string attr8, string attr9, string attr10)
        {
            SqlHelpers.GetValue<Int16>(env, CommandFactory.Prod_attributes(pcode, attr1, attr2,
                                                                           attr3, attr4, attr5, attr6, attr7, attr8, attr9, attr10));

        }

        public void prod_attributes_fields(string env, string pcode, string attrval11, string attrval12,
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
                                            string attrval104, string attrval105)
        {
            SqlHelpers.GetValue<Int16>(env,
                                       CommandFactory.prod_attributes_fields(pcode, attrval11, attrval12,
                                                                             attrval13, attrval14, attrval15
                                                                             , attrval21, attrval22, attrval23,
                                                                             attrval24, attrval25
                                                                             , attrval31, attrval32, attrval33,
                                                                             attrval34, attrval35
                                                                             , attrval41, attrval42, attrval43,
                                                                             attrval44, attrval45
                                                                             , attrval51, attrval52, attrval53,
                                                                             attrval54, attrval55, attrval61,  attrval62,attrval63,  attrval64, attrval65, attrval71, attrval72, attrval73,
                                                                             attrval74,  attrval75,attrval81,  attrval82,  attrval83,attrval84, 
                                                                             attrval85,attrval91,  attrval92,  attrval93,attrval94,  attrval95,attrval101,
                                                                             attrval102,  attrval103, attrval104,attrval105));

        }

        public void Productprices(string env, string pcode, double vatamt, double cstamt, int stateId, int allow)
        {
            SqlHelpers.GetValue<Int16>(env, CommandFactory.Productprices(pcode, vatamt, cstamt, stateId, allow));

        }

        public void ItemCodesGeneration(string env, string pcode, string attr1, string attr2,
                                        string attr3, string attr4, string attr5, string attr6, string attr7, string attr8, string attr9, string attr10)
        {
            SqlHelpers.GetValue<Int16>(env, CommandFactory.ItemCodesGeneration(pcode, attr1, attr2,
                                                                               attr3, attr4, attr5, attr6, attr7, attr8, attr9, attr10));

        }

        public DataTable ItemsList(string env, string action, string searchId, Int32 pageIndex, Int32 pageSize)
        {
            return SqlHelpers.GetTable(env, CommandFactory.ItemsList(action, searchId, pageIndex, pageSize));
        }

        public DataTable ProductList(string env, string action, string searchId, Int32 pageIndex, Int32 pageSize)
        {
            return SqlHelpers.GetTable(env, CommandFactory.ProductList(action, searchId, pageIndex, pageSize));
        }
        public DataTable StatewiseProductTaxs(string env, string action, string pcode)
        {
            return SqlHelpers.GetTable(env, CommandFactory.StatewiseProductTaxs(action, pcode));
        }
        public void ChgPrdDiscPv(string env, string pcode, double oldDisc, double newDisc, double oldpv, double newpv, string changedby, string sesid)
        {
            SqlHelpers.GetValue<int>(env, CommandFactory.ChgPrdDiscPv(pcode, oldDisc, newDisc, oldpv, newpv, changedby, sesid));
        }
        public void Repurchaseproducts_Update(string env, string pcode, string pname, string remarks, int status, double offprice, double pv, string User, string HSNO, double GST, double MRP, double PRICE)
        {
            SqlHelpers.GetValue<int>(env, CommandFactory.Repurchaseproducts_Update(pcode, pname, remarks, status, offprice, pv, User,HSNO,GST,MRP,PRICE));
        }
        public DataSet PackageList(string env, string action, string searchId, Int32 pageIndex, Int32 pageSize)
        {
            return SqlHelpers.GetDataSet(env, CommandFactory.PackageList(action, searchId, pageIndex, pageSize));
        }

        public void PackageUpdate(string env, string packcode, string name, Int16 status, string remarks)
        {
            SqlHelpers.GetValue<int>(env, CommandFactory.PackageUpdate(packcode, name, status, remarks));
        }

        public string StockInward(string env, string itemCode, int qty, string refno, string remarks, string sesid, string packcode, string batchno, DateTime mfgdate, DateTime expdate)
        {
            return SqlHelpers.GetValue<string>(env, CommandFactory.StockInward(itemCode, qty, refno, remarks, sesid, packcode, batchno, mfgdate, expdate));
        }

        public DataTable StoclLevel(string env, string action, Int32 pageIndex, Int32 pageSize)
        {
            return SqlHelpers.GetTable(env, CommandFactory.StoclLevel(action, pageIndex, pageSize));
        }
        public int GetAvlQtyforStockAdj(string env, string action, string itemcode)
        {
            return SqlHelpers.GetValue<int>(env, CommandFactory.GetAvlQtyforStockAdj(action, itemcode));
        }

        public string StockAdjust(string env, string refNo, string fCode, string itemCode, Int16 inward, Int16 outward,
                                  string remarks, string sesId)
        {
            return SqlHelpers.GetValue<string>(env,
                                               CommandFactory.StockAdjust(refNo, fCode, itemCode, inward, outward,
                                                                          remarks, sesId));
        }
        public DataTable CourierNames(string env, string action)
        {
            return SqlHelpers.GetTable(env, CommandFactory.CourierNames(action));
        }
        public DataTable GetBatchForBatchOut(string env, string action, string courier, DateTime fromdate, DateTime todate,
                                                       Int32 pageIndex, Int32 pageSize)
        {
            return SqlHelpers.GetTable(env, CommandFactory.GetBatchForBatchOut(action, courier, fromdate, todate,
                                                                               pageIndex, pageSize));
        }
        public string BatchOut(string env, string courier, string invoiceNos, string sesid)
        {
            return SqlHelpers.GetValue<string>(env, CommandFactory.BatchOut(courier, invoiceNos, sesid));
        }
        public DataSet StockInwardRpt(string env, string action, DateTime fromdate, DateTime todate,
                                                      Int32 pageIndex, Int32 pageSize)
        {
            return SqlHelpers.GetDataSet(env, CommandFactory.StockInwardRpt(action, fromdate, todate,
                                                                               pageIndex, pageSize));
        }
        public DataSet StockOrderRpt(string env, string action, DateTime fromdate, DateTime todate,
                                                     Int32 pageIndex, Int32 pageSize)
        {
            return SqlHelpers.GetDataSet(env, CommandFactory.StockOrderRpt(action, fromdate, todate,
                                                                               pageIndex, pageSize));
        }
        public DataSet StockTransforRpt(string env, string action, DateTime fromdate, DateTime todate,
                                                    Int32 pageIndex, Int32 pageSize)
        {
            return SqlHelpers.GetDataSet(env, CommandFactory.StockTransforRpt(action, fromdate, todate,
                                                                               pageIndex, pageSize));
        }
        public DataSet StockreturnsRpt(string env, string action, DateTime fromdate, DateTime todate,
                                                   Int32 pageIndex, Int32 pageSize, string searchid)
        {
            return SqlHelpers.GetDataSet(env, CommandFactory.StockreturnsRpt(action, fromdate, todate,
                                                                               pageIndex, pageSize, searchid));
        }
        public DataTable StockAdjustRpt(string env, string action, DateTime fromdate, DateTime todate,
                                                   Int32 pageIndex, Int32 pageSize)
        {
            return SqlHelpers.GetTable(env, CommandFactory.StockAdjustRpt(action, fromdate, todate,
                                                                               pageIndex, pageSize));
        }
        public DataSet StockRejectRpt(string env, string action, string sfcpcode, DateTime fromdate, DateTime todate,
                                                  Int32 pageIndex, Int32 pageSize)
        {
            return SqlHelpers.GetDataSet(env, CommandFactory.StockRejectRpt(action, sfcpcode, fromdate, todate,
                                                                               pageIndex, pageSize));
        }
        public DataTable StockDispatchRpt(string env, string action, DateTime fromdate, DateTime todate,
                                                   Int32 pageIndex, Int32 pageSize, string status, string order, string paytype)
        {
            return SqlHelpers.GetTable(env, CommandFactory.StockDispatchRpt(action, fromdate, todate,
                                                                               pageIndex, pageSize, status, order, paytype));
        }
        public DataTable StockDispatchItems(string env, string refno)
        {
            return SqlHelpers.GetTable(env, CommandFactory.StockDispatchItems(refno));
        }
        public DataTable BatchOutRpt(string env, Int32 pageIndex, Int32 pageSize)
        {
            return SqlHelpers.GetTable(env, CommandFactory.BatchOutRpt(pageIndex, pageSize));
        }

        public DataTable BatchDetRpt(string env, string despbno)
        {
            return SqlHelpers.GetTable(env, CommandFactory.BatchDetRpt(despbno));
        }
        public DataTable BatchDetExcel(string env, string despbno)
        {
            return SqlHelpers.GetTable(env, CommandFactory.BatchDetExcel(despbno));
        }
        public DataSet GetStockforReturns(string env, string action,
                                                     Int32 pageIndex, Int32 pageSize)
        {
            return SqlHelpers.GetDataSet(env, CommandFactory.GetStockforReturns(action, pageIndex, pageSize));
        }
        public DataSet TmpPackageItems(string env, string action, string randomno, string itemCode, Int32 qty, double price, Int32 rpcId, string pcode, string type, double CV,double GSTPrice)
        {
            return SqlHelpers.GetDataSet(env, CommandFactory.TmpPackageItems(action, randomno, itemCode, qty, price, rpcId, pcode,type,CV,GSTPrice));
        }
        public int PackageMaster(string env, string name, double price, Int32 bv, int pStatus, string remarks,
                                 string plantype, double discamt, double unitcomm, int regType,
                                 string randomno, string sesid)
        {
            return SqlHelpers.GetValue<int>(env, CommandFactory.PackageMaster(name, price, bv, pStatus, remarks,
                                                                              plantype, discamt, unitcomm, regType,
                                                                              randomno, sesid));
        }
        public DataTable CourierStatusRpt(string env, string status, string batchNo, Int32 regid, DateTime fromdate, DateTime todate, Int32 pageIndex, Int32 pageSize)
        {
            return SqlHelpers.GetTable(env, CommandFactory.CourierStatusRpt(status, batchNo, regid, fromdate, todate, pageIndex, pageSize));
        }
        public int MyChoicePackageCreation(string env, Int32 pid, string packcode, string name, double price, Int32 bv, int status, string remarks,
                                                double discamt, double unitcomm, int regType)
        {
            return SqlHelpers.GetValue<int>(env,
                                            CommandFactory.MyChoicePackageCreation(pid, packcode, name, price, bv, status, remarks,
                                                                                   discamt, unitcomm, regType));
        }

        public DataTable StkNote(string env, string action, string orderno, string refno)
        {
            return SqlHelpers.GetTable(env, CommandFactory.StkNote(action, orderno, refno));
        }
        public DataTable GetItemsForStockReturn(string env, string action, string refno)
        {
            return SqlHelpers.GetTable(env, CommandFactory.GetItemsForStockReturn(action, refno));
        }
        public void ApproveStkReturn(string env, string action, string refno, string remarks)
        {
            SqlHelpers.GetValue<int>(env, CommandFactory.ApproveStkReturn(action, refno, remarks));
        }
        public DataSet GetStockforTransfor(string env, string action, string refno, Int32 pageindex, Int32 pagesize)
        {
            return SqlHelpers.GetDataSet(env, CommandFactory.GetStockforTransfor(action, refno, pageindex, pagesize));
        }
        public DataTable StockTransfer(string env, string refno, string itemCodes, string sesid)
        {
            return SqlHelpers.GetTable(env, CommandFactory.StockTransfer(refno, itemCodes, sesid));
        }
        public int StockReject(string env, string refno, string remarks)
        {
            return SqlHelpers.GetValue<int>(env, CommandFactory.StockReject(refno, remarks));
        }
        public DataTable Dispatchs(string env, string action, string dispType, DateTime fromdate, DateTime todate, Int32 pageIndex, Int32 pageSize)
        {
            return SqlHelpers.GetTable(env, CommandFactory.Dispatchs(action, dispType, fromdate, todate, pageIndex, pageSize));
        }
        public DataTable DispatchItems(string env, string action, string idno)
        {
            return SqlHelpers.GetTable(env, CommandFactory.DispatchItems(action, idno));
        }
        public DataTable DispatchItemCodes(string env, string action, string fullitemcode, string packcode)
        {
            return SqlHelpers.GetTable(env, CommandFactory.DispatchItemCodes(action, fullitemcode, packcode));
        }
        public DataTable CourierMaster(string env, string action)
        {
            return SqlHelpers.GetTable(env, CommandFactory.CourierMaster(action));
        }
        public string StockDispatch(string env, string action, string fullitemcode, string idno, string courier, string sesid)
        {
            return SqlHelpers.GetValue<string>(env, CommandFactory.StockDispatch(action, fullitemcode, idno, courier, sesid));
        }
        public DataSet GetStockforReturn(string env, string action, string refno, Int32 pageindex, Int32 pagesize)
        {
            return SqlHelpers.GetDataSet(env, CommandFactory.GetStockforReturn(action, refno, pageindex, pagesize));
        }
        public int StockReturn(string env, string refno, string itemCodes, string sfcpcode, string remarks, string sesid)
        {
            return SqlHelpers.GetValue<int>(env, CommandFactory.StockReturn(refno, itemCodes, sfcpcode, remarks, sesid));
        }
        public void DespBatchExceltoDt(string env, DataTable dt)
        {
            SqlHelpers.GetValue<int>(env, CommandFactory.DespBatchExceltoDt(dt));
        }
        public void DespBatchExcel(string env, string action, string invno, string dockNo, DateTime dockDate, string batchNo, string Bank, string idno)
        {
            SqlHelpers.GetValue<int>(env, CommandFactory.DespBatchExcel(action, invno, dockNo, dockDate, batchNo,Bank,idno));
        }
        public DataTable DespBatchExcelRpt(string env)
        {
            return SqlHelpers.GetTable(env, CommandFactory.DespBatchExcelRpt());
        }
        public void UpdateDockDet(string env, string invoiceNos)
        {
            SqlHelpers.GetValue<int>(env, CommandFactory.UpdateDockDet(invoiceNos));
        }
        public DataSet EstimateStock(string env, string action, string packcodes, string packQtys)
        {
            return SqlHelpers.GetDataSet(env, CommandFactory.EstimateStock(action, packcodes, packQtys));
        }
        public DataTable ScViewHistory(string env, Int32 sno, Int32 regid, string pcode)
        {
            return SqlHelpers.GetTable(env, CommandFactory.ScViewHistory(sno, regid, pcode));
        }
        public void AddToCart(string env, Int32 regid, string pcode, Int16 qty, string ipadd, string usertype)
        {
            SqlHelpers.GetValue<int>(env, CommandFactory.AddToCart(regid, pcode, qty, ipadd, usertype));
        }
        public DataTable ChkAvailScProduct(string env, string pcode, Int32 regid)
        {
            return SqlHelpers.GetTable(env, CommandFactory.ChkAvailScProduct(pcode, regid));
        }
        public DataTable MyCartRpt(string env, Int32 regid)
        {
            return SqlHelpers.GetTable(env, CommandFactory.MyCartRpt(regid));
        }
        public void DelMyCart(string env, Int32 sno, Int32 qty)
        {
            SqlHelpers.GetValue<int>(env, CommandFactory.DelMyCart(sno, qty));
        }
        public DataSet GetSCProd_Attributes(string env, string pcode)
        {
            return SqlHelpers.GetDataSet(env, CommandFactory.GetSCProd_Attributes(pcode));
        }
        public void shoppe_Attr_fields_clear(string env, Int32 regid, string pcode, string memtype)
        {
            SqlHelpers.GetValue<int>(env, CommandFactory.shoppe_Attr_fields_clear(regid, pcode, memtype));
        }
        public void shoppe_Attr_fields(string env, Int32 regid, string pcode, string attributeName, string field, string memtype)
        {
            SqlHelpers.GetValue<int>(env, CommandFactory.shoppe_Attr_fields(regid, pcode, attributeName, field, memtype));
        }
        public DataTable Getshoppe_Attr_fields(string env, Int32 regid, string pcode, string memtype)
        {
            return SqlHelpers.GetTable(env, CommandFactory.Getshoppe_Attr_fields(regid, pcode, memtype));
        }
        //public DataTable ScOrder(string env, Int32 regid, string sesid, string mop, double orderamt, string memtype, double shpchrg)
        //{
        //    return SqlHelpers.GetTable(env, CommandFactory.ScOrder(regid, sesid, mop, orderamt, memtype, shpchrg));
        //}

        public DataSet ScOrderInvoice(string env, string action, string reqno, string billno)
        {
            return SqlHelpers.GetDataSet(env, CommandFactory.ScOrderInvoice(action, reqno, billno));
        }
        public DataTable ScMyOrders(string env, Int32 regid)
        {
            return SqlHelpers.GetTable(env, CommandFactory.ScMyOrders(regid));
        }
        public DataTable StoresGlance(string env, DateTime date, string user)
        {
            return SqlHelpers.GetTable(env, CommandFactory.StoresGlance(date, user));
        }
        public DataTable GlanceReport(string env, string action, string rpttype, DateTime ondate, string username, string sts, string searchby, Int32 pageindex, Int32 pagesize)
        {
            return SqlHelpers.GetTable(env, CommandFactory.GlanceReport(action, rpttype, ondate, username, sts, searchby, pageindex, pagesize));
        }
        public DataTable CourierDetails(string env, int sno, string CName, string Remarks, string AddedBy, int Status, string Action)
        {
            return SqlHelpers.GetTable(env, CommandFactory.CourierDetails(sno, CName, Remarks, AddedBy, Status, Action));
        }
        public DataTable GetAllcategories(string env, string action, string category, string category1, string category2)
        {
            return SqlHelpers.GetTable(env, CommandFactory.GetAllcategories(action, category, category1,category2));
        }
        public DataTable EditOrderItems(string env, string action, string idno, Int32 pid, string itemcode, Int32 packcode, string billno, Int32 prices)
        {
            return SqlHelpers.GetTable(env, CommandFactory.EditOrderItems(action, idno, pid,itemcode, packcode,billno,prices));
        }
        public DataTable IHODispatch(string env, string action, string regid, string CourierName, string IHONo, string DockNo, string Approveby)
        {
            return SqlHelpers.GetTable(env, CommandFactory.IHODispatch(action, regid, CourierName, IHONo, DockNo, Approveby));
        }
        public DataTable GVDOfferVouchers(string env, string action, string Packcode, string Voucher, string Offer, string Remarks)
        {
            return SqlHelpers.GetTable(env, CommandFactory.GVDOfferVouchers(action, Packcode, Voucher, Offer, Remarks));
        }
        public DataTable InsertCourierNos(string env, string action, string Courier, string DocNo, string SesUser, string SesID)
        {
            return SqlHelpers.GetTable(env, CommandFactory.InsertCourierNos(action, Courier, DocNo, SesUser, SesID));
        }

        public DataTable StockLevelRpt(string env, string action, string filter, Int32 pageIndex, Int32 pageSize)
        {
            return SqlHelpers.GetTable(env, CommandFactory.StockLevelRpt(action, filter, pageIndex, pageSize));
        }

        public DataTable GetFilters(string env, string action,string rpcid, string category, string pname, string price, string cv, string highprice, string highcv, string field)
        {
            return SqlHelpers.GetTable(env, CommandFactory.GetFilters(action, rpcid, category, pname, price, cv, highprice, highcv, field));
        }

        //rk 10/27/2016
        public DataTable tempInvOfferPrds(string env, string action, Int32 sno, Int32 pcode, string itemcode, string sesid, string uqid, int regid, string Attrname)
        {
            return SqlHelpers.GetTable(env, CommandFactory.tempInvOfferPrds(action, sno, pcode, itemcode, sesid, uqid, regid, Attrname));
        }
    }
}
