using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Website.Contracts
{
    public interface IBaseRepository<T> where T : class
    {
        Task<T> Get(string url, int id);

        Task<IList<T>> Get(string url);

        Task<bool> Create(string url, T newEntity);

        Task<bool> Update(string url, T updatedEntity);

        Task<bool> Delete(string url, int id);
    }
}
