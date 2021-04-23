using System;

namespace DesignPatternCSharp.Observer
{
    interface ISubject
    {
        void Attach(IObserver observer);

        void Detach(IObserver observer);

        void Notify();
    }
}
