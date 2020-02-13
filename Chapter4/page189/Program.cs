﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace page189
{
    class Program
    {
        delegate void CalcDelegate(int x, int y);

        static void Add(int x, int y) { Console.WriteLine(x + y); }
        static void Subtract(int x, int y) { Console.WriteLine(x - y); }
        static void Multiply(int x, int y) { Console.WriteLine(x * y); }
        static void Divide(int x, int y) { Console.WriteLine(x / y); }
        static void Main(string[] args)
        {
            CalcDelegate calc = Add;
            calc += Subtract;
            calc += Multiply;
            calc += Divide;

            calc(10, 5);
        }
    }
}
