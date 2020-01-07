/*************************************************************
** File: Person.cs
** Author/s: Justin Rough
** Description:
**     A simple Person class containing family and given name
** attributes and a ToString method to return a textual
** representation of current object state.
*************************************************************/
using System;

namespace ToStringDemo
{
    class Person
    {
        public Person(string givenName, string familyName)
        {
            _GivenName = givenName;
            _FamilyName = familyName;
        }

        private string _FamilyName;
        public string FamilyName
        {
            get { return _FamilyName; }
            set { _FamilyName = value; }
        }

        private string _GivenName;
        public string GivenName
        {
            get { return _GivenName; }
            set { _GivenName = value; }
        }

        public override string ToString()
        {
            return string.Format("{0}, {1}", _FamilyName, _GivenName);
        }
    }
}
