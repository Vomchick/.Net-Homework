namespace QueueTask3_1;

public class Queue<T> : IQueue<T>
{
    private QueueElement<T>? _head;
    private QueueElement<T>? _tail;
    private int _count = 0;

    public Queue(T value)
    {
        _head = new QueueElement<T> { Value = value };
        _tail = _head;
        _count++;
    }
    public Queue() { }

    private Queue(QueueElement<T>? head, QueueElement<T>? tail, int count)
    {
        _head = head;
        _tail = tail;
        _count = count;
    }

    public object Clone() 
    {
        if(_head == null)
        {
            return new Queue<T>(_head, _tail, 0);
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
        return new Queue<T>(newValuesFromHead, newTail, _count);
    } 

    public void Dequeue()
    {
        if(_head == null)
        {
            throw new NullReferenceException();
        }

        _head = _head.Next;
        if (_head == null) 
        { 
            _tail = null;
        }
        _count--;
    }

    public void Enqueue(T value)
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
        _count++;
    }

    public bool IsEmpty() => _head == null; //or _count == 0

    public T[] ToArray()
    {
        var arr = new T[_count];
        var iterator = _head;
        for(int i = 0; i < _count; i++)
        {
            arr[i] = iterator.Value;
            iterator = iterator.Next;
        }

        return arr;
    }
}

