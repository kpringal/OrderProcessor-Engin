using Order.ProcessingEngin.Common;
using Order.ProcessingEngin.Factories.Interfaces;
using Order.ProcessingEngin.RuleCommands.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Order.ProcessingEngin.Orders
{
    public class OrderProcessor
    {
        public readonly OrderEnum Order;
        public readonly IRuleCommandFacotry RuleCommandFacotry;
        public readonly bool IsContinueOnFail;
        protected IEnumerable<IRuleCommand> RuleCommands { get; private set; }

        public OrderProcessor(OrderEnum order, IRuleCommandFacotry ruleCommandFacotry, bool isContinueOnFail)
        {
            Order = order;
            RuleCommandFacotry = ruleCommandFacotry;
            IsContinueOnFail = isContinueOnFail;
            Console.WriteLine($"Order processor created for {Order.ToString()}");
        }


        public int RunCommands()
        {
            var RuleCommands = GetRulesCommands().ToArray();
            Console.WriteLine($"Below Rules have been created");
            Console.WriteLine($"{ string.Join("\n", RuleCommands.Select(x => x.RuleCommand))}");
            var commands = RuleCommands.Count();
            var failcommands = 0;
            foreach (IRuleCommand ruleCommand in RuleCommands)
            {
                var result = ruleCommand.Execute();
                failcommands += result ? 0 : 1;
                if (!result && !IsContinueOnFail)
                {
                    Console.WriteLine($"Stop running remaining ruls as IsContinueOnFail: {IsContinueOnFail} and {ruleCommand.RuleCommand} completed with Error");
                    break;
                }
            }
            Console.WriteLine($"{failcommands } failed out of {commands}");
            return failcommands;
        }

        private IEnumerable<IRuleCommand> GetRulesCommands()
        {
            Console.WriteLine($"Creating rules for {Order.ToString()}");

            switch (Order)
            {
                case OrderEnum.PhysicalProduct:
                    yield return RuleCommandFacotry.GetRuleCommands(RuleCommandEnum.GeneratePackingSlip);
                    yield return RuleCommandFacotry.GetRuleCommands(RuleCommandEnum.GenerateCommisionPayment);
                    break;
                case OrderEnum.Book:
                    yield return RuleCommandFacotry.GetRuleCommands(RuleCommandEnum.GenerateDuplicatePackingSlip);
                    yield return RuleCommandFacotry.GetRuleCommands(RuleCommandEnum.GenerateCommisionPayment);
                    break;
                case OrderEnum.MemberShip:
                    yield return RuleCommandFacotry.GetRuleCommands(RuleCommandEnum.ActivateMembership);
                    yield return RuleCommandFacotry.GetRuleCommands(RuleCommandEnum.SendMail);
                    break;
                case OrderEnum.UpgradeMemberShip:
                    yield return RuleCommandFacotry.GetRuleCommands(RuleCommandEnum.UpgradeMembership);
                    yield return RuleCommandFacotry.GetRuleCommands(RuleCommandEnum.SendMail);
                    break;
                case OrderEnum.LearningToSki:
                    yield return RuleCommandFacotry.GetRuleCommands(RuleCommandEnum.AddFirsAidVideo);
                    break;
            }

            Console.WriteLine($"Rules created for {Order.ToString()}");
        }
    }
}
