using System;

namespace Collections
{
    public class Queue
    {
        static int[] arr;
        static int r;
        private static int size;

        public Queue(int n)
        {
            size = n;
            r = -1;
            arr = new int[n];
        }

        public bool IsEmpty()
        {
            return r == -1;
        }

        public void Enque(int data)
        {
            if (IsFull())
            {
                Console.WriteLine("queue is full");
                return;
            }

            arr[++r] = data;

        }

        public bool IsFull()
        {
            if (r == size-1) return true;
            return false;
        }

        public void Deque()
        {
            if (IsEmpty())
            {
                Console.WriteLine("queue is empty");
                return;
            }

            int f = arr[0];
            for (int i = 0; i < r; i++)
            {
                arr[i] = arr[i + 1];
            }

            Console.WriteLine("f : "+f);


        }

        public void print()
        {
            int temp=0;
            if (IsEmpty())
            {
                Console.WriteLine("que is empty");
                return;
            }
            while (temp<=r)
            {
                Console.Write(arr[temp++]+",");
            }

            Console.WriteLine();
        }

        public void Peek()
        {
            if (IsEmpty())
            {
                Console.WriteLine("queue is empty");
                return;
            }

            Console.WriteLine(arr[0]);
        }
    }
}