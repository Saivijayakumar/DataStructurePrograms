using System;

namespace DataStructurePrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------->Data Structure Programs<------------------");
            Console.WriteLine("1.Unordered List\n2.Order List");
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
                default:
                    Console.WriteLine("Enter valid input");
                    break;

            }
            Console.Read();
        }
    }
}