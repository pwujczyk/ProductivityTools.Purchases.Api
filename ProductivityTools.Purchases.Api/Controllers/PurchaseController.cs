using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProductivityTools.Purchases.Api.Command;
using ProductivityTools.Purchases.Contract;

namespace ProductivityTools.Purchases.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PurchaseController : Controller
    {
        readonly IPurchaseCommand PurchaseCommand;

        public PurchaseController(IPurchaseCommand purchaseCommand)
        {
            this.PurchaseCommand = purchaseCommand;
        }

        [HttpPost]
        [Route("Add")]
        public HttpStatusCode Add(Purchase purchase)
        {
            this.PurchaseCommand.AddPurchase(purchase);
            return HttpStatusCode.OK;
        }

        [HttpGet]
        [Route("List")]
        [Authorize(AuthenticationSchemes = "Bearer")]
        public List<Purchase> List()
        {
            var r = new List<Purchase>();
            r.Add(new Purchase() { Id = 1, Status = "done" });
            r.Add(new Purchase() { Id = 2, Status = "in progress" });
            return r;
        }
    }
}