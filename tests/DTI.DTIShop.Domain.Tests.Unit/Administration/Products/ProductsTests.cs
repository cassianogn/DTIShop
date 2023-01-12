using DTI.DTIShop.Domain.Administrator.Products;
using System;
using Xunit;

namespace DTI.DTIShop.Domain.Tests.Unit.Administration.Products
{
    public class ProductsTests
    {
        [Fact(DisplayName = "Instanciar produto com sucesso")]
        public void Produdct_GenerateInstance_Success()
        {
            var productId = Guid.NewGuid();
            var product = new Product(productId, "mesa");

            Assert.Equal(productId, product.Id);
            Assert.Equal("mesa", product.Name);
        }

    }
}
