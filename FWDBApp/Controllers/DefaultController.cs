using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FWDBApp.Models;
using FWDBApp.Repository;
namespace FWDBApp.Controllers
{
    public class DefaultController : Controller
    {
        private IFrameworkRepository _frameworkRepository;

        public DefaultController()
        {
            this._frameworkRepository = new FrameworkRepository(new FrameworkModel());
        }

        public ActionResult Initiator()
        {
            return View();
        }

        public ActionResult Index()
        {
            var frameworkAsList = _frameworkRepository.FetchFrameworks();
            return View(frameworkAsList);
        }

        [HttpPost]
        public ActionResult GetFrameworkDetail()
        {
            var frameworkAsList = _frameworkRepository.FetchFrameworks();
            return Json(frameworkAsList);
        }
    }
}