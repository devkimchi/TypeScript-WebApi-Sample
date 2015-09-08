using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Description;

using Aliencube.WebApi.Hal.Helpers;
using Aliencube.WebApi.Hal.Resources;

using Swashbuckle.Swagger;

namespace TypeScriptAngularWebApiAppHalSwagger.Filters
{
    /// <summary>
    /// http://blog.greatrexpectations.com/2015/03/18/custom-operation-names-with-swashbuckle-5-0/
    /// </summary>
    public class SwaggerOperationFilter : IOperationFilter
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="operation"></param>
        /// <param name="schemaRegistry"></param>
        /// <param name="apiDescription"></param>
        public void Apply(Operation operation, SchemaRegistry schemaRegistry, ApiDescription apiDescription)
        {
            var type = apiDescription.ActionDescriptor.ReturnType;
            if (IsLinkedResourceCollectionType(type))
            {
                operation.responses.First().Value.schema.additionalProperties = new Schema() { type = "object" };
            }

            var overwriteOperationId =
                apiDescription.ActionDescriptor.GetCustomAttributes<SwaggerOperationAttribute>()
                    .Select(a => a.OperationId)
                    .FirstOrDefault();

            if (overwriteOperationId != null)
            {
                operation.operationId = overwriteOperationId;
            }
        }
        public static bool IsLinkedResourceCollectionType(Type type)
        {
            var typeToCheck = type;
            while (typeToCheck != null && typeToCheck != typeof(object))
            {
                var currentType = typeToCheck.IsGenericType ? typeToCheck.GetGenericTypeDefinition() : typeToCheck;
                if (currentType == typeof(LinkedResourceCollection<>))
                {
                    return true;
                }

                typeToCheck = typeToCheck.BaseType;
            }

            return false;
        }
    }
}