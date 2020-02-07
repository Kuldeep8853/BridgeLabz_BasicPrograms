using System;

namespace Oops.CommercialDataProcessing{

    /// <summary>
    /// stack class.......
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class StockStackList<T> {
        readonly T[] stack = new T[100];
        private static int top;

        /// <summary>
        /// Custom constructor initialize the top valiable......
        /// </summary>
        public StockStackList(){
            top = -1;
            }

        /// <summary>
        /// Push the data in stack....
        /// </summary>
        /// <param name="data"></param>
        public void Push(T data)
        {
            if (top == 99)
                Console.WriteLine("Stack is Overflow");
            else
                stack[++top] = data;
        }

        /// <summary>
        /// Print the stack data........
        /// </summary>
        public void PrintStack()
        {
            if (top < 0)
            {
                Console.WriteLine("Stack Underflow");
                return;
            }
            else
            {
                Console.WriteLine("Data in the Stack are :");
                Console.WriteLine("-----------------------");
                for (int i = top; i >= 0; i--)
                {
                    Console.WriteLine(stack[i]);
                    Console.WriteLine("-----------------------");
                }
            }
        }

    }
}
