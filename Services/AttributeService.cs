using eCommerce_backend.Data;
using eCommerce_backend.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerce_backend.Services
{
    public class AttributeService:Base.BaseService<Models.Attribute>
    {
        public AttributeService(DbSet<Models.Attribute> ts,ECommerceContext context):base(ts,context) {
            

        }

    }
}
