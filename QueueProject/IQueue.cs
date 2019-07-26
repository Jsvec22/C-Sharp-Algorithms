namespace QueueProject
{
    public interface IQueue<T>
    {
        void Enqueue(T item);
        bool isEmpty();
        bool isFull();
        T peekFront();
        T Dequeue();
        string ToString();
        int Count();
        void Clear();
        bool Contains(T item);
        T[] ToArray();
        void TrimExcess();
    }
}