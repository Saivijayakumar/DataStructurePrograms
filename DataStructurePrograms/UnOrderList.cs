using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DataStructurePrograms
{
    public class UnorderdList
    {
        public static void Unordered()
        {
            string text = File.ReadAllText(@"C:\Users\SaiVijay\source\repos\DataStructurePrograms\DataStructurePrograms\unorder.txt");
            string[] textArray = text.Split( ' ', (char)StringSplitOptions.RemoveEmptyEntries);
            CustomLinkedList<string> list = new CustomLinkedList<string>();
            for (int i = textArray.Length - 1; i >= 0; i--)
            {
                list.InsertFront(textArray[i]);
            }
            Console.WriteLine("----------Before Modifying------------");
            list.Display();
            Console.WriteLine();
            Console.WriteLine("\nEnter a string you want to search");
            string searchStr = Console.ReadLine();
            if (list.Search(searchStr))
            {
                list.DeleteElement(searchStr);
            }
            else
            {
                list.InsertFront(searchStr);
            }
            string textFile = list.ReturnString();
            File.WriteAllText(@"C:\Users\SaiVijay\source\repos\DataStructurePrograms\DataStructurePrograms\unorder.txt", textFile);
            Console.WriteLine("----------After Modifying------------");
            list.Display();
        }
    }
}