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
        public ActionResult CerrarSesion()
        {
            Session["Usuario"] = null;
            return RedirectToAction("HOMEHOME","Home");
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
        public ActionResult SubmitRegister(usuario user)
        {
            if(ModelState.IsValid)
            {
                bool reg = BD.registerUsuario(user);
                
                /*registerUsuario(nombre, usuario, contraseña);*/

                ViewBag.reg = reg;
                if (reg == false)
                {
                    Session["Usuario"] = user;
                    ViewBag.Message = "¡Se ha registrado correctamente!";
                }
                else
                {
                    ViewBag.Message = "No se ha registrado";

                }
            }
            else
            {
                return View("Register", user);
            }
            return View("AfterReg");
        }
        public ActionResult SubmitIniciarSesion(usuario user)
        {
            if (ModelState.IsValidField("Username1") && (ModelState.IsValidField("Password1")))
            {
                bool Log = BD.loginUsuario(user);
                if (Log)
                {
                    Session["Usuario"] = user;
                    if (user.EsAdmin1)
                    {
                        return View("AfterLog", user);
                    }
                    else
                    {
                        return RedirectToAction("HOMEHOME", "Home");
                    }
                }
                else
                {
                    ViewBag.ErrorMessage = "Contraseña o Usuario Incorrecto";
                    return View("IniciarSesion", user);
                    
                }
               
            }
            else
            {
                return View("IniciarSesion", user);
            }
        }

    }
     
}