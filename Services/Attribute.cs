using eCommerce_backend.Data;
using eCommerce_backend.Models;
using Microsoft.EntityFrameworkCore;


namespace eCommerce_backend.Services
{
    public class AttributeService:Base.BaseService<Attribute>
    {
        public AttributeService(DbSet<Attribute> ts,ECommerceContext context):base(ts,context) {

        }

    }
}
