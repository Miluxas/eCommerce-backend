﻿using eCommerce_backend.Data;
using eCommerce_backend.Data.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace eCommerce_backend.Services
{
    public class StoreService:Base.BaseService<Store>
    {
        public StoreService(DbSet<Store> ts,ECommerceContext context,IContentRoleAccess<Store> contentRoleAccess):base(ts,context,contentRoleAccess) {
            _predicate = (query, filter) =>
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
