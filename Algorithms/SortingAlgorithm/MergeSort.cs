using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SortingAlgorithm
{
    public class MergeSort
    {
        public static void Sort(int[] array, int lo, int hi)
        {
            if (lo >= hi) return;
            int mid = lo + (hi - lo) / 2;
            Sort(array, lo, mid);
            Sort(array, mid + 1, hi);
            Merge(array, lo, mid, hi);
        }

        private static void Merge(int[] array, int lo, int mid, int hi)
        {
            // define subarray size
            int n1 = mid - lo + 1;
            int n2 = hi - mid;

            // create subarrays
            var left = new int[n1];
            var right = new int[n2];

            int i, j;
            for (i = 0; i < n1; i++)
                left[i] = array[lo + i];
            for (j = 0; j < n2; j++)
                right[j] = array[mid + 1 + j];

            // merge subarrays
            i = 0;
            j = 0;
            int k = lo;
            while (i < n1 && j < n2)
            {
                if (left[i] <= right[j])
                    array[k++] = left[i++];
                else
                    array[k++] = right[j++];
            }

            // copy remaining elements
            while (i < n1)
                array[k++] = left[i++];
            while (j < n2)
                array[k++] = right[j++];
        }
    }
}