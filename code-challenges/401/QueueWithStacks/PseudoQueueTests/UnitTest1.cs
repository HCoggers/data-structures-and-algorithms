using Xunit;
using QueueWithStacks.Classes;

namespace PseudoQueueTests
{
    public class UnitTest1
    {
        [Fact]
        public void CanEnqueueToEmptyQueue()
        {
            PseudoQueue test = new PseudoQueue();
            test.Enqueue(5);

            Assert.Equal(5, test.Dequeue());
        }

        [Fact]
        public void CanEnqueueMultipleNodes()
        {
            PseudoQueue test = new PseudoQueue();
            test.Enqueue(5);
            test.Enqueue(3);
            test.Enqueue(2);
            Assert.True(test.Dequeue() == 5 && test.Dequeue() == 3);
        }

        [Fact]
        public void CantDequeueEmptyQueue()
        {
            PseudoQueue test = new PseudoQueue();
            Assert.Throws<System.IndexOutOfRangeException>(() => test.Dequeue());
        }
    }
}
