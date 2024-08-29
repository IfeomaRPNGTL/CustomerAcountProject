using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpnInnovation.Application.OtherInterfaces
{
    public interface IRepository<T> where T : class
    {
    
        Task<T> AddAsync(T entity);
        Task<bool> UpdateAsync(T entity);
    }

    public interface IReadRepository<T> where T : class
    {
        Task<List<T>> GetAllAsync();
        Task<T> GetByIdAsync(long id);
    }

    public interface IUnitOfWork
    {
        Task<int> SaveChanges();
    }
}
