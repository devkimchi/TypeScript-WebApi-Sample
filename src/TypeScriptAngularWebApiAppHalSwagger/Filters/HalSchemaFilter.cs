using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using Aliencube.WebApi.Hal.Resources;

using Swashbuckle.Swagger;

namespace TypeScriptAngularWebApiAppHalSwagger.Filters
{
    public class HalSchemaFilter : ISchemaFilter
    {

        public void Apply(Schema schema, SchemaRegistry schemaRegistry, Type type)
        {

            if (typeof(LinkedResourceCollection<>).IsAssignableFrom(type))
            {

                schema.type = "object";
                schema.properties.Clear();
                schema.additionalProperties = new Schema() { type = "object" };
                schema.example = new
                {
                    self = new
                    {
                        rel = "self",
                        href = "uri"
                    }
                };

            }
        }
    }
}