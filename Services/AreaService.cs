using eCommerce_backend.Data;
using eCommerce_backend.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerce_backend.Services
{
    public class AreaService:Base.BaseService<Area>
    {
        public AreaService(DbSet<Area> ts,ECommerceContext context,IContentRoleAccess<Area> contentRoleAccess):base(ts,context,contentRoleAccess) {
            _predicate = (query,filter) =>
            {
                var arr = filter.Properties();
                foreach (var prop in arr)
                {
                    if (prop.Name == "Id")
                        query = query.Where(e => e.Id == System.Guid.Parse(prop.Value.ToString()));
                    else if (prop.Name == "Name")
                        query = query.Where(e => e.Ml_Name.Contains(prop.Value.ToString()));
                }
                return query;
            };

        }

    }
}
