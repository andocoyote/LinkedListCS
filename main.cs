using AndoDoubleLinkedList;
using AndoLinkedList;
using AndoInterfaces;
using System;

// https://www.c-sharpcorner.com/article/linked-list-implementation-in-c-sharp/

namespace AndoLists
{
    class Program
    {
        static void Main(string[] args)
        {
            int selection = -1;
            int number = 0;
            string data = null;
            AndoList mylist = null;

            Console.WriteLine("1. Create a linked list");
            Console.WriteLine("2. Create a double linked list");
            Console.Write("Enter your selection: ");

            string listtype = Console.ReadLine();

            if (!int.TryParse(listtype, out number))
            {
                Console.WriteLine($"Invalid entry: {listtype}");
                return;
            }
            else
            {
                switch (number)
                {
                    case 1:
                        Console.WriteLine("Creating your new Linked List ...");
                        mylist = new AndoLinkedList.LinkedList();
                        break;
                    case 2:
                        Console.WriteLine("Creating your new Double Linked List ...");
                        mylist = new AndoDoubleLinkedList.DoubleLinkedList();
                        break;
                    default:
                        break;
                }
            }

            while (selection != 0)
            {
                selection = Menu();

                switch (selection)
                {
                    case 1:
                        Console.Write("Enter the data you want to insert: ");
                        data = Console.ReadLine();

                        if (!int.TryParse(data, out number))
                        {
                            Console.WriteLine($"Invalid entry: {data}");
                        }
                        else
                        {
                            mylist.InsertFront(number);
                        }

                        break;
                    case 2:
                        Console.Write("Enter the data you want to insert: ");
                        data = Console.ReadLine();

                        if (!int.TryParse(data, out number))
                        {
                            Console.WriteLine($"Invalid entry: {data}");
                        }
                        else
                        {
                            mylist.InsertEnd(number);
                        }
                        break;
                    case 3:
                        Console.WriteLine($"You selected {selection}");
                        break;
                    case 4:
                        mylist.PrintList();
                        break;
                    default:
                        break;
                }
            }
        }

        static int Menu()
        {
            Console.WriteLine("1. Insert data at the front of the list");
            Console.WriteLine("2. Insert data at the end of the list");
            Console.WriteLine("3. Remove data from the list");
            Console.WriteLine("4. Display the list");
            Console.WriteLine("0. Exit");
            Console.Write("Enter your selection: ");

            string selection = Console.ReadLine();

            if (!int.TryParse(selection, out int number))
            {
                Console.WriteLine($"Invalid entry: {selection}");
            }

            return number;
        }
    }
}