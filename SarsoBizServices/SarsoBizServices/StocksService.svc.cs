using System;
using System.Configuration;
using System.Data;
using SarsoBizDal;

namespace SarsoBizServices
{
    public class StocksService : IStocksService
    {
        private static readonly Utilities Objutlit = new Utilities();
        private readonly string _environment = ConfigurationManager.AppSettings["Environment"];

        public DataTable StockLogin(string username, string password)
        {
            return SarsoBizsDal.Instance.StocksModule.StockLogin(_environment, username, Objutlit.Encrypt(password));
        }

        public DataTable StockUsers(string action, int itemid)
        {
            return SarsoBizsDal.Instance.StocksModule.StockUsers(_environment, action, itemid);
        }

        public int InupStockUsers(string action, int itemId, string userName, string passWord, string name,
                                  string doorno, string lane, string streat, string city, string state,
                                  string contactName, string contactPhone, string email, int uid,
                                  string sesid, string ipaddress, int flag)
        {
            return SarsoBizsDal.Instance.StocksModule.InupStockUsers(_environment, action, itemId, userName, passWord, name,
                                                               doorno,
                                                               lane, streat, city, state, contactName,
                                                               contactPhone, email, uid, sesid, ipaddress, flag);
        }

        public int DelStockUsers(int itemid, int uid)
        {
            return SarsoBizsDal.Instance.StocksModule.DelStockUsers(_environment, itemid, uid);
        }

        public DataTable Getrpcategories(string action, string category, string category1)
        {
            return SarsoBizsDal.Instance.StocksModule.Getrpcategories(_environment, action, category, category1);
        }

        public int Craterpcategories(string category, string subCategory, string subCategoryone,
                                     string subCategorytwo, Int16 createdBy, string sesid)
        {
            return SarsoBizsDal.Instance.StocksModule.Craterpcategories(_environment, category, subCategory, subCategoryone,
                                                                  subCategorytwo, createdBy, sesid);
        }

        public DataTable Editrpcategories(string action, string category)
        {
            return SarsoBizsDal.Instance.StocksModule.Editrpcategories(_environment, action, category);
        }
        public int Updaterpcategories(string category, string subcategory, string subcategoryname, int cstatus, int sid)
        {
            return SarsoBizsDal.Instance.StocksModule.Updaterpcategories(_environment, category, subcategory, subcategoryname, cstatus, sid);
        }
        public DataTable RpcategoriesList(string action)
        {
            return SarsoBizsDal.Instance.StocksModule.RpcategoriesList(_environment, action);
        }

        public DataTable GetProducts(string action)
        {
            return SarsoBizsDal.Instance.StocksModule.GetProducts(_environment, action);
        }

        public DataTable RpCategories(string action)
        {
            return SarsoBizsDal.Instance.StocksModule.RpCategories(_environment, action);
        }

        public string Repurchaseproducts(string pcode, string pname, double price, double discAmt, double pv,
                                         double shpchrg, string descr,
                                         Int32 rpcid, int attr, string alias, int pStatus, string createdBy,
                                         string sesId, string shopinfo, double offprice, double dp, Int32 OffSts, string HSNO, double GST)
        {
            return SarsoBizsDal.Instance.StocksModule.Repurchaseproducts(_environment, pcode, pname, price, discAmt, pv,
                                                                   shpchrg, descr,
                                                                   rpcid, attr, alias, pStatus, createdBy,
                                                                   sesId,shopinfo, offprice, dp,OffSts,HSNO,GST);
        }

        public void Prod_attributes(string pcode, string attr1, string attr2,
                                    string attr3, string attr4, string attr5, string attr6, string attr7, string attr8, string attr9, string attr10)
        {
            SarsoBizsDal.Instance.StocksModule.Prod_attributes(_environment, pcode, attr1, attr2,
                                                         attr3, attr4, attr5,attr6, attr7, attr8, attr9, attr10);
        }

