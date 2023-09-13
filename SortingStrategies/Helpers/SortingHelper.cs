namespace Algorithms
{
    public static class SortingHelper
    {
        /// <summary>
        /// Swap element of the array in the index i and j 
        /// </summary>
        /// <param name="array"></param>
        /// <param name="i"></param>
        /// <param name="j"></param>
        public static void Swap(int[] array, int i, int j)
        {
            (array[i], array[j]) = (array[j], array[i]);
        }
    }
}
