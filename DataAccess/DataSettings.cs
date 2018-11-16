using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;
using System.Configuration;
using System;
using System.IO;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;

namespace SjeApi.DataAccess
{
    public class DataAccessSettings { 
        public MongoClient _client {get;set;}
        public MongoServer _server {get;set;}
        public MongoDatabase _db {get;set;}
        readonly IConfiguration _configuration;

        public DataAccessSettings(string database)
        {
            string path = Directory.GetCurrentDirectory();
            IConfiguration configuration;
            var builder = new ConfigurationBuilder()
                                .SetBasePath(path)
                                .AddJsonFile("appsettings.json");
            configuration = builder.Build();
            var hostingURL = configuration["DatabaseSettings:"+database+":HostingEnvironment"];
            var dbUserName = configuration["DatabaseSettings:"+database+":UserName"];
            var dbPassword = configuration["DatabaseSettings:"+database+":Password"];
            var connectionString = "mongodb://"+dbUserName+":"
                                            +dbPassword+"@"+hostingURL
                                                +"/"+database;
            _client = new MongoClient(connectionString);
            _server = _client.GetServer();
            _db = _server.GetDatabase(database);
        }
    }
    public class DbConnection{
        public string HostingEnvironment { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}