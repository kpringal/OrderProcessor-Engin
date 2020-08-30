using Order.ProcessingEngin.Common;

namespace Order.ProcessingEngin.RuleCommands.Interfaces
{
    public interface IRuleCommand
    {
        RuleCommandEnum RuleCommand { get; } 

        bool Execute();
    }
}
