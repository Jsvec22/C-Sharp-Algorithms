namespace QueueProject
{
    using static System.Console;
    using static System.Collections.Queue;
    class Program
    {
        static void Main()
        {
            IQueue<string> queue = new Queue<string>(15);
            queue.Enqueue("One");
            queue.Enqueue("Two");
            WriteLine(queue.Count());
            WriteLine(queue.isFull());
            WriteLine(queue);
            queue.TrimExcess();
            WriteLine(queue.Count());
            WriteLine(queue);
            WriteLine(queue.isFull());
            queue.Enqueue("Three");
        }
    }
}
