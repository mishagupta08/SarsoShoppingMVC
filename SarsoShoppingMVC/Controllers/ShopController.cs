using SarsoShoppingData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SarsoShoppingMVC.Controllers
{
    public class ShopController : Controller
    {
        // GET: Shop
        public ActionResult AddProductInToCart(String ProductCode,int Qty)
        {
            int? count = 0;
            try
            {
                using (var entities = new sarsobizEntities())
                {
                   var news = entities.TempCart_SP("Add", "test", "1854", "28470160380155", "", Qty).FirstOrDefault();
                    if (news.result == "")
                    {
                         count = entities.TempCarts.Where(r => r.UNQId == "test").Select(r=>r.Qty).Sum();
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return Json(count, JsonRequestBehavior.AllowGet);
        }
    }
}