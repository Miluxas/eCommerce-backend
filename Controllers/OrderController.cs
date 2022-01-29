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
    public class OrderController : Base.BaseController<Order>
    {
        public OrderController(ECommerceContext context, IContentRoleAccess<Order> contentRoleAccess, Guid? userId = null) : base(userId)
        {
            service = new Services.OrderService(context.Orders, context, contentRoleAccess);
        }
    }
}
