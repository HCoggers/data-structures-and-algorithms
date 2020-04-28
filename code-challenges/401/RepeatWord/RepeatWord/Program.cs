using RepeatWord.Classes;
using System;

namespace RepeatWord
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string book = "COPyCaT copYCat";
            Console.WriteLine(RepeatedWord(book));
        }

        /// <summary>
        /// Checks for the first repeated word in a long string and returns it.
        /// Returns null if no words repeat
        /// </summary>
        /// <param name="book">string to be checked for repeats</param>
        /// <returns>first repeated word</returns>
        public static string RepeatedWord(string book)
        {
            HashTable foundWords = new HashTable(20);

            string current = "";
            for (int i = 0; i < book.Length; i++)
            {
                if (book[i] != ' ')
                {
                    current += Char.ToLower(book[i]);
                }
                else if (foundWords.Contains(current))
                {
                    return current;
                }
                else
                {
                    foundWords.Add(current, "found");
                    current = "";
                }
            }
            if (foundWords.Contains(current))
                return current;
            return null;
        }
    }
}
