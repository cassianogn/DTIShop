using DTI.DTIShop.Application;
using DTI.DTIShop.Application.UseCase.Administration.Commands.Products.AddProduct;
using DTI.DTIShop.Domain.Tests.Integration;
using DTI.DTIShop.Domain.Tests.Integration.Administration.Products.Data;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;
using Xunit;

namespace DTI.DTIShop.Domain.Integration.Unit.Administration.Products
{
    public class ProductHandlerTests
    {
        [Fact(DisplayName = "Adicionar novo produto com sucesso")]
        public void AddProductCommandHandler_Add_Success()
        {
            var providers = GetProvider();
            var mediator = providers.GetService<IMediator>();
            mediator.Send(new AddProductCommand() {Name = "Cassiano" });
        }

        public IServiceProvider GetProvider()
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddInfrastructure();
            return serviceCollection.BuildServiceProvider();
        }
    }
}
