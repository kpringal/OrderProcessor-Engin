using Order.ProcessingEngin.Common;
using Order.ProcessingEngin.RuleCommands.Interfaces;
using System;

namespace Order.ProcessingEngin.RuleCommands
{
    public class ActivateMembershipRule : IRuleCommand 
    {
        public RuleCommandEnum RuleCommand { get; }

        public ActivateMembershipRule()
        {
            RuleCommand = RuleCommandEnum.ActivateMembership;
        }

        public bool Execute()
        {
            Console.WriteLine($"Started executing Rule {RuleCommand}");
            Console.WriteLine($"Rule {RuleCommand} executed successfully");
            return true;
        }
    }
}
