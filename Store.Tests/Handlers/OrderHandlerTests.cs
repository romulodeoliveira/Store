using Store.Domain.Repositories;
using Store.Tests.Repositories;

namespace Store.Tests.Handlers;

[TestClass]
public class OrderHandlerTests
{
    private readonly ICustomerRepository _customerRepository;
    private readonly IDeliveryFeeRepository _deliveryFeeRepository;
    private readonly IDiscountRepository _discountRepository;
    private readonly IProductRepository _productRepository;
    private readonly IOrderRepository _orderRepository;

    public OrderHandlerTests()
    {
        _customerRepository = new FakeCustomerRepository();
        _deliveryFeeRepository = new FakeDeliveryFeeRepository();
        _discountRepository = new FakeDiscountRepository();
        _productRepository = new FakeProductRepository();
        _orderRepository = new FakeOrderRepository();
    }

    [TestMethod]
    [TestCategory("Handlers")]
    public void GivenANonExistentCustomerTheOrderShouldNotBeGenerated()
    {
        Assert.Fail();
    }
    
    [TestMethod]
    [TestCategory("Handlers")]
    public void GivenAnInvalidZipCodeTheOrderMustBeGeneratedNormally()
    {
        Assert.Fail();
    }
    
    [TestMethod]
    [TestCategory("Handlers")]
    public void GivenANonExistentPromoCodeTheOrderMustBeGeneratedNormally()
    {
        Assert.Fail();
    }
    
    [TestMethod]
    [TestCategory("Handlers")]
    public void GivenAnOrderWithNoItemsItShouldNotBeGenerated()
    {
        Assert.Fail();
    }
    
    [TestMethod]
    [TestCategory("Handlers")]
    public void GivenAnInvalidCommandTheRequestShouldNotBeGenerated()
    {
        Assert.Fail();
    }
    
    [TestMethod]
    [TestCategory("Handlers")]
    public void GivenAValidCommandTheRequestMustBeGenerated()
    {
        Assert.Fail();
    }
}