        public void prod_attributes_fields(string pcode, string attrval11, string attrval12,
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
            SarsoBizsDal.Instance.StocksModule.prod_attributes_fields(_environment, pcode, attrval11, attrval12,
                                                                attrval13, attrval14, attrval15
                                                                , attrval21, attrval22, attrval23,
                                                                attrval24, attrval25
                                                                , attrval31, attrval32, attrval33,
                                                                attrval34, attrval35
                                                                , attrval41, attrval42, attrval43,
                                                                attrval44, attrval45
                                                                , attrval51, attrval52, attrval53,
                                                                attrval54, attrval55, attrval61, attrval62, attrval63, attrval64, attrval65, attrval71, attrval72, attrval73,
                                                                             attrval74, attrval75, attrval81, attrval82, attrval83, attrval84,
                                                                             attrval85, attrval91, attrval92, attrval93, attrval94, attrval95, attrval101,
                                                                             attrval102, attrval103, attrval104, attrval105);
        }

        public void Productprices(string pcode, double vatamt, double cstamt, int stateId, int allow)
        {
            SarsoBizsDal.Instance.StocksModule.Productprices(_environment, pcode, vatamt, cstamt, stateId, allow);
        }

        public void ItemCodesGeneration(string pcode, string attr1, string attr2,
                                        string attr3, string attr4, string attr5, string attr6, string attr7, string attr8, string attr9, string attr10)
        {
            SarsoBizsDal.Instance.StocksModule.ItemCodesGeneration(_environment, pcode, attr1, attr2,
                                                             attr3, attr4, attr5, attr6, attr7, attr8, attr9, attr10);
        }

        public DataTable ItemsList(string action, string searchId, Int32 pageIndex, Int32 pageSize)
        {
            return SarsoBizsDal.Instance.StocksModule.ItemsList(_environment, action, searchId, pageIndex, pageSize);
        }

        public DataTable ProductList(string action, string searchId, Int32 pageIndex, Int32 pageSize)
        {
            return SarsoBizsDal.Instance.StocksModule.ProductList(_environment, action, searchId, pageIndex, pageSize);
        }

        public DataTable StatewiseProductTaxs(string action, string pcode)
        {
            return SarsoBizsDal.Instance.StocksModule.StatewiseProductTaxs(_environment, action, pcode);
        }

        public void ChgPrdDiscPv(string pcode, double oldDisc, double newDisc, double oldpv, double newpv, string changedby, string sesid)
        {
            SarsoBizsDal.Instance.StocksModule.ChgPrdDiscPv(_environment, pcode, oldDisc, newDisc, oldpv, newpv, changedby, sesid);
        }

        public void Repurchaseproducts_Update(string pcode, string pname, string remarks, int status, double offprice, double pv, string User, string HSNO, double GST, double MRP, double PRICE)
        {
            SarsoBizsDal.Instance.StocksModule.Repurchaseproducts_Update(_environment, pcode, pname, remarks, status, offprice, pv, User, HSNO, GST, MRP, PRICE);
        }

        public DataSet PackageList(string action, string searchId, Int32 pageIndex, Int32 pageSize)
        {
            return SarsoBizsDal.Instance.StocksModule.PackageList(_environment, action, searchId, pageIndex, pageSize);
        }

        public void PackageUpdate(string packcode, string name, Int16 status, string remarks)
        {
            SarsoBizsDal.Instance.StocksModule.PackageUpdate(_environment, packcode, name, status, remarks);
        }

        public string StockInward(string itemCode, int qty, string refno, string remarks, string sesid, string packcode, string batchno, DateTime mfgdate, DateTime expdate)
        {
            return SarsoBizsDal.Instance.StocksModule.StockInward(_environment, itemCode, qty, refno, remarks, sesid, packcode, batchno, mfgdate, expdate);
        }

