namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part01 Question01
            //Book book1 = new Book("1", "C# Programming", new string[] { "John Doe", "Jane Smith" }, new DateTime(2023, 10, 1), 29m);
            //Book book2 = new Book("2", "Learning C#", new string[] { "Alice Johnson" }, new DateTime(2022, 5, 15), 19.99m);
            //Book book3 = new Book("3", "Advanced C#", new string[] { "Bob Brown", "Charlie Davis" }, new DateTime(2021, 8, 20), 39.99m);
            //Book book4 = new Book("4", "C# for Beginners", new string[] { "Eve White" }, new DateTime(2020, 3, 10), 14.99m);

            //string title =BookFunctions.GetTitle(book1);
            //Console.WriteLine($"Title  : {title}");

            //string authors = BookFunctions.GetAuthors(book1);
            //Console.WriteLine($"Authors of {book1.Title} : {authors}");

            //decimal price = BookFunctions.GetPrice(book1);
            //Console.WriteLine($"Price  {price}"); 
            #endregion

            #region Second Question

            //Book[] books = new Book[] 
            //{
            //  new Book("1", "C# Programming", new string[] { "John Doe", "Jane Smith" }, new DateTime(2023, 10, 1), 29m),
            //  new Book("2", "Learning C#", new string[] { "Alice Johnson" }, new DateTime(2022, 5, 15), 19.99m)

            //};

            #region User-Defined Delegate
            //BookDelegate bookDelegate = BookFunctions.GetTitle;
            //Console.WriteLine("Titles : ");
            //LibraryEngine.ProcessBooks(books.ToList(), bookDelegate); 
            #endregion

            #region Func Delegate
            //Func<Book, string> titleFunc = BookFunctions.GetTitle;
            //Console.WriteLine("Titles : ");
            //LibraryEngine.ProcessBooks(books.ToList(),titleFunc); 
            #endregion

            #region Anonymous
            //BookDelegate anonymous = delegate (Book b) { return b?.ISBN ?? "Unkown"; };
            //Console.WriteLine("ISBNS : ");
            //LibraryEngine.ProcessBooks(books.ToList(),anonymous); 
            #endregion

            #region Lambda Expression
            //BookDelegate lambdaExpression = B => B?.PublicationDate.ToShortDateString() ?? "Unkown";
            //Console.WriteLine("Publication dates : ");
            //LibraryEngine.ProcessBooks(books.ToList(),lambdaExpression); 
            #endregion

            #endregion
        }
    }
}
