using BackEnd_Api.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using static BackEnd_Api.Models.DataEntity;

namespace BackEnd_Api.Controllers
{
    [RoutePrefix("api/v1/User")]
    public class UserController : CommonApiController
    {
        User[] lstUser = new User[]
        {
            new User { Id = 1, name = "Thanh", status= 1 },
            new User { Id = 2, name = "Xuan", status = 1 },
            new User { Id = 3, name = "Nguyen", status = 1 }
        };


        [Route("")]
        [HttpGet]
        public HttpResponseMessage Get()
        {
            return ToJson(lstUser.AsEnumerable());
        }
    }
}
