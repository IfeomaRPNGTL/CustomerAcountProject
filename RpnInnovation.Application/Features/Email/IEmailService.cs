using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpnInnovation.Application.Features.Email
{
    public interface IEmailService
    {
        Task<bool> SendEmailAsync(string to, string from, string subject, string content);
        Task<bool> SendEmailWithAttachmentAsync(string email);
    }
}
