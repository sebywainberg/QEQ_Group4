using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QEQC04.Models;

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
            usuario abc = Session["Usuario"] as usuario;
            if (abc != null && abc.EsAdmin1 == true)
            {
                List<Categoria> Lista = BD.ListarCategorias();
                ViewBag.ListaCategorias = Lista;
                return View();
            }
            else
            {
                return RedirectToAction("IniciarSesion", "Backoffice");
            }
        }
        public ActionResult PerBaj()
        {
            usuario abc = Session["Usuario"] as usuario;
            if (abc != null && abc.EsAdmin1 == true)
            {
                return View();
            }
            else
            {
                return RedirectToAction("IniciarSesion", "Backoffice");
            }
        }
        public ActionResult PerMod()
        {
            usuario abc = Session["Usuario"] as usuario;
            if (abc.EsAdmin1 == true)
            {
                List<Categoria> Lista = BD.ListarCategorias();
                ViewBag.ListaCategorias = Lista;
                return View();
            }
            else
            {
                return RedirectToAction("IniciarSesion", "Backoffice");
            }

        }
        public ActionResult PerBajCheck(Personaje ronald)
        {
            bool EsValid = BD.ListarxPersonaje(ronald.Id1);
            if (EsValid == false)
            {
                bool SeBorro = BD.BajaPersonaje(ronald.Id1);
                ViewBag.Message = "Se ha eliminado correctamente";
            }
            else
            {
                ViewBag.Message = "No se ha podido eliminar, ya que hay registros en la tabla CaracteristicasxPersonaje con ese Personaje";

            }
            return View("Home");
        }
       /* public ActionResult CaracXPersonaje()
        {
            usuario abc = Session["Usuario"] as usuario;
            if (abc != null && abc.EsAdmin1 == true)
            {
                return View();
            }
            else
            {
                return RedirectToAction("IniciarSesion", "Backoffice");
            }
        }*/

        [HttpPost]
        public ActionResult SumbitAPer(Personaje a)
        {

            bool esOk = BD.AltaPersonaje(a);
            if (esOk == true)
            {
                ViewBag.Message = "No se pudo realizar la alta";
                return View("PerAlt", a);
            }
            else
            {
                ViewBag.Message = "La alta se ha registrado correctamente";
            }
            return View("Home");
        }
        public ActionResult SumbitMPer(Personaje f)
        {
            bool esOk = BD.ModPersonaje(f);
            if (esOk == true)
            {
                ViewBag.Message = "No se pudo realizar la modificacion";
                return View("PerMod", f);
            }
            else
            {
                ViewBag.Message = "La modificacion se ha realizado correctamente";
            }
            return View("Home");
        }
        public ActionResult CatMod()
        {
            usuario abc = Session["Usuario"] as usuario;
            if (abc != null && abc.EsAdmin1 == true)
            {
                return View();
            }
            else
            {
                return RedirectToAction("IniciarSesion", "Backoffice");
            }
        }
        public ActionResult CatAlt()
        {
            usuario abc = Session["Usuario"] as usuario;
            if (abc != null && abc.EsAdmin1 == true)
            {
                return View();
            }
            else
            {
                return RedirectToAction("IniciarSesion", "Backoffice");
            }
        }
        public ActionResult CatBaj()
        {
            usuario abc = Session["Usuario"] as usuario;
            if (abc != null && abc.EsAdmin1 == true)
            {
                return View();
            }
            else
            {
                return RedirectToAction("IniciarSesion", "Backoffice");
            }

        }
        public ActionResult CatBajCheck(Categoria ronald)
        {

            bool EsValid = BD.ListarxCategoria(ronald.IdCategoria);
            if (EsValid == false)
            {
                bool SeBorro = BD.BajaCategoria(ronald.IdCategoria);
                ViewBag.Message = "Se ha eliminado correctamente";
            }
            else
            {
                ViewBag.Message = "No se ha podido eliminar, ya que hay registros en la tabla Personaje con esa Caracteristica";

            }
            return View("Home");
        }
        public ActionResult SumbitACat(Categoria w)
        {
            bool esOk = BD.AltaCategoria(w);
            if (esOk == true)
            {
                ViewBag.Message = "No se pudo realizar la alta";
                return View("CatAlt", w);
            }
            else
            {
                ViewBag.Message = "La alta se ha realizado correctamente";
            }
            return View("Home");
        }
        public ActionResult SumbitMCat(Categoria f)
        {
            bool esOk = BD.ModCategoria(f);
            if (esOk == true)
            {
                ViewBag.Message = "No se pudo realizar la modificacion";
                return View("CatMod", f);
            }
            else
            {
                ViewBag.Message = "La modificacion se ha realizado correctamente";
            }
            return View("Home");
        }
        public ActionResult CaracMod()
        {
            usuario abc = Session["Usuario"] as usuario;
            if (abc != null && abc.EsAdmin1 == true)
            {
                return View();
            }
            else
            {
                return RedirectToAction("IniciarSesion", "Backoffice");
            }
        }
        public ActionResult CaracAlt()
        {
            usuario abc = Session["Usuario"] as usuario;
            if (abc != null && abc.EsAdmin1 == true)
            {
                return View();
            }
            else
            {
                return RedirectToAction("IniciarSesion", "Backoffice");
            }
        }
        public ActionResult CaracBaj()
        {
            usuario abc = Session["Usuario"] as usuario;
            if (abc != null && abc.EsAdmin1 == true)
            {
                return View();
            }
            else
            {
                return RedirectToAction("IniciarSesion", "Backoffice");
            }
        }
        public ActionResult SumbitACarac(Caracteristica m)
        {
            bool esOk = BD.AltaCaracteristica(m);
            if (esOk == true)
            {
                ViewBag.Message = "No se pudo realizar la alta";
                return View("CaracAlt", m);
            }
            else
            {
                ViewBag.Message = "La alta se ha realizado correctamente";
            }
            return View("Home");
        }
        public ActionResult CaracBajCheck(Caracteristica ron)
        {

            bool EsValid = BD.ListarxCategoria(ron.IdCarac);
            if (EsValid == false)
            {
                bool SeBorro = BD.BajaCategoria(ron.IdCarac);
                ViewBag.Message = "Se ha eliminado correctamente";
            }
            else
            {
                ViewBag.Message = "No se ha podido eliminar, ya que hay registros en la tabla Personaje con esa Caracteristica";

            }
            return View("Home");
        }
        public ActionResult SumbitMCarac(Caracteristica d)
        {
            bool esOk = BD.ModCaracteristica(d);
            if (esOk == true)
            {
                ViewBag.Message = "No se pudo realizar la modificacion";
                return View("CaracMod", d);
            }
            else
            {
                ViewBag.Message = "La modificacion se ha realizado correctamente";
            }
            return View("Home");
        }
        public ActionResult UserBaj()
        {
            usuario abc = Session["Usuario"] as usuario;
            if (abc != null && abc.EsAdmin1 == true)
            {
                return View();
            }
            else
            {
                return RedirectToAction("IniciarSesion", "Backoffice");
            }
        }
        public ActionResult UserMod()
        {
            usuario abc = Session["Usuario"] as usuario;
            if (abc != null && abc.EsAdmin1 == true)
            {
                return View();
            }
            else
            {
                return RedirectToAction("IniciarSesion", "Backoffice");
            }
        }
        public ActionResult UserBajCheck(usuario r)
        {

            bool EsValid = BD.ListarxUsuario(r.Id1);
            if (EsValid == true)
            {
                bool SeBorro = BD.BajaUsuario(r.Id1);
                if (SeBorro == true)
                {
                    ViewBag.Message = "Se ha eliminado correctamente";
                }
                else
                {
                    ViewBag.Message = "No se ha podido eliminar dicho usuario";
                }
            }
            return View("Home");
        }
        public ActionResult SumbitMuser(usuario d)
        {
            bool esOk = BD.ModUsuario(d);
            if (esOk == true)
            {
                ViewBag.Message = "No se pudo realizar la modificacion";
                return View("UserMod", d);
            }
            else
            {
                ViewBag.Message = "La modificacion se ha realizado correctamente";
            }
            return View("Home");
        }
        public ActionResult CaracXPersonaje()
        {
                
                List<Personaje> ab = new List<Personaje>();
                ab = BD.ListarxPersonaje2();
                ViewBag.ListarxPersonaje2 = ab;
                return View();
        }
    }
}