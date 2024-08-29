using RpnInnovation.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpnInnovation.Application.OtherInterfaces
{
    public interface ICustomerReadRepository
    {
        Task<bool> CheckCustomerDoesNotExistsByEmail(string email);

    }
}
