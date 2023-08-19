using AutoMapper;
using EtradeOrderModule.Application.DTOs;
using EtradeOrderModule.Application.Features.Commands.OrderCommand.UpdateOrder;
using EtradeOrderModule.Domain.Entities;


namespace EtradeOrderModule.Application.Mapping
{
    public class MappingProfile :Profile
    {
        public MappingProfile()
        {
            CreateMap<Order, CreateOrderDto>().ReverseMap();
            CreateMap<UpdateOrderCommandRequest, UpdateOrderDto>().ReverseMap();
            //CreateMap<UpdateOrderDto, Order>();
        }
    }
}
