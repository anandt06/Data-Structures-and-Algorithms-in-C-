using System;

namespace DSA.DataStructures.LinkedList.SingleLinkedList
{
    public class StackNode
    {
        public StackNode(int data)
        {
            Data = data;
        }

        public int Data { get; set; }

        public StackNode Next { get; set; }
    }

    internal class StackUsingLinkedList
    {
        public StackNode head;

        public void Push(int data)
        {
            StackNode newNode = new StackNode(data);

            if (head == null)
            {
                head = newNode;
            }
            else
            {
                StackNode temp = head;
                head = newNode;
                newNode.Next = temp;
            }
            Console.WriteLine(data + " pushed to stack");
        }

        public int Pop()
        {
            int popped = int.MinValue;
            if (head == null)
            {
                Console.WriteLine("Stack is Empty");
            }
            else
            {
                popped = head.Data;
                head = head.Next;
            }
            return popped;
        }

        public int Peek()
        {
            if (head == null)
            {
                Console.WriteLine("Stack is empty");
                return int.MinValue;
            }
            else
            {
                return head.Data;
            }
        }
    }

    class StackUsingLinkedListProgram
    {
        static void Main(string[] args)
        {
            StackUsingLinkedList sll = new StackUsingLinkedList();

            sll.Push(10);
            sll.Push(20);
            sll.Push(30);

            Console.WriteLine(sll.Pop() + " popped from stack");

            Console.WriteLine("Top element is " + sll.Peek());
        }
    }
}
