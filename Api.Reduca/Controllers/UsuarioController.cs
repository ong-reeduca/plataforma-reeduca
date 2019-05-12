using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Api.Reduca.Models;
using MongoDB.Driver;

namespace Api.Reduca.Controllers
{
    [Route("reduca/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private Context context;

        public UsuarioController()
        {
            context = new Context();
        }

        // GET: api/Usuario
        [HttpGet]
        public IEnumerable<Usuario> Get()
        {
            var usuarios = context.Usuarios.Find(_ => true).ToList();
            return usuarios;
        }

        // GET: api/Usuario/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Usuario
        [HttpPost]
        public void Post([FromBody] Usuario usuario)
        {
            context.Usuarios.InsertOne(usuario);
        }

        // PUT: api/Usuario/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
