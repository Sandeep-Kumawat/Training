using System;

namespace BookDelegateDemo
{
    
    class Program
    {
        static void Main(string[] args)
        {
            BookDB bookDB = new BookDB();
            bookDB.AddBook("The C Programing", "Sandeep", 400, true);
            bookDB.AddBook("The JAVA Programing", "Ritik", 300, true);
            bookDB.AddBook("The C# Programing", "Pradeep", 200, false);

            ProcessBookCallbackDelegate d = new ProcessBookCallbackDelegate(SellBook);
            d += RentBook;
            d += PrintPrice;
            d += PrintTitle;
            bookDB.ProcessPaperbackBooks(d);
           

        }
        static void PrintTitle(Book b)
        {
            Console.WriteLine($"{b.Title}");
        }
        static void PrintPrice(Book b)
        {
            Console.WriteLine($"{b.Price}");
        }


        static void SellBook(Book b)
        {
            Console.WriteLine($"Title Sold=: {b.Title}");
        }
        static void RentBook(Book b)
        {
            Console.WriteLine($"Title Rent=: {b.Title}");
        }

    }
}
