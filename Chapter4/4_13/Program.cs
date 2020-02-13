using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Book
{
    decimal _isbn;

    public Book(decimal isbn)
    {
        _isbn = isbn;
    }
}

namespace _4_13
{
    class Program
    {
        static void Main(string[] args)
        {

            //short n1 = 256;
            //short n2 = 32750;
            //short n3 = 256;

            //Console.WriteLine(n1.GetHashCode());
            //Console.WriteLine(n2.GetHashCode());
            //Console.WriteLine(n3.GetHashCode());

            //Book book1 = new Book(97889981);
            //Book book2 = new Book(97889981);

            //Console.WriteLine(book1.GetHashCode());
            //Console.WriteLine(book2.GetHashCode());

            //int n4 = 256;
            //int n5 = 2147483647;

            //Console.WriteLine(n4.GetHashCode());
            //Console.WriteLine(n5.GetHashCode());

            //string txt1 = new string(new char[] { 't', 'e', 'x', 't' });
            //string txt2 = new string(new char[] { 't', 'e', 'x', 't' });

            //Console.WriteLine(txt1.Equals(txt2));   // 출력 결과: True

            //Book book1 = new Book(9788998);
            //Book book2 = new Book(9788998);

            //Console.WriteLine(book1.Equals(book2));
        }
    }
}
