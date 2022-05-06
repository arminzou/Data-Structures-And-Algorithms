using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SortingAlgorithm
{
    public class QuickSort
    {
        public static void Sort(int[] array, int from, int to)
        {
            if (from >= to) return;
            int index = Partition(array, from, to);
            Sort(array, from, index - 1);
            Sort(array, index + 1, to);
        }

        private static int Partition(int[] array, int from, int to)
        {
            int pivot = array[from];
            int i = from + 1, j = to;
            while (i <= j)
            {
                while (i <= j && array[i] <= pivot)
                    i++;
                while (i <= j && array[j] > pivot)
                    j--;
                if (i > j)
                    break;
                Swap(array, i, j);
            }
            Swap(array, from, j);
            return j;
        }

        private static void Swap(int[] array, int i, int j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }
}