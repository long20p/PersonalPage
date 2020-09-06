using Microsoft.Extensions.Options;
using MongoDB.Driver;
using PersonalPage.Common.Settings;
using PersonalPage.Persistence.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PersonalPage.Persistence.Repositories
{
    public class DbContext : IDbContext
    {
        private DbSettings dbSettings;
        private IMongoDatabase database;
        private IMongoClient client;

        public DbContext(IOptions<DbSettings> dbOptions)
        {
            dbSettings = dbOptions.Value;
            client = new MongoClient(dbSettings.ConnectionString);
            database = client.GetDatabase(dbSettings.Database);
        }

        public IMongoCollection<T> GetCollection<T>(string name) => database.GetCollection<T>(name);

        public bool DatabaseExists()
        {
            var dbList = client.ListDatabases().ToList().Select(db => db.GetValue("name").AsString);
            return dbList.Contains(dbSettings.Database);
        }
    }
}
