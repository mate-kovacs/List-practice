using System;

namespace LinkedList
{
    public class CustomList
    {

        public Node Head { get; set; }
        public Node Tail { get; set; }

        public CustomList()
        {
            Head = null;
            Tail = null;
        }

        public void Add(Node node)
        {
            if ((Head == null) && (Tail == null))
            {
                Head = node;
                Tail = node;
            } else
            {
                Tail.Next = node;
                Tail = node;
            }
        }

        public void Remove(int value)
        {
            if (Head.Value == value)
            {
                Head = Head.Next;
                return;
            }
            Node current = Head;
            Node previous = null;
            while (current.Value != value)
            {
                previous = current;
                current = current.Next;
            }
            previous.Next = current.Next;
        }

        public int Get(int index)
        {
            Node current = Head;
            for (var i = 0; i <index; i ++)
            {
                current = current.Next;
            }
            return current.Value;
        }

        public void Insert(Node node, int index)
        {
            if (index == 0)
            {
                node.Next = Head;
                Head = node;
            } else
            {
                Node previous = null;
                Node current = Head;
                for (var i = 0; i < index; i ++)
                {
                    if (current.Next == null)
                    {
                        Add(node);
                        return;
                    }
                    previous = current;
                    current = current.Next;
                }
                node.Next = current;
                previous.Next = node;
            }
        }

        public void PrintList()
        {
            Node current = Head;
            while (current != null)
            {
                Console.WriteLine(current.Value);
                current = current.Next;
            }
        }

    }
}
