using eCommerce_backend.Data;
using eCommerce_backend.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerce_backend.Services
{
    public class VariationService : Base.BaseService<Variation>
    {
        public VariationService(DbSet<Variation> ts, ECommerceContext context) : base(ts, context)
        {
        }

        override public async Task<Variation> Detail(Guid id)
        {
            var query = _context.Variations.Join(
                    _context.VariationItems,
                    variation => variation.ID,
                    item => item.VariationID,
                    (Variation, item) => item
                ).ToList();
            var attri = await base.Detail(id);
            attri.Items = query;
            return attri;
        }
    }
}
