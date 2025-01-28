using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class Program
    {
        


        static void Main(string[] args)
        {
            SingelyLinkedList ll = new SingelyLinkedList();
            ll.AddFirst(1);
            ll.AddLast(2);
            ll.AddLast(1);
            ll.AddMiddle(0,2);
            ll.printLL();
            ll.SizeOfLL();
            //ll.IterativeSearch(0);
            //Console.WriteLine(ll.RecursiveSearch(1));
            //ll.Reverse();
            //ll.DeleteNthNodeFromLast(2);
            int[] nums = { 3, 5, 3 };
            Console.WriteLine(nums.Contains(2));
            ;
        }

        
    }
}
