using MVC3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC3.Controllers
{
    public class ProductosController : Controller
    {

        List<Datos> producto = new List<Datos>();

        public ProductosController()
        {

            Datos obj = new Datos();
            obj.descripcion = "manzana";
            obj.cantidad = 8;
            obj.precio = 25.20m;
            producto.Add(obj);

            Datos obj2 = new Datos();
            obj.descripcion = "Bananas";
            obj.cantidad = 25;
            obj.precio = 20.20m;
            producto.Add(obj);

        }

        // GET: Productos
        public ViewResult MostrarProductos(int id)
        {
            Datos obj1 = producto[id];
            return View(obj1);
        }
    }
}