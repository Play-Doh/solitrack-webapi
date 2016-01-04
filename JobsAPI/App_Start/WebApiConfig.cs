using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace JobsAPI
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApiWithID",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
                );

            config.Routes.MapHttpRoute(
                name: "DefaultApiWithMJin",
                routeTemplate: "api/{controller}/{action}/{mjin}"
                );

            config.Routes.MapHttpRoute(
                name: "DefaultApiWithAJin",
                routeTemplate: "api/{controller}/{action}/{ajin}"
                );

        }
    }
}
