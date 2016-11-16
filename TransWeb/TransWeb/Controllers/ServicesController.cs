using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TransWeb.Controllers
{
    public class ServicesController : Controller
    {
        // GET: Services
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Mobile()
        {
            return View("mobile");
        }

        public ActionResult ApplicationMaintenance()
        {
            return View("ApplicationMaintenance");
        }

        public ActionResult InfrastructureSupport()
        {
            return View("InfrastructureSupport");
        }
        public ActionResult SDLCManagement()
        {
            return View("SDLCManagement");
        }
        public ActionResult QualityAssurance()
        {
            return View("QualityAssurance");
        }
        public ActionResult ReengineeringAndMigration()
        {
            return View("ReengineeringAndMigration");
        }
        public ActionResult SLABasedProdSupport()
        {
            return View("SLABasedProdSupport");
        }
        public ActionResult SoftwareSecurity()
        {
            return View("SoftwareSecurity");
        }
        public ActionResult SystemIntegration()
        {
            return View("SystemIntegration");
        }
        public ActionResult WebHostingSolutions()
        {
            return View("WebHostingSolutions");
        }
        public ActionResult ITILProcess()
        {
            return View("ITILProcess");
        }       
    }
}