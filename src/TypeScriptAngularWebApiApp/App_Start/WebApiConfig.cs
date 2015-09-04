using System.Web.Http;

using Newtonsoft.Json.Serialization;

namespace TypeScriptAngularWebApiApp
{
    /// <summary>
    /// This represents the configuration entity for Web API.
    /// </summary>
    public static class WebApiConfig
    {
        /// <summary>
        /// Registers Web API configurations.
        /// </summary>
        /// <param name="config">
        /// The <see cref="HttpConfiguration" /> instance.
        /// </param>
        public static void Register(HttpConfiguration config)
        {
            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Formatters.JsonFormatter.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional });
        }
    }
}