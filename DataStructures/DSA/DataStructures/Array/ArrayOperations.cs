using System;

namespace DSA.DataStructures.Array
{
    public class ArrayOperations
    {
        private readonly int[] arr;

        /// <summary>
        //size epresents the current number of elements in the array.
        //It is used to keep track of how many elements have been added to the array and
        //helps determine where new elements can be added or existing elements can be removed.
        /// </summary>
        private int size;

        private readonly int capacity;

        public ArrayOperations(int capacity)
        {
            this.capacity = capacity;
            this.arr = new int[capacity];
            this.size = 0;
        }

        // Function to add an element at the end (default case)
        public void AddAtEnd(int value)
        {
            if (size >= capacity)
            {
                Console.WriteLine("Array is full. Cannot add value.");
                return;
            }

            arr[size] = value;
            size++;
        }

        // Function to add an element at a specific position
        public void AddAtPosition(int value, int position)
        {
            if (size >= capacity)
            {
                Console.WriteLine("Array is full. Cannot add value.");
                return;
            }

            if (position < 0 || position > size)
            {
                Console.WriteLine("Invalid position.");
                return;
            }

            // Shift elements to the right to create space
            for (int i = size; i > position; i--)
            {
                arr[i] = arr[i - 1];
            }

            arr[position] = value;
            size++;
        }

        // Function to delete an element from the end (default case)
        public void DeleteFromEnd()
        {
            if (size == 0)
            {
                Console.WriteLine("Array is empty. Cannot delete value.");
                return;
            }

            size--;
        }

        // Function to delete an element from a specific position
        public void DeleteFromPosition(int position)
        {
            if (size == 0)
            {
                Console.WriteLine("Array is empty. Cannot delete value.");
                return;
            }

            if (position < 0 || position >= size)
            {
                Console.WriteLine("Invalid position.");
                return;
            }

            // Shift elements to the left to fill the gap
            for (int i = position; i < size - 1; i++)
            {
                arr[i] = arr[i + 1];
            }

            size--;
        }

        // Function to display the elements of the array
        public void Display()
        {
            if (size == 0)
            {
                Console.WriteLine("Array is empty.");
                return;
            }

            Console.Write("Array elements: ");
            for (int i = 0; i < size; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }

        public int LinearSearch(int value)
        {
            for (int i = 0; i < size; i++)
            {
                if (arr[i] == value)
                {
                    return i; // Return the index where the value is found
                }
            }
            return -1; // Return -1 if the value is not found
        }

        public int FindMax()
        {
            if (size == 0)
            {
                Console.WriteLine("Array is empty.");
                return int.MinValue; // Return minimum integer value if array is empty
            }

            int max = arr[0];
            for (int i = 1; i < size; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            return max;
        }

        public void ReverseArray()
        {
            int start = 0;
            int end = size - 1;

            while (start < end)
            {
                // Swap elements
                int temp = arr[start];
                arr[start] = arr[end];
                arr[end] = temp;

                start++;
                end--;
            }
        }

        public static int[] MergeArrays(int[] arr1, int size1, int[] arr2, int size2)
        {
            int[] mergedArray = new int[size1 + size2];
            int index = 0;

            for (int i = 0; i < size1; i++)
            {
                mergedArray[index++] = arr1[i];
            }

            for (int j = 0; j < size2; j++)
            {
                mergedArray[index++] = arr2[j];
            }

            return mergedArray;
        }



        public void UpdateAtPosition(int position, int newValue)
        {
            if (position < 0 || position >= size)
            {
                Console.WriteLine("Invalid position.");
                return;
            }

            arr[position] = newValue;
        }

    }

    public static class ArrayProgram
    {
        public static void Main()
        {
            ArrayOperations arrayOps = new ArrayOperations(10);

            arrayOps.AddAtEnd(5);
            arrayOps.AddAtEnd(10);
            arrayOps.AddAtEnd(15);
            arrayOps.Display(); // Output: Array elements: 5 10 15 

            arrayOps.AddAtPosition(20, 1);
            arrayOps.Display(); // Output: Array elements: 5 20 10 15 


            // Search for an element
            int searchIndex = arrayOps.LinearSearch(10);
            Console.WriteLine("Element 10 found at index: " + searchIndex); // Output: Element 10 found at index: 2

            // Update an element at a specific position
            arrayOps.UpdateAtPosition(2, 25);
            arrayOps.Display(); // Output: Array elements: 5 20 25 15

            // Find the maximum element in the array
            int maxElement = arrayOps.FindMax();
            Console.WriteLine("Maximum element in the array: " + maxElement); // Output: Maximum element in the array: 25

            // Reverse the array
            arrayOps.ReverseArray();
            arrayOps.Display(); // Output: Array elements: 15 25 20 5

            // Delete an element from the end
            arrayOps.DeleteFromEnd();
            arrayOps.Display(); // Output: Array elements: 15 25 20

            // Delete an element from a specific position
            arrayOps.DeleteFromPosition(1);
            arrayOps.Display(); // Output: Array elements: 15 20
        }
    }
}

