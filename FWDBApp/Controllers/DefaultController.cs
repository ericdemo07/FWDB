using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FWDBApp.Models;

namespace FWDBApp.Controllers
{
    public class DefaultController : Controller
    {
        private FrameworkModel model = new FrameworkModel();

        // GET: Default
        public ActionResult Initiator()
        {
            return View();
        }

        public ActionResult Index()
        {
            System.Diagnostics.Debug.WriteLine("Hello to you "+ model.Frameworks.ToList().Count);

            return View(model.Frameworks.ToList());
        }

        [HttpPost]
        public ActionResult GetFrameworkDetail()
        {
            return Json(model.Frameworks.ToList());
        }
    }
}