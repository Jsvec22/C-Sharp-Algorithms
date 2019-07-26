namespace QueueProject
{
    using static System.Console;
    class Queue<T> : IQueue<T>
    {
        private int maxSize;
        private T[] myQueue;
        private int rear;
        private int front;
        private int items;
        public Queue(int size)
        {
            maxSize = size;
            myQueue = new T[size];
            front = 0;
            rear = -1;
            items = 0;
        }
        public void Enqueue(T item)
        {
            if (isFull())
                WriteLine("Queue is full.");
            else
            {
                if (rear == maxSize - 1)
                    rear = -1;
                rear++;
                myQueue[rear] = item;
                items++;
            }
        }
        public T Dequeue()
        {
            T temp = myQueue[front];
            front++;
            if (front == maxSize)
            {
                front = 0;
            }

            return temp;
        }
        public T peekFront()
        {
            return myQueue[front];
        }
        override public string ToString()
        {
            string queue = string.Empty;
            queue += "[ ";
            for (int i = 0; i < myQueue.Length; i++)
            {
                queue += myQueue[i] +
                    ((i == myQueue.Length - 1) ?
                    "" : ", ");
            }
            queue += " ]";
            return queue;
        }
        public bool isEmpty() => items == 0;
        public bool isFull() => items == maxSize;
        public int Count() => items;
        public void Clear()
        {
            myQueue = new T[maxSize];
            front = 0;
            rear = -1;
            items = 0;
        }
        public bool Contains(T item)
        {
            foreach (T i in myQueue)
                if (i.Equals(item))
                    return true;
            return false;
        }
        public T[] ToArray()
        {
            return myQueue;
        }
        public void TrimExcess()
        {
            if (items / maxSize > .9)
                return;
            T[] newQueue = new T[items];
            for(var i = 0; i < items; i++)
            {
                newQueue.SetValue(myQueue[i], i);
            }
            maxSize = items;
            myQueue = newQueue;
        }
    }
}
