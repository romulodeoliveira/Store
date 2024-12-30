using Store.Domain.Entities;
using Store.Domain.Queries;
using Store.Domain.Repositories;

namespace Store.Tests.Queries;

[TestClass]
public class ProductQueriesTests
{
    private IList<Product> _products;

    public ProductQueriesTests()
    {
        _products = new List<Product>();
        _products.Add(new Product("Arroz", 7, true));
        _products.Add(new Product("Feijão", 10, true));
        _products.Add(new Product("Leite", 9, true));
        _products.Add(new Product("Azeite", 60, false));
        _products.Add(new Product("Cerveja", 5, false));
    }
    
    [TestMethod]
    [TestCategory("Queries")]
    public void GivenTheActiveProductsQueryItShouldReturnThree()
    {
        var result = _products.AsQueryable().Where(ProductQueries.GetActiveProducts());
        Assert.AreEqual(3, result.Count());
    }

    [TestMethod]
    [TestCategory("Queries")]
    public void GivenTheInactiveProductsQueryItShouldReturnTwo()
    {
        var result = _products.AsQueryable().Where(ProductQueries.GetInactiveProducts());
        Assert.AreEqual(2, result.Count());
    }
}