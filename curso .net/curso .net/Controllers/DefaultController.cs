using curso.net.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace curso.net.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            Repository R = new Repository();
            var Model = R.GetDemo();
            return View(Model);
        }
    }
}