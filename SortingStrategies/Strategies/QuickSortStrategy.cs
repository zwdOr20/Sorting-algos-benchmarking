namespace Algorithms
{
    /// <summary>
    /// Quick sort algorithm class
    /// </summary>
    public class QuickSortStrategy : ISortStrategy
    {
        /// <inheritdoc></inheritdoc>
        private void Sort(int start, int end, int[] array)
        {
            if (array == null || array.Length < 2) return;
            else
            {
                if(start < end)
                {
                    var pivot = Partition(start, end, array);
                    Sort(start, pivot - 1, array);
                    Sort(pivot+1, end, array);
                }
            }
        }

        /// <summary>
        /// Partitioning array into two elements around the pivot 
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="array"> Size must be greater than 1</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public int Partition(int start, int end, int[] array)
        {
            if (array == null || array.Length < 2 || start < 0 || end > array.Length-1)
                throw new ArgumentException();
          
            int pivot = start - 1;
            for (int i = start; i< end; i++)
            {
                int current = array[i];
                if(current < array[end])
                {
                    pivot++;
                    SortingHelper.Swap(array, i, pivot);
                }    
            }

            SortingHelper.Swap(array, pivot + 1, end);
            return pivot+1;
        }
        
        /// <summary>
        /// Sort part of the array
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public void Sort(int[] array)
        {
            if (array == null || array.Length < 2) return;
            Sort(0, array.Length-1, array);
        }
    }
}