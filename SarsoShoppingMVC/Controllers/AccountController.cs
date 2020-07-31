using System;
using System.Globalization;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using SarsoShoppingMVC.Models;
using SarsoShoppingData;

namespace SarsoShoppingMVC.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {

        public ActionResult Register()
        {
            return View();
        }

        public ActionResult VerifySponsor(string SponsorId)
        {
            var SponserDetail = new CheckSponsor_SP_Result();
            try {
                using (var entities = new sarsobizEntities())
                {
                    SponserDetail = entities.CheckSponsor_SP(SponsorId).FirstOrDefault();
                }
            }
            catch (Exception Ex) {

            }
            return Json(SponserDetail,JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult PartialInsertReg(MemberProfile objMem)
        {
            int IsUserCreated = 0;
            try
            {
                using (var entities = new sarsobizEntities())
                {
                    IsUserCreated = entities.PartialInsertReg_Sp("1", objMem.SponserID, "Right", "Mr", objMem.FName, objMem.LName, -1, "", objMem.MobileNo, objMem.Email, objMem.Password, objMem.cnfPassword, HttpContext.Session.SessionID, objMem.Password, "", null, "", "", "", 0, "InsertReg", "", "");
                }
            }
            catch (Exception Ex)
            {

            }
            return Json(IsUserCreated, JsonRequestBehavior.AllowGet);

        }
        }
}