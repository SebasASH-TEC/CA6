using Xunit;
using Algorithms;

namespace CA6.Tests
{
    public class BinarySearchTests
    {
        [Fact]
        public void Search_ReturnsCorrectIndex_WhenElementIsFound()
        {
            int[] sortedArray = { 1, 3, 5, 7, 9, 11 };
            int result = BinarySearch.Search(sortedArray, 7);
            Assert.Equal(3, result);
        }

        [Fact]
        public void Search_ReturnsMinusOne_WhenElementIsNotFound()
        {
            int[] sortedArray = { 2, 4, 6, 8, 10 };
            int result = BinarySearch.Search(sortedArray, 5);
            Assert.Equal(-1, result);
        }

        [Fact]
        public void Search_ReturnsMinusOne_WhenArrayIsEmpty()
        {
            int[] emptyArray = { };
            int result = BinarySearch.Search(emptyArray, 1);
            Assert.Equal(-1, result);
        }

        [Fact]
        public void Search_ReturnsCorrectIndex_WhenElementIsAtBeginning()
        {
            int[] sortedArray = { 1, 2, 3, 4, 5 };
            int result = BinarySearch.Search(sortedArray, 1);
            Assert.Equal(0, result);
        }

        [Fact]
        public void Search_ReturnsCorrectIndex_WhenElementIsAtEnd()
        {
            int[] sortedArray = { 1, 2, 3, 4, 5 };
            int result = BinarySearch.Search(sortedArray, 5);
            Assert.Equal(4, result);
        }
    }
}
