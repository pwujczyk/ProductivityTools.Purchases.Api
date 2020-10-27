using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace ProductivityTools.Purchases.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [EnableCors("policy")]
    public class TestController : Controller
    {
        [HttpGet]
        [EnableCors("policy")]
        [Route("Hi")]
        public object Hi()
        {
            return new { Hi = $"Hi unsecured {DateTime.Now}" };
        }

        [HttpGet]
        [Route("HiSecure")]
        [Authorize(AuthenticationSchemes = "Bearer")]
        public object HiSecure()
        {
            return new { Hi = $"Hi secured {DateTime.Now}" };
        }
    }
}