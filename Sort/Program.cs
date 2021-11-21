using System;

namespace Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            QSort();
            //MSort();
            Console.ReadKey();
        }

        private static void QSort()
        {
            QuickSort quickSort = new QuickSort();
            quickSort.PrintUnsorted();
            quickSort.Sort();
            quickSort.PrintSorted();
        }

        private static void MSort()
        {
            MergeSort mergeSort = new MergeSort();
            mergeSort.PrintUnsorted();
            mergeSort.Sort();
            mergeSort.PrintSorted();
        }
    }
}
