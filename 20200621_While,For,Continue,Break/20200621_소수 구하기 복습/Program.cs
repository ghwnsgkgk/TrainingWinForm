using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200621_소수_구하기_복습
{
    class Program
    {
        static void Main(string[] args)
        {
            int inum;
            int inum2;
            int count = 0;

            for ( inum = 2; inum < 100; inum++)
            {
                for ( inum2 = 2; inum2 < inum; inum2++)
                {
                    if (inum % inum2 == 0)
                    {
                        break;
                    }
                }

                if (inum == inum2)
                {
                    Console.Write(" " + inum2);
                }



            }
            Console.WriteLine($"소수의 총갯수는 : {count} ");

        }
    }
}
