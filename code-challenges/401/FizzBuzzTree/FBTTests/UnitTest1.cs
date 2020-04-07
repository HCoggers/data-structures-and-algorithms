using FizzBuzzTree;
using FizzBuzzTree.Classes;
using Xunit;

namespace FBTTests
{
    public class UnitTest1
    {
        [Fact]
        public void CanReturnEmptyFBT()
        {
            Tree empty = new Tree();
            Assert.Null(Program.FizzBuzzTree(empty).Root);
        }

        [Fact]
        public void CanReturnSingleNodeTree()
        {
            Tree single = new Tree { Root = new Node { Value = 5 } };
            Assert.Equal("Buzz", Program.FizzBuzzTree(single).Root.Value);
        }

        [Fact]
        public void CanReturnHappyPath()
        {
            Tree normal = new Tree
            {
                Root = new Node
                {
                    Value = 1,
                    LeftChild = new Node
                    {
                        Value = 2
                    },
                    RightChild = new Node
                    {
                        Value = 15
                    }
                }
            };
            Assert.Equal("FizzBuzz", Program.FizzBuzzTree(normal).Root.RightChild.Value);
        }

        [Fact]
        public void CanReturnInDivisibles()
        {
            Tree indie = new Tree { Root = new Node { Value = 1 } };
            Assert.Equal("1", Program.FizzBuzzTree(indie).Root.Value);
        }
    }
}
