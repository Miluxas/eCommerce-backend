using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using eCommerce_backend.Data;
using eCommerce_backend.Data.Models;
using Microsoft.AspNetCore.Identity;
using eCommerce_backend.IdentityAuth;

namespace eCommerce_backend.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CategoryController : Base.BaseController<Category>
    {
        public CategoryController(ECommerceContext context, IContentRoleAccess<Category> contentRoleAccess, Guid? userId=null) : base(userId)
        {
            service = new Services.CategoryService(context.Categories,context,contentRoleAccess);
        }
    }
}
