using AutoMapper;
using EtradeOrderModule.Application.Abstractions.Services;
using EtradeOrderModule.Application.DTOs;
using EtradeOrderModule.Domain.Entities;
using MediatR;

namespace EtradeOrderModule.Application.Features.Commands.OrderCommand.CreateOrder
{
    public class CreateOrderCommandHandler : IRequestHandler<CreateOrderCommandRequest, CreateOrderCommandResponse>
    {
        private readonly IOrderService _orderService;
        private readonly IMapper _mapper;

        public CreateOrderCommandHandler(IOrderService orderService, IMapper mapper)
        {
            _orderService = orderService;
            _mapper = mapper;
        }

        public async Task<CreateOrderCommandResponse> Handle(CreateOrderCommandRequest request, CancellationToken cancellationToken)
        {   
            Order orderdb = new() 
            {
                Address=request.Address,
                BasketId=Guid.NewGuid().ToString(),
                CustomerId=Guid.NewGuid().ToString()
            };
            CreateOrderDto orderDto = _mapper.Map<CreateOrderDto>(orderdb);
            await _orderService.CreateOrderAsync(orderDto);
            return new(orderdb.Id);
        }
    }
}
