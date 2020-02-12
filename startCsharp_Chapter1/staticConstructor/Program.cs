using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Person
{
    public string name;

    public Person(string _name)
    {
        name = _name;
        Console.WriteLine("ctor 실행");
    }

    static Person()
    {
        Console.WriteLine("cctor 실행");
    }
}

namespace staticConstructor
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("");
            Console.WriteLine("------------");
            Person person2 = new Person("");
        }
    }
}
