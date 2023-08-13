using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EtradeOrderModule.Domain.Entities
{
    public class Order : BaseEntity
    {
        public string Address { get; set; }
        public string BasketId { get; set; }
        public string CustomerId { get; set; }
        public bool IsDeleted { get; set; } = false;

    }
}
