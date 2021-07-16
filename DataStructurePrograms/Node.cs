using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructurePrograms
{
    public class Node<T>
    {
        public T data;
        public int idata;
        public Node<T> next;
        public Node(T data)
        {
            this.data = data;
            next = null;
        }
    }
}