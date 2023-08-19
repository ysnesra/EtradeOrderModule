using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EtradeOrderModule.Application.Features.Commands.OrderCommand.CreateOrder
{
    public class CreateOrderCommandRequest :IRequest<CreateOrderCommandResponse>
    {
        public string Address { get; set; }
            
    }
}
