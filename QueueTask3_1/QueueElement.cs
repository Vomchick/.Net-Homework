namespace QueueTask3_1;

internal class QueueElement<T> : ICloneable
{
    public T Value { get; set; }
    public QueueElement<T>? Next { get; set; }

    public object Clone() => new QueueElement<T>
    {
        Next = (QueueElement<T>)(Next?.Clone()),
        Value = Value
    };
}
