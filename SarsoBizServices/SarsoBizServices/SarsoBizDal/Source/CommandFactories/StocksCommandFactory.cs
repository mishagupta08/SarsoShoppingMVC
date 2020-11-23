using System;
using System.Data;
using System.Data.SqlClient;

namespace SarsoBizDal
{
    internal partial class CommandFactory
    {
        internal static SqlCommand StockLogin(string username, string password)
        {
            var parameters = new[]
            {
                CreateParameter("@username", SqlDbType.VarChar, username),
                CreateParameter("@password", SqlDbType.VarChar, password)
            };
            return CreateCommand("StockLogin_Sp", parameters);
        }
        internal static SqlCommand StockUsers(string action, int itemid)
        {
            var parameters = new[]
            {
                CreateParameter("@action", SqlDbType.VarChar, action), 
                CreateParameter("@itemid", SqlDbType.Int, itemid)
            };
            return CreateCommand("StockUsers_Sp", parameters);
        }
        internal static SqlCommand InupStockUsers(string action, int itemId, string userName, string passWord, string name,
                                             string doorno, string lane, string streat, string city, string state,
                                             string contactName, string contactPhone, string email, int uid,
                                             string sesid, string ipaddress, int flag)
        {
            var parameters = new[]
            {
                CreateParameter("@action", SqlDbType.VarChar, action),  
                CreateParameter("@itemId", SqlDbType.Int, itemId),  
                CreateParameter("@userName", SqlDbType.VarChar, userName),  
                CreateParameter("@passWord", SqlDbType.VarChar, passWord),  
                CreateParameter("@name", SqlDbType.VarChar, name),  
                CreateParameter("@doorno", SqlDbType.VarChar, doorno),  
                CreateParameter("@lane", SqlDbType.VarChar, lane),  
                CreateParameter("@streat", SqlDbType.VarChar, streat),  
                CreateParameter("@city", SqlDbType.VarChar, city),  
                CreateParameter("@state", SqlDbType.VarChar, state),  
                CreateParameter("@Contact_Name", SqlDbType.VarChar, contactName),  
                CreateParameter("@Contact_Phone", SqlDbType.VarChar, contactPhone),  
                CreateParameter("@email", SqlDbType.VarChar, email),  
                CreateParameter("@uid", SqlDbType.Int, uid),  
                CreateParameter("@sesid", SqlDbType.VarChar, sesid), 
                CreateParameter("@ipaddress", SqlDbType.VarChar, ipaddress), 
                CreateParameter("@flag", SqlDbType.Int, flag)
            };
            return CreateCommand("INUPStockUsers_SP", parameters);
        }
        internal static SqlCommand DelStockUsers(int itemid, int uid)
        {
            var parameters = new[]
            {
                CreateParameter("@itemid", SqlDbType.Int, itemid),                
                CreateParameter("@uid", SqlDbType.Int, uid)
            };
            return CreateCommand("DelStockUsers_Sp", parameters);
        }
        internal static SqlCommand Getrpcategories(string action, string category, string category1)
        {
            var parameters = new[]
            {
                CreateParameter("@action", SqlDbType.VarChar, action),                
                CreateParameter("@category", SqlDbType.VarChar, category),
                CreateParameter("@category1", SqlDbType.VarChar, category1)
            };
            return CreateCommand("Getrpcategories_SP", parameters);
        }
        internal static SqlCommand Craterpcategories(string category, string subCategory, string subCategoryone,
                                                     string subCategorytwo, Int16 createdBy, string sesid)
        {
            var parameters = new[]
            {
                CreateParameter("@Category", SqlDbType.VarChar, category),                
                CreateParameter("@SubCategory", SqlDbType.VarChar, subCategory),
                CreateParameter("@SubCategoryone", SqlDbType.VarChar, subCategoryone),
                CreateParameter("@SubCategorytwo", SqlDbType.VarChar, subCategorytwo),
                CreateParameter("@CreatedBy", SqlDbType.Int, createdBy),
                CreateParameter("@Sesid", SqlDbType.VarChar, sesid)
            };
            return CreateCommand("Craterpcategories_SP", parameters);
        }
        internal static SqlCommand Editrpcategories(string action, string category)
        {
            var parameters = new[]
            {
                CreateParameter("@action", SqlDbType.VarChar, action),                
                CreateParameter("@category", SqlDbType.VarChar, category)
            };
            return CreateCommand("Editrpcategories_SP", parameters);
        }
        internal static SqlCommand Updaterpcategories(string category, string subcategory, string subcategoryname, int cstatus, int sid)
        {
            var parameters = new[]
            {                
                CreateParameter("@category", SqlDbType.VarChar, category),
                CreateParameter("@subcategory", SqlDbType.VarChar, subcategory),
                CreateParameter("@subcategoryone", SqlDbType.VarChar, subcategoryname),
                CreateParameter("@cstatus", SqlDbType.Int, cstatus),
                CreateParameter("@sid", SqlDbType.Int, sid)
            };
            return CreateCommand("Updaterpcategories_SP", parameters);
        }
        internal static SqlCommand RpcategoriesList(string action)
        {
            var parameters = new[]
            {
                CreateParameter("@action", SqlDbType.VarChar, action)                
            };
            return CreateCommand("RpcategoriesList_Sp", parameters);
        }
        internal static SqlCommand GetProducts(string action)
        {
            var parameters = new[]
            {
                CreateParameter("@action", SqlDbType.VarChar, action)                
            };
            return CreateCommand("GetProducts_Sp", parameters);
        }
        internal static SqlCommand RpCategories(string action)
        {
            var parameters = new[]
            {
                CreateParameter("@action", SqlDbType.VarChar, action)                
            };
            return CreateCommand("rpcategories_Sp", parameters);
        }
        internal static SqlCommand Repurchaseproducts(string pcode, string pname, double price, double discAmt, double pv,
                                                     double shpchrg, string descr,
                                                     Int32 rpcid, int attr, string alias, int pStatus, string createdBy,
                                                     string sesId, string shopinfo, double offprice, double dp,Int32 OffSts,string HSNO,double GST)
        {
            var parameters = new[]
               {   
                   CreateParameter("@pcode", SqlDbType.VarChar, pcode),                                     
                   CreateParameter("@pname", SqlDbType.VarChar, pname),
                   CreateParameter("@price", SqlDbType.Money, price),
                   CreateParameter("@discAmt", SqlDbType.Money, discAmt),
                   CreateParameter("@pv", SqlDbType.Money, pv),
                   CreateParameter("@shpchrg", SqlDbType.Money, shpchrg),
                   CreateParameter("@descr", SqlDbType.VarChar, descr),
                   CreateParameter("@rpcid", SqlDbType.Int, rpcid),
                   CreateParameter("@attr", SqlDbType.Int, attr),
                   CreateParameter("@alias", SqlDbType.VarChar, alias),
                   CreateParameter("@pStatus", SqlDbType.Int, pStatus),
                   CreateParameter("@createdBy", SqlDbType.Int, createdBy),
                   CreateParameter("@sesId", SqlDbType.VarChar, sesId),
                   CreateParameter("@shopinfo", SqlDbType.VarChar, shopinfo),
                   CreateParameter("@offprice", SqlDbType.Money, offprice),
                   CreateParameter("@dp", SqlDbType.Money, dp),
                   CreateParameter("@OffSts", SqlDbType.Int, OffSts),
                   CreateParameter("@HSNO", SqlDbType.VarChar, HSNO),
                   CreateParameter("@GST", SqlDbType.Money, GST)
                };
            return CreateCommand("Repurchaseproducts_Sp", parameters);
        }
        internal static SqlCommand Prod_attributes(string pcode, string attr1, string attr2,
                                                             string attr3, string attr4, string attr5,
            string attr6, string attr7, string attr8, string attr9, string attr10)
        {
            var parameters = new[]
               {                                        
                   CreateParameter("@Pcode", SqlDbType.VarChar, pcode),
                   CreateParameter("@attr1", SqlDbType.VarChar, attr1),
                   CreateParameter("@attr2", SqlDbType.VarChar, attr2),
                   CreateParameter("@attr3", SqlDbType.VarChar, attr3),
                   CreateParameter("@attr4", SqlDbType.VarChar, attr4),
                   CreateParameter("@attr5", SqlDbType.VarChar, attr5),
                   CreateParameter("@attr6", SqlDbType.VarChar, attr6),
                   CreateParameter("@attr7", SqlDbType.VarChar, attr7),
                   CreateParameter("@attr8", SqlDbType.VarChar, attr8),
                   CreateParameter("@attr9", SqlDbType.VarChar, attr9),
                   CreateParameter("@attr10", SqlDbType.VarChar, attr10)
                };
            return CreateCommand("Prod_attributes_Sp", parameters);
        }
        internal static SqlCommand prod_attributes_fields(string pcode, string attrval11, string attrval12,
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
            var parameters = new[]
                {
                    CreateParameter("@pcode", SqlDbType.VarChar, pcode),
                    CreateParameter("@attrval11", SqlDbType.VarChar, attrval11),
                    CreateParameter("@attrval12", SqlDbType.VarChar, attrval12),
                    CreateParameter("@attrval13", SqlDbType.VarChar, attrval13),
                    CreateParameter("@attrval14", SqlDbType.VarChar, attrval14),
                    CreateParameter("@attrval15", SqlDbType.VarChar, attrval15),
                    CreateParameter("@attrval21", SqlDbType.VarChar, attrval21),
                    CreateParameter("@attrval22", SqlDbType.VarChar, attrval22),
                    CreateParameter("@attrval23", SqlDbType.VarChar, attrval23),
                    CreateParameter("@attrval24", SqlDbType.VarChar, attrval24),
                    CreateParameter("@attrval25", SqlDbType.VarChar, attrval25),
                    CreateParameter("@attrval31", SqlDbType.VarChar, attrval31),
                    CreateParameter("@attrval32", SqlDbType.VarChar, attrval32),
                    CreateParameter("@attrval33", SqlDbType.VarChar, attrval33),
                    CreateParameter("@attrval34", SqlDbType.VarChar, attrval34),
                    CreateParameter("@attrval35", SqlDbType.VarChar, attrval35),
                    CreateParameter("@attrval41", SqlDbType.VarChar, attrval41),
                    CreateParameter("@attrval42", SqlDbType.VarChar, attrval42),
                    CreateParameter("@attrval43", SqlDbType.VarChar, attrval43),
                    CreateParameter("@attrval44", SqlDbType.VarChar, attrval44),
                    CreateParameter("@attrval45", SqlDbType.VarChar, attrval45),
                    CreateParameter("@attrval51", SqlDbType.VarChar, attrval51),
                    CreateParameter("@attrval52", SqlDbType.VarChar, attrval52),
                    CreateParameter("@attrval53", SqlDbType.VarChar, attrval53),
                    CreateParameter("@attrval54", SqlDbType.VarChar, attrval54),
                    CreateParameter("@attrval55", SqlDbType.VarChar, attrval55),
                    CreateParameter("@attrval61", SqlDbType.VarChar, attrval61),
                    CreateParameter("@attrval62", SqlDbType.VarChar, attrval62),
                    CreateParameter("@attrval63", SqlDbType.VarChar, attrval63),
                    CreateParameter("@attrval64", SqlDbType.VarChar, attrval64),
                    CreateParameter("@attrval65", SqlDbType.VarChar, attrval65),
                    CreateParameter("@attrval71", SqlDbType.VarChar, attrval71),
                    CreateParameter("@attrval72", SqlDbType.VarChar, attrval72),
                    CreateParameter("@attrval73", SqlDbType.VarChar, attrval73),
                    CreateParameter("@attrval74", SqlDbType.VarChar, attrval74),
                    CreateParameter("@attrval75", SqlDbType.VarChar, attrval75),
                    CreateParameter("@attrval81", SqlDbType.VarChar, attrval81),
                    CreateParameter("@attrval82", SqlDbType.VarChar, attrval82),
                    CreateParameter("@attrval83", SqlDbType.VarChar, attrval83),
                    CreateParameter("@attrval84", SqlDbType.VarChar, attrval84),
                    CreateParameter("@attrval85", SqlDbType.VarChar, attrval85),
                    CreateParameter("@attrval91", SqlDbType.VarChar, attrval91),
                    CreateParameter("@attrval92", SqlDbType.VarChar, attrval92),
                    CreateParameter("@attrval93", SqlDbType.VarChar, attrval93),
                    CreateParameter("@attrval94", SqlDbType.VarChar, attrval94),
                    CreateParameter("@attrval95", SqlDbType.VarChar, attrval95),
                    CreateParameter("@attrval101", SqlDbType.VarChar, attrval101),
                    CreateParameter("@attrval102", SqlDbType.VarChar, attrval102),
                    CreateParameter("@attrval103", SqlDbType.VarChar, attrval103),
                    CreateParameter("@attrval104", SqlDbType.VarChar, attrval104),
                    CreateParameter("@attrval105", SqlDbType.VarChar, attrval105)
                };
            return CreateCommand("prod_attributes_fields_Sp", parameters);
        }
        internal static SqlCommand Productprices(string pcode, double vatamt, double cstamt, int stateId, int allow)
        {
            var parameters = new[]
               {                                        
                   CreateParameter("@pcode", SqlDbType.VarChar, pcode),                   
                   CreateParameter("@vat", SqlDbType.Money, vatamt),                   
                   CreateParameter("@cst", SqlDbType.Money, cstamt),                   
                   CreateParameter("@stateId", SqlDbType.Int, stateId),
                   CreateParameter("@allow", SqlDbType.Int, allow)
                };
            return CreateCommand("Productprices_Sp", parameters);
        }
        internal static SqlCommand ItemCodesGeneration(string pcode, string attr1, string attr2,
                                                            string attr3, string attr4, string attr5, string attr6, string attr7, string attr8, string attr9, string attr10)
        {
            var parameters = new[]
               {                                        
                   CreateParameter("@Pcode", SqlDbType.VarChar, pcode),
                   CreateParameter("@attr1", SqlDbType.VarChar, attr1),
                   CreateParameter("@attr2", SqlDbType.VarChar, attr2),
                   CreateParameter("@attr3", SqlDbType.VarChar, attr3),
                   CreateParameter("@attr4", SqlDbType.VarChar, attr4),
                   CreateParameter("@attr5", SqlDbType.VarChar, attr5),
                   CreateParameter("@attr6", SqlDbType.VarChar, attr6),
                   CreateParameter("@attr7", SqlDbType.VarChar, attr7),
                   CreateParameter("@attr8", SqlDbType.VarChar, attr8),
                   CreateParameter("@attr9", SqlDbType.VarChar, attr9),
                   CreateParameter("@attr10", SqlDbType.VarChar, attr10)
                };
            return CreateCommand("ItemCodesGeneration_Sp", parameters);
        }
        internal static SqlCommand ItemsList(string action, string searchId, Int32 pageIndex, Int32 pageSize)
        {
            var parameters = new[]
                {
                    CreateParameter("@action", SqlDbType.VarChar, action), 
                    CreateParameter("@searchId", SqlDbType.VarChar, searchId),                    
                    CreateParameter("@pageIndex", SqlDbType.BigInt, pageIndex),
                    CreateParameter("@pageSize", SqlDbType.BigInt, pageSize)
                };
            return CreateCommand("ItemsList_Sp", parameters);
        }
        internal static SqlCommand ProductList(string action, string searchId, Int32 pageIndex, Int32 pageSize)
        {
            var parameters = new[]
                {
                    CreateParameter("@action", SqlDbType.VarChar, action), 
                    CreateParameter("@searchId", SqlDbType.VarChar, searchId),                    
                    CreateParameter("@pageIndex", SqlDbType.BigInt, pageIndex),
                    CreateParameter("@pageSize", SqlDbType.BigInt, pageSize)
                };
            return CreateCommand("ProductList_Sp", parameters);
        }
        internal static SqlCommand StatewiseProductTaxs(string action, string pcode)
        {
            var parameters = new[]
                {
                    CreateParameter("@action", SqlDbType.VarChar, action), 
                    CreateParameter("@pcode", SqlDbType.VarChar, pcode) 
                };
            return CreateCommand("StatewiseProductTaxs_Sp", parameters);
        }
        internal static SqlCommand Repurchaseproducts_Update(string pcode, string pname, string remarks, int status, double offprice, double pv, string User, string HSNO, double GST, double MRP, double PRICE)
        {
            var parameters = new[]
                {                     
                    CreateParameter("@pcode", SqlDbType.VarChar, pcode) ,
                    CreateParameter("@pname", SqlDbType.VarChar, pname), 
                    CreateParameter("@remarks", SqlDbType.VarChar, remarks) ,
                    CreateParameter("@status", SqlDbType.Int, status),
                    CreateParameter("@offprice", SqlDbType.Money, offprice),
                    CreateParameter("@pv", SqlDbType.Money, pv),
                    CreateParameter("@User", SqlDbType.VarChar, User), 
                    CreateParameter("@HSNO", SqlDbType.VarChar, HSNO),
                    CreateParameter("@GST", SqlDbType.Money, GST), 
                    CreateParameter("@MRP", SqlDbType.Money, MRP), 
                    CreateParameter("@PRICE", SqlDbType.Money, PRICE)
                };
            return CreateCommand("Repurchaseproducts_Update_sp", parameters);
        }
        internal static SqlCommand ChgPrdDiscPv(string pcode, double oldDisc, double newDisc, double oldpv, double newpv, string changedby, string sesid)
        {
            var parameters = new[]
                {                     
                    CreateParameter("@pcode", SqlDbType.VarChar, pcode) ,
                    CreateParameter("@oldDisc", SqlDbType.Money, oldDisc), 
                    CreateParameter("@newDisc", SqlDbType.Money, newDisc) ,
                    CreateParameter("@oldpv", SqlDbType.Money, oldpv),
                    CreateParameter("@newpv", SqlDbType.Money, newpv),
                    CreateParameter("@changedby", SqlDbType.VarChar, changedby) ,
                    CreateParameter("@sesid", SqlDbType.VarChar, sesid)
                };
            return CreateCommand("ChgPrdDiscPv_Sp", parameters);
        }
        internal static SqlCommand PackageList(string action, string searchId, Int32 pageIndex, Int32 pageSize)
        {
            var parameters = new[]
                {
                    CreateParameter("@action", SqlDbType.VarChar, action), 
                    CreateParameter("@searchId", SqlDbType.VarChar, searchId),                    
                    CreateParameter("@pageIndex", SqlDbType.BigInt, pageIndex),
                    CreateParameter("@pageSize", SqlDbType.BigInt, pageSize)
                };
            return CreateCommand("PackageList_Sp", parameters);
        }
        internal static SqlCommand PackageUpdate(string packcode, string name, Int16 status, string remarks)
        {
            var parameters = new[]
                {
                    CreateParameter("@packcode", SqlDbType.VarChar, packcode), 
                    CreateParameter("@name", SqlDbType.VarChar, name),                    
                    CreateParameter("@status", SqlDbType.Int, status),
                    CreateParameter("@remarks", SqlDbType.VarChar, remarks)
                };
            return CreateCommand("PackageUpdate_Sp", parameters);
        }
        internal static SqlCommand StockInward(string itemCode, int qty, string refno, string remarks, string sesid, string packcode, string batchno, DateTime mfgdate, DateTime expdate)
        {
            var parameters = new[]
                {
                    CreateParameter("@itemCode", SqlDbType.VarChar, itemCode), 
                    CreateParameter("@qty", SqlDbType.Int, qty),                    
                    CreateParameter("@refno", SqlDbType.VarChar, refno),
                    CreateParameter("@remarks", SqlDbType.VarChar, remarks),
                    CreateParameter("@sesid", SqlDbType.VarChar, sesid),
                    CreateParameter("@packcode", SqlDbType.VarChar, packcode),
                    CreateParameter("@batchno", SqlDbType.VarChar, batchno),
                    CreateParameter("@mfgdate", SqlDbType.DateTime, mfgdate),
                    CreateParameter("@expdate", SqlDbType.DateTime, expdate)
                };
            return CreateCommand("StockInward_Sp", parameters);
        }
        internal static SqlCommand StoclLevel(string action, Int32 pageIndex, Int32 pageSize)
        {
            var parameters = new[]
                {
                    CreateParameter("@action", SqlDbType.VarChar, action),                     
                    CreateParameter("@pageIndex", SqlDbType.BigInt, pageIndex),
                    CreateParameter("@pageSize", SqlDbType.BigInt, pageSize)
                };
            return CreateCommand("StoclLevel_Sp", parameters);
        }
        internal static SqlCommand GetAvlQtyforStockAdj(string action, string itemcode)
        {
            var parameters = new[]
                {
                    CreateParameter("@action", SqlDbType.VarChar, action),                     
                    CreateParameter("@Itemcode", SqlDbType.VarChar, itemcode) 
                };
            return CreateCommand("GetAvlQtyforStockAdj_Sp", parameters);
        }
        internal static SqlCommand StockAdjust(string refNo, string fCode, string itemCode, Int16 inward, Int16 outward, string remarks, string sesId)
        {
            var parameters = new[]
                {
                    CreateParameter("@refNo", SqlDbType.VarChar, refNo),
                    CreateParameter("@fCode", SqlDbType.VarChar, fCode),
                    CreateParameter("@itemCode", SqlDbType.VarChar, itemCode), 
                    CreateParameter("@inward", SqlDbType.Int, inward),                    
                    CreateParameter("@outward", SqlDbType.Int, outward),                                       
                    CreateParameter("@remarks", SqlDbType.VarChar, remarks),
                    CreateParameter("@sesId", SqlDbType.VarChar, sesId)                    
                };
            return CreateCommand("StockAdjust_Sp", parameters);
        }
        internal static SqlCommand CourierNames(string action)
        {
            var parameters = new[]
                {
                    CreateParameter("@action", SqlDbType.VarChar, action)  
                };
            return CreateCommand("CourierNames_Sp", parameters);
        }
        internal static SqlCommand GetBatchForBatchOut(string action, string courier, DateTime fromdate, DateTime todate,
                                                       Int32 pageIndex, Int32 pageSize)
        {
            var parameters = new[]
                {
                    CreateParameter("@action", SqlDbType.VarChar, action) ,
                    CreateParameter("@courier", SqlDbType.VarChar, courier) ,
                    CreateParameter("@fromdate", SqlDbType.DateTime, fromdate) ,
                    CreateParameter("@todate", SqlDbType.DateTime, todate) ,
                    CreateParameter("@pageIndex", SqlDbType.BigInt, pageIndex) ,
                    CreateParameter("@pageSize", SqlDbType.BigInt, pageSize) 
                };
            return CreateCommand("GetBatchForBatchOut_Sp", parameters);
        }
        internal static SqlCommand BatchOut(string courier, string invoiceNos, string sesid)
        {
            var parameters = new[]
                {                    
                    CreateParameter("@courier", SqlDbType.VarChar, courier) ,
                    CreateParameter("@InvoiceNos", SqlDbType.VarChar, invoiceNos) ,
                    CreateParameter("@sesid", SqlDbType.VarChar, sesid) 
                };
            return CreateCommand("BatchOut_Sp", parameters);
        }
        internal static SqlCommand StockInwardRpt(string action, DateTime fromdate, DateTime todate,
                                                       Int32 pageIndex, Int32 pageSize)
        {
            var parameters = new[]
                {
                    CreateParameter("@action", SqlDbType.VarChar, action) ,                    
                    CreateParameter("@fromdate", SqlDbType.DateTime, fromdate) ,
                    CreateParameter("@todate", SqlDbType.DateTime, todate) ,
                    CreateParameter("@pageIndex", SqlDbType.BigInt, pageIndex) ,
                    CreateParameter("@pageSize", SqlDbType.BigInt, pageSize) 
                };
            return CreateCommand("StockInwardRpt_Sp", parameters);
        }
        internal static SqlCommand StockOrderRpt(string action, DateTime fromdate, DateTime todate,
                                                      Int32 pageIndex, Int32 pageSize)
        {
            var parameters = new[]
                {
                    CreateParameter("@action", SqlDbType.VarChar, action) ,                    
                    CreateParameter("@fromdate", SqlDbType.DateTime, fromdate) ,
                    CreateParameter("@todate", SqlDbType.DateTime, todate) ,
                    CreateParameter("@pageIndex", SqlDbType.BigInt, pageIndex) ,
                    CreateParameter("@pageSize", SqlDbType.BigInt, pageSize) 
                };
            return CreateCommand("StockOrderRpt_Sp", parameters);
        }
        internal static SqlCommand StockTransforRpt(string action, DateTime fromdate, DateTime todate,
                                                     Int32 pageIndex, Int32 pageSize)
        {
            var parameters = new[]
                {
                    CreateParameter("@action", SqlDbType.VarChar, action) ,                    
                    CreateParameter("@fromdate", SqlDbType.DateTime, fromdate) ,
                    CreateParameter("@todate", SqlDbType.DateTime, todate) ,
                    CreateParameter("@pageIndex", SqlDbType.BigInt, pageIndex) ,
                    CreateParameter("@pageSize", SqlDbType.BigInt, pageSize) 
                };
            return CreateCommand("StockTransforRpt_Sp", parameters);
        }
        internal static SqlCommand StockreturnsRpt(string action, DateTime fromdate, DateTime todate,
                                                    Int32 pageIndex, Int32 pageSize, string searchid)
        {
            var parameters = new[]
                {
                    CreateParameter("@action", SqlDbType.VarChar, action) ,                    
                    CreateParameter("@fromdate", SqlDbType.DateTime, fromdate) ,
                    CreateParameter("@todate", SqlDbType.DateTime, todate) ,
                    CreateParameter("@pageIndex", SqlDbType.BigInt, pageIndex) ,
                    CreateParameter("@pageSize", SqlDbType.BigInt, pageSize) ,
                    CreateParameter("@searchid", SqlDbType.VarChar, searchid) 
                };
            return CreateCommand("stockreturnsRpt_Sp", parameters);
        }
        internal static SqlCommand StockAdjustRpt(string action, DateTime fromdate, DateTime todate,
                                                    Int32 pageIndex, Int32 pageSize)
        {
            var parameters = new[]
                {
                    CreateParameter("@action", SqlDbType.VarChar, action) ,
                    
                    CreateParameter("@fromdate", SqlDbType.DateTime, fromdate) ,
                    CreateParameter("@todate", SqlDbType.DateTime, todate) ,
                    CreateParameter("@pageIndex", SqlDbType.BigInt, pageIndex) ,
                    CreateParameter("@pageSize", SqlDbType.BigInt, pageSize) 
                };
            return CreateCommand("StockAdjustRpt_Sp", parameters);
        }
        internal static SqlCommand StockRejectRpt(string action, string sfcpcode, DateTime fromdate, DateTime todate,
                                                   Int32 pageIndex, Int32 pageSize)
        {
            var parameters = new[]
                {
                    CreateParameter("@action", SqlDbType.VarChar, action) ,  
                    CreateParameter("@sfcpcode", SqlDbType.VarChar, sfcpcode) ,
                    CreateParameter("@fromdate", SqlDbType.DateTime, fromdate) ,
                    CreateParameter("@todate", SqlDbType.DateTime, todate) ,
                    CreateParameter("@pageIndex", SqlDbType.BigInt, pageIndex) ,
                    CreateParameter("@pageSize", SqlDbType.BigInt, pageSize) 
                };
            return CreateCommand("StockRejectRpt_Sp", parameters);
        }
        internal static SqlCommand StockDispatchRpt(string action, DateTime fromdate, DateTime todate,
                                                   Int32 pageIndex, Int32 pageSize, string status, string order, string paytype)
        {
            var parameters = new[]
                {
                    CreateParameter("@action", SqlDbType.VarChar, action) ,                    
                    CreateParameter("@fromdate", SqlDbType.DateTime, fromdate) ,
                    CreateParameter("@todate", SqlDbType.DateTime, todate) ,
                    CreateParameter("@pageIndex", SqlDbType.BigInt, pageIndex) ,
                    CreateParameter("@pageSize", SqlDbType.BigInt, pageSize) ,
                    CreateParameter("@status", SqlDbType.VarChar, status) ,  
                    CreateParameter("@order", SqlDbType.VarChar, order) ,  
                    CreateParameter("@paytype", SqlDbType.VarChar, paytype) 
                };
            return CreateCommand("StockDispatchRpt_Sp", parameters);
        }
        internal static SqlCommand StockDispatchItems(string refno)
        {
            var parameters = new[]
                {
                    CreateParameter("@refno", SqlDbType.VarChar, refno)
                };
            return CreateCommand("StockDispatchItems_Sp", parameters);
        }
        internal static SqlCommand BatchOutRpt(Int32 pageIndex, Int32 pageSize)
        {
            var parameters = new[]
                {                                  
                    CreateParameter("@pageIndex", SqlDbType.BigInt, pageIndex) ,
                    CreateParameter("@pageSize", SqlDbType.BigInt, pageSize)                    
                };
            return CreateCommand("BatchOutRpt_Sp", parameters);
        }
        internal static SqlCommand BatchDetRpt(string despbno)
        {
            var parameters = new[]
                {
                    CreateParameter("@despbno", SqlDbType.VarChar, despbno)
                };
            return CreateCommand("BatchDetRpt_Sp", parameters);
        }
        internal static SqlCommand BatchDetExcel(string despbno)
        {
            var parameters = new[]
                {
                    CreateParameter("@despbno", SqlDbType.VarChar, despbno)
                };
            return CreateCommand("BatchDetExcel_Sp", parameters);
        }
        internal static SqlCommand GetStockforReturns(string action, Int32 pageIndex, Int32 pageSize)
        {
            var parameters = new[]
                {
                    CreateParameter("@action", SqlDbType.VarChar, action),
                    CreateParameter("@pageIndex", SqlDbType.BigInt, pageIndex),
                    CreateParameter("@pageSize", SqlDbType.BigInt, pageSize)
                };
            return CreateCommand("GetStockforReturns_Sp", parameters);
        }
        internal static SqlCommand TmpPackageItems(string action, string randomno, string itemCode, Int32 qty, double price, Int32 rpcId, string pcode, string type, double CV, double GSTPrice)
        {
            var parameters = new[]
                {
                    CreateParameter("@action", SqlDbType.VarChar, action),
                    CreateParameter("@randomno", SqlDbType.VarChar, randomno),
                    CreateParameter("@itemCode", SqlDbType.VarChar, itemCode),
                    CreateParameter("@qty", SqlDbType.BigInt, qty),
                    CreateParameter("@price", SqlDbType.Money, price),
                    CreateParameter("@rpcId", SqlDbType.Money, rpcId),
                    CreateParameter("@pcode", SqlDbType.VarChar, pcode),
                    CreateParameter("@type", SqlDbType.VarChar, type),
                    CreateParameter("@cv", SqlDbType.Money, CV),
                    CreateParameter("@GSTPrice",SqlDbType.Money,GSTPrice)
                };
            return CreateCommand("TmpPackageItems_Sp", parameters);
        }
        internal static SqlCommand PackageMaster(string name, double price, Int32 bv, int pStatus, string remarks,
                                                string plantype, double discamt, double unitcomm, int regType,
                                                string randomno, string sesid)
        {
            var parameters = new[]
                {
                    CreateParameter("@name", SqlDbType.VarChar, name),
                    CreateParameter("@price", SqlDbType.Money, price),
                    CreateParameter("@bv", SqlDbType.BigInt, bv),
                    CreateParameter("@pStatus", SqlDbType.Int, pStatus),
                    CreateParameter("@remarks", SqlDbType.VarChar, remarks),
                    CreateParameter("@plantype", SqlDbType.VarChar, plantype),
                    CreateParameter("@discamt", SqlDbType.Money, discamt),
                    CreateParameter("@unitcomm", SqlDbType.Money, unitcomm),
                    CreateParameter("@regType", SqlDbType.Int, regType),
                    CreateParameter("@randomno", SqlDbType.VarChar, randomno),
                    CreateParameter("@sesid", SqlDbType.VarChar, sesid)
                };
            return CreateCommand("PackageMaster_Sp", parameters);
        }
        internal static SqlCommand CourierStatusRpt(string status, string batchNo, Int32 regid, DateTime fromdate, DateTime todate, Int32 pageIndex, Int32 pageSize)
        {
            var parameters = new[]
                {
                    CreateParameter("@status", SqlDbType.VarChar, status),
                    CreateParameter("@batchNo", SqlDbType.VarChar, batchNo),
                    CreateParameter("@regid", SqlDbType.BigInt, regid),
                    CreateParameter("@fromdate", SqlDbType.DateTime, fromdate),
                    CreateParameter("@todate", SqlDbType.DateTime, todate),
                    CreateParameter("@pageIndex", SqlDbType.BigInt, pageIndex),
                    CreateParameter("@pageSize", SqlDbType.BigInt, pageSize)
                };
            return CreateCommand("CourierStatusRpt_Sp", parameters);
        }
        internal static SqlCommand MyChoicePackageCreation(Int32 pid, string packcode, string name, double price, Int32 bv, int status, string remarks,
                                                double discamt, double unitcomm, int regType)
        {
            var parameters = new[]
                {
                    CreateParameter("@pid", SqlDbType.BigInt, pid),
                    CreateParameter("@packcode", SqlDbType.VarChar, packcode),
                    CreateParameter("@name", SqlDbType.VarChar, name),
                    CreateParameter("@price", SqlDbType.Money, price),
                    CreateParameter("@bv", SqlDbType.BigInt, bv),
                    CreateParameter("@status", SqlDbType.Int, status),
                    CreateParameter("@remarks", SqlDbType.VarChar, remarks),
                    CreateParameter("@discamt", SqlDbType.Money, discamt),
                    CreateParameter("@unitcomm", SqlDbType.Money, unitcomm),
                    CreateParameter("@regType", SqlDbType.Int, regType)
                };
            return CreateCommand("MyChoicePackageCreation_Sp", parameters);
        }
        internal static SqlCommand StkNote(string action, string orderno, string refno)
        {
            var parameters = new[]
                {
                    CreateParameter("@action", SqlDbType.VarChar, action),
                    CreateParameter("@orderno", SqlDbType.VarChar, orderno),
                    CreateParameter("@refno", SqlDbType.VarChar, refno)
                };
            return CreateCommand("StkNote_Sp", parameters);
        }
        internal static SqlCommand GetItemsForStockReturn(string action, string refno)
        {
            var parameters = new[]
                {
                    CreateParameter("@action", SqlDbType.VarChar, action),
                    CreateParameter("@refno", SqlDbType.VarChar, refno)
                };
            return CreateCommand("GetItemsForStockReturn_Sp", parameters);
        }
        internal static SqlCommand ApproveStkReturn(string action, string refno, string remarks)
        {
            var parameters = new[]
                {
                    CreateParameter("@action", SqlDbType.VarChar, action),
                    CreateParameter("@refno", SqlDbType.VarChar, refno),
                    CreateParameter("@remarks", SqlDbType.VarChar, remarks)
                };
            return CreateCommand("ApproveStkReturn_Sp", parameters);
        }
        internal static SqlCommand GetStockforTransfor(string action, string refno, Int32 pageindex, Int32 pagesize)
        {
            var parameters = new[]
                {
                    CreateParameter("@action", SqlDbType.VarChar, action),
                    CreateParameter("@refno", SqlDbType.VarChar, refno),
                    CreateParameter("@pageindex", SqlDbType.BigInt, pageindex),
                    CreateParameter("@pagesize", SqlDbType.BigInt, pagesize)
                };
            return CreateCommand("GetStockforTransfor_Sp", parameters);
        }
        internal static SqlCommand StockTransfer(string refno, string itemCodes, string sesid)
        {
            var parameters = new[]
                {                    
                    CreateParameter("@refno", SqlDbType.VarChar, refno),
                    CreateParameter("@itemCodes", SqlDbType.VarChar, itemCodes),
                    CreateParameter("@sesid", SqlDbType.VarChar, sesid)
                };
            return CreateCommand("StockTransfer_sp", parameters);
        }
        internal static SqlCommand StockReject(string refno, string remarks)
        {
            var parameters = new[]
                {                    
                    CreateParameter("@refno", SqlDbType.VarChar, refno),
                    CreateParameter("@remarks", SqlDbType.VarChar, remarks) 
                };
            return CreateCommand("StockReject_sp", parameters);
        }
        internal static SqlCommand Dispatchs(string action, string dispType, DateTime fromdate, DateTime todate, Int32 pageIndex, Int32 pageSize)
        {
            var parameters = new[]
            {       
                CreateParameter("@action", SqlDbType.VarChar, action),
                CreateParameter("@dispType", SqlDbType.VarChar, dispType),
                CreateParameter("@fromdate", SqlDbType.DateTime, fromdate), 
                CreateParameter("@todate", SqlDbType.DateTime, todate),                                                                                         
                CreateParameter("@pageIndex", SqlDbType.BigInt, pageIndex),
                CreateParameter("@pageSize", SqlDbType.BigInt, pageSize)
            };
            return CreateCommand("Dispatchs_Sp", parameters);
        }
        internal static SqlCommand DispatchItems(string action, string idno)
        {
            var parameters = new[]
            {       
                CreateParameter("@action", SqlDbType.VarChar, action),
                CreateParameter("@idno", SqlDbType.VarChar, idno)
            };
            return CreateCommand("DispatchItems_Sp", parameters);
        }
        internal static SqlCommand DispatchItemCodes(string action, string fullitemcode, string packcode)
        {
            var parameters = new[]
            {       
                CreateParameter("@action", SqlDbType.VarChar, action),
                CreateParameter("@fullitemcode", SqlDbType.VarChar, fullitemcode),
                CreateParameter("@packcode", SqlDbType.VarChar, packcode)
            };
            return CreateCommand("DispatchItemCodes_Sp", parameters);
        }

