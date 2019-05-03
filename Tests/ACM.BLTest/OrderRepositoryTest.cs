using System;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest
{
    [TestClass]
    public class OrderRepositoryTest
    {
        [TestMethod]
        public void RetrieveOrderDisplayTest()
        {
            //-- Arrange
            var orderRepository = new OrderRepository();
            var expected = new Order(10)
            {
                OrderDate = new DateTimeOffset(DateTime.Now.Year, 4, 14, 10, 00, 00, new TimeSpan(7, 0, 0))
            };

            //-- Act
            var actual = orderRepository.Retrieve(10);

            //-- Assert
            Assert.AreEqual(expected.OrderDate, actual.OrderDate);
        }

        [TestMethod]
        public void SaveOrderUpdates()
        {
            //-- Arrange
            var orderRepository = new OrderRepository();
            var updateOrder = new Order(10)
            {
                OrderDate = new DateTimeOffset(DateTime.Now.Year, 5, 3, 10, 00, 00, new TimeSpan(7, 0, 0)),
                HasChanges = true
            };

            //-- Act
            var actual = orderRepository.Save(updateOrder);

            //-- Assert
            Assert.AreEqual(true, actual);
        }
    }
}
