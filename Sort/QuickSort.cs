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
            int pivotIndex = min;
            int pivotValue = array[max];

            for (int i = min; i < max; i++)
            {
                if (array[i] <= pivotValue)
                {
                    Swap(ref array[pivotIndex], ref array[i]); // swap left with current
                    PrintArray(array, min, max);
                    pivotIndex++; // move pointer to the right
                }
            }

            Swap(ref array[pivotIndex], ref array[max]); // move pivot to right position
            PrintArray(array, min, max);
            return pivotIndex;
        }
    }
}
