namespace Task_5._2
{
    public class Book : Item
    {
        public Book(string author, string title, string publisher, int dewy) : base(title, publisher, dewy)
        {
            _Author = author;
            _Title = title;
            _Publisher = publisher;
            _Dewy = dewy;

        }

        private int _Dewy;
        private string _Publisher;
        private string _Title; 
        private string Author;
        public string _Author { get; set; }

        public override string ToString() => $"{_Author}, {_Title}, {_Publisher}, {_Dewy}";
    }
}