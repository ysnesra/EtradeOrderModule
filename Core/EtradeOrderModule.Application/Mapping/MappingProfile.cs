using AutoMapper;
using EtradeOrderModule.Application.DTOs;
using EtradeOrderModule.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EtradeOrderModule.Application.Mapping
{
    public class MappingProfile :Profile
    {
        public MappingProfile()
        {
            CreateMap<Order, CreateOrderDto>().ReverseMap();
        }
    }
}
