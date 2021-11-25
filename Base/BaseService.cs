using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace eCommerce_backend.Base
{
    public class BaseService<T> where T : BaseModel
    {
        protected DbSet<T> _ts;
        protected Data.ECommerceContext _context;

        public BaseService(DbSet<T> ts, Data.ECommerceContext context)
        {
            _ts = ts;
            _context = context;
        }

        virtual public async Task<IEnumerable<T>> List()
        {
            return await _ts.ToListAsync();
        }
        virtual public async Task<T> Detail(Guid id)
        {
            return await _ts.AsSingleQuery<T>().FirstAsync<T>(e => e.ID == id);
        }
        public async Task<T> Create(T entity,Guid userID)
        {
            entity.CreatedAt = DateTime.UtcNow;
            entity.CreatedByID = userID;
            await _ts.AddAsync(entity);
            await _context.SaveChangesAsync();
            return await _ts.AsSingleQuery<T>().FirstAsync<T>(e => e.ID == entity.ID);
        }
        public async Task<T> Update(T entity, Guid userID)
        {
            _ts.Update(entity);
            await _context.SaveChangesAsync();
            return await _ts.AsSingleQuery<T>().FirstAsync<T>(e => e.ID == entity.ID);
        }
        public async Task<Boolean> Delete(Guid id)
        {
            var model=await _ts.AsSingleQuery<T>().FirstAsync<T>(e => e.ID == id);
            if (model != null)
            {
                model.DeleteStatus = 1;
                await _context.SaveChangesAsync();
                return true;
            }
            return false;
        }
    }
}
