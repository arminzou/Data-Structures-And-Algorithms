// See https://aka.ms/new-console-template for more information
using SortingAlgorithm;

var array = new int[] { 99, 44, 6, 2, 1, 5, 63, 87, 283, 4, 0 };
// BubbleSort.Sort(array);  // Time: O(n^2) Space: O(1)
// SelectionSort.Sort(array);  // Time: O(n^2) Space: O(1)
// InsertionSort.Sort(array);  // Time: O(n^2) Space: O(1)
// MergeSort.Sort(array, 0, array.Length - 1); // Time: O(nlogn) Space: O(n)
QuickSort.Sort(array, 0, array.Length - 1); // Time: O(nlogn)/O(n^2) at worst case Space: O(logn)

Console.WriteLine(string.Join(" ", array));