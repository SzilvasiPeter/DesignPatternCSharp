using DesignPatternCSharp.Adapter;
using DesignPatternCSharp.Builder;
using DesignPatternCSharp.Observer;
using System;

namespace DesignPatternCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Builder

            Console.WriteLine("Buillder");
            Console.WriteLine();

            PersonBuilder builder = new PersonBuilder();
            builder.AddName("Peter");
            builder.AddAge(25);
            builder.PremiumOn();

            Person personWithPremium = builder.GetPerson();
            Console.WriteLine(personWithPremium);

            builder.PremiumOff();
            Person personWithoutPremium = builder.GetPerson();
            Console.WriteLine(personWithoutPremium);
            Console.WriteLine();

            #endregion

            #region Adapter

            Console.WriteLine("Adapter");
            Console.WriteLine();

            Person personAdaptee = new Person() { Name = "Peter", Age = 25 };
            Console.WriteLine(personAdaptee.Separate());

            ISeparator separetor = new PersonAdapter(personAdaptee);
            Console.WriteLine(separetor.Separate());
            Console.WriteLine();

            #endregion

            #region Observer

            Console.WriteLine("Observer");
            Console.WriteLine();

            Person personSubject = new Person();
            IObserver downgradeObserver = new DowngradeObserver();
            IObserver upgradeObserver = new UpgradeObserver();
            personSubject.Attach(downgradeObserver);
            personSubject.Attach(upgradeObserver);

            personSubject.HasPremium = true;
            personSubject.HasPremium = false;

            personSubject.Detach(upgradeObserver);
            personSubject.HasPremium = true;
            Console.WriteLine();

            #endregion
        }
    }
}
