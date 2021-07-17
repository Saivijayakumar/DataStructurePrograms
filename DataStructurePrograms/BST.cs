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
            Console.WriteLine("Enter a number : ");
            long number = Convert.ToInt32( Console.ReadLine());
            //This code works for parentheses like if you give number it give posible parentheses.
            int[] catalan = new int[number + 1];
            catalan[0] = catalan[1] = 1;
            for (int i = 2; i <= number; i++)
            {
                catalan[i] = 0;
                for (int j = 0; j < i; j++)
                {
                    catalan[i] += catalan[j] * catalan[i - j - 1];
                }
            }
            double power = Math.Pow(10, 8) + 7;
            Console.WriteLine(Math.Abs(catalan[number] % power));
        }
    }
}
