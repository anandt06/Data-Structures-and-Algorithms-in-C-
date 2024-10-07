using System;

namespace DSA.SearchingAlgos
{
    internal class BinarySearch
    {
        static void Main(string[] args)
        {
            BinarySearchOperation(5);

            Console.WriteLine(BinarySearchAlgorithm(5));

        }

        private static int BinarySearchAlgorithm(int key)
        {
            int[] arr = { 0, 1, 3, 4, 5, 6, 7, 8 };
            int low = 0;
            int high = arr.Length - 1;

            while (low <= high)
            {
                int mid = (low + high) / 2;

                if (key == arr[mid])
                {
                    return mid;
                }
                else if (key > arr[mid])
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }
            }

            return -1;
        }

        private static void BinarySearchOperation(int number)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7 };

            int low = 0;
            int high = arr.Length;
            int mid = (low + arr.Length) / 2;
            if (number > high || number < arr[0])
            {
                Console.WriteLine("Element not found");
                return;
            }
            FindWhichSideOfMidToSearchFor(number, arr, low, high, mid);
        }

        private static void FindWhichSideOfMidToSearchFor(int number, int[] arr, int low, int high, int mid)
        {
            if (number == arr[mid])
            {
                Console.WriteLine("Number Found at {0} position", mid);
            }
            else if (number > arr[mid])
            {
                low = mid + 1;
                CalculateLMH(ref low, ref mid, ref high);
                FindWhichSideOfMidToSearchFor(number, arr, low, high, mid);
            }
            else
            {
                high = mid - 1;
                CalculateLMH(ref low, ref mid, ref high);
                FindWhichSideOfMidToSearchFor(number, arr, low, high, mid);
            }
        }

        private static void CalculateLMH(ref int low, ref int mid, ref int high)
        {
            mid = (low + high) / 2;
        }
    }
}
