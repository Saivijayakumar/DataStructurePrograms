using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructurePrograms
{
    class BST
    {
        public static void ReadInputForBST()
        {
            //(2n)! / ((n + 1)! * n!) 
            Console.WriteLine("Enter a number 1-10 : ");
            long n = Convert.ToInt32( Console.ReadLine());
            long  num1 = factorial(2 * n);
            long num2 = factorial(n + 1);
            long num3 = factorial(n);
            long result = num1 / (num2 * num3);
            Console.WriteLine(result);

        }
        public static long factorial(long n)
        {
            long res = 1;
            for (int i = 1; i <= n; ++i)
            {
                res *= i;
            }

            return res;
        }

    }
}
