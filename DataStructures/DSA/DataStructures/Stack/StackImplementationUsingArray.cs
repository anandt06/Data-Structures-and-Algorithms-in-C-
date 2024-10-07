using System;

namespace DSA.DataStructures.Stack
{
    class Stack
    {
        int top = -1;
        static readonly int MAX = 20;
        int[] StackCollection = new int[MAX];
        public void Push(int item)
        {
            if (top >= MAX)
            {
                Console.WriteLine("Stack overflow");
            }
            else
            {
                StackCollection[++top] = item;
            }
        }

        public void PrintStack()
        {
            foreach (var item in StackCollection)
            {
                Console.WriteLine(item);
            }
        }

        public int Pop()
        {
            if (top < 0)
            {
                Console.WriteLine("Stack underflow");
                return 0;
            }
            else
            {
                int value = StackCollection[top--];
                return value;
            }
        }

        public void Peek()
        {
            if (top < 0)
            {
                Console.WriteLine("Stack underflow");
            }
            else
            {
                Console.WriteLine("The topmost element of Stack is : {0}", StackCollection[top]);
            }
        }

        bool IsEmpty()
        {
            return (top < 0);
        }


        static void Main(string[] args)
        {
            Stack myStack = new Stack();

            myStack.Push(10);
            myStack.Push(20);
            myStack.Push(30);
            myStack.Push(40);
            myStack.PrintStack();
            myStack.Peek();
            Console.WriteLine("Item popped from Stack : {0}", myStack.Pop());
            myStack.PrintStack();
            Console.ReadLine();
        }
    }
}

