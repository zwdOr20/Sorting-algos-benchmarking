using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    /// <summary>
    /// Array Sorter class
    /// </summary>
    public class ArraySorter
    {
        private ISortStrategy _sortingStrategy;

        public ArraySorter(ISortStrategy sortingStrategy)
        {
            _sortingStrategy = sortingStrategy;
        }

        /// <summary>
        /// change sorting strategy
        /// </summary>
        /// <param name="sortingStrategy"></param>
        /// <returns></returns>
        public ArraySorter SetStrategy(ISortStrategy sortingStrategy)
        {
            this._sortingStrategy = sortingStrategy;
            return this;
        }
        /// <summary>
        /// sort array based on the setted strategy
        /// </summary>
        /// <param name="array"></param>
        public void Sort(int[] array)
        {
            if (array == null || array.Length < 2) return;
            _sortingStrategy.Sort(array);
        }
    }
}
