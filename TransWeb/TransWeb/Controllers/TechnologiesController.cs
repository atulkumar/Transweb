using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TransWeb.Controllers
{
    public class TechnologiesController : Controller
    {
        // GET: Technologies
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Database()
        {
            return View("Database");
        }

        public ActionResult Android()
        {
            return View("Android");
        }

        public ActionResult Microsoft_Net()
        {
            return View("Microsoft_Net");
        }

        public ActionResult CloudComputing()
        {
            return View("CloudComputing");
        }

        public ActionResult LegacySoftware()
        {
            return View("LegacySoftware");
        }

        public ActionResult Java()
        {
            return View("Java");
        }

        public ActionResult JavaScriptFramework()
        {
            return View("JavaScriptFramework");
        }

        public ActionResult IOT()
        {
            return View("IOT");
        }

        public ActionResult iOS()
        {
            return View("iOS");
        }
    }
}
