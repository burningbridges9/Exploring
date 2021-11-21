namespace Sort
{
    public class QuickSort : AbsSort
    {
        public override int[] Sort()
        {
            return (Sorted = Sort(Unsorted, 0, Unsorted.Length - 1));
        }

        private int[] Sort(int[] array, int minIndex, int maxIndex)
        {
            if (minIndex >= maxIndex)
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
            PrintArray(array, min, max);
            int pivot = min - 1;// for this moment we dont know this, set as min -1

            for (int i = min; i <= max; i++)
            {
                if (array[i] < array[max])
                {
                    pivot++;
                    Swap(ref array[pivot], ref array[i]);
                    PrintArray(array, min, max);
                }
            }

            pivot++;
            Swap(ref array[pivot], ref array[max]);
            PrintArray(array, min, max);
            return pivot;
        }
    }
}
