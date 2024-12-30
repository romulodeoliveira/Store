using Store.Domain.Entities;
using Store.Domain.Repositories;

namespace Store.Tests.Repositories;

public class FakeProductRepository : IProductRepository
{
    public IEnumerable<Product> Get(IEnumerable<Guid> ids)
    {
        IList<Product> products = new List<Product>();
        products.Add(new Product("Arroz", 7, true));
        products.Add(new Product("Feijão", 10, true));
        products.Add(new Product("Leite", 9, true));
        products.Add(new Product("Azeite", 60, false));
        products.Add(new Product("Cerveja", 5, false));

        return products;
    }
}