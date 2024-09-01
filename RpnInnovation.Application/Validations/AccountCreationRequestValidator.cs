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
               .NotEmpty().WithMessage("Lastname cannot be empty.")
               .NotNull()
               .MaximumLength(240);

            RuleFor(t => t.Bvn)
                .NotEmpty().WithMessage("Bvn cannot be empty.")
                .NotNull()
                .Length(11);
            
            RuleFor(t => t.Phone)
            .NotEmpty().WithMessage("Provide a phone number.")
            .NotNull()
            .MaximumLength(10);

            RuleFor(t => t.Email)
               .EmailAddress().WithMessage("Provide a valid email address.")
               .NotNull()
               .MaximumLength(250);

            RuleFor(t => t)
                .Must(t =>
                {
                    var result = IsUniqueEmail(t.Email);
                    return result;
                }).WithMessage("Email is not unique.");

        }

        private bool IsUniqueEmail(string email)
        {
            try
            {
                var doesNotExist = _customerRepository.CheckCustomerDoesNotExistsByEmail(email);
                if (doesNotExist.Result) return true;
                return false;
            }
            catch (Exception ex)
            {
                return false;
            }
            
        }

        
    }
}
