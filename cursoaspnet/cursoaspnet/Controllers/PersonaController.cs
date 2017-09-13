using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using cursoaspnet.Models;

namespace cursoaspnet.Controllers
{
    public class PersonaController : Controller
    {
        // GET: Persona
        public ActionResult Persona()
        {
            Persona obj = new Persona();
            obj.edad = Convert.ToInt32(Request.Form["edad"]);
            obj.nombre = Request.Form["nombre"].ToString();
            obj.apellido =  Request.Form["apellido"].ToString();

            return View(obj);
        }
        public ActionResult Index()
        {

            return View();

        }
    }
}