        public DataTable StoclLevel(string action, Int32 pageIndex, Int32 pageSize)
        {
            return SarsoBizsDal.Instance.StocksModule.StoclLevel(_environment, action, pageIndex, pageSize);
        }

        public int GetAvlQtyforStockAdj(string action, string itemcode)
        {
            return SarsoBizsDal.Instance.StocksModule.GetAvlQtyforStockAdj(_environment, action, itemcode);
        }

        public string StockAdjust(string refNo, string fCode, string itemCode, Int16 inward, Int16 outward,
                                  string remarks, string sesId)
        {
            return SarsoBizsDal.Instance.StocksModule.StockAdjust(_environment, refNo, fCode, itemCode, inward, outward,
                                                            remarks, sesId);
        }

        public DataTable CourierNames(string action)
        {
            return SarsoBizsDal.Instance.StocksModule.CourierNames(_environment, action);
        }

        public DataTable GetBatchForBatchOut(string action, string courier, DateTime fromdate, DateTime todate,
                                             Int32 pageIndex, Int32 pageSize)
        {
            return SarsoBizsDal.Instance.StocksModule.GetBatchForBatchOut(_environment, action, courier, fromdate, todate,
                                                                    pageIndex, pageSize);
        }

        public string BatchOut(string courier, string invoiceNos, string sesid)
        {
            return SarsoBizsDal.Instance.StocksModule.BatchOut(_environment, courier, invoiceNos, sesid);
        }

        public DataSet StockInwardRpt(string action, DateTime fromdate, DateTime todate,
                                            Int32 pageIndex, Int32 pageSize)
        {
            return SarsoBizsDal.Instance.StocksModule.StockInwardRpt(_environment, action, fromdate, todate,
                                                                    pageIndex, pageSize);
        }
        public DataSet StockOrderRpt(string action, DateTime fromdate, DateTime todate,
                                          Int32 pageIndex, Int32 pageSize)
        {
            return SarsoBizsDal.Instance.StocksModule.StockOrderRpt(_environment, action, fromdate, todate,
                                                                    pageIndex, pageSize);
        }
        public DataSet StockTransforRpt(string action, DateTime fromdate, DateTime todate,
                                          Int32 pageIndex, Int32 pageSize)
        {
            return SarsoBizsDal.Instance.StocksModule.StockTransforRpt(_environment, action, fromdate, todate,
                                                                    pageIndex, pageSize);
        }
        public DataSet StockreturnsRpt(string action, DateTime fromdate, DateTime todate,
                                         Int32 pageIndex, Int32 pageSize, string searchid)
        {
            return SarsoBizsDal.Instance.StocksModule.StockreturnsRpt(_environment, action, fromdate, todate,
                                                                    pageIndex, pageSize, searchid);
        }

        public DataTable StockAdjustRpt(string action, DateTime fromdate, DateTime todate,
                                          Int32 pageIndex, Int32 pageSize)
        {
            return SarsoBizsDal.Instance.StocksModule.StockAdjustRpt(_environment, action, fromdate, todate,
                                                                    pageIndex, pageSize);
        }

        public DataSet StockRejectRpt(string action, string sfcpcode, DateTime fromdate, DateTime todate,
                                          Int32 pageIndex, Int32 pageSize)
        {
            return SarsoBizsDal.Instance.StocksModule.StockRejectRpt(_environment, action, sfcpcode, fromdate, todate,
                                                                    pageIndex, pageSize);
        }

        public DataTable StockDispatchRpt(string action, DateTime fromdate, DateTime todate,
                                         Int32 pageIndex, Int32 pageSize, string status, string order, string paytype)
        {
            return SarsoBizsDal.Instance.StocksModule.StockDispatchRpt(_environment, action, fromdate, todate,
                                                                    pageIndex, pageSize, status, order, paytype);
        }

        public DataTable StockDispatchItems(string refno)
        {
            return SarsoBizsDal.Instance.StocksModule.StockDispatchItems(_environment, refno);
        }

