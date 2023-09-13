using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    /// <summary>
    /// Bubble sort strategy
    /// </summary>
    public class BubbleSortStrategy : ISortStrategy
    {
        /// <inheritdoc></inheritdoc>
        public void Sort(int[] array)
        {
            if(array == null || array.Length < 2) return;
            bool notSorted = true;

            while (notSorted)
            {
                notSorted = false;
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if( array[i] > array[i + 1])
                    {
                        (array[i], array[i + 1]) = (array[i + 1], array[i]);
                        notSorted = true;
                    }
                }
            }
        }
    }
}
