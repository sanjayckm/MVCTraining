using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApiOne.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IHttpActionResult Get()
        {
            return NotFound();
        }

        // GET api/values/5
        public IHttpActionResult Get(int id)
        {
            return BadRequest("Record not found");
        }

        // POST api/values
        public string Post([FromBody]string value)
        {
            return "Posted";
        }

        // PUT api/values/5
        public string Put(int id, [FromBody]string value)
        {
            return "Updated";
        }

        // DELETE api/values/5
        public string Delete(int id)
        {
            return "Deleted";
        }
    }
}
