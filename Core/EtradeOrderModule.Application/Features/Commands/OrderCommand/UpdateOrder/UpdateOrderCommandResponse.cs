using EtradeOrderModule.Application.Features.Commands.Response;


namespace EtradeOrderModule.Application.Features.Commands.OrderCommand.UpdateOrder
{
    public class UpdateOrderCommandResponse : BaseResponse
    {
        public string OrderId { get; set; }
        public UpdateOrderCommandResponse(string orderId)
        {
            OrderId = orderId;
            Message = $"The order with ID {orderId} has been successfully updated.";
        }
    }
}
