using System;

namespace BinarySearch
{
    public class Program
    {
        static void Main(string[] args)
        {
            int idx = BinarySearch(new int[] { 1, 2, 3, 4, 5, 6, 7 }, 8);
            Console.WriteLine($"the index is {idx}");
        }
        public static int BinarySearch(int[] sorted, int key)
        {
            int i = sorted.Length / 2;
            while(key != sorted[i])
            {
                if (i == 0 || i == (sorted.Length - 1))
                    return -1;
                if (sorted[i] < key)
                    i = (i + (i * 2)) / 2;
                else
                    i = (i + (i / 2)) / 2;
            }
            return i;
        }
    }
}
