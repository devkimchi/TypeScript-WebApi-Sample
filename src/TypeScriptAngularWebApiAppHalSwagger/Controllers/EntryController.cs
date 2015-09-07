using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;

using Aliencube.WebApi.Hal.Extensions;
using Aliencube.WebApi.Hal.Resources;

using TypeScriptAngularWebApiAppHalSwagger.Models;

namespace TypeScriptAngularWebApiAppHalSwagger.Controllers
{
    /// <summary>
    /// This represents the controller entity for salutations.
    /// </summary>
    [RoutePrefix("api")]
    public class EntryController : ApiController
    {
        private const string EntryRouteName = "Entry";

        /// <summary>
        /// Gets the list of <see cref="SalutationModel" />s.
        /// </summary>
        /// <returns>
        /// Returns the list of <see cref="SalutationModel" />s.
        /// </returns>
        [Route("", Name = EntryRouteName)]
        public virtual async Task<EntryModel> Get()
        {
            EntryModel model = null;
            await Task.Run(() =>
                {
                    model = new EntryModel();
                });

            model.AddLink(new Link() { Rel = "self", Href = this.Url.Route(EntryRouteName, new { }) });
            model.AddLinks(SalutationsController.FindLinks(this.Url).ToList());
            return model;
        }
    }
}