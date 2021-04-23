using System;

namespace DesignPatternCSharp.Observer
{
    interface IObserver
    {
        void Update(ISubject subject);
    }
}
