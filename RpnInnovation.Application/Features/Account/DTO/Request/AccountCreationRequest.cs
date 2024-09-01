using RpnInnovation.Application.Helper;
using RpnInnovation.Domain.Entities;
using RpnInnovation.Domain.Enums;
using CreateBankAccount = RpnInnovation.Domain.Entities.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpnInnovation.Application.Features.Account.DTO.Request
{
    // todo :: rename class name to AccountCreationRequest CustomerCreationRequest
    public class AccountCreationRequest
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? CountryCode { get; set; }
        public string? Phone { get; set; } 
        public string? State { get; set; }
        public string? Country { get; set; }
        public string? Bvn { get; set; }
        public AccountType AccountType { get; set; }

        public static CustomerAccount Copy(AccountCreationRequest dto)
        {
            if (dto == null) throw new ArgumentNullException(nameof(dto));
            var cst = new CustomerAccount
            {
                Email = dto.Email,
                Bvn = dto.Bvn,
                Country = dto.Country,
                CountryCode = dto.CountryCode,
                FirstName = dto.FirstName,
                LastName = dto.LastName,
                Phone = dto.Phone,
                State = dto.State,
            };

            return cst;
        }

        public static CreateBankAccount Copy(CustomerAccount createCst, AccountCreationRequest dto)
        {
            if (createCst == null) throw new ArgumentNullException(nameof(createCst));

            var cstAccount = new CreateBankAccount
            {
                Email = createCst.Email,
                AccountType = dto.AccountType,
                Bvn = createCst.Bvn,
                CustomerID = createCst.Id,
                AccountNumber = Generators.GenerateAccountNumber()
            };
            return cstAccount;
        }
    }
}
