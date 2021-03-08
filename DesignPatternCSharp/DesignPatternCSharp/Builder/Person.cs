using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternCSharp.Builder
{
    internal class Person
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public bool HasPremium { get; set; }

        public override string ToString()
        {
            string personString = String.Format("{0}({1}) {2}", Name, Age, HasPremiumString());
            personString += Environment.NewLine;

            return personString;
        }

        public string Separate()
        {
            return ToString() + "########################";
        }

        public string HasPremiumString()
        {
            return HasPremium ? "has premium" : "has no premium";
        }
    }
}
