using System;
using System.Collections.Generic;

namespace DSA.SortingAlgos
{
    /// <summary>
    /// Bubble sort, sometimes referred to as sinking sort, is a simple sorting algorithm that repeatedly steps through the input list element by element, 
    /// comparing the current element with the one after it, swapping their values if needed
    /// Best complexity: n    Worst-case complexity: n^2
    /// </summary>
    internal class BubbleSort
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 1, 5, 2, 4, 10, 7 };
            for (int i = 0; i < list.Count - 1; i++)
            {
                for (int j = 0; j < list.Count - i - 1; j++)
                {
                    if (list[j] > list[j + 1])
                    {
                        int temp = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine(list);
        }
    }
}
