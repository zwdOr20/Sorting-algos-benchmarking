namespace Algorithms
{
    /// <summary>
    /// Merge sort algorithm class
    /// </summary>
    public class MergeSortStrategy : ISortStrategy
    {

        /// <inheritdoc></inheritdoc>
        public void Sort(int[] array)
        {
            if (array == null || array.Length < 2) return;
            Sort(array, 0, array.Length - 1); 
        }
        /// <summary>
        /// Sort part of the array
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="array"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        private int[] Sort(int[] array,int start, int end)
        {
            if (array == null || start < 0 || end > array.Length)
                throw new ArgumentNullException();

            else
            {
                if (start < end)
                {
                    int half = start + (end- start)/2; 
                    Sort(array, start, half);
                    Sort(array , half+1, end);
                    // merge sorted halves
                    Merge(array, half, start, end);
                }

                return array;
            }

        }
        /// <summary>
        /// Merge two array halves
        /// </summary>
        /// <param name="array"></param>
        /// <param name="half"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        private void Merge(int[] array, int half, int start, int end)
        {
            int sizeArrayOne = half - start + 1;
            int sizeArrayTwo = end - half;
            int[] firstHalf = new int[sizeArrayOne];
            int[] secondHalf = new int[sizeArrayTwo];

            for (int i = 0; i < sizeArrayOne; i++)
            {
                firstHalf[i] = array[start+i];
            }

            for (int i = 0; i < sizeArrayTwo; i++)
            {
                secondHalf[i] = array[half+1+i];
            }

            int index1=0, index2 =0, k=start;
            

            while (index1<sizeArrayOne && index2<sizeArrayTwo)
            {
                if(firstHalf[index1]>secondHalf[index2])
                {
                    array[k] = secondHalf[index2];
                    index2++;
                }
                else
                {
                    array[k] = firstHalf[index1];
                    index1++;
                }

                k++;
            }

            // Copy remaining elements
            while (index1 < sizeArrayOne)
            {
                array[k] = firstHalf[index1];
                index1++;
                k++;
            }

            // Copy remaining elements
            while (index2 < sizeArrayTwo)
            {
                array[k] = secondHalf[index2];
                index2++;
                k++;
            }


        }
    }
}