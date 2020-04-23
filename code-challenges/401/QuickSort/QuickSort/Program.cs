using System;

namespace QuickSort
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        /// <summary>
        /// Sorts a given array using its first and last index, from smallest to highest
        /// </summary>
        /// <param name="arr">The array to be sorted</param>
        /// <param name="left">the first index of the array (usually 0)</param>
        /// <param name="right">The last index of the array (usually arr.length - 1)</param>
        public static void QuickSort(int[] arr, int left, int right)
        {
            if(left < right)
            {
                int position = Partition(arr, left, right);
                QuickSort(arr, left, position - 1);
                QuickSort(arr, position + 1, right);
            }
        }

        private static int Partition(int[] arr, int left, int right)
        {
            int pivot = arr[right];
            int low = left - 1;

            for(int i = left; i < right; i++)
            {
                if (arr[i] <= pivot)
                    Swap(arr, i, ++low);
            }
            Swap(arr, right, ++low);
            return low;
        }
        private static void Swap(int[] arr, int i, int low)
        {
            int temp = arr[i];
            arr[i] = arr[low];
            arr[low] = temp;
        }
    }
}
