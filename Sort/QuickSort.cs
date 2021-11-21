using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    public class QuickSort
    {
        int[] unsorted = { 4, 5, 1, 5, 6, 7, 1, 3, 2, 9, 2, 6, 3 };
        public int[] Unsorted => unsorted;

        public int[] Sorted { get; private set; }
        public void PrintSorted() => PrintSubArray(Sorted, 0, Sorted.Length - 1);

        public int[] Sort()
        {
            return (Sorted = Sort(unsorted, 0, unsorted.Length - 1));
        }

        public int[] Sort(int[] array, int minIndex, int maxIndex)
        {
            if (minIndex>=maxIndex)
            {
                return array;
            }


            int pivotIndex = GetPivotIndex(array, minIndex, maxIndex);
            Sort(array, minIndex, pivotIndex - 1);
            Sort(array, pivotIndex + 1, maxIndex);

            return array;
        }

        public int GetPivotIndex(int[] array, int min, int max)
        {
            PrintSubArray(array, min, max);
            int pivot = min - 1;// for this moment we dont know this, set as min -1

            for (int i = min; i <= max; i++)
            {
                if (array[i]<array[max])
                {
                    pivot++;
                    Swap(ref array[pivot], ref array[i]);
                    PrintSubArray(array, min, max);
                }
            }

            pivot++;
            Swap(ref array[pivot], ref array[max]);
            PrintSubArray(array, min, max);
            return pivot;
        }

        private void Swap(ref int v1, ref int v2)
        {
            var tmp = v1;
            v1 = v2;
            v2 = tmp;
        }

        public void PrintSubArray(int[] a, int min, int max) => Console.WriteLine($"{string.Join(",", a.Skip(min).Take(max+1).ToArray())}");
    }
}
