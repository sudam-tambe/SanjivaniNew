using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SanjivaniBusinessLayer;
using SanjivaniModalView;
namespace Sanjivani.Controllers
{
    public class CPController : Controller
    {
        ClsPartnerBAL objPartnerBAL = new ClsPartnerBAL();
        // GET: CP
        public ActionResult Index()
        {
            CPCchannelPartnerModel list = new CPCchannelPartnerModel();
            return View();
        }
        public ActionResult ChannelPartner()
        {
           
            ViewBag.PaymentMode = new SelectList(objPartnerBAL.GetPaymentmode(), "PaymentModeId", "PaymentMode");
            ViewBag.Accountype = new SelectList(objPartnerBAL.GetAccountType(), "AccountTypeId", "AccountType");
            ViewBag.StateList = new SelectList(objPartnerBAL.GetBindState(), "StateId", "StateName");
            ViewBag.BindCPCategory = new SelectList(objPartnerBAL.GetBindCPCategory(), "CategoryId", "CategoryName");
            ViewBag.BindCompanyType = new SelectList(objPartnerBAL.BindCompanyType(), "Compid", "CompanyName");
            return View();
        }
        public ActionResult _partialCPPartner()
        {
            ViewBag.StateList = new SelectList(objPartnerBAL.GetBindState(), "StateId", "StateName");
            ViewBag.BindCPCategory = new SelectList(objPartnerBAL.GetBindCPCategory(), "CategoryId", "CategoryName");
            return View();
        }
        public ActionResult _partialCPBusinessDetail()
        {
            ViewBag.TypeOfHosting = new SelectList(objPartnerBAL.GetTypeofHosting(), "TypeHostingId", "TypeofHosting");
            ViewBag.HostingPlatForm = new SelectList(objPartnerBAL.GetHostingPlatform(), "HostingPlatformId", "HostingPlatForm");
            ViewBag.StateList = new SelectList(objPartnerBAL.GetBindState(), "StateId", "StateName");
            ViewBag.BindCompanyType = new SelectList(objPartnerBAL.BindCompanyType(), "Compid", "CompanyName");
            return View();
        }
        public ActionResult _partialCPBankDetail()
        {
            ViewBag.bank = new SelectList(objPartnerBAL.GetBank(), "BankId", "BankName");
            ViewBag.PaymentMode = new SelectList(objPartnerBAL.GetPaymentmode(), "PaymentModeId", "PaymentMode");
            ViewBag.Accountype = new SelectList(objPartnerBAL.GetAccountType(), "AccountTypeId", "AccountType");
            return View();
        }
        public ActionResult _partialCPDocument()
        {
            return View();
        }
    }
}