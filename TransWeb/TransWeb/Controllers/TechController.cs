using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TransWeb.Controllers
{
    public class TechController : Controller
    {
        // GET: Tech
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Database()
        {
            return View("Database");
        }
    }
}
