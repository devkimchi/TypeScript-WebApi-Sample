using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TypeScriptAngularWebApiAppHalSwagger.Filters
{
    /// <summary>
    /// http://blog.greatrexpectations.com/2015/03/18/custom-operation-names-with-swashbuckle-5-0/
    /// </summary>
    [AttributeUsage(AttributeTargets.Method)]
    public sealed class SwaggerOperationAttribute : Attribute
    {
        /// <summary>
        /// </summary>
        /// <param name="operationId"></param>
        public SwaggerOperationAttribute(string operationId)
        {
            this.OperationId = operationId;
        }

        /// <summary>
        /// </summary>
        public string OperationId { get; private set; }
    }
}