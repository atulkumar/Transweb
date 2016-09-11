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

        public ActionResult Insurence()
        {
            return View("Insurence");
        }
    }
}
