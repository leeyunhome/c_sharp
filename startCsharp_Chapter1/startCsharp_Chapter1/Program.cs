using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace startCsharp_Chapter1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 1, sum = 0;

            while (n < 1000)
            {
                if (n % 3 == 0 || n % 5 == 0)
                {
                    sum += n;
                }
                n += 1;
            }

            Console.WriteLine(sum);
        }
    }
}
