using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QEQg4.Models;


namespace QEQC04.Controllers
{
    public class BackofficeController : Controller
    {
        // GET: Backoffice
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult IniciarSesion()
        {
            return View();
        }
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SubmitRegister(string nombre, string usuario, string password)
        {
            int reg = BD.registerUsuario(nombre, usuario, password);
            reg++;
            /*registerUsuario(nombre, usuario, contraseña);*/

            ViewBag.reg = reg;
            if(reg > 0)
            {
                ViewBag.Message = "Se ha registrado correctamente";
            }
            else
            {
                ViewBag.Message="No se ha registrado";
                
            }
            return View("AfterReg");
        }
        public ActionResult SubmitIniciarSesion(string usuario, string password)
        {
            bool Log = BD.loginUsuario(usuario, password);
            if(Log == true)
            {
                ViewBag.Message = "Contraseña o Usuario Incorrecto";
            }
            else
            {
                return View("HOMEHOME");
            }

            return View();
        }
    }
}