using RpnInnovation.Application.Features.Account.DTO.Request;
using RpnInnovation.Application.Features.Account.DTO.Response;
using RpnInnovation.Application.Features.Transaction.DTO.Request;
using RpnInnovation.Application.Features.Transaction.DTO.Response;
using RpnInnovation.Application.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpnInnovation.Application.Features.Transaction.Interfaces
{
    public interface ITransactionService
    {
        Task<BaseReponse<CreditCustomerAccountResponse>> CreditCustomerAccount(CreditCustomerAccountRequest dto);
        Task<BaseReponse<WithdrawCustomerResponse>> WithdrawCustomerAccount(WithdrawCustomerRequest dto);
        Task<BaseReponse<IntraAccountTransferResponse>> IntraAccountTransfer(IntraAccountTransferRequest dto);
    }
}
