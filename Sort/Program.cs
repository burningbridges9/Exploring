using System;

namespace Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            QuickSort quickSort = new QuickSort();
            quickSort.Sort();
            quickSort.PrintSorted();


            Console.ReadKey();
        }
    }
}
