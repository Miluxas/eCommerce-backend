using System;
using System.Linq;

namespace eCommerce_backend
{
    public class ContentRoleAccess<T> : IContentRoleAccess<T> where T : Base.BaseModel
    {
        public Func<IQueryable<T>, IQueryable<T>> SetAccessControl()
        {
            return (query) =>
            {
                return query.Where(bm => bm.IsActive);
            };
        }
    }
}
