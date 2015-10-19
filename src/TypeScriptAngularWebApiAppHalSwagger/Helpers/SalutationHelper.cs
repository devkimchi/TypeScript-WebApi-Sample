using System.Collections.Generic;

using TypeScriptAngularWebApiAppHalSwagger.Models;

using WebApi.Hal;

namespace TypeScriptAngularWebApiAppHalSwagger.Helpers
{
    /// <summary>
    /// This represents the helper entity for salutations.
    /// </summary>
    public static class SalutationHelper
    {
        /// <summary>
        /// Gets the list of salutations.
        /// </summary>
        /// <returns>Returns the list of salutations.</returns>
        public static List<SalutationModel> GetSalutations()
        {
            var link = new Link("salutations", "/api/salutations");
            var salutations = new List<SalutationModel>()
                              {
                                  new SalutationModel("Mr", "Mr") { Rel = link.Rel, Href = link.Href, Links = new List<Link>() { link } },
                                  new SalutationModel("Mrs", "Mrs") { Rel = link.Rel, Href = link.Href, Links = new List<Link>() { link } },
                                  new SalutationModel("Ms", "Ms") { Rel = link.Rel, Href = link.Href, Links = new List<Link>() { link } },
                                  new SalutationModel("Mx", "Mx") { Rel = link.Rel, Href = link.Href, Links = new List<Link>() { link } },
                              };
            return salutations;
        }
    }
}
