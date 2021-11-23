using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerce_backend.Base
{
    public interface IBaseService<T> where T : BaseModel
    {
        public Task<IEnumerable<T>> List();
        public Task<T> Detail(Guid id);
        public Task<T> Create(T entity);
    }
}
