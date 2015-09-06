using System.Collections.Generic;
using System.Linq;

using Aliencube.WebApi.Hal.Resources;

namespace TypeScriptAngularWebApiAppHal.Models
{
    /// <summary>
    /// This represents the collection entity of <see cref="SalutationModel" />.
    /// </summary>
    public class SalutationCollectionModel : LinkedResourceCollection<SalutationModel>
    {
        /// <summary>
        /// Initialises a new instance of the <see cref="SalutationCollectionModel" /> class.
        /// </summary>
        public SalutationCollectionModel()
            : base()
        {
        }

        /// <summary>
        /// Initialises a new instance of the <see cref="SalutationCollectionModel" /> class.
        /// </summary>
        /// <param name="items">
        /// The items.
        /// </param>
        public SalutationCollectionModel(IEnumerable<SalutationModel> items)
            : base(items.ToList())
        {
        }
    }
}