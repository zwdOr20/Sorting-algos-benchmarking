using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class HeapSortStrategy : ISortStrategy
    {
        //<inheritdoc></inheritdoc>
        public void Sort(int[] array)
        {
            if (array == null || array.Length < 2) return;

            int size = array.Length;
            for (int i = (size / 2) - 1; i >= 0; i--)
            {
                MaxHeapify(array, size, i);
            }

            for (int i = size - 1; i > 0; i--)
            {
                SortingHelper.Swap(array, 0, i);
                MaxHeapify(array, i - 1, 0);
            }
        }
        /// <summary>
        /// Heapify the array index node and subnodes
        /// </summary>
        /// <param name="array"></param>
        /// <param name="size"></param>
        /// <param name="index"></param>
        public void MaxHeapify(int[] array, int size, int index)
        {
            int largest = index;
            int left = index * 2 + 1;
            int right = index * 2 + 2;

            if (left < size && array[largest] < array[left])
            {
                largest = left;
            }
            if (right < size && array[largest] < array[right])
            {
                largest = right;
            }

            if (index != largest)
            {
                SortingHelper.Swap(array, largest, index);
                MaxHeapify(array, size, largest);

            }
        }
    }
}
