using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Swashbuckle.SwaggerGen.Annotations;

namespace SwaggerSample.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        // GET: api/values
        [HttpGet]
        [SwaggerOperation("GetValues")]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        [SwaggerOperation("GetValue")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        [SwaggerOperation("PostValue")]
        [SwaggerOperationFilter(typeof(ConsumesJsonFilter))]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        [SwaggerOperation("PutValue")]
        [SwaggerOperationFilter(typeof(ConsumesJsonFilter))]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        [SwaggerOperation("DeleteValue")]
        public void Delete(int id)
        {
        }
    }
}
