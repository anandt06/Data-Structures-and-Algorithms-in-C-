using System;

namespace DSA.SearchingAlgos
{
    internal class LinearSearch
    {
        static void Main(string[] args)
        {
            LinearSearchUsingForEach(4);

            LinearSearchUsingFor(5);
        }

        static void LinearSearchUsingForEach(int number)
        {
            int[] arr = { 1, 2, 3, 4, 5 };

            foreach (int num in arr)
            {
                if (num == number)
                {
                    Console.WriteLine("Element Found");
                }
            }
        }

        static void LinearSearchUsingFor(int number)
        {
            int[] arr = { 1, 2, 3, 4, 5 };

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == number)
                {
                    Console.WriteLine("Element Found");
                }
            }
        }
    }
}
