using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public class Book
    {
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string[] Authors { get; set; }
        public DateTime PublicationDate { get; set; }
        public decimal Price { get; set; }

        public Book(string _ISBN, string _Title, string[] _Authors, DateTime _PublicationDate, decimal _Price)
        {
            ISBN = _ISBN;
            Title = _Title;
            Authors = _Authors;
            PublicationDate = _PublicationDate;
            Price = _Price;
        }

        public override string ToString()
        {
            return $"ISBN : {ISBN} , Title : {Title} , Authors : {Authors} , Publication Date : {PublicationDate} , Price : {Price}";
        }
    }

    public delegate string BookDelegate(Book book);
    public class BookFunctions 
    {
        public static string GetTitle(Book B)
        {
            return B?.Title ?? "Unkown Title";
        }

        public static string GetAuthors(Book B) 
        {
            if (B?.Authors == null || B.Authors.Length == 0)
                return "No Authors";
            else
               return string.Join(", ", B.Authors); 
        }

        public static decimal GetPrice(Book B)
        {
            return B?.Price??0;
        }

    }

    public class LibraryEngine 
    {
        public static void ProcessBooks( List<Book> bList ,BookDelegate bookDelegate)
        {
            foreach (Book book in bList) 
            {   
                Console.WriteLine(bookDelegate(book));
            }
        }

        public static void ProcessBooks(List<Book> bList, Func<Book, string> processBook)
        {
            foreach (Book book in bList)
            {
                Console.WriteLine(processBook(book));
            }
        }
    }
}
