using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_1_2_1
{
    class Mathematics
    {
        public void even(int x)
        {
            if (x % 2 == 0)
            {
                Console.WriteLine(x);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Mathematics m = new Mathematics();
            m.even(10);
            m.even(5);
            m.even(12);
            //int x = 5;
            //if (x % 2 ==0)
            //{
            //    Console.WriteLine(x);
            //}

            //x = 10;
            //if (x % 2 == 0)
            //{
            //    Console.WriteLine(x);
            //}
        }
    }
}
