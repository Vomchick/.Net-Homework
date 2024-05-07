namespace QueueTask3_1;

public class Queue<T> : IQueue<T>
{
    private QueueElement<T>? _head;
    private QueueElement<T>? _tail;

    public Queue(T value)
    {
        _head = new QueueElement<T> { Value = value };
        _tail = _head;
    }
    public Queue() { }

    private Queue(QueueElement<T>? head, QueueElement<T>? tail)
    {
        _head = head;
        _tail = tail;
    }

    public object Clone() 
    {
        if(_head == null)
        {
            return new Queue<T>(_head, _tail);
        }

        var newValuesFromHead = (QueueElement<T>)_head?.Clone();
        var iterator = newValuesFromHead;
        QueueElement<T> newTail = null;
        while (iterator != null)
        {
            if(iterator.Next == null)
            {
                newTail = iterator;
            }
            iterator = iterator.Next;
        }
        return new Queue<T>(newValuesFromHead, newTail);
    } 

    public void Dequeue()
    {
        try
        {
            _head = _head.Next;
            if (_head == null) 
            { 
                _tail = null;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
    }

    public void Enqueue(T value)
    {
        try
        {
            if (_tail != null)
            {
                _tail.Next = new QueueElement<T> { Value = value };
                _tail = _tail.Next;
            }
            else
            {
                _head = new QueueElement<T> { Value = value };
                _tail = _head;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
    }

    public bool IsEmpty() => _head == null;
}