        public DataTable BatchOutRpt(Int32 pageIndex, Int32 pageSize)
        {
            return SarsoBizsDal.Instance.StocksModule.BatchOutRpt(_environment, pageIndex, pageSize);
        }

        public DataTable BatchDetRpt(string despbno)
        {
            return SarsoBizsDal.Instance.StocksModule.BatchDetRpt(_environment, despbno);
        }

        public DataTable BatchDetExcel(string despbno)
        {
            return SarsoBizsDal.Instance.StocksModule.BatchDetExcel(_environment, despbno);
        }

        public DataSet GetStockforReturns(string action, Int32 pageIndex, Int32 pageSize)
        {
            return SarsoBizsDal.Instance.StocksModule.GetStockforReturns(_environment, action, pageIndex, pageSize);
        }
        public DataSet TmpPackageItems(string action, string randomno, string itemCode, Int32 qty, double price, Int32 rpcId, string pcode, string type, double CV, double GSTPrice)
        {
            return SarsoBizsDal.Instance.StocksModule.TmpPackageItems(_environment, action, randomno, itemCode, qty, price, rpcId, pcode, type, CV, GSTPrice);
        }
        public int PackageMaster(string name, double price, Int32 bv, int pStatus, string remarks,
                                 string plantype, double discamt, double unitcomm, int regType,
                                 string randomno, string sesid)
        {
            return SarsoBizsDal.Instance.StocksModule.PackageMaster(_environment, name, price, bv, pStatus, remarks,
                                                              plantype, discamt, unitcomm, regType,
                                                              randomno, sesid);
        }

        public DataTable CourierStatusRpt(string status, string batchNo, Int32 regid, DateTime fromdate, DateTime todate, Int32 pageIndex, Int32 pageSize)
        {
            return SarsoBizsDal.Instance.StocksModule.CourierStatusRpt(_environment, status, batchNo, regid, fromdate, todate, pageIndex, pageSize);
        }
        public int MyChoicePackageCreation(Int32 pid, string packcode, string name, double price, Int32 bv, int status,
                                    string remarks, double discamt, double unitcomm, int regType)
        {
            return SarsoBizsDal.Instance.StocksModule.MyChoicePackageCreation(_environment, pid, packcode, name, price, bv, status,
                                                                        remarks,
                                                                        discamt, unitcomm, regType);
        }
        public DataTable StkNote(string action, string orderno, string refno)
        {
            return SarsoBizsDal.Instance.StocksModule.StkNote(_environment, action, orderno, refno);
        }
        public DataTable GetItemsForStockReturn(string action, string refno)
        {
            return SarsoBizsDal.Instance.StocksModule.GetItemsForStockReturn(_environment, action, refno);
        }
        public void ApproveStkReturn(string action, string refno, string remarks)
        {
            SarsoBizsDal.Instance.StocksModule.ApproveStkReturn(_environment, action, refno, remarks);
        }
        public DataSet GetStockforTransfor(string action, string refno, Int32 pageindex, Int32 pagesize)
        {
            return SarsoBizsDal.Instance.StocksModule.GetStockforTransfor(_environment, action, refno, pageindex, pagesize);
        }
        public DataTable StockTransfer(string refno, string itemCodes, string sesid)
        {
            return SarsoBizsDal.Instance.StocksModule.StockTransfer(_environment, refno, itemCodes, sesid);
        }
        public int StockReject(string refno, string remarks)
        {
            return SarsoBizsDal.Instance.StocksModule.StockReject(_environment, refno, remarks);
        }
        public DataTable Dispatchs(string action, string dispType, DateTime fromdate, DateTime todate, Int32 pageIndex, Int32 pageSize)
        {
            return SarsoBizsDal.Instance.StocksModule.Dispatchs(_environment, action, dispType, fromdate, todate, pageIndex, pageSize);
        }
        public DataTable DispatchItems(string action, string idno)
        {
            return SarsoBizsDal.Instance.StocksModule.DispatchItems(_environment, action, idno);
        }
        public DataTable DispatchItemCodes(string action, string fullitemcode, string packcode)
        {
            return SarsoBizsDal.Instance.StocksModule.DispatchItemCodes(_environment, action, fullitemcode, packcode);
        }
        public DataTable CourierMaster(string action)
        {
            return SarsoBizsDal.Instance.StocksModule.CourierMaster(_environment, action);
        }
        public string StockDispatch(string action, string fullitemcode, string idno, string courier, string sesid)
        {
            return SarsoBizsDal.Instance.StocksModule.StockDispatch(_environment, action, fullitemcode, idno, courier, sesid);
        }
        public DataSet GetStockforReturn(string action, string refno, Int32 pageindex, Int32 pagesize)
        {
            return SarsoBizsDal.Instance.StocksModule.GetStockforReturn(_environment, action, refno, pageindex, pagesize);
        }
        public int StockReturn(string refno, string itemCodes, string sfcpcode, string remarks, string sesid)
        {
            return SarsoBizsDal.Instance.StocksModule.StockReturn(_environment, refno, itemCodes, sfcpcode, remarks, sesid);
        }
        public void DespBatchExceltoDt(DataTable dt)
        {
            SarsoBizsDal.Instance.StocksModule.DespBatchExceltoDt(_environment, dt);
        }
        public void DespBatchExcel(string action, string invno, string dockNo, DateTime dockDate, string batchNo, string Bank, string idno)
        {
            SarsoBizsDal.Instance.StocksModule.DespBatchExcel(_environment, action, invno, dockNo, dockDate, batchNo, Bank, idno);
        }
        public DataTable DespBatchExcelRpt()
        {
            return SarsoBizsDal.Instance.StocksModule.DespBatchExcelRpt(_environment);
        }
        public void UpdateDockDet(string invoiceNos)
        {
            SarsoBizsDal.Instance.StocksModule.UpdateDockDet(_environment, invoiceNos);
        }

