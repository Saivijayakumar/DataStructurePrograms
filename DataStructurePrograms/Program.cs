using System;

namespace DataStructurePrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------->Data Structure Programs<------------------");
            Console.WriteLine("1.Unordered List\n2.Order List\n3.Balanced Parentheses");
            Console.WriteLine("-----------------------------------");
            Console.Write("Enter your choice :");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    UnorderdList.Unordered();
                    break;
                case 2:
                    OrderedList.Ordered();
                    break;
                case 3:
                    ParenthesChecker.ReadInput();
                    /*char[] expression = "[(5+6)∗7+8)/(4+3)(5+6)∗(7+8)/(4+3)]".ToCharArray();
                    ParenthesChecker parenthes = new ParenthesChecker();
                    bool result = parenthes.Isbalanced(expression);
                    if (result)
                    {
                        Console.WriteLine("Parantheses Balanced");
                    }
                    else
                    {
                        Console.WriteLine("Parantheses not Balanced");
                    }*/
                    break;
                default:
                    Console.WriteLine("Enter valid input");
                    break;

            }
            Console.Read();
        }
    }
}