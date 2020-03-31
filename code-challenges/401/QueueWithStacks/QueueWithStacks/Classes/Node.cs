using System;
using System.Collections.Generic;
using System.Text;

namespace QueueWithStacks.Classes
{
    public class Node
    {
        /// <summary>
        /// The Value this Node contains. In this case, an int.
        /// </summary>
        public int Value { get; set; }

        /// <summary>
        /// The Next Node in a Linked List (instantiated with the LinkList class)
        /// </summary>
        public Node Next { get; set; }

    }
}
