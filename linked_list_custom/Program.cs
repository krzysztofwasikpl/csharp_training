using System;

namespace linked_list
{
    /*
     * SinglyLinkedList is basic custom implementation of LinkedList<> 
     * from Alghoritms library
     */
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var myList = new SinglyLinkedList();
            myList.insertFirst(100);
            myList.insertFirst(200);
            myList.insertFirst(300);
            myList.insertFirst(400);
            myList.displayNodes();

            var deletedNode = myList.deleteFirst();
            Console.Write("Deleted node: ");
            deletedNode.displayNode();

            myList.insertLast(1);
            myList.displayNodes();


        }
    }

    public class SinglyLinkedList
    {
        private Node first;

        public bool isEmpty()
        {
            return (first == null);
        }

        public void insertFirst(int data)
        {
            Node newNode = new Node();
            newNode.data = data;
            newNode.next = first;
            first = newNode;
        }

        public Node deleteFirst()
        { 
            Node temp = first;
            first = first.next;

            return temp;
        }

        public void insertLast(int data)
        {
            Node current = first;
            while (current.next != null)
            {
                current = current.next;
            }

            Node newNode = new Node();
            newNode.data = data;
            current.next = newNode;

        }

        public void displayNodes()
        {
            Console.WriteLine("List (first) -- (last)");
            Node current = first;

            while (current != null)
            {
                current.displayNode();
                current = current.next;
            }

        }
    }

    public class Node
    {
        public int data;
        public Node next;

        public void displayNode()
        {
            Console.WriteLine("<" + data + ">");
        }
    }
}
