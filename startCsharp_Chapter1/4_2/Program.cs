using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_2
{
    class Mathmatics
    {
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
    class Program
    {
        static void Main(string[] args)
        {
            Mathmatics math = new Mathmatics();
            Console.WriteLine(math.GetAreaOfSquare(3));
            Console.WriteLine(math.GetValue());
            math.Output("fruit", 1);
        }
    }
}
