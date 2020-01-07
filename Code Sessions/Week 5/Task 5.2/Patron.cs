using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Task_5._2
{
    public class Patron
    {
        private static List<Item> _items;

        public ReadOnlyCollection<Item> Items => _items.AsReadOnly();

        public Patron(string name)
        {
            _Name = name;
            _items = new List<Item>();
        }

        private string _Name;
        public string Name { get; set; }

        public static int numOfBorrows { get; set; }
        
        public void BorrowBook(Item book)
        {
            _items.Add(book);
            numOfBorrows += 1;
        }
        
        public void BorrowPeriodical(Item periodical)
        {
            _items.Add(periodical);
            numOfBorrows += 1;
        }

        public override string ToString() => $"{_Name}";
    }
}