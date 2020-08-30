using Microsoft.VisualStudio.TestTools.UnitTesting;
using Order.ProcessingEngin.Common;
using Order.ProcessingEngin.Factories;
using Order.ProcessingEngin.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order.ProcessingEngin.Tests.OrderTests
{
    [TestClass]
    public class OrderProcessorTests
    {
        [DataTestMethod]
        [DataRow(OrderEnum.Book)]
        [DataRow(OrderEnum.LearningToSki)]
        [DataRow(OrderEnum.MemberShip)]
        [DataRow(OrderEnum.PhysicalProduct)]
        [DataRow(OrderEnum.UpgradeMemberShip)]
        public void Test_Orders_Should_Return_True(OrderEnum orderEnum)
        {
            // Prepare
            var op = new OrderProcessor(orderEnum, new RuleCommandFacotry(), true);

            // Run
            var result = op.RunCommands();

            // Assert
            Assert.AreEqual(orderEnum, op.Order);
            Assert.IsTrue(op.IsContinueOnFail);
            Assert.AreEqual(0, result);
            if (orderEnum == OrderEnum.LearningToSki)
                Assert.AreEqual(1, op.RuleCommands.Count());
            else
                Assert.AreEqual(2, op.RuleCommands.Count());
        }


        [TestMethod]
        public void Test_Orders_Should_Throw_Null_Ref_Exception()
        {
            Assert.ThrowsException<NullReferenceException>(() => { new OrderProcessor(OrderEnum.Book, null, true); });
        }
    }
}
