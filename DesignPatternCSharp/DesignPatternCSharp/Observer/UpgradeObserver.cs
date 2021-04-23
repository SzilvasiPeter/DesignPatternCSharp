using System;

using DesignPatternCSharp.Builder;

namespace DesignPatternCSharp.Observer
{
    internal class UpgradeObserver : IObserver
    {
        public void Update(ISubject subject)
        {
            if ((subject as Person).PremiumState == 1)
            {
                Console.WriteLine("Premium was upgraded!");
            }
        }
    }
}