        internal static SqlCommand CourierMaster(string action)
        {
            var parameters = new[]
            {       
                CreateParameter("@action", SqlDbType.VarChar, action)
            };
            return CreateCommand("CourierMaster_SP", parameters);
        }
        internal static SqlCommand StockDispatch(string action, string fullitemcode, string idno, string courier, string sesid)
        {
            var parameters = new[]
            {       
                CreateParameter("@action", SqlDbType.VarChar, action),
                CreateParameter("@fullitemcode", SqlDbType.VarChar, fullitemcode),
                CreateParameter("@idno", SqlDbType.VarChar, idno),
                CreateParameter("@courier", SqlDbType.VarChar, courier),
                CreateParameter("@sesid", SqlDbType.VarChar, sesid)
            };
            return CreateCommand("StockDispatch_Sp", parameters);
        }
        internal static SqlCommand GetStockforReturn(string action, string refno, Int32 pageindex, Int32 pagesize)
        {
            var parameters = new[]
                {
                    CreateParameter("@action", SqlDbType.VarChar, action),
                    CreateParameter("@refno", SqlDbType.VarChar, refno),
                    CreateParameter("@pageindex", SqlDbType.BigInt, pageindex),
                    CreateParameter("@pagesize", SqlDbType.BigInt, pagesize)
                };
            return CreateCommand("GetStockforReturn_Sp", parameters);
        }
        internal static SqlCommand StockReturn(string refno, string itemCodes, string sfcpcode, string remarks, string sesid)
        {
            var parameters = new[]
                {                    
                    CreateParameter("@refno", SqlDbType.VarChar, refno),
                    CreateParameter("@itemCodes", SqlDbType.VarChar, itemCodes),
                    CreateParameter("@sfcpcode", SqlDbType.VarChar, sfcpcode),
                    CreateParameter("@remarks", SqlDbType.VarChar, remarks),
                    CreateParameter("@sesid", SqlDbType.VarChar, sesid)
                };
            return CreateCommand("StockReturn_Sp", parameters);
        }
        internal static SqlCommand DespBatchExceltoDt(DataTable dt)
        {
            var parameters = new[]
                {                    
                    CreateParameter("@DESPBatchExcel_T", SqlDbType.Structured, dt, "dbo.DESPBatchExcel_T")                    
                };
            return CreateCommand("DespBatchExceltoDt_SP", parameters);
        }
        internal static SqlCommand DespBatchExcel(string action, string invno, string dockNo, DateTime dockDate, string batchNo, string Bank, string idno)
        {
            var parameters = new[]
                {   
                    CreateParameter("@action", SqlDbType.VarChar, action),
                    CreateParameter("@Invno", SqlDbType.VarChar, invno),
                    CreateParameter("@DockNo", SqlDbType.VarChar, dockNo),
                    CreateParameter("@DockDate", SqlDbType.DateTime, dockDate),
                    CreateParameter("@batchNo", SqlDbType.VarChar, batchNo),
                    CreateParameter("@Bank", SqlDbType.VarChar, Bank),
                    CreateParameter("@idno", SqlDbType.VarChar, idno)
                };
            return CreateCommand("DespBatchExcel_SP", parameters);
        }
        internal static SqlCommand DespBatchExcelRpt()
        {
            return CreateCommand("DespBatchExcelRpt_SP");
        }
        internal static SqlCommand UpdateDockDet(string invoiceNos)
        {
            var parameters = new[]
                {   
                    CreateParameter("@invoiceNos", SqlDbType.VarChar, invoiceNos)                
                };
            return CreateCommand("UpdateDockDet_Sp", parameters);
        }
        internal static SqlCommand EstimateStock(string action, string packcodes, string packQtys)
        {
            var parameters = new[]
                {   
                    CreateParameter("@action", SqlDbType.VarChar, action) ,               
                    CreateParameter("@packcodes", SqlDbType.VarChar, packcodes),                
                    CreateParameter("@packQtys", SqlDbType.VarChar, packQtys)                
                };
            return CreateCommand("EstimateStock_SP", parameters);
        }
        internal static SqlCommand ScViewHistory(Int32 sno, Int32 regid, string pcode)
        {
            var parameters = new[]
                {                       
                    CreateParameter("@sno", SqlDbType.BigInt, sno),                
                    CreateParameter("@regid", SqlDbType.BigInt, regid),
                    CreateParameter("@pcode", SqlDbType.VarChar, pcode)
                };
            return CreateCommand("ScViewHistory_SP", parameters);
        }
        internal static SqlCommand AddToCart(Int32 regid, string pcode, Int16 qty, string ipadd, string usertype)
        {
            var parameters = new[]
                {                                           
                    CreateParameter("@regid", SqlDbType.BigInt, regid),
                    CreateParameter("@pcode", SqlDbType.VarChar, pcode),
                    CreateParameter("@qty", SqlDbType.Int, qty),
                    CreateParameter("@ipadd", SqlDbType.VarChar, ipadd),
                    CreateParameter("@usertype", SqlDbType.VarChar, usertype)
                };
            return CreateCommand("AddToCart_SP", parameters);
        }
        internal static SqlCommand MyCartRpt(Int32 regid)
        {
            var parameters = new[]
                {                                           
                    CreateParameter("@regid", SqlDbType.BigInt, regid)                   
                };
            return CreateCommand("MyCartRpt_SP", parameters);
        }
        internal static SqlCommand ChkAvailScProduct(string pcode, Int32 regid)
        {
            var parameters = new[]
                {                                           
                    CreateParameter("@pcode", SqlDbType.VarChar, pcode) , 
                    CreateParameter("@regid", SqlDbType.BigInt, regid)  
                };
            return CreateCommand("chkAvailSCProduct_SP", parameters);
        }
        internal static SqlCommand DelMyCart(Int32 sno, Int32 qty)
        {
            var parameters = new[]
                {                                           
                    CreateParameter("@sno", SqlDbType.BigInt, sno) , 
                    CreateParameter("@qty", SqlDbType.BigInt, qty)  
                };
            return CreateCommand("DelMyCart_SP", parameters);
        }
        internal static SqlCommand GetSCProd_Attributes(string pcode)
        {
            var parameters = new[]
                {                                           
                    CreateParameter("@pcode", SqlDbType.VarChar, pcode)  
                };
            return CreateCommand("GetSCProd_Attributes_SP", parameters);
        }
        internal static SqlCommand shoppe_Attr_fields_clear(Int32 regid, string pcode, string memtype)
        {
            var parameters = new[]
                {   
                    CreateParameter("@regid", SqlDbType.BigInt, regid),                    
                    CreateParameter("@pcode", SqlDbType.VarChar, pcode) ,                    
                    CreateParameter("@memtype", SqlDbType.VarChar, memtype)  
                };
            return CreateCommand("shoppe_Attr_fields_clear_SP", parameters);
        }
        internal static SqlCommand shoppe_Attr_fields(Int32 regid, string pcode, string attributeName, string field, string memtype)
        {
            var parameters = new[]
                {   
                    CreateParameter("@regid", SqlDbType.BigInt, regid),                    
                    CreateParameter("@pcode", SqlDbType.VarChar, pcode) ,
                    CreateParameter("@Attribute_Name", SqlDbType.VarChar, attributeName) ,
                    CreateParameter("@field", SqlDbType.VarChar, field) ,
                    CreateParameter("@memtype", SqlDbType.VarChar, memtype)  
                };
            return CreateCommand("shoppe_Attr_fields_Sp", parameters);
        }
        internal static SqlCommand Getshoppe_Attr_fields(Int32 regid, string pcode, string memtype)
        {
            var parameters = new[]
                {   
                    CreateParameter("@regid", SqlDbType.BigInt, regid),                    
                    CreateParameter("@pcode", SqlDbType.VarChar, pcode)  ,
                    CreateParameter("@memtype", SqlDbType.VarChar, memtype)  
                };
            return CreateCommand("Getshoppe_Attr_fields_Sp", parameters);
        }
        //internal static SqlCommand ScOrder(Int32 regid, string sesid, string mop, double orderamt, string memtype, double shpchrg)
        //{
        //    var parameters = new[]
        //        {   
        //            CreateParameter("@regid", SqlDbType.BigInt, regid),                    
        //            CreateParameter("@sesid", SqlDbType.VarChar, sesid)  ,
        //            CreateParameter("@mop", SqlDbType.VarChar, mop)  ,
        //            CreateParameter("@orderamt", SqlDbType.Money, orderamt)  ,
        //            CreateParameter("@memtype", SqlDbType.VarChar, memtype) ,
        //            CreateParameter("@shpchrg", SqlDbType.Money, shpchrg) 
        //        };
        //    return CreateCommand("SCOrder_SP", parameters);
        //}
        internal static SqlCommand ScOrderInvoice(string action, string reqno, string billno)
        {
            var parameters = new[]
                {   
                    CreateParameter("@action", SqlDbType.VarChar, action),                    
                    CreateParameter("@reqno", SqlDbType.VarChar, reqno)  ,
                    CreateParameter("@billno", SqlDbType.VarChar, billno)  
                };
            return CreateCommand("SCOrderInvoice_SP", parameters);
        }
        internal static SqlCommand ScMyOrders(Int32 regid)
        {
            var parameters = new[]
                {                                           
                    CreateParameter("@regid", SqlDbType.BigInt, regid)  
                };
            return CreateCommand("SCMyOrders_SP", parameters);
        }
        internal static SqlCommand StoresGlance(DateTime date, string user)
        {
            var parameters = new[]
                {                                           
                    CreateParameter("@date", SqlDbType.DateTime, date),
                    CreateParameter("@user", SqlDbType.NVarChar, user) 
                };
            return CreateCommand("StoresGlance_SP", parameters);
        }
        internal static SqlCommand GlanceReport(string action, string rpttype, DateTime ondate, string username, string sts, string searchby, Int32 pageindex, Int32 pagesize)
        {
            var parameters = new[]
                {                                           
                    CreateParameter("@action", SqlDbType.NVarChar, action),
                    CreateParameter("@rpttype", SqlDbType.NVarChar, rpttype),
                    CreateParameter("@ondate", SqlDbType.DateTime, ondate),
                    CreateParameter("@username", SqlDbType.NVarChar, username),
                    CreateParameter("@sts", SqlDbType.NVarChar, sts),
                    CreateParameter("@searchby", SqlDbType.NVarChar, searchby),
                    CreateParameter("@pageindex", SqlDbType.Int, pageindex),
                    CreateParameter("@pagesize", SqlDbType.Int, pagesize)
                };
            return CreateCommand("StoresGlanceReport_SP", parameters);
        }
        internal static SqlCommand CourierDetails(int sno, string CName, string Remarks, string AddedBy, int Status, string Action)
        {
            var parameters = new[]
                {                                           
                    CreateParameter("@Sno", SqlDbType.Int, sno),
                    CreateParameter("@CName", SqlDbType.NVarChar, CName),
                    CreateParameter("@Remarks", SqlDbType.NVarChar, Remarks),
                    CreateParameter("@Addedby", SqlDbType.NVarChar, AddedBy),
                    CreateParameter("@Status", SqlDbType.Int, Status),
                    CreateParameter("@Action", SqlDbType.NVarChar, Action)
                };
            return CreateCommand("InsertCourierDetails_SP", parameters);
        }
        internal static SqlCommand GetAllcategories(string action, string category, string category1, string category2)
        {
            var parameters = new[]
            {
                CreateParameter("@action", SqlDbType.VarChar, action),                
                CreateParameter("@category", SqlDbType.VarChar, category),
                CreateParameter("@category1", SqlDbType.VarChar, category1),
                CreateParameter("@category2", SqlDbType.VarChar, category2)
            };
            return CreateCommand("GetAllcategories_SP", parameters);
        }
        internal static SqlCommand EditOrderItems(string action, string idno, Int32 pid, string itemcode, Int32 packcode, string billno, Int32 prices)
        {
            var parameters = new[]
            {       
                CreateParameter("@action", SqlDbType.VarChar, action),
                CreateParameter("@idno", SqlDbType.VarChar, idno),
                CreateParameter("@pid", SqlDbType.BigInt, pid),
                CreateParameter("@itemcode", SqlDbType.VarChar, itemcode),
                CreateParameter("@packcode", SqlDbType.BigInt, packcode),
                CreateParameter("@billno", SqlDbType.VarChar, billno),
                CreateParameter("@prices", SqlDbType.BigInt, prices),
            };
            return CreateCommand("EditOrderItems_Sp", parameters);
        }
        internal static SqlCommand IHODispatch(string action, string regid, string CourierName, string IHONo, string DockNo, string Approveby)
        {
            var parameters = new[]
            {       
                CreateParameter("@action", SqlDbType.VarChar, action),
                CreateParameter("@regid", SqlDbType.VarChar, regid),
                CreateParameter("@CourierName", SqlDbType.VarChar, CourierName),
                CreateParameter("@IHONo", SqlDbType.VarChar, IHONo),
                CreateParameter("@DockNo", SqlDbType.VarChar, DockNo),
                CreateParameter("@Approveby", SqlDbType.VarChar, Approveby)
            };
            return CreateCommand("IHODispatch_Sp", parameters);
        }
        internal static SqlCommand GVDOfferVouchers(string action, string Packcode, string Voucher, string Offer, string Remarks)
        {
            var parameters = new[]
            {
                CreateParameter("@action", SqlDbType.VarChar, action),                
                CreateParameter("@Packcode", SqlDbType.VarChar, Packcode),
                CreateParameter("@Voucher", SqlDbType.VarChar, Voucher),
                CreateParameter("@Offer", SqlDbType.VarChar, Offer),
                CreateParameter("@Remarks", SqlDbType.VarChar, Remarks)
            };
            return CreateCommand("GVDOfferVouchers_SP", parameters);
        }
        internal static SqlCommand InsertCourierNos(string action, string Courier, string DocNo, string SesUser, string SesID)
        {
            var parameters = new[]
            {
                CreateParameter("@action", SqlDbType.VarChar, action),                
                CreateParameter("@courier", SqlDbType.VarChar, Courier),
                CreateParameter("@docno", SqlDbType.VarChar, DocNo),
                CreateParameter("@SesUser", SqlDbType.VarChar, SesUser),
                CreateParameter("@SesID", SqlDbType.VarChar, SesID)     
            };
            return CreateCommand("S_CourierNos_Sp", parameters);
        }

