using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternCSharp.Observer
{
    interface IObserver
    {
        void Update(ISubject subject);
    }
}
