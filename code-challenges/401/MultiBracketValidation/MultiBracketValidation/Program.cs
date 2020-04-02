using StacksAndQueues.Classes;
using System;

namespace MultiBracketValidation
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        /// <summary>
        /// Returns whether or not all types of brackets in a string are properly "closed"
        /// </summary>
        /// <param name="input">the string to be validated</param>
        /// <returns>true if all brackets are paired or else false</returns>
        public static bool MultiBracketValidation(string input)
        {
            Stack curly = new Stack();
            Stack round = new Stack();
            Stack square = new Stack();
            bool paired = true;

            for (int i = 0; i < input.Length; i++)
            {
                switch(input[i])
                {
                    case '{': 
                        curly.Push(1);
                        break;
                    case '(':
                        round.Push(1);
                        break;
                    case '[':
                        square.Push(1);
                        break;
                    case '}':
                        if (curly.Top == null)
                            paired = false;
                        else curly.Pop();
                        break;
                    case ')':
                        if (round.Top == null)
                            paired = false;
                        else round.Pop();
                        break;
                    case ']':
                        if (square.Top == null)
                            paired = false;
                        else square.Pop();
                        break;
                    default:
                        break;
                }
            }
            if (curly.Top != null || round.Top != null || square.Top != null)
                paired = false;
            return paired;
        }
    }
}
