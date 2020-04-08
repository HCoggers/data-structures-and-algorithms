using LinkedList.Classes;
using System;
using System.Collections.Generic;
using Tree.Classes;
using Xunit;

namespace TreeTests
{
    public class UnitTest1
    {
        #region Monday Tests
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
                Root = new Node
                {
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

        /*[Fact]
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
            tree.Add(tree.Root, 7);*//*
            tree.Add(tree.Root, 2);
            tree.Add(tree.Root, 4);
            tree.Add(tree.Root, 6);
            tree.Add(tree.Root, 8);*//*

            Assert.Equal(new int[] { 5, 3, 7 }, tree.PreOrder(tree.Root));
        }*/

        #endregion MondayTests

        #region BreadthTests
        [Fact] 
        public void CanReturnEmptyTree()
        {
            BinaryTree empty = new BinaryTree();
            Assert.Empty(empty.BreadthFirst());
        }

        [Fact]
        public void CanReturnSingleRoot()
        {
            BinaryTree rooty = new BinaryTree
            {
                Root = new Node
                {
                    Value = 1
                }
            };
            Assert.Equal(new List<int> { 1 }, rooty.BreadthFirst());
        }

        [Fact]
        public void CanReturnPerfectTree()
        {
            BinaryTree perfect = new BinaryTree
            {
                Root = new Node
                {
                    Value = 1,
                    LeftChild = new Node
                    {
                        Value = 2,
                        LeftChild = new Node
                        {
                            Value = 4
                        },
                        RightChild = new Node
                        {
                            Value = 5
                        }
                    },
                    RightChild = new Node
                    {
                        Value = 3,
                        LeftChild = new Node
                        {
                            Value = 6
                        },
                        RightChild = new Node
                        {
                            Value = 7
                        }
                    }
                }
            };
            List<int> outcome = new List<int> { 1, 2, 3, 4, 5, 6, 7 };

            Assert.Equal(outcome, perfect.BreadthFirst());
        }

        [Fact]
        public void CanReturnImperfectTree()
        {
            BinaryTree imp = new BinaryTree
            {
                Root = new Node
                {
                    Value = 2,
                    LeftChild = new Node
                    {
                        Value = 7,
                        LeftChild = new Node
                        {
                            Value = 2
                        },
                        RightChild = new Node
                        {
                            Value = 6,
                            LeftChild = new Node
                            {
                                Value = 5
                            },
                            RightChild = new Node
                            {
                                Value = 11
                            }
                        }
                    },
                    RightChild = new Node
                    {
                        Value = 5,
                        RightChild = new Node
                        {
                            Value = 9,
                            LeftChild = new Node
                            {
                                Value = 4
                            }
                        }
                    }
                }
            };
            List<int> outcome = new List<int> { 2, 7, 5, 2, 6, 9, 5, 11, 4 };

            Assert.Equal(outcome, imp.BreadthFirst());
        }
        #endregion BreadthTests
    }
}
