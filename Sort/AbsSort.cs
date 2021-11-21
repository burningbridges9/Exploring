using System;
using System.Linq;

namespace Sort
{
    public abstract class AbsSort
    {
        int[] unsorted = { 4, 5, 1, 11, 6, 7};

        public int[] Unsorted => unsorted;

        public int[] Sorted { get; protected set; }

        protected void Swap(ref int v1, ref int v2)
        {
            var tmp = v1;
            v1 = v2;
            v2 = tmp;
        }

        public void PrintSorted() => PrintArray(Sorted, 0, Sorted.Length - 1);

        public void PrintUnsorted() => PrintArray(Unsorted, 0, Unsorted.Length - 1);

        protected void PrintArray(int[] a, int min, int max) => Console.WriteLine($"{string.Join(",", a.Skip(min).Take(max + 1).ToArray())}");

        public abstract int[] Sort();
    }
}
