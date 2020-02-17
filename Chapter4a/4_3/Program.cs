using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_3
{
    class Mathematics
    {
        public void PrintIfEven(int value)
        {
            if (value % 2 == 0)
            {
                Console.WriteLine(value);
            }
        }
        public int GetAreaOfSquare(int x)
        {
            return x * x;
        }

        public int GetValue()   // 매개변수는 없고 값만 반환
        {
            return 10;
        }

        public void Output(string prefix, int value)
        {
            Console.WriteLine(prefix + value);
        }
    }

    class Person
    {
        string name;

        public Person()
        {
            name = "홍길동";
            Console.WriteLine("생성자 호출");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("person 객체 생성되기 전.");
            Person person = new Person();
            Console.WriteLine("person 객체 생성된 후.");
            //Mathematics m = new Mathematics();
            ////int result = m.GetAreaOfSquare(m.GetValue());

            ////m.Output("결과: ", result);
            //int x = 5;
            //m.PrintIfEven(x);
            //x = 10;
            //m.PrintIfEven(x);
        }
    }
}
