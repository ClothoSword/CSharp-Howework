using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNamespace
{
    public class MyLinkList
    {
        public class Node
        {
            public Node(int v)
            {
                value = v;
            }
            public int value;
            public Node next;
        }

        public MyLinkList(params int[] values)
        {
            Node temp = null;
            for (int i = 0; i < values.Length; i++)
            {
                if (i == 0)
                {
                    head = new Node(values[0]);
                    temp = head;
                    continue;
                }

                Node n = new Node(values[i]);
                temp.next = n;
                temp = n;
            }
            temp.next = null;
        }

        public Node Find(int value)
        {
            Node temp = head;
            while (temp != null)
            {
                if (temp.value == value)
                {
                    return temp;
                }
                temp = temp.next;
            }
            Console.WriteLine("Can't find this value");
            return null;
        }

        public void Insert(Node node, int value)
        {
            Node temp = new Node(value);
            Node tempNext = node.next;
            node.next = temp;
            temp.next = tempNext;
        }

        public void Erase(int value)
        {
            Node temp = head;
            Node prevNode = head;
            while (temp != null)
            {
                if (temp == head)
                {
                    if (temp.value == value)
                    {
                        head = temp.next;
                        temp = head;
                        prevNode = head;
                    }
                    prevNode = temp;
                    temp = temp.next;
                    continue;
                }
                if (temp.value == value)
                {
                    prevNode.next = temp.next;
                    temp = prevNode.next;
                    continue;
                }
                prevNode = temp;
                temp = temp.next;
            }
        }

        public void Print()
        {
            //1->2->3...
            Node temp = head;
            string s = "";
            while (temp != null)
            {
                if (temp.next != null)
                    s += (temp.value + "->");
                else
                    s += temp.value;
                temp = temp.next;
            }
            Console.WriteLine(s);
        }

        public void Reverse()
        {
            var current = head;
            Node prev = null;
            while (current != null)
            {
                var next = current.next;
                current.next = prev;
                prev = current;
                current = next;
            }
            head = prev;
        }

        public int Size
        {
            get
            {
                Node temp = head;
                int count = 0;
                while (temp != null)
                {
                    count++;
                    temp = temp.next;
                }
                return count;
            }
        }

        private Node head = null;

    }
}
