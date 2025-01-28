using System;
using System.Data.SqlTypes;
using System.Runtime.Remoting.Messaging;

namespace Collections
{
    public class SingelyLinkedList
    {

        public static Node head;
        public static Node tail;

        public class Node
        {
            public int data;
            public Node next;

            public Node(int data)
            {
                this.data = data;
                this.next = null;
            }

        }
        public void AddFirst(int data)
        {
            Node newNode = new Node(data);
            if (head == null)
            {
                head =tail= newNode;
                return;
            }

            newNode.next = head;
            head = newNode;
        }

        // if tail is not used
        //public void AddLast(int data)
        //{
        //    Node newNode = new Node(data);
        //    Node temp = head;
        //    while (temp.next != null)
        //    {
        //        temp = temp.next;
        //    }

        //    tail.next = newNode;
        //    tail = newNode;
        //}
        

        //--if tail is used
        public void AddLast(int data)
        {
            Node newNode = new Node(data);
            if (head == null)
            {
                head = tail = newNode;
                return;
            }

            tail.next = newNode;
            tail = newNode;
        }

        public void printLL()
        {
            Node temp = head;
            while (temp != null)
            {
                Console.Write(temp.data+"->");
                temp = temp.next;
            }

            Console.WriteLine("null");
        }

        public void PrintEndPoints()
        {
            Console.WriteLine("head->"+head.data);
            Console.WriteLine("tail->"+tail.data);
        }

        public void AddMiddle(int data, int idx)
        {
            Node newNode = new Node(data);
            if (head == null||idx==0)
            {
                AddFirst(data);
                return;
            }

            
            Node temp = head;
            int i = 0;
            while (i<idx-1)
            {
                if (temp.next == null) break;
                temp = temp.next;
                i++;
            }

            newNode.next = temp.next;
            temp.next = newNode;

        }

        public int SizeOfLL()
        {
            Node temp = head;
            int size = 0;
            while (temp != null)
            {
                temp = temp.next;
                size++;
            }

            Console.WriteLine("size = "+size);
            return size;

        }

        public void RemoveFirst()
        {
            if (head == null)
            {
                Console.WriteLine("ll is empty");
                return;
            }

            head = head.next;
            printLL();
        }
        public void RemoveLast()
        {

            if (head == null)
            {
                Console.WriteLine("ll is empty");
                return;
            }
            Node temp = head;
            while (temp.next.next != null)
            {
                temp = temp.next;
            }

            tail = temp;
            tail.next = null;
            printLL();

        }
        //iterative search on linkedlist
        public void IterativeSearch(int key)
        {
            Node temp = head;
            int i = 0;
            while (temp != null)
            {
                if (temp.data == key)
                {
                    Console.WriteLine("found at "+i);
                    return;
                }

                i++;

                temp = temp.next;
            }

            Console.WriteLine("not found");

        }

        public int helper(Node head, int key)
        {
            if (head == null) return -1;
            if (head.data == key) return 0;
            int idx = helper(head.next, key);
            if (idx == -1) return -1;
            return idx + 1;
        }
        public int RecursiveSearch(int key)
        {
            return helper(head, key);
        }

        public void Reverse()
        {
            Node prev = null;
            Node curr =tail= head;
            Node next;
            while (curr != null)
            {
                next = curr.next;
                curr.next = prev;
                prev = curr;
                curr = next;
            }

            head = prev;
            printLL();
            
        }
        public void DeleteNthNodeFromLast(int idx)
        {
            int i = SizeOfLL() - idx;
            Node temp = head;
            while (i > 1)
            {
                temp = temp.next;
                i--;
            }

            temp.next = temp.next.next;
            printLL();
        }

    }
    

    


}