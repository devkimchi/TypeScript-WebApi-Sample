using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Routing;
using TypeScriptAngularWebApiAppHal.Helpers;
using TypeScriptAngularWebApiAppHal.Models;

using WebApi.Hal;

namespace TypeScriptAngularWebApiAppHal.Controllers
{
    /// <summary>
    /// This represents the controller entity for salutations.
    /// </summary>
    [RoutePrefix("api/salutations")]
    public class SalutationsController : ApiController
    {
        private const string SalutationsRouteName = "Salutations";

        /// <summary>
        /// Gets the list of links for salutations for entry.
        /// </summary>
        /// <param name="urlHelper">Url helper</param>
        /// <returns>Returns the list of <see cref="Link" /> objects.</returns>
        public static IEnumerable<Link> FindLinks(UrlHelper urlHelper)
        {
            var links = new List<Link>()
                            {
                                new Link() { Rel = "salutations", Href = urlHelper.Route(SalutationsRouteName, new { }) },
                            };

            return links;
        }

        /// <summary>
        /// Gets the list of <see cref="SalutationModel" />s.
        /// </summary>
        /// <returns>
        /// Returns the list of <see cref="SalutationModel" />s.
        /// </returns>
        [Route("", Name = SalutationsRouteName)]
        public virtual async Task<SalutationCollectionModel> Get()
        {
            var salutations = SalutationHelper.GetSalutations();
            var collection = new SalutationCollectionModel(salutations);
            collection.Links.Add(new Link() { Rel = "self", Href = this.Url.Route(SalutationsRouteName, new { }) });
            return await Task.FromResult(collection);
        }
    }
}