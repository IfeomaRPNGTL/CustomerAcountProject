using RpnInnovation.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpnInnovation.Domain.Entities
{
    public class Transaction : BaseEntity
    {
        public string AccountNumber { get; set; }
        public decimal Amount { get; set; }
        public decimal Charge { get; set; }
        public decimal NetAmount { get; set; }
        public TransactionType TransactionType { get; set; } 
    }
}
