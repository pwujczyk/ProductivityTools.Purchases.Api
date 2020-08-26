using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProductivityTools.Purchase.Api.Command;

namespace ProductivityTools.Purchase.Api.Controllers
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
        public HttpStatusCode Add(Contract.Purchase purchase)
        {
            this.PurchaseCommand.AddPurchase(purchase);
            return HttpStatusCode.OK;
        }
    }
}