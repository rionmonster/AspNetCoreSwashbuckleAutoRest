using System;
using Swashbuckle.SwaggerGen;
using System.Collections.Generic;

namespace SwaggerSample.Controllers
{
    public class ConsumesJsonFilter : IOperationFilter
    {
        public void Apply(Operation operation, OperationFilterContext context)
        {
            if (operation.Consumes == null)
                operation.Consumes = new List<string>();

            operation.Consumes.Add("application/json");
        }
    }
}