namespace QueueTask3_1;

public static class QueueExtension
{
    public static IQueue<T> Tail<T>(this IQueue<T> queue)
    {
        var newQueue = (IQueue<T>)queue.Clone();
        newQueue.Dequeue();
        return newQueue;
    }
}
