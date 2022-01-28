using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;

namespace eCommerce_backend.Base
{
    public class BaseService<T> where T : BaseModel
    {
        protected DbSet<T> _ts;
        protected Data.ECommerceContext _context;
        protected Func<IQueryable<T>, JObject, IQueryable<T>> _predicate;
        protected Func<IQueryable<T>, JObject, IQueryable<T>> _order;
        protected Func<IQueryable<T>, Pagination, IQueryable<T>> _paginate;

        public BaseService(DbSet<T> ts, Data.ECommerceContext context)
        {
            _ts = ts;
            _context = context;
            _predicate = (query,filter) =>
            {
                return query.Where<T>(e=>true);
            };
            _order = (query, order) =>
            {
                return query.OrderByDescending(e => e.CreatedAt);
            };
            _paginate = (query, paginate) =>
            {
                return query.Skip(paginate.Limit*paginate.Page).Take(paginate.Limit);
            };
        }

        virtual public async Task<IEnumerable<T>> List(ListBody listBody)
        {
            IQueryable<T> query = _ts;
            if(listBody.Filter!=null)
                query=_predicate(query,listBody.Filter);
            if (listBody.Sort != null)
                query = _predicate(query, listBody.Sort);
                query = _paginate(query, listBody.Pagination);

            return await query.ToListAsync();
        }
        virtual public async Task<T> Detail(Guid id)
        {
            return await _ts.AsSingleQuery<T>().FirstAsync<T>(e => e.Id == id);
        }
        virtual public async Task<T> Create(T entity,Guid userId)
        {
            entity.CreatedAt = DateTime.UtcNow;
            entity.CreatedById = userId;
            await _ts.AddAsync(entity);
            await _context.SaveChangesAsync();
            return await _ts.AsSingleQuery<T>().FirstAsync<T>(e => e.Id == entity.Id);
        }
        public async Task<T> Update(T entity, Guid userId)
        {
            _ts.Update(entity);
            _context.SaveChanges();
            return await _ts.AsSingleQuery<T>().FirstAsync<T>(e => e.Id == entity.Id);
        }
        public async Task<Boolean> Delete(Guid id)
        {
            var model=await _ts.AsSingleQuery<T>().FirstAsync<T>(e => e.Id == id);
            if (model != null)
            {
                model.DeleteStatus = DeleteStatus.Trash;
                await _context.SaveChangesAsync();
                return true;
            }
            return false;
        }
    }
}
