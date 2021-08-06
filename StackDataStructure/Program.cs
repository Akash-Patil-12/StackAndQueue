using System;

namespace StackDataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue queue = new Queue();
            queue.Enqueue(56);
            queue.Enqueue(30);
            queue.Enqueue(70);
            Console.WriteLine("Queue is :");
            queue.Show();
            Console.WriteLine("Dequeue element is :"+queue.Dequeue());
            Console.WriteLine("After Dequeue Queue is :");
            queue.Show();
            if (queue.IsEmpty())
            {
                Console.WriteLine("Queue is empty");
            }
            else
            {
                Console.WriteLine("Queue is not empty");
            }
            if (queue.Size() == 0)
                Console.WriteLine("Queue is empty");
            else
                Console.WriteLine("Queue size is :"+queue.Size());
        }
    }
}
