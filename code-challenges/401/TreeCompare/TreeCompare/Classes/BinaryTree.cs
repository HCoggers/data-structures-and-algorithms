using System;
using System.Collections.Generic;

namespace TreeCompare.Classes
{
    public class BinaryTree
    {
        public Node Root = null;

        /// <summary>
        /// Returns all the values in this tree in root, leftchild, rightchild order, as an array.
        /// </summary>
        /// <param name="root">The Binary Tree's Root</param>
        /// <returns>All values in the tree, as an array</returns>
        public int[] PreOrder(Node root)
        {
            if (root == null)
                return new int[0];
            string result = $"{Root.Value}";
            if (root.LeftChild != null)
                result += $",{String.Join(",", PreOrder(root.LeftChild))}";
            if (root.RightChild != null)
                result += $",{String.Join(",", PreOrder(root.RightChild))}";

            return Array.ConvertAll(result.Split(","), s => int.Parse(s));
        }

        /// <summary>
        /// Returns all the values in this tree in Left child, Root, right child order, as an array.
        /// </summary>
        /// <param name="root">The Binary Tree's Root</param>
        /// <returns>All values in the tree, as an array</returns>
        public int[] InOrder(Node root)
        {
            if (root == null)
                return new int[0];
            string result = "";
            if (root.LeftChild != null)
                result = $"{InOrder(root.LeftChild)}";
            result += $",{root}";
            if (root.RightChild != null)
                result += $",{InOrder(root.RightChild)}";

            return Array.ConvertAll(result.Split(","), s => int.Parse(s));
        }

        /// <summary>
        /// Returns all the values in this tree in left child, right child, root order, as an array.
        /// </summary>
        /// <param name="root">The Binary Tree's Root</param>
        /// <returns>All values in the tree, as an array</returns>
        public int[] PostOrder(Node root)
        {
            if (root == null)
                return new int[0];
            string result = "";
            if (root.LeftChild != null)
                result = $"{PostOrder(root.LeftChild)}";
            if (root.RightChild != null)
                result += $",{PostOrder(root.RightChild)}";
            result += $",{root}";

            return Array.ConvertAll(result.Split(","), s => int.Parse(s));
        }
    }
}
