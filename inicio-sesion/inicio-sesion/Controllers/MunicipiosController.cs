using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using inicio_sesion.Models;

namespace inicio_sesion.Controllers
{
   public class MunicipiosController : Controller
    {

        private ProyectoEntities db = new ProyectoEntities();
        private static string mensaje = string.Empty;
        private static string clase = string.Empty;

        // GET: Municipios
        public ActionResult Index()
        {
            return View();
        }

        // GET: Municipios/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Municipios/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Municipios/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Municipios/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Municipios/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Municipios/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Municipios/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }



        [HttpPost]
        public JsonResult GetMunicipios(int id)
        {
            var muni = db.Municipios.Where(x => x.IdDepartamento.Equals(id)).ToList();
            var lista = muni.Select(x => new SelectListItem { Text = x.Nombre, Value = x.IdMunicipio.ToString() }).ToList();
            return this.Json(lista.ToArray(), JsonRequestBehavior.AllowGet);
        }


        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }


    }
}