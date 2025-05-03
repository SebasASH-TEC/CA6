using Xunit;
using Algorithms;

namespace CA6.Tests
{
    public class BinarySearchTests
    {
        [Fact]
        public void Search_ReturnsCorrectIndex_WhenElementIsFound() //Testea el método Search buscando un elemento en el array y verificando si lo encuentra en la posicion correcta
        {
            int[] sortedArray = { 1, 3, 5, 7, 9, 11 };
            int result = BinarySearch.Search(sortedArray, 7);
            Assert.Equal(3, result);
        }

        [Fact]
        public void Search_ReturnsMinusOne_WhenElementIsNotFound() //Testea el método Search buscando un elemento que no existe en el array y verificando si retorna -1
        {
            int[] sortedArray = { 2, 4, 6, 8, 10 };
            int result = BinarySearch.Search(sortedArray, 5);
            Assert.Equal(-1, result);
        }

        [Fact]
        public void Search_ReturnsMinusOne_WhenArrayIsEmpty() //Testea el método Search buscando un elemento en un array vacío y verificando si retorna -1
        {
            int[] emptyArray = { };
            int result = BinarySearch.Search(emptyArray, 1);
            Assert.Equal(-1, result);
        }

        [Fact]
        public void Search_ReturnsCorrectIndex_WhenElementIsAtBeginning() //Testea el método Search buscando un elemento que está al principio del array y verificando si lo encuentra en la posicion correcta
        {
            int[] sortedArray = { 1, 2, 3, 4, 5 };
            int result = BinarySearch.Search(sortedArray, 1);
            Assert.Equal(0, result);
        }

        [Fact]
        public void Search_ReturnsCorrectIndex_WhenElementIsAtEnd() //Testea el método Search buscando un elemento que está al final del array y verificando si lo encuentra en la posicion correcta
        {
            int[] sortedArray = { 1, 2, 3, 4, 5 };
            int result = BinarySearch.Search(sortedArray, 5);
            Assert.Equal(4, result);
        }
    }
}
