using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200621배열_공부
{
    class Program
    {
       
        
        static void Main(string[] args)
        {
            int[] imoney = new int[20];
            //imoney[0] = 1004;
            //imoney[1] = 1004;
            //imoney[2] = 1004;
            //imoney[3] = 1004;
            int icount = 0;
            icount++;
            imoney[icount] = 1000 + icount * 4;
            /* for ( icount = 0; icount < 20; icount++)
             {
                 imoney[icount] = 1000 + icount * 4;

             Console.WriteLine(imoney[icount]);

             }*/
            foreach (int item in imoney)
            {
                
                
                Console.WriteLine(item);

            }


        }
    }
}
