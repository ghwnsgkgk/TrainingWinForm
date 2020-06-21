using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _20200620_이것만_하고_집가쟈_힘들다
{
    class Program
    {
        static void Main(string[] args)
        {
            int Count = 5;
            while(Count > 0) //() 조건 동안에만 작동되도록 하는 구문 
            {
                Console.WriteLine(Count);
                Count--;
            }
            Console.WriteLine("================");

            for (int Count1 = 5; Count1 >0; Count1--) //둘다 똑같은 용도의 구문 if 문이 쪼금더 간결한 거잖아 
            {
                Console.WriteLine(Count1);
            }

            Console.WriteLine("단수를 입력해주세요 : ");
            int a = int.Parse(Console.ReadLine());
            int i;
            int m;

            for ( a = 2; a <= 9; a++)
            {


                for (i = 1; i <= 9; i++)
                {
                    m = a * i;
                    Console.WriteLine($"{a}*{i}={m}");


                }
                Console.WriteLine(); //구간 띄울려고 사용 된거구나 
            }
















        }
    }
}
