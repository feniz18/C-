using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace cursoaspnet.Controllers
{
    public class ProductoController : Controller
    {
        // GET: Producto
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Buscar()
        {
            String nombreProducto = RouteData.Values["nombreProducto"].ToString();
            nombreProducto = Server.HtmlEncode(nombreProducto);
            string resultado = String.Empty;

            switch (nombreProducto)
            {

                case "PC":
                    {

                        resultado = "Disponibles 4 unidades.";
                        break;
                    }
                case "RAM":
                    {

                        resultado = "Disponibles 2 unidades.";
                        break;
                    }
                default:
                    {

                        resultado = String.Format("El producto {0} no existe en stock",nombreProducto);
                        break;
                    }


            }

            return Content("<p>" + resultado + "</p>");
        }
    }
}