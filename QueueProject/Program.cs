namespace QueueProject
{
    using static System.Console;
    using static System.Collections.Queue;
    using System;

    class Program
    {
        static void Main()
        {
            IQueue<string> queue = new Queue<string>(15);
            queue.EnqueueAll(new string[] { "One", "Two", "Three" });
            WriteLine(queue);
            WriteLine(queue.isFull());
            queue.TrimExcess();
            WriteLine(queue);
            WriteLine(queue.isFull());
            try
            {
                queue.EnqueueAll(new string[] { "Four", "Five" });
            }
            catch (Exception exception)
            {
                WriteLine(exception.Message);
            }
        }
    }
}