        public DataSet EstimateStock(string action, string packcodes, string packQtys)
        {
            return SarsoBizsDal.Instance.StocksModule.EstimateStock(_environment, action, packcodes, packQtys);
        }
        public DataTable ScViewHistory(Int32 sno, Int32 regid, string pcode)
        {
            return SarsoBizsDal.Instance.StocksModule.ScViewHistory(_environment, sno, regid, pcode);
        }

        public void AddToCart(Int32 regid, string pcode, Int16 qty, string ipadd, string usertype)
        {
            SarsoBizsDal.Instance.StocksModule.AddToCart(_environment, regid, pcode, qty, ipadd, usertype);
        }

        public DataTable MyCartRpt(Int32 regid)
        {
            return SarsoBizsDal.Instance.StocksModule.MyCartRpt(_environment, regid);
        }

        public DataTable ChkAvailScProduct(string pcode, Int32 regid)
        {
            return SarsoBizsDal.Instance.StocksModule.ChkAvailScProduct(_environment, pcode, regid);
        }

        public void DelMyCart(Int32 sno, Int32 qty)
        {
            SarsoBizsDal.Instance.StocksModule.DelMyCart(_environment, sno, qty);
        }
        public DataSet GetSCProd_Attributes(string pcode)
        {
            return SarsoBizsDal.Instance.StocksModule.GetSCProd_Attributes(_environment, pcode);
        }
        public void shoppe_Attr_fields_clear(Int32 regid, string pcode, string memtype)
        {
            SarsoBizsDal.Instance.StocksModule.shoppe_Attr_fields_clear(_environment, regid, pcode, memtype);
        }
        public void shoppe_Attr_fields(Int32 regid, string pcode, string attributeName, string field, string memtype)
        {
            SarsoBizsDal.Instance.StocksModule.shoppe_Attr_fields(_environment, regid, pcode, attributeName, field, memtype);
        }
        public DataTable Getshoppe_Attr_fields(Int32 regid, string pcode, string memtype)
        {
            return SarsoBizsDal.Instance.StocksModule.Getshoppe_Attr_fields(_environment, regid, pcode, memtype);
        }
        //public DataTable ScOrder(Int32 regid, string sesid, string mop, double orderamt, string memtype,
        //                  double shpchrg)
        //{
        //    return SarsoBizsDal.Instance.StocksModule.ScOrder(_environment, regid, sesid, mop, orderamt, memtype, shpchrg);
        //}
        public DataSet ScOrderInvoice(string action, string reqno, string billno)
        {
            return SarsoBizsDal.Instance.StocksModule.ScOrderInvoice(_environment, action, reqno, billno);
        }

