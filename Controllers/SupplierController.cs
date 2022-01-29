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
    public class SupplierController : Base.BaseController<Supplier>
    {
        public SupplierController(ECommerceContext context, IContentRoleAccess<Supplier> contentRoleAccess, Guid? userId = null) : base(userId)
        {
            service = new Services.SupplierService(context.Suppliers, context, contentRoleAccess);
        }
    }
}
