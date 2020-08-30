using Microsoft.VisualStudio.TestTools.UnitTesting;
using Order.ProcessingEngin.Common;
using Order.ProcessingEngin.Factories;
using Order.ProcessingEngin.Factories.Interfaces;
using Order.ProcessingEngin.RuleCommands.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order.ProcessingEngin.Tests.RuleCommandTests
{
    [TestClass]
    public class RuleCommandFactoryTests
    {
        [DataTestMethod]
        [DataRow(RuleCommandEnum.ActivateMembership)]
        [DataRow(RuleCommandEnum.AddFirsAidVideo)]
        [DataRow(RuleCommandEnum.GenerateCommisionPayment)]
        [DataRow(RuleCommandEnum.GenerateDuplicatePackingSlip)]
        [DataRow(RuleCommandEnum.GeneratePackingSlip)]
        [DataRow(RuleCommandEnum.SendMail)]
        [DataRow(RuleCommandEnum.UpgradeMembership)]
        public void Test_RuleCommandsFactory(RuleCommandEnum ruleEnum)
        {
            // Prepare
            var rcf = new RuleCommandFacotry();

            // Run
            var rc = rcf.GetRuleCommands(ruleEnum);

            // Assert
            Assert.IsNotNull(rcf);
            Assert.IsNotNull(rc);
            Assert.IsInstanceOfType(rcf, typeof(IRuleCommandFacotry));
            Assert.IsInstanceOfType(rc, typeof(IRuleCommand));
        }
    }
}
