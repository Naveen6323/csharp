using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Collections.Generics;

namespace Collections
{
    public class student
    {
        protected int rollno { get; set; }
        protected string name { get; set; }
        private List<student> l = new List<student>();


        public void display()
        {
            foreach (var st in l)
            {
                Console.WriteLine(st.name + "," + st.rollno);
            }
        }

        public void add(string na, int roll)
        {
            student s = new student
            {
                rollno = roll,
                name = na
            };
            l.Add(s);
        }
    }


    internal class Program : student
        {

            public int fact(int n)
            {
                if (n == 0 || n == 1) return 1;
                return n * fact(n - 1);
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
                Stack stack = new Stack();
                //stack.st.Push(1);
                //stack.st.Push(2);
                //stack.st.Push(3);
                //stack.PushAtbottom(4);
                //stack.print(stack.st);
                //Console.WriteLine(fact
                Generics g = new Generics();
                g.ht.Add("a", 1);
                g.d.Add("a", 1);
                g.d.Add("b", 1);
                if (g.d.ContainsKey("b"))
                {
                    g.d["b"] += 1;
                }


                //foreach (KeyValuePair<string,int> dict in g.d)
                //{
                //    Console.WriteLine("key:"+dict.Key+",value:"+dict.Value);
                //}
                //Console.WriteLine();
                //arr.Contains(1);
                //int s = 30;
                //string p = Convert.ToString(s,2);
                ////byte a = (Convert.ToByte(p));
                //List<int> l = new List<int>();
                //l.ToArray();
                //int a = 1;
                //Generics.Compare('c','a','g');

                //SortedList s = new SortedList();
                //s.Add("naveen",3);
                //s.Add("navee",2);
                //foreach (DictionaryEntry st in s)
                //{
                //    Console.WriteLine(st.Key+","+st.Value);
                //}


                //List<List<int>> l = new List<List<int>>();
                //l.Add(new List<int>{1,2,3});
                //l.Add(new List<int> { 1, 2, 3 });

                //foreach (var innerList in l)
                //{
                //    Console.WriteLine(string.Join(", ", innerList));


                //string p =
                //Generics.Swap(20,11);

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
                
                student studentList = new student();
                studentList.add("navee",98);
                studentList.display();
                

            }


        }
    
}