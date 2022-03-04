using System;

namespace PP02
{
    internal class Program
    {
        static void Main(string[] args)
        {
           LinkedListQueue linkedListQueue = new LinkedListQueue();
            linkedListQueue.enqueue(56);
            linkedListQueue.enqueue(30);
            linkedListQueue.enqueue(70);
            linkedListQueue.Display();
            linkedListQueue.Dequeue();
            linkedListQueue.Display();
        }
    }
}