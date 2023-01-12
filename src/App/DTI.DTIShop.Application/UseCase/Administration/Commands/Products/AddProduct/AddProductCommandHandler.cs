using DTI.Core.Application.Ports.Out;
using DTI.Core.Application.UseCases.AddEntity;
using DTI.DTIShop.Domain.Administrator.Products;
using MediatR;

namespace DTI.DTIShop.Application.UseCase.Administration.Commands.Products.AddProduct
{
    public class AddProductCommandHandler : AddEntityCommandHandler<Product, AddProductCommand>, IRequestHandler<AddProductCommand, Guid>
    {
        public AddProductCommandHandler(IWriterRepository<Product> writerRepository) : base(writerRepository)
        {
        }

        public async Task<Guid> Handle(AddProductCommand command, CancellationToken cancellationToken)
        {
            return await Execute(command);
        }

        public override Product MapCommandToEntity(AddProductCommand command)
        {
            var product = new Product(Guid.NewGuid(), command.Name);
            return product;
        }
    }
}
