using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleApp.Console;

namespace SimpleApp.UnitTests;
[TestClass]
public class OrderProcessorTests
{
    // Test Methods should follow this naming convention
    // METHODNAME_CONDITION_EXPECTATION
    [TestMethod]
    [ExpectedException(typeof(InvalidOperationException))]
    public void Process_OrderIsAlreadyShipped_ThrowException()
    {
        var orderProcessor = new OrderProcessor(new FakeShippingCalculator());
        var order = new Order { Shipment = new()};
        orderProcessor.Process(order);
    }

    [TestMethod]
    public void Process_OrderIsNotShipped_ShouldSetTheShipmentPropertyofTheOrder()
    {
        var orderProcessor = new OrderProcessor(new FakeShippingCalculator());
        var order = new Order();
        orderProcessor.Process(order);
        Assert.IsTrue(order.IsShipped);
        Assert.AreEqual(1, order.Shipment.Cost);
        Assert.AreEqual(DateTime.Today.AddDays(1), order.Shipment.ShippingDate);
    }
}
