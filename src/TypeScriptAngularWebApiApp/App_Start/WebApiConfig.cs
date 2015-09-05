using System;
using System.Web.Http;

using Newtonsoft.Json.Serialization;

using Owin;

namespace TypeScriptAngularWebApiApp
{
    /// <summary>
    /// This represents the config entity for Web API.
    /// </summary>
    public static class WebApiConfig
    {
        /// <summary>
        /// Configures the Web API.
        /// </summary>
        /// <param name="builder">
        /// The <see cref="IAppBuilder" /> instance.
        /// </param>
        /// <exception cref="ArgumentNullException">
        /// Throws when either <c>builder</c> or <c>container</c> is null.
        /// </exception>
        public static void Configure(IAppBuilder builder)
        {
            if (builder == null)
            {
                throw new ArgumentNullException("builder");
            }

            var config = new HttpConfiguration();

            // Routes
            config.MapHttpAttributeRoutes();

            config.Formatters.JsonFormatter.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional });

            builder.UseWebApi(config);
        }
    }
}