using System;

namespace DSA.DataStructures.Queue
{
    internal class QueueUsingArray
    {
        public int[] arr;
        int enqueueIndex;
        int dequeueIndex;
        int max;

        public QueueUsingArray(int size)
        {
            max = size;
            arr = new int[size];
            enqueueIndex = -1;
            dequeueIndex = -1;
        }

        public void Enqueue(int key)
        {
            if (enqueueIndex < max - 1)
            {
                arr[++enqueueIndex] = key;
            }
            else
            {
                Console.WriteLine("Queue overflow");
            }
        }

        public int Dequeue()
        {
            if (arr.Length > 0 && dequeueIndex < max - 1)
                return arr[++dequeueIndex];
            else
                Console.WriteLine("Queue Empty");
            return 0;
        }
    }

    public class QueueUsingArrayProgram
    {
        static void Main(string[] args)
        {
            QueueUsingArray queueUsingArray = new QueueUsingArray(4);
            queueUsingArray.Enqueue(1);
            queueUsingArray.Enqueue(2);
            queueUsingArray.Enqueue(3);
            queueUsingArray.Enqueue(4);
            queueUsingArray.Enqueue(5);
            var dequeuedKey1 = queueUsingArray.Dequeue();
            RemoveElementFromArray(queueUsingArray, dequeuedKey1);
            //var dequeuedKey2 = queueUsingArray.Dequeue();
            //var dequeuedKey3 = queueUsingArray.Dequeue();
            //var dequeuedKey4 = queueUsingArray.Dequeue();
            //var dequeuedKey5 = queueUsingArray.Dequeue();
            Console.WriteLine();

        }

        private static void RemoveElementFromArray(QueueUsingArray queueUsingArray, int dequeuedKey)
        {
            //var index = Array.IndexOf(queueUsingArray.arr, dequeuedKey);
            //for (int i = index; i < queueUsingArray.arr.Length - 1; i++)
            //{
            //    queueUsingArray.arr[i] = queueUsingArray.arr[i + 1];
            //}
        }
    }
}

//int i = 0;
//int pos;
//int[] arr = new int[5] { 35, 50, 55, 77, 98 };

//Console.WriteLine("Elements before deletion:");
//for (i = 0; i < 5; i++)
//{
//    Console.WriteLine("Element[" + (i) + "]: " + arr[i]);
//}

//// Let's say the position to delete the item is 2 i.e. arr[1]
//pos = 2;

//// Shifting elements
//for (i = pos - 1; i < 4; i++)
//{
//    arr[i] = arr[i + 1];
//}

//Console.WriteLine("Elements after deletion: ");
//for (i = 0; i < 4; i++)
//{
//    Console.WriteLine("Element[" + (i + 1) + "]: " + arr[i]);
//}
