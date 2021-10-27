using AndoInterfaces;
using System;

namespace AndoLinkedList
{
    internal class Node
    {
        internal int Data;
        internal Node Next;

        public Node(int data)
        {
            Data = data;
            Next = null;
        }
    }

    internal class LinkedList: AndoList
    {
        private Node head = null;

        public void InsertFront(int data)
        {
            Node newnode = new Node(data);

            // Make the new node link to the thing head is pointing to
            // If head isn't pointing to anything, dnode.Next will point to null
            newnode.Next = head;

            // Finally, point head to the new node we just added
            head = newnode;
        }

        public void InsertEnd(int data)
        {
            Node newnode = new Node(data);

            // Start at the beginning of the list
            Node lastNode = head;

            // Find the last node in the list
            while (lastNode.Next != null)
            {
                lastNode = lastNode.Next;
            }

            // Append the new node to the last node
            lastNode.Next = newnode;
            newnode.Next = null;
        }

        public void PrintList()
        {
            Node curNode = head;

            while (curNode != null)
            {
                Console.WriteLine(curNode.Data);
                curNode = curNode.Next;
            }
        }
    }
}