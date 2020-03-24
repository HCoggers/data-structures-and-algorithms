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

            while(current != null)
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
        // Can successfully add multiple nodes to the end of a linked list
        // Can successfully insert a node before a node located in the middle of a linked list
        // Can successfully insert a node before the first node of a linked list
        // Can successfully insert after a node in the middle of the linked list
        // Can successfully insert a node after the last node of the linked list
    }
}
