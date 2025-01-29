using System;
using System.Collections.Generic;
using System.Linq;

namespace Collections
{
    public class Stack
    {
        public Stack<int> st = new Stack<int>();

        public void PushAtbottom(int data)
        {
            if (st.Count == 0)
            {
                st.Push(data);
                return;
            }

            int top = st.Pop();
            PushAtbottom(data);
            st.Push(top);
        }

        public void print(Stack<int> st)
        {
            if (st.Count == 0) return;
            Console.WriteLine(st.Pop());
            print(st);

        }

        public string nextGreater(int[] arr)
        {
            int[] nextgrater = new int[arr.Length];
            Stack<int> newstack = new Stack<int>();
            for (int i = arr.Length-1; i >=0; i--)
            {
                while (newstack.Count!=0 && newstack.Peek() <= arr[i])
                {
                    newstack.Pop();
                }

                if (newstack.Count == 0)
                {
                    newstack.Push(arr[i]);
                    nextgrater[i] = -1;
                }
                else
                {
                    nextgrater[i]= newstack.Peek();
                    newstack.Push(arr[i]);
                }

            }

            Console.WriteLine(string.Join(",",arr));
            return String.Join(",",nextgrater);
        }
    }
}