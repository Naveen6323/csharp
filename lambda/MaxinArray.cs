using System;

namespace lambda
{
    public class MaxinArray
    {
        public static void MaxInArray<T>(T[] array) where T : IComparable
        {
            T el = array[0];
            foreach (T val in array)
            {
                if (val.CompareTo(el) > 0) el = val;
            }

            Console.WriteLine($"Max element in array is {el}");
        }
    }
}