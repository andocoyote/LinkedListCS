using AndoInterfaces;
using System;

namespace AndoDoubleLinkedList
{
    internal class DNode
    {
        internal int Data;
        internal DNode Prev;
        internal DNode Next;

        public DNode(int data)
        {
            Data = data;
            Prev = null;
            Next = null;
        }
    }

    internal class DoubleLinkedList: AndoList
    {
        private DNode head = null;

        public void InsertFront(int data)
        {
            DNode newdnode = new DNode(data);

            // Make the new node link to the thing head is pointing to
            // If head isn't pointing to anything, dnode.Next will point to null
            newdnode.Next = head;
            newdnode.Prev = null;

            // If head is pointing to something, point it's backpointer to the new node
            // instead of to head.  Now, we've placed the new node at the front of the list
            if (head != null)
            {
                head.Prev = newdnode;
            }

            // Finally, point head to the new node we just added
            head = newdnode;
        }

        public void InsertEnd(int data)
        {
            DNode newnode = new DNode(data);

            // Start at the beginning of the list
            DNode lastNode = head;

            // Find the last node in the list
            while (lastNode.Next != null)
            {
                lastNode = lastNode.Next;
            }

            // Append the new node to the last node
            lastNode.Next = newnode;
            newnode.Prev = lastNode;
            newnode.Next = null;
        }

        public void PrintList()
        {
            DNode curNode = head;

            while (curNode != null)
            {
                Console.WriteLine(curNode.Data);
                curNode = curNode.Next;
            }
        }
    }
}