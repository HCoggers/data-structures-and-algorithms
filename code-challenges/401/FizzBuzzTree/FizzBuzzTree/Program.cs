using FizzBuzzTree.Classes;
using System;

namespace FizzBuzzTree
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        /// <summary>
        /// Takes in a binary tree of integers, and returns a "fizzbuzz" tree,
        /// where any value divisible by 3 is now a "fizz"
        /// any value divisible by 5 is now a "buzz"
        /// and any value divisible by both is now a "fizzbuzz"
        /// all other values are simply converted to strings
        /// </summary>
        /// <param name="tree">The tree to be fizzed and buzzed</param>
        /// <returns>the fizzbuzz tree</returns>
        public static Tree FizzBuzzTree(Tree tree)
        {
            if (tree.Root == null)
                return new Tree();

            int value = (int)tree.Root.Value;
            Node result = new Node { Value = "" };

            if ( value % 3 == 0)
                result.Value += "Fizz";
            if (value % 5 == 0)
                result.Value += "Buzz";
            if ((string)result.Value == "")
                result.Value += $"{value}";

            if (tree.Root.LeftChild != null)
                result.LeftChild = FizzBuzzTree( new Tree 
                    { 
                        Root = tree.Root.LeftChild 
                    }).Root;
            if (tree.Root.RightChild != null)
                result.RightChild = FizzBuzzTree(new Tree
                {
                    Root = tree.Root.RightChild
                }).Root;

            return new Tree { Root = result };
        }
    }
}
