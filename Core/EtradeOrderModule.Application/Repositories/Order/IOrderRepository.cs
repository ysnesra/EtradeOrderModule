using EtradeOrderModule.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EtradeOrderModule.Application.Repositories
{
    public interface IOrderRepository : IRepository<Order>,IAsyncRepository<Order>
    {
    }
}
