using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Calculator.Controllers
{
    public class SumController : ApiController
    {
        // GET: api/Sum
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Sum/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Sum
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Sum/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Sum/5
        public void Delete(int id)
        {
        }
    }
}
