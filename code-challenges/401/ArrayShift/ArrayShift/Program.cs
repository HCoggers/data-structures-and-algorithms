using System;

namespace ArrayShift
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] array = { 1, 2, 4, 5, 6 };
            int number = 9;
            int[] answer = InsertShiftArray(array, number);
            foreach(int i in answer)
                Console.Write($"{i}, ");
        }
        public static int[] InsertShiftArray(int[] oldArray, int newInt)
        {
            int[] newArray = new int[oldArray.Length + 1];
            for(int i = 0; i < newArray.Length; i++)
            {
                if (i > (newArray.Length / 2))
                    newArray[i] = oldArray[i - 1];
                else if (i == (newArray.Length / 2))
                    newArray[i] = newInt;
                else
                    newArray[i] = oldArray[i];
            }

            return newArray;
        }
    }
}
