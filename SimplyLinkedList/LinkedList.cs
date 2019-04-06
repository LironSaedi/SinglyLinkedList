using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplyLinkedList
{
    public class LinkedList<T>
    {
        internal class Node
        {
            public T Value;
            public Node Next;

            public Node(T value)
            {
                Value = value;
            }

            public Node(T value, Node next)
            {
                Value = value;
                Next = next;
            }
        }

        int Count = 0;
        Node Head;

        void AddFirst(T value)
        {

            if (Head == null)
            {
                new Node(value);
            }
            T swapValue = Head.Value;


        }


    }
}
