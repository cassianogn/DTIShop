using DTI.Core.Infrastructure.Repositories;
using DTI.DTIShop.Domain.Administrator.Products;
using Microsoft.EntityFrameworkCore;

namespace DTI.DTIShop.Infrastructure.Administration.Products
{
    internal class ProductsRepository : EntityRepository<Product>
    {
        public ProductsRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
