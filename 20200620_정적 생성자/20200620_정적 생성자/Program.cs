using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200620_정적_생성자
{class Person
    {
        static public Person President = new Person("대통령");
        public string _name;

        private Person(string name) // 생성자
        {
            _name = name;
            
        }

        static Person() //정적생성자 // 매개변수를 초기화 할 수 없다.
        {
            President = new Person("대통령"); // 정적 필드 초기화
        }
        public void DisplayName()
        {
            Console.WriteLine(_name);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person.President.DisplayName();
        }
    }
}
