using System.Collections.Generic;
using System.Linq;

namespace TypeScriptAngularWebApiAppHalSwagger.Models
{
    /// <summary>
    /// This represents the view model entity for salutation collection.
    /// </summary>
    public class SalutationCollectionViewModel
    {
        /// <summary>
        /// Initialises a new instance of the <see cref="SalutationCollectionViewModel" /> class.
        /// </summary>
        /// <param name="models">List of <see cref="SalutationModel" /> objects.</param>
        public SalutationCollectionViewModel(IList<Proxies.Models.SalutationModel> models)
        {
            this.Salutations = models.Select(p => new SalutationViewModel(p)).ToList();
        }

        /// <summary>
        /// Gets or sets the list of salutations.
        /// </summary>
        public List<SalutationViewModel> Salutations { get; set; }
    }

    /// <summary>
    /// This represents the view model entity for salutation.
    /// </summary>
    public class SalutationViewModel
    {
        /// <summary>
        /// Initialises a new instance of the <see cref="SalutationViewModel" /> class.
        /// </summary>
        /// <param name="model"><see cref="SalutationModel" /> object.</param>
        public SalutationViewModel(Proxies.Models.SalutationModel model)
        {
            this.Text = model.Text;
            this.Value = model.Value;
        }

        /// <summary>
        /// Gets or sets the salutation text.
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// Gets or sets the salutation value.
        /// </summary>
        public string Value { get; set; }
    }
}
