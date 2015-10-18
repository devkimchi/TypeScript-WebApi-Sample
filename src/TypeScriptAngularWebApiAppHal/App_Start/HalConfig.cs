using System.Net.Http.Headers;
using System.Web.Http;

using Newtonsoft.Json.Serialization;

using WebApi.Hal;

namespace TypeScriptAngularWebApiAppHal
{
    /// <summary>
    /// This represents the config entity for HAL.
    /// </summary>
    public static class HalConfig
    {
        /// <summary>
        /// Configures HAL formatters.
        /// </summary>
        /// <param name="config"><see cref="HttpConfiguration" /> instance.</param>
        public static void ConfigHal(this HttpConfiguration config)
        {
            config.ConfigHalJson();
            config.ConfigHalXml();
        }

        private static void ConfigHalJson(this HttpConfiguration config)
        {
            var jsonFormatter = new JsonHalMediaTypeFormatter()
                                {
                                    SerializerSettings =
                                    {
                                        ContractResolver = new CamelCasePropertyNamesContractResolver()
                                    }
                                };
            config.Formatters.Add(jsonFormatter);
        }

        private static void ConfigHalXml(this HttpConfiguration config)
        {
            var xmlFormatter = new XmlHalMediaTypeFormatter();
            config.Formatters.Add(xmlFormatter);
        }
    }
}
