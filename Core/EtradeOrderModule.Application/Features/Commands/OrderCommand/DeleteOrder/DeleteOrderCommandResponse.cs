using EtradeOrderModule.Application.Features.Commands.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EtradeOrderModule.Application.Features.Commands.OrderCommand.DeleteOrder
{
    public class DeleteOrderCommandResponse : BaseResponse
    {
        public string OrderId { get; set; }
        public DeleteOrderCommandResponse(string orderId)
        {
            OrderId = orderId;
            Message = $"The order with ID {orderId} has been canceled.";
        }
    }
}
