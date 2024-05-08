namespace QueueTask3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var queue = new Queue<int>(1);
            queue.Dequeue();
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);
            queue.ToArray();
            queue.Dequeue();
            queue.ToArray();
            queue.Dequeue();
            var tailQueue = queue.Tail();
            tailQueue.Enqueue(2);

            //mostly useless, check test class
        }
    }
}
