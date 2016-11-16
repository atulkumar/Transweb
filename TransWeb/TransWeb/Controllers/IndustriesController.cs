using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TransWeb.Controllers
{
    public class IndustriesController : Controller
    {
        // GET: Industries
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Insurance()
        {
            return View("Insurance");
        }

        public ActionResult ELearningAndEducation()
        {
            return View("ELearningAndEducation");
        }

        public ActionResult FinanceAndBanking()
        {
            return View("FinanceAndBanking");
        }


        public ActionResult GameAndEntertainment()
        {
            return View("GameAndEntertainment");
        }

        public ActionResult Healthcare()
        {
            return View("Healthcare");
        }

        public ActionResult Hospitality()
        {
            return View("Hospitality");
        }

        public ActionResult Legal()
        {
            return View("Legal");
        }

        public ActionResult Payments()
        {
            return View("Payments");
        }

        public ActionResult Retail()
        {
            return View("Retail");
        }

        public ActionResult SupplyChain()
        {
            return View("SupplyChain");
        }

        public ActionResult Telecommunication()
        {
            return View("Telecommunication");
        }

        public ActionResult Utilities()
        {
            return View("Utilities");
        }
    }
}
