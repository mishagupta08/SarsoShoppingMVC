using PagedList;
using SarsoShoppingData;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Web;
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

        public ActionResult ProductList(string Category, string Category1,int? page)
         {
            DataTable dt = new DataTable();
            PagewiseProducts FinalList = new PagewiseProducts();
            string constr = ConfigurationManager.ConnectionStrings["sarsobizServices"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("Getrpcategories_SP"))
                {
                    cmd.Parameters.Add("@action", SqlDbType.VarChar).Value = "CatogoryProducts";                     
                    cmd.Parameters.Add("@category", SqlDbType.VarChar).Value = Category;
                    cmd.Parameters.Add("@category1", SqlDbType.VarChar).Value = "";

                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {                        
                        sda.Fill(dt);
                    }
                }
            }

            List<repurchaseproduct> productList = new List<repurchaseproduct>();
            productList = ConvertDataTable<repurchaseproduct>(dt);
            page = page ?? 1;
            int NoOfRecord = 20;
            double totalcount = 0;
            if (productList != null)
            {
                totalcount = productList.Count;
                productList = (productList.Skip(((page ?? 1) - 1) * NoOfRecord).Take(NoOfRecord)).ToList();
                productList = productList.Select(r=>new repurchaseproduct {
                    Descr = !string.IsNullOrEmpty(r.Descr) ?Regex.Replace(r.Descr, @"<[^>]+>|&nbsp;", "").Trim() : "",
                    PCode = r.PCode,
                    PName = r.PName,
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

        public ActionResult Neeti()
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