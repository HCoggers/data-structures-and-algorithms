using System;
using Xunit;
using LinkedList.Classes;

namespace LinkedListTests
{
    public class UnitTest1
    {
        /*
        
        5. Will return true when finding a value within the linked list that exists
        6. Will return false when searching for a value in the linked list that does not exist
        7. Can properly return a collection of all the values that exist in the linked list
        */
        
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

            Assert.True(list.Includes(firstN) && list.Includes(secondN) && list.Includes(thirdN));

        }
    }
}
