using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpnInnovation.Domain.Entities
{
    public class BaseEntity
    {
        public BaseEntity()
        {
            isActive = true;
            isSuspended = false;
            CreatedOn = DateTime.Now;
        }
        public int Id { get; set; }

        // Audit Properties
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public bool isActive { get; set; }
        public bool isSuspended { get; set; }

    }
}
