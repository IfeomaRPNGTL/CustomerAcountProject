using RpnInnovation.Application.Features.Account.DTO.Request;
using RpnInnovation.Application.Features.Account.DTO.Response;
using RpnInnovation.Application.Features.Transaction.DTO.Request;
using RpnInnovation.Application.Features.Transaction.DTO.Response;
using RpnInnovation.Application.Features.Transaction.Interfaces;
using RpnInnovation.Application.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpnInnovation.Infrastructure.Services
{
    public class TransactionService : ITransactionService
    {
        public TransactionService()
        {
            
        }

        public Task<BaseReponse<CreditCustomerAccountResponse>> CreditCustomerAccount(CreditCustomerAccountRequest dto)
        {
            throw new NotImplementedException();
        }

        public Task<BaseReponse<IntraAccountTransferResponse>> IntraAccountTransfer(IntraAccountTransferRequest dto)
        {
            throw new NotImplementedException();
        }

        public Task<BaseReponse<WithdrawCustomerResponse>> WithdrawCustomerAccount(WithdrawCustomerRequest dto)
        {
            throw new NotImplementedException();
        }
    }
}
