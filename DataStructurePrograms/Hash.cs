using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructurePrograms
{
    class Hash
    {
        public static int size;
        public static void HashList()
        {
            size = 11;
            string textFile = File.ReadAllText(@"C:\Users\SaiVijay\source\repos\DataStructurePrograms\HashValues.txt");
            string[] input = textFile.Split(' ');
            HashSlot<int> hashSlot = new HashSlot<int>(size);
            for (int i = 0; i < input.Length; i++)
            {
                hashSlot.Add(Convert.ToInt32(input[i]));
            }
            hashSlot.Display();
            Console.WriteLine("\nEnter a number which you want to search");
            int searchNum = Convert.ToInt32(Console.ReadLine());
            if (hashSlot.Search(searchNum) == 1)
            {
                Console.WriteLine("Element is present ");
            }
            else
            {
                hashSlot.Add(searchNum);
            }

            File.WriteAllText(@"C:\Users\SaiVijay\source\repos\DataStructurePrograms\HashValues.txt", hashSlot.Display());
        }
    }
}
