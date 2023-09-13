using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithmsTests
{
    public class QuickSortingStrategyTest
    {
        private ISortStrategy _strategy;

        public QuickSortingStrategyTest()
        {
            _strategy = new QuickSortStrategy();
        }

        [Fact]
        public void test_quick_sort_strategy_if_array_contains_duplicate_values()
        {
            // arrange
            ISortStrategy strategy = new QuickSortStrategy();
            var context = new ArraySorter(_strategy);

            var array = new int[] { 3, 10, 2, 5, 10, 1, 6, 5, 9, 0, 22,9 };

            // act
            context.Sort(array);
            var expected = new int[] { 0, 1, 2, 3, 5, 5, 6, 9, 9,10, 10, 22 };
            // assert
            Assert.Equal(expected, array);
        }
        [Fact]
        public void test_quick_sort_strategy_if_array_contains_negative_values()
        {
            // arrange
            ISortStrategy strategy = new QuickSortStrategy();
            var context = new ArraySorter(_strategy);

            var array = new int[] { -1,3, 10, 2, 5,-12, 10, 1, 6, 5, 9, 0, 22, 9 };

            // act
            context.Sort(array);
            var expected = new int[] { -12,-1,0, 1, 2, 3, 5, 5, 6, 9, 9, 10, 10, 22 };
            // assert
            Assert.Equal(expected, array);
        }

    }
}
