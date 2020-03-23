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
        
        public bool Includes(Node search)
        {
            Node current = this.Head;
            bool includes = false;
            while(current != null)
            {
                if (current == search)
                    includes = true;
                current = current.Next;
            }
            return includes;
        }
    }
}
