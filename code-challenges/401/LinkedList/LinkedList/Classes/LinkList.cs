using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList.Classes
{
    public class LinkList
    {
        public Node Head { get; set; }

        public void Insert(Node newNode)
        {
            newNode.Next = this.Head;
            this.Head = newNode;
        }
        
        public bool Includes(int searchValue)
        {
            Node current = this.Head;
            bool includes = false;
            while(current != null)
            {
                if (current.Value == searchValue)
                    includes = true;
                current = current.Next;
            }
            return includes;
        }

        public override string ToString()
        {
            string collection = "";
            Node current = this.Head;
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
