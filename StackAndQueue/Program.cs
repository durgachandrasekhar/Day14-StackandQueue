using System;

namespace StackAndQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            //Display Welcome Message
            Console.WriteLine("Welcome to Stack and Queue !");
            Console.WriteLine("----------------------------");

            
            LinkedListQueue linkedListQueue = new LinkedListQueue();
            linkedListQueue.Enqueue(56);
            linkedListQueue.Enqueue(30);
            linkedListQueue.Enqueue(70);
            Console.WriteLine("----------------");

            //Display Queue
            linkedListQueue.Display();
        }
    }
}