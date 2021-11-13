using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using eCommerce_backend.Data;
using eCommerce_backend.Models;

namespace eCommerce_backend.Base
{
    [Route("[controller]")]
    [ApiController]
    public class BaseController<T> : ControllerBase where T : BaseModel 
    {
        protected BaseService<T> service;

        // GET: [controller]
        [HttpGet]
        public async Task<IEnumerable<T>> Index()
        {
            return await service.List();
        }

        [HttpGet]
        [Route("Detail")]
        public async Task<T?> Detail(Int64? id)
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
