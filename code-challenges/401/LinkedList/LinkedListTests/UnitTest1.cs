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
            Node node = new Node();
            node.Value = 5;
            LinkList list = new LinkList();
            list.Insert(node);

            Assert.Equal(list.Head.Value, node.Value);
        }

        // 3. The head property will properly point to the first node in the linked list
        [Fact]
        public void LinkListHeadIsFirstNode()
        {
            Node firstN = new Node { Value = 5 };
            Node secondN = new Node { Value = 18 };
            Node thirdN = new Node { Value = 71 };
            LinkList list = new LinkList();

            list.Insert(firstN);
            list.Insert(secondN);
            list.Insert(thirdN);
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
            Node firstN = new Node { Value = 5 };
            Node secondN = new Node { Value = 18 };
            Node thirdN = new Node { Value = 71 };
            LinkList list = new LinkList();

            list.Insert(firstN);
            list.Insert(secondN);
            list.Insert(thirdN);

            Assert.True(list.Includes(firstN.Value) && list.Includes(secondN.Value) && list.Includes(thirdN.Value));
        }

        // 5. Will return true when finding a value within the linked list that exists
        [Fact]
        public void CanFindExistingValue()
        {
            Node snape = new Node { Value = 394 };
            LinkList list = new LinkList();
            list.Insert(snape);

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
            fibo.Insert(new Node { Value = 1 });
            fibo.Insert(new Node { Value = 1 });
            fibo.Insert(new Node { Value = 2 });
            fibo.Insert(new Node { Value = 3 });
            fibo.Insert(new Node { Value = 5 });
            fibo.Insert(new Node { Value = 8 });
            string expectation = "{ 8 } -> { 5 } -> { 3 } -> { 2 } -> { 1 } -> { 1 } -> NULL";

            Assert.Equal(expectation, fibo.ToString());
        }

        // ----- CC #2 TESTS -----

        // 1. Can successfully add a node to the end of the linked list
        [Fact]
        public void CanAppendNodeToEndOfList()
        {
            LinkList test = new LinkList();
            test.Insert(new Node { Value = 1 });
            test.Insert(new Node { Value = 2 });
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
