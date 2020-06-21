using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200620_초심으로_돌아가서_다시_개념_잡기
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("person 객체가 생성되기전");
            Person person = new Person("영희"); //여기에서 영희라는 이름이 _name으로 저장된다.(Person) 생성자가 실행되면서 person이라는 객체가 생성됨 
            person.WriteName(); //그 객체를 통해서 매서드를 실행할 수 있다. 
            Console.WriteLine("person 객체가 생성된 후");
        }
    }

    class Person
    {
        string _name;
        public Person(string name) //이건 생성자
        {
            _name = name;
            
        }

        public void WriteName() // 이건 메서드
        {
            Console.WriteLine("NAME : " + _name);
        }






    }

   




    
}
