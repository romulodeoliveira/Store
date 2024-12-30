using Store.Domain.Entities;
using Store.Domain.Repositories;

namespace Store.Tests.Repositories;

public class FakeDiscountRepository : IDiscountRepository
{
    public Discount Get(string code)
    {
        if (code == "123456789")
        {
            return new Discount(10, DateTime.Now.AddDays(5));
        }

        if (code == "111111111")
        {
            return new Discount(10, DateTime.Now.AddDays(-1));
        }

        return null;
    }
}