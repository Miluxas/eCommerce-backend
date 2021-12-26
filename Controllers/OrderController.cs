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
        public OrderController(ECommerceContext context, Guid? userID = null) : base(userID)
        {
            service = new Services.OrderService(context.Orders, context);
        }
    }
}
