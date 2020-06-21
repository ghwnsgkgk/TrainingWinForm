using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace _20200621_다항_배열_공부
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[2, 3] { { 1, 2, 3, }, { 4, 5, 6, } };
            Console.WriteLine("array.GetLength(0)     : " + array.GetLength(0));
            Console.WriteLine("array.GetLength(1)     : " + array.GetLength(1));
            Console.WriteLine("array.GetUpperBound(0) : " + array.GetUpperBound(0));
            Console.WriteLine("array.GetUpperBound(0) : " + array.GetUpperBound(1));
            Console.WriteLine("Length " + array.Length);
            Console.WriteLine("=====================================================");

            Console.WriteLine("Reverse Test : 1,2,3,4,5,6 뒤집기 ");
            int[] array1 = new int[6] { 1, 2, 3, 4, 5, 6 };
            Array.Reverse(array1);
            foreach (int item in array1)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine(" ");
            Console.WriteLine("Sort Test : 7,200,2,65,84,11 뒤집기 ");

            int[] array2 = new int[6] { 7,200,2,65,84,11 };
            Array.Sort(array2);
            foreach (int item in array2)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine("Sort Test : 7,200,2,65,84,11 뒤집기 ");

            int result = Array.BinarySearch(array2, 11);
            Console.WriteLine("BinarySearch " + result);
            

























        }
    }
}
