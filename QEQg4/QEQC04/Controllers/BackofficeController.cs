using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QEQC04.Models;


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
            registerUsuario(nombre, usuario, contraseña);

            return View();
        }
        public ActionResult SubmitIniciarSesion(string usuario, string contraseña)
        {

            return View();
        }
    }
}