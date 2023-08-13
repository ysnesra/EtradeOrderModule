using EtradeOrderModule.Application.Repositories;
using EtradeOrderModule.Domain.Entities;
using EtradeOrderModule.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EtradeOrderModule.Persistence.Repositories
{
    public class OrderRepository : RepositoryBase<Order>, IOrderRepository
    {
        public OrderRepository(EtradeOrderBootcampDbContext context) :base(context)
        {
                
        }
       
    }
}
