using System.Web.Mvc;
using FWDBApp.Repository;
namespace FWDBApp.Controllers
{
    public class DefaultController : Controller
    {
        private IFrameworkRepository frameworkRepository;
        //gets data using repository pattern
        public DefaultController(IFrameworkRepository frameworkRepository)
        {
            this.frameworkRepository = frameworkRepository;
        }
        //will start server and handover task to angular
        public ActionResult Initiator()
        {
            return View();
        }
        //Default/Static
        public ActionResult Index()
        {
            var frameworkAsList = this.frameworkRepository.FetchFrameworks();
            return this.View(frameworkAsList);
        }
        //Default/Ajax (on button click)
        [HttpPost]
        public ActionResult GetFrameworkDetail()
        {
            var frameworkAsList = this.frameworkRepository.FetchFrameworks();
            return this.Json(frameworkAsList);
        }
    }
}