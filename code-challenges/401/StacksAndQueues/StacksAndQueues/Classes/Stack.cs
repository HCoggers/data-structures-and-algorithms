using System;
using System.Collections.Generic;
using System.Text;
using LinkedList.Classes;

namespace StacksAndQueues.Classes
{
    public class Stack
    {
        public Node Top { get; set; }

        /// <summary>
        /// Adds a new node with the given value to the top of a stack
        /// </summary>
        /// <param name="value">The value to be pushed onto the stack</param>
        public void Push(int value)
        {
            Node newTop = new Node { Value = value };
            if (Top != null)
                newTop.Next = Top;
            Top = newTop;
        }

        /// <summary>
        /// Removes the top Node of a stack, and returns its value
        /// </summary>
        /// <returns>The Value of the Top node</returns>
        public int Pop()
        {
            try
            {
                int popped = Top.Value;

                Node temp = Top;
                Top = Top.Next;
                // Remove next reference to allow garbage collection
                temp.Next = null;

                return popped;
            }
            catch
            {
                throw new IndexOutOfRangeException("This Stack is Empty. Push a value onto it first.");
            }
        }

        /// <summary>
        /// Returns the value of the top node on a stack
        /// </summary>
        /// <returns>Top's value</returns>
        public int Peek()
        {
            try
            {
                return Top.Value;
            }
            catch
            {
                throw new IndexOutOfRangeException("This Stack is Empty. Push a value onto it first.");
            }
        }


        /// <summary>
        /// Constructor sets an initial empty value to the Top property
        /// </summary>
        public Stack()
        {
            Top = null;
        }
    }
}
