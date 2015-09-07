using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Description;

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
            var overwriteOperationId = apiDescription.ActionDescriptor
                .GetCustomAttributes<SwaggerOperationAttribute>()
                .Select(a => a.OperationId)
                .FirstOrDefault();

            if (overwriteOperationId != null)
            {
                operation.operationId = overwriteOperationId;
            }
        }
    }
}