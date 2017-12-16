using System;
using System.Collections.Generic;

namespace linked_list
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Linked list");

            LinkedList<string> newList = new LinkedList<string>();
            newList.AddFirst("bartek");
            newList.AddFirst("damian");
            newList.AddFirst("asia");

            Console.WriteLine("All names from initialization state");
            foreach(var name in newList)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("Remove name female asia");
            LinkedListNode<string> nodeToRemove = newList.Find("asia");
            newList.Remove(nodeToRemove);

            Console.WriteLine("All names from after removing node: " + nodeToRemove.Value);
            foreach (var name in newList)
            {
                Console.WriteLine(name);
            }

        }
    }
}
