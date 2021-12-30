using eCommerce_backend.Data;
using eCommerce_backend.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace eCommerce_backend.Services
{
    public class PurchaseService : Base.BaseService<Purchase>
    {
        public PurchaseService(DbSet<Purchase> ts,ECommerceContext context):base(ts,context) {

        }
        public async Task<Purchase> RegisterNewPurchase(Purchase entity, Guid userId)
        {
            entity.CreatedAt = DateTime.UtcNow;
            entity.CreatedById = userId;
            await _ts.AddAsync(entity);
            await _context.SaveChangesAsync();
            return await _ts.AsSingleQuery<Purchase>().FirstAsync<Purchase>(e => e.Id == entity.Id);
        }

    }
}
