using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Task_4._1
{
    internal class Program
    {
//
        public static void DisplayOrder(Order order)
        {
            Console.WriteLine(order.ToString());

            foreach (var book in order.Books)
            {
                Console.WriteLine(book.ToString());
            }
        }
        
        public static void Main(string[] args)
        {
            Book book1 = new Book("Ben", "MyBook", "Ben's Publishing", 2020);
            Book book2 = new Book("Steve", "His Book", "Steve's Publishing", 1985);
            
            Order order1 = new Order("Elaine");
            order1.Add(book1);
            DisplayOrder(order1);
            Order order2 = new Order();
            order2.Add(book2); 
            DisplayOrder(order2);
            Order order3 = new Order(order1);
            DisplayOrder(order3);
            
        }
    }

    class Book
    {
        private string _author;
        private string _title;
        private string _publisher;
        private int _year;

        public Book(string author, string title, string publisher, int year)
        {
            _author = author;
            _title = title;
            _publisher = publisher;
            _year = year;
        }

        public string Author
        {
            get => _author;
            set => _author = value;
        }

        public string Title
        {
            get => _title;
            set => _title = value;
        }

        public string Publisher
        {
            get => _publisher;
            set => _publisher = value;
        }

        public int Year
        {
            get => _year;
            set => _year = value;
        }

        public override string ToString()
        {
            return $"-- {_author}, {_title}, {_publisher}, {_year}";
        }
    }

    class Order
    {
        private string _customer;
        private const string DEFAULT_CUSTOMER = "UNKNOWN";
        private List<Book> _books;

        public ReadOnlyCollection<Book> Books => _books.AsReadOnly();

        public Order() : this(DEFAULT_CUSTOMER)
        {
        }

        public string Customer
        {
            get => _customer;
        }

        public Order(string customer)
        {
            _customer = customer;
            _books = new List<Book>();
        }

        public Order(Order source)
        {
            _customer = source.Customer;
            _books = new List<Book>();
            foreach (var b in source._books)
            {
                _books.Add(b);
            }
        }

        public void Add(Book book)
        {
            _books.Add(book);
        }

        public override string ToString() => $"-- {_customer} has {_books.Count} books";
    }
}