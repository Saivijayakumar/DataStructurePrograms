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
            long en = 2 * n;
            long  num1 = factorial(en);
            long num2 = factorial(en - n);
            long num3 = factorial(n);
            long result1 = num1 / (num2 * num3);
            long result = result1 / (n + 1);
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
