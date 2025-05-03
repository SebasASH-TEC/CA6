using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public static class BinarySearch
    {
        /// <summary>
        /// Performs binary search on a sorted array.
        /// </summary>
        /// <param name="array">Sorted integer array</param>
        /// <param name="target">Value to search for</param>
        /// <returns>Index of target if found; otherwise, -1</returns>
        public static int Search(int[] array, int target)
        {
            int left = 0;
            int right = array.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (array[mid] == target)
                    return mid;
                else if (array[mid] < target)
                    left = mid + 1;
                else
                    right = mid - 1;
            }

            return -1; // Not found
        }
    }
}
