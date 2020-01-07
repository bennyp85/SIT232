namespace TelephoneContact
{
    class Person
    {
        // encapsulate attribute variables
        private string _FamilyName;
        private string _GivenName;
        private string _TelephoneNumber;

        // abstract properties
        public string FamilyName
        {
            get { return _FamilyName; }
            set { _FamilyName = value; }
        }


        public string GivenName
        {
            get { return _GivenName; }
            set { _GivenName = value; }
        }


        public string TelephoneNumber
        {
            get { return _TelephoneNumber; }
            set { _TelephoneNumber = value; }
        }

        // custom constructor 
        public Person(string familyName, string givenName, string telephoneNumber)
        {
            _FamilyName = familyName;
            _GivenName = givenName;
            _TelephoneNumber = telephoneNumber;
        }

       
    }
}
