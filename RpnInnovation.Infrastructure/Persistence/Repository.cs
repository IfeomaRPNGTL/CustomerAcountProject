using Microsoft.EntityFrameworkCore;
using RpnInnovation.Application.OtherInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpnInnovation.Infrastructure.Persistence
{
    public class Repository<T> : IUnitOfWork, IRepository<T> where T : class
    {
        private readonly AppContext _dbContext;
        private readonly DbSet<T> _dbSet;
        public Repository(AppContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = _dbContext.Set<T>();
        }

        public async Task<T> AddAsync(T entity)
        {
            try
            {
               var result = await _dbSet.AddAsync(entity); // add migration
               var save = await SaveChanges();// update-datba
               return result.Entity;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public async Task<int> SaveChanges()
        {
            return await _dbContext.SaveChangesAsync();
        }

        public Task<bool> UpdateAsync(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
