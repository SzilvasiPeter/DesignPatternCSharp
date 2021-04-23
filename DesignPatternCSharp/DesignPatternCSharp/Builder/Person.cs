using System;
using System.Collections.Generic;

using DesignPatternCSharp.Observer;

namespace DesignPatternCSharp.Builder
{
    internal class Person : ISubject
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public bool HasPremium
        {
            get
            {
                return myHasPremium;
            }
            set
            {
                if(myHasPremium == true && value == false)
                {
                    PremiumState = -1;
                }
                else if(myHasPremium == false && value == true)
                {
                    PremiumState = 1;
                }

                myHasPremium = value;
                Notify();
            }
        }

        public int PremiumState { get; set; }

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

        public void Attach(IObserver observer)
        {
            Console.WriteLine("Subject: Attached an observer.");
            myObservers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            myObservers.Remove(observer);
            Console.WriteLine("Subject: Detached an observer.");
        }

        public void Notify()
        {
            Console.WriteLine("Subject: Notifying observers...");

            foreach (var observer in myObservers)
            {
                observer.Update(this);
            }
        }

        private bool myHasPremium;

        private List<IObserver> myObservers = new List<IObserver>();
    }
}
