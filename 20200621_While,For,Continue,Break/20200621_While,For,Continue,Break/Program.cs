using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200621_While_For_Continue_Break
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 1; 
            int sum = 0;
            while (true)
            {
                while (n < 1000)
                {
                    if (n % 3 == 0 || n % 5 == 0)
                    {
                        sum = sum + n;
                    }
                    n++;

                }
                
                Console.WriteLine(sum);
            }

        }
    }
}
