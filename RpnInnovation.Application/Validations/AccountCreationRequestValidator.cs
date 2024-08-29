using FluentValidation;
using RpnInnovation.Application.Features.Account.DTO.Request;
using RpnInnovation.Application.OtherInterfaces;

namespace RpnInnovation.Application.Validations
{
    public class AccountCreationRequestValidator : AbstractValidator<AccountCreationRequest>
    {
        private readonly ICustomerReadRepository _customerRepository;

        public AccountCreationRequestValidator(ICustomerReadRepository customerRepository)
        {
            _customerRepository = customerRepository;

            RuleFor(t => t.FirstName)
                .NotEmpty().WithMessage("Firstname cannot be empty.")
                .NotNull()
                .MaximumLength(240);
            RuleFor(t => t.LastName)
               .NotEmpty().WithMessage("Firstname cannot be empty.")
               .NotNull()
               .MaximumLength(240);

            RuleFor(t => t.Email)
               .EmailAddress().WithMessage("Provide a valid email address.")
               .NotNull()
               .MaximumLength(250)
               .MustAsync(IsUniqueEmail).WithMessage("Email exists use a different email.");
            RuleFor(t => t.Phone)
            .NotEmpty().WithMessage("Provide a phone number.")
            .NotNull()
            .MaximumLength(10);
            _customerRepository = customerRepository;
        }

        private async Task<bool> IsUniqueEmail(string email, CancellationToken token)
        {
            try
            {
                var doesNotExist = await _customerRepository.CheckCustomerDoesNotExistsByEmail(email);
                if (doesNotExist) return false;
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
            
        }

        
    }
}
