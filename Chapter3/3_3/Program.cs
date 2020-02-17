using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //int sum = 0;
            //int n = 0;  // 초깃값이 0으로 변경됨
            //do
            //{
            //    if (n % 2 == 0) sum += n;
            //} while (++n <= 1000);

            //int sum = 0;
            //int n = 1;

            //while (n++ <= 1000)
            //{
            //    if (n % 2 != 0)
            //    {
            //        continue;
            //    }
            //    sum += n;

            //}

            // page 87
            //int sum = 0;
            //int n = 1;
            //while (n++ <= 1000)
            //{
            //    if ((n % 2) != 0) continue;
            //    if ((n % 3) != 0) continue;
            //    if ((n % 5) != 0) continue;

            //    sum += n;
            //}

            //    int sum = 0;
            //    int n = 0;

            //LOOP:
            //    n++;
            //    if (n > 1000)
            //    {
            //        goto LOOPEXIT;
            //    }

            //    if ((n % 2) != 0) goto LOOP;

            //    sum += n;
            //    goto LOOP;

            //LOOPEXIT:

            //    Console.WriteLine(sum);

            //bool exitLoop = false;

            //for (int x = 2; x < 10; x++)
            //{
            //    for (int y = 1; y < 10; y++)
            //    {
            //        Console.WriteLine(x + " * " + y + " = " + (x * y));

            //        exitLoop = x == 5 && y == 8;
            //        if (exitLoop == true)
            //        {
            //            break;
            //        }
            //    }

            //    if (exitLoop == true)
            //    {
            //        break;
            //    }
            //}


            //    for (int x = 2; x < 10; x++)
            //    {
            //        for (int y = 1; y < 10; ++y)
            //        {
            //            Console.WriteLine(x + " * " + y + " = " + (x * y));

            //            if (x == 5 && y == 8) goto LOOP_EXIT;
            //        }
            //    }

            //LOOP_EXIT:;

            int n = 1;
            int sum = 0;

            while (n < 1000)
            {
                if (n % 3 == 0 || n % 5 == 0)
                {
                    sum += n;
                }
                n++;
            }

            Console.WriteLine("Sum : " + sum);
        }
    }
}
