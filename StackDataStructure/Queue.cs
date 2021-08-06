using System;
using System.Collections.Generic;
using System.Text;

namespace StackDataStructure
{
    class Queue
    {
        Node head;
        internal void Dequeue()
        {
            if (this.head == null)
            {
                Console.WriteLine("Queue is empty");
            }
            else
            {
                while (this.head != null)
                {
                    Console.WriteLine("Value Dequ is {0}" + this.head.data);
                    this.head = this.head.next;
                }
            }
        }
        internal void Enqueue(int data)
        {
            Node node = new Node(data);
            if (head == null)
            {
                head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
                Console.WriteLine("{0} inserted into queue", node.data);
            }
        }
        internal void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Queue is empty");
                return;
            }
            while (temp != null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.next;
            }
        }
    }
}
