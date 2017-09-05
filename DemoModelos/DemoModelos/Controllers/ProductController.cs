using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoModelos.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Details(int id)
        {

           
            ActionResult Result = null;
            var Repository = new ModelCL.Repository();
            var Model = Repository.GetProductByID(id);
            if (Model != null)
            {

                Result = View(Model);

            }
            else{

                Result = Content("Producto no encontrado");

            }
            return Result;
        }
    }
}