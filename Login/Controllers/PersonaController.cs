using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Login.Controllers
{
    public class PersonaController : Controller
    {
        // GET: Persona
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult procesar(String usuario, String DUI) {

            if (usuario.Equals("Jose")&& DUI.Equals("12345678")) {
                return Redirect("/Persona/segundavista");

               
            }else
            return Redirect("/Persona/Index");
        }

        public ActionResult segundavista() {

            return View();
        }


        public object MostrarDatosPrecesados(String nombre, String hrstrab, String antiguedad, String valorH) {

            ViewBag.nombre = nombre;
            ViewBag.valorh = valorH;
            ViewBag.antiguedad = antiguedad;
            ViewBag.hrstrab = hrstrab;

            float totalacobrar = float.Parse(valorH) * float.Parse(hrstrab) + float.Parse(antiguedad) * 30;
            ViewBag.total = totalacobrar;


            float totaldeldescuento = (float)(totalacobrar * 0.13);
            ViewBag.totaldes = totaldeldescuento;


            float totalcondescuento = totalacobrar - totaldeldescuento;
            ViewBag.totalcondes = totalcondescuento;
            
            return View();
        }
    }
}