using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Book
{
    decimal isbn13;
    string title;
    string contents;

    public Book(decimal isbn13, string title, string contents)
    {
        this.isbn13 = isbn13;
        this.title = title;
        this.contents = contents;
    }

    public override bool Equals(object obj)
    {
        if (obj == null)
        {
            return false;
        }

        Book book = obj as Book;

        if(book == null)
        {
            return false;
        }
        return this.isbn13 == book.isbn13;
    }

    public override int GetHashCode()
    {
        return this.isbn13.GetHashCode();
    }
}
namespace _4_19
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book(978998, "일잘하는 평사원의 업무자동화", ".....");
            Book book2 = new Book(978998, "일잘하는 평사원의 업무자동화", ".....");
            Book book3 = new Book(9789409, "파이썬 3.6 프로그래밍", ".....");

            Console.WriteLine("book1 == book2: " + book1.Equals(book2));
            Console.WriteLine("book1 == book3: " + book1.Equals(book3));
        }
    }
}
