using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200620_클래스의_인스턴스를_단_하나만_만드는_예제
{ class Person
    {
        static public Person President = new Person("대통령");
        string _name;
        public Person(string name)
        {
            _name = name;
        }

        public void Displays()
        {
            Console.WriteLine(_name);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Person.President.Displays();
            Person.person = new Person();
        }
    }
}
