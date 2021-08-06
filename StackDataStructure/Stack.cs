using System;
using System.Collections.Generic;
using System.Text;

namespace StackDataStructure
{
    class Stack
    {
        internal Node head;
        /// <summary>
        /// Add new data to stack
        /// </summary>
        /// <param name="data"></param>
        internal void Push(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = this.head;
                head = node;
                head.next = temp;
            }
            Console.WriteLine("{0} inserted", node.data);
        }
        /// <summary>
        /// Check stack is empty or not
        /// </summary>
        public void IsEmpty()
        {
            if (this.head == null)
                Console.WriteLine("Stack is empty");
            else
                Console.WriteLine("Stack is not empty");
        }
        /// <summary>
        /// Show all elements of stack
        /// </summary>
        internal void ShowStack()
        {
            Node temp = this.head;
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
            Console.WriteLine();
        }
    }
}
