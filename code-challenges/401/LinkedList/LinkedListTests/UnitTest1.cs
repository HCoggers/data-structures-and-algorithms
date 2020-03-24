using System;
using Xunit;
using LinkedList.Classes;

namespace LinkedListTests
{
    public class UnitTest1
    {

        // 1. Can successfully instantiate an empty linked list
        [Fact]
        public void CanCreateEmptyLinkedList()
        {
            LinkList list = new LinkList();
            Assert.Null(list.Head);
        }

        // 2. Can properly insert into the linked list
        [Fact]
        public void CanInsertNodeToLinkList()
        {
            LinkList list = new LinkList();
            list.Insert(5);

            Assert.Equal(5, list.Head.Value);
        }

        // 3. The head property will properly point to the first node in the linked list
        [Fact]
        public void LinkListHeadIsFirstNode()
        {
            LinkList list = new LinkList();
            list.Insert(5);
            list.Insert(18);
            list.Insert(71);
            Node current = list.Head;
            bool headIsFirst = true;

            while (current != null)
            {
                // Checking if the head node, the last inserted, comes AFTER any other node in the list
                if (current.Next == list.Head)
                    headIsFirst = false;
                current = current.Next;
            }

            Assert.True(headIsFirst);

        }

        // 4. Can properly insert multiple nodes into the linked list
        [Fact]
        public void CanInsertMultipleNodes()
        {
            LinkList list = new LinkList();

            list.Insert(5);
            list.Insert(18);
            list.Insert(71);

            Assert.True(list.Includes(5) && list.Includes(18) && list.Includes(71));
        }

        // 5. Will return true when finding a value within the linked list that exists
        [Fact]
        public void CanFindExistingValue()
        {
            LinkList list = new LinkList();
            list.Insert(394);

            Assert.True(list.Includes(394));
        }

        // 6. Will return false when searching for a value in the linked list that does not exist
        [Fact]
        public void WontFindNonexistantValue()
        {
            LinkList emptyList = new LinkList();
            Assert.False(emptyList.Includes(7));
        }

        // 7. Can properly return a collection of all the values that exist in the linked list
        [Fact]
        public void CanCreateStringCollectionOfValues()
        {
            LinkList fibo = new LinkList();
            fibo.Insert(1);
            fibo.Insert(1);
            fibo.Insert(2);
            fibo.Insert(3);
            fibo.Insert(5);
            fibo.Insert(8);
            string expectation = "{ 8 } -> { 5 } -> { 3 } -> { 2 } -> { 1 } -> { 1 } -> NULL";

            Assert.Equal(expectation, fibo.ToString());
        }

        // ----- CC #2 TESTS -----

        // 1. Can successfully add a node to the end of the linked list
        [Fact]
        public void CanAppendNodeToEndOfList()
        {
            LinkList test = new LinkList();
            test.Insert(1);
            test.Insert(2);
            test.Append(3);

            Assert.Equal(3, test.Head.Next.Next.Value);
        }

        // 2. Can successfully add multiple nodes to the end of a linked list
        [Fact]
        public void CanAppendMultipleNodes()
        {
            LinkList list = new LinkList();
            list.Insert(1);
            list.Append(3);
            list.Append(5);

            // checks for the second and third values to equal 3 and 5, and checks that the third is the last node
            Assert.True(list.Head.Next.Value == 3 && list.Head.Next.Next.Value == 5 && list.Head.Next.Next.Next == null);
        }

        // 3. Can successfully insert a node before a node located in the middle of a linked list
        [Fact]
        public void CanInsertNodeBeforeMiddle()
        {
            LinkList threes = new LinkList();
            threes.Insert(3);
            threes.Insert(6);
            threes.Insert(9);
            threes.Insert(15);
            threes.Insert(18);
            threes.InsertBefore(9, 12);

            Assert.Equal("{ 18 } -> { 15 } -> { 12 } -> { 9 } -> { 6 } -> { 3 } -> NULL", threes.ToString());
        }

        // 4. Can successfully insert a node before the first node of a linked list
        [Fact]
        public void CanInsertNodeBeforeHead()
        {
            LinkList threes = new LinkList();
            threes.Insert(3);
            threes.Insert(6);
            threes.Insert(9);
            threes.InsertBefore(9, 12);

            Assert.Equal(12, threes.Head.Value);
        }

        // 5. Can successfully insert after a node in the middle of the linked list
        [Fact]
        public void CanInsertNodeAfterMiddle()
        {
            LinkList fours = new LinkList();
            fours.Append(4);
            fours.Append(8);
            fours.Append(16);
            fours.InsertAfter(8, 12);

            Assert.Equal("{ 4 } -> { 8 } -> { 12 } -> { 16 } -> NULL", fours.ToString());
        }
        // 6. Can successfully insert a node after the last node of the linked list
        [Fact]
        public void CanInsertNodeAfterEnd()
        {
            LinkList fours = new LinkList();
            fours.Append(4);
            fours.Append(8);
            fours.Append(12);
            fours.Append(16);
            fours.InsertAfter(16, 20);

            Assert.Equal("{ 4 } -> { 8 } -> { 12 } -> { 16 } -> { 20 } -> NULL", fours.ToString());
        }
    }
}
