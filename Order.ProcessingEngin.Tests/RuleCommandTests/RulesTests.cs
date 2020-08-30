using Microsoft.VisualStudio.TestTools.UnitTesting;
using Order.ProcessingEngin.Common;
using Order.ProcessingEngin.RuleCommands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order.ProcessingEngin.Tests.RuleCommandTests
{
    [TestClass]
    public class ActivateMembershipRuleTests
    {
        [TestMethod]
        public void Test_ActivateMembershipRule()
        {
            // Arrange 
            var temp = new ActivateMembershipRule();

            // Run
            var result = temp.Execute();

            // Asser
            Assert.IsNotNull(temp);
            Assert.IsTrue(result);
            Assert.AreEqual(RuleCommandEnum.ActivateMembership, temp.RuleCommand);
        }
    }


    [TestClass]
    public class AddFirsAidVideoRuleTests
    {
        [TestMethod]
        public void Test_AddFirsAidVideoRule()
        {
            // Arrange 
            var temp = new AddFirsAidVideoRule();

            // Run
            var result = temp.Execute();

            // Asser
            Assert.IsNotNull(temp);
            Assert.IsTrue(result);
            Assert.AreEqual(RuleCommandEnum.AddFirsAidVideo, temp.RuleCommand);
        }
    }


    [TestClass]
    public class CommisionPaymentRuleTests
    {
        [TestMethod]
        public void Test_CommisionPaymentRule()
        {
            // Arrange 
            var temp = new CommisionPaymentRule();

            // Run
            var result = temp.Execute();

            // Asser
            Assert.IsNotNull(temp);
            Assert.IsTrue(result);
            Assert.AreEqual(RuleCommandEnum.GenerateCommisionPayment, temp.RuleCommand);
        }
    }


    [TestClass]
    public class DuplicatePackingSlipTests
    {
        [TestMethod]
        public void Test_DuplicatePackingSlip()
        {
            // Arrange 
            var temp = new DuplicatePackingSlip();

            // Run
            var result = temp.Execute();

            // Asser
            Assert.IsNotNull(temp);
            Assert.IsTrue(result);
            Assert.AreEqual(RuleCommandEnum.GenerateDuplicatePackingSlip, temp.RuleCommand);
        }
    }


    [TestClass]
    public class PackingSlipRuleTests
    {
        [TestMethod]
        public void Test_PackingSlipRule()
        {
            // Arrange 
            var temp = new PackingSlipRule();

            // Run
            var result = temp.Execute();

            // Asser
            Assert.IsNotNull(temp);
            Assert.IsTrue(result);
            Assert.AreEqual(RuleCommandEnum.GeneratePackingSlip, temp.RuleCommand);
        }
    }

    [TestClass]
    public class SendMailRuleTests
    {
        [TestMethod]
        public void Test_SendMailRule()
        {
            // Arrange 
            var temp = new SendMailRule();

            // Run
            var result = temp.Execute();

            // Asser
            Assert.IsNotNull(temp);
            Assert.IsTrue(result);
            Assert.AreEqual(RuleCommandEnum.SendMail, temp.RuleCommand);
        }
    }

    [TestClass]
    public class UpgradeMembershipRuleTests
    {
        [TestMethod]
        public void Test_UpgradeMembershipRule()
        {
            // Arrange 
            var temp = new UpgradeMembershipRule();

            // Run
            var result = temp.Execute();

            // Asser
            Assert.IsNotNull(temp);
            Assert.IsTrue(result);
            Assert.AreEqual(RuleCommandEnum.UpgradeMembership, temp.RuleCommand);
        }
    }
}
