using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200620_공부하는_내용보다_잊어버리는_내용이_더_많네
{
    class Person
    {
        public string _name;
        public Person(string name)
        {
            _name = name;
        }

        public void OutPutYourName()
        {
            Console.WriteLine(_name);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("홍길동");
            person.OutPutYourName();

            Console.WriteLine(person._name); //생성된 객체에서 다시 변수를 불러오는건 가능한데 메서드는 안된다. 
        }

     
    }
}
