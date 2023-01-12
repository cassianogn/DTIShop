using DTI.DTIShop.Application;
using DTI.DTIShop.Infrastructure.Administration.Products;
using Microsoft.Extensions.DependencyInjection;

namespace DTI.DTIShop.Domain.Tests.Integration
{
    public static class InfrastrucuteModule
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            //services.AddDbContext<>
            services.AddDTIShopApplication<ProductsRepository>();
            return services;
        }
    }
}
