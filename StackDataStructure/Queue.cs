using System;
using System.Collections.Generic;
using System.Text;

namespace StackDataStructure
{
    class Queue
    {
        Node head;
        /// <summary>
        /// Remove last element 
        /// </summary>
        /// <returns></returns>
        internal int Dequeue()
        {
            int number=0;
            if (this.head == null)
            {
                return 0;
            }
            else
            {
                while (this.head != null)
                {
                    number = this.head.data;
                    this.head = this.head.next;
                    return number;
                }
            }
            return number;
        }
        /// <summary>
        /// Insert new element
        /// </summary>
        /// <param name="data"></param>
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
        /// <summary>
        /// Show list of all Queue element
        /// </summary>
        internal void Show()
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
        /// <summary>
        /// Check queue is empty or not
        /// </summary>
        /// <returns></returns>
        public bool IsEmpty()
        {
            Node temp = this.head;
            if (temp == null)
                return true;
            return false;
        }
        /// <summary>
        /// return size of queue
        /// </summary>
        /// <returns></returns>
        public int Size()
        {
            int count = 0;
            Node temp = this.head;
            while (temp != null)
            {
                count++;
                temp = temp.next;
            }
            return count;
        }
    }
}
