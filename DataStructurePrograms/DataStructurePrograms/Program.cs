using System;

namespace DataStructurePrograms
{
    class Program
    {
       public static void Main()
        {
            Console.WriteLine("Enter the choice");
            Console.WriteLine("UnorderedList. print the unordered linked list.");
            Console.WriteLine("orderedList. print the ordered linked list.");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "UnorderedList":
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
                        break;

                    }
                case "orderedList":
                    {
                        break;

                    }
            }
           
        }
    }
}
