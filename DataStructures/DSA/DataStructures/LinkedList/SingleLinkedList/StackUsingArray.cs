// Stack Implementation using Array

using System;

namespace DSA.DataStructures.LinkedList.SingleLinkedList
{
    class StackUsingArray
    {
        private int[] arr;
        private int top;
        private int max;
        public StackUsingArray(int size)
        {
            arr = new int[size]; // Maximum size of Stack
            top = -1;
            max = size;
        }

        public void Push(int item)
        {
            if (top >= max - 1)
            {
                Console.WriteLine("Stack Overflow");
                return;
            }
            else
            {
                arr[++top] = item;
            }
        }

        public int Pop()
        {
            if (top == -1)
            {
                Console.WriteLine("Stack is Empty");
                return -1;
            }
            else
            {
                Console.WriteLine("{0} popped from stack ", arr[top]);
                return arr[top--];
            }
        }

        public int Peek()
        {
            if (top == -1)
            {
                Console.WriteLine("Stack is Empty");
                return -1;
            }
            else
            {
                Console.WriteLine("{0} popped from stack ", arr[top]);
                return arr[top];
            }
        }

        public void PrintStack()
        {
            if (top == -1)
            {
                Console.WriteLine("Stack is Empty");
                return;
            }
            else
            {
                for (int i = 0; i <= top; i++)
                {
                    Console.WriteLine("{0} pushed into stack", arr[i]);
                }
            }
        }
    }


    class StackUsingArrayProgram
    {
        static void Main()
        {
            StackUsingArray p = new StackUsingArray(5);

            p.Push(10);
            p.Push(20);
            p.Push(30);
            p.PrintStack();
            p.Pop();
        }
    }
}
