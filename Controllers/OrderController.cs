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
    public class OrderController : Base.BaseController<Order>
    {
        public OrderController(ECommerceContext context, Guid? userId = null) : base(userId)
        {
            service = new Services.OrderService(context.Orders, context);
        }
    }
}
