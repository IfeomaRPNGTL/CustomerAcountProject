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

        public async Task<AccountCreationResponse> CreateBankAccount(AccountCreationRequest dto)
        {
            //create cst


            //creat act

            // send email
            return null;
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
