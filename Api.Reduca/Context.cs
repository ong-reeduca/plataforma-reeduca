using System;
using Api.Reduca.Models;
using MongoDB.Driver;

namespace Api.Reduca
{
    /// <summary>
    /// classe de contexto acesso dados MongoDb
    /// </summary>
    public class Context
    {
        private readonly IMongoDatabase database;

        public Context()
        {
            // incluir o endereço do mongo
            database = new MongoClient("mongodb://localhost..bolinhoDeQueijo").GetDatabase("Api.Reduca");
        }

        // recebe documento do Mongo
        public IMongoCollection<Usuario> Usuarios
        {
            get
            {
                return database.GetCollection<Usuario>("Usuario");
            }
        }
    }
}
