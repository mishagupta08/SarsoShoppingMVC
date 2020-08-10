using System;
using System.Linq;
using System.Web.Mvc;
using SarsoShoppingData;
using System.Diagnostics;

namespace SarsoShoppingMVC.Controllers
{

    public class AccountController : Controller
    {

        public ActionResult SignIn()
        {
            return View();
        }

        public ActionResult Register()
        {
            return View();
        }

        public ActionResult Login()
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
                throw Ex;
            }
            return Json(SponserDetail,JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult PartialInsertReg(MemberProfile objMem)
        {
            Response objResponse = new Response();
            SiteUtility objutility = new SiteUtility();
            int IsUserCreated = 0;
            try
            {
                using (var entities = new sarsobizEntities())
                {
                    var fieldCheck  = entities.GetRegFields_Sp("RegFields", objMem.FName, objMem.LName, "", "", objMem.MobileNo, objMem.Email).FirstOrDefault();
                    if (!string.IsNullOrEmpty(fieldCheck))
                    {
                        if (fieldCheck == "SUCC")
                        {
                            IsUserCreated = entities.PartialInsertReg_Sp(objMem.UserNo, objMem.SponserID, "Right", "Mr", objMem.FName, objMem.LName, -1, "", objMem.MobileNo, objMem.Email, objutility.Encrypt(objMem.Password), objutility.Encrypt(objMem.cnfPassword), HttpContext.Session.SessionID, objMem.Password, "", null, "", "", "", 0, "InsertReg", "", "");
                            if (IsUserCreated > 0)
                            {
                                objResponse.status = true;
                                objResponse.Message = "Dear " + objMem.FName + " " + objMem.LName + ", You have been successfully registered with SARSO, your login details has been sent to your registered mobile number. Experience the new Art of shopping with www.sarsobiz.net.";
                            }
                            else
                            {
                                objResponse.status = false;
                                objResponse.Message = "Partial Guest Registration Failed Please try again";
                            }
                        }
                        else
                        {
                            objResponse.status = false;
                            objResponse.Message = "Mobile No. Already Exists";

                        }
                    }
                    else
                    {
                        objResponse.status = false;
                        objResponse.Message = "Please Check Firsr Name (or) Last Name (or) Mobile NO (or) Email ID  Again";
                    }
                }
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            return Json(IsUserCreated, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult Login(MemberProfile objMem)
        {
            Response objResponse = new Response();
            SiteUtility objutility = new SiteUtility();
            int IsUserCreated = 0;
            try
            {
                using (var entities = new sarsobizEntities())
                {
                    CheckDownto_SP_Result LoginCheck = entities.CheckDownto_SP("DistributorLogin", Convert.ToString(objMem.Regid) , objutility.Encrypt(objMem.Password)).FirstOrDefault();
                    if (LoginCheck.Result!=null)
                    { 
                        
                    }
                }
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            return Json(IsUserCreated, JsonRequestBehavior.AllowGet);
        }

        protected override void OnException(ExceptionContext filterContext)
        {
            Exception exception = filterContext.Exception;

            EventLog.WriteEntry("Sarso Shopping", filterContext.RouteData.Values["controller"].ToString() +"/"+ filterContext.RouteData.Values["action"].ToString(), EventLogEntryType.Error);

            filterContext.ExceptionHandled = true;

            var Result = this.View("Error", new HandleErrorInfo(exception,
                filterContext.RouteData.Values["controller"].ToString(),
                filterContext.RouteData.Values["action"].ToString()));

            filterContext.Result = Result;

        }
    }
}