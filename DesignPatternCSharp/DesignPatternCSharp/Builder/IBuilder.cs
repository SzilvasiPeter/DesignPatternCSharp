using System;
using System.Collections.Generic;
using System.Text;

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
