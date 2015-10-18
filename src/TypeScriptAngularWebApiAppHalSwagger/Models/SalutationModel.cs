using WebApi.Hal;

namespace TypeScriptAngularWebApiAppHalSwagger.Models
{
    /// <summary>
    /// This represents the entity for salutation.
    /// </summary>
    public class SalutationModel : Representation
    {
        /// <summary>
        /// Initialises a new instance of the <see cref="SalutationModel" /> class.
        /// </summary>
        public SalutationModel()
        {
        }

        /// <summary>
        /// Initialises a new instance of the <see cref="SalutationModel" /> class.
        /// </summary>
        /// <param name="text">
        /// Salutation text.
        /// </param>
        /// <param name="value">
        /// Salutation value.
        /// </param>
        public SalutationModel(string text, string value)
        {
            this.Text = text;
            this.Value = value;
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