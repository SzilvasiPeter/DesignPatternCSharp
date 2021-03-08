using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternCSharp.Observer
{
    interface ISubject
    {
        void Attach(IObserver observer);

        void Detach(IObserver observer);

        void Notify();
    }
}
