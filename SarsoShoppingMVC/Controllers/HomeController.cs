using SarsoShoppingData;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public ActionResult VerifySponsor(string SponsorId)
        {
            List<GVDPackage> Packages = new List<GVDPackage>();
            try
            {
                using (var entities = new sarsobizEntities())
                {
                    List<object> test = entities.Getrpcategories_SP("BindGvdProduct", "", "").Select(r => 
                                        new object {
                                                
                                        }).ToList();                       

                }
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            return Json("", JsonRequestBehavior.AllowGet);
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

    }
}