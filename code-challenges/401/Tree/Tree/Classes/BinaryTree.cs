using LinkedList.Classes;
using StacksAndQueues.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tree.Classes
{
    public class BinaryTree
    {
        public LinkedList.Classes.Node Root = null;

        /// <summary>
        /// Returns a list of values in the tree, row by row, from top to bottom
        /// </summary>
        /// <param name="tree">the tree to be sorted</param>
        /// <returns>All values in the tree, breadth-first</returns>
        public List<int> BreadthFirst()
        {
            Node current = Root;

            List<int> result = new List<int>();
            if (current == null)
                return result;

            Queue order = new Queue();
            order.Enqueue(current);

            while(!order.IsEmpty())
            {
                current = order.Front;

                if (current.LeftChild != null)
                    order.Enqueue(current.LeftChild);
                if (current.RightChild != null)
                    order.Enqueue(current.RightChild);
                result.Add(order.Dequeue());
            }

            return result;
        }

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
                result = $"{PreOrder(root.LeftChild)}";
            result += $",{root}";
            if (root.RightChild != null)
                result += $",{PreOrder(root.RightChild)}";

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
                result = $"{PreOrder(root.LeftChild)}";
            if (root.RightChild != null)
                result += $",{PreOrder(root.RightChild)}";
            result += $",{root}";

            return Array.ConvertAll(result.Split(","), s => int.Parse(s));
        }
    }
}
