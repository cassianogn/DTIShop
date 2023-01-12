using DTI.Core.Domain.Interfaces.Entities;
using MediatR;

namespace DTI.DTIShop.Application.UseCase.Administration.Commands.Products.UpdateProduct
{
    public class UpdateProductCommand : IEntityDTO, IRequest
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }

    }
}
