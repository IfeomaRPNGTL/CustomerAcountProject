using RpnInnovation.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpnInnovation.Domain.Entities
{
    public class Account : BaseEntity
    {
        public string? AccountNumber { get; set; }
        public decimal? Balance { get; set; }
        public decimal? LedgerBalance { get; set; }
        public AccountType? AccountType { get; set; }
        public int? CustomerID { get; set; } // foreign key
        public string? Email { get; set; } // foreign key
        public string? Bvn { get; set; } // foreign key
        public CustomerAccount? Customer { get; set; }
    }
}
