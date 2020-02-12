using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_1_5_2
{
    class Person
    {
        static int CountOfInstance; // private 정적 필드
        public string name;

        public Person(string _name)
        {
            CountOfInstance++;
            name = _name;
        }

        static public void OutputCount()    // public 정적 메서드
        {
            Console.WriteLine(CountOfInstance);//정적 메서드에서 정적 필드에 접근
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person.OutputCount();   // 클래스 이름으로 정적 메서드 호출

            Person person1 = new Person("이혜림");
            Person person2 = new Person("백유리");
            Person person3 = new Person("조은지");

            Person.OutputCount();   // 출력 결과: 2

            if (args.Length < 2)
                return;

            for (int i = 0; i < args.Length; ++i)
                Console.WriteLine(args[i]);

        }
    }
}
