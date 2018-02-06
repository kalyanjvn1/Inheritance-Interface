using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Inheritance.cs
{
    [TestClass]
    public class TestInheritance
    {
        //METHODNAME_CONDITION_EXPECTATION
        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Process_OrderIsAlreadyShipped_ThrowsAnException()
        {
            var orderProcedssor = new OrderProcessor(new FakeShippingCalculator());
            var order = new Order
            {
                Shipment = new Shipment()
            };

            orderProcedssor.Process(order);
        }

        [TestMethod]
        public void Process_OrderIsNotShipped_ShouldSetTheShipmentPropertyOfTheOrder()
        {
            //Arrange
            const double expectedShippingCost = 1;
            DateTime expectedShippedDate = DateTime.Now.AddDays(1);

            var orderProcedssor = new OrderProcessor(new FakeShippingCalculator());
            var order = new Order() {TotalPrice = 20};
            
            //Act
            orderProcedssor.Process(order);
            
            //Assert
            Assert.IsTrue(order.IsShipped);
            Assert.AreEqual(expectedShippingCost, order.Shipment.Cost,"Shipping cost did not matched");
            Assert.AreEqual(expectedShippedDate.Date, order.Shipment.ShippingDate.Date, "Shipping Date is not matched");
        }
    }

    public class FakeShippingCalculator : IShippingCalculator
    {
        public double CalculateShipping(Order order)
        {
            return 1;
        }
    }
}
