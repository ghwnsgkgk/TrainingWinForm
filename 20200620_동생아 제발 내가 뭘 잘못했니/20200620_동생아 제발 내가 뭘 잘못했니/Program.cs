using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200620_동생아_제발_내가_뭘_잘못했니
{ class Person
    {
        static public int CountOfInstance; //정적 인스턴스
        public string _name;

        public Person(string name)
        {
            _name = name;
            CountOfInstance++;
        }
        static public void OutPutCount() //정적 메소드
        {
            Console.WriteLine(CountOfInstance);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person.OutPutCount();
            Person person = new Person("홍길동");
            Person person1 = new Person("홍길순");
            Person.OutPutCount();
        }
    }
}
