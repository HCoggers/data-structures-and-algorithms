using System;
using Tree.Classes;
using Xunit;

namespace TreeTests
{
    public class UnitTest1
    {
        [Fact]
        public void CanInstantiateEmptyTree()
        {
            BinarySearchTree tree = new BinarySearchTree();
            Assert.Null(tree.Root);
        }

        [Fact]
        public void CanInstantiateTreeWithRoot()
        {
            BinarySearchTree tree = new BinarySearchTree { 
                Root = new Node { 
                    Value = 5 
                } 
            } ;

            Assert.Equal(5, tree.Root.Value);
        }

        [Fact]
        public void CanAddChildrenNodes()
        {
            BinarySearchTree tree = new BinarySearchTree
            {
                Root = new Node
                {
                    Value = 5
                }
            };
            tree.Add(tree.Root, 3);
            tree.Add(tree.Root, 7);

            Assert.True(tree.Contains(tree.Root, 3) && tree.Contains(tree.Root, 7));
        }

        [Fact]
        public void CanReturnPreOrder()
        {
            BinarySearchTree tree = new BinarySearchTree
            {
                Root = new Node
                {
                    Value = 5
                }
            };
            tree.Add(tree.Root, 3);
            tree.Add(tree.Root, 7);/*
            tree.Add(tree.Root, 2);
            tree.Add(tree.Root, 4);
            tree.Add(tree.Root, 6);
            tree.Add(tree.Root, 8);*/

            Assert.Equal(new int[] { 5, 3, 7 }, tree.PreOrder(tree.Root));
        }
    }
}
