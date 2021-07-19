using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructurePrograms
{
    class HashSlot<T>
    {
        //Instance Variable
        public int size = 11;
        public LinkedList<T>[] item;
        //Parameterized constructure
        public HashSlot(int size)
        {
            this.size = size;
            this.item = new LinkedList<T>[11];
        }
        //Adding elements to list
        public void Add(T value)
        {
            int pos = GetArrayPosition(value);
            LinkedList<T> list = GetLinkedList(pos);
            list.AddLast(value);
        }
        //Geting Hash code for given value
        public int GetArrayPosition(T key)
        {
            size = 11;
            int hashcode = key.GetHashCode();
            int position = hashcode % size;
            return Math.Abs(position);
        }
        //Creating linked list for given position
        protected LinkedList<T> GetLinkedList(int position)
        {
            LinkedList<T> linkedList = item[position];
            if (linkedList == null)
            {
                linkedList = new LinkedList<T>();
                item[position] = linkedList;
            }
            return linkedList;
        }
        //Display the total list 
        public string Display()
        {
            string result = "";
            int count = 1;
            for (int i = 0; i < size; i++)
            {
                LinkedList<T> linkedList = item[i];
                if (linkedList == null)
                {
                    continue;
                }
                foreach (T value in linkedList)
                {
                    Console.WriteLine("Element {0} of Hash Table is: {1}", count, value);
                    result = value.ToString() + " " + result;
                    count++;
                }
            }
            return result;
        }
        //Serch for a perticular value in hash list 
        public int Search(T value)
        {
            int position = GetArrayPosition(value);
            LinkedList<T> linkedList = GetLinkedList(position);
            if (linkedList == null)
            {
                return -1;
            }
            else
            {
                int flag = 0;
                foreach (T i in linkedList)
                {
                    if (i.Equals(value))
                    {
                        flag = 1;

                    }
                }
                return flag;
            }
        }
    }
}
