using Order.ProcessingEngin.Common;
using Order.ProcessingEngin.RuleCommands.Interfaces;
using System;

namespace Order.ProcessingEngin.RuleCommands
{
    public class AddFirsAidVideoRule : IRuleCommand 
    {
        public RuleCommandEnum RuleCommand { get; }

        public AddFirsAidVideoRule()
        {
            RuleCommand = RuleCommandEnum.AddFirsAidVideo;
        }

        public bool Execute()
        {
            Console.WriteLine($"Started executing Rule {RuleCommand}");
            Console.WriteLine($"Rule {RuleCommand} executed successfully");
            return true;
        }
    }
}
