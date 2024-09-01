using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpnInnovation.Application.Features.Account.DTO.Response
{
    public class AccountCreationResponse
    {
        public string AccountNumber { get; set; }
        public string AccountTypeCreated { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
