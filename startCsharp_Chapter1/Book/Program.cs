using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    class Book
    {
        public string Title;
        public decimal ISBN13;
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

        public void WriteIf(bool output, string txt)
        {
            if (output == false)
            {
                return;
            }

            Console.WriteLine(txt);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book();
            book1.Open();
            book1.Close();
            book1.WriteIf(true, "sex");
            book1.WriteIf(false, "sex");
        }
    }
}
