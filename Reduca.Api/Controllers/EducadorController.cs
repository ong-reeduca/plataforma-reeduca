﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Reduca.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EducadorController
    {
        // GET api/educador
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/educadores/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/educadores
        [HttpPost]
        public void Post([FromBody] string value)
        {

        }

        // PUT api/educadores/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/educadores/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
