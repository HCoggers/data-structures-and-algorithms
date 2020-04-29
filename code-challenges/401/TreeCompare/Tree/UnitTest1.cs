using TreeCompare.Classes;
using System;
using Xunit;
using TreeCompare;

namespace TreeCompareTests
{
    public class UnitTest1
    {
        [Fact]
        public void CanIntersectBinaryTrees()
        {
            BinaryTree tree1 = new BinaryTree
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
            BinaryTree tree2 = new BinaryTree
            {
                Root = new Node
                {
                    Value = 10,
                    LeftChild = new Node
                    {
                        Value = 2,
                        LeftChild = new Node
                        {
                            Value = 7
                        },
                        RightChild = new Node
                        {
                            Value = 5
                        }
                    },
                    RightChild = new Node
                    {
                        Value = 8,
                        LeftChild = new Node
                        {
                            Value = 6
                        },
                        RightChild = new Node
                        {
                            Value = 42
                        }
                    }
                }

            };

            Assert.Equal(new int[] {7, 5, 2, 6 }, Program.TreeIntersection(tree1, tree2));
        }

        [Fact]
        public void CanReturnEmpty()
        {
            BinaryTree tree1 = new BinaryTree
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
            BinaryTree tree2 = new BinaryTree();

            Assert.Equal(new int[0], Program.TreeIntersection(tree1, tree2));
        }

        [Fact]
        public void WillOnlyReturnOnePerValue()
        {
            BinaryTree tree1 = new BinaryTree
            {
                Root = new Node
                {
                    Value = 1,
                    LeftChild = new Node
                    {
                        Value = 7,
                        LeftChild = new Node
                        {
                            Value = 7
                        },
                        RightChild = new Node
                        {
                            Value = 7
                        }
                    },
                    RightChild = new Node
                    {
                        Value = 7,
                        LeftChild = new Node
                        {
                            Value = 7
                        },
                        RightChild = new Node
                        {
                            Value = 7
                        }
                    }
                }
            };
            BinaryTree tree2 = new BinaryTree
            {
                Root = new Node
                {
                    Value = 7,
                    LeftChild = new Node
                    {
                        Value = 7,
                        LeftChild = new Node
                        {
                            Value = 7
                        },
                        RightChild = new Node
                        {
                            Value = 7
                        }
                    },
                    RightChild = new Node
                    {
                        Value = 7,
                        LeftChild = new Node
                        {
                            Value = 1
                        },
                        RightChild = new Node
                        {
                            Value = 7
                        }
                    }
                }
            };

            Assert.Equal(new int[] { 7, 1 }, Program.TreeIntersection(tree1, tree2));
        }
    }
}
