using Store.Domain.Entities;
using Store.Domain.Enums;

namespace Store.Tests.Entities;

[TestClass]
public class OrderTests
{
    private readonly Customer _customer = new Customer("Rômulo de Oliveira","devromulodeoliveira@gmail.com");
    private readonly Product _product = new Product("Feijão", 10, true);
    private readonly Discount _discount = new Discount(10.0m, DateTime.Now.AddDays(5));
        
    [TestMethod]
    [TestCategory("Domain")]
    public void GivenANewValidRequestItMustGenerateANumberWithEightCharacters()
    {
        var order = new Order(_customer, 10.0m, _discount);
        Assert.AreEqual(8, order.Number.Length);
    }

    [TestMethod]
    [TestCategory("Domain")]
    public void GivenANewRequestItsStatusMustBeAwaitingPayment()
    {
        var order = new Order(_customer, 10.0m, _discount);
        Assert.AreEqual(EOrderStatus.WaitingPayment, order.Status);
    }
    
    [TestMethod]
    [TestCategory("Domain")]
    public void OncePaymentHasBeenMadeForTheOrderItsStatusShouldBeAwaitingDelivery()
    {
        var order = new Order(_customer, 10.0m, _discount);
        order.AddItem(_product, 1);
        order.Pay(10.0m);
        Assert.AreEqual(EOrderStatus.WaitingDelivery, order.Status);
    }
    
    [TestMethod]
    [TestCategory("Domain")]
    public void GivenACanceledOrderItsStatusMustBeCanceled()
    {
        var order = new Order(_customer, 10.0m, _discount);
        order.AddItem(_product, 1);
        order.Cancel();
        Assert.AreEqual(EOrderStatus.Canceled, order.Status);
    }
        
    [TestMethod]
    [TestCategory("Domain")]
    public void GivenANewItemWithNoProductItShouldNotBeAdded()
    {
        var order = new Order(_customer, 10.0m, _discount);
        order.AddItem(null, 1);
        Assert.AreEqual(0, order.Items.Count);
    }

    [TestMethod]
    [TestCategory("Domain")]
    [DataRow(0)]
    [DataRow(-1)]
    [DataRow(-2)]
    public void GivenANewItemWithQuantityZeroOrLessItShouldNotBeAdded(int quantity)
    {
        var order = new Order(_customer, 10.0m, _discount);
        order.AddItem(_product, quantity);
        Assert.AreEqual(0, order.Items.Count);
    }
    
    [TestMethod]
    [TestCategory("Domain")]
    public void GivenANewValidOrderYourTotalMustBeFifty()
    {
        var order = new Order(_customer, 40.0m, null);
        order.AddItem(_product, 1);
        Assert.AreEqual(50.0m, order.Total());
    }
    
    [TestMethod]
    [TestCategory("Domain")]
    public void GivenAnExpiredDiscountTheOrderValueShouldBeSixty()
    {
        var discount = new Discount(10.0m, DateTime.Now.AddDays(-1));
        var order = new Order(_customer, 10.0m, discount);
        order.AddItem(_product, 5);
        Assert.AreEqual(60.0m, order.Total());
    }
    
    [TestMethod]
    [TestCategory("Domain")]
    public void GivenAnInvalidDiscountTheOrderValueShouldBeSixty()
    {
        var order = new Order(_customer, 10.0m, null);
        order.AddItem(_product, 5);
        Assert.AreEqual(60.0m, order.Total());
    }
    
    [TestMethod]
    [TestCategory("Domain")]
    public void GivenADiscountOfTenTheOrderValueShouldBeFifty()
    {
        var order = new Order(_customer, 10.0m, _discount);
        order.AddItem(_product, 5);
        Assert.AreEqual(50.0m, order.Total());
    }
        
    [TestMethod]
    [TestCategory("Domain")]
    public void GivenADeliveryChargeOfTenTheOrderValueShouldBSixty()
    {
        var order = new Order(_customer, 10.0m, _discount);
        order.AddItem(_product, 6); 
        Assert.AreEqual(60, order.Total());
    }
        
    [TestMethod]
    [TestCategory("Domain")]
    public void GivenAnOrderWithoutACustomerItMustBeInvalid()
    {
        var order = new Order(null, 10.0m, null);
        Assert.AreEqual(false, order.IsValid);
    }
}