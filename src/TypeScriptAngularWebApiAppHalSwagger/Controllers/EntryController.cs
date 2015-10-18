using System.Threading.Tasks;
using System.Web.Http;

using TypeScriptAngularWebApiAppHalSwagger.Models;

using WebApi.Hal;

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

            model.Links.Add(new Link() { Rel = "self", Href = this.Url.Route(EntryRouteName, new { }) });
            foreach (var link in SalutationsController.FindLinks(this.Url))
            {
                model.Links.Add(link);
            }

            return model;
        }
    }
}