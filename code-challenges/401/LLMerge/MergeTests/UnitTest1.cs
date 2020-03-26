using LinkedList.Classes;
using System;
using Xunit;

namespace MergeTests
{
    public class UnitTest1
    {
        [Fact]
        public void CanZipFullAndEmptyLists()
        {
            LinkList test1 = new LinkList
            {
                Head = new Node
                {
                    Value = 1,
                    Next = new Node
                    {
                        Value = 3,
                        Next = new Node
                        {
                            Value = 2
                        }
                    }
                }
            };

            LinkList test2 = new LinkList();

            LinkList merged = LLMerge.Program.MergeLists(test1, test2);

            Assert.Equal(test1, merged);
        }
        [Fact]
        public void CanZipEmptyLists()
        {
            LinkList test1 = new LinkList();

            LinkList test2 = new LinkList();

            LinkList merged = LLMerge.Program.MergeLists(test1, test2);

            Assert.Null(merged.Head);
        }
        [Fact]
        public void CanZipDifferentLengths()
        {
            LinkList test1 = new LinkList
            {
                Head = new Node
                {
                    Value = 1,
                    Next = new Node
                    {
                        Value = 3,
                        Next = new Node
                        {
                            Value = 5
                        }
                    }
                }
            };

            LinkList test2 = new LinkList
            {
                Head = new Node
                {
                    Value = 2,
                    Next = new Node
                    {
                        Value = 4,
                        Next = new Node
                        {
                            Value = 6,
                            Next = new Node
                            {
                                Value = 7,
                                Next = new Node
                                {
                                    Value = 8
                                }
                            }
                        }
                    }
                }
            };

            LinkList merged = LLMerge.Program.MergeLists(test1, test2);

            Assert.Equal("{ 1 } -> { 2 } -> { 3 } -> { 4 } -> { 5 } -> { 6 } -> { 7 } -> { 8 } -> NULL", merged.ToString());
        }
        [Fact]
        public void CanZipEqualLists()
        {
            LinkList test1 = new LinkList
            {
                Head = new Node
                {
                    Value = 1,
                    Next = new Node
                    {
                        Value = 2,
                        Next = new Node
                        {
                            Value = 5
                        }
                    }
                }
            };

            LinkList test2 = new LinkList
            {
                Head = new Node
                {
                    Value = 1,
                    Next = new Node
                    {
                        Value = 3,
                        Next = new Node
                        {
                            Value = 8
                        }
                    }
                }
            };

            LinkList zipped = LLMerge.Program.MergeLists(test1, test2);
            Assert.Equal("{ 1 } -> { 1 } -> { 2 } -> { 3 } -> { 5 } -> { 8 } -> NULL", zipped.ToString());
        }
    }
}
