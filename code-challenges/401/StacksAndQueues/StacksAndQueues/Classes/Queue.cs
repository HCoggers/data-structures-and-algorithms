using LinkedList.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace StacksAndQueues.Classes
{
    public class Queue
    {
        public Node Front { get; set; }
        private Node Rear { get; set; }

        /// <summary>
        /// Insert a given value at the rear of the queue
        /// </summary>
        /// <param name="newValue">The value to be queued up</param>
        public void Enqueue(int newValue)
        {
            Node queued = new Node { Value = newValue };
            if (Front == null)
                Front = queued;
            else
            {
                Rear.Next = queued;
            }
            Rear = queued;
        }

        /// <summary>
        /// Removes the first node and returns its value
        /// </summary>
        /// <returns>The value of the dequeued node</returns>
        public int Dequeue()
        {
            try
            {
                int dequeued = Front.Value;

                Node temp = Front;
                Front = Front.Next;
                // Remove next reference to allow garbage collection
                temp.Next = null;

                return dequeued;
            }
            catch
            {
                throw new IndexOutOfRangeException("This Queue is Empty. Enqueue a value first.");
            }
        }

        public int Peek()
        {
            try
            {
                return Front.Value;
            }
            catch
            {
                throw new IndexOutOfRangeException("This Queue is Empty. Enqueue a value first.");
            }
        }

        /// <summary>
        /// Queue's contructor creates an empty queue
        /// </summary>
        public Queue()
        {
            Front = null;
            Rear = null;
        }
    }
}
