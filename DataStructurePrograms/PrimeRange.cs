using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructurePrograms
{
    class PrimeRange
    {
         public static int[,] array = new int[500, 1];
        public static void MainPrimeMethod()
        {
            Prime(array);
            Display(array);
        }
        public static void Prime(int[,] array)
        {

            int row = 0;
            int count = 1;
            int flag = 1;
            int start = 0;
            int end = 1000;
            if (start == 0)
            {
                start = 2;
            }
            if (start == 2)
            {
                Console.Write(start + " ");
            }
            //Make sure the process starts with even number
            if (start % 2 == 0)
            {
                start++;
            }
            //checking only odd 
            for (int i = start; i <= end; i = i + 2)
            {
                flag = 1;
                // WE TRAVERSE TILL SQUARE ROOT OF j only.
                // (LARGEST POSSIBLE VALUE OF A PRIME FACTOR)
                for (int j = 2; j * j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        flag = 0;
                        break;
                    }
                }
                if (flag == 1)
                {
                    //Console.Write(i + " ");
                    array[row, 0] = ++count;
                    array[++row, 1] = i;
                }
            }
        }
        public static void Display(int[,] array)
        {
            foreach(int i in array)
            {
                Console.Write(i + " ");
            }
        }

    }
}
