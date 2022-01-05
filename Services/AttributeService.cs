using eCommerce_backend.Data;
using eCommerce_backend.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerce_backend.Services
{
    public class AttributeService:Base.BaseService<Data.Models.Attribute>
    {
        public AttributeService(DbSet<Data.Models.Attribute> ts,ECommerceContext context):base(ts,context) {
            

        }

    }
}
