using FluentValidation.WebApi;
using System.Web.Http;
using webapi_fluentvalidation.ActionFilters;
using webapi_fluentvalidation.Handlers;

namespace webapi_fluentvalidation
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            config.Filters.Add(new ValidateModelStateFilter());
            config.MessageHandlers.Add(new ResponseWrappingHandler());

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            FluentValidationModelValidatorProvider.Configure(config);
        }
    }
}
