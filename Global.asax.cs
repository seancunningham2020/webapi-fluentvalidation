using System.Web.Http;
using webapi_fluentvalidation.App_Start;

namespace webapi_fluentvalidation
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
            ContainerConfig.SetUp();
        }
    }
}
