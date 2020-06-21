using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200621_계산기_만들어보기
{
    class Program
    {
        


        static void Main(string[] args)
        {
            
            Console.WriteLine("========================");
            Console.WriteLine("=====계산기프로그램=====");
            Console.WriteLine("=========1.덧셈=========");
            Console.WriteLine("=========2.뺄셈=========");
            Console.WriteLine("=========3.곱셈=========");
            Console.WriteLine("=========4.나눗셈=======");
            Console.WriteLine("=========5.종료=========");
            Console.WriteLine("========================");

            Console.WriteLine("메뉴를 입력하세요 : ");
            int iNUM = int.Parse(Console.ReadLine());
            Console.WriteLine("정수를 입력하세요 : ");
            int iNUM1 = int.Parse(Console.ReadLine());
            Console.WriteLine("두번째 정수를 입력하세요 : ");
            int iNUM2 = int.Parse(Console.ReadLine());
            

            if (iNUM == 1)
            {
                ADD(iNUM1, iNUM2);
                Console.WriteLine("정답은: " + ADD(iNUM1, iNUM2));
            }
            if (iNUM == 2)
            {
                SUB(iNUM1, iNUM2);
                Console.WriteLine("정답은: " + SUB(iNUM1, iNUM2));
            }
            if (iNUM == 3)
            {
                MUL(iNUM1, iNUM2);
                Console.WriteLine("정답은: " + MUL(iNUM1, iNUM2));
            }
            if (iNUM == 4)
            {
                DIV(iNUM1, iNUM2);
                Console.WriteLine("정답은: " + DIV(iNUM1, iNUM2));
            }

        }

        static int ADD(int add, int add1)
        {
            return add + add1;
        }
        static int SUB(int add, int add1)
        {
            return add - add1;
        }
        static int MUL(int add, int add1)
        {
            return add * add1;
        }
        static int DIV(int add, int add1)
        {
            return add / add1;
        }


    }
}
