using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4a
{
    class Program
    {
        static void Main(string[] args)
        {
            Book gulliver = new Book();

            gulliver.Author = "Jonathan Swift";
            gulliver.ISBN13 = 9788983920775;
            gulliver.Title = "걸리버 여행기";
            gulliver.Contents = "...";
            gulliver.PageCount = 384;

            string author = gulliver.Author;
            decimal isbn13 = gulliver.ISBN13;
            string title = gulliver.Title;
            string contents = gulliver.Contents;
            int pageCount = gulliver.PageCount;

            if (args.Length < 2)
            {
                return;
            }
            Console.WriteLine(args[0]);
            Console.WriteLine(args[1]);
            Console.WriteLine(args[2]);            
            Console.WriteLine(args[3]);
            //return 1004;
        }
    }

    class Book
    {
        public string Title;
        public decimal ISBN13;
        public string Contents;
        public string Author;
        public int PageCount;

        public void Open()
        {
            Console.WriteLine("Book is opened");
        }

        public void Close()
        {
            Console.WriteLine("Book is closed");
        }
    }
}
