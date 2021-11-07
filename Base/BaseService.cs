using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace eCommerce_backend.Base
{
    public class BaseService<T> where T : BaseModel
    {
        protected DbSet<T> _ts;

        public BaseService(DbSet<T> ts)
        {
            _ts = ts;
        }

        public async Task<IEnumerable<T>> List()
        {
            return await _ts.ToListAsync();
        }
    }
}
