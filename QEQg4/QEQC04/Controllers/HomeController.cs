using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace QEQC04.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Inicio()
        {
            return View("HOMEHOME");
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {    
            return View();
        }
        public ActionResult Instrucciones()
        {
            return View();
        }
        public ActionResult Volver()
        {
            return View("HOMEHOME");
        }

    }

}