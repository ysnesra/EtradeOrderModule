using AutoMapper;
using EtradeOrderModule.Application.Abstractions.Services;
using EtradeOrderModule.Application.DTOs;
using EtradeOrderModule.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EtradeOrderModule.Application.Features.Commands.OrderCommand.UpdateOrder
{
    public class UpdateOrderCommandHandler : IRequestHandler<UpdateOrderCommandRequest, UpdateOrderCommandResponse>
    {
        private readonly IOrderService _orderService;
        private readonly IMapper _mapper;

        public UpdateOrderCommandHandler(IOrderService orderService, IMapper mapper)
        {
            _orderService = orderService;
            _mapper = mapper;
        }
        public async Task<UpdateOrderCommandResponse> Handle(UpdateOrderCommandRequest request, CancellationToken cancellationToken)
        {
            UpdateOrderDto updateOrderDto = _mapper.Map<UpdateOrderDto>(request);

            Order orderdb = await _orderService.UpdateOrderAsync(updateOrderDto);
            var mappedOrderId = new UpdateOrderCommandResponse(orderdb.Id);
            return mappedOrderId;
        }
    }
}
