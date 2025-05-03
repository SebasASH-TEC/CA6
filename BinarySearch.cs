using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    // Clase para implementar la búsqueda binaria
    public static class BinarySearch 
    {
        
        public static int Search(int[] array, int target)
        {
            int left = 0;
            int right = array.Length - 1; //Dimensiona el array

            while (left <= right) //Verifica si el índice izquierdo es menor o igual al derecho, o sea, si hay elementos en el array
            {
                int mid = left + (right - left) / 2; //Calcula el índice medio que usará para comparar el valor del array con el valor objetivo (El pivote)

                if (array[mid] == target) //Si el valor del array en el índice medio es igual al valor objetivo, entonces se ha encontrado el elemento
                    return mid;
                else if (array[mid] < target) //Si el valor del array en el índice medio es menor que el valor objetivo, entonces se busca en la mitad derecha del array
                    left = mid + 1;
                else
                    right = mid - 1; //Sino, entonces se busca en la mitad izquierda del array
            }

            return -1; //Si no se encuentra el elemento, se retorna -1
        }
    }
}
