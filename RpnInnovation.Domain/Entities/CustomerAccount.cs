using RpnInnovation.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpnInnovation.Domain.Entities
{
    // KYC
    public class CustomerAccount : BaseEntity
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string Email { get; set; }
        public string Bvn { get; set; }
        public string? CountryCode { get; set; }
        public string? Phone { get; set; } //90000000
        public string? State { get; set; }
        public string? Country { get; set; }
        public ICollection<Account> Accounts { get; set; }
    }
}
