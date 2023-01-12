using MediatR;

namespace DTI.DTIShop.Application.UseCase.Administration.Commands.Products.AddProduct
{
    public class AddProductCommand : IRequest<Guid>
    {
        public string Name { get; set; }
    }
}
