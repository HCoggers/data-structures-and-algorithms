using StacksAndQueues.Classes;
using Xunit;

namespace StacksAndQueuesTests
{
    public class UnitTest1
    {

        #region Stack Tests
        [Fact]
        public void CanPushOntoStack()
        {
            Stack pancakes = new Stack();
            pancakes.Push(5);

            Assert.Equal(5, pancakes.Top.Value);
        }

        [Fact]
        public void CanPushMultipleValuesToStack()
        {
            Stack dishes = new Stack();
            dishes.Push(7);
            dishes.Push(3);

            Assert.Equal(3, dishes.Top.Value);
        }

        [Fact]
        public void CanPopOffOfStack()
        {
            Stack books = new Stack();
            books.Push(7);
            books.Push(42);
            books.Pop();

            Assert.Equal(7, books.Top.Value);
        }

        [Fact]
        public void CanEmptyStackWithPops()
        {
            Stack cash = new Stack();
            cash.Push(5);
            cash.Push(5);
            cash.Push(5);
            cash.Pop();
            cash.Pop();
            cash.Pop();

            Assert.Null(cash.Top);
        }

        [Fact]
        public void CanPeekNextValueOnStack()
        {
            Stack tissues = new Stack();
            tissues.Push(5);
            tissues.Push(69);

            Assert.Equal(69, tissues.Peek());
        }

        [Fact]
        public void CanCreateEmptyStack()
        {
            Stack cares = new Stack();

            Assert.Null(cares.Top);
        }

        [Fact]
        public void PeekCanThrowExceptionsOnEmptyStack()
        {
            Stack worries = new Stack();
            Assert.Throws<System.IndexOutOfRangeException>(() => worries.Peek());
        }

        [Fact]
        public void PopCanThrowExceptionsOnEmptyStack()
        {
            Stack worries = new Stack();
            Assert.Throws<System.IndexOutOfRangeException>(() => worries.Pop());
        }
        #endregion Stack Tests

        #region Queue Tests
        [Fact] 
        public void CanEnqueueValueOntoQueue()
        {
            Queue atcostco = new Queue();
            atcostco.Enqueue(1);

            Assert.Equal(1, atcostco.Front.Value);
        }

        [Fact]
        public void CanEnqueueMultipleValues()
        {
            Queue forWillCall = new Queue();
            forWillCall.Enqueue(5);
            forWillCall.Enqueue(7);
            Assert.True(forWillCall.Front.Value == 5 && forWillCall.Front.Next.Value == 7);
        }

        [Fact]
        public void CanDequeueAValue()
        {
            Queue tsa = new Queue();
            tsa.Enqueue(7);
            Assert.True(7 == tsa.Dequeue() && tsa.Front == null);
        }

        [Fact]
        public void CanPeekNextValueinQueue()
        {
            Queue traffic = new Queue();
            traffic.Enqueue(7);

            Assert.Equal(7, traffic.Peek());
        }

        [Fact]
        public void CanEmptyQueueWithDequeues()
        {
            Queue todo = new Queue();
            todo.Enqueue(3);
            todo.Enqueue(4);
            todo.Enqueue(5);
            todo.Dequeue();
            todo.Dequeue();
            todo.Dequeue();

            Assert.Null(todo.Front);
        }

        [Fact]
        public void CanInstantiateEmptyQueue()
        {
            Queue dmv = new Queue();
            Assert.Null(dmv.Front);
        }

        [Fact]
        public void DequeueCanThrowExceptionOnEmptyQueue()
        {
            Queue batters = new Queue();
            Assert.Throws<System.IndexOutOfRangeException>(() => batters.Dequeue());
        }

        [Fact]
        public void PeekCanThrowExceptionOnEmptyQueue()
        {
            Queue batters = new Queue();
            Assert.Throws<System.IndexOutOfRangeException>(() => batters.Peek());
        }
        #endregion Queue Tests
    }
}
