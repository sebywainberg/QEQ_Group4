using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
<<<<<<< HEAD
using QEQg4.Models;

=======
>>>>>>> 30c68f61114c8e5b6746b8b8d47bd59bf1cfe620


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
        public ActionResult SubmitRegister(string nombre, string usuario, string contraseña)
        {
<<<<<<< HEAD
            int reg = BD.registerUsuario(nombre, usuario, contraseña);
=======

            /*registerUsuario(nombre, usuario, contraseña);*/
>>>>>>> 30c68f61114c8e5b6746b8b8d47bd59bf1cfe620

            ViewBag.reg = reg;
            if(reg > 0)
            {
                ViewBag.Message="Se ha registrado correctamente";
                    }
            else
            {
                ViewBag.Message="No se ha registrado";
                
            }
            return View("AfterReg");
        }
        public ActionResult SubmitIniciarSesion(string usuario, string contraseña)
        {
            bool Log = true; 
                //BD.loginUsuario(usuario, contraseña);
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