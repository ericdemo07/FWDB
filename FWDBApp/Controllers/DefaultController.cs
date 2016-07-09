using System.Web.Mvc;
using FWDBApp.Models;
using FWDBApp.Repository;
namespace FWDBApp.Controllers
{
    public class DefaultController : Controller
    {
        private IFrameworkRepository frameworkRepository;

        public DefaultController(IFrameworkRepository frameworkRepository)
        {
            this.frameworkRepository = frameworkRepository;
        }

        public ActionResult Initiator()
        {
            return View();
        }

        public ActionResult Index()
        {
            var frameworkAsList = this.frameworkRepository.FetchFrameworks();
            return this.View(frameworkAsList);
        }

        [HttpPost]
        public ActionResult GetFrameworkDetail()
        {
            var frameworkAsList = this.frameworkRepository.FetchFrameworks();
            return this.Json(frameworkAsList);
        }
    }
}