using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using FWDBApp.Repository;
using SimpleInjector.Integration.Web.Mvc;

namespace FWDBApp
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            var container = new SimpleInjector.Container();
            
            //Registrations here
            container.Register<IFrameworkRepository, FrameworkRepository>();

            //storing container to be use by the application
            DependencyResolver.SetResolver(new SimpleInjectorDependencyResolver(container));
        }
    }
}
