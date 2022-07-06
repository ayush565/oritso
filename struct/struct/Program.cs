using System;
namespace structExample
{
    public struct Book
    {
        public string Title;
        public string Author;
        public double price;
        public short year;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Book myBook = new Book();
            myBook.Title = "C#";
            myBook.Author = "xyz";
            myBook.price = 10000.00;
            myBook.year = 2017;


            Console.WriteLine($"Book {myBook.Title} was written by {myBook.Author}" +
               $" in {myBook.year}. Price is {myBook.price}");

            Console.ReadKey();
        }
    }
}