namespace DSA.SortingAlgos
{
    /// <summary>
    /// Selection sort is a simple and efficient sorting algorithm that works by repeatedly selecting the smallest (or largest) 
    /// element from the unsorted portion of the list and moving it to the sorted portion of the list. 
    /// Selection Sort has a time complexity of O ( n^2 ) in all cases (best, average, worst)
    /// </summary>
    internal class SelectionSort
    {
        static void Main(string[] args)
        {
            int[] arr = { 64, 25, 12, 22, 11 };
            int minELement = arr[0];
            int temp = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                temp = arr[i];

                for (int j = i; j < arr.Length; j++)
                {
                    if (arr[j] < minELement)
                    {
                        minELement = arr[i];
                    }
                }

            }

        }
    }

}
