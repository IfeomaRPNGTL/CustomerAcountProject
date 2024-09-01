using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RpnInnovation.Application.Features.Account.DTO.Request;
using RpnInnovation.Application.Features.Account.Interfaces;

namespace RpnInnovation.WebApi.Controllers
{
    [Route("api/customer")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private IAccountService _accountService;

        public CustomerController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        [HttpPost("create-account")]
        public async Task<IActionResult> CreateAccount(AccountCreationRequest dto)
        {
            var serviceResponse = await _accountService.CreateBankAccount(dto);

            if(serviceResponse.Status)
            {
                return Ok(serviceResponse);
            }
            return BadRequest(serviceResponse);
        }
    } 
}
