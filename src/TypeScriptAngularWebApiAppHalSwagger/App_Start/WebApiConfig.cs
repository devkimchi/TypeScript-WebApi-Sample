using System;
using System.Web.Http;

using Autofac;
using Autofac.Integration.WebApi;
using Newtonsoft.Json.Serialization;
using Owin;

namespace TypeScriptAngularWebApiAppHalSwagger
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
        /// <param name="container">
        /// The <see cref="IContainer" /> instance.
        /// </param>
        /// <exception cref="ArgumentNullException">
        /// Throws when either <c>builder</c> or <c>container</c> is null.
        /// </exception>
        public static void Configure(IAppBuilder builder, IContainer container)
        {
            if (builder == null)
            {
                throw new ArgumentNullException("builder");
            }

            var config = new HttpConfiguration()
                         {
                             DependencyResolver = new AutofacWebApiDependencyResolver(container),
                         };

            config.MapHttpAttributeRoutes();

            config.ConfigHal();
            config.Formatters.JsonFormatter.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();

            config.ConfigSwagger();

            builder.UseWebApi(config);
        }
    }
}