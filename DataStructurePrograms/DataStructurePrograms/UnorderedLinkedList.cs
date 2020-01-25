using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructurePrograms{
    class UnorderedLinkedList{
       public class Node{
             public Node next;
             public Object data;
            public Node(Object item){
                this.data = item;
                this.next = null;
            }
        }
        
        private Node head;
       public void Add(Object data){
            Node toAdd = new Node(data);
            if (head == null)
                head = toAdd;
            else{
                Node current = head;
                while (current.next != null){
                    current = current.next;
                }
                current.next = toAdd;
            }
        }
        public void AddFirst(Object data){
            Node toAdd = new Node(data);
            if (head == null)
                head = toAdd;
            else{
                Node tamp = head;
                head = toAdd;
                toAdd.next = tamp;
            }
        }
        public void AddLast(object data){
                   Add(data);
        }
        public void PrintNode(){
            if (head == null)
                Console.WriteLine("Linked list is empty");
            else{
                Node tamp = head;
                while (tamp!= null){
                    Console.Write(tamp.data);
                    if (tamp.next != null)
                        Console.Write("-->");
                    tamp = tamp.next;
                }
            }
            Console.WriteLine();
        }

        public void Remove(Object data) {
            if (head == null)
                Console.WriteLine("List is empty");
            Node tamp = this.head;
            if (tamp.data == data)
                head = tamp.next;
            else{
                while (tamp.next !=null){
                    if (tamp.next.data.Equals(data))
                    {
                        tamp.next = tamp.next.next;
                        break;
                    }
                    tamp = tamp.next;
                }
            }
        }

        public void Size(){
            int count = 0;
            Node tamp = head;
            while (tamp != null){
                count++;
                tamp = tamp.next;
            }
            Console.WriteLine(count);
        }

        public  bool Search(Object data) {
            Node temp = this.head;
            bool matched;
            while (!(matched = temp.data.Equals(data)) && temp.next != null){
                temp = temp.next;
            }
            return matched;
        }

        public void ToSearch(Object data){
            Console.WriteLine(Search(data));            
        }
        public void Empty(){
            this.head = null;
        }

        public void Index(Object data){
            if (head == null)
             Console.WriteLine("list is empty");
            int count = 0;
            Node tamp = head;
            while (tamp.next != null){
                if (tamp.data.Equals(data)){
                    Console.WriteLine(count);
                    break;
                }
                count++;
                tamp = tamp.next;
            }      
        }

        public void Reverse(){
            if (head == null)
                return;
            Node prev = null,
            current = this.head;
            Node next;
            while (current.next != null){
                next = current.next;
                current.next = prev;
                prev = current;
                current = next;
            }
            current.next = prev;
            head = current;
        }

        public void Insert(int index,Object data){
            int count = 0;
            Node AddIndex = new Node(data);
            if (head == null)
            {
                Console.WriteLine("List is empty and add given node is zero position");
                head = AddIndex;
            }
            else
            {
                Node tamp = head;
                while (null != tamp.next && index > count++)
                    tamp = tamp.next;
                AddIndex.next = tamp.next;
                tamp.next = AddIndex;
            }

        }
        public void Pop()
        {
            if (head == null)
                Console.WriteLine("list is empty");
            Node tamp = head;
            while (tamp.next.next != null)
            {
                tamp = tamp.next;
            }
            Console.WriteLine(tamp.next.data);
            tamp.next = null;
        }
        public void Pop(int index)
        {
            if (head == null)
                Console.WriteLine("list is empty");
            int count = 0;
            Node tamp = head;
            while (tamp.next != null && index > count++)
                tamp = tamp.next;
            Console.WriteLine(tamp.next.data);
            tamp.next = null;
            tamp.next = tamp.next.next;
        }
    }
}
