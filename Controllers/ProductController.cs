using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using eCommerce_backend.Data;
using eCommerce_backend.Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using eCommerce_backend.IdentityAuth;
using System.Security.Claims;

namespace eCommerce_backend.Controllers
{
    [Authorize]
    [Route("[controller]")]
    [ApiController]
    public class ProductController : Base.BaseController<Product>
    {
        public ProductController(ECommerceContext context, IContentRoleAccess<Product> contentRoleAccess, Guid? userId=null) : base(userId)
        {
            service = new Services.ProductService(context.Products,context,contentRoleAccess);
        }

        //[HttpPost]
        //[Route("Create")]
        //override public async Task<Product> Create(Product detail)
        //{
        //    var userId = Guid.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));
        //    //var list = new Task<Product>[10000000];
        //    for (int i = 0; i < 10000000; i++)
        //    {
        //        detail.Id = Guid.NewGuid();
        //        var name = new Dictionary<string, string>();
        //        name.Add("en", " created by seeder   " + i.ToString());
        //        detail.Name = name;

        //        await service.Create(detail, userId);
        //    }
        //    //await Task.WhenAll(list);
        //    return await service.Create(detail, userId);
        //}
    }
}
