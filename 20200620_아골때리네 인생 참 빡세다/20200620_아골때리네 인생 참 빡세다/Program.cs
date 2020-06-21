using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200620_아골때리네_인생_참_빡세다
{
    class Person
    {
        static public int CountOfInstance; // static 예약어로 정적 필드로 만듦
        public string _name;
        public Person(string name)
        {
            CountOfInstance++;
            _name = name;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Person.CountOfInstance);

            Person person = new Person("홍길동");
            Console.WriteLine(Person.CountOfInstance);
            Person person1 = new Person("홍길수");
            Console.WriteLine(Person.CountOfInstance);

        }
    }
}
