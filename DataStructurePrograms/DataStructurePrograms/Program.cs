using System;
using System.Collections.Generic;

namespace DataStructurePrograms
{
    class Program
    {
       public static void Main()
        {
            Console.WriteLine("Enter the choice");
            Console.WriteLine("List1. unordered linked list implementation.");
            Console.WriteLine("List2. ordered linked list implementation.");
            Console.WriteLine("stack. Stack implementation.");
            Console.WriteLine("Param. Check parentheses is balaned or not.");
            Console.WriteLine("queue. Implemetation of queue.");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "List1":
                    {
                        UnorderedLinkedList ll = new UnorderedLinkedList();
                        ll.Add(3);
                        ll.Add(65);
                        ll.Add(76);
                        ll.Add(75);
                        ll.Add(58);
                        ll.Add(585);
                        ll.Add(575);
                        ll.Add("Kuldeep");
                        ll.Add("Kasaudhan");
                        ll.Size();
                        ll.PrintNode();
                        ll.AddLast(34);
                        ll.AddLast(30);
                        ll.AddFirst(2);
                        ll.AddFirst(1);
                        ll.PrintNode();
                        ll.Size();
                        ll.ToSearch(75);
                        ll.ToSearch("Kuldeep");
                        ll.ToSearch(100);
                        ll.ToSearch("asdfgh");
                        ll.Remove(2);
                        ll.PrintNode();
                        ll.Index(2);
                        ll.Index("Kuldeep");
                        ll.Reverse();
                        ll.PrintNode();
                        ll.Index(2);
                        ll.Insert(4, 79);
                        ll.PrintNode();
                        ll.Size();
                        ll.Pop();
                        ll.Pop();
                        ll.PrintNode();
                        ll.Pop();
                        ll.PrintNode();
                        ll.Pop();
                        ll.PrintNode();
                        ll.Pop();
                        ll.PrintNode();
                        ll.Pop();
                        ll.PrintNode();
                        ll.Pop();
                        ll.PrintNode();
                        break;

                    }
                case "List2":
                    {
                        break;

                    }
                case "stack":
                    {
                        Stack st = new Stack();
                        st.Push(1);
                        st.Push(2);
                        st.Push(3);
                        st.Push(4);
                        st.Push(5);
                        st.Push(6);
                        st.Push(7);
                        st.Push(8);
                        st.Push(9);
                        st.Push(10);
                        st.PrintStack();
                        st.Size();
                        st.Peek();
                        st.Pop();
                        st.PrintStack();
                        break;

                    }
                case "Param":
                    {
                        BalancedParentheses bl = new BalancedParentheses();
                        Console.WriteLine("Enter the Expression.");
                        string exp = Console.ReadLine();
                        char[] exp1 = exp.ToCharArray();
                        if (bl.Parentheses(exp1))
                            Console.WriteLine("Balanced parentheses");
                        else
                            Console.WriteLine("Unbalanced parentheses");
                        break;

                    }
                case "queue":
                    {
                        Console.WriteLine("Enter the queue capacity ");
                        int capacity = Convert.ToInt32(Console.ReadLine());
                        Queue qu = new Queue(capacity);
                        qu.PrintQueue();
                        qu.Enqueue(1);
                        qu.Enqueue(2);
                        qu.Enqueue(3);
                        qu.Enqueue(4);
                        qu.PrintQueue();
                        qu.Dequeue();
                        qu.PrintQueue();
                        qu.Dequeue();
                        qu.PrintQueue();
                        qu.Enqueue(19);
                        qu.Enqueue(10);
                        qu.Enqueue(9);
                        qu.Enqueue(4);
                        qu.Enqueue(56);
                        qu.Enqueue(8);
                        qu.Enqueue(15);
                        qu.PrintQueue();
                        break;
                    }
                case "Bank":
                    {
                        Console.WriteLine("Enter the number of Custmors ");
                        int capacity = Convert.ToInt32(Console.ReadLine());
                        Queue casier = new Queue(capacity);
                        for (int i = 1; i <= capacity; i++)
                        {
                            Console.WriteLine("Enter the custmor name, Activity, Account number and Amount ");
                            string name = Console.ReadLine();
                            string activity = Console.ReadLine();
                            long AccNum = Convert.ToInt64(Console.ReadLine());
                            int Amount = Convert.ToInt32(Console.ReadLine());
                            BankCustmor bank = new BankCustmor(name, activity, AccNum, Amount);                           
                            casier.Enqueue(new BankCustmor(name, activity, AccNum, Amount));
                        }
                        casier.PrintQueue();
                        break;

                    }
                default:
                    {
                        Console.WriteLine("Enter the right choice.");
                        break;
                    }
            }
           
        }
    }
}
