using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_7
{
    class Person
    {
        static public Person President = new Person("대통령");    //public 정적 필드
        string name;

        private Person(string _name)
        {
            name = _name;
        }

        public void DisplayName()
        {
            Console.WriteLine(name);
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
