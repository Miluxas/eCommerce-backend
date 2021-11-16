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

        override public async Task<Models.Attribute> Detail(Int64 id)
        {
            var query = _context.Attributes.Join(
        _context.AttributeItems,
        attribute => attribute.ID,
        item => item.AttributeID,
        (Attribute, item) => item
    ).ToList();
            var attri =await base.Detail(id);
            attri.Items = query;
            return attri;
        }
    }
}
