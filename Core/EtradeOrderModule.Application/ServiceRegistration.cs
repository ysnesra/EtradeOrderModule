using EtradeOrderModule.Application.Mapping;
using FluentValidation;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EtradeOrderModule.Application
{
    public static class ServiceRegistration
    {
        public static void AddApplicationServices(this IServiceCollection servis)
        {           
            servis.AddMediatR(Assembly.GetExecutingAssembly());
            servis.AddAutoMapper(typeof(MappingProfile));
        }
    }
}
