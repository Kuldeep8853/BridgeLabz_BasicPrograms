using System;

namespace Oops.CommercialDataProcessing{
    public class StockLinkedList<T>{

       /// <summary>
       /// this is node class...
       /// </summary>
       /// <typeparam name="T"></typeparam>
        public class Node<T>
        {
            public T data;
            public Node<T> next;

            /// <summary>
            /// Custom Construre initialize the data value.....
            /// </summary>
            /// <typeparam name="T"></typeparam>
            public Node(T data)
            {
                this.data = data;
                next = null;
            }
        }

        /// <summary>
        /// head valiable privete accesses modifier..
        /// </summary>
        private Node<T> head;

        /// <summary>
        /// Add the data in linked list....
        /// </summary>
        /// <param name="data"></param>
        public void Add(T data)
        {
            Node<T> toAdd = new Node<T>(data);
            if (head == null) {
                head = toAdd;
            }
            else
            {
                Node<T> tamp = head;
                while (tamp.next != null)
                {
                    tamp = tamp.next;
                }
                tamp.next = toAdd;
            }
        }

        /// <summary>
        /// Remove the data from linked list.....
        /// </summary>
        /// <param name="data"></param>
        public void RemoveData( T data)
        {
            if (head == null)
            {
                Console.WriteLine("List is empty! ");
            }
            Node<T> tamp = head;
            if (tamp.data.Equals(data))
                head = tamp.next;
            else
            {
                while (tamp.next!=null)
                {
                    if (tamp.next.data.Equals(data))
                    {
                        tamp.next = tamp.next.next;
                        break;
                    }
                    tamp = tamp.next;
                   
                }

            }
        }

        /// <summary>
        /// Print the linked list data..... 
        /// </summary>
        public void PrintStock()
        {
            if (head == null)
                Console.WriteLine("stock list is empty");
            else
            {
                Node<T> tamp = head;
                Console.WriteLine("------------------------");
                while (tamp != null)
                {
                    Console.WriteLine(tamp.data);
                    Console.WriteLine("------------------------");
                    tamp = tamp.next;
                }
            }
        }

    }
}
