using model.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using model.neg;

namespace WebApplication1.Controllers
{
    public class AlumnoController : Controller
    {
        private AlumnoNeg objAlumnoNeg;

        public AlumnoController()
        {


            objAlumnoNeg = new AlumnoNeg();
        }
        // GET: Alumno
        public ActionResult Inicio()
        {
            List<Alumno> lista = objAlumnoNeg.findAll();
            return View(lista);
        }
        [HttpGet]
        public ActionResult create(Alumno objAlumno)
        {

            return View();

        }

        [HttpPost]
        public ActionResult Create(Alumno objAlumno)
        {
            mensajeInicio();
            objAlumnoNeg.create(objAlumno);
            mensajeErrorRegistro(objAlumno);

            return View();

        }

        public void mensajeInicio()
        {
            ViewBag.mensajeInicio = "Formulario de registro de alumnos";

        }

        public void mensajeErrorRegistro(Alumno objAlumno)
        {

            switch (objAlumno.Estado)
            {
                case 10:
                    ViewBag.mensajeError = "Campo Codigo Esta Vacio";
                    break;
                case 100:
                    ViewBag.mensajeError = "Solo se permiten numeros";
                    break;
                case 1:
                    ViewBag.mensajeError = "Excedio la longitud de la cadena en el campo idCliente, solo se permiten 2 caracteres de tipo numero";
                    break;
                case 20:

                    ViewBag.mensajeError = "El Campo nombre esta vacio";
                    break;
                case 2:

                    ViewBag.mensajeError = "Excedio la longitud de la cadena en el campo Nombre, solo se permiten 50 caracteres";
                    break;
                case 30:

                    ViewBag.mensajeError = "El Campo apellido esta vacio";
                    break;
                case 3:

                    ViewBag.mensajeError = "Excedio la longitud de la cadena en el campo apellido, solo se permiten 50 caracteres";
                    break;
                case 40:

                    ViewBag.mensajeError = "El Campo telefono esta vacio";
                    break;
                case 4:

                    ViewBag.mensajeError = "Excedio la longitud de la cadena en el campo telefono, solo se permiten 12 caracteres";
                    break;
                case 5:

                    ViewBag.mensajeError = "Alumno["+objAlumno.IdAlumno+"] ya esta registrado";
                    break;
                case 99:
                    ViewBag.mensajeError = "Alumno[" + objAlumno.IdAlumno + "] fue registrado con exito";
                    break;
            }

        }
    }
}