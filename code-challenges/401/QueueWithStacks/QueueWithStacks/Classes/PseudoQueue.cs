using System;
using System.Collections.Generic;
using System.Text;

namespace QueueWithStacks.Classes
{
    public class PseudoQueue
    {
        // s1 will act as our readable queue
        private Stack s1 = new Stack();
        // s2 will act as our standby so we can properly enqueue nodes
        private Stack s2 = new Stack();

        /// <summary>
        /// Enqueues a Node onto the back of the PseudoQueue
        /// </summary>
        /// <param name="value">value to be assigned to the node</param>
        public void Enqueue(int value)
        {
            while (s1.Top != null)
                s2.Push(s1.Pop());
            s1.Push(value);
            while (s2.Top != null)
                s1.Push(s2.Pop());
        }

        /// <summary>
        /// Removes the front node of the queue, returning its value
        /// </summary>
        /// <returns>value of dequeued node</returns>
        public int Dequeue()
        {
            return s1.Pop();
        }

    }
}
