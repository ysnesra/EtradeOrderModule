using EtradeOrderModule.Application.Abstractions.Services;
using EtradeOrderModule.Application.DTOs;
using EtradeOrderModule.Application.Exceptions;
using EtradeOrderModule.Application.Repositories;
using EtradeOrderModule.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EtradeOrderModule.Persistence.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;

        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public async Task<Order> CreateOrderAsync(CreateOrderDto createOrderDto)
        {
            var newOrder = await _orderRepository.AddAsync(new()
            {
                CreatedDate = DateTime.Now,
                BasketId = createOrderDto.BasketId,
                CustomerId = createOrderDto.CustomerId,
                Address = createOrderDto.Address,

            });
            return newOrder;
        }

        public async Task RemoveOrderAsync(string id)
        {
            Order? order= await _orderRepository.GetAsync(x=>x.Id==id);
            if(order is null)
                throw new NotFoundOrderException();
            order.IsDeleted = true;
            await _orderRepository.UpdateAsync(order);
        }

        public async Task<Order> UpdateOrderAsync(UpdateOrderDto updateOrderDto)
        {
            Order? order = await _orderRepository.GetAsync(x => x.Id == updateOrderDto.Id);
            if (order is null)
                throw new NotFoundOrderException();
            //Silindiyse Güncellenemesin
            if (order.IsDeleted)
                throw new UpdateControlException();

            order.Address = updateOrderDto.Address;
            var updatedOrder = await _orderRepository.UpdateAsync(order);

            return updatedOrder;
        }

    }
}
