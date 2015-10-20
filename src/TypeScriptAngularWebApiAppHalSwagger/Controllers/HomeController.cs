using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;

using TypeScriptAngularWebApiAppHalSwagger.Models;
using TypeScriptAngularWebApiAppHalSwagger.Proxies;

namespace TypeScriptAngularWebApiAppHalSwagger.Controllers
{
    /// <summary>
    /// This represents the controller entity for /home.
    /// </summary>
    [RoutePrefix("home")]
    public class HomeController : ApiController
    {
        private readonly ITypeScriptAngularWebApiAppHalSwaggerClient _client;

        /// <summary>
        /// Initialises a new instance of the <see cref="HomeController" /> class.
        /// </summary>
        /// <param name="client"><see cref="ITypeScriptAngularWebApiAppHalSwaggerClient" /> instance.</param>
        public HomeController(ITypeScriptAngularWebApiAppHalSwaggerClient client)
        {
            if (client == null)
            {
                throw new ArgumentNullException(nameof(client));
            }

            this._client = client;
        }

        /// <summary>
        /// Gets the list of <see cref="SalutationViewModel" /> objects.
        /// </summary>
        /// <returns></returns>
        [Route("")]
        public virtual async Task<SalutationCollectionViewModel> Get()
        {
            var response = await this._client.Salutations.GetWithHttpMessagesAsync();
            var collection = new SalutationCollectionViewModel(response.Body.ResourceList);
            return collection;
        }
    }
}