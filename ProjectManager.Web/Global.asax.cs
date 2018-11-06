using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Ninject;
using Ninject.Modules;
using Ninject.Web.Mvc;
using ProjectManager.BusinessLogic.Infrastructure;
using ProjectManager.Web.Util;

namespace ProjectManager.Web
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            Mapping.Mapping.Configure();


            NinjectModule projectModule = new ProjectModule();
            NinjectModule serviceModule = new ServiceModule("ProjectManagerDb");
            var kernel = new StandardKernel(projectModule, serviceModule);
            DependencyResolver.SetResolver(new NinjectDependencyResolver(kernel));
            
        }
    }
}
