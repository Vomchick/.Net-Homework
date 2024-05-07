namespace QueueTask3_1;

public interface IQueue<T> : ICloneable
{
    public void Enqueue(T value);

    public void Dequeue();

    public bool IsEmpty();
}
