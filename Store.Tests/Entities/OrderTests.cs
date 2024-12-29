namespace Store.Tests.Entities;

[TestClass]
public class OrderTests
{
    [TestMethod]
    [TestCategory("Domain")]
    public void GivenANewValidRequestItMustGenerateANumberWithEightCharacters()
    {
        Assert.Fail();
    }

    [TestMethod]
    [TestCategory("Domain")]
    public void GivenANewRequestItsStatusMustBeAwaitingPayment()
    {
        Assert.Fail();
    }
    
    [TestMethod]
    [TestCategory("Domain")]
    public void OncePaymentHasBeenMadeForTheOrderItsStatusShouldBeAwaitingDelivery()
    {
        Assert.Fail();
    }
    
    [TestMethod]
    [TestCategory("Domain")]
    public void GivenACanceledOrderItsStatusMustBeCanceled()
    {
        Assert.Fail();
    }
        
    [TestMethod]
    [TestCategory("Domain")]
    public void GivenANewItemWithNoProductItShouldNotBeAdded()
    {
        Assert.Fail();
    }
    
    [TestMethod]
    [TestCategory("Domain")]
    public void GivenANewValidOrderYourTotalMustBeFifty()
    {
        Assert.Fail();
    }
    
    [TestMethod]
    [TestCategory("Domain")]
    public void GivenAnExpiredDiscountTheOrderValueShouldBeSixty()
    {
        Assert.Fail();
    }
    
    [TestMethod]
    [TestCategory("Domain")]
    public void GivenADiscountOfTenTheOrderValueShouldBeFifty()
    {
        Assert.Fail();
    }
        
    [TestMethod]
    [TestCategory("Domain")]
    public void GivenADeliveryChargeOfTenTheOrderValueShouldBSixty()
    {
        Assert.Fail();
    }
        
    [TestMethod]
    [TestCategory("Domain")]
    public void GivenAnOrderWithoutACustomerItMustBeInvalid()
    {
        Assert.Fail();
    }
}