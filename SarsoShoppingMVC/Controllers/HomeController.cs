using PagedList;
using SarsoShoppingData;
using SarsoShoppingMVC.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web.Mvc;

namespace SarsoShoppingMVC.Controllers
{
    public class HomeController : Controller
    {
        ShopRepository objSrepo = null;
        Common objCmn = null;

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
            List<rpcategory> catList = new List<rpcategory>();
            try
            {
                using (var entities = new sarsobizEntities())
                {
                    catList = entities.rpcategories.Where(r=>r.cstatus==true).ToList();
                }
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            return PartialView("_Categories", catList);
        }

        [ChildActionOnly]
        public ActionResult GetCategorySideBar(string Category)
     {
            List<rpcategory> catList = new List<rpcategory>();
            objSrepo = new ShopRepository();
            try
            {
                using (var entities = new sarsobizEntities())
                {
                    catList =  entities.rpcategories.OrderBy(r=>r.sorting).Where(r => r.cstatus == true && r.Category == Category).Distinct().ToList();
                }
                ViewBag.Category = Category;
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            return PartialView("_CategorySideBar", catList);
        }

        public ActionResult ProductList(string Category, string Category1, int? page)

        {
            DataTable dt = new DataTable();
            PagewiseProducts FinalList = new PagewiseProducts();
            objSrepo = new ShopRepository();
            objCmn = new Common();

            if(!String.IsNullOrEmpty(Category1))
               dt = objSrepo.Call_Getrpcategories("SubCatogoryProducts", Category, Category1);
            else
               dt = objSrepo.Call_Getrpcategories("CatogoryProducts", Category, Category1);

            List<repurchaseproduct> productList = new List<repurchaseproduct>();
            productList = objCmn.ConvertDataTable<repurchaseproduct>(dt);
            page = page ?? 1;
            int NoOfRecord = 12;
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
                    MRP = r.MRP,
                    PV = r.pv,
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
            try
            {
                 objProduct = GetProductInfo(ProdID);
            }
            catch (Exception ex)
            {
                throw ex;

            }
            return View(objProduct);
        }

        

        public ProductDetails GetProductInfo(string ProdID)
        {
            ProductDetails objProduct = new ProductDetails();
            objSrepo = new ShopRepository();
            objCmn = new Common();
            try
            {
                DataTable dt = new DataTable();
                dt = objSrepo.Call_Getrpcategories("SC1Product", ProdID, "");

                List<repurchaseproduct> objpList = objCmn.ConvertDataTable<repurchaseproduct>(dt);
                objProduct.product = objpList.Select(r => new repurchaseproduct
                {
                    Descr = !string.IsNullOrEmpty(r.Descr) ? Regex.Replace(r.Descr, @"<[^>]+>|&nbsp;", "").Trim() : "",
                    PCode = r.PCode,
                    PName = r.PName,
                    pcode = r.pcode,
                    Pname = r.Pname,
                    offprice = r.offprice,
                    MRP = r.MRP,
                    PV = r.pv,
                    Category = r.Category,
                    SubCategory = r.SubCategory,
                    SubCategoryone = r.SubCategoryone
                }).FirstOrDefault();

                dt = new DataTable();
                dt = objSrepo.Call_Getrpcategories("SCProd_Attribute_Names", ProdID, "");
                List<Prod_attributes> objProdAttr = objCmn.ConvertDataTable<Prod_attributes>(dt);
                objProduct.productAttr = objProdAttr.ToList();

                dt = new DataTable();
                dt = objSrepo.Call_Getrpcategories("SCProd_Attribute_Fileds", ProdID, "");
                List<Prod_attributes_fields> objProdAttrFields = objCmn.ConvertDataTable<Prod_attributes_fields>(dt);
                objProduct.productAttrFields = objProdAttrFields.ToList();

                dt = new DataTable();
                dt = objSrepo.Call_Getrpcategories("SCProd_Product_images", ProdID, "");
                List<ProductImage> objProdImage = objCmn.ConvertDataTable<ProductImage>(dt);
                objProduct.productImage = objProdImage.ToList();
            }
            catch (Exception ex)
            {
                throw ex;

            }
            return objProduct;
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

        
    }
}