        internal static SqlCommand StockLevelRpt(string action, string filter, Int32 pageIndex, Int32 pageSize)
        {
            var parameters = new[]
                {
                    CreateParameter("@Action", SqlDbType.VarChar, action),  
                    CreateParameter("@Filter", SqlDbType.VarChar, filter),  
                    CreateParameter("@pageIndex", SqlDbType.BigInt, pageIndex),
                    CreateParameter("@PageSize", SqlDbType.BigInt, pageSize)
                };
            return CreateCommand("StockLevelRpt_Sp", parameters);
        }

       internal static SqlCommand GetFilters(string action,string rpcid, string category,string pname,string price,string cv,string highprice,string highcv,string field)
        {
            var parameters = new[]
                {
                    CreateParameter("@Action", SqlDbType.VarChar, action),
                    CreateParameter("@rpcid",SqlDbType.VarChar,rpcid),                    
                    CreateParameter("@category", SqlDbType.VarChar, category),
                    CreateParameter("@pname", SqlDbType.VarChar, pname), 
                    CreateParameter("@price", SqlDbType.Money,Convert.ToDecimal(price ?? "0")),
                    CreateParameter("@cv", SqlDbType.Money,Convert.ToDecimal(cv ?? "0")),
                    CreateParameter("@highprice", SqlDbType.Money,Convert.ToDecimal(highprice ?? "0")),
                    CreateParameter("@highcv", SqlDbType.Money,Convert.ToDecimal(highcv ?? "0")),
                    CreateParameter("@field", SqlDbType.VarChar, field)
                };
            return CreateCommand("Filters_sp", parameters);
        }
        //rk 10/27/2016
       internal static SqlCommand tempInvOfferPrds(string action, Int32 sno, Int32 pcode, string itemcode, string sesid, string uqid, int regid, string Attrname)
       {
           var parameters = new[]
                {
                    CreateParameter("@action", SqlDbType.VarChar, action),
                    CreateParameter("@sno",SqlDbType.VarChar,sno),                    
                    CreateParameter("@pcode", SqlDbType.VarChar, pcode),
                    CreateParameter("@itemcode", SqlDbType.VarChar, itemcode ?? ""), 
                    CreateParameter("@sesid", SqlDbType.VarChar,sesid),
                    CreateParameter("@uqid", SqlDbType.VarChar,uqid),
                    CreateParameter("@regid", SqlDbType.Int,regid),
                    CreateParameter("@Attrname", SqlDbType.VarChar,Attrname ?? "")
                };
           return CreateCommand("tempInvOfferPrds_sp", parameters);
       }
    }
 


}
