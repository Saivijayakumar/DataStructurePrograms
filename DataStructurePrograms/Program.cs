using System;

namespace DataStructurePrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------->Data Structure Programs<------------------");
            Console.WriteLine("1.Unordered List\n2.Order List\n3.Balanced Parentheses\n4.Finding count of BST\n5.Printing Calender\n6.Prime in Range 0 to 1000");
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
                    break;
                case 4:
                    BST.ReadInputForBST();
                    break;
                case 5:
                    CalenderPrint.PrintCalender();
                    break;
                case 6:
                    PrimeRange.MainPrimeMethod();
                    break;
                default:
                    Console.WriteLine("Enter valid input");
                    break;

            }
            Console.Read();
        }
    }
}