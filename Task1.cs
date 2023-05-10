using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generic_dz
{
    class Swap<T>
    {
        public static void swap(ref T a, ref T b) 
        {
            T temp = a;
            a = b;
            b = temp;
        }
    }

    internal class Task1
    {
        public static void task1()
        {
            int x = 1;
            int y = 2;
            Console.WriteLine("Before: x = {0}, y = {1}", x, y); // Before: x = 1, y = 2
            Swap<int>.swap(ref x, ref y);
            Console.WriteLine("After: x = {0}, y = {1}", x, y); // After: x = 2, y = 1

            string s1 = "hello";
            string s2 = "world";
            Console.WriteLine("Before: s1 = {0}, s2 = {1}", s1, s2); // Before: s1 = hello, s2 = world
            Swap<string>.swap(ref s1, ref s2);
            Console.WriteLine("After: s1 = {0}, s2 = {1}", s1, s2); // After: s1 = world, s2 = hello

        }
    }
}
