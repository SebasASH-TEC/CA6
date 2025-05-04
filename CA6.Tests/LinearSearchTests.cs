using Algorithms;
using Xunit;

namespace CA6.Tests
{
    public class LinearSearchTests
    {
        [Fact]
        public void ElementFound_ReturnsCorrectIndex()
        {
            int[] arr = { 5, 10, 15, 20 };//arreglo
            int result = LinealSearch.LinearSearch(arr, 15);//lo que se quiere buscar 
            Assert.Equal(2, result); //en este caso si  encuentra el resultado 
        }

        [Fact]
        public void ElementNotFound_ReturnsMinusOne()
        {
            int[] arr = { 1, 2, 3, 4 };//arreglo
            int result = LinealSearch.LinearSearch(arr, 10);//lo que se quiere buscar en el arreglo anterior
            Assert.Equal(-1, result);// en este caso no se encuentra el elemento en el arreglo
        }

        [Fact]
        public void EmptyArray_ReturnsMinusOne()
        {
            int[] arr = { };//arreglo vacio
            int result = LinealSearch.LinearSearch(arr, 1);//lo que se quiere buscar
            Assert.Equal(-1, result);//no se encuentra pues el arreglo esta vacio
        }

        [Fact]
        public void DuplicatedElement_ReturnsFirstIndex()
        {
            int[] arr = { 3, 5, 3, 7, 3 };//arreglo
            int result = LinealSearch.LinearSearch(arr, 3);//lo que se busca
            Assert.Equal(0, result);// da como resultado 0, pues el primer elemento que encontro esta en esa posicion a pesar de que se encuantra repetido
        }
    }
}