using RpnInnovation.Application.Features.Account.DTO.Request;
using RpnInnovation.Application.Features.Account.DTO.Response;
using RpnInnovation.Application.Features.Account.Interfaces;
using RpnInnovation.Application.Helper;
using RpnInnovation.Application.OtherInterfaces;
using RpnInnovation.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpnInnovation.Infrastructure.Services
{
    public class AccountService : IAccountService
    {
        private readonly IRepository<CustomerAccount> _customerRepository;
        private readonly IReadRepository<CustomerAccount> _readCustomerRepo;
        private readonly IRepository<Account> _acctRepository;
        private readonly IReadRepository<Account> _readAcctRepository;

        public AccountService(IReadRepository<Account> readAcctRepository, IRepository<Account> acctRepository, IReadRepository<CustomerAccount> readCustomerRepo, IRepository<CustomerAccount> customerRepository)
        {
            _readAcctRepository = readAcctRepository;
            _acctRepository = acctRepository;
            _readCustomerRepo = readCustomerRepo;
            _customerRepository = customerRepository;
        }

        public async Task<BaseReponse<AccountCreationResponse>> CreateBankAccount(AccountCreationRequest dto)
        {
            var response = new BaseReponse<AccountCreationResponse>();
            //create cst
            var cst = new CustomerAccount
            {
                Email = dto.Email,
                FirstName = dto.FirstName,
                LastName = dto.LastName,
                Phone = dto.Phone,
                Bvn = dto.Bvn,
                Country = dto.Country,
                CountryCode = dto.CountryCode,
                State = dto.State,
            };

            var createCst = await _customerRepository.AddAsync(cst);
            if(createCst is null || createCst.Id < 1 )
            {
                response.Message = $"Could not create customer, try again";
                response.Data = new AccountCreationResponse();
                return response;
            }


            //creat act
            var cstAccount = new Account
            {
                Email = createCst.Email,
                AccountType = dto.AccountType,
                Bvn = createCst.Bvn,
                CustomerID = createCst.Id,
                AccountNumber = Generators.GenerateAccountNumber()
            };

            var createAccount = await _acctRepository.AddAsync(cstAccount);
            if(createAccount is null || createAccount.Id < 1 )
            {
                response.Message = $"Could not create customer Account, try again";
                response.Data = new AccountCreationResponse();
                return response;
            }
            // send email
            response.Status = true;
            response.Message = $"Account created, you should receive an email comfirmation";
            response.Data = new AccountCreationResponse() { AccountNumber = createAccount.AccountNumber, AccountTypeCreated = dto.AccountType.ToString(), CreatedOn = DateTime.Now };
            return response;
        }

        public Task<BaseReponse<object>> GetAccountBalance(string accountNumber)
        {
            throw new NotImplementedException();
        }

        public Task<BaseReponse<GetAccountDetailResponse>> GetBankAccountDetails(string accountNumber)
        {
            throw new NotImplementedException();
        }

        public Task<BaseReponse<AccountUpdateResponse>> UpdateAccountDetails(AccountUpdateRequest dto)
        {
            throw new NotImplementedException();
        }

        Task<BaseReponse<AccountCreationResponse>> IAccountService.CreateBankAccount(AccountCreationRequest dto)
        {
            throw new NotImplementedException();
        }
    }
}
