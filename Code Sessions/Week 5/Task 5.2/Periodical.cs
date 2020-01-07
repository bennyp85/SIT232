namespace Task_5._2
{
    public class Periodical : Item
    {
        public Periodical(string title, string publisher, string edition, int dewy) : base(title, publisher, dewy)
        {
            _Edition = edition;
            _Title = title;
            _Publisher = publisher;
            _Dewy = dewy;

        }

        private int _Dewy;
        private string _Publisher;
        private string _Title; 
        private string Author;
        

        private string _Edition;
        public int Edition { get; set; }

        public override string ToString() => $"{_Title}, {_Publisher}, {_Edition}, {_Dewy}";

    }
}