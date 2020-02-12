using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    class Person
    {
        static public int CountOfInstance;
        string name;

        public Person()
        {
            name = "홍길동";
            Console.WriteLine("생성자 호출");
        }
        public Person(string in_name)
        {
            CountOfInstance++;
            name = in_name;
        }
        ~Person()
        {
            Console.WriteLine(name + "소멸자 호출");
        }

        public string getName()
        {
            return name;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Person p1 = new Person();
            Person p2 = new Person("이혜림");
            Person p3 = new Person("백유리");
            Person p4 = new Person("조은지");
            Console.WriteLine(Person.CountOfInstance);

            //Console.WriteLine(p1.getName());
            //Console.WriteLine(p2.getName());


        }
    }
}
