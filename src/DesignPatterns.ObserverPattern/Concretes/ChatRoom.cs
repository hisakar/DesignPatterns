using System;
using System.Collections.Generic;
using System.Text;
using DesignPatterns.ObserverPattern.Abstracts;

namespace DesignPatterns.ObserverPattern.Concretes
{
    public class ChatRoom : IObservable
    {
        public IList<IObserver> Observers { get; set; }

        public IList<string> Messages { get; set; }
       
        public string LastMessage { get; set; }

        public ChatRoom()
        {
            Observers = Observers ?? new List<IObserver>();
            Messages = Messages ?? new List<string>();
        }

        public void Add(IList<IObserver> observers)
        {
            foreach (var observer in observers)
            {
                Observers.Add(observer);
            }
        }

        public void Remove(IList<IObserver> observers)
        {
            foreach (var observer in observers)
            {
                Observers.Remove(observer);
            }
        }

        public void Notify()
        {
            foreach (var observer in Observers)
            {
                observer.Update();
            }
        }

        public void SetState(string message)
        {
            Messages.Add(message);
            LastMessage = message;
            Notify();
        }

        public string GetLastMessage()
        {
            return LastMessage;
        }

        public IList<string> GetMessages()
        {
            return Messages;
        }
    }
}
