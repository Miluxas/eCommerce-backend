using eCommerce_backend.Data;
using eCommerce_backend.Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;

namespace eCommerce_backend.Controllers
{
    [Authorize]
    [Route("[controller]")]
    [ApiController]
    public class WarehouseController : Base.BaseController<Warehouse>
    {
        public WarehouseController(ECommerceContext context, Guid? userId = null) : base(userId)
        {
            service = new Services.WarehouseService(context.Warehouses, context);
        }
    }
}
