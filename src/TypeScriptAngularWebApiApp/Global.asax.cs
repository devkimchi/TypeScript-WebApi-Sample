using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace TypeScriptAngularWebApiApp
{
    /// <summary>
    /// This represents the entity for application start.
    /// </summary>
    public class WebApiApplication : HttpApplication
    {
        /// <summary>
        /// Called when application is being started.
        /// </summary>
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
        }
    }
}