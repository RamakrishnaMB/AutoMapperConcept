
using BuisnessLayer.AutoMapperSettings;
using MVC5WebAM.Configuration;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace MVC5WebAM
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            AutofacConfigureMVC.RegisterAutofac();
            AutoMapperConfig.ConfigureAtApplicationStart();
        }
    }
}
