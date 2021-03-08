using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternCSharp.Builder
{
    internal class PersonBuilder : IBuilder
    {
        public PersonBuilder()
        {
            Reset();
        }

        public void Reset()
        {
            myPerson = new Person();
        }

        public void AddAge(int age)
        {
            myPerson.Age = age;
        }

        public void AddName(string name)
        {
            myPerson.Name = name;
        }

        public void PremiumOff()
        {
            myPerson.HasPremium = false;
        }

        public void PremiumOn()
        {
            myPerson.HasPremium = true;
        }

        public Person GetPerson()
        {
            return myPerson;
        }

        private Person myPerson;
    }
}
