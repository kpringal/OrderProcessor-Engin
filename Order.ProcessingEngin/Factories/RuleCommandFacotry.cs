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
                    return new PackingSlipRule(ruleCommand);

                case RuleCommandEnum.GenerateDuplicatePackingSlip:
                    return new DuplicatePackingSlip(ruleCommand);

                case RuleCommandEnum.ActivateMembership:
                    return new ActivateMembershipRule(ruleCommand);

                case RuleCommandEnum.UpgradeMembership:
                    return new ActivateMembershipRule(ruleCommand);

                case RuleCommandEnum.SendMail:
                    return new ActivateMembershipRule(ruleCommand);

                case RuleCommandEnum.AddFirsAidVideo:
                    return new ActivateMembershipRule(ruleCommand);

                case RuleCommandEnum.GenerateCommisionPayment:
                    return new ActivateMembershipRule(ruleCommand);

                default:
                    Console.WriteLine("Unhandeled command");
                    return null;
            }
        }
    }
}
