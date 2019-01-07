using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace MD_Api
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "balanco/{controller}/{ano}",
                defaults: new { id = RouteParameter.Optional }
            );
            config.Formatters.JsonFormatter.SupportedMediaTypes.Add(
               new System.Net.Http.Headers.MediaTypeHeaderValue("text/html"));
        }
    }
}
