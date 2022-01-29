using eCommerce_backend.Base;
using System;
using System.Linq;

namespace eCommerce_backend
{
    public interface IContentRoleAccess<T> where T : BaseModel
    {
        Func<IQueryable<T>, IQueryable<T>> SetAccessControl();
    }
}
