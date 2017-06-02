using Simple.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Simple.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpPost]
        public JsonResult AjaxMethod(string name)
        {

            PersonaModel persona = new PersonaModel
            {
                Nombre = name,
                DateTime = DateTime.Now.ToString()
            };

            return Json(persona);
        }
    }
}