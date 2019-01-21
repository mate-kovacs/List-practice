using System;
using LinkedList;

namespace ListTester
{
    class Program
    {
        static void Main(string[] args)
        {
            Node node1 = new Node(1);
            Node node2 = new Node(2);
            Node node3 = new Node(3);
            Node node4 = new Node(4);
            Node node5 = new Node(5);
            Node node6 = new Node(6);
            Node node7 = new Node(7);
            Node node8 = new Node(8);
            Node node9 = new Node(9);

            CustomList list = new CustomList();
            list.Add(node1);
            list.Add(node2);
            list.Add(node3);
            list.PrintList();
            Console.WriteLine("\n");
            Console.WriteLine(list.Get(1));
        }
    }
}
