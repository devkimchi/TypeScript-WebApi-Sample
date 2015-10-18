using System.Collections.Generic;

using WebApi.Hal;

namespace TypeScriptAngularWebApiAppHal.Models
{
    /// <summary>
    /// This represents the collection entity of <see cref="SalutationModel" />.
    /// </summary>
    public class SalutationCollectionModel : SimpleListRepresentation<SalutationModel>
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
        public SalutationCollectionModel(IList<SalutationModel> items)
            : base(items)
        {
        }
    }
}