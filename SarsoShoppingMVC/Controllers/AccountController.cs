﻿using System;
using System.Linq;
using System.Web.Mvc;
using SarsoShoppingData;
using System.Diagnostics;
using System.Web.Security;
using SarsoShoppingMVC.Models;
using SarsoBizServices;

namespace SarsoShoppingMVC.Controllers
{

    public class AccountController : Controller
    {
        SiteUtility utility;
        private MemberService objmem;
        public ShopRepository objSRepo = null;
        public Common objCommon = null;

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

        public ActionResult Dashboard()
        {
            objSRepo = new ShopRepository();
            var model = new DashboardViewModel();
            objmem = new MemberService();
            utility = new SiteUtility();

            objCommon = new Common();
            //GetUserProfileDetail(model);
            ViewBag.ModeName = Contants.LAYOUT_HORIZONTAL;
            return View("dashboardView");
        }

        private void GetUserProfileDetail(DashboardViewModel model)
        {
            var regId = Convert.ToString(Session["LoginRegId"]);
            var dt = objSRepo.GetMemberDetail(regId);
            var MemDetailList = objCommon.ConvertDataTable<MemberDetailes_Sp_Result>(dt);
            var MemDetail = new MemberDetailes_Sp_Result();
            if (MemDetailList != null && MemDetailList.Count > 0)
            {
                MemDetail = MemDetailList.FirstOrDefault();
                model.DistributorDetail = new Distributor();
                model.DistributorDetail.RegId = MemDetail.Regid;
                model.DistributorDetail.Name = MemDetail.name;
                //model.DistributorDetail. = MemDetail.Regid;

                var SICPnewdt = objmem.MemberCV("SICPRANKNEW", DateTime.Now, DateTime.Now, Convert.ToInt32(regId));
                if (SICPnewdt.Rows.Count > 0)
                {
                    model.DistributorDetail.Rank = SICPnewdt.Rows[0]["RankName"].ToString();
                }

                dt = objmem.MemberDetailes((Convert.ToInt32(regId)));
                if (dt.Rows.Count > 0)
                {
                    model.ProfileDetail = new MyProfile();
                    model.ProfileDetail.AccountNo = dt.Rows[0]["Accno"].ToString();
                    model.ProfileDetail.BankName = dt.Rows[0]["Bank"].ToString();
                    model.ProfileDetail.BranchName = dt.Rows[0]["Branch"].ToString();
                    model.ProfileDetail.CorrespondenceAdress = dt.Rows[0]["add2"].ToString();
                    model.ProfileDetail.CorrespondenceCity = dt.Rows[0]["CorCity"].ToString();
                    model.ProfileDetail.CorrespondenceDistrict = dt.Rows[0]["corDistrict"].ToString();
                    model.ProfileDetail.CorrespondencePincode = dt.Rows[0]["CorPin"].ToString();
                    model.ProfileDetail.CorrespondenceState = dt.Rows[0]["corstate"].ToString();
                    model.ProfileDetail.dateOfBirth = dt.Rows[0]["Dob"].ToString();
                    model.ProfileDetail.distributorId = dt.Rows[0]["idno"].ToString();
                    model.ProfileDetail.email = dt.Rows[0]["Email"].ToString();
                    model.ProfileDetail.IFSCCode = dt.Rows[0]["ifscode"].ToString();
                    model.ProfileDetail.mobileNo = dt.Rows[0]["Mobile"].ToString();
                    model.ProfileDetail.name = dt.Rows[0]["fName"].ToString() + " " + dt.Rows[0]["lName"].ToString();
                    model.ProfileDetail.NomineeDob = dt.Rows[0]["NomineeDOB"].ToString();
                    model.ProfileDetail.NomineeName = dt.Rows[0]["nominee"].ToString();
                    model.ProfileDetail.PanNo = dt.Rows[0]["panno"].ToString();
                    model.ProfileDetail.PayeeName = dt.Rows[0]["fName"].ToString() + " " + dt.Rows[0]["lName"].ToString();
                    model.ProfileDetail.Relationship = dt.Rows[0]["Relation"].ToString();
                    model.ProfileDetail.sponserId = dt.Rows[0]["spridno"].ToString();
                    model.ProfileDetail.sponserName = dt.Rows[0]["sprname"].ToString();
                }
            }
        }

