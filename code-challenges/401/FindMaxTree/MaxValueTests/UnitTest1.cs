using LinkedList.Classes;
using System;
using Tree.Classes;
using Xunit;

namespace MaxValueTests
{
    public class UnitTest1
    {
        [Fact]
        public void CanReturnZeroForEmptyTree()
        {
            BinaryTree empty = new BinaryTree();
            Assert.Equal(0, empty.FindMaxValue());
        }

        [Fact]
        public void CanReturnSingleRootValue()
        {
            BinaryTree solo = new BinaryTree { Root = new Node { Value = 5 } };
            Assert.Equal(5, solo.FindMaxValue());
        }
        
        [Fact]
        public void CanFindMaxInPerfectTree()
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

            Assert.Equal(7, perfect.FindMaxValue());
        }
    }
}
