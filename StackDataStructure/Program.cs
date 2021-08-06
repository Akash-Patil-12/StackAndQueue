using System;

namespace StackDataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();
            stack.Push(70); 
            stack.Push(30);
            stack.Push(56);
            Console.WriteLine("After Add stack is :");
            stack.ShowStack();
            stack.PeekPopTillEmpty();
            Console.WriteLine("After Pop stack is :");
            stack.ShowStack();
        }
    }
}
