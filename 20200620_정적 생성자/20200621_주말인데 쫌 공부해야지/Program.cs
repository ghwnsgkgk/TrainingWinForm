using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200621_주말인데_쫌_공부해야지
{
    class Program
    {
        static void Main(string[] args)
        {
            int icommend;
            while(true)
            {
                Console.WriteLine("================");
                Console.WriteLine("======메뉴======");
                Console.WriteLine("=====1안녕======");
                Console.WriteLine("=====2헬로======");
                Console.WriteLine("=====3종료======");
                icommend = int.Parse(Console.ReadLine());
                if ((icommend < 1) || (icommend > 3))
                {
                    continue;
                }
                if (icommend == 1)
                {
                    Console.WriteLine("안녕");
                }
                else if (icommend == 2)
                {
                    Console.WriteLine("헬로");

                }
                else if (icommend == 3)
                {
                    Console.WriteLine("종료");
                }
                break;
            }
            
        }
    }
}
