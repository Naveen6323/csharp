using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class Program
    {


        public static int fact(int n)
        {
            if (n == 0) return 1;
            return  n* fact(n - 1);
        }
        static void Main(string[] args)
        {
            //SingelyLinkedList ll = new SingelyLinkedList();
            //ll.AddFirst(1);
            //ll.AddLast(2);
            //ll.AddLast(1);
            //ll.AddMiddle(0,2);
            //ll.printLL();
            //ll.SizeOfLL();
            //ll.IterativeSearch(0);
            //Console.WriteLine(ll.RecursiveSearch(1));
            //ll.Reverse();
            //ll.DeleteNthNodeFromLast(2);
            //int[] nums = { 3, 5, 3 };
            //Console.WriteLine(nums.Contains(2));
            Stack stack  = new Stack();
            //stack.st.Push(1);
            //stack.st.Push(2);
            //stack.st.Push(3);
            //stack.PushAtbottom(4);
            //stack.print(stack.st);
            //Console.WriteLine(fact(4));
            int[] arr = { 6, 8, 2, 1, 3 };
            Console.WriteLine();
            arr.Contains(1);
            int s = 30;
            string p = Convert.ToString(s,2);
            //byte a = (Convert.ToByte(p));
            List<int> l = new List<int>();
            l.ToArray();
            //char[] ch = p.ToCharArray();
            //Console.WriteLine(string.Join(",",ch));
            //char c = '3';
            //Console.WriteLine(c-'0');

            ////Console.WriteLine(stack.nextGreater(arr));
            //Queue q = new Queue(5);
            //q.Enque(1);
            //q.Enque(2);
            //q.Enque(3);
            //q.Enque(3);
            //q.Enque(3);
            //q.Deque();
            //q.Deque();
            //q.print();

        }

        
    }
}
