using eCommerce_backend.Data;
using eCommerce_backend.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerce_backend.Services
{
    public class AreaService:Base.BaseService<Models.Area>
    {
        public AreaService(DbSet<Area> ts,ECommerceContext context):base(ts,context) {
            

        }

    }
}
