using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace Reduca.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ColaboradorController
    {
        // GET api/colaborador
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/colaboradors/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/colaboradors
        [HttpPost]
        public void Post([FromBody] string value)
        {

        }

        // PUT api/colaboradors/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/colaboradors/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
