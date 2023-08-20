using EtradeOrderModule.Application.DTOs;
using EtradeOrderModule.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EtradeOrderModule.Application.Abstractions.Services
{
    public interface IOrderService
    {
        Task<Order> CreateOrderAsync(CreateOrderDto createOrderDto);
        Task<Order> UpdateOrderAsync(UpdateOrderDto updateOrderDto);
        Task RemoveOrderAsync(string id);

        //Task<Order> GetOrderByIdAsync(string id, bool tracking = true);
    }
}
