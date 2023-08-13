using EtradeOrderModule.Application.Abstractions.Services;
using EtradeOrderModule.Application.Repositories;
using EtradeOrderModule.Persistence.Contexts;
using EtradeOrderModule.Persistence.Repositories;
using EtradeOrderModule.Persistence.Services;
using FluentValidation;
using Microsoft.AspNetCore.Authentication;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EtradeOrderModule.Persistence
{
    public static class ServiceRegistration
    {
        public static IServiceCollection AddPersistenceServices(this IServiceCollection services,
                                                                IConfiguration configuration)
        {
            services.AddDbContext<EtradeOrderBootcampDbContext>(options =>
                                                     options.UseSqlServer(
                                                         configuration.GetConnectionString("DefaultConnectionString")));

            services.AddScoped<IOrderRepository, OrderRepository>();
            services.AddScoped<IOrderService, OrderService>();


            return services;
        }
    }
}
