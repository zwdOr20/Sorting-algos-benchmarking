namespace SortingAlgorithmsTests
{
    public class HelperSortingTest
    {
        [Fact]
        public void test_Swap_method_throw_out_of_range_exception_if_index_greater_thanthe_array_size()
        {
            // arrange
            var array = new int[] { 1, 2 };
            // act
            Action action = () => SortingHelper.Swap(array, 0,3);
            //asset
            Assert.Throws<IndexOutOfRangeException>(() => action());
        }
        [Fact]
        public void test_Swap_method_throw_Null_Exception_if_array_is_null()
        {
            // act
            Action action = () => SortingHelper.Swap(null, 0, 3);
            //asset
            Assert.Throws<NullReferenceException>(() => action());
        }
        [Fact]
        public void test_Swap_method_swap_two_elements()
        {
            var array = new int[] { 1, 2 };
            // act
            SortingHelper.Swap(array, 0, 1);
            //asset
            Assert.Equal(2, array[0]);
            Assert.Equal(1, array[1]);
        }
    }
}
