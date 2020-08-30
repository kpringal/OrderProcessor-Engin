using Order.ProcessingEngin.Common;
using Order.ProcessingEngin.RuleCommands.Interfaces;
using System;

namespace Order.ProcessingEngin.RuleCommands
{
    public class CommisionPaymentRule : IRuleCommand 
    {
        public RuleCommandEnum RuleCommand { get; }

        public CommisionPaymentRule()
        {
            RuleCommand = RuleCommandEnum.GenerateCommisionPayment;
        }

        public bool Execute()
        {
            Console.WriteLine($"Started executing Rule {RuleCommand}");
            Console.WriteLine($"Rule {RuleCommand} executed successfully");
            return true;
        }
    }
}
