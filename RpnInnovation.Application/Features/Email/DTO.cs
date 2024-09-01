using RpnInnovation.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpnInnovation.Application.Features.Email
{
    public class DTO
    {
    }

    public class EmailResponse
    {
        public string? To { get; set; }
        public string? Subject { get; set; }
        public string Content { get; set; }
        public CustomerAccount Customer { get; set; }

        public static EmailResponse Copy(string message, string subject, Domain.Entities.Account createAccount, CustomerAccount createCst)
        {
            return new EmailResponse
            {
                Content = message,
                Customer = createCst,
                To = createCst.Email,
                Subject = subject,
            };

        }
    }
}
