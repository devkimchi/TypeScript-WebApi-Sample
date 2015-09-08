using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using Aliencube.WebApi.Hal.Helpers;
using Aliencube.WebApi.Hal.Resources;

using Swashbuckle.Swagger;

namespace TypeScriptAngularWebApiAppHalSwagger.Filters
{
    public class HalSchemaFilter : ISchemaFilter
    {

        public void Apply(Schema schema, SchemaRegistry schemaRegistry, Type type)
        {
            if (!FormatterHelper.IsSupportedType(type))
            {
                return;
            }

            schema.type = "object";
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