using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.Extensions.DependencyInjection;
using ProductivityTools.Purchases.Api.Database;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace ProductivityTools.Purchases.Api.Command
{
    public static class Services
    {
        public static void RegisterePurchaseServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IPurchaseCommand, PurchaseCommand>();
            serviceCollection.RegisterDatabaseServices();
        }
    }
}
