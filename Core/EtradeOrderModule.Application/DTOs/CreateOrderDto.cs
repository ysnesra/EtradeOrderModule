using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EtradeOrderModule.Application.DTOs
{
    public class CreateOrderDto
    {
        public string Address { get; set; }
        public DateTime CreatedDate { get; set; } 
        public string BasketId { get; set; }
        public string CustomerId { get; set; }       
    }
}
