using System;

namespace MergeSort
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        /// <summary>
        /// Sorts a given array from smallest to largest
        /// </summary>
        /// <param name="arr">array to be sorted</param>
        public static void MergeSort(int[] arr)
        {
            int n = arr.Length;
            if (n > 1)
            {
                int mid = n / 2;
                int[] Left = new int[mid];
                int[] Right = new int[n - mid];
                for (int i = 0; i < mid; i++)
                    Left[i] = arr[i];
                for (int i = mid; i < n; i++)
                    Right[i - mid] = arr[i];
                MergeSort(Left);
                MergeSort(Right);
                Merge(Left, Right, arr);
            }
        }

        /// <summary>
        /// Compares two sorted halves of one array and combines them to sort the original array
        /// </summary>
        /// <param name="left">left sorted array</param>
        /// <param name="right">right sorted array</param>
        /// <param name="arr">original array to be updated with sorted halves</param>
        private static void Merge(int[] left, int[] right, int[] arr)
        {
            int l = 0;
            int r = 0;
            int i = 0;
            while(l < left.Length && r < right.Length)
            {
                if (left[l] < right[r])
                    arr[i++] = left[l++];
                else
                    arr[i++] = right[r++];
            }
            if(l == left.Length)
                while(r < right.Length)
                    arr[i++] = right[r++];
            else
                while (l < left.Length)
                    arr[i++] = left[l++];

        }
    }
}
