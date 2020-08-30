using Order.ProcessingEngin.Common;
using Order.ProcessingEngin.Factories.Interfaces;
using Order.ProcessingEngin.RuleCommands;
using Order.ProcessingEngin.RuleCommands.Interfaces;
using System;

namespace Order.ProcessingEngin.Factories
{
    public class RuleCommandFacotry : IRuleCommandFacotry  
    {
        public IRuleCommand GetRuleCommands(RuleCommandEnum ruleCommand)
        {
            switch (ruleCommand)
            {
                case RuleCommandEnum.GeneratePackingSlip:
                    return new PackingSlipRule();

                case RuleCommandEnum.GenerateDuplicatePackingSlip:
                    return new DuplicatePackingSlip();

                case RuleCommandEnum.ActivateMembership:
                    return new ActivateMembershipRule();

                case RuleCommandEnum.UpgradeMembership:
                    return new UpgradeMembershipRule();

                case RuleCommandEnum.SendMail:
                    return new SendMailRule();

                case RuleCommandEnum.AddFirsAidVideo:
                    return new AddFirsAidVideoRule();

                case RuleCommandEnum.GenerateCommisionPayment:
                    return new CommisionPaymentRule();

                default:
                    Console.WriteLine("Unhandeled command");
                    return null;
            }
        }
    }
}
