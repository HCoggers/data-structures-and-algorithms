using System;
using System.Collections.Generic;
using TreeCompare.Classes;

namespace TreeCompare
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static int[] TreeIntersection(BinaryTree tree1, BinaryTree tree2)
        {
            List<int> result = new List<int>();
            HashTable values = new HashTable(20);

            TreeToTable(tree1.Root, values);
            Intersect(values, tree2.Root, result);

            return result.ToArray();
        }

        /// <summary>
        /// Adds all the common values from a given binary tree and a hash table to a given list.
        /// </summary>
        /// <param name="values">hash table of stringified values to be searched</param>
        /// <param name="root">root of Binary tree to be compared</param>
        /// <param name="result">empty list to hold any found matches</param>
        private static void Intersect(HashTable values, Node root, List<int> result)
        {
            if (root == null)
                return;
            if (root.LeftChild != null)
                Intersect(values, root.LeftChild, result);
            if (root.RightChild != null)
                Intersect(values, root.RightChild, result);
            if (values.Contains(root.Value.ToString()) && !result.Contains(root.Value))
                result.Add(root.Value);
        }

        /// <summary>
        /// Populates a given Hash table with all the unique values in a binary tree.
        /// </summary>
        /// <param name="root">root of Binary tree to be transferred to hash table</param>
        /// <param name="values">Empty hash table to hold values</param>
        private static void TreeToTable(Node root, HashTable values)
        {
            if (root == null)
                return;
            if (root.LeftChild != null)
                TreeToTable(root.LeftChild, values);
            if (root.RightChild != null)
                TreeToTable(root.RightChild, values);
            if (!values.Contains(root.Value.ToString()))
                values.Add(root.Value.ToString(), "found");
        }
    }
}
