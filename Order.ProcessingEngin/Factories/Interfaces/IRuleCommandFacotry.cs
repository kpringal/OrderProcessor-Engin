using Order.ProcessingEngin.Common;
using Order.ProcessingEngin.RuleCommands.Interfaces;

namespace Order.ProcessingEngin.Factories.Interfaces
{
    public interface IRuleCommandFacotry
    {
        IRuleCommand GetRuleCommands(RuleCommandEnum ruleCommand); 
    }
}
