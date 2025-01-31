using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
namespace Collections
{
    public class Generics
    {
        public static void Compare<T>(T value1, T value2, T value3)where T : IComparable<T>
        {
            T max = value1.CompareTo(value2)>0?value1: value2;
            max = max.CompareTo(value3) > 0 ? max : value3;
            T min = value1.CompareTo(value2) > 0 ? value2 : value1;
            min = min.CompareTo(value3) > 0 ? value3 : min;
            Console.WriteLine("max : "+max);
            Console.WriteLine("min : " + min);
        }

        public static void Swap<T>( T a, T b)
        {
            Console.WriteLine("before swap: a:" + a + "\nb:" + b); 
            T temp = a;
            a = b;
            b = temp;
            Console.WriteLine("after swap: a:" + a + "\nb:" + b);


        }

        public Hashtable ht = new Hashtable();
        public Dictionary<string, int> d = new Dictionary<string, int>();

       


    }

    
}