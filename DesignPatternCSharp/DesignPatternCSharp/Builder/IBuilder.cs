using System;

namespace DesignPatternCSharp.Builder
{
    interface IBuilder
    {
        void AddName(string name);

        void AddAge(int age);

        void PremiumOn();

        void PremiumOff();
    }
}
