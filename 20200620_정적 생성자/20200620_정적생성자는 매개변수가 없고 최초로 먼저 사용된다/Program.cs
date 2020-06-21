using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200620_정적생성자는_매개변수가_없고_최초로_먼저_사용된다
{
    class Person
    {
        public string _name;

        public Person(string name) //객체 생성을 해줘야 호출이 가능하다.
        {
            _name = name;
            Console.WriteLine("ctor실행"); //이상태로는 name변수를 뽑아내지 못하고 생성자 안에 저장만 가능하다 
        }
        static Person() //정적 생성자는 개발자의 객체 생성과 상관 없이 무조건 호출이 된다.
        {
            Console.WriteLine("cctor실행");
        }

        public Person() // 디폴트 생성자로 단순히 31번 개체와 연결이 되어있지만 아무것도 없어서 진행되지않는다 
        {
        }
    }
    class Program
    {
        

        static void Main(string[] args)
        {
            Person person = new Person(); //디폴트 상태  // 첫번째 Person 생성자와는 연결이 안되는 거지 이상태는 
            Person person1 = new Person("이준호"); // 지금상태가 첫번째 Person 생성자와 연결이 된다.string 값을 넣어줬으니까 
            
            Console.WriteLine("====================");
            
        }
    }
}
