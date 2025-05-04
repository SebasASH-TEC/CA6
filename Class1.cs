using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{ //Clase para la busqueda lineal
    public static class LinealSearch
    {
        public static int LinearSearch(int[] arr, int target) //Obtiene los datos, el array y el elemento a buscar
        {
            for (int i = 0; i < arr.Length; i++) //recorre todo el array elemento por elemento
            {
                if (arr[i] == target) //compara el elemento del array con el elemento a buscar
                {
                    return i; //retorna el elemento en caso de que este se encuentre
                }
            }
            return -1; //retorna -1 en caso de haber recorrido todo el array y no encontrar el elemento
        }
    }
}