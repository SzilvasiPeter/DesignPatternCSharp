using DesignPatternCSharp.Adapter;
using DesignPatternCSharp.Builder;
using System;

namespace DesignPatternCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Builder
            PersonBuilder builder = new PersonBuilder();
            builder.AddName("Peter");
            builder.AddAge(25);
            builder.PremiumOn();

            Person personWithPremium = builder.GetPerson();
            Console.WriteLine(personWithPremium);

            builder.PremiumOff();
            Person personWithoutPremium = builder.GetPerson();
            Console.WriteLine(personWithoutPremium);
            #endregion

            #region Adapter
            Person personAdaptee = new Person() { Name = "Peter", Age = 25 };
            Console.WriteLine(personAdaptee.Separate());

            ISeparetor separetor = new PersonAdapter(personAdaptee);
            Console.WriteLine(separetor.Separate());
            #endregion
        }
    }
}
