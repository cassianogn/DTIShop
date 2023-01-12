using DTI.Core.Application.Ports.Out;
using DTI.Core.Application.UseCases.UpdateEntity;
using DTI.DTIShop.Domain.Administrator.Products;
using MediatR;

namespace DTI.DTIShop.Application.UseCase.Administration.Commands.Products.UpdateProduct
{
    public class UpdateProductCommandHandler : UpdateEntityCommandHandler<Product, UpdateProductCommand>, IRequestHandler<UpdateProductCommand>
    {
        public UpdateProductCommandHandler(IWriterRepository<Product> writerRepository, IReaderRepository<Product> readerRepository) : base(writerRepository, readerRepository)
        {
        }

        public async Task<Unit> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
        {
            await Execute(request);
            return Unit.Value;
        }

        protected override Product UpdateEntity(Product entity, UpdateProductCommand command)
        {
            entity.SetName(command.Nome);
            return entity;
        }
    }
}
