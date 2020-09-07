using PagedList;
using SarsoShoppingData;
using SarsoShoppingMVC.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Web.Mvc;

namespace SarsoShoppingMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult StartYourBusiness()
        {
            return View();
        }

        [ChildActionOnly]
        public ActionResult GetCategories()
        {
            List<string> catList = new List<string>();
            try
            {
                using (var entities = new sarsobizEntities())
                {
                    catList = entities.rpcategories.Select(r => r.Category).Distinct().ToList();
                }
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            return PartialView("_Categories", catList);
        }

        public ActionResult ProductList(string Category, string Category1, int? page)
        {
            DataTable dt = new DataTable();
            PagewiseProducts FinalList = new PagewiseProducts();
            ShopRepository objSrepo = new ShopRepository();

            dt = objSrepo.Call_Getrpcategories("CatogoryProducts", Category, "");

            List<repurchaseproduct> productList = new List<repurchaseproduct>();
            productList = ConvertDataTable<repurchaseproduct>(dt);
            page = page ?? 1;
            int NoOfRecord = 20;
            double totalcount = 0;
            if (productList != null)
            {
                totalcount = productList.Count;
                productList = (productList.Skip(((page ?? 1) - 1) * NoOfRecord).Take(NoOfRecord)).ToList();
                productList = productList.Select(r => new repurchaseproduct
                {
                    Descr = !string.IsNullOrEmpty(r.Descr) ? Regex.Replace(r.Descr, @"<[^>]+>|&nbsp;", "").Trim() : "",
                    PCode = r.PCode,
                    PName = r.PName,
                    pcode = r.pcode,
                    Pname = r.Pname,
                    offprice = r.offprice,
                    Category = r.Category,
                    SubCategory = r.SubCategory,
                    SubCategoryone = r.SubCategoryone
                }).ToList();
            }

            FinalList.ProductList = productList;
            var list = new List<int>();
            for (var i = 1; i <= totalcount; i++)
            {
                list.Add(i);
            }

            FinalList.pagerCount = list.ToPagedList(Convert.ToInt32(page ?? 1), NoOfRecord);
            ViewBag.Category = Category;
            ViewBag.Category1 = Category1;

            return View("ProductList", FinalList);
        }

        public ActionResult ProductDetail(string ProdID)
        {
            ProductDetails objProduct = new ProductDetails();
            ShopRepository objSrepo = new ShopRepository();
            try
            {
                DataTable dt = new DataTable();
                dt = objSrepo.Call_Getrpcategories("SC1Product", ProdID, "");

                List<repurchaseproduct> objpList = ConvertDataTable<repurchaseproduct>(dt);
                objProduct.product = objpList.Select(r => new repurchaseproduct
                {
                    Descr = !string.IsNullOrEmpty(r.Descr) ? Regex.Replace(r.Descr, @"<[^>]+>|&nbsp;", "").Trim() : "",
                    PCode = r.PCode,
                    PName = r.PName,
                    pcode = r.pcode,
                    Pname = r.Pname,
                    offprice = r.offprice,
                    Category = r.Category,
                    SubCategory = r.SubCategory,
                    SubCategoryone = r.SubCategoryone
                }).FirstOrDefault();

                dt = new DataTable();
                dt = objSrepo.Call_Getrpcategories("SCProd_Attribute_Names", ProdID, "");
                List<Prod_attributes> objProdAttr = ConvertDataTable<Prod_attributes>(dt);
                objProduct.productAttr = objProdAttr.ToList();

                dt = new DataTable();
                dt = objSrepo.Call_Getrpcategories("SCProd_Attribute_Fileds", ProdID, "");
                List<Prod_attributes_fields> objProdAttrFields = ConvertDataTable<Prod_attributes_fields>(dt);
                objProduct.productAttrFields = objProdAttrFields.ToList();

                dt = new DataTable();
                dt = objSrepo.Call_Getrpcategories("SCProd_Product_images", ProdID, "");
                List<ProductImage> objProdImage = ConvertDataTable<ProductImage>(dt);
                objProduct.productImage = objProdImage.ToList();
            }
            catch (Exception ex)
            {
                throw ex;

            }
            return View(objProduct);
        }

        public ActionResult Neeti()
        {
            return View();
        }

        public ActionResult Swadharma()
        {
            return View();
        }

        public ActionResult SwadharmaStory()
        {
            return View();
        }

        public ActionResult Tamra()
        {
            return View();
        }

        public ActionResult Sootram()
        {
            return View();
        }

        public ActionResult FAQ()
        {
            return View();
        }

        public ActionResult ContactUs()
        {
            return View();
        }

        public ActionResult HoDoIPay()
        {
            return View();
        }

        public ActionResult ReturnAProduct()
        {
            return View();
        }

        public ActionResult TermsAndConditions()
        {
            return View();
        }

        public ActionResult PrivacyPolicy()
        {
            return View();
        }

        private static List<T> ConvertDataTable<T>(DataTable dt)
        {
            List<T> data = new List<T>();
            foreach (DataRow row in dt.Rows)
            {
                T item = GetItem<T>(row);
                data.Add(item);
            }
            return data;
        }
        private static T GetItem<T>(DataRow dr)
        {
            Type temp = typeof(T);
            T obj = Activator.CreateInstance<T>();

            foreach (DataColumn column in dr.Table.Columns)
            {
                foreach (PropertyInfo pro in temp.GetProperties())
                {
                    if (pro.Name == column.ColumnName)
                        pro.SetValue(obj, dr[column.ColumnName], null);
                    else
                        continue;
                }
            }
            return obj;
        }

    }
}