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
        /// <param name="newNode">The node to be inserted</param>
        public void Insert(Node newNode)
        {
            newNode.Next = Head;
            Head = newNode;
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
