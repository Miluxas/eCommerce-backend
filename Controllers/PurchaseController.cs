using eCommerce_backend.Data;
using eCommerce_backend.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;

namespace eCommerce_backend.Controllers
{
    [Authorize]
    [Route("[controller]")]
    [ApiController]
    public class PurchaseController : Base.BaseController<Purchase>
    {
        public PurchaseController(ECommerceContext context, Guid? userID = null) : base(userID)
        {
            service = new Services.PurchaseService(context.Purchases, context);
        }
    }
}
