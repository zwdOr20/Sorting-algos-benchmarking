namespace SortingAlgorithmsTests
{
    public class ArraySorterTest
    {
        [Fact]
        public void If_Array_is_null_do_nothing()
        {
            // arrange
            int[] array = null;
            ArraySorter context = new ArraySorter(null);
            // act
            context.Sort(array);
           
            // assert
            Assert.Null(array);
        }
        [Theory]
        [InlineData(new int[] {1})]
        [InlineData(new int[] {})]
        public void If_Array_Empty_or_has_one_element_do_nothing(int[] array)
        {
            // arrange
            ArraySorter context = new ArraySorter(null);
            // act
            context.Sort(array);
            var expected = new int[array.Length];
            array.CopyTo(expected, 0);
            // assert
            Assert.Equal(array, expected);
        }

        [Fact]
        public void If_Strategy_Not_Set_Throw_Argument_Null_Exception()
        {
            // arrange
            ArraySorter context = new ArraySorter(null);
            // act
            Action acion = () => context.Sort(new int[] { 1,2,0});
            // assert
            Assert.Throws<NullReferenceException>(acion);
        }
    }
}