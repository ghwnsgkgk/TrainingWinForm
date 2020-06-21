using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _20200621_소수구하기__
{
    class Program
    {
        static void Main(string[] args)
        {
            int count =0;
            int inum;
            int inum2;
            for ( inum = 2; inum < 100; inum++) //inum이 100 이 되기 전까지 1씩 반복된다는 걸 보여주고 
            {
                for ( inum2 = 2; inum2 < inum; inum2++) //inum 과 inum2 가 같아 질 수 없다는 걸 보여주는 거고
                {
                    if(inum % inum2 == 0) // inum을 inum2로 나누었을 때 나누어 떨어지는 거는 소수가 아니기에 작동에 브레이크를 걸어줬고
                    {
                        break; //이경우는 탈출 코딩이 안되도록 만들기
                    }

                }
            
                if(inum == inum2) // 위의 포문을 나와서 inum 과 inum2가 다를때 나누어 떨어지는 경우를 제외하고 나서의 inum과 inum2가 같아지는 상황을 출력면 끝
                {
                    Console.Write(" " + inum2); //이거는 단순히 숫자 사이의 간격을 띄우기위해서
                    count++;
                }
     
            }

            Console.WriteLine("소수의 갯수는 {0}", count);

        }
    }
}
