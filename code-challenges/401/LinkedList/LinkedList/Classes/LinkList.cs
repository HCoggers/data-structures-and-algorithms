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
