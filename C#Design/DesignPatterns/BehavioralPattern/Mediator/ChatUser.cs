using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPattern.Mediator
{
    // Concrete Colleague
    public class ChatUser : User
    {
        public ChatUser(string username, IChatRoom chatRoom) : base(username, chatRoom) { }

        public override void ReceiveMessage(string message)
        {
            Console.WriteLine($"{Username} received message: {message}");
        }

        public override void SendMessage(string message)
        {
            Console.WriteLine($"{Username} sending message: {message}");
            chatRoom.SendMessage(message, this);
        }
    }
}
