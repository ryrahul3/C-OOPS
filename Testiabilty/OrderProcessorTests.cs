using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using POSInterface;

namespace Testiabilty
{
    [TestClass]
    public class OrderProcessorTests
    {
        //METHODNAME_CONDITION_EXPECTATION
        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Process_OrderAlreadyShipped_ThrowsException()
        {
            var orderProcessor = new OrderProcessor(new FakeShippingCalulator());
            var order = new Order
            {
                Shipment = new Shipment()
            };

            orderProcessor.Process(order);
        }
        [TestMethod]
        public void Process_OrderIsNotShipped_ShouldSetTheShipmentPropertyOfTheOrder()
        {
            var orderProcessor = new OrderProcessor(new FakeShippingCalulator());
            var order = new Order();
            orderProcessor.Process(order);

            Assert.IsTrue(order.IsShiped);
            Assert.AreEqual(1,order.Shipment.Cost);
            Assert.AreEqual(DateTime.Today.AddDays(1),order.Shipment.ShippingDate);

        }
    }

    public class FakeShippingCalulator : IShippingCalculator
    {
        public float CalculateShipping(Order order)
        {
            return 1;
        }
    }
}
