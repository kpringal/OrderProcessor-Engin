using Order.ProcessingEngin.Common;
using Order.ProcessingEngin.RuleCommands.Interfaces;
using System;

namespace Order.ProcessingEngin.RuleCommands
{
    public class SendMailRule : IRuleCommand 
    {
        public RuleCommandEnum RuleCommand { get; }

        public SendMailRule()
        {
            RuleCommand = RuleCommandEnum.SendMail;
        }

        public bool Execute()
        {
            Console.WriteLine($"Started executing Rule {RuleCommand}");
            Console.WriteLine($"Rule {RuleCommand} executed successfully");
            return true;
        }
    }
}
