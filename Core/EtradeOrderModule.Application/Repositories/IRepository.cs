using EtradeOrderModule.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EtradeOrderModule.Application.Repositories
{
    public interface IRepository<T> where T : BaseEntity
    {
        T Get(Expression<Func<T, bool>> predicate);

        IQueryable<T> GetList(Expression<Func<T, bool>>? predicate = null,
                             Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null,
                             Func<IQueryable<T>, IIncludableQueryable<T, object>>? include = null,
                             bool enableTracking = true);  
        bool Add(T entity);
        T Update(T entity);
        bool Delete(T entity);
    }
}
