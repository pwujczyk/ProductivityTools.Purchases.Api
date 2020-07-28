using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ProductivityTools.Purchase.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PurchaseController : Controller
    {
        [HttpPost]
        [Route("Add")]
        public IActionResult Add(object x)
        {
            return View();
        }
    }
}