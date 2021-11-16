using eCommerce_backend.Data;
using eCommerce_backend.Models;
using Microsoft.EntityFrameworkCore;


namespace eCommerce_backend.Services
{
    public class TagService:Base.BaseService<Tag>
    {
        public TagService(DbSet<Tag> ts,ECommerceContext context):base(ts,context) {

        }

    }
}
