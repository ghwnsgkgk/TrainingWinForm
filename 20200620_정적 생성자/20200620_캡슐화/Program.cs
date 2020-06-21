using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200620_캡슐화
{
    class Cricle
    {
        double pi = 3.14;
        double GetArea(double radi)
        {
            return radi * radi * pi;
        }
        
        void Print1(double value)
        {
            
            Console.WriteLine(GetArea(value));
        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            double pi = 3.14;
            double GetAreaOfCircle(double radius)
            {
                
                return radius * radius * pi;
            }
            Console.WriteLine(GetAreaOfCircle(10)); //이렇게 써도 결과 같이 나오는걸  다시 Print 메서드를 통해서 캡슐화한다.

            void Print(double value)
            {
                Console.WriteLine(GetAreaOfCircle(value));
            }

          

            Print(10); // 캡슐화 !!
           

        }
    }
}
