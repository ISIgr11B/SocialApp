using Dal.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Vive.Vcs.Visualisation.Dal.VisualisationDbContext.Entities;

namespace Vive.Vcs.Visualisation.Dal.VisualisationDbContext.Repositories
{
    public abstract class BaseRepository<TObject> : IBaseRepository<TObject> where TObject : class, IEntity
    {
        protected readonly MainDbContext _context;

        protected BaseRepository(MainDbContext context)
        {
            _context = context;
        }

        private static IQueryable<TObject> PrepareResult(IQueryable<TObject> result, Func<IQueryable<TObject>, IOrderedQueryable<TObject>> orderBy = null,
                                                 Func<IQueryable<TObject>, IQueryable<TObject>> includeMembers = null, int? skip = null, int? take = null)
        {
            if (includeMembers != null)
            {
                result = includeMembers(result);
            }
            if (orderBy != null)
            {
                result = orderBy(result);
            }
            if (skip != null)
            {
                result = result.Skip(skip.Value);
            }
            if (take != null)
            {
                result = result.Take(take.Value);
            }

            return result;
        }

        public virtual IEnumerable<TObject> GetAll(Func<IQueryable<TObject>, IOrderedQueryable<TObject>> orderBy = null,
                                                         Func<IQueryable<TObject>, IQueryable<TObject>> includeMembers = null, int? skip = null, int? take = null)
        {
            var result = _context.Set<TObject>().AsQueryable();
            return PrepareResult(result, orderBy, includeMembers, skip, take).ToList();
        }

        public virtual async Task<IEnumerable<TObject>> GetAllAsync(Func<IQueryable<TObject>, IOrderedQueryable<TObject>> orderBy = null,
                                                         Func<IQueryable<TObject>, IQueryable<TObject>> includeMembers = null, int? skip = null, int? take = null)
        {
            var result = _context.Set<TObject>().AsQueryable();
            return await PrepareResult(result, orderBy, includeMembers, skip, take).ToListAsync();
        }

        public virtual TObject Find(int id, Func<IQueryable<TObject>, IQueryable<TObject>> includeMembers = null)
        {
            var result = _context.Set<TObject>().AsQueryable();

            if (includeMembers != null)
            {
                result = includeMembers(result);
            }

            return result.FirstOrDefault(r => r.Id == id);
        }

        public virtual async Task<TObject> FindAsync(int id, Func<IQueryable<TObject>, IQueryable<TObject>> includeMembers = null)
        {
            var result = _context.Set<TObject>().AsQueryable();

            if (includeMembers != null)
            {
                result = includeMembers(result);
            }

            return await result.FirstOrDefaultAsync(r => r.Id == id);
        }

        public virtual TObject Find(Expression<Func<TObject, bool>> match, Func<IQueryable<TObject>, IQueryable<TObject>> includeMembers = null)
        {
            var result = _context.Set<TObject>().AsQueryable();

            if (includeMembers != null)
            {
                result = includeMembers(result);
            }

            return result.FirstOrDefault(match);
        }

        public virtual async Task<TObject> FindAsync(Expression<Func<TObject, bool>> match, Func<IQueryable<TObject>, IQueryable<TObject>> includeMembers = null)
        {
            var result = _context.Set<TObject>().AsQueryable();

            if (includeMembers != null)
            {
                result = includeMembers(result);
            }

            return await result.FirstOrDefaultAsync(match);
        }

        public virtual IEnumerable<TObject> FindAll(Expression<Func<TObject, bool>> match, Func<IQueryable<TObject>, IOrderedQueryable<TObject>> orderBy = null,
                                                         Func<IQueryable<TObject>, IQueryable<TObject>> includeMembers = null, int? skip = null, int? take = null)
        {
            var result = _context.Set<TObject>().Where(match).AsQueryable();

            result = PrepareResult(result, orderBy, includeMembers, skip, take);

            return result.ToList();
        }

        public virtual async Task<IEnumerable<TObject>> FindAllAsync(Expression<Func<TObject, bool>> match, Func<IQueryable<TObject>, IOrderedQueryable<TObject>> orderBy = null,
                                                         Func<IQueryable<TObject>, IQueryable<TObject>> includeMembers = null, int? skip = null, int? take = null)
        {
            var result = _context.Set<TObject>().Where(match).AsQueryable();

            result = PrepareResult(result, orderBy, includeMembers, skip, take);

            return await result.ToListAsync();
        }

        public virtual TObject Add(TObject t)
        {
            _context.Set<TObject>().Add(t);
            return t;
        }

        public virtual async Task<TObject> AddAsync(TObject t)
        {
            await _context.Set<TObject>().AddAsync(t);
            return t;
        }

        public virtual IEnumerable<TObject> AddRange(IEnumerable<TObject> t)
        {
            _context.Set<TObject>().AddRange(t);
            return t;
        }

        public async Task<IEnumerable<TObject>> AddRangeAsync(IEnumerable<TObject> t)
        {
            await _context.Set<TObject>().AddRangeAsync(t);
            return t;
        }

        public virtual TObject Update(TObject t)
        {
            _context.Attach(t);
            _context.Entry(t).State = EntityState.Modified;
            return t;
        }

        public virtual async Task<TObject> UpdateAsync(TObject t)
        {
            _context.Attach(t);
            _context.Entry(t).State = EntityState.Modified;
            return t;
        }

        public virtual IEnumerable<TObject> UpdateRange(IEnumerable<TObject> t)
        {
            _context.Set<TObject>().UpdateRange(t);
            return t;
        }

        public virtual async Task<IEnumerable<TObject>> UpdateRangeAsync(IEnumerable<TObject> t)
        {
            _context.Set<TObject>().UpdateRange(t);

            return t;
        }

        public virtual void Delete(TObject t)
        {
            _context.Set<TObject>().Remove(t);
        }

        public virtual async Task DeleteAsync(TObject t)
        {
            _context.Set<TObject>().Remove(t);
        }

        public virtual void DeleteRange(IEnumerable<TObject> t)
        {
            _context.Set<TObject>().RemoveRange(t);
        }

        public virtual async Task DeleteRangeAsync(IEnumerable<TObject> t)
        {
            _context.Set<TObject>().RemoveRange(t);
        }

        public virtual int Count()
        {
            return _context.Set<TObject>().Count();
        }

        public virtual async Task<int> CountAsync()
        {
            return await _context.Set<TObject>().CountAsync();
        }

        public virtual void DeleteAll()
        {
            IEnumerable<TObject> query = GetAll();

            foreach (var entity in query)
            {
                _context.Entry(entity).State = EntityState.Deleted;
            }
        }
    }
}
