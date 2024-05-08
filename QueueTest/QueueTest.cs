using QueueTask3_1;

namespace QueueTest
{
    [TestClass]
    public class QueueTest
    {
        [TestMethod]
        public void DequeEmptyQueue()
        {
            var queue = new QueueTask3_1.Queue<int>();
            
            Assert.ThrowsException<NullReferenceException>(() => queue.Dequeue());
        }

        [TestMethod]
        public void Enque()
        {
            var queue = new QueueTask3_1.Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            var expectedResult = new int[] { 1, 2, 3 };

            for (int i = 0; i < expectedResult.Length; i++)
            {
                Assert.AreEqual(queue.ToArray()[i], expectedResult[i]);
            }
        }

        [TestMethod]
        public void Deque()
        {
            var queue = new QueueTask3_1.Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Dequeue();

            var expectedResult = new int[] { 2, 3 };

            for (int i = 0; i < expectedResult.Length; i++)
            {
                Assert.AreEqual(queue.ToArray()[i], expectedResult[i]);
            }
        }

        [TestMethod]
        public void IsEmptyFalse()
        {
            var queue = new QueueTask3_1.Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            Assert.IsFalse(queue.IsEmpty());
        }

        [TestMethod]
        public void IsEmptyTrue()
        {
            var queue = new QueueTask3_1.Queue<int>();

            Assert.IsTrue(queue.IsEmpty());
        }

        [TestMethod]
        public void Tail()
        {
            var queue = new QueueTask3_1.Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            
            var tailedQueue = queue.Tail();

            var expectedResult = new int[] { 2, 3, 4 };

            for (int i = 0; i < expectedResult.Length; i++)
            {
                Assert.AreEqual(tailedQueue.ToArray()[i], expectedResult[i]);
            }
        }
    }
}
