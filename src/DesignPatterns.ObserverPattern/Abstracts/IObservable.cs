using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.ObserverPattern.Abstracts
{
    public interface IObservable
    {
        IList<IObserver> Observers { get; set; }

        void Add(IList<IObserver> observers);
        
        void Remove(IList<IObserver> observers);

        void Notify();
    }
}
