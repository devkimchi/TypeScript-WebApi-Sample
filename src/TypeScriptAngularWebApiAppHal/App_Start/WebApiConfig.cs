using System;
using System.Web.Http;

using Aliencube.WebApi.Hal.Configs;

using Owin;

namespace TypeScriptAngularWebApiAppHal
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

            config.MapHttpAttributeRoutes();

            config.ConfigHalFormatter();

            builder.UseWebApi(config);
        }
    }
}