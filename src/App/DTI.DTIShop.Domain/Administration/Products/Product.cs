using DTI.Core.Domain.Entities;

namespace DTI.DTIShop.Domain.Administrator.Products
{
    public class Product : NamedEntity
    {
        public Product(Guid id, string name) : base(id, name)
        {
        }

        public void SetName(string name)
        {
            Name = name;
        }
    }
}
