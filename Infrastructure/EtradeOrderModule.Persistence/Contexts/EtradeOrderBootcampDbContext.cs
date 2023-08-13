using EtradeOrderModule.Domain.Entities;
using EtradeOrderModule.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EtradeOrderModule.Persistence.Contexts
{
    public class EtradeOrderBootcampDbContext: DbContext
    {
        protected IConfiguration Configuration { get; set; }
        public DbSet<Order> Orders { get; set; }
        public EtradeOrderBootcampDbContext(DbContextOptions dbContextOptions, IConfiguration configuration) : base(dbContextOptions)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
        }

    }
}



