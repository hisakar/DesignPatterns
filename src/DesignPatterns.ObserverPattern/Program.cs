using System;
using System.Collections.Generic;
using DesignPatterns.ObserverPattern.Abstracts;
using DesignPatterns.ObserverPattern.Concretes;

namespace DesignPatterns.ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var chatRoom = new ChatRoom();

            var userFromMobile = new UserFromCellPhone(chatRoom);
            var userFromDesktop = new UserFromDesktop(chatRoom);
            var userFromWeb = new UserFromWeb(chatRoom);

            var observerList = new List<IObserver> { userFromWeb, userFromDesktop, userFromMobile };

            chatRoom.Add(observerList);

            chatRoom.SetState("state 1");

            userFromWeb.WriteLastMessageToConsole();
            userFromDesktop.WriteLastMessageToConsole();
            userFromMobile.WriteLastMessageToConsole();

            chatRoom.SetState("state 2");

            userFromWeb.WriteMessagesToConsole();
            userFromDesktop.WriteMessagesToConsole();
            userFromMobile.WriteMessagesToConsole();

            var removedObserverList = new List<IObserver> { userFromWeb, userFromDesktop };

            chatRoom.Remove(removedObserverList);

            chatRoom.SetState("state 3");

            userFromWeb.WriteMessagesToConsole();
            userFromDesktop.WriteMessagesToConsole();
            userFromMobile.WriteMessagesToConsole();

            userFromWeb.WriteLastMessageToConsole();
            userFromDesktop.WriteLastMessageToConsole();
            userFromMobile.WriteLastMessageToConsole();

        }
    }
}
