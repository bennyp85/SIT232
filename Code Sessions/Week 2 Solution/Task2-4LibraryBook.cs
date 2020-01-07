

namespace Task2_4
{
    class LibraryBook
    {
        // encapsulate attribute variables
        private string _CallNumber;
        private string _Title;
        private string _Author;

        // abtract properties
        public string CallNumber
        {
            get { return _CallNumber; }
            set { _CallNumber = value; }
        }

        public string Title
        {
            get { return _Title;  }
            set { _Title = value; }
        }

        public string Author
        {
            get { return _Author; }
            set { _Author = value; }
        }        
        
        // custom constructor
        public LibraryBook(string callNumber, string title, string author)
        {
            _CallNumber = callNumber;
            _Title = title;
            _Author = author;
        }

    }
}
