using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using eCommerce_backend.Data;
using eCommerce_backend.Models;
using eCommerce_backend.IdentityAuth;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;

namespace eCommerce_backend.Base
{
    [Route("[controller]")]
    [ApiController]
    public class BaseController<T> : ControllerBase where T : BaseModel 
    {
        private readonly UserManager<ApplicationUser> _userManager;

        public BaseController(UserManager<ApplicationUser> userManager){
            _userManager = userManager;
        }
        protected BaseService<T> service;

        // GET: [controller]
        [HttpGet]
        public async Task<IEnumerable<T>> Index()
        {
            var userEmail = User.FindFirstValue(ClaimTypes.Email);
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier); // will give the user's userId

            return await service.List();
        }

        [HttpGet]
        [Route("Detail")]
        public async Task<T?> Detail(Guid? id)
        {
            if (id.HasValue)
                return await service.Detail(id.Value);
            else
                return null;

        }

        [HttpPost]
        [Route("Create")]
        public async Task<T> Create( T detail)
        {
            return await service.Create(detail);
        }

        // GET: [controller]/Details/5
    }
}
