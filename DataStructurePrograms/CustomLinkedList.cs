using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructurePrograms
{
    public class CustomLinkedList<T>
    {
        public Node<T> head;

        public bool Search(T val)
        {
            Node<T> temp = this.head;
            while (temp != null)
            {
                if (temp.data.Equals(val))
                {
                    Console.WriteLine($"\n{val} is present in list ");
                    return true;
                }
                temp = temp.next;
            }
            return false;
        }
        public void InsertFront(T new_data)
        {
            Node<T> newNode = new Node<T>(new_data);
            newNode.next = this.head;
            this.head = newNode;
            //Console.WriteLine("Inserted the list in front " + newNode.data);
        }
        public void Display()
        {
            Node<T> temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Linked List is Empty");
                return;
            }
            else
            {
                while (temp != null)
                {
                    Console.Write(" " + temp.data + " ");
                    temp = temp.next;
                }
            }
        }
        public void Sort(T data)
        {
            Node<T> newNode = new Node<T>(data);
            Node<T> temp = head;
            if (head == null || newNode.idata <= head.idata)
            {
                newNode.next = head;
                head = newNode;
            }
            else if (head.next == null && head.idata < newNode.idata)
            {
                head.next = newNode;
            }
            else
            {
                if (temp.next.idata > newNode.idata)
                {
                    newNode.next = temp.next;
                    temp.next = newNode;
                }
                else
                {
                    while (temp.next != null && temp.next.idata < newNode.idata)
                    {
                        temp = temp.next;
                    }
                    newNode.next = temp.next;
                    temp.next = newNode;
                }
            }
        }
        public bool DeleteElement(T data)
        {
            Node<T> current = head;
            Node<T> previous = head;
            if(current.data.Equals(data))
            {
                head.data = head.next.data;
                head.next = head.next.next;
                Console.WriteLine($"{data} element deleted from the list");
                return true;
            }
            else
            {
                current = current.next;
            }
            while(!current.data.Equals(data))
            {
                if(current.next==null)
                {
                    break;
                }
                previous = current;
                current = current.next;
            }
            if(current.data.Equals(data))
            {
                previous.next = current.next;
                Console.WriteLine($"{data} element deleted from the list");
                return true;
            }
            else
            {
                Console.WriteLine("Element not found");
                return false;
            }

        }
        public string ReturnString()
        {
            string strText = "";
            Node<T> cur = head;
            if (head != null)
            {
                strText += cur.data;
                cur = cur.next;
                while (cur != null)
                {
                    strText = strText + " " + cur.data;
                    cur = cur.next;

                }
                return strText;
            }
            else
            {
                Console.WriteLine("Empty!!!");
                return default;
            }
        }
    }
}