        private void GetUserOrdersDetail(DashboardViewModel model)
        {
            var regId = Convert.ToString(Session["LoginRegId"]);
            var dt = objmem.MemeberReport(Convert.ToInt32(regId), "SICPRepurRpt", 3, Convert.ToInt32(0), Convert.ToInt32(0));

            //if (dt.Rows.Count > 0)
            //{
            //    gvOrders.DataSource = dt;
            //    gvOrders.DataBind();
            //    if (ViewState["Ordercnt"] != null) return;
            //    ViewState["Ordercnt"] = dt.Rows[0]["totcnt"];
            //    lblorder.Text = "Repurchase Orders(" + dt.Rows.Count + ")";
            //}
            //else
            //{

            //    // dt.Rows.Add(dt.NewRow());
            //    gvOrders.DataSource = dt;
            //    gvOrders.DataBind();
            //    lblorder.Text = "Repurchase Orders(0)";
            //    // GvpkgRpt.Rows[0].Visible = false;
            //}
        }

        public ActionResult Logout()
        {
            Session["LoginUserId"] = null;
            Session["LoginUserName"] = null;
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }

        public ActionResult VerifySponsor(string SponsorId)
        {
            var SponserDetail = new CheckSponsor_SP_Result();
            try
            {
                using (var entities = new sarsobizEntities())
                {
                    SponserDetail = entities.CheckSponsor_SP(SponsorId).FirstOrDefault();
                }
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            return Json(SponserDetail, JsonRequestBehavior.AllowGet);
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
                    var fieldCheck = entities.GetRegFields_Sp("RegFields", objMem.FName, objMem.LName, "", "", objMem.MobileNo, objMem.Email).FirstOrDefault();
                    if (!string.IsNullOrEmpty(fieldCheck))
                    {
                        if (fieldCheck == "SUCC")
                        {
                            IsUserCreated = entities.SP_InsertReg(objMem.UserNo, objMem.SponserID, "Right", "Mr", objMem.FName, objMem.LName, -1, "", objMem.MobileNo, objMem.Email, objutility.Encrypt(objMem.Password), objutility.Encrypt(objMem.cnfPassword), HttpContext.Session.SessionID, objMem.Password, "", null, "", "", "", 0, "InsertReg", "", "").FirstOrDefault() ?? 0;
                            if (IsUserCreated > 0)
                            {
                                objResponse.status = true;
                                objResponse.Message = "Dear " + objMem.FName + " " + objMem.LName + ", You have been successfully registered with SARSO with Login ID " + IsUserCreated + ". Experience the new Art of shopping with www.swadharma.life.";
                            }
                            else
                            {
                                objResponse.status = false;
                                objResponse.Message = "Registration Failed Please try again";
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
                        objResponse.Message = "Please Check First Name (or) Last Name (or) Mobile NO (or) Email ID  Again";
                    }
                }
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            return Json(objResponse, JsonRequestBehavior.AllowGet);
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
                    var LoginCheck = entities.SP_ValidateUser("DistributorLogin", Convert.ToString(objMem.Regid), objutility.Encrypt(objMem.Password)).FirstOrDefault();
                    if (LoginCheck.Result != null && LoginCheck.Result == "success")
                    {
                        objResponse.Message = "success";
                        objResponse.Regid = LoginCheck.Mid ?? 0;
                        Session["LoginUserId"] = LoginCheck.Mid;
                        Session["LoginRegId"] = LoginCheck.Mid;
                        Session["LoginUserName"] = LoginCheck.Name;
                        FormsAuthentication.SetAuthCookie(LoginCheck.Name, false);
                    }
                    else if (LoginCheck.Result != null)
                    {
                        objResponse.Message = LoginCheck.Result;
                    }
                    else
                    {
                        objResponse.Message = "Something Went wrong.";
                    }


                }
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            return Json(objResponse, JsonRequestBehavior.AllowGet);
        }

        protected override void OnException(ExceptionContext filterContext)
        {
            Exception exception = filterContext.Exception;

            EventLog.WriteEntry("Sarso Shopping", filterContext.RouteData.Values["controller"].ToString() + "/" + filterContext.RouteData.Values["action"].ToString(), EventLogEntryType.Error);

            filterContext.ExceptionHandled = true;

            var Result = this.View("Error", new HandleErrorInfo(exception,
                filterContext.RouteData.Values["controller"].ToString(),
                filterContext.RouteData.Values["action"].ToString()));

            filterContext.Result = Result;

        }
    }
}