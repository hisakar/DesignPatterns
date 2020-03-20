using System;
using System.Collections.Generic;
using System.Text;
using DesignPatterns.ObserverPattern.Abstracts;

namespace DesignPatterns.ObserverPattern.Concretes
{
    public class UserFromWeb:IObserver
    {

        public ChatRoom ChatRoom;

        public IList<string> Messages { get; set; }

        public string LastMessage { get; set; }

        public UserFromWeb(ChatRoom chatRoom)
        {
            ChatRoom = chatRoom;
            Messages = Messages ?? new List<string>();
        }

        public void Update()
        {
            LastMessage = ChatRoom.GetLastMessage();
            Messages = new List<string>(ChatRoom.GetMessages());
        }

        public void WriteMessagesToConsole()
        {
            foreach (var message in Messages)
            {
                Console.WriteLine($"Written from WEB ==> {message}");
            }
        }

        public void WriteLastMessageToConsole()
        {
            Console.WriteLine($"Written from WEB ==> {LastMessage}");
        }

    }
}
