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
        /// Remove top element from stack
        /// </summary>
        internal void Pop()
        {
            if (this.head == null)
            {
                Console.WriteLine("Stack is empty");
            }
            this.head = this.head.next;
        }
        /// <summary>
        /// show top element
        /// </summary>
        public void Peek()
        {
            if (this.head == null)
            {
                Console.WriteLine("Stack is empty");
            }
            else
            {
                Console.WriteLine("Peek element is :"+this.head.data);
            }
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
            if (temp == null)
            {
                Console.WriteLine("Stack is empty");
                return;
            }
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
            Console.WriteLine();
        }
        /// <summary>
        /// Peek and Pop till Stack not empty
        /// </summary>
        public void PeekPopTillEmpty()
        {
            Node temp = this.head;
            while (temp != null)
            {
                Peek();
                Pop();
                temp = temp.next;
            }
        }
    }
}
