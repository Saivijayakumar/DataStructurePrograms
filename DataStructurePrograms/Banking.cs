using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructurePrograms
{
    class Banking
    {
        public int bankBal = 100;
        public void ReadInputForQueue()
        {
            Console.WriteLine("Enter the number of persons in Queue");
            int persons = Convert.ToInt32(Console.ReadLine());
            CustomLinkedList<int> list = new CustomLinkedList<int>();
            for (int i = 1; i <= persons; i++)
            {
                Console.WriteLine("-------------------");
                Console.WriteLine("Person {0} ", i);
                Console.WriteLine("-------------------");
                list.Enqueue(i);
                WithdrawalAndDeposit();
                list.Dequeue();
            }
            Console.WriteLine($"\nThe Remaining Balence is {bankBal}");
        }
        public void WithdrawalAndDeposit()
        {
            string flag = "Y";
            while (flag.ToUpper() == "Y")
            {
                Console.WriteLine($"\nThe Balence is {bankBal}");
                Console.WriteLine("1.Do you want to Withdraw cash\n2.Do you want to Deposit Cash\n3.Do you want to Exit");
                Console.WriteLine("Enter the option");
                int num = Convert.ToInt32(Console.ReadLine());
                switch (num)
                {
                    case 1:
                        Console.WriteLine("Enter amount to withdraw");
                        int withdrawalAmount = Convert.ToInt32(Console.ReadLine());
                        if (bankBal > withdrawalAmount)
                        {
                            bankBal = bankBal - withdrawalAmount;
                        }
                        else
                        {
                            Console.WriteLine("InSufficient Funds!!!");
                        }
                        break;
                    case 2:
                        Console.WriteLine("Enter amount to deposit");
                        int amountDeposit = Convert.ToInt32(Console.ReadLine());
                        bankBal = bankBal + amountDeposit;
                        break;
                    case 3:
                        break;
                    default:
                        Console.WriteLine("Wrong Option!");
                        break;
                }
                Console.WriteLine("\nDo you want to continue?(Y/N)");
                flag = Console.ReadLine();
            }

        }
    }
}
