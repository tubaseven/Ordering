using Microsoft.Extensions.DependencyInjection;
using ShopiOrderingApp.Application.Interfaces;
using ShopiOrderingApp.Persistence.Repositories;

namespace ShopiOrderingApp.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceRegistration(this IServiceCollection services)
        {          

            services.AddTransient<IOrderRepository, OrderRepository>();
        }

    }
}
