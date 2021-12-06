﻿using System;
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
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication.JwtBearer;

namespace eCommerce_backend.Base
{
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    [Route("[controller]")]
    [ApiController]
    public class BaseController<T> : ControllerBase where T : BaseModel 
    {
        public class ListBody
        {
            public int Page { get; set; }
            public int Limit { get; set; }
            public dynamic Filter { get; set; }

        }
        public BaseController(){
        }
        protected BaseService<T> service;

        [HttpPost]
        public async Task<IEnumerable<T>> Index(ListBody listBody)
        {

            return await service.List(listBody);
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
        virtual public async Task<T> Create( T detail)
        {
            var userID =Guid.Parse( User.FindFirstValue(ClaimTypes.NameIdentifier));

            return await service.Create(detail,userID);
        }

        [HttpPost]
        [Route("Update")]
        public async Task<T> Update(T detail)
        {
            var userID = Guid.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));

            return await service.Update(detail, userID);
        }

        [HttpDelete]
        [Route("Delete")]
        public async Task<Boolean> Delete(Guid id)
        {
            return await service.Delete(id);
        }
    }
}
