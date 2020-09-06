using MongoDB.Driver;
using PersonalPage.Persistence.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PersonalPage.Persistence.Repositories
{
    public interface IDbContext
    {
        IMongoCollection<T> GetCollection<T>(string name);
        bool DatabaseExists();
    }
}
