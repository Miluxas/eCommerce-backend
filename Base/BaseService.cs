using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace eCommerce_backend.Base
{
    public class BaseService<T> :IBaseService<T> where T : BaseModel
    {
        protected DbSet<T> _ts;
        protected Data.ECommerceContext _context;

        public BaseService(DbSet<T> ts, Data.ECommerceContext context)
        {
            _ts = ts;
            _context = context;
        }

        public async Task<IEnumerable<T>> List()
        {
            return await _ts.ToListAsync();
        }
        public async Task<T> Detail(Int64 id)
        {
            return await _ts.AsNoTracking<T>().FirstAsync<T>(e => e.ID == id);
        }
        public async Task<T> Create(T entity)
        {
            entity.CreatedAt = DateTime.UtcNow;
        
            await _ts.AddAsync(entity);
            await _context.SaveChangesAsync();
            return await _ts.AsNoTracking<T>().FirstAsync<T>(e => e.ID == entity.ID);
        }
    }
}
