using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructurePrograms
{
    class Palindrome
    {
        public static string input;
        public static void IsPalindrome()
        {
            CustomLinkedList<char> linkedList = new CustomLinkedList<char>();
            Console.Write("Enter the string to be checked:");
            input = Console.ReadLine();
            for (int i = 0; i < input.Length; i++)
            {
                linkedList.Enqueue(input[i]);
            }
            string reverseWord = linkedList.DequeuePalindromeChecker();
            if (input.Equals(reverseWord))
            {
                Console.WriteLine("\n{0} is a Palindrome!", input);
            }
            else
            {
                Console.WriteLine("\n{0} is not a Palindrome!", input);

            }
        }
    }
}
