using PizzariaPoloh.Web.App_Start;
using System.Web.Mvc;
using System.Web.Routing;

namespace PizzariaPoloh.Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            ConfiguracaoInjecao.ConfigurarDependencias();
        }
    }
}
