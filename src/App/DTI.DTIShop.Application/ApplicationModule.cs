using DTI.Core.Application.Ports.Out;
using DTI.Core.Domain;
using DTI.DTIShop.Application.UseCase.Administration.Commands.Products.AddProduct;
using DTI.DTIShop.Domain.Administrator.Products;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace DTI.DTIShop.Application
{
    public static class ApplicationModule
    {
        public static IServiceCollection AddDTIShopApplication<
            TProductRepositoryAdapter
            >(this IServiceCollection services)
            where TProductRepositoryAdapter : class, IReaderRepository<Product>, IWriterRepository<Product>
        {
            services.AddScoped<IReaderRepository<Product>, TProductRepositoryAdapter>();
            services.AddScoped<IWriterRepository<Product>, TProductRepositoryAdapter>();
            services.AddDomainCoreModule();
            AddMediator(services);
            return services;
        }

        private static void AddMediator(IServiceCollection services)
        {
            services.AddMediatR(typeof(AddProductCommand));
        }
    }
}
