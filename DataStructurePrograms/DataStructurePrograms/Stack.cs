using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructurePrograms{
   public class Stack{
        readonly Object[] stack = new Object[100];
        private static int top;

       public Stack()
        {
            top = -1;
        }
        public bool IsEmpty()
        {
            return (top < 0);
        }
        public void Push(Object data)
        {
            if (top == 99)
                Console.WriteLine("Stack is Overflow");
            else
                stack[++top] = data;
        }
        public void Pop()
        {
            if (top == -1)
                Console.WriteLine("stack is underflow");
            else
            {
                Object  value = stack[top--];
                Console.WriteLine(value);
            }
        }
        public void Size()
        {
            int count = 0;
            for (int i = 0; i <= top; i++)
                count++;
            Console.WriteLine("stack size is = "+count);
        }
       public void Peek()
        {
            if (top < 0)
            {
                Console.WriteLine("Stack Underflow");
                return;
            }
            else
                Console.WriteLine("The topmost element of Stack is : "+stack[top]);
        }
        public void PrintStack()
        {
            if (top < 0)
            {
                Console.WriteLine("Stack Underflow");
                return;
            }
            else
            {
                Console.WriteLine("Items in the Stack are :");
                for (int i = top; i >= 0; i--)
                {
                    Console.WriteLine(stack[i]);
                }
            }
        }
    }
}
