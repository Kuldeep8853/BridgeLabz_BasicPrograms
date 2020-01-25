using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructurePrograms{
   public class Queue{
        private static int front, rear, capacity;
        private static Object[] queue;
        public Queue(int c)
        {
            capacity = c;
            front = rear = 0;
            queue = new Object[capacity];
        }
        public void Enqueue(Object  data)
        {
            if (capacity == rear)
            {
                Console.WriteLine("Queue is full");
            }
            else
            {
                queue[rear] = data;
                rear++;
            }
        }
        public void Dequeue()
        {
            if(front ==rear)
                Console.WriteLine("Queue is empty");
            else
            {
                Console.WriteLine(queue[front++]);
            }
        }
        public void PrintQueue()
        {
            if (rear == front)
                Console.WriteLine("Queue is empty");
            else{
                for (int i = front; i < rear; i++)
                    Console.Write(queue[i]+ "<--");
            }
            Console.WriteLine();
        }
    }
}
