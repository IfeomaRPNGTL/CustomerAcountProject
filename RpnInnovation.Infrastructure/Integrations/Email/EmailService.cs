using RpnInnovation.Application.Features.Email;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpnInnovation.Infrastructure.Integrations.Email
{
    public class EmailService : IEmailService
    {

       
        public Task<bool> SendEmailAsync(string to, string from, string subject, string content)
        {
            throw new NotImplementedException();
        }

        public Task<bool> SendEmailWithAttachmentAsync(string email)
        {
            throw new NotImplementedException();
        }
    }
}
