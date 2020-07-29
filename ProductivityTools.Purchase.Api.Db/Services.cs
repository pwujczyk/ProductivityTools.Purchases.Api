using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace ProductivityTools.Purchase.Api.Database
{
    public static class Services
    {
        public static void RegisterDatabaseServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IPurchaseRepository, PurchaseRepository>();
            serviceCollection.AddDbContext<PurchaseContext>();
        }
    }
}
