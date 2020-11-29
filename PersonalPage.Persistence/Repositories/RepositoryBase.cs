using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PersonalPage.Persistence.Repositories
{
    public abstract class RepositoryBase<T> : IRepository<T>
    {
        protected RepositoryBase(IDbContext context)
        {
            DbContext = context;
        }

        protected IDbContext DbContext { get; }

        protected abstract string CollectionName { get; }

        protected IMongoCollection<T> Collection => DbContext.GetCollection<T>(CollectionName);

        public async Task Add(T item)
        {
            await Collection.InsertOneAsync(item);
        }

        public async Task BulkAdd(IEnumerable<T> items)
        {
            await Collection.InsertManyAsync(items);
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await Where(x => 1 == 1);
        }

        public async Task<T> GetSingle(Expression<Func<T, bool>> predicate)
        {
            return await Collection.Find(predicate).FirstOrDefaultAsync();
        }

        public async Task Update(T item)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<T>> Where(Expression<Func<T, bool>> predicate)
        {
            var results = new List<T>();
            using (var cursor = await Collection.FindAsync<T>(predicate))
            {
                while(await cursor.MoveNextAsync())
                {
                    foreach (var item in cursor.Current)
                    {
                        results.Add(item);
                    }
                }
            }
            return results;
        }
    }
}
