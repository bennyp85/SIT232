using System.Security.AccessControl;

namespace Task_5._2
{
    public class Item
    {
        public Item(string title, string publisher, int dewy)
        {
            _Title = title;
            _Publisher = publisher;
            _Dewy = dewy;
        }

        private string _Title;
        public string Title { get; set; }

        private string _Publisher;
        public string Publisher { get; set; }

        private int _Dewy;
        public int Dewy { get; set; }
    }
}