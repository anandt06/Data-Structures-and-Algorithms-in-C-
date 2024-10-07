namespace DSA.SortingAlgos
{
    internal class InsertionSort
    {
        static void Main(string[] args)
        {
            InsertionSortUsingAlgo();
        }

        private static void InsertionSortUsingAlgo()
        {
            int[] arr = new int[] { 9, 5, 1, 4, 3 };

            int temp = 0;

            for (int i = 1; i < arr.Length; i++)
            {
                temp = arr[i];

                int j = i;
                while (j > 0 && temp < arr[j - 1])
                {
                    arr[j] = arr[j - 1];
                    j--;
                }
                arr[j] = temp;
            }
        }

        //private static void InsertionSortUsingFor()
        //{
        //    int[] arr = new int[] { 9, 5, 1, 4, 3 };

        //    int key = 0;
        //    int temp = 0;

        //    for (int i = 0; i < arr.Length - 1; i++)
        //    {
        //        key = arr[i + 1];

        //        for (int j = i; j >= 0; j--)
        //        {
        //            if (arr[j + 1] < arr[j])
        //            {
        //                temp = arr[j];
        //                arr[j] = arr[j + 1];
        //                arr[j + 1] = temp;
        //            }
        //        }
        //    }
        //}
    }
}
