using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_5
{
    class Book
    {
        public string Title;
        public decimal ISBN13;
        public string Author;

        public Book(string title)
        {
            Title = title;
        }

        public Book(string title, decimal isbn13)
        {
            Title = title;
            ISBN13 = isbn13;
        }

        public Book(string title, decimal isbn13, string author)
        {
            Title = title;
            ISBN13 = isbn13;
            Author = author;
        }

        public void PrintBook()
        {
            Console.WriteLine(Title + " " + ISBN13 + " " + Author);
        }

        ~Book()
        {
            Console.WriteLine(Title + " 소멸자 호출");
        }
    }
    class Program
    {
        
        static void Main(string[] args)
        {
            Book gulliver = new Book("걸리버 여행기");
            Book hackleberry = new Book("허클베리 핀의 모험", 123131313313m);
            Book alice = new Book("이상한 나라의 섹스", 123131313377m, "Lewis Carroll");

            gulliver.PrintBook();
            hackleberry.PrintBook();
            alice.PrintBook();
        }
    }
}
