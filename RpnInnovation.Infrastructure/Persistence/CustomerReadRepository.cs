using Microsoft.EntityFrameworkCore;
using RpnInnovation.Application.OtherInterfaces;
using RpnInnovation.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpnInnovation.Infrastructure.Persistence
{
    public class CustomerReadRepository : ICustomerReadRepository
    {
        private readonly AppContext _dbContext;
        private readonly DbSet<CustomerAccount> _dbSet;
        public CustomerReadRepository(AppContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = _dbContext.Set<CustomerAccount>();
        }


        public async Task<bool> CheckCustomerDoesNotExistsByEmail(string email)
        {
            try
            {
                var count = await _dbSet.CountAsync(t => t.Email.ToLower().Equals(email.ToLower()));
                if (count > 0) { return true; }
                return false;
            }
            catch (Exception ex)
            {
                return true;
            }
        }
    }
}
