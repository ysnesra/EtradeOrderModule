using EtradeOrderModule.Application.Features.Commands.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EtradeOrderModule.Application.Features.Commands.OrderCommand.CreateOrder
{
    public class CreateOrderCommandResponse :BaseResponse
    {
        public string OrderId { get; set; }
        public CreateOrderCommandResponse(string orderId)
        {
            OrderId = orderId;
            Message = $"The order with ID {orderId} has been successfully created.";
        }
    }
}
