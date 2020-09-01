using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PersonalPage.Persistence.Repositories
{
    public interface IRepository<T>
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> Get(string id);
        Task<IEnumerable<T>> Where(Func<T, bool> predicate);
    }
}
