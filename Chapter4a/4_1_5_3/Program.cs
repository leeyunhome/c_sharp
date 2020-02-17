using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_1_5_3
{
    class Person
    {
        static public Person President;  // = new Person("대통령");

        public string _name;

        public Person(string name)
        {
            _name = name;
            Console.WriteLine("ctor 실행");
        }

        static Person()
        {
            //President = new Person("부통령");
            Console.WriteLine("cctor 실행");

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
            Person person1 = new Person("");
            Console.WriteLine("----------------");
            //Person.President.DisplayName();

            Person person2 = new Person("");

        }
    }
}
