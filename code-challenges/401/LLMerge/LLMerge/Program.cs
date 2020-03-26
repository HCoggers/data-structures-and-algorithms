using LinkedList.Classes;
using System;

namespace LLMerge
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            LinkList test1 = new LinkList
            {
                Head = new Node
                {
                    Value = 1,
                    Next = new Node
                    {
                        Value = 3,
                        Next = new Node
                        {
                            Value = 2
                        }
                    }
                }
            };

            LinkList test2 = new LinkList
            {
                Head = new Node
                {
                    Value = 5,
                    Next = new Node
                    {
                        Value = 9,
                        Next = new Node
                        {
                            Value = 4
                        }
                    }
                }
            };

            LinkList zipped = MergeLists(test1, test2);
            Console.WriteLine(zipped.ToString());
        }

        /// <summary>
        /// Merges two linked lists together, alternating nodes between the first and the second.
        /// Continues with nodes until both lists are fully integrated, even if list lengths differ.
        /// </summary>
        /// <param name="list1">This list will be first, the Head node will be from this.</param>
        /// <param name="list2">This list will be second.</param>
        /// <returns></returns>
        public static LinkList MergeLists(LinkList list1, LinkList list2)
        {
            Node temp = null;
            Node current1 = list1.Head;
            Node current2 = list2.Head;
            if (current1 != null)
            {
                if (current2 != null)
                {
                    while (current1.Next != null && current2.Next != null)
                    {
                        temp = current1.Next;
                        current1.Next = current2;
                        current1 = temp;
                        temp = current2.Next;
                        current2.Next = current1;
                        current2 = temp;
                    }
                        current1.Next = current2;
                }
                return list1;
            }
            return list2;
        }
    }
}
