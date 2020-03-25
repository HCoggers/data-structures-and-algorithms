using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList.Classes
{
    public class LinkList
    {
        /// <summary>
        /// The First Node in a linked list. The entry point to traverse the list
        /// </summary>
        public Node Head { get; set; }

        /// <summary>
        /// Inserts a new node at the beginning of a linked list, assigning it to head, and moving the previous head down to list.
        /// </summary>
        /// <param name="nodeValue">The value of the new node to be inserted</param>
        public void Insert(int nodeValue)
        {
            Node newNode = new Node { Value = nodeValue };
            newNode.Next = Head;
            Head = newNode;
        }

        /// <summary>
        /// Inserts a new node before the first node whose value matches the search value.
        /// </summary>
        /// <param name="searchValue">The Value of the node to search for.</param>
        /// <param name="newValue">The Value of the new node to be inserted.</param>
        public void InsertBefore(int searchValue, int newValue)
        {
            Node current = this.Head;
            if (current.Value == searchValue)
            {
                Insert(newValue);
                return;
            }
                
            while(current.Next.Value != searchValue && current != null)
                current = current.Next;
            if (current != null)
                current.Next = new Node { Value = newValue, Next = current.Next };
        }

        /// <summary>
        /// Inserts a new node after the first node whose value matches the search value.
        /// </summary>
        /// <param name="searchValue">The Value of the node to search for.</param>
        /// <param name="newValue">The Value of the new node to be inserted.</param>
        public void InsertAfter(int searchValue, int newValue)
        {
            Node current = this.Head;
            while (current.Value != searchValue && current.Next != null)
                current = current.Next;
            if (current.Value == searchValue)
                current.Next = new Node { Value = newValue, Next = current.Next };
        }

        /// <summary>
        /// Appends a new node to the end of a linked list, assigning it to the next value of the previous tail.
        /// </summary>
        /// <param name="nodeValue">The value of the new node to be appended</param>
        public void Append(int nodeValue)
        {
            Node current = this.Head;
            if (current == null)
                this.Head = new Node { Value = nodeValue };
            else
            {
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = new Node { Value = nodeValue };
            }
        }

        /// <summary>
        /// Deletes the first node whose value matches the first value from the list
        /// </summary>
        /// <param name="searchValue">The value of the node to be deleted</param>
        public void Delete(int searchValue)
        {
            Node current = Head;
            if (current.Value == searchValue)
            {
                Head = current.Next;
                return;
            }
            while (current.Next.Value != searchValue && current.Next != null)
                current = current.Next;
            if (current.Next.Value == searchValue)
                current.Next = current.Next.Next;
        }
        
        public int KthFromEnd(int k)
        {
            int K = -k;
            Node current = Head;
            while(current.Next != null)
            {
                current = current.Next;
                K++;
            }
            if (K < 0 || k < 0)
                throw new IndexOutOfRangeException($"There is no Node {k} nodes from the list end.");

            current = Head;
            for (int i = 0; i < K; i++)
                current = current.Next;

            return current.Value;
        }

        /// <summary>
        /// Checks if a given Value is represented anywhere in the linked list's nodes. returns true if it finds a matching value.
        /// </summary>
        /// <param name="searchValue">The value to search for</param>
        /// <returns>True if found. False if not</returns>
        public bool Includes(int searchValue)
        {
            Node current = Head;
            bool includes = false;
            while(current != null)
            {
                if (current.Value == searchValue)
                    includes = true;
                current = current.Next;
            }
            return includes;
        }

        /// <summary>
        /// Returns a formatted string of all the values of nodes in your list.
        /// Format: "{ a } -> { b } -> { c } -> NULL"
        /// </summary>
        /// <returns>string representation of LinkList</returns>
        public override string ToString()
        {
            string collection = "";
            Node current = Head;
            while(current != null)
            {
                collection += $"{{ {current.Value} }} -> ";
                current = current.Next;
            }
            collection += "NULL";
            return collection;
        }
    }
}
