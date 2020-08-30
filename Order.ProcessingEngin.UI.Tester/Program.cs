using Order.ProcessingEngin.Common;
using Order.ProcessingEngin.Factories;
using Order.ProcessingEngin.Factories.Interfaces;
using Order.ProcessingEngin.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order.ProcessingEngin.UI
{
    class Program
    {
        static void Main(string[] args)
        {
        TOP:
            Console.Clear();
            var orderEnum = GetOrderneedToBeproccessed();

            if (orderEnum.HasValue)
            {
                Console.WriteLine();
                Console.WriteLine();
                IRuleCommandFacotry rcf = new RuleCommandFacotry();
                OrderProcessor op = new OrderProcessor(orderEnum.Value, rcf, true);
                op.RunCommands();

                Console.WriteLine();
                Console.WriteLine("Press C to Continue processing order.");
                var temp = Console.ReadLine();
                if (temp.ToLower().Equals("c"))
                    goto TOP;
            }
            else
            {
                Console.WriteLine("Invalid orderEnum value, press R to try again");
                var temp = Console.ReadLine();
                if (temp.ToLower().Equals("r"))
                    goto TOP;
            }
        }


        private static OrderEnum? GetOrderneedToBeproccessed()
        {
            Console.WriteLine("Select order to be proccessed");

            Console.WriteLine($"Press 1 for {OrderEnum.Book} order");
            Console.WriteLine($"Press 2 for {OrderEnum.LearningToSki} order");
            Console.WriteLine($"Press 3 for {OrderEnum.MemberShip} order");
            Console.WriteLine($"Press 4 for {OrderEnum.PhysicalProduct} order");
            Console.WriteLine($"Press 5 for {OrderEnum.UpgradeMemberShip} order");

            string temp = Console.ReadLine();
            int input = 0;
            OrderEnum? orderEnum = null;

            if (!int.TryParse(temp, out input))
            {
                Console.WriteLine("Invalid user input, press R to try again");
                temp = Console.ReadLine();
                if (temp.ToLower().Equals("r"))
                    return GetOrderneedToBeproccessed();
                else
                    return null;
            }

            if (input <= 0 && input > 5)
            {
                Console.WriteLine("Invalid user input, press R to try again");
                temp = Console.ReadLine();
                if (temp.ToLower().Equals("r"))
                    return GetOrderneedToBeproccessed();
                else
                    return null;
            }

            if (input == 1)
                orderEnum = OrderEnum.Book;
            else if (input == 2)
                orderEnum = OrderEnum.LearningToSki;
            else if (input == 3)
                orderEnum = OrderEnum.MemberShip;
            else if (input == 4)
                orderEnum = OrderEnum.PhysicalProduct;
            else if (input == 5)
                orderEnum = OrderEnum.UpgradeMemberShip;

            return orderEnum;
        }
    }
}
