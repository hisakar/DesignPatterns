using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.ObserverPattern.Abstracts
{
    public interface IObserver
    {
        int Id { get; set; }
        void Update();
    }
}
