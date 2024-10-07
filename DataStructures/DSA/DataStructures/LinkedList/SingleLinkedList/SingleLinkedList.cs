using System;

namespace DSA.DataStructures.LinkedList.SingleLinkedList
{
    public class Node
    {
        public Node Next;
        public int Key;
    }

    public class SingleLinkedList
    {
        private Node head;

        private Node tail;

        public void PrintAllNodes()
        {
            Node current = head;
            while (current != null)
            {
                Console.WriteLine(current.Key);
                current = current.Next;
            }
        }

        public void PrintAllNodesUsingRecursion(Node node)
        {
            Console.WriteLine(node.Key);
            PrintAllNodesUsingRecursion(node.Next);
        }

        public void PushFront(int data)
        {
            Node node = new Node();
            node.Key = data;
            node.Next = head;

            head = node;

            //This condition ensures the first added element is added as tail
            if (tail == null)
                tail = head;
        }

        public void PushLast(int data)
        {
            Node node = new Node();
            node.Key = data;

            if (head == null)
            {
                head = node;
                head.Next = null;
            }
            else
            {
                var current = head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = node;
                tail = node;
            }
        }

        public void PopFront()
        {
            if (head == null)
            {
                Console.WriteLine("Empty List");
            }
            else
            {
                head = head.Next;

                //if after pop operatiom if there are no elements then head is null in that case tail also will be null
                if (head == null)
                {
                    tail = null;
                }
            }
        }

        public void PopBack()
        {
            if (head == null)
                Console.WriteLine("Empty List");
            if (head == tail)
                head = tail = null;
            else
            {
                var current = head;
                while (current.Next.Next != null)
                {
                    current = current.Next;
                }
                current.Next = null;
                tail = current;
                tail.Next = null;
            }
        }

        public bool Find(int key)
        {
            Node current = head;

            while (current.Next != null)
            {
                if (current.Key == key)
                {
                    return true;
                }
                else
                {
                    current = current.Next;
                }
            }
            return false;
        }

        public void AddAfter(Node node, Node newNode)
        {
            var current = head;
            while (current != null)
            {
                if (current.Key == node.Key)
                {
                    var tempNext = current.Next;
                    newNode.Next = tempNext;
                    current.Next = newNode;

                    // Update the tail if the new node is added at the end
                    if (tempNext == null)
                    {
                        tail = newNode;
                    }
                    return;
                }
                current = current.Next;
            }
        }
    }

    class LinkedListProgram
    {
        static void Main(string[] args)
        {
            SingleLinkedList myList = new SingleLinkedList();

            myList.PushFront(3);
            myList.PushFront(2);
            myList.PushFront(1);
            myList.PushLast(4);
            myList.PushLast(5);
            //myList.PopFront();


            Node node = new Node();
            node.Key = 4;

            Node newNode = new Node();
            newNode.Key = 13;

            myList.AddAfter(node, newNode);

            myList.PopBack();

            //var exists = myList.Find(2);

            //Node node1 = new Node();
            //node1.Key = 14;
            //myList.AddAfter(node1, 4);

            myList.PrintAllNodes();

            //Console.ReadLine();

            var s1 = new Student();
            s1.Name="A";

            var s3= new Student();
            s3.Name="v";

            var s2 = s1;
            s2.Name="B";


        }

        
    }

    class Student
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
