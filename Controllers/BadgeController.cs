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
    public class BadgeController : Base.BaseController<Badge>
    {
        public BadgeController(ECommerceContext context, IContentRoleAccess<Badge> contentRoleAccess, Guid? userId = null) : base(userId)
        {
            service = new Services.BadgeService(context.Badges, context,contentRoleAccess);
        }
    }
}
