using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralPattern.Mediator
{
    // Colleague interface
    public abstract class User
    {
        protected IChatRoom chatRoom;
        public string Username { get; }

        public User(string username, IChatRoom chatRoom)
        {
            Username = username;
            this.chatRoom = chatRoom;
        }

        public abstract void ReceiveMessage(string message);
        public abstract void SendMessage(string message);
    }
}
