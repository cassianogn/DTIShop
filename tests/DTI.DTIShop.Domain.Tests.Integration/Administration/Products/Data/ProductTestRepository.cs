using DTI.Core.Application.Ports.Out;
using DTI.DTIShop.Domain.Administrator.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTI.DTIShop.Domain.Tests.Integration.Administration.Products.Data
{
    public class ProductTestRepository : IReaderRepository<Product>, IWriterRepository<Product>
    {
        public Task AddAsync(Product entity)
        {
            return Task.CompletedTask;
        }

        public Task DeleteAsync(Product entity)
        {
            return Task.CompletedTask;
        }
        public Task<Product> GetEntityByIdAsync(Guid id)
        {
            return Task.FromResult(new Product(id, "teste"));
        }

        public Task UpdateAsync(Product entity)
        {
            return Task.CompletedTask;
        }

    }
}
