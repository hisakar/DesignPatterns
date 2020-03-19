using System;
using System.Collections.Generic;
using System.Text;
using DesignPatterns.ObserverPattern.Abstracts;

namespace DesignPatterns.ObserverPattern.Concretes
{
   public  class UserFromDesktop:IObserver
    {
        public int Id { get; set; }

        public ChatRoom ChatRoom;

        public IList<string> Messages { get; set; }

        public string LastMessage { get; set; }

        public UserFromDesktop(ChatRoom chatRoom,int id)
        {
            Id = id;
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
                Console.WriteLine($"Written from DESKTOP ==> {message}");
            }
        }

        public void WriteLastMessageToConsole()
        {
            Console.WriteLine($"Written from DESKTOP ==> {LastMessage}");
        }
    }
}
