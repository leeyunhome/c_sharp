using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_4
{
    class Person
    {
        static public int CountOfInstance;  // static 예약어로 정적 필드로 만듦
        public string _name;                // 인스턴스 필드

        public Person(string name)
        {
            CountOfInstance++;
            _name = name;
        }

        public void PrinteName()
        {
            Console.WriteLine("Name: " + _name);
        }

        static public void OutputCount()
        {
            Console.WriteLine(CountOfInstance);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person.OutputCount();

            Person person1 = new Person("혜림");

            Person person2 = new Person("유리");
            Person person3 = new Person("민지");
            Person person4 = new Person("민지");
            Person person5 = new Person("민지");
            //Console.WriteLine(Person.CountOfInstance);

            Person.OutputCount();

            //person.PrinteName();
            //Console.WriteLine(person._name);
        }
    }
}
