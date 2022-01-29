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
    public class BrandController : Base.BaseController<Brand>
    {
        public BrandController(ECommerceContext context, IContentRoleAccess<Brand> contentRoleAccess, Guid? userId = null) : base(userId)
        {
            service = new Services.BrandService(context.Brands, context, contentRoleAccess);
        }
    }
}
