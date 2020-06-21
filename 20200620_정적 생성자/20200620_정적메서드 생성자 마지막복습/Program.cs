using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200620_정적메서드_생성자_마지막복습
{
    class Person
    {
        public string _name;
        public Person(string name)
        {
            _name = name;
            Console.WriteLine("일반 생성자");
        }
        static Person()
        {
            Console.WriteLine("정적 생성자");
        }
        public Person()
        {
            Console.WriteLine("디폴트 생성자");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            Person person1 = new Person("이준호");
            
        }
    }
}
