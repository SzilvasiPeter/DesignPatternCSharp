using System;

using DesignPatternCSharp.Builder;

namespace DesignPatternCSharp.Adapter
{
    class PersonAdapter : ISeparator
    {
        public PersonAdapter(Person person)
        {
            myPerson = person;
        }

        public string Separate()
        {
            return myPerson.ToString() + "*********************";
        }

        private readonly Person myPerson;
    }
}
