using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace Star_K.DBApi.Web
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            config.Routes.MapHttpRoute(
               name: "Logging",
               routeTemplate: "api/stark/loggings/{date}",
               defaults: new {controller ="loggings", date = RouteParameter.Optional }
           );

        }
    }
}
