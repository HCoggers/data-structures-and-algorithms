using System;
using System.Collections.Generic;
using System.Text;

namespace Tree.Classes
{
    public class BinarySearchTree : BinaryTree
    {
        public void Add(Node root, int value)
        {
            if (root == null)
                Root = new Node { Value = value };
            if(value < root.Value)
            {
                if (root.LeftChild == null)
                    root.LeftChild = new Node { Value = value };
                else
                    Add(root.LeftChild, value);
            }
            if (value > root.Value)
            {
                if (root.RightChild == null)
                    root.RightChild = new Node { Value = value };
                else
                    Add(root.RightChild, value);
            }
        }

        public bool Contains(Node root, int value)
        {
            if (value == root.Value)
                return true;
            if (value < root.Value)
                return Contains(root.LeftChild, value);
            if (value > root.Value)
                return Contains(root.RightChild, value);
            return false;
        }
    }
}
