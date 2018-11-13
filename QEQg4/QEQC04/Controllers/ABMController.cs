using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QEQC04.Models;
using QEQg4.Models;

namespace QEQC04.Controllers
{
    public class ABMController : Controller
    {
        // GET: ABM
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Home()
        {
            return View();
        }
        public ActionResult Usuarios()
        {
            return View();
        }
        public ActionResult Caracteristicas()
        {
            return View();
        }
        public ActionResult Categorias()
        {
            return View();
        }
        public ActionResult Personajes()
        {
            return View();
        }
        //tabla personajes
        public ActionResult PerAlt()
        {
            return View();
        }
        public ActionResult PerBaj()
        {
            return View();
        }
        public ActionResult PerMod()
        {
            return View();
        }
        public ActionResult PerBajCheck(Personaje ronald)
        {
            bool EsValid = BD.ListarxPersonaje(ronald.Id1);
            if(EsValid == false)
            {
                bool SeBorro = BD.BajaPersonaje(ronald.Id1);
                ViewBag.Message = "Se ha eliminado correctamente";
            }
            else
            {
                ViewBag.Message = "No se ha podido eliminar, ya que hay registros en la tabla CaracteristicasxPersonaje con ese Personaje";

            }
            return View("AfterBPer");
        }
        public ActionResult CaracXPersonaje()
        {
            return View();
        }




    }
}