        public DataTable ScMyOrders(Int32 regid)
        {
            return SarsoBizsDal.Instance.StocksModule.ScMyOrders(_environment, regid);
        }
        public DataTable StoresGlance(DateTime date, string user)
        {
            return SarsoBizsDal.Instance.StocksModule.StoresGlance(_environment, date, user);
        }
        public DataTable GlanceReport(string action, string rpttype, DateTime ondate, string username, string sts, string searchby, Int32 pageindex, Int32 pagesize)
        {
            return SarsoBizsDal.Instance.StocksModule.GlanceReport(_environment, action, rpttype, ondate, username, sts, searchby, pageindex, pagesize);
        }
        public DataTable CourierDetails(int sno, string CName, string Remarks, string AddedBy, int Status, string Action)
        {
            return SarsoBizsDal.Instance.StocksModule.CourierDetails(_environment, sno, CName, Remarks, AddedBy, Status, Action);
        }
        public DataTable GetAllcategories(string action, string category, string category1, string category2)
        {
            return SarsoBizsDal.Instance.StocksModule.GetAllcategories(_environment, action, category, category1, category2);
        }
        public DataTable EditOrderItems(string action, string idno, Int32 pid, string itemcode, Int32 packcode, string billno, Int32 prices)
        {
            return SarsoBizsDal.Instance.StocksModule.EditOrderItems(_environment, action, idno, pid, itemcode, packcode,billno,prices);
        }
        public DataTable IHODispatch(string action, string regid, string CourierName, string IHONo, string DockNo, string Approveby)
        {
            return SarsoBizsDal.Instance.StocksModule.IHODispatch(_environment, action, regid, CourierName, IHONo, DockNo, Approveby);
        }
        public DataTable GVDOfferVouchers(string action, string Packcode, string Voucher, string Offer, string Remarks)
        {
            return SarsoBizsDal.Instance.StocksModule.GVDOfferVouchers(_environment, action, Packcode, Voucher, Offer, Remarks);
        }
        public DataTable InsertCourierNos(string action, string Courier, string DocNo, string SesUser, string SesID)
        {
            return SarsoBizsDal.Instance.StocksModule.InsertCourierNos(_environment, action, Courier, DocNo, SesUser, SesID);
        }

        public DataTable StockLevelRpt(string action, string filter, Int32 pageIndex, Int32 pageSize)
        {
            return SarsoBizsDal.Instance.StocksModule.StockLevelRpt(_environment, action, filter, pageIndex, pageSize);
        }
        public DataTable GetFilters(string action,string rpcid, string category, string pname, string price, string cv, string highprice, string highcv, string field)
        {
            return SarsoBizsDal.Instance.StocksModule.GetFilters(_environment, action, rpcid, category, pname, price, cv, highprice, highcv, field);
        }
        //rk 10/27/2016
        public DataTable tempInvOfferPrds(string action, Int32 sno, Int32 pcode, string itemcode, string sesid, string uqid, int regid, string Attrname)
        {
            return SarsoBizsDal.Instance.StocksModule.tempInvOfferPrds(_environment, action, sno, pcode, itemcode, sesid, uqid, regid, Attrname);
        }
    }
}
