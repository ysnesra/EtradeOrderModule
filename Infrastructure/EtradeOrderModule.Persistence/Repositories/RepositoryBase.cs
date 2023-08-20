using EtradeOrderModule.Application.Repositories;
using EtradeOrderModule.Domain.Entities;
using EtradeOrderModule.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EtradeOrderModule.Persistence.Repositories
{
    public class RepositoryBase<T> : IAsyncRepository<T>, IRepository<T>
         where T : BaseEntity
    {
        private readonly EtradeOrderBootcampDbContext _context;

        public RepositoryBase(EtradeOrderBootcampDbContext context)
        {
            _context = context;
        }

        public async Task<T?> GetAsync(Expression<Func<T, bool>> predicate)
        {
            return await _context.Set<T>().FirstOrDefaultAsync(predicate);
        }

        public async Task<IQueryable<T>> GetListAsync(Expression<Func<T, bool>>? predicate = null,
                                                           Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy =
                                                               null,
                                                           Func<IQueryable<T>, IIncludableQueryable<T, object>>?
                                                               include = null, bool enableTracking = true,
                                                           CancellationToken cancellationToken = default)
        {
            IQueryable<T> queryable = Query();
            if (!enableTracking) queryable = queryable.AsNoTracking();
            if (include != null) queryable = include(queryable);
            if (predicate != null) queryable = queryable.Where(predicate);
            if (orderBy != null) queryable = orderBy(queryable);

            return queryable;
        }



        public IQueryable<T> Query()
        {
            return _context.Set<T>();
        }

        public async Task<T> AddAsync(T entity)
        {
            _context.Entry(entity).State = EntityState.Added;
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<T> UpdateAsync(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<bool> DeleteAsync(T entity)
        {
            _context.Entry(entity).State = EntityState.Deleted;
            await _context.SaveChangesAsync();
            return true;
        }

        public T? Get(Expression<Func<T, bool>> predicate)
        {
            return _context.Set<T>().FirstOrDefault(predicate);
        }

        public IQueryable<T> GetList(Expression<Func<T, bool>>? predicate = null,
                                          Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null,
                                          Func<IQueryable<T>, IIncludableQueryable<T, object>>? include = null,
                                          bool enableTracking = true)
        {
            IQueryable<T> queryable = Query();
            if (!enableTracking) queryable = queryable.AsNoTracking();
            if (include != null) queryable = include(queryable);
            if (predicate != null) queryable = queryable.Where(predicate);
            if (orderBy != null) queryable = orderBy(queryable);

            return queryable;
        }



        public bool Add(T entity)
        {
            _context.Entry(entity).State = EntityState.Added;
            _context.SaveChanges();
            return true;       
        }

        public T Update(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();
            return entity;
        }

        public bool Delete(T entity)
        {
            _context.Entry(entity).State = EntityState.Deleted;
            _context.SaveChanges();
            return true;
        }

    }
}
