namespace Sort
{
    class MergeSort : AbsSort
    {
        public override int[] Sort()
        {
            Sorted = Unsorted;
            Sort(Sorted);
            return Sorted;
        }

        private void Sort(int[] array)
        {
            if (array.Length == 1)
                return;

            int mid = array.Length / 2;
            int[] l = new int[mid]; // linq take/skip?
            int[] r = new int[array.Length - mid];

            for (int i = 0; i < mid; i++)
            {
                l[i] = array[i];
            }

            for (int i = 0; i < array.Length - mid; i++)
            {
                r[i] = array[mid + i];
            }

            Sort(l);
            Sort(r);
            Merge(array, l, r);
        }

        private void Merge(int[] target, int[] l, int[] r)
        {
            int minLeftIndex = 0, minRightIndex = 0, targetMinIndex = 0;
            while (minLeftIndex < l.Length && minRightIndex < r.Length) // merge as far as one of arrays is not empty
            {
                if (l[minLeftIndex] <= r[minRightIndex])
                {
                    target[targetMinIndex] = l[minLeftIndex];
                    minLeftIndex++;
                }
                else if (l[minLeftIndex] > r[minRightIndex])
                {
                    target[targetMinIndex] = r[minRightIndex];
                    minRightIndex++;
                }
                targetMinIndex++;
            }
            while (minLeftIndex < l.Length) // merge the left ones
            {
                target[targetMinIndex] = l[minLeftIndex];
                minLeftIndex++;
                targetMinIndex++;
            }
            while (minRightIndex < r.Length) // merge the right ones
            {
                target[targetMinIndex] = r[minRightIndex];
                minRightIndex++;
                targetMinIndex++;
            }
        }
    }
}
